using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace System.Data;

/// <summary>Represents the collection of tables for the <see cref="T:System.Data.DataSet" />.</summary>
[DefaultEvent("CollectionChanged")]
[ListBindable(false)]
public sealed class DataTableCollection : InternalDataCollectionBase
{
	private readonly DataSet _dataSet;

	private readonly ArrayList _list;

	private int _defaultNameIndex;

	private DataTable[] _delayedAddRangeTables;

	private CollectionChangeEventHandler _onCollectionChangedDelegate;

	private CollectionChangeEventHandler _onCollectionChangingDelegate;

	private static int s_objectTypeCount;

	private readonly int _objectID;

	protected override ArrayList List => null;

	internal int ObjectID => 0;

	/// <summary>Gets the <see cref="T:System.Data.DataTable" /> object at the specified index.</summary>
	/// <param name="index">The zero-based index of the <see cref="T:System.Data.DataTable" /> to find.</param>
	/// <returns>A <see cref="T:System.Data.DataTable" /> with the specified index; otherwise <see langword="null" /> if the <see cref="T:System.Data.DataTable" /> does not exist.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">The index value is greater than the number of items in the collection.</exception>
	public DataTable this[int index] => null;

	/// <summary>Gets the <see cref="T:System.Data.DataTable" /> object with the specified name.</summary>
	/// <param name="name">The name of the <see langword="DataTable" /> to find.</param>
	/// <returns>A <see cref="T:System.Data.DataTable" /> with the specified name; otherwise <see langword="null" /> if the <see cref="T:System.Data.DataTable" /> does not exist.</returns>
	public DataTable this[string name] => null;

	/// <summary>Gets the <see cref="T:System.Data.DataTable" /> object with the specified name in the specified namespace.</summary>
	/// <param name="name">The name of the <see langword="DataTable" /> to find.</param>
	/// <param name="tableNamespace">The name of the <see cref="T:System.Data.DataTable" /> namespace to look in.</param>
	/// <returns>A <see cref="T:System.Data.DataTable" /> with the specified name; otherwise <see langword="null" /> if the <see cref="T:System.Data.DataTable" /> does not exist.</returns>
	public DataTable this[string name, string tableNamespace] => null;

	/// <summary>Occurs after the <see cref="T:System.Data.DataTableCollection" /> is changed because of <see cref="T:System.Data.DataTable" /> objects being added or removed.</summary>
	public event CollectionChangeEventHandler CollectionChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	internal DataTableCollection(DataSet dataSet)
	{
	}

	internal DataTable GetTable(string name, string ns)
	{
		return null;
	}

	internal DataTable GetTableSmart(string name, string ns)
	{
		return null;
	}

	/// <summary>Adds the specified <see langword="DataTable" /> to the collection.</summary>
	/// <param name="table">The <see langword="DataTable" /> object to add.</param>
	/// <exception cref="T:System.ArgumentNullException">The value specified for the table is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The table already belongs to this collection, or belongs to another collection.</exception>
	/// <exception cref="T:System.Data.DuplicateNameException">A table in the collection has the same name. The comparison is not case sensitive.</exception>
	public void Add(DataTable table)
	{
	}

	private void ArrayAdd(DataTable table)
	{
	}

	internal string AssignName()
	{
		return null;
	}

	private void BaseAdd(DataTable table)
	{
	}

	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength)
	{
	}

	private void BaseRemove(DataTable table)
	{
	}

	internal bool CanRemove(DataTable table, bool fThrowException)
	{
		return false;
	}

	/// <summary>Clears the collection of all <see cref="T:System.Data.DataTable" /> objects.</summary>
	public void Clear()
	{
	}

	/// <summary>Gets a value that indicates whether a <see cref="T:System.Data.DataTable" /> object with the specified name exists in the collection.</summary>
	/// <param name="name">The name of the <see cref="T:System.Data.DataTable" /> to find.</param>
	/// <returns>
	///   <see langword="true" /> if the specified table exists; otherwise <see langword="false" />.</returns>
	public bool Contains(string name)
	{
		return false;
	}

	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive)
	{
		return false;
	}

	internal bool Contains(string name, bool caseSensitive)
	{
		return false;
	}

	/// <summary>Gets the index of the specified <see cref="T:System.Data.DataTable" /> object.</summary>
	/// <param name="table">The <see langword="DataTable" /> to search for.</param>
	/// <returns>The zero-based index of the table, or -1 if the table is not found in the collection.</returns>
	public int IndexOf(DataTable table)
	{
		return 0;
	}

	/// <summary>Gets the index in the collection of the <see cref="T:System.Data.DataTable" /> object with the specified name.</summary>
	/// <param name="tableName">The name of the <see langword="DataTable" /> object to look for.</param>
	/// <returns>The zero-based index of the <see langword="DataTable" /> with the specified name, or -1 if the table does not exist in the collection.  
	///
	///  Returns -1 when two or more tables have the same name but different namespaces. The call does not succeed if there is any ambiguity when matching a table name to exactly one table.</returns>
	public int IndexOf(string tableName)
	{
		return 0;
	}

	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull)
	{
		return 0;
	}

	internal void ReplaceFromInference(List<DataTable> tableList)
	{
	}

	internal int InternalIndexOf(string tableName)
	{
		return 0;
	}

	internal int InternalIndexOf(string tableName, string tableNamespace)
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

	internal void RegisterName(string name, string tbNamespace)
	{
	}

	/// <summary>Removes the specified <see cref="T:System.Data.DataTable" /> object from the collection.</summary>
	/// <param name="table">The <see langword="DataTable" /> to remove.</param>
	/// <exception cref="T:System.ArgumentNullException">The value specified for the table is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The table does not belong to this collection.  
	///  -or-  
	///  The table is part of a relationship.</exception>
	public void Remove(DataTable table)
	{
	}

	internal void UnregisterName(string name)
	{
	}
}
