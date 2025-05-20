using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms.Layout;

namespace System.Windows.Forms;

/// <summary>Represents a collection of <see cref="T:System.Windows.Forms.ToolStripItem" /> objects.</summary>
[Editor("System.Windows.Forms.Design.ToolStripCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
[ListBindable(false)]
public class ToolStripItemCollection : ArrangedElementCollection, ICollection, IEnumerable, IList
{
	private ToolStrip owner;

	private bool internal_created;

	/// <summary>Gets a value indicating whether the collection has a fixed size.</summary>
	/// <returns>
	///   <see langword="true" /> if the collection has a fixed size; otherwise, <see langword="false" />.</returns>
	bool IList.IsFixedSize => false;

	/// <summary>Retrieves the element at the specified index.</summary>
	/// <param name="index">The zero-based index of the item to get.</param>
	/// <returns>The <see cref="T:System.Windows.Forms.ToolStripItem" /> at the specified index.</returns>
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

	/// <summary>Gets a value indicating whether the <see cref="T:System.Windows.Forms.ToolStripItemCollection" /> is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolStripItemCollection" /> is read-only; otherwise, <see langword="false" />.</returns>
	public override bool IsReadOnly => false;

	/// <summary>Gets the item at the specified index.</summary>
	/// <param name="index">The zero-based index of the item to get.</param>
	/// <returns>The <see cref="T:System.Windows.Forms.ToolStripItem" /> located at the specified position in the <see cref="T:System.Windows.Forms.ToolStripItemCollection" />.</returns>
	public new virtual ToolStripItem this[int index] => null;

	internal ToolStripItemCollection(ToolStrip owner, ToolStripItem[] value, bool internalcreated)
	{
	}

	/// <summary>Adds an item to the collection.</summary>
	/// <param name="value">The item to add to the collection.</param>
	/// <returns>The location at which <paramref name="value" /> was inserted.</returns>
	int IList.Add(object value)
	{
		return 0;
	}

	/// <summary>Removes all items from the collection.</summary>
	void IList.Clear()
	{
	}

	/// <summary>Determines if the collection contains a specified item.</summary>
	/// <param name="value">The item to locate in the collection.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is contained in the collection; otherwise, <see langword="false" />.</returns>
	bool IList.Contains(object value)
	{
		return false;
	}

	/// <summary>Determines the location of a specified item in the collection.</summary>
	/// <param name="value">The item to locate in the collection.</param>
	/// <returns>The index of the item in the collection, if found; otherwise, -1.</returns>
	int IList.IndexOf(object value)
	{
		return 0;
	}

	/// <summary>Inserts an item into the collection at a specified index.</summary>
	/// <param name="index">The zero-based index at which to insert <paramref name="value" />.</param>
	/// <param name="value">The item to insert into the collection.</param>
	void IList.Insert(int index, object value)
	{
	}

	/// <summary>Removes the first occurrence of a specified item from the collection.</summary>
	/// <param name="value">The item to remove from the collection.</param>
	void IList.Remove(object value)
	{
	}

	/// <summary>Removes an item from the collection at a specified index.</summary>
	/// <param name="index">The zero-based index of the item to remove.</param>
	void IList.RemoveAt(int index)
	{
	}

	/// <summary>Adds a <see cref="T:System.Windows.Forms.ToolStripItem" /> that displays the specified text to the collection.</summary>
	/// <param name="text">The text to be displayed on the <see cref="T:System.Windows.Forms.ToolStripItem" />.</param>
	/// <returns>The new <see cref="T:System.Windows.Forms.ToolStripItem" />.</returns>
	public ToolStripItem Add(string text)
	{
		return null;
	}

	/// <summary>Adds the specified item to the end of the collection.</summary>
	/// <param name="value">The <see cref="T:System.Windows.Forms.ToolStripItem" /> to add to the end of the collection.</param>
	/// <returns>An <see cref="T:System.Int32" /> representing the zero-based index of the new item in the collection.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />.</exception>
	public int Add(ToolStripItem value)
	{
		return 0;
	}

	/// <summary>Adds a <see cref="T:System.Windows.Forms.ToolStripItem" /> that displays the specified image and text to the collection and that raises the <see cref="E:System.Windows.Forms.ToolStripItem.Click" /> event.</summary>
	/// <param name="text">The text to be displayed on the <see cref="T:System.Windows.Forms.ToolStripItem" />.</param>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> to be displayed on the <see cref="T:System.Windows.Forms.ToolStripItem" />.</param>
	/// <param name="onClick">Raises the <see cref="E:System.Windows.Forms.ToolStripItem.Click" /> event.</param>
	/// <returns>The new <see cref="T:System.Windows.Forms.ToolStripItem" />.</returns>
	public ToolStripItem Add(string text, Image image, EventHandler onClick)
	{
		return null;
	}

	/// <summary>Removes all items from the collection.</summary>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Windows.Forms.ToolStripItemCollection" /> is read-only.</exception>
	public new virtual void Clear()
	{
	}

	/// <summary>Determines whether the specified item is a member of the collection.</summary>
	/// <param name="value">The <see cref="T:System.Windows.Forms.ToolStripItem" /> to search for in the <see cref="T:System.Windows.Forms.ToolStripItemCollection" />.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolStripItem" /> is a member of the current <see cref="T:System.Windows.Forms.ToolStripItemCollection" />; otherwise, <see langword="false" />.</returns>
	public bool Contains(ToolStripItem value)
	{
		return false;
	}

	/// <summary>Copies the collection into the specified position of the specified <see cref="T:System.Windows.Forms.ToolStripItem" /> array.</summary>
	/// <param name="array">The array of type <see cref="T:System.Windows.Forms.ToolStripItem" /> to which to copy the collection.</param>
	/// <param name="index">The position in the <see cref="T:System.Windows.Forms.ToolStripItem" /> array at which to paste the collection.</param>
	public void CopyTo(ToolStripItem[] array, int index)
	{
	}

	/// <summary>Retrieves the index of the specified item in the collection.</summary>
	/// <param name="value">The <see cref="T:System.Windows.Forms.ToolStripItem" /> to locate in the <see cref="T:System.Windows.Forms.ToolStripItemCollection" />.</param>
	/// <returns>A zero-based index value that represents the position of the specified <see cref="T:System.Windows.Forms.ToolStripItem" /> in the <see cref="T:System.Windows.Forms.ToolStripItemCollection" />, if found; otherwise, -1.</returns>
	public int IndexOf(ToolStripItem value)
	{
		return 0;
	}

	/// <summary>Inserts the specified item into the collection at the specified index.</summary>
	/// <param name="index">The location in the <see cref="T:System.Windows.Forms.ToolStripItemCollection" /> at which to insert the <see cref="T:System.Windows.Forms.ToolStripItem" />.</param>
	/// <param name="value">The <see cref="T:System.Windows.Forms.ToolStripItem" /> to insert.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />.</exception>
	public void Insert(int index, ToolStripItem value)
	{
	}

	/// <summary>Removes the specified item from the collection.</summary>
	/// <param name="value">The <see cref="T:System.Windows.Forms.ToolStripItem" /> to remove from the <see cref="T:System.Windows.Forms.ToolStripItemCollection" />.</param>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Windows.Forms.ToolStripItemCollection" /> is read-only.</exception>
	public void Remove(ToolStripItem value)
	{
	}

	/// <summary>Removes an item from the specified index in the collection.</summary>
	/// <param name="index">The index value of the <see cref="T:System.Windows.Forms.ToolStripItem" /> to remove.</param>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Windows.Forms.ToolStripItemCollection" /> is read-only.</exception>
	public void RemoveAt(int index)
	{
	}

	internal int AddNoOwnerOrLayout(ToolStripItem value)
	{
		return 0;
	}

	internal void InsertNoOwnerOrLayout(int index, ToolStripItem value)
	{
	}

	internal void RemoveNoOwnerOrLayout(ToolStripItem value)
	{
	}
}
