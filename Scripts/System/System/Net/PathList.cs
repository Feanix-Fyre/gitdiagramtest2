using System.Collections;

namespace System.Net;

[Serializable]
internal class PathList
{
	[Serializable]
	private class PathListComparer : IComparer
	{
		internal static readonly PathListComparer StaticInstance;

		int IComparer.Compare(object ol, object or)
		{
			return 0;
		}
	}

	private SortedList m_list;

	public int Count => 0;

	public ICollection Values => null;

	public object this[string s]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public object SyncRoot => null;

	public int GetCookiesCount()
	{
		return 0;
	}

	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
