using System;
using System.Collections.Generic;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Users;

public struct InputUser : IEquatable<InputUser>
{
	public struct ControlSchemeChangeSyntax
	{
		internal int m_UserIndex;

		public ControlSchemeChangeSyntax AndPairRemainingDevices()
		{
			return default(ControlSchemeChangeSyntax);
		}
	}

	[Flags]
	internal enum UserFlags
	{
		BindToAllDevices = 1,
		UserAccountSelectionInProgress = 2
	}

	private struct UserData
	{
		public InputUserAccountHandle? platformUserAccountHandle;

		public string platformUserAccountName;

		public string platformUserAccountId;

		public int deviceCount;

		public int deviceStartIndex;

		public IInputActionCollection actions;

		public InputControlScheme? controlScheme;

		public InputControlScheme.MatchResult controlSchemeMatch;

		public int lostDeviceCount;

		public int lostDeviceStartIndex;

		public UserFlags flags;
	}

	private struct CompareDevicesByUserAccount : IComparer<InputDevice>
	{
		public InputUserAccountHandle platformUserAccountHandle;

		public int Compare(InputDevice x, InputDevice y)
		{
			return 0;
		}

		private static InputUserAccountHandle? GetUserAccountHandleForDevice(InputDevice device)
		{
			return null;
		}
	}

	private struct OngoingAccountSelection
	{
		public InputDevice device;

		public uint userId;
	}

	private struct GlobalState
	{
		internal int pairingStateVersion;

		internal uint lastUserId;

		internal int allUserCount;

		internal int allPairedDeviceCount;

		internal int allLostDeviceCount;

		internal InputUser[] allUsers;

		internal UserData[] allUserData;

		internal InputDevice[] allPairedDevices;

		internal InputDevice[] allLostDevices;

		internal InlinedArray<OngoingAccountSelection> ongoingAccountSelections;

		internal CallbackArray<Action<InputUser, InputUserChange, InputDevice>> onChange;

		internal CallbackArray<Action<InputControl, InputEventPtr>> onUnpairedDeviceUsed;

		internal CallbackArray<Func<InputDevice, InputEventPtr, bool>> onPreFilterUnpairedDeviceUsed;

		internal Action<object, InputActionChange> actionChangeDelegate;

		internal Action<InputDevice, InputDeviceChange> onDeviceChangeDelegate;

		internal Action<InputEventPtr, InputDevice> onEventDelegate;

		internal bool onActionChangeHooked;

		internal bool onDeviceChangeHooked;

		internal bool onEventHooked;

		internal int listenForUnpairedDeviceActivity;
	}

	public const uint InvalidId = 0u;

	private uint m_Id;

	private static GlobalState s_GlobalState;

	public bool valid => false;

	public int index => 0;

	public uint id => 0u;

	public InputUserAccountHandle? platformUserAccountHandle => null;

	public string platformUserAccountName => null;

	public string platformUserAccountId => null;

	public ReadOnlyArray<InputDevice> pairedDevices => default(ReadOnlyArray<InputDevice>);

	public ReadOnlyArray<InputDevice> lostDevices => default(ReadOnlyArray<InputDevice>);

	public IInputActionCollection actions => null;

	public InputControlScheme? controlScheme => null;

	public InputControlScheme.MatchResult controlSchemeMatch => default(InputControlScheme.MatchResult);

	public bool hasMissingRequiredDevices => false;

	public static ReadOnlyArray<InputUser> all => default(ReadOnlyArray<InputUser>);

	public static int listenForUnpairedDeviceActivity
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static event Action<InputUser, InputUserChange, InputDevice> onChange
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<InputControl, InputEventPtr> onUnpairedDeviceUsed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Func<InputDevice, InputEventPtr, bool> onPrefilterUnpairedDeviceActivity
	{
		add
		{
		}
		remove
		{
		}
	}

	public override string ToString()
	{
		return null;
	}

	public void AssociateActionsWithUser(IInputActionCollection actions)
	{
	}

	public ControlSchemeChangeSyntax ActivateControlScheme(string schemeName)
	{
		return default(ControlSchemeChangeSyntax);
	}

