using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.Users;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/PlayerInput.html")]
[AddComponentMenu("Input/Player Input")]
[DisallowMultipleComponent]
public class PlayerInput : MonoBehaviour
{
	[Serializable]
	public class ActionEvent : UnityEvent<InputAction.CallbackContext>
	{
		[SerializeField]
		private string m_ActionId;

		[SerializeField]
		private string m_ActionName;

		public string actionId => null;

		public string actionName => null;

		public ActionEvent()
		{
		}

		public ActionEvent(InputAction action)
		{
		}

		public ActionEvent(Guid actionGUID, string name = null)
		{
		}
	}

	[Serializable]
	public class DeviceLostEvent : UnityEvent<PlayerInput>
	{
	}

	[Serializable]
	public class DeviceRegainedEvent : UnityEvent<PlayerInput>
	{
	}

	[Serializable]
	public class ControlsChangedEvent : UnityEvent<PlayerInput>
	{
	}

	public const string DeviceLostMessage = "OnDeviceLost";

	public const string DeviceRegainedMessage = "OnDeviceRegained";

	public const string ControlsChangedMessage = "OnControlsChanged";

	[SerializeField]
	[Tooltip("Input actions associated with the player.")]
	internal InputActionAsset m_Actions;

	[SerializeField]
	[Tooltip("Determine how notifications should be sent when an input-related event associated with the player happens.")]
	internal PlayerNotifications m_NotificationBehavior;

	[SerializeField]
	[Tooltip("UI InputModule that should have it's input actions synchronized to this PlayerInput's actions.")]
	internal InputSystemUIInputModule m_UIInputModule;

	[SerializeField]
	[Tooltip("Event that is triggered when the PlayerInput loses a paired device (e.g. its battery runs out).")]
	internal DeviceLostEvent m_DeviceLostEvent;

	[SerializeField]
	internal DeviceRegainedEvent m_DeviceRegainedEvent;

	[SerializeField]
	internal ControlsChangedEvent m_ControlsChangedEvent;

	[SerializeField]
	internal ActionEvent[] m_ActionEvents;

	[SerializeField]
	internal bool m_NeverAutoSwitchControlSchemes;

	[SerializeField]
	internal string m_DefaultControlScheme;

	[SerializeField]
	internal string m_DefaultActionMap;

	[SerializeField]
	internal int m_SplitScreenIndex;

	[Tooltip("Reference to the player's view camera. Note that this is only required when using split-screen and/or per-player UIs. Otherwise it is safe to leave this property uninitialized.")]
	[SerializeField]
	internal Camera m_Camera;

	[NonSerialized]
	private InputValue m_InputValueObject;

	[NonSerialized]
	internal InputActionMap m_CurrentActionMap;

	[NonSerialized]
	private int m_PlayerIndex;

	[NonSerialized]
	private bool m_InputActive;

	[NonSerialized]
	private bool m_Enabled;

	[NonSerialized]
	internal bool m_ActionsInitialized;

	[NonSerialized]
	private Dictionary<string, string> m_ActionMessageNames;

	[NonSerialized]
	private InputUser m_InputUser;

	[NonSerialized]
	private Action<InputAction.CallbackContext> m_ActionTriggeredDelegate;

	[NonSerialized]
	private CallbackArray<Action<PlayerInput>> m_DeviceLostCallbacks;

	[NonSerialized]
	private CallbackArray<Action<PlayerInput>> m_DeviceRegainedCallbacks;

	[NonSerialized]
	private CallbackArray<Action<PlayerInput>> m_ControlsChangedCallbacks;

	[NonSerialized]
	private CallbackArray<Action<InputAction.CallbackContext>> m_ActionTriggeredCallbacks;

	[NonSerialized]
	private Action<InputControl, InputEventPtr> m_UnpairedDeviceUsedDelegate;

	[NonSerialized]
	private Func<InputDevice, InputEventPtr, bool> m_PreFilterUnpairedDeviceUsedDelegate;

	[NonSerialized]
	private bool m_OnUnpairedDeviceUsedHooked;

	[NonSerialized]
	private Action<InputDevice, InputDeviceChange> m_DeviceChangeDelegate;

	[NonSerialized]
	private bool m_OnDeviceChangeHooked;

	internal static int s_AllActivePlayersCount;

	internal static PlayerInput[] s_AllActivePlayers;

	private static Action<InputUser, InputUserChange, InputDevice> s_UserChangeDelegate;

	private static int s_InitPairWithDevicesCount;

	private static InputDevice[] s_InitPairWithDevices;

	private static int s_InitPlayerIndex;

