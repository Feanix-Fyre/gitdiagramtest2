using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Represents the collection of groups within a <see cref="T:System.Windows.Forms.ListView" /> control.</summary>
[ListBindable(false)]
public class ListViewGroupCollection : ICollection, IEnumerable, IList
{
	private List<ListViewGroup> list;

	private ListView list_view_owner;

	private ListViewGroup default_group;

	/// <summary>Gets a value indicating whether access to the collection is synchronized (thread safe).</summary>
	/// <returns>
	///   <see langword="true" /> in all cases.</returns>
	bool ICollection.IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
	/// <returns>The object used to synchronize the collection.</returns>
	object ICollection.SyncRoot => null;

	/// <summary>Gets a value indicating whether the collection has a fixed size.</summary>
	/// <returns>
	///   <see langword="false" /> in all cases.</returns>
	bool IList.IsFixedSize => false;

	/// <summary>Gets a value indicating whether the collection is read-only.</summary>
	/// <returns>
	///   <see langword="false" /> in all cases.</returns>
	bool IList.IsReadOnly => false;

	/// <summary>Gets or sets the <see cref="T:System.Windows.Forms.ListViewGroup" /> at the specified index within the collection.</summary>
	/// <param name="index">The zero-based index of the element to get or set.</param>
	/// <returns>A <see cref="T:System.Windows.Forms.ListViewGroup" /> that represents the item located at the specified index within the collection.</returns>
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

	/// <summary>Gets the number of groups in the collection.</summary>
	/// <returns>The number of groups in the collection.</returns>
	public int Count => 0;

	/// <summary>Gets or sets the <see cref="T:System.Windows.Forms.ListViewGroup" /> at the specified index within the collection.</summary>
	/// <param name="index">The index within the collection of the <see cref="T:System.Windows.Forms.ListViewGroup" /> to get or set.</param>
	/// <returns>The <see cref="T:System.Windows.Forms.ListViewGroup" /> at the specified index within the collection.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than 0 or greater than or equal to <see cref="P:System.Windows.Forms.ListViewGroupCollection.Count" />.</exception>
	public ListViewGroup this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal int InternalCount => 0;

	internal ListViewGroup DefaultGroup => null;

	private ListViewGroupCollection()
	{
	}

	internal ListViewGroupCollection(ListView listViewOwner)
	{
	}

	/// <summary>Adds a new <see cref="T:System.Windows.Forms.ListViewGroup" /> to the <see cref="T:System.Windows.Forms.ListViewGroupCollection" />.</summary>
	/// <param name="value">The <see cref="T:System.Windows.Forms.ListViewGroup" /> to add to the <see cref="T:System.Windows.Forms.ListViewGroupCollection" />.</param>
	/// <returns>The index at which the <see cref="T:System.Windows.Forms.ListViewGroup" /> has been added.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="value" /> is not a <see cref="T:System.Windows.Forms.ListViewGroup" />.  
	/// -or-  
	/// <paramref name="value" /> contains at least one <see cref="T:System.Windows.Forms.ListViewItem" /> that belongs to a <see cref="T:System.Windows.Forms.ListView" /> control other than the one that owns this <see cref="T:System.Windows.Forms.ListViewGroupCollection" />.</exception>
	int IList.Add(object value)
	{
		return 0;
	}

	/// <summary>Determines whether the specified value is located in the collection.</summary>
	/// <param name="value">An object that represents the <see cref="T:System.Windows.Forms.ListViewGroup" /> to locate in the collection.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is a <see cref="T:System.Windows.Forms.ListViewGroup" /> contained in the collection; otherwise, <see langword="false" />.</returns>
	bool IList.Contains(object value)
	{
		return false;
	}

	/// <summary>Returns the index within the collection of the specified value.</summary>
	/// <param name="value">The <see cref="T:System.Windows.Forms.ListViewGroup" /> to find in the <see cref="T:System.Windows.Forms.ListViewGroupCollection" />.</param>
	/// <returns>The zero-based index of <paramref name="value" /> if it is in the collection; otherwise, -1.</returns>
	int IList.IndexOf(object value)
	{
		return 0;
	}

