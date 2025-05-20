using System.Runtime.InteropServices;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.XR.Haptics;

[StructLayout((LayoutKind)2, Size = 1040)]
public struct SendBufferedHapticCommand : IInputDeviceCommandInfo
{
	private const int kMaxHapticBufferSize = 1024;

	private const int kSize = 1040;

	[FieldOffset(0)]
	private InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	private int channel;

	[FieldOffset(12)]
	private int bufferSize;

	[FieldOffset(16)]
	private unsafe fixed byte buffer[1024];

	private static FourCC Type => default(FourCC);

	public FourCC typeStatic => default(FourCC);

	public static SendBufferedHapticCommand Create(byte[] rumbleBuffer)
	{
		return default(SendBufferedHapticCommand);
	}
}
