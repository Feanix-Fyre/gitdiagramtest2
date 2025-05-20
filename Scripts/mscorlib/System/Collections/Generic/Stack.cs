using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic;

[Serializable]
[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
[DebuggerTypeProxy(typeof(StackDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
public class Stack<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[Serializable]
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly Stack<T> _stack;

		private readonly int _version;

		private int _index;

		private T _currentElement;

		public T Current => default(T);

		object IEnumerator.Current => null;

		internal Enumerator(Stack<T> stack)
		{
			_stack = null;
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

	private int _size;

	private int _version;

	[NonSerialized]
	private object _syncRoot;

	private const int DefaultCapacity = 4;

	public int Count => 0;

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot => null;

	public Stack()
	{
	}

	public Stack(int capacity)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(T item)
	{
		return false;
	}

	void ICollection.CopyTo(Array array, int arrayIndex)
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

	public T Peek()
	{
		return default(T);
	}

	public T Pop()
	{
		return default(T);
	}

	public void Push(T item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PushWithResize(T item)
	{
	}

	private void ThrowForEmptyStack()
	{
	}
}
