using System.Collections.Generic;

namespace System.Linq;

internal class Set<TElement>
{
	internal struct Slot
	{
		internal int hashCode;

		internal TElement value;

		internal int next;
	}

	private int[] buckets;

	private Slot[] slots;

	private int count;

	private int freeList;

	private IEqualityComparer<TElement> comparer;

	public Set(IEqualityComparer<TElement> comparer)
	{
	}

	public bool Add(TElement value)
	{
		return false;
	}

	private bool Find(TElement value, bool add)
	{
		return false;
	}

	private void Resize()
	{
	}

	internal int InternalGetHashCode(TElement value)
	{
		return 0;
	}
}
