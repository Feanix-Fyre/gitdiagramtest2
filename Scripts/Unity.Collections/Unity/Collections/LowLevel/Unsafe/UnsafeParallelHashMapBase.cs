using System;
using System.Diagnostics;

namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompatible(GenericTypeArguments = new Type[]
{
	typeof(int),
	typeof(int)
})]
internal struct UnsafeParallelHashMapBase<TKey, TValue> where TKey : struct, IEquatable<TKey> where TValue : struct
{
	internal unsafe static void Clear(UnsafeParallelHashMapData* data)
	{
	}

	internal unsafe static int AllocEntry(UnsafeParallelHashMapData* data, int threadIndex)
	{
		return 0;
	}

	internal unsafe static void FreeEntry(UnsafeParallelHashMapData* data, int idx, int threadIndex)
	{
	}

	internal unsafe static bool TryAddAtomic(UnsafeParallelHashMapData* data, TKey key, TValue item, int threadIndex)
	{
		return false;
	}

	internal unsafe static void AddAtomicMulti(UnsafeParallelHashMapData* data, TKey key, TValue item, int threadIndex)
	{
	}

	internal unsafe static bool TryAdd(UnsafeParallelHashMapData* data, TKey key, TValue item, bool isMultiHashMap, AllocatorManager.AllocatorHandle allocation)
	{
		return false;
	}

	internal unsafe static int Remove(UnsafeParallelHashMapData* data, TKey key, bool isMultiHashMap)
	{
		return 0;
	}

	internal unsafe static void Remove(UnsafeParallelHashMapData* data, NativeParallelMultiHashMapIterator<TKey> it)
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	internal unsafe static void RemoveKeyValue<TValueEQ>(UnsafeParallelHashMapData* data, TKey key, TValueEQ value) where TValueEQ : struct, IEquatable<TValueEQ>
	{
	}

	internal unsafe static bool TryGetFirstValueAtomic(UnsafeParallelHashMapData* data, TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey> it)
	{
		item = default(TValue);
		it = default(NativeParallelMultiHashMapIterator<TKey>);
		return false;
	}

	internal unsafe static bool TryGetNextValueAtomic(UnsafeParallelHashMapData* data, out TValue item, ref NativeParallelMultiHashMapIterator<TKey> it)
	{
		item = default(TValue);
		return false;
	}

	internal unsafe static bool SetValue(UnsafeParallelHashMapData* data, ref NativeParallelMultiHashMapIterator<TKey> it, ref TValue item)
	{
		return false;
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckOutOfCapacity(int idx, int keyCapacity)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private unsafe static void CheckIndexOutOfBounds(UnsafeParallelHashMapData* data, int idx)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void ThrowFull()
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void ThrowInvalidIterator()
	{
	}
}
