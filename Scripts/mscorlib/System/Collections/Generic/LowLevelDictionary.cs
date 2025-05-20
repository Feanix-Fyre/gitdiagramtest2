namespace System.Collections.Generic;

internal class LowLevelDictionary<TKey, TValue>
{
	private sealed class Entry
	{
		public TKey _key;

		public TValue _value;

		public Entry _next;
	}

	private sealed class DefaultComparer<T> : IEqualityComparer<T>
	{
		public bool Equals(T x, T y)
		{
			return false;
		}

		public int GetHashCode(T obj)
		{
			return 0;
		}
	}

	private Entry[] _buckets;

	private int _numEntries;

	private int _version;

	private IEqualityComparer<TKey> _comparer;

	public TKey this[TKey key]
	{
		set
		{
		}
	}

	public LowLevelDictionary()
	{
	}

	public LowLevelDictionary(int capacity, IEqualityComparer<TKey> comparer)
	{
	}

	public void Clear(int capacity = 17)
	{
	}

	public bool Remove(TKey key)
	{
		return false;
	}

	private Entry Find(TKey key)
	{
		return null;
	}

	private Entry UncheckedAdd(TKey key, TValue value)
	{
		return null;
	}

	private void ExpandBuckets()
	{
	}

	private int GetBucket(TKey key, int numBuckets = 0)
	{
		return 0;
	}
}
