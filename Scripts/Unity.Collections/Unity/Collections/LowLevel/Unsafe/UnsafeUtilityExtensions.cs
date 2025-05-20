using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompatible]
public static class UnsafeUtilityExtensions
{
	internal unsafe static void MemSwap(void* ptr, void* otherPtr, long size)
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public unsafe static T ReadArrayElementBoundsChecked<T>(void* source, int index, int capacity)
	{
		return default(T);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public unsafe static void WriteArrayElementBoundsChecked<T>(void* destination, int index, T value, int capacity)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public unsafe static void* AddressOf<T>(in T value) where T : struct
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static ref T AsRef<T>(in T value) where T : struct
	{
		throw null;
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private unsafe static void CheckMemSwapOverlap(byte* dst, byte* src, long size)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckIndexRange(int index, int capacity)
	{
	}
}
