using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[DebuggerDisplay("Size = {size} Capacity = {capacity}")]
public class DynamicArray<T> where T : new()
{
	public struct Iterator
	{
		private readonly DynamicArray<T> owner;

		private int index;

		public ref T Current
		{
			get
			{
				throw null;
			}
		}

		public Iterator(DynamicArray<T> setOwner)
		{
			owner = null;
			index = 0;
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	public struct RangeEnumerable
	{
		public struct RangeIterator
		{
			private readonly DynamicArray<T> owner;

			private int index;

			private int first;

			private int last;

			public ref T Current
			{
				get
				{
					throw null;
				}
			}

			public RangeIterator(DynamicArray<T> setOwner, int first, int numItems)
			{
				owner = null;
				index = 0;
				this.first = 0;
				last = 0;
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		public RangeIterator iterator;

		public RangeIterator GetEnumerator()
		{
			return default(RangeIterator);
		}
	}

	private T[] m_Array;

	public int size { get; private set; }

	public int capacity => 0;

	public ref T this[int index]
	{
		get
		{
			throw null;
		}
	}

	public DynamicArray()
	{
	}

	public DynamicArray(int size)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(T item)
	{
		return false;
	}

	public int Add(in T value)
	{
		return 0;
	}

	public void AddRange(DynamicArray<T> array)
	{
	}

	public bool Remove(T item)
	{
		return false;
	}

	public void RemoveAt(int index)
	{
	}

	public void RemoveRange(int index, int count)
	{
	}

	public int FindIndex(int startIndex, int count, Predicate<T> match)
	{
		return 0;
	}

	public int IndexOf(T item, int index, int count)
	{
		return 0;
	}

	public int IndexOf(T item, int index)
	{
		return 0;
	}

	public int IndexOf(T item)
	{
		return 0;
	}

	public void Resize(int newSize, bool keepContent = false)
	{
	}

	public void Reserve(int newCapacity, bool keepContent = false)
	{
	}

	public static implicit operator T[](DynamicArray<T> array)
	{
		return null;
	}

	public Iterator GetEnumerator()
	{
		return default(Iterator);
	}

	public RangeEnumerable SubRange(int first, int numItems)
	{
		return default(RangeEnumerable);
	}

	internal void BumpVersion()
	{
	}
}
