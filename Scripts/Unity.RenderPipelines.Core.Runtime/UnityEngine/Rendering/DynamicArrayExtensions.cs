using System;

namespace UnityEngine.Rendering;

public static class DynamicArrayExtensions
{
	private static int Partition<T>(T[] data, int left, int right) where T : IComparable<T>, new()
	{
		return 0;
	}

	private static void QuickSort<T>(T[] data, int left, int right) where T : IComparable<T>, new()
	{
	}

	public static void QuickSort<T>(this DynamicArray<T> array) where T : IComparable<T>, new()
	{
	}
}
