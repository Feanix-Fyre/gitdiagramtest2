using System.Runtime.InteropServices;

namespace UnityEngineInternal.Input;

[StructLayout((LayoutKind)2, Pack = 1, Size = 20)]
internal struct NativeInputEventBuffer
{
	[FieldOffset(0)]
	public unsafe void* eventBuffer;

	[FieldOffset(8)]
	public int eventCount;

	[FieldOffset(12)]
	public int sizeInBytes;

	[FieldOffset(16)]
	public int capacityInBytes;
}
