using System.Diagnostics;

namespace System.Collections.Generic;

/// <summary>Represents a collection of key/value pairs that are sorted by key based on the associated <see cref="T:System.Collections.Generic.IComparer`1" /> implementation.</summary>
/// <typeparam name="TKey">The type of keys in the collection.</typeparam>
/// <typeparam name="TValue">The type of values in the collection.</typeparam>
[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
public class SortedList<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
{
	[Serializable]
	private struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		private SortedList<TKey, TValue> _sortedList;

		private TKey _key;

		private TValue _value;

		private int _index;

		private int _version;

		private int _getEnumeratorRetType;

		object IDictionaryEnumerator.Key => null;

		DictionaryEntry IDictionaryEnumerator.Entry => default(DictionaryEntry);

		public KeyValuePair<TKey, TValue> Current => default(KeyValuePair<TKey, TValue>);

		object IEnumerator.Current => null;

		object IDictionaryEnumerator.Value => null;

		internal Enumerator(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType)
		{
			_sortedList = null;
			_key = default(TKey);
			_value = default(TValue);
			_index = 0;
			_version = 0;
			_getEnumeratorRetType = 0;
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	private sealed class SortedListKeyEnumerator : IEnumerator<TKey>, IDisposable, IEnumerator
	{
		private SortedList<TKey, TValue> _sortedList;

		private int _index;

		private int _version;

		private TKey _currentKey;

		public TKey Current => default(TKey);

		object IEnumerator.Current => null;

		internal SortedListKeyEnumerator(SortedList<TKey, TValue> sortedList)
		{
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	private sealed class SortedListValueEnumerator : IEnumerator<TValue>, IDisposable, IEnumerator
	{
		private SortedList<TKey, TValue> _sortedList;

		private int _index;

		private int _version;

		private TValue _currentValue;

		public TValue Current => default(TValue);

		object IEnumerator.Current => null;

		internal SortedListValueEnumerator(SortedList<TKey, TValue> sortedList)
		{
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	private sealed class KeyList : IList<TKey>, ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection
	{
		private SortedList<TKey, TValue> _dict;

		public int Count => 0;

		public bool IsReadOnly => false;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		public TKey this[int index]
		{
			get
			{
				return default(TKey);
			}
			set
			{
			}
		}

		internal KeyList(SortedList<TKey, TValue> dictionary)
		{
		}

		public void Add(TKey key)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(TKey key)
		{
			return false;
		}

		public void CopyTo(TKey[] array, int arrayIndex)
		{
		}

		void ICollection.CopyTo(Array array, int arrayIndex)
		{
		}

		public void Insert(int index, TKey value)
		{
		}

		public IEnumerator<TKey> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public int IndexOf(TKey key)
		{
			return 0;
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public void RemoveAt(int index)
		{
		}
	}

	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
	private sealed class ValueList : IList<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection
	{
		private SortedList<TKey, TValue> _dict;

		public int Count => 0;

		public bool IsReadOnly => false;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		public TValue this[int index]
		{
			get
			{
				return default(TValue);
			}
			set
			{
			}
		}

		internal ValueList(SortedList<TKey, TValue> dictionary)
		{
		}

		public void Add(TValue key)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(TValue value)
		{
			return false;
		}

		public void CopyTo(TValue[] array, int arrayIndex)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		public void Insert(int index, TValue value)
		{
		}

		public IEnumerator<TValue> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public int IndexOf(TValue value)
		{
			return 0;
		}

		public bool Remove(TValue value)
		{
			return false;
		}

		public void RemoveAt(int index)
		{
		}
	}

	private TKey[] keys;

	private TValue[] values;

	private int _size;

	private int version;

	private IComparer<TKey> comparer;

	private KeyList keyList;

	private ValueList valueList;

	[NonSerialized]
	private object _syncRoot;

	/// <summary>Gets or sets the number of elements that the <see cref="T:System.Collections.Generic.SortedList`2" /> can contain.</summary>
	/// <returns>The number of elements that the <see cref="T:System.Collections.Generic.SortedList`2" /> can contain.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <see cref="P:System.Collections.Generic.SortedList`2.Capacity" /> is set to a value that is less than <see cref="P:System.Collections.Generic.SortedList`2.Count" />.</exception>
	/// <exception cref="T:System.OutOfMemoryException">There is not enough memory available on the system.</exception>
	public int Capacity
	{
		set
		{
		}
	}

	/// <summary>Gets the <see cref="T:System.Collections.Generic.IComparer`1" /> for the sorted list.</summary>
	/// <returns>The <see cref="T:System.IComparable`1" /> for the current <see cref="T:System.Collections.Generic.SortedList`2" />.</returns>
	public IComparer<TKey> Comparer => null;

	/// <summary>Gets the number of key/value pairs contained in the <see cref="T:System.Collections.Generic.SortedList`2" />.</summary>
	/// <returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Generic.SortedList`2" />.</returns>
	public int Count => 0;

	/// <summary>Gets a collection containing the keys in the <see cref="T:System.Collections.Generic.SortedList`2" />, in sorted order.</summary>
	/// <returns>A <see cref="T:System.Collections.Generic.IList`1" /> containing the keys in the <see cref="T:System.Collections.Generic.SortedList`2" />.</returns>
	public IList<TKey> Keys => null;

	ICollection<TKey> IDictionary<TKey, TValue>.Keys => null;

	/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the keys of the <see cref="T:System.Collections.IDictionary" />.</summary>
	/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the keys of the <see cref="T:System.Collections.IDictionary" />.</returns>
	ICollection IDictionary.Keys => null;

	IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys => null;

	/// <summary>Gets a collection containing the values in the <see cref="T:System.Collections.Generic.SortedList`2" />.</summary>
	/// <returns>A <see cref="T:System.Collections.Generic.IList`1" /> containing the values in the <see cref="T:System.Collections.Generic.SortedList`2" />.</returns>
	public IList<TValue> Values => null;

	ICollection<TValue> IDictionary<TKey, TValue>.Values => null;

	/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.IDictionary" />.</summary>
	/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.IDictionary" />.</returns>
	ICollection IDictionary.Values => null;

	IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values => null;

	bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IDictionary" /> is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.IDictionary" /> is read-only; otherwise, <see langword="false" />.  In the default implementation of <see cref="T:System.Collections.Generic.SortedList`2" />, this property always returns <see langword="false" />.</returns>
	bool IDictionary.IsReadOnly => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IDictionary" /> has a fixed size.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.IDictionary" /> has a fixed size; otherwise, <see langword="false" />.  In the default implementation of <see cref="T:System.Collections.Generic.SortedList`2" />, this property always returns <see langword="false" />.</returns>
	bool IDictionary.IsFixedSize => false;

	/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).</summary>
	/// <returns>
	///   <see langword="true" /> if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, <see langword="false" />.  In the default implementation of <see cref="T:System.Collections.Generic.SortedList`2" />, this property always returns <see langword="false" />.</returns>
	bool ICollection.IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</summary>
	/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.  In the default implementation of <see cref="T:System.Collections.Generic.SortedList`2" />, this property always returns the current instance.</returns>
	object ICollection.SyncRoot => null;

	/// <summary>Gets or sets the value associated with the specified key.</summary>
	/// <param name="key">The key whose value to get or set.</param>
	/// <returns>The value associated with the specified key. If the specified key is not found, a get operation throws a <see cref="T:System.Collections.Generic.KeyNotFoundException" /> and a set operation creates a new element using the specified key.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">The property is retrieved and <paramref name="key" /> does not exist in the collection.</exception>
	public TValue this[TKey key]
	{
		get
		{
			return default(TValue);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the element with the specified key.</summary>
	/// <param name="key">The key of the element to get or set.</param>
	/// <returns>The element with the specified key, or <see langword="null" /> if <paramref name="key" /> is not in the dictionary or <paramref name="key" /> is of a type that is not assignable to the key type <paramref name="TKey" /> of the <see cref="T:System.Collections.Generic.SortedList`2" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">A value is being assigned, and <paramref name="key" /> is of a type that is not assignable to the key type <paramref name="TKey" /> of the <see cref="T:System.Collections.Generic.SortedList`2" />.  
	///  -or-  
	///  A value is being assigned, and <paramref name="value" /> is of a type that is not assignable to the value type <paramref name="TValue" /> of the <see cref="T:System.Collections.Generic.SortedList`2" />.</exception>
	object IDictionary.this[object key]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.SortedList`2" /> class that is empty, has the default initial capacity, and uses the default <see cref="T:System.Collections.Generic.IComparer`1" />.</summary>
	public SortedList()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.SortedList`2" /> class that is empty, has the specified initial capacity, and uses the default <see cref="T:System.Collections.Generic.IComparer`1" />.</summary>
	/// <param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Generic.SortedList`2" /> can contain.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="capacity" /> is less than zero.</exception>
	public SortedList(int capacity)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.SortedList`2" /> class that is empty, has the default initial capacity, and uses the specified <see cref="T:System.Collections.Generic.IComparer`1" />.</summary>
	/// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> implementation to use when comparing keys.  
	///  -or-  
	///  <see langword="null" /> to use the default <see cref="T:System.Collections.Generic.Comparer`1" /> for the type of the key.</param>
	public SortedList(IComparer<TKey> comparer)
	{
	}

	/// <summary>Adds an element with the specified key and value into the <see cref="T:System.Collections.Generic.SortedList`2" />.</summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="value">The value of the element to add. The value can be <see langword="null" /> for reference types.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">An element with the same key already exists in the <see cref="T:System.Collections.Generic.SortedList`2" />.</exception>
	public void Add(TKey key, TValue value)
	{
	}

	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
	{
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
	{
		return false;
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
	{
		return false;
	}

	/// <summary>Adds an element with the provided key and value to the <see cref="T:System.Collections.IDictionary" />.</summary>
	/// <param name="key">The <see cref="T:System.Object" /> to use as the key of the element to add.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to use as the value of the element to add.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="key" /> is of a type that is not assignable to the key type <paramref name="TKey" /> of the <see cref="T:System.Collections.IDictionary" />.  
	/// -or-  
	/// <paramref name="value" /> is of a type that is not assignable to the value type <paramref name="TValue" /> of the <see cref="T:System.Collections.IDictionary" />.  
	/// -or-  
	/// An element with the same key already exists in the <see cref="T:System.Collections.IDictionary" />.</exception>
	void IDictionary.Add(object key, object value)
	{
	}

	private KeyList GetKeyListHelper()
	{
		return null;
	}

	private ValueList GetValueListHelper()
	{
		return null;
	}

	/// <summary>Removes all elements from the <see cref="T:System.Collections.Generic.SortedList`2" />.</summary>
	public void Clear()
	{
	}

	/// <summary>Determines whether the <see cref="T:System.Collections.IDictionary" /> contains an element with the specified key.</summary>
	/// <param name="key">The key to locate in the <see cref="T:System.Collections.IDictionary" />.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.IDictionary" /> contains an element with the key; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	bool IDictionary.Contains(object key)
	{
		return false;
	}

	/// <summary>Determines whether the <see cref="T:System.Collections.Generic.SortedList`2" /> contains a specific key.</summary>
	/// <param name="key">The key to locate in the <see cref="T:System.Collections.Generic.SortedList`2" />.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.Generic.SortedList`2" /> contains an element with the specified key; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	public bool ContainsKey(TKey key)
	{
		return false;
	}

	/// <summary>Determines whether the <see cref="T:System.Collections.Generic.SortedList`2" /> contains a specific value.</summary>
	/// <param name="value">The value to locate in the <see cref="T:System.Collections.Generic.SortedList`2" />. The value can be <see langword="null" /> for reference types.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.Generic.SortedList`2" /> contains an element with the specified value; otherwise, <see langword="false" />.</returns>
	public bool ContainsValue(TValue value)
	{
		return false;
	}

	void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
	}

	/// <summary>Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ICollection" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="arrayIndex" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional.  
	/// -or-  
	/// <paramref name="array" /> does not have zero-based indexing.  
	/// -or-  
	/// The number of elements in the source <see cref="T:System.Collections.ICollection" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />.  
	/// -or-  
	/// The type of the source <see cref="T:System.Collections.ICollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
	void ICollection.CopyTo(Array array, int index)
	{
	}

	private void EnsureCapacity(int min)
	{
	}

	private TValue GetByIndex(int index)
	{
		return default(TValue);
	}

	/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Generic.SortedList`2" />.</summary>
	/// <returns>An <see cref="T:System.Collections.Generic.IEnumerator`1" /> of type <see cref="T:System.Collections.Generic.KeyValuePair`2" /> for the <see cref="T:System.Collections.Generic.SortedList`2" />.</returns>
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> for the <see cref="T:System.Collections.IDictionary" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> for the <see cref="T:System.Collections.IDictionary" />.</returns>
	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns an enumerator that iterates through a collection.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	private TKey GetKey(int index)
	{
		return default(TKey);
	}

	/// <summary>Searches for the specified key and returns the zero-based index within the entire <see cref="T:System.Collections.Generic.SortedList`2" />.</summary>
	/// <param name="key">The key to locate in the <see cref="T:System.Collections.Generic.SortedList`2" />.</param>
	/// <returns>The zero-based index of <paramref name="key" /> within the entire <see cref="T:System.Collections.Generic.SortedList`2" />, if found; otherwise, -1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	public int IndexOfKey(TKey key)
	{
		return 0;
	}

	/// <summary>Searches for the specified value and returns the zero-based index of the first occurrence within the entire <see cref="T:System.Collections.Generic.SortedList`2" />.</summary>
	/// <param name="value">The value to locate in the <see cref="T:System.Collections.Generic.SortedList`2" />.  The value can be <see langword="null" /> for reference types.</param>
	/// <returns>The zero-based index of the first occurrence of <paramref name="value" /> within the entire <see cref="T:System.Collections.Generic.SortedList`2" />, if found; otherwise, -1.</returns>
	public int IndexOfValue(TValue value)
	{
		return 0;
	}

	private void Insert(int index, TKey key, TValue value)
	{
	}

	/// <summary>Gets the value associated with the specified key.</summary>
	/// <param name="key">The key whose value to get.</param>
	/// <param name="value">When this method returns, the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <paramref name="value" /> parameter. This parameter is passed uninitialized.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.Generic.SortedList`2" /> contains an element with the specified key; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	public bool TryGetValue(TKey key, out TValue value)
	{
		value = default(TValue);
		return false;
	}

	/// <summary>Removes the element at the specified index of the <see cref="T:System.Collections.Generic.SortedList`2" />.</summary>
	/// <param name="index">The zero-based index of the element to remove.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.Generic.SortedList`2.Count" />.</exception>
	public void RemoveAt(int index)
	{
	}

	/// <summary>Removes the element with the specified key from the <see cref="T:System.Collections.Generic.SortedList`2" />.</summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <returns>
	///   <see langword="true" /> if the element is successfully removed; otherwise, <see langword="false" />.  This method also returns <see langword="false" /> if <paramref name="key" /> was not found in the original <see cref="T:System.Collections.Generic.SortedList`2" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	public bool Remove(TKey key)
	{
		return false;
	}

	/// <summary>Removes the element with the specified key from the <see cref="T:System.Collections.IDictionary" />.</summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	void IDictionary.Remove(object key)
	{
	}

	private static bool IsCompatibleKey(object key)
	{
		return false;
	}
}
