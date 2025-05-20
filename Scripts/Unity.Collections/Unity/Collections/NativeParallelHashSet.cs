using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections;

[DebuggerTypeProxy(typeof(NativeHashSetDebuggerTypeProxy<>))]
[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
public struct NativeParallelHashSet<T> : INativeDisposable, IDisposable, IEnumerable<T>, IEnumerable where T : struct, IEquatable<T>
{
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	[NativeContainerIsAtomicWriteOnly]
	public struct ParallelWriter
	{
		internal NativeParallelHashMap<T, bool>.ParallelWriter m_Data;

		public int Capacity => 0;

		public bool Add(T item)
		{
			return false;
		}
	}

	[NativeContainer]
	[NativeContainerIsReadOnly]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator;

		public T Current => default(T);

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

	internal NativeParallelHashMap<T, bool> m_Data;

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

	public NativeParallelHashSet(int capacity, AllocatorManager.AllocatorHandle allocator)
	{
		m_Data = default(NativeParallelHashMap<T, bool>);
	}

	public int Count()
	{
		return 0;
	}

	public void Dispose()
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

	public bool Add(T item)
	{
		return false;
	}

	public bool Remove(T item)
	{
		return false;
	}

	public bool Contains(T item)
	{
		return false;
	}

	public NativeArray<T> ToNativeArray(AllocatorManager.AllocatorHandle allocator)
	{
		return default(NativeArray<T>);
	}

	public ParallelWriter AsParallelWriter()
	{
		return default(ParallelWriter);
	}

	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
