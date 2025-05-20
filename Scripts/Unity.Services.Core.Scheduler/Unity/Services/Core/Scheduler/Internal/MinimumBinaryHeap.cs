using System.Collections.Generic;

namespace Unity.Services.Core.Scheduler.Internal;

internal abstract class MinimumBinaryHeap
{
}
internal class MinimumBinaryHeap<T> : MinimumBinaryHeap
{
	private readonly object m_Lock;

	private readonly IComparer<T> m_Comparer;

	private readonly int m_MinimumCapacity;

	private T[] m_HeapArray;

	public int Count { get; private set; }

	public T Min => default(T);

	public MinimumBinaryHeap(IComparer<T> comparer, int minimumCapacity = 10)
	{
	}

	internal MinimumBinaryHeap(ICollection<T> collection, IComparer<T> comparer, int minimumCapacity = 10)
	{
	}

	public void Insert(T item)
	{
	}

	private void IncreaseHeapCapacityWhenFull()
	{
	}

	public void Remove(T item)
	{
	}

	private int IndexOf(T item)
	{
		return 0;
	}

	public T ExtractMin()
	{
		return default(T);
	}

	private void DecreaseHeapCapacityWhenSpare()
	{
	}

	private void MinHeapify()
	{
	}

	private static void Swap(ref T lhs, ref T rhs)
	{
	}

	private static int GetParentIndex(int index)
	{
		return 0;
	}

	private static int GetLeftChildIndex(int index)
	{
		return 0;
	}

	private static int GetRightChildIndex(int index)
	{
		return 0;
	}
}
