using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.DualShock.LowLevel;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock;

[InputControlLayout(stateType = typeof(DualShock4HIDInputReport), hideInUI = true, isNoisy = true)]
public class DualShock4GamepadHID : DualShockGamepad, IEventPreProcessor, IInputStateCallbackReceiver
{
	[StructLayout((LayoutKind)2)]
	internal struct DualShock4HIDGenericInputReport
	{
		[FieldOffset(0)]
		public byte leftStickX;

		[FieldOffset(1)]
		public byte leftStickY;

		[FieldOffset(2)]
		public byte rightStickX;

		[FieldOffset(3)]
		public byte rightStickY;

		[FieldOffset(4)]
		public byte buttons0;

		[FieldOffset(5)]
		public byte buttons1;

		[FieldOffset(6)]
		public byte buttons2;

		[FieldOffset(7)]
		public byte leftTrigger;

		[FieldOffset(8)]
		public byte rightTrigger;

		public static FourCC Format => default(FourCC);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DualShock4HIDInputReport ToHIDInputReport()
		{
			return default(DualShock4HIDInputReport);
		}
	}

	private float? m_LowFrequencyMotorSpeed;

	private float? m_HighFrequenceyMotorSpeed;

	private Color? m_LightBarColor;

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

	public bool SetMotorSpeedsAndLightBarColor(float lowFrequency, float highFrequency, Color color)
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
