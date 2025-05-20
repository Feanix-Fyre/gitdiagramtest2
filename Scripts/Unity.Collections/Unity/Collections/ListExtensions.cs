using System;
using System.Collections.Generic;

namespace Unity.Collections;

public static class ListExtensions
{
	public static bool RemoveSwapBack<T>(this List<T> list, T value)
	{
		return false;
	}

	public static bool RemoveSwapBack<T>(this List<T> list, Predicate<T> matcher)
	{
		return false;
	}

	public static void RemoveAtSwapBack<T>(this List<T> list, int index)
	{
	}

	public static NativeList<T> ToNativeList<T>(this List<T> list, AllocatorManager.AllocatorHandle allocator) where T : struct
	{
		return default(NativeList<T>);
	}

	public static NativeArray<T> ToNativeArray<T>(this List<T> list, AllocatorManager.AllocatorHandle allocator) where T : struct
	{
		return default(NativeArray<T>);
	}
}
