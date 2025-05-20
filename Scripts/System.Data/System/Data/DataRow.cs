using System.Collections;
using System.ComponentModel;

namespace System.Data;

/// <summary>Represents a row of data in a <see cref="T:System.Data.DataTable" />.</summary>
public class DataRow
{
	private readonly DataTable _table;

	private readonly DataColumnCollection _columns;

	internal int _oldRecord;

	internal int _newRecord;

	internal int _tempRecord;

	internal long _rowID;

	internal DataRowAction _action;

	internal bool _inChangingEvent;

	internal bool _inDeletingEvent;

	internal bool _inCascade;

	private DataColumn _lastChangedColumn;

	private int _countColumnChange;

	private DataError _error;

	private int _rbTreeNodeId;

	private static int s_objectTypeCount;

	internal readonly int _objectID;

	internal DataColumn LastChangedColumn
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool HasPropertyChanged => false;

	internal int RBTreeNodeId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the custom error description for a row.</summary>
	/// <returns>The text describing an error.</returns>
	public string RowError
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal long rowID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	/// <summary>Gets the current state of the row with regard to its relationship to the <see cref="T:System.Data.DataRowCollection" />.</summary>
	/// <returns>One of the <see cref="T:System.Data.DataRowState" /> values.</returns>
	public DataRowState RowState => default(DataRowState);

	/// <summary>Gets the <see cref="T:System.Data.DataTable" /> for which this row has a schema.</summary>
	/// <returns>The <see cref="T:System.Data.DataTable" /> to which this row belongs.</returns>
	public DataTable Table => null;

	/// <summary>Gets or sets the data stored in the column specified by name.</summary>
	/// <param name="columnName">The name of the column.</param>
	/// <returns>An <see cref="T:System.Object" /> that contains the data.</returns>
	/// <exception cref="T:System.ArgumentException">The column specified by <paramref name="columnName" /> cannot be found.</exception>
	/// <exception cref="T:System.Data.DeletedRowInaccessibleException">Occurs when you try to set a value on a deleted row.</exception>
	/// <exception cref="T:System.InvalidCastException">Occurs when you set a value and its <see cref="T:System.Type" /> does not match <see cref="P:System.Data.DataColumn.DataType" />.</exception>
	/// <exception cref="T:System.Data.NoNullAllowedException">Occurs when you try to insert a null value into a column where <see cref="P:System.Data.DataColumn.AllowDBNull" /> is set to <see langword="false" />.</exception>
	public string this[string columnName]
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the data stored in the specified <see cref="T:System.Data.DataColumn" />.</summary>
	/// <param name="column">A <see cref="T:System.Data.DataColumn" /> that contains the data.</param>
	/// <returns>An <see cref="T:System.Object" /> that contains the data.</returns>
	/// <exception cref="T:System.ArgumentException">The column does not belong to this table.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="column" /> is null.</exception>
	/// <exception cref="T:System.Data.DeletedRowInaccessibleException">An attempt was made to set a value on a deleted row.</exception>
	/// <exception cref="T:System.InvalidCastException">The data types of the value and the column do not match.</exception>
	public object this[DataColumn column]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the specified version of data stored in the specified <see cref="T:System.Data.DataColumn" />.</summary>
	/// <param name="column">A <see cref="T:System.Data.DataColumn" /> that contains information about the column.</param>
	/// <param name="version">One of the <see cref="T:System.Data.DataRowVersion" /> values that specifies the row version that you want. Possible values are <see langword="Default" />, <see langword="Original" />, <see langword="Current" />, and <see langword="Proposed" />.</param>
	/// <returns>An <see cref="T:System.Object" /> that contains the data.</returns>
	/// <exception cref="T:System.ArgumentException">The column does not belong to the table.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="column" /> argument contains null.</exception>
	/// <exception cref="T:System.Data.VersionNotFoundException">The row does not have this version of data.</exception>
	public object this[DataColumn column, DataRowVersion version] => null;

