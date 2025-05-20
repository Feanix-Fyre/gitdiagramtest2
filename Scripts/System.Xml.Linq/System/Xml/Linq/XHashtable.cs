namespace System.Xml.Linq;

internal sealed class XHashtable<TValue>
{
	public delegate string ExtractKeyDelegate(TValue value);

	private sealed class XHashtableState
	{
		private struct Entry
		{
			public TValue Value;

			public int HashCode;

			public int Next;
		}

		private int[] _buckets;

		private Entry[] _entries;

		private int _numEntries;

		private ExtractKeyDelegate _extractKey;

		public XHashtableState(ExtractKeyDelegate extractKey, int capacity)
		{
		}

		public XHashtableState Resize()
		{
			return null;
		}

		public bool TryGetValue(string key, int index, int count, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		public bool TryAdd(TValue value, out TValue newValue)
		{
			newValue = default(TValue);
			return false;
		}

		private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex)
		{
			return false;
		}

		private static int ComputeHashCode(string key, int index, int count)
		{
			return 0;
		}
	}

	private XHashtableState _state;

	public XHashtable(ExtractKeyDelegate extractKey, int capacity)
	{
	}

	public bool TryGetValue(string key, int index, int count, out TValue value)
	{
		value = default(TValue);
		return false;
	}

	public TValue Add(TValue value)
	{
		return default(TValue);
	}
}