	private bool TryFindControlScheme(string schemeName, out InputControlScheme scheme)
	{
		scheme = default(InputControlScheme);
		return false;
	}

	internal void FindControlScheme(string schemeName, out InputControlScheme scheme)
	{
		scheme = default(InputControlScheme);
	}

	public ControlSchemeChangeSyntax ActivateControlScheme(InputControlScheme scheme)
	{
		return default(ControlSchemeChangeSyntax);
	}

	private void ActivateControlSchemeInternal(int userIndex, InputControlScheme scheme)
	{
	}

	public void UnpairDevice(InputDevice device)
	{
	}

	public void UnpairDevices()
	{
	}

	private static void RemoveLostDevicesForUser(int userIndex)
	{
	}

	public void UnpairDevicesAndRemoveUser()
	{
	}

	public static InputControlList<InputDevice> GetUnpairedInputDevices()
	{
		return default(InputControlList<InputDevice>);
	}

	public static int GetUnpairedInputDevices(ref InputControlList<InputDevice> list)
	{
		return 0;
	}

	public static InputUser? FindUserPairedToDevice(InputDevice device)
	{
		return null;
	}

	public static InputUser? FindUserByAccount(InputUserAccountHandle platformUserAccountHandle)
	{
		return null;
	}

	public static InputUser CreateUserWithoutPairedDevices()
	{
		return default(InputUser);
	}

	public static InputUser PerformPairingWithDevice(InputDevice device, InputUser user = default(InputUser), InputUserPairingOptions options = InputUserPairingOptions.None)
	{
		return default(InputUser);
	}

	private static bool InitiateUserAccountSelection(int userIndex, InputDevice device, InputUserPairingOptions options)
	{
		return false;
	}

	public bool Equals(InputUser other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(InputUser left, InputUser right)
	{
		return false;
	}

	public static bool operator !=(InputUser left, InputUser right)
	{
		return false;
	}

	private static int AddUser()
	{
		return 0;
	}

	private static void RemoveUser(int userIndex)
	{
	}

	private static void Notify(int userIndex, InputUserChange change, InputDevice device)
	{
	}

	private static int TryFindUserIndex(uint userId)
	{
		return 0;
	}

	private static int TryFindUserIndex(InputUserAccountHandle platformHandle)
	{
		return 0;
	}

	private static int TryFindUserIndex(InputDevice device)
	{
		return 0;
	}

	private static void AddDeviceToUser(int userIndex, InputDevice device, bool asLostDevice = false, bool dontUpdateControlScheme = false)
	{
	}

	private static void RemoveDeviceFromUser(int userIndex, InputDevice device, bool asLostDevice = false)
	{
	}

	private static void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing = false)
	{
	}

	private static long UpdatePlatformUserAccount(int userIndex, InputDevice device)
	{
		return 0L;
	}

	private static long QueryPairedPlatformUserAccount(InputDevice device, out InputUserAccountHandle? platformAccountHandle, out string platformAccountName, out string platformAccountId)
	{
		platformAccountHandle = null;
		platformAccountName = null;
		platformAccountId = null;
		return 0L;
	}

	private static bool InitiateUserAccountSelectionAtPlatformLevel(InputDevice device)
	{
		return false;
	}

	private static void OnActionChange(object obj, InputActionChange change)
	{
	}

	private static void OnDeviceChange(InputDevice device, InputDeviceChange change)
	{
	}

	private static int FindLostDevice(InputDevice device, int startIndex = 0)
	{
		return 0;
	}

	private static void OnEvent(InputEventPtr eventPtr, InputDevice device)
	{
	}

	internal static ISavedState SaveAndResetState()
	{
		return null;
	}

	private static void HookIntoActionChange()
	{
	}

	private static void UnhookFromActionChange()
	{
	}

	private static void HookIntoDeviceChange()
	{
	}

	private static void UnhookFromDeviceChange()
	{
	}

	private static void HookIntoEvents()
	{
	}

	private static void UnhookFromDeviceStateChange()
	{
	}

	private static void DisposeAndResetGlobalState()
	{
	}

	internal static void ResetGlobals()
	{
	}
}