	/// <summary>Gets or sets all the values for this row through an array.</summary>
	/// <returns>An array of type <see cref="T:System.Object" />.</returns>
	/// <exception cref="T:System.ArgumentException">The array is larger than the number of columns in the table.</exception>
	/// <exception cref="T:System.InvalidCastException">A value in the array does not match its <see cref="P:System.Data.DataColumn.DataType" /> in its respective <see cref="T:System.Data.DataColumn" />.</exception>
	/// <exception cref="T:System.Data.ConstraintException">An edit broke a constraint.</exception>
	/// <exception cref="T:System.Data.ReadOnlyException">An edit tried to change the value of a read-only column.</exception>
	/// <exception cref="T:System.Data.NoNullAllowedException">An edit tried to put a null value in a column where <see cref="P:System.Data.DataColumn.AllowDBNull" /> of the <see cref="T:System.Data.DataColumn" /> object is <see langword="false" />.</exception>
	/// <exception cref="T:System.Data.DeletedRowInaccessibleException">The row has been deleted.</exception>
	public object[] ItemArray
	{
		set
		{
		}
	}

	/// <summary>Gets a value that indicates whether there are errors in a row.</summary>
	/// <returns>
	///   <see langword="true" /> if the row contains an error; otherwise, <see langword="false" />.</returns>
	public bool HasErrors => false;

	/// <summary>Initializes a new instance of the DataRow. Constructs a row from the builder. Only for internal usage.</summary>
	/// <param name="builder">builder</param>
	protected internal DataRow(DataRowBuilder builder)
	{
	}

	private void RowErrorChanged()
	{
	}

	internal void CheckForLoops(DataRelation rel)
	{
	}

	internal int GetNestedParentCount()
	{
		return 0;
	}

	/// <summary>Commits all the changes made to this row since the last time <see cref="M:System.Data.DataRow.AcceptChanges" /> was called.</summary>
	/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to the table.</exception>
	public void AcceptChanges()
	{
	}

	/// <summary>Starts an edit operation on a <see cref="T:System.Data.DataRow" /> object.</summary>
	/// <exception cref="T:System.Data.InRowChangingEventException">The method was called inside the <see cref="E:System.Data.DataTable.RowChanging" /> event.</exception>
	/// <exception cref="T:System.Data.DeletedRowInaccessibleException">The method was called upon a deleted row.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void BeginEdit()
	{
	}

	private bool BeginEditInternal()
	{
		return false;
	}

	/// <summary>Cancels the current edit on the row.</summary>
	/// <exception cref="T:System.Data.InRowChangingEventException">The method was called inside the <see cref="E:System.Data.DataTable.RowChanging" /> event.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void CancelEdit()
	{
	}

	private void CheckColumn(DataColumn column)
	{
	}

	internal void CheckInTable()
	{
	}

	/// <summary>Deletes the <see cref="T:System.Data.DataRow" />.</summary>
	/// <exception cref="T:System.Data.DeletedRowInaccessibleException">The <see cref="T:System.Data.DataRow" /> has already been deleted.</exception>
	public void Delete()
	{
	}

	/// <summary>Ends the edit occurring on the row.</summary>
	/// <exception cref="T:System.Data.InRowChangingEventException">The method was called inside the <see cref="E:System.Data.DataTable.RowChanging" /> event.</exception>
	/// <exception cref="T:System.Data.ConstraintException">The edit broke a constraint.</exception>
	/// <exception cref="T:System.Data.ReadOnlyException">The row belongs to the table and the edit tried to change the value of a read-only column.</exception>
	/// <exception cref="T:System.Data.NoNullAllowedException">The edit tried to put a null value into a column where <see cref="P:System.Data.DataColumn.AllowDBNull" /> is false.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void EndEdit()
	{
	}

	/// <summary>Sets the error description for a column specified by index.</summary>
	/// <param name="columnIndex">The zero-based index of the column.</param>
	/// <param name="error">The error description.</param>
	/// <exception cref="T:System.IndexOutOfRangeException">The <paramref name="columnIndex" /> argument is out of range</exception>
	public void SetColumnError(int columnIndex, string error)
	{
	}

	/// <summary>Sets the error description for a column specified as a <see cref="T:System.Data.DataColumn" />.</summary>
	/// <param name="column">The <see cref="T:System.Data.DataColumn" /> to set the error description for.</param>
	/// <param name="error">The error description.</param>
	public void SetColumnError(DataColumn column, string error)
	{
	}

	/// <summary>Gets the error description of the specified <see cref="T:System.Data.DataColumn" />.</summary>
	/// <param name="column">A <see cref="T:System.Data.DataColumn" />.</param>
	/// <returns>The text of the error description.</returns>
	public string GetColumnError(DataColumn column)
	{
		return null;
	}

