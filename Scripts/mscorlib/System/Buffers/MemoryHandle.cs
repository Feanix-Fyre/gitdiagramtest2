using System.Runtime.InteropServices;

namespace System.Buffers;

public struct MemoryHandle : IDisposable
{
	private unsafe void* _pointer;

	private GCHandle _handle;

	private IPinnable _pinnable;

	[CLSCompliant(false)]
	public unsafe void* Pointer => null;

	[CLSCompliant(false)]
	public unsafe MemoryHandle(void* pointer, GCHandle handle = default(GCHandle), IPinnable pinnable = null)
	{
		_pointer = null;
		_handle = default(GCHandle);
		_pinnable = null;
	}

	public void Dispose()
	{
	}
}
