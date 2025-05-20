namespace System.Dynamic.Utils;

internal sealed class CacheDict<TKey, TValue>
{
	private sealed class Entry
	{
		internal readonly int _hash;

		internal readonly TKey _key;

		internal readonly TValue _value;

		internal Entry(int hash, TKey key, TValue value)
		{
		}
	}

	private readonly int _mask;

	private readonly Entry[] _entries;

	internal TKey this[TKey key]
	{
		set
		{
		}
	}

	internal CacheDict(int size)
	{
	}

	private static int AlignSize(int size)
	{
		return 0;
	}

	internal bool TryGetValue(TKey key, out TValue value)
	{
		value = default(TValue);
		return false;
	}

	internal void Add(TKey key, TValue value)
	{
	}
}
