using System;
using System.Collections.Generic;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public static class InputSystem
{
	private struct StateEventBuffer
	{
		public StateEvent stateEvent;

		public const int kMaxSize = 512;

		public unsafe fixed byte data[511];
	}

	private struct DeltaStateEventBuffer
	{
		public DeltaStateEvent stateEvent;

		public const int kMaxSize = 512;

		public unsafe fixed byte data[511];
	}

	internal const string kAssemblyVersion = "1.7.0";

	internal const string kDocUrl = "https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7";

	internal static InputManager s_Manager;

	internal static InputRemoting s_Remote;

	public static ReadOnlyArray<InputDevice> devices => default(ReadOnlyArray<InputDevice>);

	public static ReadOnlyArray<InputDevice> disconnectedDevices => default(ReadOnlyArray<InputDevice>);

	public static float pollingFrequency
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	internal static bool isProcessingEvents => false;

	public static InputEventListener onEvent
	{
		get
		{
			return default(InputEventListener);
		}
		set
		{
		}
	}

	public static IObservable<InputControl> onAnyButtonPress => null;

	public static InputSettings settings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static InputRemoting remoting => null;

	public static Version version => null;

	public static bool runInBackground
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static InputMetrics metrics => default(InputMetrics);

	public static event Action<string, InputControlLayoutChange> onLayoutChange
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<InputDevice, InputDeviceChange> onDeviceChange
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event InputDeviceCommandDelegate onDeviceCommand
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event InputDeviceFindControlLayoutDelegate onFindLayoutForDevice
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action onBeforeUpdate
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action onAfterUpdate
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action onSettingsChange
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<object, InputActionChange> onActionChange
	{
		add
		{
		}
		remove
		{
		}
	}

	public static void RegisterLayout(Type type, string name = null, InputDeviceMatcher? matches = null)
	{
	}

	public static void RegisterLayout<T>(string name = null, InputDeviceMatcher? matches = null) where T : InputControl
	{
	}

	public static void RegisterLayout(string json, string name = null, InputDeviceMatcher? matches = null)
	{
	}

	public static void RegisterLayoutOverride(string json, string name = null)
	{
	}

	public static void RegisterLayoutMatcher(string layoutName, InputDeviceMatcher matcher)
	{
	}

	public static void RegisterLayoutMatcher<TDevice>(InputDeviceMatcher matcher) where TDevice : InputDevice
	{
	}

	public static void RegisterLayoutBuilder(Func<InputControlLayout> buildMethod, string name, string baseLayout = null, InputDeviceMatcher? matches = null)
	{
	}

	public static void RegisterPrecompiledLayout<TDevice>(string metadata) where TDevice : InputDevice, new()
	{
	}

	public static void RemoveLayout(string name)
	{
	}

	public static string TryFindMatchingLayout(InputDeviceDescription deviceDescription)
	{
		return null;
	}

	public static IEnumerable<string> ListLayouts()
	{
		return null;
	}

	public static IEnumerable<string> ListLayoutsBasedOn(string baseLayout)
	{
		return null;
	}

	public static InputControlLayout LoadLayout(string name)
	{
		return null;
	}

	public static InputControlLayout LoadLayout<TControl>() where TControl : InputControl
	{
		return null;
	}

	public static string GetNameOfBaseLayout(string layoutName)
	{
		return null;
	}

	public static bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName)
	{
		return false;
	}

	public static void RegisterProcessor(Type type, string name = null)
	{
	}

	public static void RegisterProcessor<T>(string name = null)
	{
	}

	public static Type TryGetProcessor(string name)
	{
		return null;
	}

	public static IEnumerable<string> ListProcessors()
	{
		return null;
	}

	public static InputDevice AddDevice(string layout, string name = null, string variants = null)
	{
		return null;
	}

	public static TDevice AddDevice<TDevice>(string name = null) where TDevice : InputDevice
	{
		return null;
	}

	public static InputDevice AddDevice(InputDeviceDescription description)
	{
		return null;
	}

	public static void AddDevice(InputDevice device)
	{
	}

	public static void RemoveDevice(InputDevice device)
	{
	}

	public static void FlushDisconnectedDevices()
	{
	}

	public static InputDevice GetDevice(string nameOrLayout)
	{
		return null;
	}

	public static TDevice GetDevice<TDevice>() where TDevice : InputDevice
	{
		return null;
	}

	public static InputDevice GetDevice(Type type)
	{
		return null;
	}

	public static TDevice GetDevice<TDevice>(InternedString usage) where TDevice : InputDevice
	{
		return null;
	}

	public static TDevice GetDevice<TDevice>(string usage) where TDevice : InputDevice
	{
		return null;
	}

	public static InputDevice GetDeviceById(int deviceId)
	{
		return null;
	}

	public static List<InputDeviceDescription> GetUnsupportedDevices()
	{
		return null;
	}

	public static int GetUnsupportedDevices(List<InputDeviceDescription> descriptions)
	{
		return 0;
	}

	public static void EnableDevice(InputDevice device)
	{
	}

	public static void DisableDevice(InputDevice device, bool keepSendingEvents = false)
	{
	}

	public static bool TrySyncDevice(InputDevice device)
	{
		return false;
	}

	public static void ResetDevice(InputDevice device, bool alsoResetDontResetControls = false)
	{
	}

	[Obsolete("Use 'ResetDevice' instead.", false)]
	public static bool TryResetDevice(InputDevice device)
	{
		return false;
	}

	public static void PauseHaptics()
	{
	}

	public static void ResumeHaptics()
	{
	}

	public static void ResetHaptics()
	{
	}

	public static void SetDeviceUsage(InputDevice device, string usage)
	{
	}

	public static void SetDeviceUsage(InputDevice device, InternedString usage)
	{
	}

	public static void AddDeviceUsage(InputDevice device, string usage)
	{
	}

	public static void AddDeviceUsage(InputDevice device, InternedString usage)
	{
	}

	public static void RemoveDeviceUsage(InputDevice device, string usage)
	{
	}

	public static void RemoveDeviceUsage(InputDevice device, InternedString usage)
	{
	}

	public static InputControl FindControl(string path)
	{
		return null;
	}

	public static InputControlList<InputControl> FindControls(string path)
	{
		return default(InputControlList<InputControl>);
	}

	public static InputControlList<TControl> FindControls<TControl>(string path) where TControl : InputControl
	{
		return default(InputControlList<TControl>);
	}

	public static int FindControls<TControl>(string path, ref InputControlList<TControl> controls) where TControl : InputControl
	{
		return 0;
	}

	public static void QueueEvent(InputEventPtr eventPtr)
	{
	}

	public static void QueueEvent<TEvent>(ref TEvent inputEvent) where TEvent : struct, IInputEventTypeInfo
	{
	}

	public static void QueueStateEvent<TState>(InputDevice device, TState state, double time = -1.0) where TState : struct, IInputStateTypeInfo
	{
	}

	public static void QueueDeltaStateEvent<TDelta>(InputControl control, TDelta delta, double time = -1.0) where TDelta : struct
	{
	}

	public static void QueueConfigChangeEvent(InputDevice device, double time = -1.0)
	{
	}

	public static void QueueTextEvent(InputDevice device, char character, double time = -1.0)
	{
	}

	public static void Update()
	{
	}

	internal static void Update(InputUpdateType updateType)
	{
	}

	public static void RegisterInteraction(Type type, string name = null)
	{
	}

	public static void RegisterInteraction<T>(string name = null)
	{
	}

	public static Type TryGetInteraction(string name)
	{
		return null;
	}

	public static IEnumerable<string> ListInteractions()
	{
		return null;
	}

	public static void RegisterBindingComposite(Type type, string name)
	{
	}

	public static void RegisterBindingComposite<T>(string name = null)
	{
	}

	public static Type TryGetBindingComposite(string name)
	{
		return null;
	}

	public static void DisableAllEnabledActions()
	{
	}

	public static List<InputAction> ListEnabledActions()
	{
		return null;
	}

	public static int ListEnabledActions(List<InputAction> actions)
	{
		return 0;
	}

	static InputSystem()
	{
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void RunInitializeInPlayer()
	{
	}

	internal static void EnsureInitialized()
	{
	}

	private static void InitializeInPlayer(IInputRuntime runtime = null, InputSettings settings = null)
	{
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void RunInitialUpdate()
	{
	}

	private static void PerformDefaultPluginInitialization()
	{
	}
}
