using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Switch.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Switch;

[InputControlLayout(stateType = typeof(SwitchProControllerHIDInputState), displayName = "Switch Pro Controller")]
public class SwitchProControllerHID : Gamepad, IInputStateCallbackReceiver, IEventPreProcessor
{
	[StructLayout((LayoutKind)2, Size = 7)]
	private struct SwitchInputOnlyReport
	{
		public const int kSize = 7;

		[FieldOffset(0)]
		public byte buttons0;

		[FieldOffset(1)]
		public byte buttons1;

		[FieldOffset(2)]
		public byte hat;

		[FieldOffset(3)]
		public byte leftX;

		[FieldOffset(4)]
		public byte leftY;

		[FieldOffset(5)]
		public byte rightX;

		[FieldOffset(6)]
		public byte rightY;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public SwitchProControllerHIDInputState ToHIDInputReport()
		{
			return default(SwitchProControllerHIDInputState);
		}
	}

	[StructLayout((LayoutKind)2, Size = 12)]
	private struct SwitchSimpleInputReport
	{
		public const int kSize = 12;

		public const byte ExpectedReportId = 63;

		[FieldOffset(0)]
		public byte reportId;

		[FieldOffset(1)]
		public byte buttons0;

		[FieldOffset(2)]
		public byte buttons1;

		[FieldOffset(3)]
		public byte hat;

		[FieldOffset(4)]
		public ushort leftX;

		[FieldOffset(6)]
		public ushort leftY;

		[FieldOffset(8)]
		public ushort rightX;

		[FieldOffset(10)]
		public ushort rightY;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public SwitchProControllerHIDInputState ToHIDInputReport()
		{
			return default(SwitchProControllerHIDInputState);
		}
	}

	[StructLayout((LayoutKind)2, Size = 25)]
	private struct SwitchFullInputReport
	{
		public const int kSize = 25;

		public const byte ExpectedReportId = 48;

		[FieldOffset(0)]
		public byte reportId;

		[FieldOffset(3)]
		public byte buttons0;

		[FieldOffset(4)]
		public byte buttons1;

		[FieldOffset(5)]
		public byte buttons2;

		[FieldOffset(6)]
		public byte left0;

		[FieldOffset(7)]
		public byte left1;

		[FieldOffset(8)]
		public byte left2;

		[FieldOffset(9)]
		public byte right0;

		[FieldOffset(10)]
		public byte right1;

		[FieldOffset(11)]
		public byte right2;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public SwitchProControllerHIDInputState ToHIDInputReport()
		{
			return default(SwitchProControllerHIDInputState);
		}
	}

	[StructLayout((LayoutKind)2)]
	private struct SwitchHIDGenericInputReport
	{
		[FieldOffset(0)]
		public byte reportId;

		public static FourCC Format => default(FourCC);
	}

	[StructLayout((LayoutKind)2, Size = 49)]
	internal struct SwitchMagicOutputReport
	{
		internal enum ReportType
		{
			Magic = 0x80
		}

		public enum CommandIdType
		{
			Status = 1,
			Handshake = 2,
			Highspeed = 3,
			ForceUSB = 4
		}

		public const int kSize = 49;

		public const byte ExpectedReplyInputReportId = 129;

		[FieldOffset(0)]
		public byte reportType;

		[FieldOffset(1)]
		public byte commandId;
	}

	[StructLayout((LayoutKind)2, Size = 57)]
	internal struct SwitchMagicOutputHIDBluetooth : IInputDeviceCommandInfo
	{
		public const int kSize = 57;

		[FieldOffset(0)]
		public InputDeviceCommand baseCommand;

		[FieldOffset(8)]
		public SwitchMagicOutputReport report;

		public static FourCC Type => default(FourCC);

		public FourCC typeStatic => default(FourCC);

		public static SwitchMagicOutputHIDBluetooth Create(SwitchMagicOutputReport.CommandIdType type)
		{
			return default(SwitchMagicOutputHIDBluetooth);
		}
	}

	[StructLayout((LayoutKind)2, Size = 72)]
	internal struct SwitchMagicOutputHIDUSB : IInputDeviceCommandInfo
	{
		public const int kSize = 72;

		[FieldOffset(0)]
		public InputDeviceCommand baseCommand;

		[FieldOffset(8)]
		public SwitchMagicOutputReport report;

		public static FourCC Type => default(FourCC);

		public FourCC typeStatic => default(FourCC);

		public static SwitchMagicOutputHIDUSB Create(SwitchMagicOutputReport.CommandIdType type)
		{
			return default(SwitchMagicOutputHIDUSB);
		}
	}

	private static readonly SwitchMagicOutputReport.CommandIdType[] s_HandshakeSequence;

	private int m_HandshakeStepIndex;

	private double m_HandshakeTimer;

	internal const byte JitterMaskLow = 120;

	internal const byte JitterMaskHigh = 135;

	[InputControl(name = "capture", displayName = "Capture")]
	public ButtonControl captureButton { get; protected set; }

	[InputControl(name = "home", displayName = "Home")]
	public ButtonControl homeButton { get; protected set; }

	protected override void OnAdded()
	{
	}

	private void HandshakeRestart()
	{
	}

	private void HandshakeTick()
	{
	}

	public void OnNextUpdate()
	{
	}

	public void OnStateEvent(InputEventPtr eventPtr)
	{
	}

	public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset)
	{
		return false;
	}

	public bool PreProcessEvent(InputEventPtr eventPtr)
	{
		return false;
	}
}
