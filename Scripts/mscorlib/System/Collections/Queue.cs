using System.Diagnostics;

namespace System.Collections;

/// <summary>Represents a first-in, first-out collection of objects.</summary>
[Serializable]
[DebuggerTypeProxy(typeof(QueueDebugView))]
[DebuggerDisplay("Count = {Count}")]
public class Queue : ICollection, IEnumerable, ICloneable
{
	[Serializable]
	private class QueueEnumerator : IEnumerator, ICloneable
	{
		private Queue _q;

		private int _index;

		private int _version;

		private object _currentElement;

		public virtual object Current => null;

		internal QueueEnumerator(Queue q)
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

	internal class QueueDebugView
	{
	}

	private object[] _array;

	private int _head;

	private int _tail;

	private int _size;

	private int _growFactor;

	private int _version;

	[NonSerialized]
	private object _syncRoot;

	/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Queue" />.</summary>
	/// <returns>The number of elements contained in the <see cref="T:System.Collections.Queue" />.</returns>
	public virtual int Count => 0;

	/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Queue" /> is synchronized (thread safe).</summary>
	/// <returns>
	///   <see langword="true" /> if access to the <see cref="T:System.Collections.Queue" /> is synchronized (thread safe); otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public virtual bool IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Queue" />.</summary>
	/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Queue" />.</returns>
	public virtual object SyncRoot => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Queue" /> class that is empty, has the default initial capacity, and uses the default growth factor.</summary>
	public Queue()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Queue" /> class that is empty, has the specified initial capacity, and uses the default growth factor.</summary>
	/// <param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Queue" /> can contain.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="capacity" /> is less than zero.</exception>
	public Queue(int capacity)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Queue" /> class that is empty, has the specified initial capacity, and uses the specified growth factor.</summary>
	/// <param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Queue" /> can contain.</param>
	/// <param name="growFactor">The factor by which the capacity of the <see cref="T:System.Collections.Queue" /> is expanded.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="capacity" /> is less than zero.  
	/// -or-  
	/// <paramref name="growFactor" /> is less than 1.0 or greater than 10.0.</exception>
	public Queue(int capacity, float growFactor)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Queue" /> class that contains elements copied from the specified collection, has the same initial capacity as the number of elements copied, and uses the default growth factor.</summary>
	/// <param name="col">The <see cref="T:System.Collections.ICollection" /> to copy elements from.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="col" /> is <see langword="null" />.</exception>
	public Queue(ICollection col)
	{
	}

	/// <summary>Creates a shallow copy of the <see cref="T:System.Collections.Queue" />.</summary>
	/// <returns>A shallow copy of the <see cref="T:System.Collections.Queue" />.</returns>
	public virtual object Clone()
	{
		return null;
	}

	/// <summary>Copies the <see cref="T:System.Collections.Queue" /> elements to an existing one-dimensional <see cref="T:System.Array" />, starting at the specified array index.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Queue" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
	/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional.  
	/// -or-  
	/// The number of elements in the source <see cref="T:System.Collections.Queue" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
	/// <exception cref="T:System.ArrayTypeMismatchException">The type of the source <see cref="T:System.Collections.Queue" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
	public virtual void CopyTo(Array array, int index)
	{
	}

	/// <summary>Adds an object to the end of the <see cref="T:System.Collections.Queue" />.</summary>
	/// <param name="obj">The object to add to the <see cref="T:System.Collections.Queue" />. The value can be <see langword="null" />.</param>
	public virtual void Enqueue(object obj)
	{
	}

	/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Queue" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.Queue" />.</returns>
	public virtual IEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Removes and returns the object at the beginning of the <see cref="T:System.Collections.Queue" />.</summary>
	/// <returns>The object that is removed from the beginning of the <see cref="T:System.Collections.Queue" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Collections.Queue" /> is empty.</exception>
	public virtual object Dequeue()
	{
		return null;
	}

	/// <summary>Returns the object at the beginning of the <see cref="T:System.Collections.Queue" /> without removing it.</summary>
	/// <returns>The object at the beginning of the <see cref="T:System.Collections.Queue" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Collections.Queue" /> is empty.</exception>
	public virtual object Peek()
	{
		return null;
	}

	internal object GetElement(int i)
	{
		return null;
	}

	private void SetCapacity(int capacity)
	{
	}
}
