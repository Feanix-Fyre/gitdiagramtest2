using System.Runtime.Serialization;

namespace System.Collections.Generic;

[Serializable]
internal sealed class TreeSet<T> : SortedSet<T>
{
	public TreeSet()
	{
	}

	public TreeSet(IComparer<T> comparer)
	{
	}

	public TreeSet(SerializationInfo siInfo, StreamingContext context)
	{
	}

	internal override bool AddIfNotPresent(T item)
	{
		return false;
	}
}
