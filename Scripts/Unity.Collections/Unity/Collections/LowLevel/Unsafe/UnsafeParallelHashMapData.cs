using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Unity.Collections.LowLevel.Unsafe;

[StructLayout((LayoutKind)2)]
[BurstCompatible]
internal struct UnsafeParallelHashMapData
{
	[FieldOffset(0)]
	internal unsafe byte* values;

	[FieldOffset(8)]
	internal unsafe byte* keys;

	[FieldOffset(16)]
	internal unsafe byte* next;

	[FieldOffset(24)]
	internal unsafe byte* buckets;

	[FieldOffset(32)]
	internal int keyCapacity;

	[FieldOffset(36)]
	internal int bucketCapacityMask;

	[FieldOffset(40)]
	internal int allocatedIndexLength;

	[FieldOffset(64)]
	internal unsafe fixed int firstFreeTLS[2048];

	internal const int IntsPerCacheLine = 16;

	internal static int GetBucketSize(int capacity)
	{
		return 0;
	}

	internal static int GrowCapacity(int capacity)
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	internal unsafe static void AllocateHashMap<TKey, TValue>(int length, int bucketLength, AllocatorManager.AllocatorHandle label, out UnsafeParallelHashMapData* outBuf) where TKey : struct where TValue : struct
	{
		System.Runtime.CompilerServices.Unsafe.As<UnsafeParallelHashMapData*, @null>(ref outBuf) = null;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	internal unsafe static void ReallocateHashMap<TKey, TValue>(UnsafeParallelHashMapData* data, int newCapacity, int newBucketCapacity, AllocatorManager.AllocatorHandle label) where TKey : struct where TValue : struct
	{
	}

	internal unsafe static void DeallocateHashMap(UnsafeParallelHashMapData* data, AllocatorManager.AllocatorHandle allocator)
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	internal static int CalculateDataSize<TKey, TValue>(int length, int bucketLength, out int keyOffset, out int nextOffset, out int bucketOffset) where TKey : struct where TValue : struct
	{
		keyOffset = default(int);
		nextOffset = default(int);
		bucketOffset = default(int);
		return 0;
	}

	internal unsafe static bool IsEmpty(UnsafeParallelHashMapData* data)
	{
		return false;
	}

	internal unsafe static int GetCount(UnsafeParallelHashMapData* data)
	{
		return 0;
	}

	internal unsafe static bool MoveNext(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index)
	{
		index = default(int);
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	internal unsafe static void GetKeyArray<TKey>(UnsafeParallelHashMapData* data, NativeArray<TKey> result) where TKey : struct
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	internal unsafe static void GetValueArray<TValue>(UnsafeParallelHashMapData* data, NativeArray<TValue> result) where TValue : struct
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	internal unsafe static void GetKeyValueArrays<TKey, TValue>(UnsafeParallelHashMapData* data, NativeKeyValueArrays<TKey, TValue> result) where TKey : struct where TValue : struct
	{
	}

	internal UnsafeHashMapBucketData GetBucketData()
	{
		return default(UnsafeHashMapBucketData);
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private unsafe static void CheckHashMapReallocateDoesNotShrink(UnsafeParallelHashMapData* data, int newCapacity)
	{
	}
}
