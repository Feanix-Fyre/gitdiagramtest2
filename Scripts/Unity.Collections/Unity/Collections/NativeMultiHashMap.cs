using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections;

[NativeContainer]
[Obsolete("NativeMultiHashMap is renamed to NativeParallelMultiHashMap. (UnityUpgradable) -> NativeParallelMultiHashMap<TKey, TValue>", false)]
public struct NativeMultiHashMap<TKey, TValue> : INativeDisposable, IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable where TKey : struct, IEquatable<TKey> where TValue : struct
{
	[NativeContainerIsAtomicWriteOnly]
	[NativeContainer]
	public struct ParallelWriter
	{
		internal UnsafeParallelMultiHashMap<TKey, TValue>.ParallelWriter m_Writer;

		public int m_ThreadIndex => 0;

		public int Capacity => 0;

		public void Add(TKey key, TValue item)
		{
		}
	}

	public struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
	{
		internal NativeMultiHashMap<TKey, TValue> hashmap;

		internal TKey key;

		internal bool isFirst;

		private TValue value;

		private NativeParallelMultiHashMapIterator<TKey> iterator;

		public TValue Current => default(TValue);

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

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}

	[NativeContainer]
	[NativeContainerIsReadOnly]
	public struct KeyValueEnumerator : IEnumerator<KeyValue<TKey, TValue>>, IEnumerator, IDisposable
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

	internal UnsafeParallelMultiHashMap<TKey, TValue> m_MultiHashMapData;

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

	public bool IsCreated => false;

	public NativeMultiHashMap(int capacity, AllocatorManager.AllocatorHandle allocator)
	{
		m_MultiHashMapData = default(UnsafeParallelMultiHashMap<TKey, TValue>);
	}

	internal void Initialize<U>(int capacity, ref U allocator, int disposeSentinelStackDepth) where U : struct, AllocatorManager.IAllocator
	{
	}

	private NativeMultiHashMap(int capacity, AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth)
	{
		m_MultiHashMapData = default(UnsafeParallelMultiHashMap<TKey, TValue>);
	}

	public int Count()
	{
		return 0;
	}

	public void Clear()
	{
	}

	public void Add(TKey key, TValue item)
	{
	}

	public int Remove(TKey key)
	{
		return 0;
	}

	public void Remove(NativeParallelMultiHashMapIterator<TKey> it)
	{
	}

	public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey> it)
	{
		item = default(TValue);
		it = default(NativeParallelMultiHashMapIterator<TKey>);
		return false;
	}

	public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey> it)
	{
		item = default(TValue);
		return false;
	}

	public bool ContainsKey(TKey key)
	{
		return false;
	}

	public int CountValuesForKey(TKey key)
	{
		return 0;
	}

	public bool SetValue(TValue item, NativeParallelMultiHashMapIterator<TKey> it)
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

	public Enumerator GetValuesForKey(TKey key)
	{
		return default(Enumerator);
	}

	public KeyValueEnumerator GetEnumerator()
	{
		return default(KeyValueEnumerator);
	}

	IEnumerator<KeyValue<TKey, TValue>> IEnumerable<KeyValue<TKey, TValue>>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckRead()
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckWrite()
	{
	}
}
