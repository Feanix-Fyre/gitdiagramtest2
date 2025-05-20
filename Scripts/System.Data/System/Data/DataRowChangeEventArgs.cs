namespace System.Data;

/// <summary>Provides data for the <see cref="E:System.Data.DataTable.RowChanged" />, <see cref="E:System.Data.DataTable.RowChanging" />, <see cref="M:System.Data.DataTable.OnRowDeleting(System.Data.DataRowChangeEventArgs)" />, and <see cref="M:System.Data.DataTable.OnRowDeleted(System.Data.DataRowChangeEventArgs)" /> events.</summary>
public class DataRowChangeEventArgs : EventArgs
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataRowChangeEventArgs" /> class.</summary>
	/// <param name="row">The <see cref="T:System.Data.DataRow" /> upon which an action is occuring.</param>
	/// <param name="action">One of the <see cref="T:System.Data.DataRowAction" /> values.</param>
	public DataRowChangeEventArgs(DataRow row, DataRowAction action)
	{
	}
}
