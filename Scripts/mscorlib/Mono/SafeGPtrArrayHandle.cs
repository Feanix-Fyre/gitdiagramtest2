using System;

namespace Mono;

internal struct SafeGPtrArrayHandle : IDisposable
{
	private RuntimeGPtrArrayHandle handle;

	internal int Length => 0;

	internal IntPtr this[int i] => (IntPtr)0;

	internal SafeGPtrArrayHandle(IntPtr ptr)
	{
		handle = default(RuntimeGPtrArrayHandle);
	}

	public void Dispose()
	{
	}
}
