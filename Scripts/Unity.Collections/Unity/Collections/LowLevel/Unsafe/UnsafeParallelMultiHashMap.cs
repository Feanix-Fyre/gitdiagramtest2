using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompatible(GenericTypeArguments = new Type[]
{
	typeof(int),
	typeof(int)
})]
[DebuggerTypeProxy(typeof(UnsafeParallelMultiHashMapDebuggerTypeProxy<, >))]
public struct UnsafeParallelMultiHashMap<TKey, TValue> : INativeDisposable, IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable where TKey : struct, IEquatable<TKey> where TValue : struct
{
	public struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
	{
		internal UnsafeParallelMultiHashMap<TKey, TValue> hashmap;

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

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	[NativeContainerIsAtomicWriteOnly]
	public struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMapData* m_Buffer;

		[NativeSetThreadIndex]
		internal int m_ThreadIndex;

		public int Capacity => 0;

		public void Add(TKey key, TValue item)
		{
		}
	}

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

	public bool IsCreated => false;

	public unsafe UnsafeParallelMultiHashMap(int capacity, AllocatorManager.AllocatorHandle allocator)
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

	public void Add(TKey key, TValue item)
	{
	}

	public int Remove(TKey key)
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public void Remove<TValueEQ>(TKey key, TValueEQ value) where TValueEQ : struct, IEquatable<TValueEQ>
	{
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

	public Enumerator GetValuesForKey(TKey key)
	{
		return default(Enumerator);
	}

	public ParallelWriter AsParallelWriter()
	{
		return default(ParallelWriter);
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
}
