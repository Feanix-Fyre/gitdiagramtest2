using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.InputSystem.Utilities;

internal struct OneOrMore<TValue, TList> : IReadOnlyList<TValue>, IEnumerable<TValue>, IEnumerable, IReadOnlyCollection<TValue> where TList : IReadOnlyList<TValue>
{
	private class Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
	{
		internal int m_Index;

		internal OneOrMore<TValue, TList> m_List;

		public TValue Current => default(TValue);

		object IEnumerator.Current => null;

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

	private readonly bool m_IsSingle;

	private readonly TValue m_Single;

	private readonly TList m_Multiple;

	public int Count => 0;

	public TValue this[int index] => default(TValue);

	public OneOrMore(TValue single)
	{
		m_IsSingle = false;
		m_Single = default(TValue);
		m_Multiple = default(TList);
	}

	public OneOrMore(TList multiple)
	{
		m_IsSingle = false;
		m_Single = default(TValue);
		m_Multiple = default(TList);
	}

	public static implicit operator OneOrMore<TValue, TList>(TValue single)
	{
		return default(OneOrMore<TValue, TList>);
	}

	public static implicit operator OneOrMore<TValue, TList>(TList multiple)
	{
		return default(OneOrMore<TValue, TList>);
	}

	public IEnumerator<TValue> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
