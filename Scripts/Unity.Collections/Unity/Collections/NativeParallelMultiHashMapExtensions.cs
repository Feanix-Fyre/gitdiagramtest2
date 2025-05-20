using System;

namespace Unity.Collections;

[BurstCompatible]
public static class NativeParallelMultiHashMapExtensions
{
	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int),
		typeof(AllocatorManager.AllocatorHandle)
	})]
	internal static void Initialize<TKey, TValue, U>(this ref NativeParallelMultiHashMap<TKey, TValue> container, int capacity, ref U allocator, int disposeSentinelStackDepth = 2) where TKey : struct, IEquatable<TKey> where TValue : struct where U : struct, AllocatorManager.IAllocator
	{
	}
}
