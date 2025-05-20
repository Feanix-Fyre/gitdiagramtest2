using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 8)]
public struct DisableDeviceCommand : IInputDeviceCommandInfo
{
	internal const int kSize = 8;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	public static FourCC Type => default(FourCC);

	public FourCC typeStatic => default(FourCC);

	public static DisableDeviceCommand Create()
	{
		return default(DisableDeviceCommand);
	}
}
