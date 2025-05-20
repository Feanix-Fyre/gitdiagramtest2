using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 8)]
public struct InputDeviceCommand : IInputDeviceCommandInfo
{
	internal const int kBaseCommandSize = 8;

	public const int BaseCommandSize = 8;

	public const long GenericFailure = -1L;

	public const long GenericSuccess = 1L;

	[FieldOffset(0)]
	public FourCC type;

	[FieldOffset(4)]
	public int sizeInBytes;

	public int payloadSizeInBytes => 0;

	public unsafe void* payloadPtr => null;

	public FourCC typeStatic => default(FourCC);

	public InputDeviceCommand(FourCC type, int sizeInBytes = 8)
	{
		this.type = default(FourCC);
		this.sizeInBytes = 0;
	}

	public static NativeArray<byte> AllocateNative(FourCC type, int payloadSize)
	{
		return default(NativeArray<byte>);
	}
}
