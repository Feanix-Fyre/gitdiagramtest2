using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.InputSystem.Utilities;

public struct ReadOnlyArray<TValue> : IReadOnlyList<TValue>, IEnumerable<TValue>, IEnumerable, IReadOnlyCollection<TValue>
{
	public struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
	{
		private readonly TValue[] m_Array;

		private readonly int m_IndexStart;

		private readonly int m_IndexEnd;

		private int m_Index;

		public TValue Current => default(TValue);

		object IEnumerator.Current => null;

		internal Enumerator(TValue[] array, int index, int length)
		{
			m_Array = null;
			m_IndexStart = 0;
			m_IndexEnd = 0;
			m_Index = 0;
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	internal TValue[] m_Array;

	internal int m_StartIndex;

	internal int m_Length;

	public int Count => 0;

	public TValue this[int index] => default(TValue);

	public ReadOnlyArray(TValue[] array)
	{
		m_Array = null;
		m_StartIndex = 0;
		m_Length = 0;
	}

	public ReadOnlyArray(TValue[] array, int index, int length)
	{
		m_Array = null;
		m_StartIndex = 0;
		m_Length = 0;
	}

	public TValue[] ToArray()
	{
		return null;
	}

	public int IndexOf(Predicate<TValue> predicate)
	{
		return 0;
	}

	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public static implicit operator ReadOnlyArray<TValue>(TValue[] array)
	{
		return default(ReadOnlyArray<TValue>);
	}
}
