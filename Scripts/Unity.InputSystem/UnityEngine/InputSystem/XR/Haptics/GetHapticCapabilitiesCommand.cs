using System.Runtime.InteropServices;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.XR.Haptics;

[StructLayout((LayoutKind)2, Size = 20)]
public struct GetHapticCapabilitiesCommand : IInputDeviceCommandInfo
{
	private const int kSize = 20;

	[FieldOffset(0)]
	private InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public uint numChannels;

	[FieldOffset(12)]
	public uint frequencyHz;

	[FieldOffset(16)]
	public uint maxBufferSize;

	private static FourCC Type => default(FourCC);

	public FourCC typeStatic => default(FourCC);

	public HapticCapabilities capabilities => default(HapticCapabilities);

	public static GetHapticCapabilitiesCommand Create()
	{
		return default(GetHapticCapabilitiesCommand);
	}
}