	/// <summary>Clears the errors for the row. This includes the <see cref="P:System.Data.DataRow.RowError" /> and errors set with <see cref="M:System.Data.DataRow.SetColumnError(System.Int32,System.String)" />.</summary>
	public void ClearErrors()
	{
	}

	internal void ClearError(DataColumn column)
	{
	}

	/// <summary>Gets an array of columns that have errors.</summary>
	/// <returns>An array of <see cref="T:System.Data.DataColumn" /> objects that contain errors.</returns>
	public DataColumn[] GetColumnsInError()
	{
		return null;
	}

	/// <summary>Gets the child rows of this <see cref="T:System.Data.DataRow" /> using the specified <see cref="T:System.Data.DataRelation" />.</summary>
	/// <param name="relation">The <see cref="T:System.Data.DataRelation" /> to use.</param>
	/// <returns>An array of <see cref="T:System.Data.DataRow" /> objects or an array of length zero.</returns>
	/// <exception cref="T:System.ArgumentException">The relation and row do not belong to the same table.</exception>
	/// <exception cref="T:System.ArgumentNullException">The relation is <see langword="null" />.</exception>
	/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to the table.</exception>
	/// <exception cref="T:System.Data.VersionNotFoundException">The row does not have this version of data.</exception>
	public DataRow[] GetChildRows(DataRelation relation)
	{
		return null;
	}

