using System.Diagnostics;

namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
internal class LowLevelList<T>
{
	private const int _defaultCapacity = 4;

	protected T[] _items;

	protected int _size;

	protected int _version;

	private static readonly T[] s_emptyArray;

	public int Capacity
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Count => 0;

	public T this[int index]
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public LowLevelList()
	{
	}

	public LowLevelList(int capacity)
	{
	}

	public void Add(T item)
	{
	}

	private void EnsureCapacity(int min)
	{
	}

	public void AddRange(IEnumerable<T> collection)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(T item)
	{
		return false;
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
	}

	public int IndexOf(T item)
	{
		return 0;
	}

	public void Insert(int index, T item)
	{
	}

	public void InsertRange(int index, IEnumerable<T> collection)
	{
	}

	public bool Remove(T item)
	{
		return false;
	}

	public int RemoveAll(Predicate<T> match)
	{
		return 0;
	}

	public void RemoveAt(int index)
	{
	}
}
