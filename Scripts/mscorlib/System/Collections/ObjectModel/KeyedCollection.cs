using System.Collections.Generic;
using System.Diagnostics;

namespace System.Collections.ObjectModel;

/// <summary>Provides the abstract base class for a collection whose keys are embedded in the values.</summary>
/// <typeparam name="TKey">The type of keys in the collection.</typeparam>
/// <typeparam name="TItem">The type of items in the collection.</typeparam>
[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
public abstract class KeyedCollection<TKey, TItem> : Collection<TItem>
{
	private readonly IEqualityComparer<TKey> comparer;

	private Dictionary<TKey, TItem> dict;

	private int keyCount;

	private readonly int threshold;

	private new List<TItem> Items => null;

	/// <summary>Gets the element with the specified key.</summary>
	/// <param name="key">The key of the element to get.</param>
	/// <returns>The element with the specified key. If an element with the specified key is not found, an exception is thrown.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">An element with the specified key does not exist in the collection.</exception>
	public TItem this[TKey key] => default(TItem);

	/// <summary>Gets the lookup dictionary of the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</summary>
	/// <returns>The lookup dictionary of the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />, if it exists; otherwise, <see langword="null" />.</returns>
	protected IDictionary<TKey, TItem> Dictionary => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" /> class that uses the default equality comparer.</summary>
	protected KeyedCollection()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" /> class that uses the specified equality comparer.</summary>
	/// <param name="comparer">The implementation of the <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> generic interface to use when comparing keys, or <see langword="null" /> to use the default equality comparer for the type of the key, obtained from <see cref="P:System.Collections.Generic.EqualityComparer`1.Default" />.</param>
	protected KeyedCollection(IEqualityComparer<TKey> comparer)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" /> class that uses the specified equality comparer and creates a lookup dictionary when the specified threshold is exceeded.</summary>
	/// <param name="comparer">The implementation of the <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> generic interface to use when comparing keys, or <see langword="null" /> to use the default equality comparer for the type of the key, obtained from <see cref="P:System.Collections.Generic.EqualityComparer`1.Default" />.</param>
	/// <param name="dictionaryCreationThreshold">The number of elements the collection can hold without creating a lookup dictionary (0 creates the lookup dictionary when the first item is added), or -1 to specify that a lookup dictionary is never created.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="dictionaryCreationThreshold" /> is less than -1.</exception>
	protected KeyedCollection(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold)
	{
	}

	/// <summary>Determines whether the collection contains an element with the specified key.</summary>
	/// <param name="key">The key to locate in the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" /> contains an element with the specified key; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="key" /> is <see langword="null" />.</exception>
	public bool Contains(TKey key)
	{
		return false;
	}

	public bool TryGetValue(TKey key, out TItem item)
	{
		item = default(TItem);
		return false;
	}

	/// <summary>Removes all elements from the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</summary>
	protected override void ClearItems()
	{
	}

	/// <summary>When implemented in a derived class, extracts the key from the specified element.</summary>
	/// <param name="item">The element from which to extract the key.</param>
	/// <returns>The key for the specified element.</returns>
	protected abstract TKey GetKeyForItem(TItem item);

	/// <summary>Inserts an element into the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" /> at the specified index.</summary>
	/// <param name="index">The zero-based index at which <paramref name="item" /> should be inserted.</param>
	/// <param name="item">The object to insert.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than 0.  
	/// -or-  
	/// <paramref name="index" /> is greater than <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
	protected override void InsertItem(int index, TItem item)
	{
	}

	/// <summary>Removes the element at the specified index of the <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</summary>
	/// <param name="index">The index of the element to remove.</param>
	protected override void RemoveItem(int index)
	{
	}

	/// <summary>Replaces the item at the specified index with the specified item.</summary>
	/// <param name="index">The zero-based index of the item to be replaced.</param>
	/// <param name="item">The new item.</param>
	protected override void SetItem(int index, TItem item)
	{
	}

	private void AddKey(TKey key, TItem item)
	{
	}

	private void CreateDictionary()
	{
	}

	private void RemoveKey(TKey key)
	{
	}
}
