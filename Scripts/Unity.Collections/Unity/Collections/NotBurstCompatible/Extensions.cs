using System;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections.NotBurstCompatible;

public static class Extensions
{
	[NotBurstCompatible]
	public static T[] ToArray<T>(this NativeParallelHashSet<T> set) where T : struct, IEquatable<T>
	{
		return null;
	}

	[NotBurstCompatible]
	public static T[] ToArrayNBC<T>(this NativeList<T> list) where T : struct
	{
		return null;
	}

	[NotBurstCompatible]
	public static void CopyFromNBC<T>(this NativeList<T> list, T[] array) where T : struct
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	[Obsolete("Burst now supports tuple, please use `GetUniqueKeyArray` method from `Unity.Collections.UnsafeParallelMultiHashMap` instead.", false)]
	public static (NativeArray<TKey>, int) GetUniqueKeyArrayNBC<TKey, TValue>(this UnsafeParallelMultiHashMap<TKey, TValue> hashmap, AllocatorManager.AllocatorHandle allocator) where TKey : struct, IEquatable<TKey>, IComparable<TKey> where TValue : struct
	{
		return default((NativeArray<TKey>, int));
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	[Obsolete("Burst now supports tuple, please use `GetUniqueKeyArray` method from `Unity.Collections.NativeParallelMultiHashMap` instead.", false)]
	public static (NativeArray<TKey>, int) GetUniqueKeyArrayNBC<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> hashmap, AllocatorManager.AllocatorHandle allocator) where TKey : struct, IEquatable<TKey>, IComparable<TKey> where TValue : struct
	{
		return default((NativeArray<TKey>, int));
	}
}
