using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;
using UnityEngineInternal.Input;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Pack = 1, Size = 20)]
public struct InputEvent
{
	private const uint kHandledMask = 2147483648u;

	private const uint kIdMask = 2147483647u;

	internal const int kBaseEventSize = 20;

	public const int InvalidEventId = 0;

	internal const int kAlignment = 4;

	[FieldOffset(0)]
	private NativeInputEvent m_Event;

	public FourCC type
	{
		get
		{
			return default(FourCC);
		}
		set
		{
		}
	}

	public uint sizeInBytes
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public int eventId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int deviceId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

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

	internal double internalTime
	{
		get
		{
			return 0.0;
		}
		set
		{
		}
	}

	public bool handled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public InputEvent(FourCC type, int sizeInBytes, int deviceId, double time = -1.0)
	{
		m_Event = default(NativeInputEvent);
	}

	public override string ToString()
	{
		return null;
	}

	internal unsafe static InputEvent* GetNextInMemory(InputEvent* currentPtr)
	{
		return null;
	}

	internal unsafe static InputEvent* GetNextInMemoryChecked(InputEvent* currentPtr, ref InputEventBuffer buffer)
	{
		return null;
	}

	public unsafe static bool Equals(InputEvent* first, InputEvent* second)
	{
		return false;
	}
}
