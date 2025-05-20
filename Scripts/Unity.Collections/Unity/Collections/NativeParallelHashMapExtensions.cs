using System;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[BurstCompatible]
public static class NativeParallelHashMapExtensions
{
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static int Unique<T>(this NativeArray<T> array) where T : struct, IEquatable<T>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static (NativeArray<TKey>, int) GetUniqueKeyArray<TKey, TValue>(this UnsafeParallelMultiHashMap<TKey, TValue> container, AllocatorManager.AllocatorHandle allocator) where TKey : struct, IEquatable<TKey>, IComparable<TKey> where TValue : struct
	{
		return default((NativeArray<TKey>, int));
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static (NativeArray<TKey>, int) GetUniqueKeyArray<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> container, AllocatorManager.AllocatorHandle allocator) where TKey : struct, IEquatable<TKey>, IComparable<TKey> where TValue : struct
	{
		return default((NativeArray<TKey>, int));
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	[Obsolete("GetBucketData is deprecated, please use GetUnsafeBucketData instead. (RemovedAfter 2021-07-08) (UnityUpgradable) -> GetUnsafeBucketData<TKey,TValue>(*)", false)]
	public static UnsafeHashMapBucketData GetBucketData<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> container) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeHashMapBucketData);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static UnsafeHashMapBucketData GetUnsafeBucketData<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> container) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeHashMapBucketData);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static UnsafeHashMapBucketData GetUnsafeBucketData<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> container) where TKey : struct, IEquatable<TKey> where TValue : struct
	{
		return default(UnsafeHashMapBucketData);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static void Remove<TKey, TValue>(this NativeParallelMultiHashMap<TKey, TValue> container, TKey key, TValue value) where TKey : struct, IEquatable<TKey> where TValue : struct, IEquatable<TValue>
	{
	}
}
