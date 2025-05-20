using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;

namespace System.Windows.Forms;

/// <summary>Represents a collection of <see cref="T:System.Windows.Forms.TreeNode" /> objects.</summary>
[Editor("System.Windows.Forms.Design.TreeNodeCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
public class TreeNodeCollection : ICollection, IEnumerable, IList
{
	internal class TreeNodeEnumerator : IEnumerator
	{
		private TreeNodeCollection collection;

		private int index;

		public object Current => null;

		public TreeNodeEnumerator(TreeNodeCollection collection)
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

	private static readonly int OrigSize;

	private TreeNode owner;

	private int count;

	private TreeNode[] nodes;

	/// <summary>Gets a value indicating whether access to the collection is synchronized (thread safe).</summary>
	/// <returns>
	///   <see langword="false" /> in all cases.</returns>
	bool ICollection.IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
	/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Windows.Forms.TreeNodeCollection" />.</returns>
	object ICollection.SyncRoot => null;

	/// <summary>Gets a value indicating whether the tree node collection has a fixed size.</summary>
	/// <returns>
	///   <see langword="false" /> in all cases.</returns>
	bool IList.IsFixedSize => false;

	/// <summary>Gets or sets the tree node at the specified index in the collection.</summary>
	/// <param name="index">The zero-based index at which to get or set the item.</param>
	/// <returns>The <see cref="T:System.Windows.Forms.TreeNode" /> at the specified index in the <see cref="T:System.Windows.Forms.TreeNodeCollection" />.</returns>
	/// <exception cref="T:System.ArgumentException">The value set is not a <see cref="T:System.Windows.Forms.TreeNode" />.</exception>
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

	/// <summary>Gets the total number of <see cref="T:System.Windows.Forms.TreeNode" /> objects in the collection.</summary>
	/// <returns>The total number of <see cref="T:System.Windows.Forms.TreeNode" /> objects in the collection.</returns>
	[Browsable(false)]
	public int Count => 0;

	/// <summary>Gets a value indicating whether the collection is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the collection is read-only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool IsReadOnly => false;

	/// <summary>Gets or sets the <see cref="T:System.Windows.Forms.TreeNode" /> at the specified indexed location in the collection.</summary>
	/// <param name="index">The indexed location of the <see cref="T:System.Windows.Forms.TreeNode" /> in the collection.</param>
	/// <returns>The <see cref="T:System.Windows.Forms.TreeNode" /> at the specified indexed location in the collection.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> value is less than 0 or is greater than the number of tree nodes in the collection.</exception>
	public virtual TreeNode this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal TreeNodeCollection(TreeNode owner)
	{
	}

	/// <summary>Adds an object to the end of the tree node collection.</summary>
	/// <param name="node">The object to add to the tree node collection.</param>
	/// <returns>The zero-based index value of the <see cref="T:System.Windows.Forms.TreeNode" /> that was added to the tree node collection.</returns>
	/// <exception cref="T:System.Exception">
	///   <paramref name="node" /> is currently assigned to another <see cref="T:System.Windows.Forms.TreeView" /> control.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="node" /> is <see langword="null" />.</exception>
	int IList.Add(object node)
	{
		return 0;
	}

	/// <summary>Determines whether the specified tree node is a member of the collection.</summary>
	/// <param name="node">The object to find in the collection.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="node" /> is a member of the collection; otherwise, <see langword="false" />.</returns>
	bool IList.Contains(object node)
	{
		return false;
	}

	/// <summary>Returns the index of the specified tree node in the collection.</summary>
	/// <param name="node">The <see cref="T:System.Windows.Forms.TreeNode" /> to locate in the collection.</param>
	/// <returns>The zero-based index of the item found in the tree node collection; otherwise, -1.</returns>
	int IList.IndexOf(object node)
	{
		return 0;
	}

	/// <summary>Inserts an existing tree node in the tree node collection at the specified location.</summary>
	/// <param name="index">The indexed location within the collection to insert the tree node.</param>
	/// <param name="node">The <see cref="T:System.Windows.Forms.TreeNode" /> to insert into the collection.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="node" /> is currently assigned to another <see cref="T:System.Windows.Forms.TreeView" />.  
	/// -or-  
	/// <paramref name="node" /> is not a <see cref="T:System.Windows.Forms.TreeNode" />.</exception>
	void IList.Insert(int index, object node)
	{
	}

	/// <summary>Removes the specified tree node from the tree node collection.</summary>
	/// <param name="node">The <see cref="T:System.Windows.Forms.TreeNode" /> to remove from the collection.</param>
	void IList.Remove(object node)
	{
	}

	/// <summary>Adds a previously created tree node to the end of the tree node collection.</summary>
	/// <param name="node">The <see cref="T:System.Windows.Forms.TreeNode" /> to add to the collection.</param>
	/// <returns>The zero-based index value of the <see cref="T:System.Windows.Forms.TreeNode" /> added to the tree node collection.</returns>
	/// <exception cref="T:System.ArgumentException">The <paramref name="node" /> is currently assigned to another <see cref="T:System.Windows.Forms.TreeView" />.</exception>
	public virtual int Add(TreeNode node)
	{
		return 0;
	}

	/// <summary>Removes all tree nodes from the collection.</summary>
	public virtual void Clear()
	{
	}

	/// <summary>Determines whether the specified tree node is a member of the collection.</summary>
	/// <param name="node">The <see cref="T:System.Windows.Forms.TreeNode" /> to locate in the collection.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.TreeNode" /> is a member of the collection; otherwise, <see langword="false" />.</returns>
	public bool Contains(TreeNode node)
	{
		return false;
	}

	/// <summary>Copies the entire collection into an existing array at a specified location within the array.</summary>
	/// <param name="dest">The destination array.</param>
	/// <param name="index">The index in the destination array at which storing begins.</param>
	public void CopyTo(Array dest, int index)
	{
	}

	/// <summary>Returns an enumerator that can be used to iterate through the tree node collection.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that represents the tree node collection.</returns>
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns the index of the specified tree node in the collection.</summary>
	/// <param name="node">The <see cref="T:System.Windows.Forms.TreeNode" /> to locate in the collection.</param>
	/// <returns>The zero-based index of the item found in the tree node collection; otherwise, -1.</returns>
	public int IndexOf(TreeNode node)
	{
		return 0;
	}

	/// <summary>Inserts an existing tree node into the tree node collection at the specified location.</summary>
	/// <param name="index">The indexed location within the collection to insert the tree node.</param>
	/// <param name="node">The <see cref="T:System.Windows.Forms.TreeNode" /> to insert into the collection.</param>
	/// <exception cref="T:System.ArgumentException">The <paramref name="node" /> is currently assigned to another <see cref="T:System.Windows.Forms.TreeView" />.</exception>
	public virtual void Insert(int index, TreeNode node)
	{
	}

	/// <summary>Removes the specified tree node from the tree node collection.</summary>
	/// <param name="node">The <see cref="T:System.Windows.Forms.TreeNode" /> to remove.</param>
	public void Remove(TreeNode node)
	{
	}

	/// <summary>Removes a tree node from the tree node collection at a specified index.</summary>
	/// <param name="index">The index of the <see cref="T:System.Windows.Forms.TreeNode" /> to remove.</param>
	public virtual void RemoveAt(int index)
	{
	}

	private void RemoveAt(int index, bool update)
	{
	}

	private TreeNode GetPrevNode(TreeNode node)
	{
		return null;
	}

	private void SetupNode(TreeNode node)
	{
	}

	private int AddSorted(TreeNode node)
	{
		return 0;
	}

	private void Grow()
	{
	}

	private void Shrink()
	{
	}
}
