using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.EnhancedTouch;

public struct TouchHistory : IReadOnlyList<Touch>, IEnumerable<Touch>, IEnumerable, IReadOnlyCollection<Touch>
{
	private class Enumerator : IEnumerator<Touch>, IEnumerator, IDisposable
	{
		private readonly TouchHistory m_Owner;

		private int m_Index;

		public Touch Current => default(Touch);

		object IEnumerator.Current => null;

		internal Enumerator(TouchHistory owner)
		{
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

	private readonly InputStateHistory<TouchState> m_History;

	private readonly Finger m_Finger;

	private readonly int m_Count;

	private readonly int m_StartIndex;

	private readonly uint m_Version;

	public int Count => 0;

	public Touch this[int index] => default(Touch);

	internal TouchHistory(Finger finger, InputStateHistory<TouchState> history, int startIndex = -1, int count = -1)
	{
		m_History = null;
		m_Finger = null;
		m_Count = 0;
		m_StartIndex = 0;
		m_Version = 0u;
	}

	public IEnumerator<Touch> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	internal void CheckValid()
	{
	}
}
