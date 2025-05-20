using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Data;

/// <summary>Represents a collection of <see cref="T:System.Data.DataColumn" /> objects for a <see cref="T:System.Data.DataTable" />.</summary>
[DefaultEvent("CollectionChanged")]
public sealed class DataColumnCollection : InternalDataCollectionBase
{
	private readonly DataTable _table;

	private readonly ArrayList _list;

	private int _defaultNameIndex;

	private DataColumn[] _delayedAddRangeColumns;

	private readonly Dictionary<string, DataColumn> _columnFromName;

	private bool _fInClear;

	private DataColumn[] _columnsImplementingIChangeTracking;

	private int _nColumnsImplementingIChangeTracking;

	private int _nColumnsImplementingIRevertibleChangeTracking;

	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanging;

	protected override ArrayList List => null;

	internal DataColumn[] ColumnsImplementingIChangeTracking => null;

	internal int ColumnsImplementingIChangeTrackingCount => 0;

	internal int ColumnsImplementingIRevertibleChangeTrackingCount => 0;

	/// <summary>Gets the <see cref="T:System.Data.DataColumn" /> from the collection at the specified index.</summary>
	/// <param name="index">The zero-based index of the column to return.</param>
	/// <returns>The <see cref="T:System.Data.DataColumn" /> at the specified index.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">The index value is greater than the number of items in the collection.</exception>
	public DataColumn this[int index] => null;

	/// <summary>Gets the <see cref="T:System.Data.DataColumn" /> from the collection with the specified name.</summary>
	/// <param name="name">The <see cref="P:System.Data.DataColumn.ColumnName" /> of the column to return.</param>
	/// <returns>The <see cref="T:System.Data.DataColumn" /> in the collection with the specified <see cref="P:System.Data.DataColumn.ColumnName" />; otherwise a null value if the <see cref="T:System.Data.DataColumn" /> does not exist.</returns>
	public DataColumn this[string name] => null;

	internal DataColumn this[string name, string ns] => null;

	/// <summary>Occurs when the columns collection changes, either by adding or removing a column.</summary>
	public event CollectionChangeEventHandler CollectionChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	internal event CollectionChangeEventHandler ColumnPropertyChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	internal DataColumnCollection(DataTable table)
	{
	}

	/// <summary>Creates and adds the specified <see cref="T:System.Data.DataColumn" /> object to the <see cref="T:System.Data.DataColumnCollection" />.</summary>
	/// <param name="column">The <see cref="T:System.Data.DataColumn" /> to add.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="column" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The column already belongs to this collection, or to another collection.</exception>
	/// <exception cref="T:System.Data.DuplicateNameException">The collection already has a column with the specified name. (The comparison is not case-sensitive.)</exception>
	/// <exception cref="T:System.Data.InvalidExpressionException">The expression is invalid. See the <see cref="P:System.Data.DataColumn.Expression" /> property for more information about how to create expressions.</exception>
	public void Add(DataColumn column)
	{
	}

	internal void AddAt(int index, DataColumn column)
	{
	}

	private void ArrayAdd(DataColumn column)
	{
	}

	private void ArrayAdd(int index, DataColumn column)
	{
	}

	private void ArrayRemove(DataColumn column)
	{
	}

	internal string AssignName()
	{
		return null;
	}

	private void BaseAdd(DataColumn column)
	{
	}

	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength)
	{
	}

	private void BaseRemove(DataColumn column)
	{
	}

	internal bool CanRemove(DataColumn column, bool fThrowException)
	{
		return false;
	}

	private void CheckIChangeTracking(DataColumn column)
	{
	}

	/// <summary>Clears the collection of any columns.</summary>
	public void Clear()
	{
	}

	/// <summary>Checks whether the collection contains a column with the specified name.</summary>
	/// <param name="name">The <see cref="P:System.Data.DataColumn.ColumnName" /> of the column to look for.</param>
	/// <returns>
	///   <see langword="true" /> if a column exists with this name; otherwise, <see langword="false" />.</returns>
	public bool Contains(string name)
	{
		return false;
	}

	internal bool Contains(string name, bool caseSensitive)
	{
		return false;
	}

	/// <summary>Gets the index of the column with the specific name (the name is not case sensitive).</summary>
	/// <param name="columnName">The name of the column to find.</param>
	/// <returns>The zero-based index of the column with the specified name, or -1 if the column does not exist in the collection.</returns>
	public int IndexOf(string columnName)
	{
		return 0;
	}

	internal int IndexOfCaseInsensitive(string name)
	{
		return 0;
	}

	private string MakeName(int index)
	{
		return null;
	}

	private void OnCollectionChanged(CollectionChangeEventArgs ccevent)
	{
	}

	private void OnCollectionChanging(CollectionChangeEventArgs ccevent)
	{
	}

	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent)
	{
	}

	internal void RegisterColumnName(string name, DataColumn column)
	{
	}

	internal bool CanRegisterName(string name)
	{
		return false;
	}

	/// <summary>Removes the specified <see cref="T:System.Data.DataColumn" /> object from the collection.</summary>
	/// <param name="column">The <see cref="T:System.Data.DataColumn" /> to remove.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="column" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The column does not belong to this collection.  
	///  -Or-  
	///  The column is part of a relationship.  
	///  -Or-  
	///  Another column's expression depends on this column.</exception>
	public void Remove(DataColumn column)
	{
	}

	internal void UnregisterName(string name)
	{
	}

	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn)
	{
	}

	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn)
	{
	}
}
