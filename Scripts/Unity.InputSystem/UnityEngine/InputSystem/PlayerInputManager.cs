using System;
using UnityEngine.Events;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

[AddComponentMenu("Input/Player Input Manager")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/PlayerInputManager.html")]
public class PlayerInputManager : MonoBehaviour
{
	[Serializable]
	public class PlayerJoinedEvent : UnityEvent<PlayerInput>
	{
	}

	[Serializable]
	public class PlayerLeftEvent : UnityEvent<PlayerInput>
	{
	}

	public const string PlayerJoinedMessage = "OnPlayerJoined";

	public const string PlayerLeftMessage = "OnPlayerLeft";

	[SerializeField]
	internal PlayerNotifications m_NotificationBehavior;

	[Tooltip("Set a limit for the maximum number of players who are able to join.")]
	[SerializeField]
	internal int m_MaxPlayerCount;

	[SerializeField]
	internal bool m_AllowJoining;

	[SerializeField]
	internal PlayerJoinBehavior m_JoinBehavior;

	[SerializeField]
	internal PlayerJoinedEvent m_PlayerJoinedEvent;

	[SerializeField]
	internal PlayerLeftEvent m_PlayerLeftEvent;

	[SerializeField]
	internal InputActionProperty m_JoinAction;

	[SerializeField]
	internal GameObject m_PlayerPrefab;

	[SerializeField]
	internal bool m_SplitScreen;

	[SerializeField]
	internal bool m_MaintainAspectRatioInSplitScreen;

	[SerializeField]
	[Tooltip("Explicitly set a fixed number of screens or otherwise allow the screen to be divided automatically to best fit the number of players.")]
	internal int m_FixedNumberOfSplitScreens;

	[SerializeField]
	internal Rect m_SplitScreenRect;

	[NonSerialized]
	private bool m_JoinActionDelegateHooked;

	[NonSerialized]
	private bool m_UnpairedDeviceUsedDelegateHooked;

	[NonSerialized]
	private Action<InputAction.CallbackContext> m_JoinActionDelegate;

	[NonSerialized]
	private Action<InputControl, InputEventPtr> m_UnpairedDeviceUsedDelegate;

	[NonSerialized]
	private CallbackArray<Action<PlayerInput>> m_PlayerJoinedCallbacks;

	[NonSerialized]
	private CallbackArray<Action<PlayerInput>> m_PlayerLeftCallbacks;

	public bool splitScreen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool maintainAspectRatioInSplitScreen => false;

	public int fixedNumberOfSplitScreens => 0;

	public Rect splitScreenArea => default(Rect);

	public int playerCount => 0;

	public int maxPlayerCount => 0;

	public bool joiningEnabled => false;

	public PlayerJoinBehavior joinBehavior
	{
		get
		{
			return default(PlayerJoinBehavior);
		}
		set
		{
		}
	}

	public InputActionProperty joinAction
	{
		get
		{
			return default(InputActionProperty);
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

	public PlayerJoinedEvent playerJoinedEvent => null;

	public PlayerLeftEvent playerLeftEvent => null;

	public GameObject playerPrefab
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static PlayerInputManager instance { get; private set; }

	internal static string[] messages => null;

	public event Action<PlayerInput> onPlayerJoined
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<PlayerInput> onPlayerLeft
	{
		add
		{
		}
		remove
		{
		}
	}

	public void EnableJoining()
	{
	}

	public void DisableJoining()
	{
	}

	internal void JoinPlayerFromUI()
	{
	}

	public void JoinPlayerFromAction(InputAction.CallbackContext context)
	{
	}

	public void JoinPlayerFromActionIfNotAlreadyJoined(InputAction.CallbackContext context)
	{
	}

	public PlayerInput JoinPlayer(int playerIndex = -1, int splitScreenIndex = -1, string controlScheme = null, InputDevice pairWithDevice = null)
	{
		return null;
	}

	public PlayerInput JoinPlayer(int playerIndex = -1, int splitScreenIndex = -1, string controlScheme = null, params InputDevice[] pairWithDevices)
	{
		return null;
	}

	private bool CheckIfPlayerCanJoin(int playerIndex = -1)
	{
		return false;
	}

	private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateSplitScreen()
	{
	}

	private bool IsDeviceUsableWithPlayerActions(InputDevice device)
	{
		return false;
	}

	private void ValidateInputActionAsset()
	{
	}

	internal void NotifyPlayerJoined(PlayerInput player)
	{
	}

	internal void NotifyPlayerLeft(PlayerInput player)
	{
	}
}
