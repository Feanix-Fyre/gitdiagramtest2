using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

internal class InputActionState : IInputStateChangeMonitor, ICloneable, IDisposable
{
	[StructLayout((LayoutKind)2, Size = 48)]
	internal struct InteractionState
	{
		[Flags]
		private enum Flags
		{
			TimerRunning = 1
		}

		[FieldOffset(0)]
		private ushort m_TriggerControlIndex;

		[FieldOffset(2)]
		private byte m_Phase;

		[FieldOffset(3)]
		private byte m_Flags;

		[FieldOffset(4)]
		private float m_TimerDuration;

		[FieldOffset(8)]
		private double m_StartTime;

		[FieldOffset(16)]
		private double m_TimerStartTime;

		[FieldOffset(24)]
		private double m_PerformedTime;

		[FieldOffset(32)]
		private float m_TotalTimeoutCompletionTimeDone;

		[FieldOffset(36)]
		private float m_TotalTimeoutCompletionTimeRemaining;

		[FieldOffset(40)]
		private long m_TimerMonitorIndex;

		public int triggerControlIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public double startTime
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double performedTime
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double timerStartTime
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public float timerDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float totalTimeoutCompletionDone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float totalTimeoutCompletionTimeRemaining
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public long timerMonitorIndex
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public bool isTimerRunning
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public InputActionPhase phase
		{
			get
			{
				return default(InputActionPhase);
			}
			set
			{
			}
		}
	}

	[StructLayout((LayoutKind)2, Size = 32)]
	internal struct BindingState
	{
		[Flags]
		public enum Flags
		{
			ChainsWithNext = 1,
			EndOfChain = 2,
			Composite = 4,
			PartOfComposite = 8,
			InitialStateCheckPending = 0x10,
			WantsInitialStateCheck = 0x20
		}

		[FieldOffset(0)]
		private byte m_ControlCount;

		[FieldOffset(1)]
		private byte m_InteractionCount;

		[FieldOffset(2)]
		private byte m_ProcessorCount;

		[FieldOffset(3)]
		private byte m_MapIndex;

		[FieldOffset(4)]
		private byte m_Flags;

		[FieldOffset(5)]
		private byte m_PartIndex;

		[FieldOffset(6)]
		private ushort m_ActionIndex;

		[FieldOffset(8)]
		private ushort m_CompositeOrCompositeBindingIndex;

		[FieldOffset(10)]
		private ushort m_ProcessorStartIndex;

		[FieldOffset(12)]
		private ushort m_InteractionStartIndex;

		[FieldOffset(14)]
		private ushort m_ControlStartIndex;

		[FieldOffset(16)]
		private double m_PressTime;

		[FieldOffset(24)]
		private int m_TriggerEventIdForComposite;

		[FieldOffset(28)]
		private int __padding;

		public int controlStartIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int controlCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int interactionStartIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int interactionCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int processorStartIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int processorCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int actionIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int mapIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int compositeOrCompositeBindingIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int triggerEventIdForComposite
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public double pressTime
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public Flags flags
		{
			get
			{
				return default(Flags);
			}
			set
			{
			}
		}

		public bool chainsWithNext
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isEndOfChain
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isPartOfChain => false;

		public bool isComposite
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isPartOfComposite
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool initialStateCheckPending
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool wantsInitialStateCheck
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int partIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}

	[StructLayout((LayoutKind)2, Size = 48)]
	public struct TriggerState
	{
		[Flags]
		public enum Flags
		{
			HaveMagnitude = 1,
			PassThrough = 2,
			MayNeedConflictResolution = 4,
			HasMultipleConcurrentActuations = 8,
			InProcessing = 0x10,
			Button = 0x20,
			Pressed = 0x40
		}

		public const int kMaxNumMaps = 255;

		public const int kMaxNumControls = 65535;

		public const int kMaxNumBindings = 65535;

		[FieldOffset(0)]
		private byte m_Phase;

		[FieldOffset(1)]
		private byte m_Flags;

		[FieldOffset(2)]
		private byte m_MapIndex;

		[FieldOffset(4)]
		private ushort m_ControlIndex;

		[FieldOffset(8)]
		private double m_Time;

		[FieldOffset(16)]
		private double m_StartTime;

		[FieldOffset(24)]
		private ushort m_BindingIndex;

		[FieldOffset(26)]
		private ushort m_InteractionIndex;

		[FieldOffset(28)]
		private float m_Magnitude;

		[FieldOffset(32)]
		private uint m_LastPerformedInUpdate;

