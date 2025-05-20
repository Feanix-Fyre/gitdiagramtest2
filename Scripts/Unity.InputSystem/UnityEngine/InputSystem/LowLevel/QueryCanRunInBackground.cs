using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 12)]
public struct QueryCanRunInBackground : IInputDeviceCommandInfo
{
	internal const int kSize = 9;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public bool canRunInBackground;

	public static FourCC Type => default(FourCC);

	public FourCC typeStatic => default(FourCC);

	public static QueryCanRunInBackground Create()
	{
		return default(QueryCanRunInBackground);
	}
}
