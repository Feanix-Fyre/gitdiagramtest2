namespace System.Collections.Generic;

internal class ArraySortHelper<T>
{
	private static readonly ArraySortHelper<T> s_defaultArraySortHelper;

	public static ArraySortHelper<T> Default => null;

	public void Sort(T[] keys, int index, int length, IComparer<T> comparer)
	{
	}

	public int BinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer)
	{
		return 0;
	}

	internal static void Sort(T[] keys, int index, int length, Comparison<T> comparer)
	{
	}

	internal static int InternalBinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer)
	{
		return 0;
	}

	private static void SwapIfGreater(T[] keys, Comparison<T> comparer, int a, int b)
	{
	}

	private static void Swap(T[] a, int i, int j)
	{
	}

	internal static void IntrospectiveSort(T[] keys, int left, int length, Comparison<T> comparer)
	{
	}

	private static void IntroSort(T[] keys, int lo, int hi, int depthLimit, Comparison<T> comparer)
	{
	}

	private static int PickPivotAndPartition(T[] keys, int lo, int hi, Comparison<T> comparer)
	{
		return 0;
	}

	private static void Heapsort(T[] keys, int lo, int hi, Comparison<T> comparer)
	{
	}

	private static void DownHeap(T[] keys, int i, int n, int lo, Comparison<T> comparer)
	{
	}

	private static void InsertionSort(T[] keys, int lo, int hi, Comparison<T> comparer)
	{
	}
}
internal class ArraySortHelper<TKey, TValue>
{
	private static readonly ArraySortHelper<TKey, TValue> s_defaultArraySortHelper;

	public static ArraySortHelper<TKey, TValue> Default => null;

	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer)
	{
	}

	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b)
	{
	}

	private static void Swap(TKey[] keys, TValue[] values, int i, int j)
	{
	}

	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer)
	{
	}

	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer)
	{
	}

	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer)
	{
		return 0;
	}

	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer)
	{
	}

	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer)
	{
	}

	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer)
	{
	}
}
