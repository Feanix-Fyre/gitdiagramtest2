using System.Collections;

namespace System.Windows.Forms.Layout;

/// <summary>Represents a collection of objects.</summary>
public class ArrangedElementCollection : ICollection, IEnumerable, IList
{
	internal ArrayList list;

	/// <summary>For a description of this member, see the <see cref="P:System.Collections.IList.IsFixedSize" /> property.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.IList" /> has a fixed size; otherwise, <see langword="false" />.</returns>
	bool IList.IsFixedSize => false;

	/// <summary>For a description of this member, see the <see cref="P:System.Collections.IList.Item(System.Int32)" /> property.</summary>
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

	/// <summary>For a description of this member, see the <see cref="P:System.Collections.ICollection.IsSynchronized" /> property.</summary>
	/// <returns>
	///   <see langword="true" /> if access to the <see cref="T:System.Windows.Forms.Layout.ArrangedElementCollection" /> is synchronized (thread safe); otherwise, <see langword="false" />.</returns>
	bool ICollection.IsSynchronized => false;

	/// <summary>For a description of this member, see the <see cref="P:System.Collections.ICollection.SyncRoot" /> property.</summary>
	/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Windows.Forms.Layout.ArrangedElementCollection" />.</returns>
	object ICollection.SyncRoot => null;

	/// <summary>Gets the number of elements in the collection.</summary>
	/// <returns>The number of elements currently contained in the collection.</returns>
	public virtual int Count => 0;

	/// <summary>Gets a value indicating whether the collection is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the collection is read-only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public virtual bool IsReadOnly => false;

	internal bool IsFixedSize => false;

	internal object this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal ArrangedElementCollection()
	{
	}

	/// <summary>For a description of this member, see the <see cref="M:System.Collections.IList.Add(System.Object)" /> method.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to add to the <see cref="T:System.Collections.IList" />.</param>
	/// <returns>The position into which the new element was inserted.</returns>
	int IList.Add(object value)
	{
		return 0;
	}

	/// <summary>For a description of this member, see the <see cref="M:System.Collections.IList.Clear" /> method.</summary>
	void IList.Clear()
	{
	}

	/// <summary>For a description of this member, see the <see cref="M:System.Collections.IList.Contains(System.Object)" /> method.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.IList" />.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Object" /> is found in the <see cref="T:System.Collections.IList" />; otherwise, <see langword="false" />.</returns>
	bool IList.Contains(object value)
	{
		return false;
	}

	/// <summary>For a description of this member, see the <see cref="M:System.Collections.IList.IndexOf(System.Object)" /> method.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.IList" />.</param>
	/// <returns>The index of <paramref name="value" /> if found in the list; otherwise, -1.</returns>
	int IList.IndexOf(object value)
	{
		return 0;
	}

	/// <summary>For a description of this member, see the <see cref="M:System.Collections.IList.Insert(System.Int32,System.Object)" /> method.</summary>
	/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to insert into the <see cref="T:System.Collections.IList" />.</param>
	void IList.Insert(int index, object value)
	{
	}

	/// <summary>For a description of this member, see the <see cref="M:System.Collections.IList.Remove(System.Object)" /> method.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to remove from the <see cref="T:System.Collections.IList" />.</param>
	void IList.Remove(object value)
	{
	}

	/// <summary>For a description of this member, see the <see cref="M:System.Collections.IList.RemoveAt(System.Int32)" /> method.</summary>
	/// <param name="index">The zero-based index of the item to remove.</param>
	void IList.RemoveAt(int index)
	{
	}

	/// <summary>Copies the entire contents of this collection to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from the current collection. The array must have zero-based indexing.</param>
	/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than 0.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional.  
	/// -or-  
	/// The number of elements in the source collection is greater than the available space from <paramref name="index" /> to the end of <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The type of the source element cannot be cast automatically to the type of <paramref name="array" />.</exception>
	public void CopyTo(Array array, int index)
	{
	}

	/// <summary>Determines whether two <see cref="T:System.Windows.Forms.Layout.ArrangedElementCollection" /> instances are equal.</summary>
	/// <param name="obj">The <see cref="T:System.Windows.Forms.Layout.ArrangedElementCollection" /> to compare with the current <see cref="T:System.Windows.Forms.Layout.ArrangedElementCollection" />.</param>
	/// <returns>
	///   <see langword="true" /> if the specified <see cref="T:System.Windows.Forms.Layout.ArrangedElementCollection" /> is equal to the current <see cref="T:System.Windows.Forms.Layout.ArrangedElementCollection" />; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns an enumerator for the entire collection.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the entire collection.</returns>
	public virtual IEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A hash code for the current <see cref="T:System.Windows.Forms.Layout.ArrangedElementCollection" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	internal int Add(object value)
	{
		return 0;
	}

	internal void Clear()
	{
	}

	internal bool Contains(object value)
	{
		return false;
	}

	internal int IndexOf(object value)
	{
		return 0;
	}

	internal void Insert(int index, object value)
	{
	}

	internal void Remove(object value)
	{
	}
}
