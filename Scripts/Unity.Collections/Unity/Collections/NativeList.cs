using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections;

[DebuggerTypeProxy(typeof(NativeListDebugView<>))]
[DebuggerDisplay("Length = {Length}")]
[NativeContainer]
[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
public struct NativeList<T> : INativeDisposable, IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable where T : struct
{
	[NativeContainer]
	[NativeContainerIsAtomicWriteOnly]
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeList<T>* ListData;

		public unsafe readonly void* Ptr => null;

		internal unsafe ParallelWriter(UnsafeList<T>* listData)
		{
			ListData = null;
		}

		public void AddNoResize(T value)
		{
		}

		public unsafe void AddRangeNoResize(void* ptr, int count)
		{
		}

		public void AddRangeNoResize(UnsafeList<T> list)
		{
		}

		public void AddRangeNoResize(NativeList<T> list)
		{
		}
	}

	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<T>* m_ListData;

	internal AllocatorManager.AllocatorHandle m_DeprecatedAllocator;

	public T this[int index]
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public int Length
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Capacity
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsEmpty => false;

	public bool IsCreated => false;

	public unsafe NativeList(AllocatorManager.AllocatorHandle allocator)
	{
		m_ListData = null;
		m_DeprecatedAllocator = default(AllocatorManager.AllocatorHandle);
	}

	public unsafe NativeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator)
	{
		m_ListData = null;
		m_DeprecatedAllocator = default(AllocatorManager.AllocatorHandle);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
	internal void Initialize<U>(int initialCapacity, ref U allocator, int disposeSentinelStackDepth) where U : struct, AllocatorManager.IAllocator
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
	internal static NativeList<T> New<U>(int initialCapacity, ref U allocator, int disposeSentinelStackDepth) where U : struct, AllocatorManager.IAllocator
	{
		return default(NativeList<T>);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
	internal static NativeList<T> New<U>(int initialCapacity, ref U allocator) where U : struct, AllocatorManager.IAllocator
	{
		return default(NativeList<T>);
	}

	private unsafe NativeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth)
	{
		m_ListData = null;
		m_DeprecatedAllocator = default(AllocatorManager.AllocatorHandle);
	}

	public ref T ElementAt(int index)
	{
		throw null;
	}

	public unsafe UnsafeList<T>* GetUnsafeList()
	{
		return null;
	}

	public void AddNoResize(T value)
	{
	}

	public unsafe void AddRangeNoResize(void* ptr, int count)
	{
	}

	public void AddRangeNoResize(NativeList<T> list)
	{
	}

	public void Add(in T value)
	{
	}

	public void AddRange(NativeArray<T> array)
	{
	}

	public unsafe void AddRange(void* ptr, int count)
	{
	}

	public void InsertRangeWithBeginEnd(int begin, int end)
	{
	}

	public void RemoveAtSwapBack(int index)
	{
	}

	public void RemoveRangeSwapBack(int index, int count)
	{
	}

	[Obsolete("RemoveRangeSwapBackWithBeginEnd(begin, end) is deprecated, use RemoveRangeSwapBack(index, count) instead. (RemovedAfter 2021-06-02)", false)]
	public void RemoveRangeSwapBackWithBeginEnd(int begin, int end)
	{
	}

	public void RemoveAt(int index)
	{
	}

	public void RemoveRange(int index, int count)
	{
	}

	[Obsolete("RemoveRangeWithBeginEnd(begin, end) is deprecated, use RemoveRange(index, count) instead. (RemovedAfter 2021-06-02)", false)]
	public void RemoveRangeWithBeginEnd(int begin, int end)
	{
	}

	public void Dispose()
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
	internal void Dispose<U>(ref U allocator) where U : struct, AllocatorManager.IAllocator
	{
	}

	[NotBurstCompatible]
	public JobHandle Dispose(JobHandle inputDeps)
	{
		return default(JobHandle);
	}

	public void Clear()
	{
	}

	public static implicit operator NativeArray<T>(NativeList<T> nativeList)
	{
		return default(NativeArray<T>);
	}

	public NativeArray<T> AsArray()
	{
		return default(NativeArray<T>);
	}

	public NativeArray<T> AsDeferredJobArray()
	{
		return default(NativeArray<T>);
	}

	[NotBurstCompatible]
	public T[] ToArray()
	{
		return null;
	}

	public NativeArray<T> ToArray(AllocatorManager.AllocatorHandle allocator)
	{
		return default(NativeArray<T>);
	}

	public NativeArray<T>.Enumerator GetEnumerator()
	{
		return default(NativeArray<T>.Enumerator);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[NotBurstCompatible]
	[Obsolete("Please use `CopyFromNBC` from `Unity.Collections.NotBurstCompatible` namespace instead. (RemovedAfter 2021-06-22)", false)]
	public void CopyFrom(T[] array)
	{
	}

	public void CopyFrom(NativeArray<T> array)
	{
	}

	public void Resize(int length, NativeArrayOptions options)
	{
	}

	public void ResizeUninitialized(int length)
	{
	}

	public void SetCapacity(int capacity)
	{
	}

	public void TrimExcess()
	{
	}

	public NativeArray<T>.ReadOnly AsParallelReader()
	{
		return default(NativeArray<T>.ReadOnly);
	}

	public ParallelWriter AsParallelWriter()
	{
		return default(ParallelWriter);
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckInitialCapacity(int initialCapacity)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckTotalSize(int initialCapacity, long totalSize)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckSufficientCapacity(int capacity, int length)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckIndexInRange(int value, int length)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckArgPositive(int value)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckHandleMatches(AllocatorManager.AllocatorHandle handle)
	{
	}
}
