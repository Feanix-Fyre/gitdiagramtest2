namespace System.Data;

/// <summary>Provides data for the <see cref="M:System.Data.DataTable.Clear" /> method.</summary>
public sealed class DataTableClearEventArgs : EventArgs
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataTableClearEventArgs" /> class.</summary>
	/// <param name="dataTable">The <see cref="T:System.Data.DataTable" /> whose rows are being cleared.</param>
	public DataTableClearEventArgs(DataTable dataTable)
	{
	}
}
