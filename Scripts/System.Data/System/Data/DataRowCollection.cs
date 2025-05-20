using System.Collections;

namespace System.Data;

/// <summary>Represents a collection of rows for a <see cref="T:System.Data.DataTable" />.</summary>
public sealed class DataRowCollection : InternalDataCollectionBase
{
	private sealed class DataRowTree : RBTree<DataRow>
	{
		internal DataRowTree()
			: base(default(TreeAccessMethod))
		{
		}

		protected override int CompareNode(DataRow record1, DataRow record2)
		{
			return 0;
		}

		protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2)
		{
			return 0;
		}
	}

	private readonly DataTable _table;

	private readonly DataRowTree _list;

	internal int _nullInList;

	/// <summary>Gets the total number of <see cref="T:System.Data.DataRow" /> objects in this collection.</summary>
	/// <returns>The total number of <see cref="T:System.Data.DataRow" /> objects in this collection.</returns>
	public override int Count => 0;

	/// <summary>Gets the row at the specified index.</summary>
	/// <param name="index">The zero-based index of the row to return.</param>
	/// <returns>The specified <see cref="T:System.Data.DataRow" />.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">The index value is greater than the number of items in the collection.</exception>
	public DataRow this[int index] => null;

	internal DataRowCollection(DataTable table)
	{
	}

	/// <summary>Adds the specified <see cref="T:System.Data.DataRow" /> to the <see cref="T:System.Data.DataRowCollection" /> object.</summary>
	/// <param name="row">The <see cref="T:System.Data.DataRow" /> to add.</param>
	/// <exception cref="T:System.ArgumentNullException">The row is null.</exception>
	/// <exception cref="T:System.ArgumentException">The row either belongs to another table or already belongs to this table.</exception>
	/// <exception cref="T:System.Data.ConstraintException">The addition invalidates a constraint.</exception>
	/// <exception cref="T:System.Data.NoNullAllowedException">The addition tries to put a null in a <see cref="T:System.Data.DataColumn" /> where <see cref="P:System.Data.DataColumn.AllowDBNull" /> is false.</exception>
	public void Add(DataRow row)
	{
	}

	internal void DiffInsertAt(DataRow row, int pos)
	{
	}

	/// <summary>Gets the index of the specified <see cref="T:System.Data.DataRow" /> object.</summary>
	/// <param name="row">The <see langword="DataRow" /> to search for.</param>
	/// <returns>The zero-based index of the row, or -1 if the row is not found in the collection.</returns>
	public int IndexOf(DataRow row)
	{
		return 0;
	}

	internal DataRow AddWithColumnEvents(params object[] values)
	{
		return null;
	}

	internal void ArrayAdd(DataRow row)
	{
	}

	internal void ArrayInsert(DataRow row, int pos)
	{
	}

	internal void ArrayClear()
	{
	}

	internal void ArrayRemove(DataRow row)
	{
	}

	/// <summary>Copies all the <see cref="T:System.Data.DataRow" /> objects from the collection into the given array, starting at the given destination array index.</summary>
	/// <param name="ar">The one-dimensional array that is the destination of the elements copied from the <see langword="DataRowCollection" />. The array must have zero-based indexing.</param>
	/// <param name="index">The zero-based index in the array at which copying begins.</param>
	public override void CopyTo(Array ar, int index)
	{
	}

	/// <summary>Copies all the <see cref="T:System.Data.DataRow" /> objects from the collection into the given array, starting at the given destination array index.</summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from the <see langword="DataRowCollection" />. The array must have zero-based indexing.</param>
	/// <param name="index">The zero-based index in the array at which copying begins.</param>
	public void CopyTo(DataRow[] array, int index)
	{
	}

	/// <summary>Gets an <see cref="T:System.Collections.IEnumerator" /> for this collection.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for this collection.</returns>
	public override IEnumerator GetEnumerator()
	{
		return null;
	}
}
