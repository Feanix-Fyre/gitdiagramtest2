using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Unity.Collections;

[Serializable]
[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
[DebuggerTypeProxy(typeof(FixedList32BytesDebugView<>))]
public struct FixedList32Bytes<T> : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> where T : struct
{
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private FixedList32Bytes<T> m_List;

		private int m_Index;

		public T Current => default(T);

		object IEnumerator.Current => null;

		public Enumerator(ref FixedList32Bytes<T> list)
		{
			m_List = default(FixedList32Bytes<T>);
			m_Index = 0;
		}

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

	[SerializeField]
	internal ushort length;

	[SerializeField]
	internal FixedBytes30 buffer;

	[CreateProperty]
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

	[CreateProperty]
	private IEnumerable<T> Elements => null;

	public bool IsEmpty => false;

	internal int LengthInBytes => 0;

	internal unsafe byte* Buffer => null;

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

	public ref T ElementAt(int index)
	{
		throw null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public void Add(in T item)
	{
	}

	public unsafe void AddRange(void* ptr, int length)
	{
	}

	public void AddNoResize(in T item)
	{
	}

	public unsafe void AddRangeNoResize(void* ptr, int length)
	{
	}

	public void Clear()
	{
	}

	public void InsertRangeWithBeginEnd(int begin, int end)
	{
	}

	public void Insert(int index, in T item)
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

	[NotBurstCompatible]
	public T[] ToArray()
	{
		return null;
	}

	public NativeArray<T> ToNativeArray(AllocatorManager.AllocatorHandle allocator)
	{
		return default(NativeArray<T>);
	}

	public static bool operator ==(in FixedList32Bytes<T> a, in FixedList32Bytes<T> b)
	{
		return false;
	}

	public static bool operator !=(in FixedList32Bytes<T> a, in FixedList32Bytes<T> b)
	{
		return false;
	}

	public int CompareTo(FixedList32Bytes<T> other)
	{
		return 0;
	}

	public bool Equals(FixedList32Bytes<T> other)
	{
		return false;
	}

	public static bool operator ==(in FixedList32Bytes<T> a, in FixedList64Bytes<T> b)
	{
		return false;
	}

	public static bool operator !=(in FixedList32Bytes<T> a, in FixedList64Bytes<T> b)
	{
		return false;
	}

	public int CompareTo(FixedList64Bytes<T> other)
	{
		return 0;
	}

	public bool Equals(FixedList64Bytes<T> other)
	{
		return false;
	}

	public FixedList32Bytes(in FixedList64Bytes<T> other)
	{
		length = 0;
		buffer = default(FixedBytes30);
	}

	internal int Initialize(in FixedList64Bytes<T> other)
	{
		return 0;
	}

	public static implicit operator FixedList32Bytes<T>(in FixedList64Bytes<T> other)
	{
		return default(FixedList32Bytes<T>);
	}

	public static bool operator ==(in FixedList32Bytes<T> a, in FixedList128Bytes<T> b)
	{
		return false;
	}

	public static bool operator !=(in FixedList32Bytes<T> a, in FixedList128Bytes<T> b)
	{
		return false;
	}

	public int CompareTo(FixedList128Bytes<T> other)
	{
		return 0;
	}

	public bool Equals(FixedList128Bytes<T> other)
	{
		return false;
	}

	public FixedList32Bytes(in FixedList128Bytes<T> other)
	{
		length = 0;
		buffer = default(FixedBytes30);
	}

	internal int Initialize(in FixedList128Bytes<T> other)
	{
		return 0;
	}

	public static implicit operator FixedList32Bytes<T>(in FixedList128Bytes<T> other)
	{
		return default(FixedList32Bytes<T>);
	}

	public static bool operator ==(in FixedList32Bytes<T> a, in FixedList512Bytes<T> b)
	{
		return false;
	}

	public static bool operator !=(in FixedList32Bytes<T> a, in FixedList512Bytes<T> b)
	{
		return false;
	}

	public int CompareTo(FixedList512Bytes<T> other)
	{
		return 0;
	}

	public bool Equals(FixedList512Bytes<T> other)
	{
		return false;
	}

	public FixedList32Bytes(in FixedList512Bytes<T> other)
	{
		length = 0;
		buffer = default(FixedBytes30);
	}

	internal int Initialize(in FixedList512Bytes<T> other)
	{
		return 0;
	}

	public static implicit operator FixedList32Bytes<T>(in FixedList512Bytes<T> other)
	{
		return default(FixedList32Bytes<T>);
	}

	public static bool operator ==(in FixedList32Bytes<T> a, in FixedList4096Bytes<T> b)
	{
		return false;
	}

	public static bool operator !=(in FixedList32Bytes<T> a, in FixedList4096Bytes<T> b)
	{
		return false;
	}

	public int CompareTo(FixedList4096Bytes<T> other)
	{
		return 0;
	}

	public bool Equals(FixedList4096Bytes<T> other)
	{
		return false;
	}

	public FixedList32Bytes(in FixedList4096Bytes<T> other)
	{
		length = 0;
		buffer = default(FixedBytes30);
	}

	internal int Initialize(in FixedList4096Bytes<T> other)
	{
		return 0;
	}

	public static implicit operator FixedList32Bytes<T>(in FixedList4096Bytes<T> other)
	{
		return default(FixedList32Bytes<T>);
	}

	[NotBurstCompatible]
	public override bool Equals(object obj)
	{
		return false;
	}

	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}
}
