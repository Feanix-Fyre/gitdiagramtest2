using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Serialization;

namespace UnityEngine.InputSystem.UI;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/UISupport.html#setting-up-ui-input")]
public class InputSystemUIInputModule : BaseInputModule
{
	private struct InputActionReferenceState
	{
		public int refCount;

		public bool enabledByInputModule;
	}

	public enum CursorLockBehavior
	{
		OutsideScreen = 0,
		ScreenCenter = 1
	}

	private const float kClickSpeed = 0.3f;

	[Tooltip("The Initial delay (in seconds) between an initial move action and a repeated move action.")]
	[SerializeField]
	[FormerlySerializedAs("m_RepeatDelay")]
	private float m_MoveRepeatDelay;

	[SerializeField]
	[FormerlySerializedAs("m_RepeatRate")]
	[Tooltip("The speed (in seconds) that the move action repeats itself once repeating (max 1 per frame).")]
	private float m_MoveRepeatRate;

	[Tooltip("Scales the Eventsystem.DragThreshold, for tracked devices, to make selection easier.")]
	private float m_TrackedDeviceDragThresholdMultiplier;

	[Tooltip("Transform representing the real world origin for tracking devices. When using the XR Interaction Toolkit, this should be pointing to the XR Rig's Transform.")]
	[SerializeField]
	private Transform m_XRTrackingOrigin;

	internal const float kPixelPerLine = 20f;

	[SerializeField]
	[HideInInspector]
	private InputActionAsset m_ActionsAsset;

	[SerializeField]
	[HideInInspector]
	private InputActionReference m_PointAction;

	[SerializeField]
	[HideInInspector]
	private InputActionReference m_MoveAction;

	[HideInInspector]
	[SerializeField]
	private InputActionReference m_SubmitAction;

	[HideInInspector]
	[SerializeField]
	private InputActionReference m_CancelAction;

	[SerializeField]
	[HideInInspector]
	private InputActionReference m_LeftClickAction;

	[SerializeField]
	[HideInInspector]
	private InputActionReference m_MiddleClickAction;

	[SerializeField]
	[HideInInspector]
	private InputActionReference m_RightClickAction;

	[SerializeField]
	[HideInInspector]
	private InputActionReference m_ScrollWheelAction;

	[SerializeField]
	[HideInInspector]
	private InputActionReference m_TrackedDevicePositionAction;

	[SerializeField]
	[HideInInspector]
	private InputActionReference m_TrackedDeviceOrientationAction;

	[SerializeField]
	private bool m_DeselectOnBackgroundClick;

	[SerializeField]
	private UIPointerBehavior m_PointerBehavior;

	[SerializeField]
	[HideInInspector]
	internal CursorLockBehavior m_CursorLockBehavior;

	private static Dictionary<InputAction, InputActionReferenceState> s_InputActionReferenceCounts;

	[NonSerialized]
	private bool m_ActionsHooked;

	[NonSerialized]
	private bool m_NeedToPurgeStalePointers;

	private Action<InputAction.CallbackContext> m_OnPointDelegate;

	private Action<InputAction.CallbackContext> m_OnMoveDelegate;

	private Action<InputAction.CallbackContext> m_OnLeftClickDelegate;

	private Action<InputAction.CallbackContext> m_OnRightClickDelegate;

	private Action<InputAction.CallbackContext> m_OnMiddleClickDelegate;

	private Action<InputAction.CallbackContext> m_OnScrollWheelDelegate;

	private Action<InputAction.CallbackContext> m_OnTrackedDevicePositionDelegate;

	private Action<InputAction.CallbackContext> m_OnTrackedDeviceOrientationDelegate;

	private Action<object> m_OnControlsChangedDelegate;

	[NonSerialized]
	private int m_CurrentPointerId;

	[NonSerialized]
	private int m_CurrentPointerIndex;

	[NonSerialized]
	internal UIPointerType m_CurrentPointerType;

	internal InlinedArray<int> m_PointerIds;

	internal InlinedArray<InputControl> m_PointerTouchControls;

	internal InlinedArray<PointerModel> m_PointerStates;

	private NavigationModel m_NavigationState;

	[NonSerialized]
	private GameObject m_LocalMultiPlayerRoot;

	public bool deselectOnBackgroundClick
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public UIPointerBehavior pointerBehavior
	{
		get
		{
			return default(UIPointerBehavior);
		}
		set
		{
		}
	}

	public CursorLockBehavior cursorLockBehavior
	{
		get
		{
			return default(CursorLockBehavior);
		}
		set
		{
		}
	}

	internal GameObject localMultiPlayerRoot
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float moveRepeatDelay
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float moveRepeatRate
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private bool explictlyIgnoreFocus => false;

	private bool shouldIgnoreFocus => false;

