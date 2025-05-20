using System.Collections;

namespace System.ComponentModel;

/// <summary>Represents a collection of <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects.</summary>
public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary
{
	private class PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private PropertyDescriptorCollection _owner;

		private int _index;

		public object Current => null;

		public DictionaryEntry Entry => default(DictionaryEntry);

		public object Key => null;

		public object Value => null;

		public PropertyDescriptorEnumerator(PropertyDescriptorCollection owner)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	/// <summary>Specifies an empty collection that you can use instead of creating a new one with no items. This <see langword="static" /> field is read-only.</summary>
	public static readonly PropertyDescriptorCollection Empty;

	private IDictionary _cachedFoundProperties;

	private bool _cachedIgnoreCase;

	private PropertyDescriptor[] _properties;

	private readonly string[] _namedSort;

	private readonly IComparer _comparer;

	private bool _propsOwned;

	private bool _needSort;

	private bool _readOnly;

	private readonly object _internalSyncObject;

	/// <summary>Gets the number of property descriptors in the collection.</summary>
	/// <returns>The number of property descriptors in the collection.</returns>
	public int Count { get; private set; }

	/// <summary>Gets or sets the <see cref="T:System.ComponentModel.PropertyDescriptor" /> at the specified index number.</summary>
	/// <param name="index">The zero-based index of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> to get or set.</param>
	/// <returns>The <see cref="T:System.ComponentModel.PropertyDescriptor" /> with the specified index number.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">The <paramref name="index" /> parameter is not a valid index for <see cref="P:System.ComponentModel.PropertyDescriptorCollection.Item(System.Int32)" />.</exception>
	public virtual PropertyDescriptor this[int index] => null;

	/// <summary>Gets or sets the <see cref="T:System.ComponentModel.PropertyDescriptor" /> with the specified name.</summary>
	/// <param name="name">The name of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> to get from the collection.</param>
	/// <returns>The <see cref="T:System.ComponentModel.PropertyDescriptor" /> with the specified name, or <see langword="null" /> if the property does not exist.</returns>
	public virtual PropertyDescriptor this[string name] => null;

	/// <summary>Gets a value indicating whether access to the collection is synchronized (thread safe).</summary>
	/// <returns>
	///   <see langword="true" /> if access to the collection is synchronized (thread safe); otherwise, <see langword="false" />.</returns>
	bool ICollection.IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
	/// <returns>An object that can be used to synchronize access to the collection.</returns>
	object ICollection.SyncRoot => null;

	/// <summary>Gets the number of elements contained in the collection.</summary>
	/// <returns>The number of elements contained in the collection.</returns>
	int ICollection.Count => 0;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IDictionary" /> has a fixed size.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.IDictionary" /> has a fixed size; otherwise, <see langword="false" />.</returns>
	bool IDictionary.IsFixedSize => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IDictionary" /> is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.IDictionary" /> is read-only; otherwise, <see langword="false" />.</returns>
	bool IDictionary.IsReadOnly => false;

	/// <summary>Gets or sets the element with the specified key.</summary>
	/// <param name="key">The key of the element to get or set.</param>
	/// <returns>The element with the specified key.</returns>
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

	/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the keys of the <see cref="T:System.Collections.IDictionary" />.</summary>
	/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the keys of the <see cref="T:System.Collections.IDictionary" />.</returns>
	ICollection IDictionary.Keys => null;

	/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.IDictionary" />.</summary>
	/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.IDictionary" />.</returns>
	ICollection IDictionary.Values => null;

	/// <summary>Gets a value indicating whether the collection is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the collection is read-only; otherwise, <see langword="false" />.</returns>
	bool IList.IsReadOnly => false;

	/// <summary>Gets a value indicating whether the collection has a fixed size.</summary>
	/// <returns>
	///   <see langword="true" /> if the collection has a fixed size; otherwise, <see langword="false" />.</returns>
	bool IList.IsFixedSize => false;

	/// <summary>Gets or sets an item from the collection at a specified index.</summary>
	/// <param name="index">The zero-based index of the item to get or set.</param>
	/// <returns>The element at the specified index.</returns>
	/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="value" /> is not a <see cref="T:System.ComponentModel.PropertyDescriptor" />.</exception>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="index" /> is less than 0.  
	/// -or-  
	/// <paramref name="index" /> is equal to or greater than <see cref="P:System.ComponentModel.EventDescriptorCollection.Count" />.</exception>
	object IList.this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> class.</summary>
	/// <param name="properties">An array of type <see cref="T:System.ComponentModel.PropertyDescriptor" /> that provides the properties for this collection.</param>
	public PropertyDescriptorCollection(PropertyDescriptor[] properties)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> class, which is optionally read-only.</summary>
	/// <param name="properties">An array of type <see cref="T:System.ComponentModel.PropertyDescriptor" /> that provides the properties for this collection.</param>
	/// <param name="readOnly">If <see langword="true" />, specifies that the collection cannot be modified.</param>
	public PropertyDescriptorCollection(PropertyDescriptor[] properties, bool readOnly)
	{
	}

	private PropertyDescriptorCollection(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer)
	{
	}

	/// <summary>Adds the specified <see cref="T:System.ComponentModel.PropertyDescriptor" /> to the collection.</summary>
	/// <param name="value">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to add to the collection.</param>
	/// <returns>The index of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> that was added to the collection.</returns>
	/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
	public int Add(PropertyDescriptor value)
	{
		return 0;
	}

	/// <summary>Removes all <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects from the collection.</summary>
	/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
	public void Clear()
	{
	}

	/// <summary>Returns whether the collection contains the given <see cref="T:System.ComponentModel.PropertyDescriptor" />.</summary>
	/// <param name="value">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to find in the collection.</param>
	/// <returns>
	///   <see langword="true" /> if the collection contains the given <see cref="T:System.ComponentModel.PropertyDescriptor" />; otherwise, <see langword="false" />.</returns>
	public bool Contains(PropertyDescriptor value)
	{
		return false;
	}

	/// <summary>Copies the entire collection to an array, starting at the specified index number.</summary>
	/// <param name="array">An array of <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects to copy elements of the collection to.</param>
	/// <param name="index">The index of the <paramref name="array" /> parameter at which copying begins.</param>
	public void CopyTo(Array array, int index)
	{
	}

	private void EnsurePropsOwned()
	{
	}

	private void EnsureSize(int sizeNeeded)
	{
	}

	/// <summary>Returns the <see cref="T:System.ComponentModel.PropertyDescriptor" /> with the specified name, using a Boolean to indicate whether to ignore case.</summary>
	/// <param name="name">The name of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> to return from the collection.</param>
	/// <param name="ignoreCase">
	///   <see langword="true" /> if you want to ignore the case of the property name; otherwise, <see langword="false" />.</param>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> with the specified name, or <see langword="null" /> if the property does not exist.</returns>
	public virtual PropertyDescriptor Find(string name, bool ignoreCase)
	{
		return null;
	}

	/// <summary>Returns the index of the given <see cref="T:System.ComponentModel.PropertyDescriptor" />.</summary>
	/// <param name="value">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to return the index of.</param>
	/// <returns>The index of the given <see cref="T:System.ComponentModel.PropertyDescriptor" />.</returns>
	public int IndexOf(PropertyDescriptor value)
	{
		return 0;
	}

	/// <summary>Adds the <see cref="T:System.ComponentModel.PropertyDescriptor" /> to the collection at the specified index number.</summary>
	/// <param name="index">The index at which to add the <paramref name="value" /> parameter to the collection.</param>
	/// <param name="value">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to add to the collection.</param>
	/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
	public void Insert(int index, PropertyDescriptor value)
	{
	}

	/// <summary>Removes the specified <see cref="T:System.ComponentModel.PropertyDescriptor" /> from the collection.</summary>
	/// <param name="value">The <see cref="T:System.ComponentModel.PropertyDescriptor" /> to remove from the collection.</param>
	/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
	public void Remove(PropertyDescriptor value)
	{
	}

	/// <summary>Removes the <see cref="T:System.ComponentModel.PropertyDescriptor" /> at the specified index from the collection.</summary>
	/// <param name="index">The index of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> to remove from the collection.</param>
	/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
	public void RemoveAt(int index)
	{
	}

	/// <summary>Sorts the members of this collection. The specified order is applied first, followed by the default sort for this collection, which is usually alphabetical.</summary>
	/// <param name="names">An array of strings describing the order in which to sort the <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects in this collection.</param>
	/// <returns>A new <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> that contains the sorted <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects.</returns>
	public virtual PropertyDescriptorCollection Sort(string[] names)
	{
		return null;
	}

	/// <summary>Sorts the members of this collection. The specified order is applied first, followed by the default sort for this collection, which is usually alphabetical.</summary>
	/// <param name="names">An array of strings describing the order in which to sort the <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects in this collection.</param>
	protected void InternalSort(string[] names)
	{
	}

	/// <summary>Sorts the members of this collection, using the specified <see cref="T:System.Collections.IComparer" />.</summary>
	/// <param name="sorter">A comparer to use to sort the <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects in this collection.</param>
	protected void InternalSort(IComparer sorter)
	{
	}

	/// <summary>Returns an enumerator for this class.</summary>
	/// <returns>An enumerator of type <see cref="T:System.Collections.IEnumerator" />.</returns>
	public virtual IEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Removes all items from the collection.</summary>
	/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
	void IList.Clear()
	{
	}

	/// <summary>Removes all elements from the <see cref="T:System.Collections.IDictionary" />.</summary>
	void IDictionary.Clear()
	{
	}

	/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.IDictionary" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.IDictionary" />.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	/// <summary>Removes the item at the specified index.</summary>
	/// <param name="index">The zero-based index of the item to remove.</param>
	/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
	void IList.RemoveAt(int index)
	{
	}

	/// <summary>Adds an element with the provided key and value to the <see cref="T:System.Collections.IDictionary" />.</summary>
	/// <param name="key">The <see cref="T:System.Object" /> to use as the key of the element to add.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to use as the value of the element to add.</param>
	/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	void IDictionary.Add(object key, object value)
	{
	}

	/// <summary>Determines whether the <see cref="T:System.Collections.IDictionary" /> contains an element with the specified key.</summary>
	/// <param name="key">The key to locate in the <see cref="T:System.Collections.IDictionary" />.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.IDictionary" /> contains an element with the key; otherwise, <see langword="false" />.</returns>
	bool IDictionary.Contains(object key)
	{
		return false;
	}

	/// <summary>Returns an enumerator for this class.</summary>
	/// <returns>An enumerator of type <see cref="T:System.Collections.IEnumerator" />.</returns>
	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return null;
	}

	/// <summary>Removes the element with the specified key from the <see cref="T:System.Collections.IDictionary" />.</summary>
	/// <param name="key">The key of the element to remove.</param>
	void IDictionary.Remove(object key)
	{
	}

	/// <summary>Adds an item to the <see cref="T:System.Collections.IList" />.</summary>
	/// <param name="value">The item to add to the collection.</param>
	/// <returns>The position into which the new element was inserted.</returns>
	int IList.Add(object value)
	{
		return 0;
	}

	/// <summary>Determines whether the collection contains a specific value.</summary>
	/// <param name="value">The item to locate in the collection.</param>
	/// <returns>
	///   <see langword="true" /> if the item is found in the collection; otherwise, <see langword="false" />.</returns>
	bool IList.Contains(object value)
	{
		return false;
	}

	/// <summary>Determines the index of a specified item in the collection.</summary>
	/// <param name="value">The item to locate in the collection.</param>
	/// <returns>The index of <paramref name="value" /> if found in the list, otherwise -1.</returns>
	int IList.IndexOf(object value)
	{
		return 0;
	}

	/// <summary>Inserts an item into the collection at a specified index.</summary>
	/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
	/// <param name="value">The item to insert into the collection.</param>
	/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
	void IList.Insert(int index, object value)
	{
	}

	/// <summary>Removes the first occurrence of a specified value from the collection.</summary>
	/// <param name="value">The item to remove from the collection.</param>
	/// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
	void IList.Remove(object value)
	{
	}
}
