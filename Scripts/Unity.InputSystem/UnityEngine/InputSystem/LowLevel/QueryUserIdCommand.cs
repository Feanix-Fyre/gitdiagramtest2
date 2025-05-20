using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 520)]
internal struct QueryUserIdCommand : IInputDeviceCommandInfo
{
	public const int kMaxIdLength = 256;

	internal const int kSize = 520;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public unsafe fixed byte idBuffer[512];

	public static FourCC Type => default(FourCC);

	public FourCC typeStatic => default(FourCC);

	public string ReadId()
	{
		return null;
	}

	public static QueryUserIdCommand Create()
	{
		return default(QueryUserIdCommand);
	}
}
