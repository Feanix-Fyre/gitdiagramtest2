using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UI.Collections;

internal class IndexedSet<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	private readonly List<T> m_List;

	private Dictionary<T, int> m_Dictionary;

	private int m_EnabledObjectCount;

	public int Count => 0;

	public int Capacity => 0;

	public bool IsReadOnly => false;

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

	public void Add(T item)
	{
	}

	public void Add(T item, bool isActive)
	{
	}

	public bool AddUnique(T item, bool isActive = true)
	{
		return false;
	}

	public bool EnableItem(T item)
	{
		return false;
	}

	public bool DisableItem(T item)
	{
		return false;
	}

	public bool Remove(T item)
	{
		return false;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
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

	public void RemoveAt(int index)
	{
	}

	private void Swap(int index1, int index2)
	{
	}

	public void RemoveAll(Predicate<T> match)
	{
	}

	public void Sort(Comparison<T> sortLayoutFunction)
	{
	}
}
