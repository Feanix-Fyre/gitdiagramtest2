using System.Collections.Generic;
using System.Diagnostics;

namespace System.Collections.ObjectModel;

/// <summary>Represents a read-only, generic collection of key/value pairs.</summary>
/// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
/// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(DictionaryDebugView<, >))]
public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
{
	[Serializable]
	private struct DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private readonly IDictionary<TKey, TValue> _dictionary;

		private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator;

		public DictionaryEntry Entry => default(DictionaryEntry);

		public object Key => null;

		public object Value => null;

		public object Current => null;

		public DictionaryEnumerator(IDictionary<TKey, TValue> dictionary)
		{
			_dictionary = null;
			_enumerator = null;
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	/// <summary>Represents a read-only collection of the keys of a <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" /> object.</summary>
	/// <typeparam name="TKey" />
	/// <typeparam name="TValue" />
	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
	public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
	{
		private readonly ICollection<TKey> _collection;

		[NonSerialized]
		private object _syncRoot;

		/// <summary>Gets the number of elements in the collection.</summary>
		/// <returns>The number of elements in the collection.</returns>
		public int Count => 0;

		bool ICollection<TKey>.IsReadOnly => false;

		/// <summary>Gets a value that indicates whether access to the collection is synchronized (thread safe).</summary>
		/// <returns>
		///   <see langword="true" /> if access to the collection is synchronized (thread safe); otherwise, <see langword="false" />.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>An object that can be used to synchronize access to the collection.</returns>
		object ICollection.SyncRoot => null;

		internal KeyCollection(ICollection<TKey> collection)
		{
		}

		/// <summary>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</summary>
		/// <param name="item">The object to add to the collection.</param>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		void ICollection<TKey>.Add(TKey item)
		{
		}

		/// <summary>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</summary>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		void ICollection<TKey>.Clear()
		{
		}

		/// <summary>Determines whether the collection contains a specific value.</summary>
		/// <param name="item">The object to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if <paramref name="item" /> is found in the collection; otherwise, <see langword="false" />.</returns>
		bool ICollection<TKey>.Contains(TKey item)
		{
			return false;
		}

		/// <summary>Copies the elements of the collection to an array, starting at a specific array index.</summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from the collection. The array must have zero-based indexing.</param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="arrayIndex" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is multidimensional.  
		/// -or-  
		/// The number of elements in the source collection is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />.  
		/// -or-  
		/// Type <paramref name="T" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
		public void CopyTo(TKey[] array, int arrayIndex)
		{
		}

		/// <summary>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</summary>
		/// <param name="item">The object to remove from the collection.</param>
		/// <returns>
		///   <see langword="true" /> if <paramref name="item" /> was successfully removed from the collection; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if <paramref name="item" /> is not found in the original collection.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		bool ICollection<TKey>.Remove(TKey item)
		{
			return false;
		}

		/// <summary>Returns an enumerator that iterates through the collection.</summary>
		/// <returns>An enumerator that can be used to iterate through the collection.</returns>
		public IEnumerator<TKey> GetEnumerator()
		{
			return null;
		}

		/// <summary>Returns an enumerator that iterates through the collection.</summary>
		/// <returns>An enumerator that can be used to iterate through the collection.</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		/// <summary>Copies the elements of the collection to an array, starting at a specific array index.</summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from the collection. The array must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is multidimensional.  
		/// -or-  
		/// The number of elements in the source collection is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
		void ICollection.CopyTo(Array array, int index)
		{
		}

		internal KeyCollection()
		{
		}
	}

	/// <summary>Represents a read-only collection of the values of a <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" /> object.</summary>
	/// <typeparam name="TKey" />
	/// <typeparam name="TValue" />
	[Serializable]
	[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
	{
		private readonly ICollection<TValue> _collection;

		[NonSerialized]
		private object _syncRoot;

		/// <summary>Gets the number of elements in the collection.</summary>
		/// <returns>The number of elements in the collection.</returns>
		public int Count => 0;

		bool ICollection<TValue>.IsReadOnly => false;

		/// <summary>Gets a value that indicates whether access to the collection is synchronized (thread safe).</summary>
		/// <returns>
		///   <see langword="true" /> if access to the collection is synchronized (thread safe); otherwise, <see langword="false" />.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>An object that can be used to synchronize access to the collection.</returns>
		object ICollection.SyncRoot => null;

		internal ValueCollection(ICollection<TValue> collection)
		{
		}

		/// <summary>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</summary>
		/// <param name="item">The object to add to the collection.</param>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		void ICollection<TValue>.Add(TValue item)
		{
		}

		/// <summary>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</summary>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		void ICollection<TValue>.Clear()
		{
		}

		/// <summary>Determines whether the collection contains a specific value.</summary>
		/// <param name="item">The object to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if <paramref name="item" /> is found in the collection; otherwise, <see langword="false" />.</returns>
		bool ICollection<TValue>.Contains(TValue item)
		{
			return false;
		}

		/// <summary>Copies the elements of the collection to an array, starting at a specific array index.</summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from the collection. The array must have zero-based indexing.</param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="arrayIndex" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is multidimensional.  
		/// -or-  
		/// The number of elements in the source collection is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />.  
		/// -or-  
		/// Type <paramref name="T" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
		public void CopyTo(TValue[] array, int arrayIndex)
		{
		}

		/// <summary>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</summary>
		/// <param name="item">The object to remove from the collection.</param>
		/// <returns>
		///   <see langword="true" /> if <paramref name="item" /> was successfully removed from the collection; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if item is not found in the original collection.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		bool ICollection<TValue>.Remove(TValue item)
		{
			return false;
		}

		/// <summary>Returns an enumerator that iterates through the collection.</summary>
		/// <returns>An enumerator that can be used to iterate through the collection.</returns>
		public IEnumerator<TValue> GetEnumerator()
		{
			return null;
		}

		/// <summary>Returns an enumerator that iterates through the collection.</summary>
		/// <returns>An enumerator that can be used to iterate through the collection.</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		/// <summary>Copies the elements of the collection to an array, starting at a specific array index.</summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from the collection. The array must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is multidimensional.  
		/// -or-  
		/// The number of elements in the source collection is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
		void ICollection.CopyTo(Array array, int index)
		{
		}

		internal ValueCollection()
		{
		}
	}

	private readonly IDictionary<TKey, TValue> m_dictionary;

	[NonSerialized]
	private object _syncRoot;

	[NonSerialized]
	private KeyCollection _keys;

	[NonSerialized]
	private ValueCollection _values;

	/// <summary>Gets a key collection that contains the keys of the dictionary.</summary>
	/// <returns>A key collection that contains the keys of the dictionary.</returns>
	public KeyCollection Keys => null;

	/// <summary>Gets a collection that contains the values in the dictionary.</summary>
	/// <returns>A collection that contains the values in the object that implements <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" />.</returns>
	public ValueCollection Values => null;

	ICollection<TKey> IDictionary<TKey, TValue>.Keys => null;

	ICollection<TValue> IDictionary<TKey, TValue>.Values => null;

	/// <summary>Gets the element that has the specified key.</summary>
	/// <param name="key">The key of the element to get.</param>
	/// <returns>The element that has the specified key.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">The property is retrieved and <paramref name="key" /> is not found.</exception>
	public TValue this[TKey key] => default(TValue);

	TValue IDictionary<TKey, TValue>.this[TKey key]
	{
		get
		{
			return default(TValue);
		}
		set
		{
		}
	}

	/// <summary>Gets the number of items in the dictionary.</summary>
	/// <returns>The number of items in the dictionary.</returns>
	public int Count => 0;

	bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

	/// <summary>Gets a value that indicates whether the dictionary has a fixed size.</summary>
	/// <returns>
	///   <see langword="true" /> if the dictionary has a fixed size; otherwise, <see langword="false" />.</returns>
	bool IDictionary.IsFixedSize => false;

	/// <summary>Gets a value that indicates whether the dictionary is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> in all cases.</returns>
	bool IDictionary.IsReadOnly => false;

	/// <summary>Gets a collection that contains the keys of the dictionary.</summary>
	/// <returns>A collection that contains the keys of the dictionary.</returns>
	ICollection IDictionary.Keys => null;

	/// <summary>Gets a collection that contains the values in the dictionary.</summary>
	/// <returns>A collection that contains the values in the dictionary.</returns>
	ICollection IDictionary.Values => null;

	/// <summary>Gets the element that has the specified key.</summary>
	/// <param name="key">The key of the element to get or set.</param>
	/// <returns>The element that has the specified key.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The property is set.  
	///  -or-  
	///  The property is set, <paramref name="key" /> does not exist in the collection, and the dictionary has a fixed size.</exception>
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

	/// <summary>Gets a value that indicates whether access to the dictionary is synchronized (thread safe).</summary>
	/// <returns>
	///   <see langword="true" /> if access to the dictionary is synchronized (thread safe); otherwise, <see langword="false" />.</returns>
	bool ICollection.IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the dictionary.</summary>
	/// <returns>An object that can be used to synchronize access to the dictionary.</returns>
	object ICollection.SyncRoot => null;

	IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys => null;

	IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values => null;

	/// <summary>Determines whether the dictionary contains an element that has the specified key.</summary>
	/// <param name="key">The key to locate in the dictionary.</param>
	/// <returns>
	///   <see langword="true" /> if the dictionary contains an element that has the specified key; otherwise, <see langword="false" />.</returns>
	public bool ContainsKey(TKey key)
	{
		return false;
	}

	/// <summary>Retrieves the value that is associated with the specified key.</summary>
	/// <param name="key">The key whose value will be retrieved.</param>
	/// <param name="value">When this method returns, the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <paramref name="value" /> parameter. This parameter is passed uninitialized.</param>
	/// <returns>
	///   <see langword="true" /> if the object that implements <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" /> contains an element with the specified key; otherwise, <see langword="false" />.</returns>
	public bool TryGetValue(TKey key, out TValue value)
	{
		value = default(TValue);
		return false;
	}

	void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
	{
	}

	bool IDictionary<TKey, TValue>.Remove(TKey key)
	{
		return false;
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
	{
		return false;
	}

	void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
	}

	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
	{
	}

	void ICollection<KeyValuePair<TKey, TValue>>.Clear()
	{
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
	{
		return false;
	}

	/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" />.</summary>
	/// <returns>An enumerator that can be used to iterate through the collection.</returns>
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns an enumerator that iterates through a collection.</summary>
	/// <returns>An enumerator that can be used to iterate through the collection.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	private static bool IsCompatibleKey(object key)
	{
		return false;
	}

	/// <summary>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="value">The value of the element to add.</param>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	void IDictionary.Add(object key, object value)
	{
	}

	/// <summary>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</summary>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	void IDictionary.Clear()
	{
	}

	/// <summary>Determines whether the dictionary contains an element that has the specified key.</summary>
	/// <param name="key">The key to locate in the dictionary.</param>
	/// <returns>
	///   <see langword="true" /> if the dictionary contains an element that has the specified key; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	bool IDictionary.Contains(object key)
	{
		return false;
	}

	/// <summary>Returns an enumerator for the dictionary.</summary>
	/// <returns>An enumerator for the dictionary.</returns>
	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return null;
	}

	/// <summary>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
	void IDictionary.Remove(object key)
	{
	}

	/// <summary>Copies the elements of the dictionary to an array, starting at the specified array index.</summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from the dictionary. The array must have zero-based indexing.</param>
	/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional.  
	/// -or-  
	/// The number of elements in the source dictionary is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.  
	/// -or-  
	/// The type of the source dictionary cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
	void ICollection.CopyTo(Array array, int index)
	{
	}
}
