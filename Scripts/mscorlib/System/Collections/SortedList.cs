using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections;

/// <summary>Represents a collection of key/value pairs that are sorted by the keys and are accessible by key and by index.</summary>
[Serializable]
[DebuggerTypeProxy(typeof(SortedListDebugView))]
[DebuggerDisplay("Count = {Count}")]
public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable
{
	[Serializable]
	private class SyncSortedList : SortedList
	{
		private SortedList _list;

		private object _root;

		public override int Count => 0;

		public override object SyncRoot => null;

		public override bool IsReadOnly => false;

		public override bool IsFixedSize => false;

		public override bool IsSynchronized => false;

		public override object this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal SyncSortedList(SortedList list)
		{
		}

		public override void Add(object key, object value)
		{
		}

		public override void Clear()
		{
		}

		public override object Clone()
		{
			return null;
		}

		public override bool Contains(object key)
		{
			return false;
		}

		public override bool ContainsKey(object key)
		{
			return false;
		}

		public override bool ContainsValue(object key)
		{
			return false;
		}

		public override void CopyTo(Array array, int index)
		{
		}

		public override object GetByIndex(int index)
		{
			return null;
		}

		public override IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		public override object GetKey(int index)
		{
			return null;
		}

		public override IList GetKeyList()
		{
			return null;
		}

		public override IList GetValueList()
		{
			return null;
		}

		public override int IndexOfKey(object key)
		{
			return 0;
		}

		public override int IndexOfValue(object value)
		{
			return 0;
		}

		public override void RemoveAt(int index)
		{
		}

		public override void Remove(object key)
		{
		}
	}

	[Serializable]
	private class SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
	{
		private SortedList _sortedList;

		private object _key;

		private object _value;

		private int _index;

		private int _startIndex;

		private int _endIndex;

		private int _version;

		private bool _current;

		private int _getObjectRetType;

		public virtual object Key => null;

		public virtual DictionaryEntry Entry => default(DictionaryEntry);

		public virtual object Current => null;

		public virtual object Value => null;

		internal SortedListEnumerator(SortedList sortedList, int index, int count, int getObjRetType)
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

	[Serializable]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	private class KeyList : IList, ICollection, IEnumerable
	{
		private SortedList sortedList;

		public virtual int Count => 0;

		public virtual bool IsReadOnly => false;

		public virtual bool IsFixedSize => false;

		public virtual bool IsSynchronized => false;

		public virtual object SyncRoot => null;

		public virtual object this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal KeyList(SortedList sortedList)
		{
		}

		public virtual int Add(object key)
		{
			return 0;
		}

		public virtual void Clear()
		{
		}

		public virtual bool Contains(object key)
		{
			return false;
		}

		public virtual void CopyTo(Array array, int arrayIndex)
		{
		}

		public virtual void Insert(int index, object value)
		{
		}

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		public virtual int IndexOf(object key)
		{
			return 0;
		}

		public virtual void Remove(object key)
		{
		}

		public virtual void RemoveAt(int index)
		{
		}
	}

	[Serializable]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	private class ValueList : IList, ICollection, IEnumerable
	{
		private SortedList sortedList;

		public virtual int Count => 0;

		public virtual bool IsReadOnly => false;

		public virtual bool IsFixedSize => false;

		public virtual bool IsSynchronized => false;

		public virtual object SyncRoot => null;

		public virtual object this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ValueList(SortedList sortedList)
		{
		}

		public virtual int Add(object key)
		{
			return 0;
		}

		public virtual void Clear()
		{
		}

		public virtual bool Contains(object value)
		{
			return false;
		}

		public virtual void CopyTo(Array array, int arrayIndex)
		{
		}

		public virtual void Insert(int index, object value)
		{
		}

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		public virtual int IndexOf(object value)
		{
			return 0;
		}

		public virtual void Remove(object value)
		{
		}

		public virtual void RemoveAt(int index)
		{
		}
	}

	internal class SortedListDebugView
	{
	}

	private object[] keys;

	private object[] values;

	private int _size;

	private int version;

	private IComparer comparer;

	private KeyList keyList;

	private ValueList valueList;

	[NonSerialized]
	private object _syncRoot;

	/// <summary>Gets or sets the capacity of a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <returns>The number of elements that the <see cref="T:System.Collections.SortedList" /> object can contain.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value assigned is less than the current number of elements in the <see cref="T:System.Collections.SortedList" /> object.</exception>
	/// <exception cref="T:System.OutOfMemoryException">There is not enough memory available on the system.</exception>
	public virtual int Capacity
	{
		set
		{
		}
	}

	/// <summary>Gets the number of elements contained in a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <returns>The number of elements contained in the <see cref="T:System.Collections.SortedList" /> object.</returns>
	public virtual int Count => 0;

	/// <summary>Gets the keys in a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <returns>An <see cref="T:System.Collections.ICollection" /> object containing the keys in the <see cref="T:System.Collections.SortedList" /> object.</returns>
	public virtual ICollection Keys => null;

	/// <summary>Gets the values in a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <returns>An <see cref="T:System.Collections.ICollection" /> object containing the values in the <see cref="T:System.Collections.SortedList" /> object.</returns>
	public virtual ICollection Values => null;

	/// <summary>Gets a value indicating whether a <see cref="T:System.Collections.SortedList" /> object is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.SortedList" /> object is read-only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public virtual bool IsReadOnly => false;

	/// <summary>Gets a value indicating whether a <see cref="T:System.Collections.SortedList" /> object has a fixed size.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.SortedList" /> object has a fixed size; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public virtual bool IsFixedSize => false;

	/// <summary>Gets a value indicating whether access to a <see cref="T:System.Collections.SortedList" /> object is synchronized (thread safe).</summary>
	/// <returns>
	///   <see langword="true" /> if access to the <see cref="T:System.Collections.SortedList" /> object is synchronized (thread safe); otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public virtual bool IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.SortedList" /> object.</returns>
	public virtual object SyncRoot => null;

	/// <summary>Gets or sets the value associated with a specific key in a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <param name="key">The key associated with the value to get or set.</param>
	/// <returns>The value associated with the <paramref name="key" /> parameter in the <see cref="T:System.Collections.SortedList" /> object, if <paramref name="key" /> is found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The property is set and the <see cref="T:System.Collections.SortedList" /> object is read-only.  
	///  -or-  
	///  The property is set, <paramref name="key" /> does not exist in the collection, and the <see cref="T:System.Collections.SortedList" /> has a fixed size.</exception>
	/// <exception cref="T:System.OutOfMemoryException">There is not enough available memory to add the element to the <see cref="T:System.Collections.SortedList" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The comparer throws an exception.</exception>
	public virtual object this[object key]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.SortedList" /> class that is empty, has the default initial capacity, and is sorted according to the <see cref="T:System.IComparable" /> interface implemented by each key added to the <see cref="T:System.Collections.SortedList" /> object.</summary>
	public SortedList()
	{
	}

	private void Init()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.SortedList" /> class that is empty, has the specified initial capacity, and is sorted according to the <see cref="T:System.IComparable" /> interface implemented by each key added to the <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <param name="initialCapacity">The initial number of elements that the <see cref="T:System.Collections.SortedList" /> object can contain.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="initialCapacity" /> is less than zero.</exception>
	/// <exception cref="T:System.OutOfMemoryException">There is not enough available memory to create a <see cref="T:System.Collections.SortedList" /> object with the specified <paramref name="initialCapacity" />.</exception>
	public SortedList(int initialCapacity)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.SortedList" /> class that is empty, has the default initial capacity, and is sorted according to the specified <see cref="T:System.Collections.IComparer" /> interface.</summary>
	/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing keys.  
	///  -or-  
	///  <see langword="null" /> to use the <see cref="T:System.IComparable" /> implementation of each key.</param>
	public SortedList(IComparer comparer)
	{
	}

	/// <summary>Adds an element with the specified key and value to a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="value">The value of the element to add. The value can be <see langword="null" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">An element with the specified <paramref name="key" /> already exists in the <see cref="T:System.Collections.SortedList" /> object.  
	///  -or-  
	///  The <see cref="T:System.Collections.SortedList" /> is set to use the <see cref="T:System.IComparable" /> interface, and <paramref name="key" /> does not implement the <see cref="T:System.IComparable" /> interface.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.SortedList" /> is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.SortedList" /> has a fixed size.</exception>
	/// <exception cref="T:System.OutOfMemoryException">There is not enough available memory to add the element to the <see cref="T:System.Collections.SortedList" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The comparer throws an exception.</exception>
	public virtual void Add(object key, object value)
	{
	}

	/// <summary>Removes all elements from a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.SortedList" /> object is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.SortedList" /> has a fixed size.</exception>
	public virtual void Clear()
	{
	}

	/// <summary>Creates a shallow copy of a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <returns>A shallow copy of the <see cref="T:System.Collections.SortedList" /> object.</returns>
	public virtual object Clone()
	{
		return null;
	}

	/// <summary>Determines whether a <see cref="T:System.Collections.SortedList" /> object contains a specific key.</summary>
	/// <param name="key">The key to locate in the <see cref="T:System.Collections.SortedList" /> object.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.SortedList" /> object contains an element with the specified <paramref name="key" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The comparer throws an exception.</exception>
	public virtual bool Contains(object key)
	{
		return false;
	}

	/// <summary>Determines whether a <see cref="T:System.Collections.SortedList" /> object contains a specific key.</summary>
	/// <param name="key">The key to locate in the <see cref="T:System.Collections.SortedList" /> object.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.SortedList" /> object contains an element with the specified <paramref name="key" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The comparer throws an exception.</exception>
	public virtual bool ContainsKey(object key)
	{
		return false;
	}

	/// <summary>Determines whether a <see cref="T:System.Collections.SortedList" /> object contains a specific value.</summary>
	/// <param name="value">The value to locate in the <see cref="T:System.Collections.SortedList" /> object. The value can be <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.SortedList" /> object contains an element with the specified <paramref name="value" />; otherwise, <see langword="false" />.</returns>
	public virtual bool ContainsValue(object value)
	{
		return false;
	}

	/// <summary>Copies <see cref="T:System.Collections.SortedList" /> elements to a one-dimensional <see cref="T:System.Array" /> object, starting at the specified index in the array.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> object that is the destination of the <see cref="T:System.Collections.DictionaryEntry" /> objects copied from <see cref="T:System.Collections.SortedList" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="arrayIndex" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional.  
	/// -or-  
	/// The number of elements in the source <see cref="T:System.Collections.SortedList" /> object is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.SortedList" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
	public virtual void CopyTo(Array array, int arrayIndex)
	{
	}

	private void EnsureCapacity(int min)
	{
	}

	/// <summary>Gets the value at the specified index of a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <param name="index">The zero-based index of the value to get.</param>
	/// <returns>The value at the specified index of the <see cref="T:System.Collections.SortedList" /> object.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is outside the range of valid indexes for the <see cref="T:System.Collections.SortedList" /> object.</exception>
	public virtual object GetByIndex(int index)
	{
		return null;
	}

	/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> that iterates through the <see cref="T:System.Collections.SortedList" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.SortedList" />.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> object that iterates through a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> object for the <see cref="T:System.Collections.SortedList" /> object.</returns>
	public virtual IDictionaryEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Gets the key at the specified index of a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <param name="index">The zero-based index of the key to get.</param>
	/// <returns>The key at the specified index of the <see cref="T:System.Collections.SortedList" /> object.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is outside the range of valid indexes for the <see cref="T:System.Collections.SortedList" /> object.</exception>
	public virtual object GetKey(int index)
	{
		return null;
	}

	/// <summary>Gets the keys in a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <returns>An <see cref="T:System.Collections.IList" /> object containing the keys in the <see cref="T:System.Collections.SortedList" /> object.</returns>
	public virtual IList GetKeyList()
	{
		return null;
	}

	/// <summary>Gets the values in a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <returns>An <see cref="T:System.Collections.IList" /> object containing the values in the <see cref="T:System.Collections.SortedList" /> object.</returns>
	public virtual IList GetValueList()
	{
		return null;
	}

	/// <summary>Returns the zero-based index of the specified key in a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <param name="key">The key to locate in the <see cref="T:System.Collections.SortedList" /> object.</param>
	/// <returns>The zero-based index of the <paramref name="key" /> parameter, if <paramref name="key" /> is found in the <see cref="T:System.Collections.SortedList" /> object; otherwise, -1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The comparer throws an exception.</exception>
	public virtual int IndexOfKey(object key)
	{
		return 0;
	}

	/// <summary>Returns the zero-based index of the first occurrence of the specified value in a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <param name="value">The value to locate in the <see cref="T:System.Collections.SortedList" /> object. The value can be <see langword="null" />.</param>
	/// <returns>The zero-based index of the first occurrence of the <paramref name="value" /> parameter, if <paramref name="value" /> is found in the <see cref="T:System.Collections.SortedList" /> object; otherwise, -1.</returns>
	public virtual int IndexOfValue(object value)
	{
		return 0;
	}

	private void Insert(int index, object key, object value)
	{
	}

	/// <summary>Removes the element at the specified index of a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <param name="index">The zero-based index of the element to remove.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is outside the range of valid indexes for the <see cref="T:System.Collections.SortedList" /> object.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.SortedList" /> is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.SortedList" /> has a fixed size.</exception>
	public virtual void RemoveAt(int index)
	{
	}

	/// <summary>Removes the element with the specified key from a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.SortedList" /> object is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.SortedList" /> has a fixed size.</exception>
	public virtual void Remove(object key)
	{
	}

	/// <summary>Returns a synchronized (thread-safe) wrapper for a <see cref="T:System.Collections.SortedList" /> object.</summary>
	/// <param name="list">The <see cref="T:System.Collections.SortedList" /> object to synchronize.</param>
	/// <returns>A synchronized (thread-safe) wrapper for the <see cref="T:System.Collections.SortedList" /> object.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="list" /> is <see langword="null" />.</exception>
	public static SortedList Synchronized(SortedList list)
	{
		return null;
	}
}
