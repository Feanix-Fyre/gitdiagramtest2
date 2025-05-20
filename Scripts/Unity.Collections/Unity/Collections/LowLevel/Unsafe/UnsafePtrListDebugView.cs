using System;

namespace Unity.Collections.LowLevel.Unsafe;

internal sealed class UnsafePtrListDebugView
{
	private UnsafePtrList Data;

	public IntPtr[] Items => null;

	public UnsafePtrListDebugView(UnsafePtrList data)
	{
	}
}