		[FieldOffset(36)]
		private uint m_LastCanceledInUpdate;

		[FieldOffset(40)]
		private uint m_PressedInUpdate;

		[FieldOffset(44)]
		private uint m_ReleasedInUpdate;

		public InputActionPhase phase
		{
			get
			{
				return default(InputActionPhase);
			}
			set
			{
			}
		}

		public bool isDisabled => false;

		public bool isWaiting => false;

		public bool isStarted => false;

		public bool isPerformed => false;

		public bool isCanceled => false;

		public double time
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double startTime
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public float magnitude
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool haveMagnitude => false;

		public int mapIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int controlIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int bindingIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int interactionIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public uint lastPerformedInUpdate
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint lastCanceledInUpdate
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint pressedInUpdate
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint releasedInUpdate
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public bool isPassThrough
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isButton
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isPressed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool mayNeedConflictResolution
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool hasMultipleConcurrentActuations
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool inProcessing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Flags flags
		{
			get
			{
				return default(Flags);
			}
			set
			{
			}
		}
	}

	public struct ActionMapIndices
	{
		public int actionStartIndex;

		public int actionCount;

		public int controlStartIndex;

		public int controlCount;

		public int bindingStartIndex;

		public int bindingCount;

		public int interactionStartIndex;

		public int interactionCount;

		public int processorStartIndex;

		public int processorCount;

		public int compositeStartIndex;

		public int compositeCount;
	}

	public struct UnmanagedMemory : IDisposable
	{
		public unsafe void* basePtr;

		public int mapCount;

		public int actionCount;

		public int interactionCount;

		public int bindingCount;

		public int controlCount;

		public int compositeCount;

		public unsafe TriggerState* actionStates;

		public unsafe BindingState* bindingStates;

		public unsafe InteractionState* interactionStates;

		public unsafe float* controlMagnitudes;

		public unsafe float* compositeMagnitudes;

		public unsafe int* enabledControls;

		public unsafe ushort* actionBindingIndicesAndCounts;

		public unsafe ushort* actionBindingIndices;

		public unsafe int* controlIndexToBindingIndex;

		public unsafe ushort* controlGroupingAndComplexity;

		public bool controlGroupingInitialized;

		public unsafe ActionMapIndices* mapIndices;

		public bool isAllocated => false;

		public int sizeInBytes => 0;

		public void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount)
		{
		}

		public void Dispose()
		{
		}

		public void CopyDataFrom(UnmanagedMemory memory)
		{
		}

