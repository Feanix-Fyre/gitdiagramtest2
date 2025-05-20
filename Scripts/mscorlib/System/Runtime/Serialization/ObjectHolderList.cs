namespace System.Runtime.Serialization;

internal class ObjectHolderList
{
	internal ObjectHolder[] m_values;

	internal int m_count;

	internal int Version => 0;

	internal int Count => 0;

	internal ObjectHolderList()
	{
	}

	internal ObjectHolderList(int startingSize)
	{
	}

	internal virtual void Add(ObjectHolder value)
	{
	}

	internal ObjectHolderListEnumerator GetFixupEnumerator()
	{
		return null;
	}

	private void EnlargeArray()
	{
	}
}
