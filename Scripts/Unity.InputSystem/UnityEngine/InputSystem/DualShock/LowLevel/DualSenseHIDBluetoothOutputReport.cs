using System.Runtime.InteropServices;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock.LowLevel;

[StructLayout((LayoutKind)2, Size = 86)]
internal struct DualSenseHIDBluetoothOutputReport : IInputDeviceCommandInfo
{
	internal const int kSize = 86;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public byte reportId;

	[FieldOffset(9)]
	public byte tag1;

	[FieldOffset(10)]
	public byte tag2;

	[FieldOffset(11)]
	public DualSenseHIDOutputReportPayload payload;

	[FieldOffset(82)]
	public uint crc32;

	[FieldOffset(8)]
	public unsafe fixed byte rawData[74];

	public static FourCC Type => default(FourCC);

	public FourCC typeStatic => default(FourCC);

	public static DualSenseHIDBluetoothOutputReport Create(DualSenseHIDOutputReportPayload payload, byte outputSequenceId)
	{
		return default(DualSenseHIDBluetoothOutputReport);
	}
}
