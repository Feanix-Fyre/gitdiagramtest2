using System.Collections.Generic;

namespace UnityEngine.Timeline;

internal class IntervalTree<T> where T : IInterval
{
	internal struct Entry
	{
		public long intervalStart;

		public long intervalEnd;

		public T item;
	}

	private const int kMinNodeSize = 10;

	private const int kInvalidNode = -1;

	private const long kCenterUnknown = long.MaxValue;

	private readonly List<Entry> m_Entries;

	private readonly List<IntervalTreeNode> m_Nodes;

	public bool dirty { get; internal set; }

	public void Add(T item)
	{
	}

	public void IntersectsWith(long value, List<T> results)
	{
	}

	public void IntersectsWithRange(long start, long end, List<T> results)
	{
	}

	public void UpdateIntervals()
	{
	}

	private void Query(IntervalTreeNode intervalTreeNode, long value, List<T> results)
	{
	}

	private void QueryRange(IntervalTreeNode intervalTreeNode, long start, long end, List<T> results)
	{
	}

	private void Rebuild()
	{
	}

	private int Rebuild(int start, int end)
	{
		return 0;
	}

	public void Clear()
	{
	}
}
