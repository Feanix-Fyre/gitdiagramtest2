using System;
using System.Diagnostics;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections;

[NativeContainer]
[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
public struct NativeQueue<T> : INativeDisposable, IDisposable where T : struct
{
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	[NativeContainerIsAtomicWriteOnly]
	[NativeContainer]
	public struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		internal unsafe NativeQueueData* m_Buffer;

		[NativeDisableUnsafePtrRestriction]
		internal unsafe NativeQueueBlockPoolData* m_QueuePool;

		[NativeSetThreadIndex]
		internal int m_ThreadIndex;

		public void Enqueue(T value)
		{
		}
	}

	[NativeDisableUnsafePtrRestriction]
	private unsafe NativeQueueData* m_Buffer;

	[NativeDisableUnsafePtrRestriction]
	private unsafe NativeQueueBlockPoolData* m_QueuePool;

	private AllocatorManager.AllocatorHandle m_AllocatorLabel;

	public int Count => 0;

	internal static int PersistentMemoryBlockCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal static int MemoryBlockSize => 0;

	public bool IsCreated => false;

	public unsafe NativeQueue(AllocatorManager.AllocatorHandle allocator)
	{
		m_Buffer = null;
		m_QueuePool = null;
		m_AllocatorLabel = default(AllocatorManager.AllocatorHandle);
	}

	public bool IsEmpty()
	{
		return false;
	}

	public T Peek()
	{
		return default(T);
	}

	public void Enqueue(T value)
	{
	}

	public T Dequeue()
	{
		return default(T);
	}

	public bool TryDequeue(out T item)
	{
		item = default(T);
		return false;
	}

	public NativeArray<T> ToArray(AllocatorManager.AllocatorHandle allocator)
	{
		return default(NativeArray<T>);
	}

	public void Clear()
	{
	}

	public void Dispose()
	{
	}

	[NotBurstCompatible]
	public JobHandle Dispose(JobHandle inputDeps)
	{
		return default(JobHandle);
	}

	public ParallelWriter AsParallelWriter()
	{
		return default(ParallelWriter);
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckRead()
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckReadNotEmpty()
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckWrite()
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void ThrowEmpty()
	{
	}
}
