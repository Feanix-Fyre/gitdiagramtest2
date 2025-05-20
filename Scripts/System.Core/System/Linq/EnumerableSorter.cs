using System.Collections.Generic;

namespace System.Linq;

internal abstract class EnumerableSorter<TElement>
{
	internal abstract void ComputeKeys(TElement[] elements, int count);

	internal abstract int CompareKeys(int index1, int index2);

	internal int[] Sort(TElement[] elements, int count)
	{
		return null;
	}

	private void QuickSort(int[] map, int left, int right)
	{
	}
}
internal class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement>
{
	internal Func<TElement, TKey> keySelector;

	internal IComparer<TKey> comparer;

	internal bool descending;

	internal EnumerableSorter<TElement> next;

	internal TKey[] keys;

	internal EnumerableSorter(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next)
	{
	}

	internal override void ComputeKeys(TElement[] elements, int count)
	{
	}

	internal override int CompareKeys(int index1, int index2)
	{
		return 0;
	}
}
