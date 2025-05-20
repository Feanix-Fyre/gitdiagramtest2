using System;
using System.Runtime.InteropServices;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal;

internal struct PinnedArray<T> : IDisposable where T : struct
{
	public T[] managedArray;

	public GCHandle handle;

	public NativeArray<T> nativeArray;

	public int length => 0;

	public PinnedArray(int length)
	{
		managedArray = null;
		handle = default(GCHandle);
		nativeArray = default(NativeArray<T>);
	}

	public void Dispose()
	{
	}
}