		public UnmanagedMemory Clone()
		{
			return default(UnmanagedMemory);
		}
	}

	internal struct GlobalState
	{
		internal InlinedArray<GCHandle> globalList;

		internal CallbackArray<Action<object, InputActionChange>> onActionChange;

		internal CallbackArray<Action<object>> onActionControlsChanged;
	}

	public const int kInvalidIndex = -1;

	public InputActionMap[] maps;

	public InputControl[] controls;

	public IInputInteraction[] interactions;

	public InputProcessor[] processors;

	public InputBindingComposite[] composites;

	public int totalProcessorCount;

	public UnmanagedMemory memory;

	private bool m_OnBeforeUpdateHooked;

	private bool m_OnAfterUpdateHooked;

	private bool m_InProcessControlStateChange;

	private InputEventPtr m_CurrentlyProcessingThisEvent;

	private Action m_OnBeforeUpdateDelegate;

	private Action m_OnAfterUpdateDelegate;

	internal static GlobalState s_GlobalState;

	public int totalCompositeCount => 0;

	public int totalMapCount => 0;

	public int totalActionCount => 0;

	public int totalBindingCount => 0;

	public int totalInteractionCount => 0;

	public int totalControlCount => 0;

	public unsafe ActionMapIndices* mapIndices => null;

	public unsafe TriggerState* actionStates => null;

	public unsafe BindingState* bindingStates => null;

	public unsafe InteractionState* interactionStates => null;

	public unsafe int* controlIndexToBindingIndex => null;

	public unsafe ushort* controlGroupingAndComplexity => null;

	public unsafe float* controlMagnitudes => null;

	public unsafe uint* enabledControls => null;

	public bool isProcessingControlStateChange => false;

	public void Initialize(InputBindingResolver resolver)
	{
	}

	private void ComputeControlGroupingIfNecessary()
	{
	}

	public void ClaimDataFrom(InputBindingResolver resolver)
	{
	}

	~InputActionState()
	{
	}

	public void Dispose()
	{
	}

	private void Destroy(bool isFinalizing = false)
	{
	}

	public InputActionState Clone()
	{
		return null;
	}

	object ICloneable.Clone()
	{
		return null;
	}

	private bool IsUsingDevice(InputDevice device)
	{
		return false;
	}

	private bool CanUseDevice(InputDevice device)
	{
		return false;
	}

	public bool HasEnabledActions()
	{
		return false;
	}

	private void FinishBindingCompositeSetups()
	{
	}

	internal void PrepareForBindingReResolution(bool needFullResolve, ref InputControlList<InputControl> activeControls, ref bool hasEnabledActions)
	{
	}

	public void FinishBindingResolution(bool hasEnabledActions, UnmanagedMemory oldMemory, InputControlList<InputControl> activeControls, bool isFullResolve)
	{
	}

	private void RestoreActionStatesAfterReResolvingBindings(UnmanagedMemory oldState, InputControlList<InputControl> activeControls, bool isFullResolve)
	{
	}

	private bool IsActiveControl(int bindingIndex, int controlIndex)
	{
		return false;
	}

	private int FindControlIndexOnBinding(int bindingIndex, InputControl control)
	{
		return 0;
	}

	private void ResetActionStatesDrivenBy(InputDevice device)
	{
	}

	private bool IsActionBoundToControlFromDevice(InputDevice device, int actionIndex)
	{
		return false;
	}

	public void ResetActionState(int actionIndex, InputActionPhase toPhase = InputActionPhase.Waiting, bool hardReset = false)
	{
	}

	public ref TriggerState FetchActionState(InputAction action)
	{
		throw null;
	}

	public ActionMapIndices FetchMapIndices(InputActionMap map)
	{
		return default(ActionMapIndices);
	}

	public void EnableAllActions(InputActionMap map)
	{
	}

	private void EnableControls(InputActionMap map)
	{
	}

	public void EnableSingleAction(InputAction action)
	{
	}

	private void EnableControls(InputAction action)
	{
	}

	public void DisableAllActions(InputActionMap map)
	{
	}

	public void DisableControls(InputActionMap map)
	{
	}

	public void DisableSingleAction(InputAction action)
	{
	}

	private void DisableControls(InputAction action)
	{
	}

	private void EnableControls(int mapIndex, int controlStartIndex, int numControls)
	{
	}

	private void DisableControls(int mapIndex, int controlStartIndex, int numControls)
	{
	}

	public void SetInitialStateCheckPending(int actionIndex, bool value = true)
	{
	}

	private unsafe void SetInitialStateCheckPending(BindingState* bindingStatePtr, bool value)
	{
	}

	private bool IsControlEnabled(int controlIndex)
	{
		return false;
	}

	private void SetControlEnabled(int controlIndex, bool state)
	{
	}

	private void HookOnBeforeUpdate()
	{
	}

	private void UnhookOnBeforeUpdate()
	{
	}

	private void OnBeforeInitialUpdate()
	{
	}

	void IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long mapControlAndBindingIndex)
	{
	}

	void IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long mapControlAndBindingIndex, int interactionIndex)
	{
	}

	private long ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex)
	{
		return 0L;
	}

	private void SplitUpMapAndControlAndBindingIndex(long mapControlAndBindingIndex, out int mapIndex, out int controlIndex, out int bindingIndex)
	{
		mapIndex = default(int);
		controlIndex = default(int);
		bindingIndex = default(int);
	}

	internal static int GetComplexityFromMonitorIndex(long mapControlAndBindingIndex)
	{
		return 0;
	}

	private void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, double time, InputEventPtr eventPtr)
	{
	}

	private unsafe void ProcessButtonState(ref TriggerState trigger, int actionIndex, BindingState* bindingStatePtr)
	{
	}

	private unsafe static bool ShouldIgnoreInputOnCompositeBinding(BindingState* binding, InputEvent* eventPtr)
	{
		return false;
	}

	private bool IsConflictingInput(ref TriggerState trigger, int actionIndex)
	{
		return false;
	}

	private ushort GetActionBindingStartIndexAndCount(int actionIndex, out ushort bindingCount)
	{
		bindingCount = default(ushort);
		return 0;
	}

	private void ProcessDefaultInteraction(ref TriggerState trigger, int actionIndex)
	{
	}

	private void ProcessInteractions(ref TriggerState trigger, int interactionStartIndex, int interactionCount)
	{
	}

	private void ProcessTimeout(double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex)
	{
	}

	internal void SetTotalTimeoutCompletionTime(float seconds, ref TriggerState trigger)
	{
	}

	internal void StartTimeout(float seconds, ref TriggerState trigger)
	{
	}

	private void StopTimeout(int interactionIndex)
	{
	}

	internal void ChangePhaseOfInteraction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformed = InputActionPhase.Waiting, bool processNextInteractionOnCancel = true)
	{
	}

	private bool ChangePhaseOfAction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformedOrCanceled = InputActionPhase.Waiting)
	{
		return false;
	}

	private unsafe void ChangePhaseOfActionInternal(int actionIndex, TriggerState* actionState, InputActionPhase newPhase, ref TriggerState trigger)
	{
	}

	private void CallActionListeners(int actionIndex, InputActionMap actionMap, InputActionPhase phase, ref CallbackArray<Action<InputAction.CallbackContext>> listeners, string callbackName)
	{
	}

	private object GetActionOrNoneString(ref TriggerState trigger)
	{
		return null;
	}

	internal InputAction GetActionOrNull(int bindingIndex)
	{
		return null;
	}

	internal InputAction GetActionOrNull(ref TriggerState trigger)
	{
		return null;
	}

	internal InputControl GetControl(ref TriggerState trigger)
	{
		return null;
	}

	private IInputInteraction GetInteractionOrNull(ref TriggerState trigger)
	{
		return null;
	}

	internal int GetBindingIndexInMap(int bindingIndex)
	{
		return 0;
	}

	internal int GetBindingIndexInState(int mapIndex, int bindingIndexInMap)
	{
		return 0;
	}

	internal ref BindingState GetBindingState(int bindingIndex)
	{
		throw null;
	}

	internal ref InputBinding GetBinding(int bindingIndex)
	{
		throw null;
	}

	internal InputActionMap GetActionMap(int bindingIndex)
	{
		return null;
	}

	private void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex)
	{
	}

	private void ResetInteractionState(int interactionIndex)
	{
	}

	internal int GetValueSizeInBytes(int bindingIndex, int controlIndex)
	{
		return 0;
	}

	internal Type GetValueType(int bindingIndex, int controlIndex)
	{
		return null;
	}

	internal static bool IsActuated(ref TriggerState trigger, float threshold = 0f)
	{
		return false;
	}

	internal unsafe void ReadValue(int bindingIndex, int controlIndex, void* buffer, int bufferSize, bool ignoreComposites = false)
	{
	}

	internal TValue ReadValue<TValue>(int bindingIndex, int controlIndex, bool ignoreComposites = false) where TValue : struct
	{
		return default(TValue);
	}

	internal TValue ApplyProcessors<TValue>(int bindingIndex, TValue value, InputControl<TValue> controlOfType = null) where TValue : struct
	{
		return default(TValue);
	}

	public float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber)
	{
		return 0f;
	}

	internal double GetCompositePartPressTime(int bindingIndex, int partNumber)
	{
		return 0.0;
	}

	internal unsafe TValue ReadCompositePartValue<TValue, TComparer>(int bindingIndex, int partNumber, bool* buttonValuePtr, out int controlIndex, TComparer comparer = default(TComparer)) where TValue : struct where TComparer : IComparer<TValue>
	{
		controlIndex = default(int);
		return default(TValue);
	}

	internal unsafe bool ReadCompositePartValue(int bindingIndex, int partNumber, void* buffer, int bufferSize)
	{
		return false;
	}

	internal object ReadCompositePartValueAsObject(int bindingIndex, int partNumber)
	{
		return null;
	}

	internal object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites = false)
	{
		return null;
	}

	internal bool ReadValueAsButton(int bindingIndex, int controlIndex)
	{
		return false;
	}

	internal static ISavedState SaveAndResetState()
	{
		return null;
	}

	private void AddToGlobalList()
	{
	}

	private void RemoveMapFromGlobalList()
	{
	}

	private static void CompactGlobalList()
	{
	}

	internal void NotifyListenersOfActionChange(InputActionChange change)
	{
	}

	internal static void NotifyListenersOfActionChange(InputActionChange change, object actionOrMapOrAsset)
	{
	}

	private static void ResetGlobals()
	{
	}

	internal static int FindAllEnabledActions(List<InputAction> result)
	{
		return 0;
	}

	internal static void OnDeviceChange(InputDevice device, InputDeviceChange change)
	{
	}

	internal static void DeferredResolutionOfBindings()
	{
	}

	internal static void DisableAllActions()
	{
	}

	internal static void DestroyAllActionMapStates()
	{
	}
}
