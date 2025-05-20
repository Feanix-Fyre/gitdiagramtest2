using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 12)]
public struct QueryEnabledStateCommand : IInputDeviceCommandInfo
{
	internal const int kSize = 9;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public bool isEnabled;

	public static FourCC Type => default(FourCC);

	public FourCC typeStatic => default(FourCC);

	public static QueryEnabledStateCommand Create()
	{
		return default(QueryEnabledStateCommand);
	}
}
