using System;

namespace Unity.Collections;

internal struct UnmanagedArray<T> : IDisposable where T : unmanaged
{
	private IntPtr m_pointer;

	private int m_length;

	private AllocatorManager.AllocatorHandle m_allocator;

	public ref T this[int index]
	{
		get
		{
			throw null;
		}
	}

	public UnmanagedArray(int length, AllocatorManager.AllocatorHandle allocator)
	{
		m_pointer = (IntPtr)0;
		m_length = 0;
		m_allocator = default(AllocatorManager.AllocatorHandle);
	}

	public void Dispose()
	{
	}

	public unsafe T* GetUnsafePointer()
	{
		return null;
	}
}
