using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Windows.Forms;

/// <summary>Contains a collection of strings to use for the auto-complete feature on certain Windows Forms controls.</summary>
public class AutoCompleteStringCollection : ICollection, IList
{
	private ArrayList list;

	/// <summary>Gets a value indicating whether the collection has a fixed size. For a description of this member, see <see cref="P:System.Collections.IList.IsFixedSize" />.</summary>
	/// <returns>
	///   <see langword="true" /> if the collection has a fixed size; otherwise, <see langword="false" />.</returns>
	bool IList.IsFixedSize => false;

	/// <summary>Gets a value indicating whether the collection is read-only. For a description of this member, see <see cref="P:System.Collections.IList.IsReadOnly" />.</summary>
	/// <returns>
	///   <see langword="true" /> if the collection is read-only; otherwise, <see langword="false" />.</returns>
	bool IList.IsReadOnly => false;

	/// <summary>Gets the element at a specified index. For a description of this member, see <see cref="P:System.Collections.IList.Item(System.Int32)" />.</summary>
	/// <param name="index">The zero-based index of the element to get.</param>
	/// <returns>The element at the specified index.</returns>
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

	/// <summary>Gets the number of items in the <see cref="T:System.Windows.Forms.AutoCompleteStringCollection" /> .</summary>
	/// <returns>The number of items in the <see cref="T:System.Windows.Forms.AutoCompleteStringCollection" />.</returns>
	public int Count => 0;

	/// <summary>Gets a value indicating whether access to the <see cref="T:System.Windows.Forms.AutoCompleteStringCollection" /> is synchronized (thread safe).</summary>
	/// <returns>
	///   <see langword="false" /> in all cases.</returns>
	public bool IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Windows.Forms.AutoCompleteStringCollection" />.</summary>
	/// <returns>Returns this <see cref="T:System.Windows.Forms.AutoCompleteStringCollection" />.</returns>
	public object SyncRoot => null;

	/// <summary>Gets a value indicating whether the contents of the collection are read-only.</summary>
	/// <returns>
	///   <see langword="false" /> in all cases.</returns>
	public bool IsReadOnly => false;

	/// <summary>Gets or sets the element at the specified index.</summary>
	/// <param name="index">The index at which to get or set the <see cref="T:System.String" />.</param>
	/// <returns>The <see cref="T:System.String" /> at the specified position.</returns>
	public string this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Occurs when the collection changes.</summary>
	public event CollectionChangeEventHandler CollectionChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
		}
	}

	/// <summary>Copies the strings of the collection to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index. For a description of this member, see <see cref="M:System.Collections.ICollection.CopyTo(System.Array,System.Int32)" />.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the strings copied from collection. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
	/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
	void ICollection.CopyTo(Array array, int index)
	{
	}

	/// <summary>Adds a string to the collection. For a description of this member, see <see cref="M:System.Collections.IList.Add(System.Object)" />.</summary>
	/// <param name="value">The string to be added to the collection</param>
	/// <returns>The index at which the <paramref name="value" /> has been added.</returns>
	int IList.Add(object value)
	{
		return 0;
	}

	/// <summary>Determines where the collection contains a specified string. For a description of this member, see <see cref="M:System.Collections.IList.Contains(System.Object)" />.</summary>
	/// <param name="value">The string to locate in the collection.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is found in the collection; otherwise, <see langword="false" />.</returns>
	bool IList.Contains(object value)
	{
		return false;
	}

	/// <summary>Determines the index of a specified string in the collection. For a description of this member, see <see cref="M:System.Collections.IList.IndexOf(System.Object)" />.</summary>
	/// <param name="value">The string to locate in the collection.</param>
	/// <returns>The index of <paramref name="value" /> if found in the list; otherwise, -1.</returns>
	int IList.IndexOf(object value)
	{
		return 0;
	}

	/// <summary>Inserts an item to the collection at the specified index. For a description of this member, see <see cref="M:System.Collections.IList.Insert(System.Int32,System.Object)" />.</summary>
	/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
	/// <param name="value">The string to insert into the collection.</param>
	void IList.Insert(int index, object value)
	{
	}

	/// <summary>Removes the first occurrence of a specific string from the collection. For a description of this member, see <see cref="M:System.Collections.IList.Remove(System.Object)" />.</summary>
	/// <param name="value">The string to remove from the collection.</param>
	void IList.Remove(object value)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.AutoCompleteStringCollection.CollectionChanged" /> event.</summary>
	/// <param name="e">A <see cref="T:System.ComponentModel.CollectionChangeEventArgs" /> that contains the event data.</param>
	protected void OnCollectionChanged(CollectionChangeEventArgs e)
	{
	}

	/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Windows.Forms.AutoCompleteStringCollection" />.</summary>
	/// <returns>An enumerator that iterates through the collection.</returns>
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Inserts a new <see cref="T:System.String" /> into the collection.</summary>
	/// <param name="value">The <see cref="T:System.String" /> to add to the collection.</param>
	/// <returns>The position in the collection where the <see cref="T:System.String" /> was added.</returns>
	public int Add(string value)
	{
		return 0;
	}

	/// <summary>Removes all strings from the collection.</summary>
	public void Clear()
	{
	}

	/// <summary>Indicates whether the <see cref="T:System.String" /> exists within the collection.</summary>
	/// <param name="value">The <see cref="T:System.String" /> for which to search.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.String" /> exists within the collection; otherwise, <see langword="false" />.</returns>
	public bool Contains(string value)
	{
		return false;
	}

	/// <summary>Obtains the position of the specified string within the collection.</summary>
	/// <param name="value">The <see cref="T:System.String" /> for which to search.</param>
	/// <returns>The index for the specified item.</returns>
	public int IndexOf(string value)
	{
		return 0;
	}

	/// <summary>Inserts the string into a specific index in the collection.</summary>
	/// <param name="index">The position at which to insert the string.</param>
	/// <param name="value">The string to insert.</param>
	public void Insert(int index, string value)
	{
	}

	/// <summary>Removes a string from the collection.</summary>
	/// <param name="value">The <see cref="T:System.String" /> to remove.</param>
	public void Remove(string value)
	{
	}

	/// <summary>Removes the string at the specified index.</summary>
	/// <param name="index">The zero-based index of the string to remove.</param>
	public void RemoveAt(int index)
	{
	}
}
