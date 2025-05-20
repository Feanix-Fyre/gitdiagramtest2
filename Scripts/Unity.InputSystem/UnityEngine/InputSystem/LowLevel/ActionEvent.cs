using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 37)]
internal struct ActionEvent : IInputEventTypeInfo
{
	[FieldOffset(0)]
	public InputEvent baseEvent;

	[FieldOffset(20)]
	private ushort m_ControlIndex;

	[FieldOffset(22)]
	private ushort m_BindingIndex;

	[FieldOffset(24)]
	private ushort m_InteractionIndex;

	[FieldOffset(26)]
	private byte m_StateIndex;

	[FieldOffset(27)]
	private byte m_Phase;

	[FieldOffset(28)]
	private double m_StartTime;

	[FieldOffset(36)]
	public unsafe fixed byte m_ValueData[1];

	public static FourCC Type => default(FourCC);

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

	public unsafe byte* valueData => null;

	public int valueSizeInBytes => 0;

	public int stateIndex
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

	public FourCC typeStatic => default(FourCC);

	public InputEventPtr ToEventPtr()
	{
		return default(InputEventPtr);
	}

	public static int GetEventSizeWithValueSize(int valueSizeInBytes)
	{
		return 0;
	}

	public unsafe static ActionEvent* From(InputEventPtr ptr)
	{
		return null;
	}
}
