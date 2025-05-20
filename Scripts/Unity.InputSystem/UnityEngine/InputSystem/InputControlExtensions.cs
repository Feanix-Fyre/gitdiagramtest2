using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public static class InputControlExtensions
{
	[Flags]
	public enum Enumerate
	{
		IgnoreControlsInDefaultState = 1,
		IgnoreControlsInCurrentState = 2,
		IncludeSyntheticControls = 4,
		IncludeNoisyControls = 8,
		IncludeNonLeafControls = 0x10
	}

	public struct InputEventControlCollection : IEnumerable<InputControl>, IEnumerable
	{
		internal InputDevice m_Device;

		internal InputEventPtr m_EventPtr;

		internal Enumerate m_Flags;

		internal float m_MagnitudeThreshold;

		public InputEventPtr eventPtr => default(InputEventPtr);

		public InputEventControlEnumerator GetEnumerator()
		{
			return default(InputEventControlEnumerator);
		}

		IEnumerator<InputControl> IEnumerable<InputControl>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public struct InputEventControlEnumerator : IEnumerator<InputControl>, IEnumerator, IDisposable
	{
		private Enumerate m_Flags;

		private readonly InputDevice m_Device;

		private readonly uint[] m_StateOffsetToControlIndex;

		private readonly int m_StateOffsetToControlIndexLength;

		private readonly InputControl[] m_AllControls;

		private unsafe byte* m_DefaultState;

		private unsafe byte* m_CurrentState;

		private unsafe byte* m_NoiseMask;

		private InputEventPtr m_EventPtr;

		private InputControl m_CurrentControl;

		private int m_CurrentIndexInStateOffsetToControlIndexMap;

		private uint m_CurrentControlStateBitOffset;

		private unsafe byte* m_EventState;

		private uint m_CurrentBitOffset;

		private uint m_EndBitOffset;

		private float m_MagnitudeThreshold;

		public InputControl Current => null;

		object IEnumerator.Current => null;

		internal unsafe InputEventControlEnumerator(InputEventPtr eventPtr, InputDevice device, Enumerate flags, float magnitudeThreshold = 0f)
		{
			m_Flags = default(Enumerate);
			m_Device = null;
			m_StateOffsetToControlIndex = null;
			m_StateOffsetToControlIndexLength = 0;
			m_AllControls = null;
			m_DefaultState = null;
			m_CurrentState = null;
			m_NoiseMask = null;
			m_EventPtr = default(InputEventPtr);
			m_CurrentControl = null;
			m_CurrentIndexInStateOffsetToControlIndexMap = 0;
			m_CurrentControlStateBitOffset = 0u;
			m_EventState = null;
			m_CurrentBitOffset = 0u;
			m_EndBitOffset = 0u;
			m_MagnitudeThreshold = 0f;
		}

		private bool CheckDefault(uint numBits)
		{
			return false;
		}

		private bool CheckCurrent(uint numBits)
		{
			return false;
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}

	public struct ControlBuilder
	{
		public InputControl control { get; internal set; }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder At(InputDevice device, int index)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder WithParent(InputControl parent)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder WithName(string name)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder WithDisplayName(string displayName)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder WithShortDisplayName(string shortDisplayName)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder WithLayout(InternedString layout)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder WithUsages(int startIndex, int count)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder WithAliases(int startIndex, int count)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder WithChildren(int startIndex, int count)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder WithStateBlock(InputStateBlock stateBlock)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder WithDefaultState(PrimitiveValue value)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder WithMinAndMax(PrimitiveValue min, PrimitiveValue max)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder WithProcessor<TProcessor, TValue>(TProcessor processor) where TProcessor : InputProcessor<TValue> where TValue : struct
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder IsNoisy(bool value)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder IsSynthetic(bool value)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder DontReset(bool value)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ControlBuilder IsButton(bool value)
		{
			return default(ControlBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Finish()
		{
		}
	}

	public struct DeviceBuilder
	{
		public InputDevice device { get; internal set; }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DeviceBuilder WithName(string name)
		{
			return default(DeviceBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DeviceBuilder WithDisplayName(string displayName)
		{
			return default(DeviceBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DeviceBuilder WithShortDisplayName(string shortDisplayName)
		{
			return default(DeviceBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DeviceBuilder WithLayout(InternedString layout)
		{
			return default(DeviceBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DeviceBuilder WithChildren(int startIndex, int count)
		{
			return default(DeviceBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DeviceBuilder WithStateBlock(InputStateBlock stateBlock)
		{
			return default(DeviceBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DeviceBuilder IsNoisy(bool value)
		{
			return default(DeviceBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DeviceBuilder WithControlUsage(int controlIndex, InternedString usage, InputControl control)
		{
			return default(DeviceBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DeviceBuilder WithControlAlias(int controlIndex, InternedString alias)
		{
			return default(DeviceBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DeviceBuilder WithStateOffsetToControlIndexMap(uint[] map)
		{
			return default(DeviceBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DeviceBuilder WithControlTree(byte[] controlTreeNodes, ushort[] controlTreeIndicies)
		{
			return default(DeviceBuilder);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Finish()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetAllButtonPresses_003Ed__43 : IEnumerable<InputControl>, IEnumerable, IEnumerator<InputControl>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private InputControl _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private InputEventPtr eventPtr;

		public InputEventPtr _003C_003E3__eventPtr;

		private float magnitude;

		public float _003C_003E3__magnitude;

		private bool buttonControlsOnly;

		public bool _003C_003E3__buttonControlsOnly;

		private InputEventControlEnumerator _003C_003E7__wrap1;

		InputControl IEnumerator<InputControl>.Current
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
		public _003CGetAllButtonPresses_003Ed__43(int _003C_003E1__state)
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

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<InputControl> IEnumerable<InputControl>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public static TControl FindInParentChain<TControl>(this InputControl control) where TControl : InputControl
	{
		return null;
	}

	public static bool IsPressed(this InputControl control, float buttonPressPoint = 0f)
	{
		return false;
	}

	public static bool IsActuated(this InputControl control, float threshold = 0f)
	{
		return false;
	}

	public static object ReadValueAsObject(this InputControl control)
	{
		return null;
	}

	public unsafe static void ReadValueIntoBuffer(this InputControl control, void* buffer, int bufferSize)
	{
	}

	public static object ReadDefaultValueAsObject(this InputControl control)
	{
		return null;
	}

	public static TValue ReadValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent) where TValue : struct
	{
		return default(TValue);
	}

	public static bool ReadValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent, out TValue value) where TValue : struct
	{
		value = default(TValue);
		return false;
	}

	public static object ReadValueFromEventAsObject(this InputControl control, InputEventPtr inputEvent)
	{
		return null;
	}

	public static TValue ReadUnprocessedValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr eventPtr) where TValue : struct
	{
		return default(TValue);
	}

	public static bool ReadUnprocessedValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent, out TValue value) where TValue : struct
	{
		value = default(TValue);
		return false;
	}

	public static void WriteValueFromObjectIntoEvent(this InputControl control, InputEventPtr eventPtr, object value)
	{
	}

	public unsafe static void WriteValueIntoState(this InputControl control, void* statePtr)
	{
	}

	public unsafe static void WriteValueIntoState<TValue>(this InputControl control, TValue value, void* statePtr) where TValue : struct
	{
	}

	public unsafe static void WriteValueIntoState<TValue>(this InputControl<TValue> control, TValue value, void* statePtr) where TValue : struct
	{
	}

	public unsafe static void WriteValueIntoState<TValue>(this InputControl<TValue> control, void* statePtr) where TValue : struct
	{
	}

	public static void WriteValueIntoState<TValue, TState>(this InputControl<TValue> control, TValue value, ref TState state) where TValue : struct where TState : struct, IInputStateTypeInfo
	{
	}

	public static void WriteValueIntoEvent<TValue>(this InputControl control, TValue value, InputEventPtr eventPtr) where TValue : struct
	{
	}

	public static void WriteValueIntoEvent<TValue>(this InputControl<TValue> control, TValue value, InputEventPtr eventPtr) where TValue : struct
	{
	}

	public unsafe static void CopyState(this InputDevice device, void* buffer, int bufferSizeInBytes)
	{
	}

	public static void CopyState<TState>(this InputDevice device, out TState state) where TState : struct, IInputStateTypeInfo
	{
		state = default(TState);
	}

	public static bool CheckStateIsAtDefault(this InputControl control)
	{
		return false;
	}

	public unsafe static bool CheckStateIsAtDefault(this InputControl control, void* statePtr, void* maskPtr = null)
	{
		return false;
	}

	public static bool CheckStateIsAtDefaultIgnoringNoise(this InputControl control)
	{
		return false;
	}

	public unsafe static bool CheckStateIsAtDefaultIgnoringNoise(this InputControl control, void* statePtr)
	{
		return false;
	}

	public unsafe static bool CompareStateIgnoringNoise(this InputControl control, void* statePtr)
	{
		return false;
	}

	public unsafe static bool CompareState(this InputControl control, void* firstStatePtr, void* secondStatePtr, void* maskPtr = null)
	{
		return false;
	}

	public unsafe static bool CompareState(this InputControl control, void* statePtr, void* maskPtr = null)
	{
		return false;
	}

	public unsafe static bool HasValueChangeInState(this InputControl control, void* statePtr)
	{
		return false;
	}

	public static bool HasValueChangeInEvent(this InputControl control, InputEventPtr eventPtr)
	{
		return false;
	}

	public unsafe static void* GetStatePtrFromStateEvent(this InputControl control, InputEventPtr eventPtr)
	{
		return null;
	}

	internal unsafe static void* GetStatePtrFromStateEventUnchecked(this InputControl control, InputEventPtr eventPtr, FourCC eventType)
	{
		return null;
	}

	public static bool ResetToDefaultStateInEvent(this InputControl control, InputEventPtr eventPtr)
	{
		return false;
	}

	public static void QueueValueChange<TValue>(this InputControl<TValue> control, TValue value, double time = -1.0) where TValue : struct
	{
	}

	public unsafe static void AccumulateValueInEvent(this InputControl<float> control, void* currentStatePtr, InputEventPtr newState)
	{
	}

	internal unsafe static void AccumulateValueInEvent(this InputControl<Vector2> control, void* currentStatePtr, InputEventPtr newState)
	{
	}

	public static void FindControlsRecursive<TControl>(this InputControl parent, IList<TControl> controls, Func<TControl, bool> predicate) where TControl : InputControl
	{
	}

	internal static string BuildPath(this InputControl control, string deviceLayout, StringBuilder builder = null)
	{
		return null;
	}

	public static InputEventControlCollection EnumerateControls(this InputEventPtr eventPtr, Enumerate flags, InputDevice device = null, float magnitudeThreshold = 0f)
	{
		return default(InputEventControlCollection);
	}

	public static InputEventControlCollection EnumerateChangedControls(this InputEventPtr eventPtr, InputDevice device = null, float magnitudeThreshold = 0f)
	{
		return default(InputEventControlCollection);
	}

	public static bool HasButtonPress(this InputEventPtr eventPtr, float magnitude = -1f, bool buttonControlsOnly = true)
	{
		return false;
	}

	public static InputControl GetFirstButtonPressOrNull(this InputEventPtr eventPtr, float magnitude = -1f, bool buttonControlsOnly = true)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetAllButtonPresses_003Ed__43))]
	public static IEnumerable<InputControl> GetAllButtonPresses(this InputEventPtr eventPtr, float magnitude = -1f, bool buttonControlsOnly = true)
	{
		return null;
	}

	public static ControlBuilder Setup(this InputControl control)
	{
		return default(ControlBuilder);
	}

	public static DeviceBuilder Setup(this InputDevice device, int controlCount, int usageCount, int aliasCount)
	{
		return default(DeviceBuilder);
	}
}
