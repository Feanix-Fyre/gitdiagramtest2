using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 56)]
public struct TouchState : IInputStateTypeInfo
{
	internal const int kSizeInBytes = 56;

	[FieldOffset(0)]
	[InputControl(displayName = "Touch ID", layout = "Integer", synthetic = true, dontReset = true)]
	public int touchId;

	[FieldOffset(4)]
	[InputControl(displayName = "Position", dontReset = true)]
	public Vector2 position;

	[FieldOffset(12)]
	[InputControl(displayName = "Delta", layout = "Delta")]
	public Vector2 delta;

	[FieldOffset(20)]
	[InputControl(displayName = "Pressure", layout = "Axis")]
	public float pressure;

	[FieldOffset(24)]
	[InputControl(displayName = "Radius")]
	public Vector2 radius;

	[FieldOffset(32)]
	[InputControl(name = "phase", displayName = "Touch Phase", layout = "TouchPhase", synthetic = true)]
	[InputControl(name = "press", displayName = "Touch Contact?", layout = "TouchPress", useStateFrom = "phase")]
	public byte phaseId;

	[FieldOffset(33)]
	[InputControl(name = "tapCount", displayName = "Tap Count", layout = "Integer")]
	public byte tapCount;

	[FieldOffset(34)]
	[InputControl(name = "displayIndex", displayName = "Display Index", layout = "Integer")]
	public byte displayIndex;

	[FieldOffset(35)]
	[InputControl(name = "indirectTouch", displayName = "Indirect Touch?", layout = "Button", bit = 0u, synthetic = true)]
	[InputControl(name = "tap", displayName = "Tap", layout = "Button", bit = 4u)]
	public byte flags;

	[FieldOffset(36)]
	internal uint updateStepCount;

	[FieldOffset(40)]
	[InputControl(displayName = "Start Time", layout = "Double", synthetic = true)]
	public double startTime;

	[FieldOffset(48)]
	[InputControl(displayName = "Start Position", synthetic = true)]
	public Vector2 startPosition;

	public static FourCC Format => default(FourCC);

	public TouchPhase phase
	{
		get
		{
			return default(TouchPhase);
		}
		set
		{
		}
	}

	public bool isNoneEndedOrCanceled => false;

	public bool isInProgress => false;

	public bool isPrimaryTouch
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool isOrphanedPrimaryTouch
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isIndirectTouch
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isTap
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool isTapPress
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool isTapRelease
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool beganInSameFrame
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public FourCC format => default(FourCC);

	public override string ToString()
	{
		return null;
	}
}
