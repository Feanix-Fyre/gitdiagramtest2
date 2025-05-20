using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 264)]
public struct QueryKeyboardLayoutCommand : IInputDeviceCommandInfo
{
	internal const int kMaxNameLength = 256;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public unsafe fixed byte nameBuffer[256];

	public static FourCC Type => default(FourCC);

	public FourCC typeStatic => default(FourCC);

	public string ReadLayoutName()
	{
		return null;
	}

	public void WriteLayoutName(string name)
	{
	}

	public static QueryKeyboardLayoutCommand Create()
	{
		return default(QueryKeyboardLayoutCommand);
	}
}
