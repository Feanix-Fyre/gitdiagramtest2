using System.Runtime.InteropServices;

namespace UnityEngineInternal.Input;

[StructLayout((LayoutKind)2, Pack = 1, Size = 20)]
internal struct NativeInputEvent
{
	public const int structSize = 20;

	[FieldOffset(0)]
	public NativeInputEventType type;

	[FieldOffset(4)]
	public ushort sizeInBytes;

	[FieldOffset(6)]
	public ushort deviceId;

	[FieldOffset(8)]
	public double time;

	[FieldOffset(16)]
	public int eventId;
}
