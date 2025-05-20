using System;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock.LowLevel;

[StructLayout((LayoutKind)2, Size = 40)]
internal struct DualShockHIDOutputReport : IInputDeviceCommandInfo
{
	[Flags]
	public enum Flags
	{
		Rumble = 1,
		Color = 2
	}

	internal const int kSize = 40;

	internal const int kReportId = 5;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public byte reportId;

	[FieldOffset(9)]
	public byte flags;

	[FieldOffset(10)]
	public unsafe fixed byte unknown1[2];

	[FieldOffset(12)]
	public byte highFrequencyMotorSpeed;

	[FieldOffset(13)]
	public byte lowFrequencyMotorSpeed;

	[FieldOffset(14)]
	public byte redColor;

	[FieldOffset(15)]
	public byte greenColor;

	[FieldOffset(16)]
	public byte blueColor;

	[FieldOffset(17)]
	public unsafe fixed byte unknown2[23];

	public static FourCC Type => default(FourCC);

	public FourCC typeStatic => default(FourCC);

	public void SetMotorSpeeds(float lowFreq, float highFreq)
	{
	}

	public void SetColor(Color color)
	{
	}

	public static DualShockHIDOutputReport Create()
	{
		return default(DualShockHIDOutputReport);
	}
}
