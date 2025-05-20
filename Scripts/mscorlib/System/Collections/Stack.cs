using System.Diagnostics;

namespace System.Collections;

/// <summary>Represents a simple last-in-first-out (LIFO) non-generic collection of objects.</summary>
[Serializable]
[DebuggerTypeProxy(typeof(StackDebugView))]
[DebuggerDisplay("Count = {Count}")]
public class Stack : ICollection, IEnumerable, ICloneable
{
	[Serializable]
	private class StackEnumerator : IEnumerator, ICloneable
	{
		private Stack _stack;

		private int _index;

		private int _version;

		private object _currentElement;

		public virtual object Current => null;

		internal StackEnumerator(Stack stack)
		{
		}

		public object Clone()
		{
			return null;
		}

		public virtual bool MoveNext()
		{
			return false;
		}

		public virtual void Reset()
		{
		}
	}

	internal class StackDebugView
	{
	}

	private object[] _array;

	private int _size;

	private int _version;

	[NonSerialized]
	private object _syncRoot;

	private const int _defaultCapacity = 10;

	/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Stack" />.</summary>
	/// <returns>The number of elements contained in the <see cref="T:System.Collections.Stack" />.</returns>
	public virtual int Count => 0;

	/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Stack" /> is synchronized (thread safe).</summary>
	/// <returns>
	///   <see langword="true" />, if access to the <see cref="T:System.Collections.Stack" /> is synchronized (thread safe); otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public virtual bool IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Stack" />.</summary>
	/// <returns>An <see cref="T:System.Object" /> that can be used to synchronize access to the <see cref="T:System.Collections.Stack" />.</returns>
	public virtual object SyncRoot => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Stack" /> class that is empty and has the default initial capacity.</summary>
	public Stack()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Stack" /> class that is empty and has the specified initial capacity or the default initial capacity, whichever is greater.</summary>
	/// <param name="initialCapacity">The initial number of elements that the <see cref="T:System.Collections.Stack" /> can contain.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="initialCapacity" /> is less than zero.</exception>
	public Stack(int initialCapacity)
	{
	}

	/// <summary>Removes all objects from the <see cref="T:System.Collections.Stack" />.</summary>
	public virtual void Clear()
	{
	}

	/// <summary>Creates a shallow copy of the <see cref="T:System.Collections.Stack" />.</summary>
	/// <returns>A shallow copy of the <see cref="T:System.Collections.Stack" />.</returns>
	public virtual object Clone()
	{
		return null;
	}

	/// <summary>Determines whether an element is in the <see cref="T:System.Collections.Stack" />.</summary>
	/// <param name="obj">The object to locate in the <see cref="T:System.Collections.Stack" />. The value can be <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" />, if <paramref name="obj" /> is found in the <see cref="T:System.Collections.Stack" />; otherwise, <see langword="false" />.</returns>
	public virtual bool Contains(object obj)
	{
		return false;
	}

	/// <summary>Copies the <see cref="T:System.Collections.Stack" /> to an existing one-dimensional <see cref="T:System.Array" />, starting at the specified array index.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Stack" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
	/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional.  
	/// -or-  
	/// The number of elements in the source <see cref="T:System.Collections.Stack" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Stack" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
	public virtual void CopyTo(Array array, int index)
	{
	}

	/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.Stack" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.Stack" />.</returns>
	public virtual IEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns the object at the top of the <see cref="T:System.Collections.Stack" /> without removing it.</summary>
	/// <returns>The <see cref="T:System.Object" /> at the top of the <see cref="T:System.Collections.Stack" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Collections.Stack" /> is empty.</exception>
	public virtual object Peek()
	{
		return null;
	}

	/// <summary>Removes and returns the object at the top of the <see cref="T:System.Collections.Stack" />.</summary>
	/// <returns>The <see cref="T:System.Object" /> removed from the top of the <see cref="T:System.Collections.Stack" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Collections.Stack" /> is empty.</exception>
	public virtual object Pop()
	{
		return null;
	}

	/// <summary>Inserts an object at the top of the <see cref="T:System.Collections.Stack" />.</summary>
	/// <param name="obj">The <see cref="T:System.Object" /> to push onto the <see cref="T:System.Collections.Stack" />. The value can be <see langword="null" />.</param>
	public virtual void Push(object obj)
	{
	}
}
