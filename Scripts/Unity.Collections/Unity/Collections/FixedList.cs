using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Unity.Collections;

[Serializable]
[BurstCompatible(GenericTypeArguments = new Type[]
{
	typeof(int),
	typeof(FixedBytes30)
})]
internal struct FixedList<T, U> : INativeList<T>, IIndexable<T> where T : struct where U : struct
{
	[SerializeField]
	internal ushort length;

	[SerializeField]
	internal U buffer;

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
}
[StructLayout((LayoutKind)0, Size = 1)]
[BurstCompatible]
internal struct FixedList
{
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	internal static int PaddingBytes<T>() where T : struct
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	internal static int StorageBytes<BUFFER, T>() where BUFFER : struct where T : struct
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	internal static int Capacity<BUFFER, T>() where BUFFER : struct where T : struct
	{
		return 0;
	}

	[Conditional("UNITY_DOTS_DEBUG")]
	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	internal static void CheckResize<BUFFER, T>(int newLength) where BUFFER : struct where T : struct
	{
	}
}
