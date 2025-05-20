using System;

namespace Unity.Collections;

[BurstCompatible(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
public struct AllocatorHelper<T> : IDisposable where T : struct, AllocatorManager.IAllocator
{
	private unsafe readonly T* m_allocator;

	private AllocatorManager.AllocatorHandle m_backingAllocator;

	public ref T Allocator
	{
		get
		{
			throw null;
		}
	}

	[NotBurstCompatible]
	public unsafe AllocatorHelper(AllocatorManager.AllocatorHandle backingAllocator)
	{
		m_allocator = null;
		m_backingAllocator = default(AllocatorManager.AllocatorHandle);
	}

	[NotBurstCompatible]
	public void Dispose()
	{
	}
}
