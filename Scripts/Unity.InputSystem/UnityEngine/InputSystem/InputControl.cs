using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

[DebuggerDisplay("{DebuggerDisplay(),nq}")]
public abstract class InputControl
{
	[Flags]
	internal enum ControlFlags
	{
		ConfigUpToDate = 1,
		IsNoisy = 2,
		IsSynthetic = 4,
		IsButton = 8,
		DontReset = 0x10,
		SetupFinished = 0x20,
		UsesStateFromOtherControl = 0x40
	}

	protected internal InputStateBlock m_StateBlock;

	internal InternedString m_Name;

	internal string m_Path;

	internal string m_DisplayName;

	internal string m_DisplayNameFromLayout;

	internal string m_ShortDisplayName;

	internal string m_ShortDisplayNameFromLayout;

	internal InternedString m_Layout;

	internal InternedString m_Variants;

	internal InputDevice m_Device;

	internal InputControl m_Parent;

	internal int m_UsageCount;

	internal int m_UsageStartIndex;

	internal int m_AliasCount;

	internal int m_AliasStartIndex;

	internal int m_ChildCount;

	internal int m_ChildStartIndex;

	internal ControlFlags m_ControlFlags;

	internal bool m_CachedValueIsStale;

	internal bool m_UnprocessedCachedValueIsStale;

	internal PrimitiveValue m_DefaultState;

	internal PrimitiveValue m_MinValue;

	internal PrimitiveValue m_MaxValue;

	internal FourCC m_OptimizedControlDataType;

	public string name => null;

	public string displayName
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public string shortDisplayName
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public string path => null;

	public string layout => null;

	public string variants => null;

	public InputDevice device => null;

	public InputControl parent => null;

	public ReadOnlyArray<InputControl> children => default(ReadOnlyArray<InputControl>);

	public ReadOnlyArray<InternedString> usages => default(ReadOnlyArray<InternedString>);

	public ReadOnlyArray<InternedString> aliases => default(ReadOnlyArray<InternedString>);

	public InputStateBlock stateBlock => default(InputStateBlock);

	public bool noisy
	{
		get
		{
			return false;
		}
		internal set
		{
		}
	}

	public bool synthetic
	{
		get
		{
			return false;
		}
		internal set
		{
		}
	}

	public InputControl this[string path] => null;

	public abstract Type valueType { get; }

	public abstract int valueSizeInBytes { get; }

	public float magnitude => 0f;

	protected internal unsafe void* currentStatePtr => null;

	protected internal unsafe void* previousFrameStatePtr => null;

	protected internal unsafe void* defaultStatePtr => null;

	protected internal unsafe void* noiseMaskPtr => null;

	protected internal uint stateOffsetRelativeToDeviceRoot => 0u;

	public FourCC optimizedControlDataType => default(FourCC);

	internal bool isSetupFinished
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool isButton
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool isConfigUpToDate
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool dontReset
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool usesStateFromOtherControl
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool hasDefaultState => false;

	public override string ToString()
	{
		return null;
	}

	private string DebuggerDisplay()
	{
		return null;
	}

	public float EvaluateMagnitude()
	{
		return 0f;
	}

	public unsafe virtual float EvaluateMagnitude(void* statePtr)
	{
		return 0f;
	}

	public unsafe abstract object ReadValueFromBufferAsObject(void* buffer, int bufferSize);

	public unsafe abstract object ReadValueFromStateAsObject(void* statePtr);

	public unsafe abstract void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize);

	public unsafe virtual void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr)
	{
	}

	public unsafe virtual void WriteValueFromObjectIntoState(object value, void* statePtr)
	{
	}

	public unsafe abstract bool CompareValue(void* firstStatePtr, void* secondStatePtr);

	public InputControl TryGetChildControl(string path)
	{
		return null;
	}

	public TControl TryGetChildControl<TControl>(string path) where TControl : InputControl
	{
		return null;
	}

	public InputControl GetChildControl(string path)
	{
		return null;
	}

	public TControl GetChildControl<TControl>(string path) where TControl : InputControl
	{
		return null;
	}

	protected virtual void FinishSetup()
	{
	}

	protected void RefreshConfigurationIfNeeded()
	{
	}

	protected virtual void RefreshConfiguration()
	{
	}

	protected virtual FourCC CalculateOptimizedControlDataType()
	{
		return default(FourCC);
	}

	public void ApplyParameterChanges()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void SetOptimizedControlDataType()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal void SetOptimizedControlDataTypeRecursively()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	internal void EnsureOptimizationTypeHasNotChanged()
	{
	}

	internal void CallFinishSetupRecursive()
	{
	}

	internal string MakeChildPath(string path)
	{
		return null;
	}

	internal void BakeOffsetIntoStateBlockRecursive(uint offset)
	{
	}

	internal int GetDeviceIndex()
	{
		return 0;
	}

	internal bool IsValueConsideredPressed(float value)
	{
		return false;
	}

	internal virtual void AddProcessor(object first)
	{
	}

	internal void MarkAsStale()
	{
	}

	internal void MarkAsStaleRecursively()
	{
	}
}
public abstract class InputControl<TValue> : InputControl where TValue : struct
{
	internal InlinedArray<InputProcessor<TValue>> m_ProcessorStack;

	private TValue m_CachedValue;

	private TValue m_UnprocessedCachedValue;

	internal bool evaluateProcessorsEveryRead;

	public override Type valueType => null;

	public override int valueSizeInBytes => 0;

	public ref readonly TValue value
	{
		get
		{
			throw null;
		}
	}

	internal ref readonly TValue unprocessedValue
	{
		get
		{
			throw null;
		}
	}

	internal InputProcessor<TValue>[] processors => null;

	public TValue ReadValue()
	{
		return default(TValue);
	}

	public TValue ReadValueFromPreviousFrame()
	{
		return default(TValue);
	}

	public TValue ReadDefaultValue()
	{
		return default(TValue);
	}

	public unsafe TValue ReadValueFromState(void* statePtr)
	{
		return default(TValue);
	}

	public unsafe TValue ReadValueFromStateWithCaching(void* statePtr)
	{
		return default(TValue);
	}

	public unsafe TValue ReadUnprocessedValueFromStateWithCaching(void* statePtr)
	{
		return default(TValue);
	}

	public TValue ReadUnprocessedValue()
	{
		return default(TValue);
	}

	public unsafe abstract TValue ReadUnprocessedValueFromState(void* statePtr);

	public unsafe override object ReadValueFromStateAsObject(void* statePtr)
	{
		return null;
	}

	public unsafe override void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize)
	{
	}

	public unsafe override void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr)
	{
	}

	public unsafe override void WriteValueFromObjectIntoState(object value, void* statePtr)
	{
	}

	public unsafe virtual void WriteValueIntoState(TValue value, void* statePtr)
	{
	}

	public unsafe override object ReadValueFromBufferAsObject(void* buffer, int bufferSize)
	{
		return null;
	}

	private static bool CompareValue(ref TValue firstValue, ref TValue secondValue)
	{
		return false;
	}

	public unsafe override bool CompareValue(void* firstStatePtr, void* secondStatePtr)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public TValue ProcessValue(TValue value)
	{
		return default(TValue);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void ProcessValue(ref TValue value)
	{
	}

	internal TProcessor TryGetProcessor<TProcessor>() where TProcessor : InputProcessor<TValue>
	{
		return null;
	}

	internal override void AddProcessor(object processor)
	{
	}

	protected override void FinishSetup()
	{
	}
}
