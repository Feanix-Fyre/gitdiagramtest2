using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 16)]
internal struct WarpMousePositionCommand : IInputDeviceCommandInfo
{
	internal const int kSize = 16;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public Vector2 warpPositionInPlayerDisplaySpace;

	public static FourCC Type => default(FourCC);

	public FourCC typeStatic => default(FourCC);

	public static WarpMousePositionCommand Create(Vector2 position)
	{
		return default(WarpMousePositionCommand);
	}
}
