using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(QueueDebugView<>))]
[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[Serializable]
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly Queue<T> _q;

		private readonly int _version;

		private int _index;

		private T _currentElement;

		public T Current => default(T);

		object IEnumerator.Current => null;

		internal Enumerator(Queue<T> q)
		{
			_q = null;
			_version = 0;
			_index = 0;
			_currentElement = default(T);
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		private void ThrowEnumerationNotStartedOrEnded()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private T[] _array;

	private int _head;

	private int _tail;

	private int _size;

	private int _version;

	[NonSerialized]
	private object _syncRoot;

	private const int MinimumGrow = 4;

	private const int GrowFactor = 200;

	public int Count => 0;

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot => null;

	public Queue()
	{
	}

	public Queue(int capacity)
	{
	}

	public void Clear()
	{
	}

	void ICollection.CopyTo(Array array, int index)
	{
	}

	public void Enqueue(T item)
	{
	}

	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public T Dequeue()
	{
		return default(T);
	}

	public T Peek()
	{
		return default(T);
	}

	public bool Contains(T item)
	{
		return false;
	}

	public T[] ToArray()
	{
		return null;
	}

	private void SetCapacity(int capacity)
	{
	}

	private void MoveNext(ref int index)
	{
	}

	private void ThrowForEmptyQueue()
	{
	}
}
