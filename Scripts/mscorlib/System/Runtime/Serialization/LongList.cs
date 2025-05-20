namespace System.Runtime.Serialization;

[Serializable]
internal class LongList
{
	private long[] m_values;

	private int m_count;

	private int m_totalItems;

	private int m_currentItem;

	internal int Count => 0;

	internal long Current => 0L;

	internal LongList()
	{
	}

	internal LongList(int startingSize)
	{
	}

	internal void Add(long value)
	{
	}

	internal void StartEnumeration()
	{
	}

	internal bool MoveNext()
	{
		return false;
	}

	internal bool RemoveElement(long value)
	{
		return false;
	}

	private void EnlargeArray()
	{
	}
}
