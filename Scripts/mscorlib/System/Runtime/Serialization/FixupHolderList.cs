namespace System.Runtime.Serialization;

[Serializable]
internal class FixupHolderList
{
	internal FixupHolder[] m_values;

	internal int m_count;

	internal FixupHolderList()
	{
	}

	internal FixupHolderList(int startingSize)
	{
	}

	internal virtual void Add(FixupHolder fixup)
	{
	}

	private void EnlargeArray()
	{
	}
}
