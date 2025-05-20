using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Collections;

namespace UnityEngine.InputSystem;

[DebuggerDisplay("Count = {Count}")]
public struct InputControlList<TControl> : IList<TControl>, ICollection<TControl>, IEnumerable<TControl>, IEnumerable, IReadOnlyList<TControl>, IReadOnlyCollection<TControl>, IDisposable where TControl : InputControl
{
	private struct Enumerator : IEnumerator<TControl>, IEnumerator, IDisposable
	{
		private unsafe readonly ulong* m_Indices;

		private readonly int m_Count;

		private int m_Current;

		public TControl Current => null;

		object IEnumerator.Current => null;

		public unsafe Enumerator(InputControlList<TControl> list)
		{
			m_Indices = null;
			m_Count = 0;
			m_Current = 0;
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}

	private int m_Count;

	private NativeArray<ulong> m_Indices;

	private readonly Allocator m_Allocator;

	private const ulong kInvalidIndex = ulong.MaxValue;

	public int Count => 0;

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

	public bool IsReadOnly => false;

	public TControl this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputControlList(Allocator allocator, int initialCapacity = 0)
	{
		m_Count = 0;
		m_Indices = default(NativeArray<ulong>);
		m_Allocator = default(Allocator);
	}

	public InputControlList(IEnumerable<TControl> values, Allocator allocator = Allocator.Persistent)
	{
		m_Count = 0;
		m_Indices = default(NativeArray<ulong>);
		m_Allocator = default(Allocator);
	}

	public InputControlList(params TControl[] values)
	{
		m_Count = 0;
		m_Indices = default(NativeArray<ulong>);
		m_Allocator = default(Allocator);
	}

	public void Resize(int size)
	{
	}

	public void Add(TControl item)
	{
	}

	public void AddSlice<TList>(TList list, int count = -1, int destinationIndex = -1, int sourceIndex = 0) where TList : IReadOnlyList<TControl>
	{
	}

	public void AddRange(IEnumerable<TControl> list, int count = -1, int destinationIndex = -1)
	{
	}

	public bool Remove(TControl item)
	{
		return false;
	}

	public void RemoveAt(int index)
	{
	}

	public void CopyTo(TControl[] array, int arrayIndex)
	{
	}

	public int IndexOf(TControl item)
	{
		return 0;
	}

	public int IndexOf(TControl item, int startIndex, int count = -1)
	{
		return 0;
	}

	public void Insert(int index, TControl item)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(TControl item)
	{
		return false;
	}

	public bool Contains(TControl item, int startIndex, int count = -1)
	{
		return false;
	}

	public void SwapElements(int index1, int index2)
	{
	}

	public void Sort<TCompare>(int startIndex, int count, TCompare comparer) where TCompare : IComparer<TControl>
	{
	}

	public TControl[] ToArray(bool dispose = false)
	{
		return null;
	}

	internal void AppendTo(ref TControl[] array, ref int count)
	{
	}

	public void Dispose()
	{
	}

	public IEnumerator<TControl> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	private static ulong ToIndex(TControl control)
	{
		return 0uL;
	}

	private static TControl FromIndex(ulong index)
	{
		return null;
	}
}