	/// <summary>Gets the child rows of a <see cref="T:System.Data.DataRow" /> using the specified <see cref="T:System.Data.DataRelation" />, and <see cref="T:System.Data.DataRowVersion" />.</summary>
	/// <param name="relation">The <see cref="T:System.Data.DataRelation" /> to use.</param>
	/// <param name="version">One of the <see cref="T:System.Data.DataRowVersion" /> values specifying the version of the data to get. Possible values are <see langword="Default" />, <see langword="Original" />, <see langword="Current" />, and <see langword="Proposed" />.</param>
	/// <returns>An array of <see cref="T:System.Data.DataRow" /> objects.</returns>
	/// <exception cref="T:System.ArgumentException">The relation and row do not belong to the same table.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="relation" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to the table.</exception>
	/// <exception cref="T:System.Data.VersionNotFoundException">The row does not have the requested <see cref="T:System.Data.DataRowVersion" />.</exception>
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version)
	{
		return null;
	}

	internal DataColumn GetDataColumn(string columnName)
	{
		return null;
	}

	/// <summary>Gets the parent row of a <see cref="T:System.Data.DataRow" /> using the specified <see cref="T:System.Data.DataRelation" />.</summary>
	/// <param name="relation">The <see cref="T:System.Data.DataRelation" /> to use.</param>
	/// <returns>The parent <see cref="T:System.Data.DataRow" /> of the current row.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="relation" /> does not belong to the <see cref="T:System.Data.DataTable" />.  
	/// -or-
	///  The row is <see langword="null" />.</exception>
	/// <exception cref="T:System.Data.DataException">A child row has multiple parents.</exception>
	/// <exception cref="T:System.Data.InvalidConstraintException">This row does not belong to the child table of the <see cref="T:System.Data.DataRelation" /> object.</exception>
	/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to a table.</exception>
	public DataRow GetParentRow(DataRelation relation)
	{
		return null;
	}

	/// <summary>Gets the parent row of a <see cref="T:System.Data.DataRow" /> using the specified <see cref="T:System.Data.DataRelation" />, and <see cref="T:System.Data.DataRowVersion" />.</summary>
	/// <param name="relation">The <see cref="T:System.Data.DataRelation" /> to use.</param>
	/// <param name="version">One of the <see cref="T:System.Data.DataRowVersion" /> values specifying the version of the data to get.</param>
	/// <returns>The parent <see cref="T:System.Data.DataRow" /> of the current row.</returns>
	/// <exception cref="T:System.ArgumentNullException">The row is <see langword="null" />.  
	/// -or-
	///  The <paramref name="relation" /> does not belong to this table's parent relations.</exception>
	/// <exception cref="T:System.Data.DataException">A child row has multiple parents.</exception>
	/// <exception cref="T:System.Data.InvalidConstraintException">The relation's child table is not the table the row belongs to.</exception>
	/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to a table.</exception>
	/// <exception cref="T:System.Data.VersionNotFoundException">The row does not have this version of data.</exception>
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version)
	{
		return null;
	}

	internal DataRow GetNestedParentRow(DataRowVersion version)
	{
		return null;
	}

	/// <summary>Gets the parent rows of a <see cref="T:System.Data.DataRow" /> using the specified <see cref="T:System.Data.DataRelation" />.</summary>
	/// <param name="relation">The <see cref="T:System.Data.DataRelation" /> to use.</param>
	/// <returns>An array of <see cref="T:System.Data.DataRow" /> objects or an array of length zero.</returns>
	/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Data.DataRelation" /> does not belong to this row's <see cref="T:System.Data.DataSet" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">The row is <see langword="null" />.</exception>
	/// <exception cref="T:System.Data.InvalidConstraintException">The relation's child table is not the table the row belongs to.</exception>
	/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to a <see cref="T:System.Data.DataTable" />.</exception>
	public DataRow[] GetParentRows(DataRelation relation)
	{
		return null;
	}

	/// <summary>Gets the parent rows of a <see cref="T:System.Data.DataRow" /> using the specified <see cref="T:System.Data.DataRelation" />, and <see cref="T:System.Data.DataRowVersion" />.</summary>
	/// <param name="relation">The <see cref="T:System.Data.DataRelation" /> to use.</param>
	/// <param name="version">One of the <see cref="T:System.Data.DataRowVersion" /> values specifying the version of the data to get.</param>
	/// <returns>An array of <see cref="T:System.Data.DataRow" /> objects or an array of length zero.</returns>
	/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Data.DataRelation" /> does not belong to this row's <see cref="T:System.Data.DataSet" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">The row is <see langword="null" />.</exception>
	/// <exception cref="T:System.Data.InvalidConstraintException">The relation's child table is not the table the row belongs to.</exception>
	/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to a <see cref="T:System.Data.DataTable" />.</exception>
	/// <exception cref="T:System.Data.VersionNotFoundException">The row does not have the requested <see cref="T:System.Data.DataRowVersion" />.</exception>
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version)
	{
		return null;
	}

	internal object[] GetColumnValues(DataColumn[] columns)
	{
		return null;
	}

	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version)
	{
		return null;
	}

	internal object[] GetKeyValues(DataKey key)
	{
		return null;
	}

	internal object[] GetKeyValues(DataKey key, DataRowVersion version)
	{
		return null;
	}

	internal int GetCurrentRecordNo()
	{
		return 0;
	}

	internal int GetDefaultRecord()
	{
		return 0;
	}

	internal int GetOriginalRecordNo()
	{
		return 0;
	}

	private int GetProposedRecordNo()
	{
		return 0;
	}

	internal int GetRecordFromVersion(DataRowVersion version)
	{
		return 0;
	}

	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState)
	{
		return default(DataRowVersion);
	}

	internal DataViewRowState GetRecordState(int record)
	{
		return default(DataViewRowState);
	}

	internal bool HasKeyChanged(DataKey key)
	{
		return false;
	}

	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2)
	{
		return false;
	}

	/// <summary>Gets a value that indicates whether a specified version exists.</summary>
	/// <param name="version">One of the <see cref="T:System.Data.DataRowVersion" /> values that specifies the row version.</param>
	/// <returns>
	///   <see langword="true" /> if the version exists; otherwise, <see langword="false" />.</returns>
	public bool HasVersion(DataRowVersion version)
	{
		return false;
	}

	internal bool HaveValuesChanged(DataColumn[] columns)
	{
		return false;
	}

	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2)
	{
		return false;
	}

	/// <summary>Rejects all changes made to the row since <see cref="M:System.Data.DataRow.AcceptChanges" /> was last called.</summary>
	/// <exception cref="T:System.Data.RowNotInTableException">The row does not belong to the table.</exception>
	public void RejectChanges()
	{
	}

	internal void ResetLastChangedColumn()
	{
	}

	internal void SetKeyValues(DataKey key, object[] keyValues)
	{
	}

	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested)
	{
	}

	internal void SetParentRowToDBNull()
	{
	}

	internal void SetParentRowToDBNull(DataRelation relation)
	{
	}

	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex)
	{
		return 0;
	}
}
