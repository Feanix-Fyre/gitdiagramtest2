namespace System.Runtime.Serialization;

internal class ObjectHolderListEnumerator
{
	private bool m_isFixupEnumerator;

	private ObjectHolderList m_list;

	private int m_startingVersion;

	private int m_currPos;

	internal ObjectHolder Current => null;

	internal ObjectHolderListEnumerator(ObjectHolderList list, bool isFixupEnumerator)
	{
	}

	internal bool MoveNext()
	{
		return false;
	}
}
