using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.DualShock.LowLevel;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock;

[InputControlLayout(stateType = typeof(DualSenseHIDInputReport), displayName = "DualSense HID")]
public class DualSenseGamepadHID : DualShockGamepad, IEventMerger, IEventPreProcessor, IInputStateCallbackReceiver
{
	[StructLayout((LayoutKind)2)]
	internal struct DualSenseHIDGenericInputReport
	{
		[FieldOffset(0)]
		public byte reportId;

		public static FourCC Format => default(FourCC);
	}

	[StructLayout((LayoutKind)2)]
	internal struct DualSenseHIDUSBInputReport
	{
		public const int ExpectedReportId = 1;

		[FieldOffset(0)]
		public byte reportId;

		[FieldOffset(1)]
		public byte leftStickX;

		[FieldOffset(2)]
		public byte leftStickY;

		[FieldOffset(3)]
		public byte rightStickX;

		[FieldOffset(4)]
		public byte rightStickY;

		[FieldOffset(5)]
		public byte leftTrigger;

		[FieldOffset(6)]
		public byte rightTrigger;

		[FieldOffset(8)]
		public byte buttons0;

		[FieldOffset(9)]
		public byte buttons1;

		[FieldOffset(10)]
		public byte buttons2;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DualSenseHIDInputReport ToHIDInputReport()
		{
			return default(DualSenseHIDInputReport);
		}
	}

	[StructLayout((LayoutKind)2)]
	internal struct DualSenseHIDBluetoothInputReport
	{
		public const int ExpectedReportId = 49;

		[FieldOffset(0)]
		public byte reportId;

		[FieldOffset(2)]
		public byte leftStickX;

		[FieldOffset(3)]
		public byte leftStickY;

		[FieldOffset(4)]
		public byte rightStickX;

		[FieldOffset(5)]
		public byte rightStickY;

		[FieldOffset(6)]
		public byte leftTrigger;

		[FieldOffset(7)]
		public byte rightTrigger;

		[FieldOffset(9)]
		public byte buttons0;

		[FieldOffset(10)]
		public byte buttons1;

		[FieldOffset(11)]
		public byte buttons2;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DualSenseHIDInputReport ToHIDInputReport()
		{
			return default(DualSenseHIDInputReport);
		}
	}

	[StructLayout((LayoutKind)2)]
	internal struct DualSenseHIDMinimalInputReport
	{
		public static int ExpectedSize1;

		public static int ExpectedSize2;

		[FieldOffset(0)]
		public byte reportId;

		[FieldOffset(1)]
		public byte leftStickX;

		[FieldOffset(2)]
		public byte leftStickY;

		[FieldOffset(3)]
		public byte rightStickX;

		[FieldOffset(4)]
		public byte rightStickY;

		[FieldOffset(5)]
		public byte buttons0;

		[FieldOffset(6)]
		public byte buttons1;

		[FieldOffset(7)]
		public byte buttons2;

		[FieldOffset(8)]
		public byte leftTrigger;

		[FieldOffset(9)]
		public byte rightTrigger;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DualSenseHIDInputReport ToHIDInputReport()
		{
			return default(DualSenseHIDInputReport);
		}
	}

	private float? m_LowFrequencyMotorSpeed;

	private float? m_HighFrequenceyMotorSpeed;

	private Color? m_LightBarColor;

	private byte outputSequenceId;

	internal const byte JitterMaskLow = 120;

	internal const byte JitterMaskHigh = 135;

	public ButtonControl leftTriggerButton { get; protected set; }

	public ButtonControl rightTriggerButton { get; protected set; }

	public ButtonControl playStationButton { get; protected set; }

	protected override void FinishSetup()
	{
	}

	public override void PauseHaptics()
	{
	}

	public override void ResetHaptics()
	{
	}

	public override void ResumeHaptics()
	{
	}

	public override void SetLightBarColor(Color color)
	{
	}

	public override void SetMotorSpeeds(float lowFrequency, float highFrequency)
	{
	}

	public bool SetMotorSpeedsAndLightBarColor(float? lowFrequency, float? highFrequency, Color? color)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static bool MergeForward(DualSenseHIDUSBInputReport* currentState, DualSenseHIDUSBInputReport* nextState)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static bool MergeForward(DualSenseHIDBluetoothInputReport* currentState, DualSenseHIDBluetoothInputReport* nextState)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static bool MergeForward(DualSenseHIDMinimalInputReport* currentState, DualSenseHIDMinimalInputReport* nextState)
	{
		return false;
	}

	bool IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
	{
		return false;
	}

	bool IEventPreProcessor.PreProcessEvent(InputEventPtr eventPtr)
	{
		return false;
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
}
