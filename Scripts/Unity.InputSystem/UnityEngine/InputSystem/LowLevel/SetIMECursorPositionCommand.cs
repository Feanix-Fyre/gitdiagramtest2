using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 16)]
public struct SetIMECursorPositionCommand : IInputDeviceCommandInfo
{
	internal const int kSize = 16;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	private Vector2 m_Position;

	public static FourCC Type => default(FourCC);

	public Vector2 position => default(Vector2);

	public FourCC typeStatic => default(FourCC);

	public static SetIMECursorPositionCommand Create(Vector2 cursorPosition)
	{
		return default(SetIMECursorPositionCommand);
	}
}