	[Obsolete("'repeatRate' has been obsoleted; use 'moveRepeatRate' instead. (UnityUpgradable) -> moveRepeatRate", false)]
	public float repeatRate
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Obsolete("'repeatDelay' has been obsoleted; use 'moveRepeatDelay' instead. (UnityUpgradable) -> moveRepeatDelay", false)]
	public float repeatDelay
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Transform xrTrackingOrigin
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float trackedDeviceDragThresholdMultiplier
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public InputActionReference point
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputActionReference scrollWheel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputActionReference leftClick
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputActionReference middleClick
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputActionReference rightClick
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputActionReference move
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputActionReference submit
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputActionReference cancel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputActionReference trackedDeviceOrientation
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputActionReference trackedDevicePosition
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete("'trackedDeviceSelect' has been obsoleted; use 'leftClick' instead.", true)]
	public InputActionReference trackedDeviceSelect
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputActionAsset actionsAsset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void ActivateModule()
	{
	}

	public override bool IsPointerOverGameObject(int pointerOrTouchId)
	{
		return false;
	}

	public RaycastResult GetLastRaycastResult(int pointerOrTouchId)
	{
		return default(RaycastResult);
	}

	private RaycastResult PerformRaycast(ExtendedPointerEventData eventData)
	{
		return default(RaycastResult);
	}

	private void ProcessPointer(ref PointerModel state)
	{
	}

	private bool PointerShouldIgnoreTransform(Transform t)
	{
		return false;
	}

	private void ProcessPointerMovement(ref PointerModel pointer, ExtendedPointerEventData eventData)
	{
	}

	private void ProcessPointerMovement(ExtendedPointerEventData eventData, GameObject currentPointerTarget)
	{
	}

	private void ProcessPointerButton(ref PointerModel.ButtonState button, PointerEventData eventData)
	{
	}

	private void ProcessPointerButtonDrag(ref PointerModel.ButtonState button, ExtendedPointerEventData eventData)
	{
	}

	private static void ProcessPointerScroll(ref PointerModel pointer, PointerEventData eventData)
	{
	}

	internal void ProcessNavigation(ref NavigationModel navigationState)
	{
	}

	private bool IsMoveAllowed(AxisEventData eventData)
	{
		return false;
	}

	private void SwapAction(ref InputActionReference property, InputActionReference newValue, bool actionsHooked, Action<InputAction.CallbackContext> actionCallback)
	{
	}

	public void AssignDefaultActions()
	{
	}

	public void UnassignActions()
	{
	}

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	private void ResetPointers()
	{
	}

	private bool HasNoActions()
	{
		return false;
	}

	private void EnableAllActions()
	{
	}

	private void DisableAllActions()
	{
	}

	private void EnableInputAction(InputActionReference inputActionReference)
	{
	}

	private void TryDisableInputAction(InputActionReference inputActionReference, bool isComponentDisabling = false)
	{
	}

	private int GetPointerStateIndexFor(int pointerOrTouchId)
	{
		return 0;
	}

	private ref PointerModel GetPointerStateForIndex(int index)
	{
		throw null;
	}

	private int GetDisplayIndexFor(InputControl control)
	{
		return 0;
	}

	private int GetPointerStateIndexFor(ref InputAction.CallbackContext context)
	{
		return 0;
	}

	private int GetPointerStateIndexFor(InputControl control, bool createIfNotExists = true)
	{
		return 0;
	}

	private int AllocatePointer(int pointerId, int displayIndex, int touchId, UIPointerType pointerType, InputControl control, InputDevice device, InputControl touchControl = null)
	{
		return 0;
	}

	private void SendPointerExitEventsAndRemovePointer(int index)
	{
	}

	private void RemovePointerAtIndex(int index)
	{
	}

	private void PurgeStalePointers()
	{
	}

	private static bool HaveControlForDevice(InputDevice device, InputActionReference actionReference)
	{
		return false;
	}

	private void OnPointCallback(InputAction.CallbackContext context)
	{
	}

	private bool IgnoreNextClick(ref InputAction.CallbackContext context, bool wasPressed)
	{
		return false;
	}

	private void OnLeftClickCallback(InputAction.CallbackContext context)
	{
	}

	private void OnRightClickCallback(InputAction.CallbackContext context)
	{
	}

	private void OnMiddleClickCallback(InputAction.CallbackContext context)
	{
	}

	private bool CheckForRemovedDevice(ref InputAction.CallbackContext context)
	{
		return false;
	}

	private void OnScrollCallback(InputAction.CallbackContext context)
	{
	}

	private void OnMoveCallback(InputAction.CallbackContext context)
	{
	}

	private void OnTrackedDeviceOrientationCallback(InputAction.CallbackContext context)
	{
	}

	private void OnTrackedDevicePositionCallback(InputAction.CallbackContext context)
	{
	}

	private void OnControlsChanged(object obj)
	{
	}

	private void FilterPointerStatesByType()
	{
	}

	public override void Process()
	{
	}

	public override int ConvertUIToolkitPointerId(PointerEventData sourcePointerData)
	{
		return 0;
	}

	private void HookActions()
	{
	}

	private void UnhookActions()
	{
	}

	private void SetActionCallbacks(bool install)
	{
	}

	private static void SetActionCallback(InputActionReference actionReference, Action<InputAction.CallbackContext> callback, bool install)
	{
	}

	private InputActionReference UpdateReferenceForNewAsset(InputActionReference actionReference)
	{
		return null;
	}
}
