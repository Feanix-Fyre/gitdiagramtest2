using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

internal class InputManager
{
	internal enum DeviceDisableScope
	{
		Everywhere = 0,
		InFrontendOnly = 1,
		TemporaryWhilePlayerIsInBackground = 2
	}

	[Serializable]
	internal struct AvailableDevice
	{
		public InputDeviceDescription description;

		public int deviceId;

		public bool isNative;

		public bool isRemoved;
	}

	private struct StateChangeMonitorTimeout
	{
		public InputControl control;

		public double time;

		public IInputStateChangeMonitor monitor;

		public long monitorIndex;

		public int timerIndex;
	}

	internal struct StateChangeMonitorListener
	{
		public InputControl control;

		public IInputStateChangeMonitor monitor;

		public long monitorIndex;

		public uint groupIndex;
	}

	internal struct StateChangeMonitorsForDevice
	{
		public MemoryHelpers.BitRegion[] memoryRegions;

		public StateChangeMonitorListener[] listeners;

		public DynamicBitfield signalled;

		public bool needToUpdateOrderingOfMonitors;

		public bool needToCompactArrays;

		public int count => 0;

		public void Add(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex)
		{
		}

		public void Remove(IInputStateChangeMonitor monitor, long monitorIndex, bool deferRemoval)
		{
		}

		public void Clear()
		{
		}

		public void CompactArrays()
		{
		}

		private void RemoveAt(int i)
		{
		}

		public void SortMonitorsByIndex()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CListControlLayouts_003Ed__75 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string basedOn;

		public string _003C_003E3__basedOn;

		public InputManager _003C_003E4__this;

		private InternedString _003CinternedBasedOn_003E5__2;

		private Dictionary<InternedString, Type>.Enumerator _003C_003E7__wrap2;

		private Dictionary<InternedString, string>.Enumerator _003C_003E7__wrap3;

		private Dictionary<InternedString, Func<InputControlLayout>>.Enumerator _003C_003E7__wrap4;

