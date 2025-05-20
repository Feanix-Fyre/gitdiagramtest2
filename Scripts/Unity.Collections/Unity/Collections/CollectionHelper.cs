using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Unity.Burst;

namespace Unity.Collections;

[BurstCompatible]
public static class CollectionHelper
{
	[StructLayout((LayoutKind)2)]
	internal struct LongDoubleUnion
	{
		[FieldOffset(0)]
		internal long longValue;

		[FieldOffset(0)]
		internal double doubleValue;
	}

	public const int CacheLineSize = 64;

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	internal static void CheckAllocator(AllocatorManager.AllocatorHandle allocator)
	{
	}

	public static int Log2Floor(int value)
	{
		return 0;
	}

	public static int Log2Ceil(int value)
	{
		return 0;
	}

	public static int Align(int size, int alignmentPowerOfTwo)
	{
		return 0;
	}

	public static ulong Align(ulong size, ulong alignmentPowerOfTwo)
	{
		return 0uL;
	}

	public unsafe static bool IsAligned(void* p, int alignmentPowerOfTwo)
	{
		return false;
	}

	public static bool IsAligned(ulong offset, int alignmentPowerOfTwo)
	{
		return false;
	}

	public static bool IsPowerOfTwo(int value)
	{
		return false;
	}

	public unsafe static uint Hash(void* ptr, int bytes)
	{
		return 0u;
	}

	[NotBurstCompatible]
	internal static void WriteLayout(Type type)
	{
	}

	internal static bool ShouldDeallocate(AllocatorManager.AllocatorHandle allocator)
	{
		return false;
	}

	internal static int AssumePositive(int value)
	{
		return 0;
	}

	[NotBurstCompatible]
	[BurstDiscard]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	internal static void CheckIsUnmanaged<T>()
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	internal static void CheckIntPositivePowerOfTwo(int value)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	internal static void CheckUlongPositivePowerOfTwo(ulong value)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	internal static void CheckIndexInRange(int index, int length)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	internal static void CheckCapacityInRange(int capacity, int length)
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(AllocatorManager.AllocatorHandle)
	})]
	public static NativeArray<T> CreateNativeArray<T, U>(int length, ref U allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct where U : struct, AllocatorManager.IAllocator
	{
		return default(NativeArray<T>);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static NativeArray<T> CreateNativeArray<T>(int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static NativeArray<T> CreateNativeArray<T>(NativeArray<T> array, AllocatorManager.AllocatorHandle allocator) where T : struct
	{
		return default(NativeArray<T>);
	}

	[NotBurstCompatible]
	public static NativeArray<T> CreateNativeArray<T>(T[] array, AllocatorManager.AllocatorHandle allocator) where T : struct
	{
		return default(NativeArray<T>);
	}

	[NotBurstCompatible]
	public static NativeArray<T> CreateNativeArray<T, U>(T[] array, ref U allocator) where T : struct where U : struct, AllocatorManager.IAllocator
	{
		return default(NativeArray<T>);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int),
		typeof(AllocatorManager.AllocatorHandle)
	})]
	public static NativeParallelHashMap<TKey, TValue> CreateNativeParallelHashMap<TKey, TValue, U>(int length, ref U allocator) where TKey : struct, IEquatable<TKey> where TValue : struct where U : struct, AllocatorManager.IAllocator
	{
		return default(NativeParallelHashMap<TKey, TValue>);
	}

	[Obsolete("CreateNativeMultiHashMap is renamed to CreateNativeParallelHashMap. (UnityUpgradable) -> CreateNativeParallelHashMap<TKey, TValue, U>(*)", true)]
	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int),
		typeof(AllocatorManager.AllocatorHandle)
	})]
	public static NativeHashMap<TKey, TValue> CreateNativeMultiHashMap<TKey, TValue, U>(int length, ref U allocator) where TKey : struct, IEquatable<TKey> where TValue : struct where U : struct, AllocatorManager.IAllocator
	{
		return default(NativeHashMap<TKey, TValue>);
	}
}
