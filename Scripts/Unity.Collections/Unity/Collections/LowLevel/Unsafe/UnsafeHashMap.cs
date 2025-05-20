using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe;

[Obsolete("UnsafeHashMap is renamed to UnsafeParallelHashMap. (UnityUpgradable) -> UnsafeParallelHashMap<TKey, TValue>", false)]
public struct UnsafeHashMap<TKey, TValue> : INativeDisposable, IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable where TKey : struct, IEquatable<TKey> where TValue : struct
{
	[NativeContainerIsAtomicWriteOnly]
	public struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMapData* m_Buffer;

		[NativeSetThreadIndex]
		internal int m_ThreadIndex;

		public int Capacity => 0;

		public bool TryAdd(TKey key, TValue item)
		{
			return false;
		}
	}

	public struct Enumerator : IEnumerator<KeyValue<TKey, TValue>>, IEnumerator, IDisposable
	{
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator;

		public KeyValue<TKey, TValue> Current => default(KeyValue<TKey, TValue>);

		object IEnumerator.Current => null;

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeParallelHashMapData* m_Buffer;

	internal AllocatorManager.AllocatorHandle m_AllocatorLabel;

	public bool IsEmpty => false;

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

	public TValue this[TKey key]
	{
		get
		{
			return default(TValue);
		}
		set
		{
		}
	}

	public bool IsCreated => false;

	public unsafe UnsafeHashMap(int capacity, AllocatorManager.AllocatorHandle allocator)
	{
		m_Buffer = null;
		m_AllocatorLabel = default(AllocatorManager.AllocatorHandle);
	}

	public int Count()
	{
		return 0;
	}

	public void Clear()
	{
	}

	public bool TryAdd(TKey key, TValue item)
	{
		return false;
	}

	public void Add(TKey key, TValue item)
	{
	}

	public bool Remove(TKey key)
	{
		return false;
	}

	public bool TryGetValue(TKey key, out TValue item)
	{
		item = default(TValue);
		return false;
	}

	public bool ContainsKey(TKey key)
	{
		return false;
	}

	public void Dispose()
	{
	}

	[NotBurstCompatible]
	public JobHandle Dispose(JobHandle inputDeps)
	{
		return default(JobHandle);
	}

	public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator)
	{
		return default(NativeArray<TKey>);
	}

	public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator)
	{
		return default(NativeArray<TValue>);
	}

	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorManager.AllocatorHandle allocator)
	{
		return default(NativeKeyValueArrays<TKey, TValue>);
	}

	public ParallelWriter AsParallelWriter()
	{
		return default(ParallelWriter);
	}

	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	IEnumerator<KeyValue<TKey, TValue>> IEnumerable<KeyValue<TKey, TValue>>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