	/// <summary>Inserts a <see cref="T:System.Windows.Forms.ListViewGroup" /> into the <see cref="T:System.Windows.Forms.ListViewGroupCollection" />.</summary>
	/// <param name="index">The position at which the <see cref="T:System.Windows.Forms.ListViewGroup" /> is added to the collection.</param>
	/// <param name="value">The <see cref="T:System.Windows.Forms.ListViewGroup" /> to add to the collection.</param>
	void IList.Insert(int index, object value)
	{
	}

	/// <summary>Removes the <see cref="T:System.Windows.Forms.ListViewGroup" /> from the <see cref="T:System.Windows.Forms.ListViewGroupCollection" />.</summary>
	/// <param name="value">The <see cref="T:System.Windows.Forms.ListViewGroup" /> to remove from the <see cref="T:System.Windows.Forms.ListViewGroupCollection" />.</param>
	void IList.Remove(object value)
	{
	}

	/// <summary>Returns an enumerator used to iterate through the collection.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that represents the collection.</returns>
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Copies the groups in the collection to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
	/// <param name="array">The <see cref="T:System.Array" /> to which the groups are copied.</param>
	/// <param name="index">The first index within the array to which the groups are copied.</param>
	public void CopyTo(Array array, int index)
	{
	}

	/// <summary>Adds the specified <see cref="T:System.Windows.Forms.ListViewGroup" /> to the collection.</summary>
	/// <param name="group">The <see cref="T:System.Windows.Forms.ListViewGroup" /> to add to the collection.</param>
	/// <returns>The index of the group within the collection, or -1 if the group is already present in the collection.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="group" /> contains at least one <see cref="T:System.Windows.Forms.ListViewItem" /> that belongs to a <see cref="T:System.Windows.Forms.ListView" /> control other than the one that owns this <see cref="T:System.Windows.Forms.ListViewGroupCollection" />.</exception>
	public int Add(ListViewGroup group)
	{
		return 0;
	}

	/// <summary>Removes all groups from the collection.</summary>
	public void Clear()
	{
	}

	/// <summary>Determines whether the specified group is located in the collection.</summary>
	/// <param name="value">The <see cref="T:System.Windows.Forms.ListViewGroup" /> to locate in the collection.</param>
	/// <returns>
	///   <see langword="true" /> if the group is in the collection; otherwise, <see langword="false" />.</returns>
	public bool Contains(ListViewGroup value)
	{
		return false;
	}

	/// <summary>Returns the index of the specified <see cref="T:System.Windows.Forms.ListViewGroup" /> within the collection.</summary>
	/// <param name="value">The <see cref="T:System.Windows.Forms.ListViewGroup" /> to locate in the collection.</param>
	/// <returns>The zero-based index of the group within the collection, or -1 if the group is not in the collection.</returns>
	public int IndexOf(ListViewGroup value)
	{
		return 0;
	}

	/// <summary>Inserts the specified <see cref="T:System.Windows.Forms.ListViewGroup" /> into the collection at the specified index.</summary>
	/// <param name="index">The index within the collection at which to insert the group.</param>
	/// <param name="group">The <see cref="T:System.Windows.Forms.ListViewGroup" /> to insert into the collection.</param>
	public void Insert(int index, ListViewGroup group)
	{
	}

	/// <summary>Removes the specified <see cref="T:System.Windows.Forms.ListViewGroup" /> from the collection.</summary>
	/// <param name="group">The <see cref="T:System.Windows.Forms.ListViewGroup" /> to remove from the collection.</param>
	public void Remove(ListViewGroup group)
	{
	}

	/// <summary>Removes the <see cref="T:System.Windows.Forms.ListViewGroup" /> at the specified index within the collection.</summary>
	/// <param name="index">The index within the collection of the <see cref="T:System.Windows.Forms.ListViewGroup" /> to remove.</param>
	public void RemoveAt(int index)
	{
	}

	internal ListViewGroup GetInternalGroup(int index)
	{
		return null;
	}

	private void AddGroup(ListViewGroup group)
	{
	}

	private void CheckListViewItemsInGroup(ListViewGroup value)
	{
	}
}