	private static int s_InitSplitScreenIndex;

	private static string s_InitControlScheme;

	internal static bool s_DestroyIfDeviceSetupUnsuccessful;

	public bool inputIsActive => false;

	[Obsolete("Use inputIsActive instead.")]
	public bool active => false;

	public int playerIndex => 0;

	public int splitScreenIndex => 0;

	public InputActionAsset actions
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string currentControlScheme => null;

	public string defaultControlScheme
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool neverAutoSwitchControlSchemes
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public InputActionMap currentActionMap
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string defaultActionMap
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public PlayerNotifications notificationBehavior
	{
		get
		{
			return default(PlayerNotifications);
		}
		set
		{
		}
	}

	public ReadOnlyArray<ActionEvent> actionEvents
	{
		get
		{
			return default(ReadOnlyArray<ActionEvent>);
		}
		set
		{
		}
	}

	public DeviceLostEvent deviceLostEvent => null;

	public DeviceRegainedEvent deviceRegainedEvent => null;

	public ControlsChangedEvent controlsChangedEvent => null;

	public Camera camera
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputSystemUIInputModule uiInputModule
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputUser user => default(InputUser);

	public ReadOnlyArray<InputDevice> devices => default(ReadOnlyArray<InputDevice>);

	public bool hasMissingRequiredDevices => false;

	public static ReadOnlyArray<PlayerInput> all => default(ReadOnlyArray<PlayerInput>);

	public static bool isSinglePlayer => false;

	public event Action<InputAction.CallbackContext> onActionTriggered
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<PlayerInput> onDeviceLost
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<PlayerInput> onDeviceRegained
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<PlayerInput> onControlsChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public TDevice GetDevice<TDevice>() where TDevice : InputDevice
	{
		return null;
	}

	public void ActivateInput()
	{
	}

	public void DeactivateInput()
	{
	}

	[Obsolete("Use DeactivateInput instead.")]
	public void PassivateInput()
	{
	}

	public bool SwitchCurrentControlScheme(params InputDevice[] devices)
	{
		return false;
	}

	public void SwitchCurrentControlScheme(string controlScheme, params InputDevice[] devices)
	{
	}

	public void SwitchCurrentActionMap(string mapNameOrId)
	{
	}

	public static PlayerInput GetPlayerByIndex(int playerIndex)
	{
		return null;
	}

	public static PlayerInput FindFirstPairedToDevice(InputDevice device)
	{
		return null;
	}

	public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1, string controlScheme = null, int splitScreenIndex = -1, InputDevice pairWithDevice = null)
	{
		return null;
	}

	public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1, string controlScheme = null, int splitScreenIndex = -1, params InputDevice[] pairWithDevices)
	{
		return null;
	}

	private static PlayerInput DoInstantiate(GameObject prefab)
	{
		return null;
	}

	private void InitializeActions()
	{
	}

	private void UninitializeActions()
	{
	}

	private void InstallOnActionTriggeredHook()
	{
	}

	private void UninstallOnActionTriggeredHook()
	{
	}

	private void OnActionTriggered(InputAction.CallbackContext context)
	{
	}

	private void CacheMessageNames()
	{
	}

	private void ClearCaches()
	{
	}

	private void AssignUserAndDevices()
	{
	}

	private bool HaveBindingForDevice(InputDevice device)
	{
		return false;
	}

	private void UnassignUserAndDevices()
	{
	}

	private bool TryToActivateControlScheme(InputControlScheme controlScheme)
	{
		return false;
	}

	private void AssignPlayerIndex()
	{
	}

	private void OnEnable()
	{
	}

	private void StartListeningForUnpairedDeviceActivity()
	{
	}

	private void StopListeningForUnpairedDeviceActivity()
	{
	}

	private void StartListeningForDeviceChanges()
	{
	}

	private void StopListeningForDeviceChanges()
	{
	}

	private void OnDisable()
	{
	}

	public void DebugLogAction(InputAction.CallbackContext context)
	{
	}

	private void HandleDeviceLost()
	{
	}

	private void HandleDeviceRegained()
	{
	}

	private void HandleControlsChanged()
	{
	}

	private static void OnUserChange(InputUser user, InputUserChange change, InputDevice device)
	{
	}

	private static bool OnPreFilterUnpairedDeviceUsed(InputDevice device, InputEventPtr eventPtr)
	{
		return false;
	}

	private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr)
	{
	}

	private void OnDeviceChange(InputDevice device, InputDeviceChange change)
	{
	}

	private void SwitchControlSchemeInternal(ref InputControlScheme controlScheme, params InputDevice[] devices)
	{
	}
}
