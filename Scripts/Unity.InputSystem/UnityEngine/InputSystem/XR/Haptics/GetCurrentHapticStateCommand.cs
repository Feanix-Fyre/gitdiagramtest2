using System.Runtime.InteropServices;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.XR.Haptics;

[StructLayout((LayoutKind)2, Size = 16)]
public struct GetCurrentHapticStateCommand : IInputDeviceCommandInfo
{
	private const int kSize = 16;

	[FieldOffset(0)]
	private InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public uint samplesQueued;

	[FieldOffset(12)]
	public uint samplesAvailable;

	private static FourCC Type => default(FourCC);

	public FourCC typeStatic => default(FourCC);

	public HapticState currentState => default(HapticState);

	public static GetCurrentHapticStateCommand Create()
	{
		return default(GetCurrentHapticStateCommand);
	}
}
