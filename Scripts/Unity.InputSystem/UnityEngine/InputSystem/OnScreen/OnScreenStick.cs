using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Serialization;

namespace UnityEngine.InputSystem.OnScreen;

[AddComponentMenu("Input/On-Screen Stick")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/OnScreen.html#on-screen-sticks")]
public class OnScreenStick : OnScreenControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	public enum Behaviour
	{
		RelativePositionWithStaticOrigin = 0,
		ExactPositionWithStaticOrigin = 1,
		ExactPositionWithDynamicOrigin = 2
	}

	private const string kDynamicOriginClickable = "DynamicOriginClickable";

	[FormerlySerializedAs("movementRange")]
	[SerializeField]
	[Min(0f)]
	private float m_MovementRange;

	[Min(0f)]
	[SerializeField]
	[Tooltip("Defines the circular region where the onscreen control may have it's origin placed.")]
	private float m_DynamicOriginRange;

	[InputControl(layout = "Vector2")]
	[SerializeField]
	private string m_ControlPath;

	[SerializeField]
	[Tooltip("Choose how the onscreen stick will move relative to it's origin and the press position.\n\nRelativePositionWithStaticOrigin: The control's center of origin is fixed. The control will begin un-actuated at it's centered position and then move relative to the pointer or finger motion.\n\nExactPositionWithStaticOrigin: The control's center of origin is fixed. The stick will immediately jump to the exact position of the click or touch and begin tracking motion from there.\n\nExactPositionWithDynamicOrigin: The control's center of origin is determined by the initial press position. The stick will begin un-actuated at this center position and then track the current pointer or finger position.")]
	private Behaviour m_Behaviour;

	[SerializeField]
	[Tooltip("Set this to true to prevent cancellation of pointer events due to device switching. Cancellation will appear as the stick jumping back and forth between the pointer position and the stick center.")]
	private bool m_UseIsolatedInputActions;

	[SerializeField]
	[Tooltip("The action that will be used to detect pointer down events on the stick control. Note that if no bindings are set, default ones will be provided.")]
	private InputAction m_PointerDownAction;

	[SerializeField]
	[Tooltip("The action that will be used to detect pointer movement on the stick control. Note that if no bindings are set, default ones will be provided.")]
	private InputAction m_PointerMoveAction;

	private Vector3 m_StartPos;

	private Vector2 m_PointerDownPos;

	[NonSerialized]
	private List<RaycastResult> m_RaycastResults;

	[NonSerialized]
	private PointerEventData m_PointerEventData;

	public float movementRange
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float dynamicOriginRange
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool useIsolatedInputActions
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override string controlPathInternal
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Behaviour behaviour
	{
		get
		{
			return default(Behaviour);
		}
		set
		{
		}
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void Start()
	{
	}

	private void BeginInteraction(Vector2 pointerPosition, Camera uiCamera)
	{
	}

	private void MoveStick(Vector2 pointerPosition, Camera uiCamera)
	{
	}

	private void EndInteraction()
	{
	}

	private void OnPointerDown(InputAction.CallbackContext ctx)
	{
	}

	private void OnPointerMove(InputAction.CallbackContext ctx)
	{
	}

	private void OnPointerUp(InputAction.CallbackContext ctx)
	{
	}

	private Camera GetCameraFromCanvas()
	{
		return null;
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void DrawGizmoCircle(Vector2 center, float radius)
	{
	}

	private void UpdateDynamicOriginClickableArea()
	{
	}
}
