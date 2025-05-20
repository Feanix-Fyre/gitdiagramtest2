using System;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

public struct InputEventPtr : IEquatable<InputEventPtr>
{
	private unsafe readonly InputEvent* m_EventPtr;

	public bool valid => false;

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

	public int id
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public FourCC type => default(FourCC);

	public uint sizeInBytes => 0u;

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

	public unsafe InputEvent* data => null;

	internal FourCC stateFormat => default(FourCC);

	internal uint stateSizeInBytes => 0u;

	internal uint stateOffset => 0u;

	public unsafe InputEventPtr(InputEvent* eventPtr)
	{
		m_EventPtr = null;
	}

	public bool IsA<TOtherEvent>() where TOtherEvent : struct, IInputEventTypeInfo
	{
		return false;
	}

	public InputEventPtr Next()
	{
		return default(InputEventPtr);
	}

	public override string ToString()
	{
		return null;
	}

	public unsafe InputEvent* ToPointer()
	{
		return null;
	}

	public bool Equals(InputEventPtr other)
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

	public static bool operator ==(InputEventPtr left, InputEventPtr right)
	{
		return false;
	}

	public static bool operator !=(InputEventPtr left, InputEventPtr right)
	{
		return false;
	}

	public unsafe static implicit operator InputEventPtr(InputEvent* eventPtr)
	{
		return default(InputEventPtr);
	}

	public unsafe static InputEventPtr From(InputEvent* eventPtr)
	{
		return default(InputEventPtr);
	}

	public unsafe static implicit operator InputEvent*(InputEventPtr eventPtr)
	{
		return null;
	}

	public unsafe static InputEvent* FromInputEventPtr(InputEventPtr eventPtr)
	{
		return null;
	}
}
