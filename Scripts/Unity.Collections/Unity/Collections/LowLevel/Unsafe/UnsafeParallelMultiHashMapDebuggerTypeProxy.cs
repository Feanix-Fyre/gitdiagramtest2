using System;
using System.Collections.Generic;

namespace Unity.Collections.LowLevel.Unsafe;

internal sealed class UnsafeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue> where TKey : struct, IEquatable<TKey>, IComparable<TKey> where TValue : struct
{
	private UnsafeParallelMultiHashMap<TKey, TValue> m_Target;

	public List<ListPair<TKey, List<TValue>>> Items => null;

	public UnsafeParallelMultiHashMapDebuggerTypeProxy(UnsafeParallelMultiHashMap<TKey, TValue> target)
	{
	}

	public static (NativeArray<TKey>, int) GetUniqueKeyArray(ref UnsafeParallelMultiHashMap<TKey, TValue> hashMap, AllocatorManager.AllocatorHandle allocator)
	{
		return default((NativeArray<TKey>, int));
	}
}