		string IEnumerator<string>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CListControlLayouts_003Ed__75(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		private void _003C_003Em__Finally2()
		{
		}

		private void _003C_003Em__Finally3()
		{
		}

		private void _003C_003Em__Finally4()
		{
		}

		private void _003C_003Em__Finally5()
		{
		}

		private void _003C_003Em__Finally6()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	internal int m_LayoutRegistrationVersion;

	private float m_PollingFrequency;

	internal InputControlLayout.Collection m_Layouts;

	private TypeTable m_Processors;

	private TypeTable m_Interactions;

	private TypeTable m_Composites;

	private int m_DevicesCount;

	private InputDevice[] m_Devices;

	private Dictionary<int, InputDevice> m_DevicesById;

	internal int m_AvailableDeviceCount;

	internal AvailableDevice[] m_AvailableDevices;

	internal int m_DisconnectedDevicesCount;

	internal InputDevice[] m_DisconnectedDevices;

	internal InputUpdateType m_UpdateMask;

	private InputUpdateType m_CurrentUpdate;

	internal InputStateBuffers m_StateBuffers;

	private CallbackArray<Action<InputDevice, InputDeviceChange>> m_DeviceChangeListeners;

	private CallbackArray<Action<InputDevice, InputEventPtr>> m_DeviceStateChangeListeners;

	private CallbackArray<InputDeviceFindControlLayoutDelegate> m_DeviceFindLayoutCallbacks;

	internal CallbackArray<InputDeviceCommandDelegate> m_DeviceCommandCallbacks;

	private CallbackArray<Action<string, InputControlLayoutChange>> m_LayoutChangeListeners;

	private CallbackArray<Action<InputEventPtr, InputDevice>> m_EventListeners;

	private CallbackArray<Action> m_BeforeUpdateListeners;

	private CallbackArray<Action> m_AfterUpdateListeners;

	private CallbackArray<Action> m_SettingsChangedListeners;

	private bool m_NativeBeforeUpdateHooked;

	private bool m_HaveDevicesWithStateCallbackReceivers;

	private bool m_HasFocus;

	private InputEventStream m_InputEventStream;

	private InputDeviceExecuteCommandDelegate m_DeviceFindExecuteCommandDelegate;

	private int m_DeviceFindExecuteCommandDeviceId;

	internal IInputRuntime m_Runtime;

	internal InputMetrics m_Metrics;

	internal InputSettings m_Settings;

	private bool m_ShouldMakeCurrentlyUpdatingDeviceCurrent;

	internal StateChangeMonitorsForDevice[] m_StateChangeMonitors;

	private InlinedArray<StateChangeMonitorTimeout> m_StateChangeMonitorTimeouts;

	public ReadOnlyArray<InputDevice> devices => default(ReadOnlyArray<InputDevice>);

	public TypeTable processors => default(TypeTable);

	public TypeTable interactions => default(TypeTable);

	public TypeTable composites => default(TypeTable);

	public InputMetrics metrics => default(InputMetrics);

	public InputSettings settings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputUpdateType updateMask
	{
		get
		{
			return default(InputUpdateType);
		}
		set
		{
		}
	}

	public InputUpdateType defaultUpdateType => default(InputUpdateType);

	public float pollingFrequency
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool isProcessingEvents => false;

	private bool gameIsPlaying => false;

	private bool gameHasFocus => false;

	private bool gameShouldGetInputRegardlessOfFocus => false;

	public event Action<InputDevice, InputDeviceChange> onDeviceChange
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<InputDevice, InputEventPtr> onDeviceStateChange
	{
		add
		{
		}
		remove
		{
		}
	}

	public event InputDeviceCommandDelegate onDeviceCommand
	{
		add
		{
		}
		remove
		{
		}
	}

	public event InputDeviceFindControlLayoutDelegate onFindControlLayoutForDevice
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<string, InputControlLayoutChange> onLayoutChange
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<InputEventPtr, InputDevice> onEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action onBeforeUpdate
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action onAfterUpdate
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action onSettingsChange
	{
		add
		{
		}
		remove
		{
		}
	}

	public void RegisterControlLayout(string name, Type type)
	{
	}

	public void RegisterControlLayout(string json, string name = null, bool isOverride = false)
	{
	}

	public void RegisterControlLayoutBuilder(Func<InputControlLayout> method, string name, string baseLayout = null)
	{
	}

	private void PerformLayoutPostRegistration(InternedString layoutName, InlinedArray<InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout = false, bool isOverride = false)
	{
	}

	public void RegisterPrecompiledLayout<TDevice>(string metadata) where TDevice : InputDevice, new()
	{
	}

	private void RecreateDevicesUsingLayout(InternedString layout, bool isKnownToBeDeviceLayout = false)
	{
	}

	private bool IsControlOrChildUsingLayoutRecursive(InputControl control, InternedString layout)
	{
		return false;
	}

	private bool IsControlUsingLayout(InputControl control, InternedString layout)
	{
		return false;
	}

	public void RegisterControlLayoutMatcher(string layoutName, InputDeviceMatcher matcher)
	{
	}

	public void RegisterControlLayoutMatcher(Type type, InputDeviceMatcher matcher)
	{
	}

	private void RecreateDevicesUsingLayoutWithInferiorMatch(InputDeviceMatcher deviceMatcher)
	{
	}

	private void RecreateDevice(InputDevice oldDevice, InternedString newLayout)
	{
	}

	private void AddAvailableDevicesMatchingDescription(InputDeviceMatcher matcher, InternedString layout)
	{
	}

	public void RemoveControlLayout(string name)
	{
	}

	public InputControlLayout TryLoadControlLayout(Type type)
	{
		return null;
	}

	public InputControlLayout TryLoadControlLayout(InternedString name)
	{
		return null;
	}

	public InternedString TryFindMatchingControlLayout(ref InputDeviceDescription deviceDescription, int deviceId = 0)
	{
		return default(InternedString);
	}

	private InternedString FindOrRegisterDeviceLayoutForType(Type type)
	{
		return default(InternedString);
	}

	private bool IsDeviceLayoutMarkedAsSupportedInSettings(InternedString layoutName)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CListControlLayouts_003Ed__75))]
	public IEnumerable<string> ListControlLayouts(string basedOn = null)
	{
		return null;
	}

	public int GetControls<TControl>(string path, ref InputControlList<TControl> controls) where TControl : InputControl
	{
		return 0;
	}

	public void SetDeviceUsage(InputDevice device, InternedString usage)
	{
	}

	public void AddDeviceUsage(InputDevice device, InternedString usage)
	{
	}

	public void RemoveDeviceUsage(InputDevice device, InternedString usage)
	{
	}

	private void NotifyUsageChanged(InputDevice device)
	{
	}

	public InputDevice AddDevice(Type type, string name = null)
	{
		return null;
	}

	public InputDevice AddDevice(string layout, string name = null, InternedString variants = default(InternedString))
	{
		return null;
	}

	private InputDevice AddDevice(InternedString layout, int deviceId, string deviceName = null, InputDeviceDescription deviceDescription = default(InputDeviceDescription), InputDevice.DeviceFlags deviceFlags = (InputDevice.DeviceFlags)0, InternedString variants = default(InternedString))
	{
		return null;
	}

	public void AddDevice(InputDevice device)
	{
	}

	public InputDevice AddDevice(InputDeviceDescription description)
	{
		return null;
	}

	public InputDevice AddDevice(InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName = null, int deviceId = 0, InputDevice.DeviceFlags deviceFlags = (InputDevice.DeviceFlags)0)
	{
		return null;
	}

	public InputDevice AddDevice(InputDeviceDescription description, InternedString layout, string deviceName = null, int deviceId = 0, InputDevice.DeviceFlags deviceFlags = (InputDevice.DeviceFlags)0)
	{
		return null;
	}

	public void RemoveDevice(InputDevice device, bool keepOnListOfAvailableDevices = false)
	{
	}

	public void FlushDisconnectedDevices()
	{
	}

	public void ResetDevice(InputDevice device, bool alsoResetDontResetControls = false, bool? issueResetCommand = null)
	{
	}

	public InputDevice TryGetDevice(string nameOrLayout)
	{
		return null;
	}

	public InputDevice GetDevice(string nameOrLayout)
	{
		return null;
	}

	public InputDevice TryGetDevice(Type layoutType)
	{
		return null;
	}

	public InputDevice TryGetDeviceById(int id)
	{
		return null;
	}

	public int GetUnsupportedDevices(List<InputDeviceDescription> descriptions)
	{
		return 0;
	}

	public void EnableOrDisableDevice(InputDevice device, bool enable, DeviceDisableScope scope = DeviceDisableScope.Everywhere)
	{
	}

	private unsafe void QueueEvent(InputEvent* eventPtr)
	{
	}

	public void QueueEvent(InputEventPtr ptr)
	{
	}

	public void QueueEvent<TEvent>(ref TEvent inputEvent) where TEvent : struct, IInputEventTypeInfo
	{
	}

	public void Update()
	{
	}

	public void Update(InputUpdateType updateType)
	{
	}

	internal void Initialize(IInputRuntime runtime, InputSettings settings)
	{
	}

	internal void Destroy()
	{
	}

	internal void InitializeData()
	{
	}

	internal void InstallRuntime(IInputRuntime runtime)
	{
	}

	internal void InstallGlobals()
	{
	}

	internal void UninstallGlobals()
	{
	}

	private void MakeDeviceNameUnique(InputDevice device)
	{
	}

	private static void ResetControlPathsRecursive(InputControl control)
	{
	}

	private void AssignUniqueDeviceId(InputDevice device)
	{
	}

	private void ReallocateStateBuffers()
	{
	}

	private void InitializeDefaultState(InputDevice device)
	{
	}

	private void InitializeDeviceState(InputDevice device)
	{
	}

	private void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor)
	{
	}

	private InputDevice TryMatchDisconnectedDevice(string deviceDescriptor)
	{
		return null;
	}

	private void InstallBeforeUpdateHookIfNecessary()
	{
	}

	private void RestoreDevicesAfterDomainReloadIfNecessary()
	{
	}

	private void WarnAboutDevicesFailingToRecreateAfterDomainReload()
	{
	}

	private void OnBeforeUpdate(InputUpdateType updateType)
	{
	}

	internal void ApplySettings()
	{
	}

	internal long ExecuteGlobalCommand<TCommand>(ref TCommand command) where TCommand : struct, IInputDeviceCommandInfo
	{
		return 0L;
	}

	internal void AddAvailableDevicesThatAreNowRecognized()
	{
	}

	private bool ShouldRunDeviceInBackground(InputDevice device)
	{
		return false;
	}

	internal void OnFocusChanged(bool focus)
	{
	}

	internal bool ShouldRunUpdate(InputUpdateType updateType)
	{
		return false;
	}

	private void OnUpdate(InputUpdateType updateType, ref InputEventBuffer eventBuffer)
	{
	}

	private void InvokeAfterUpdateCallback(InputUpdateType updateType)
	{
	}

	internal void DontMakeCurrentlyUpdatingDeviceCurrent()
	{
	}

	internal unsafe bool UpdateState(InputDevice device, InputEvent* eventPtr, InputUpdateType updateType)
	{
		return false;
	}

	internal unsafe bool UpdateState(InputDevice device, InputUpdateType updateType, void* statePtr, uint stateOffsetInDevice, uint stateSize, double internalTime, InputEventPtr eventPtr = default(InputEventPtr))
	{
		return false;
	}

	private unsafe void WriteStateChange(InputStateBuffers.DoubleBuffers buffers, int deviceIndex, ref InputStateBlock deviceStateBlock, uint stateOffsetInDevice, void* statePtr, uint stateSizeInBytes, bool flippedBuffers)
	{
	}

	private bool FlipBuffersForDeviceIfNecessary(InputDevice device, InputUpdateType updateType)
	{
		return false;
	}

	public void AddStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex)
	{
	}

	private void RemoveStateChangeMonitors(InputDevice device)
	{
	}

	public void RemoveStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex)
	{
	}

	public void AddStateChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex, int timerIndex)
	{
	}

	public void RemoveStateChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex, int timerIndex)
	{
	}

	private void SortStateChangeMonitorsIfNecessary(int deviceIndex)
	{
	}

	public void SignalStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor)
	{
	}

	public void FireStateChangeNotifications()
	{
	}

	private unsafe bool ProcessStateChangeMonitors(int deviceIndex, void* newStateFromEvent, void* oldStateOfDevice, uint newStateSizeInBytes, uint newStateOffsetInBytes)
	{
		return false;
	}

	internal unsafe void FireStateChangeNotifications(int deviceIndex, double internalTime, InputEvent* eventPtr)
	{
	}

	private void ProcessStateChangeMonitorTimeouts()
	{
	}
}
