namespace System.Data;

/// <summary>Occurs when a target and source <see langword="DataRow" /> have the same primary key value, and the <see cref="P:System.Data.DataSet.EnforceConstraints" /> property is set to true.</summary>
public class MergeFailedEventArgs : EventArgs
{
	/// <summary>Returns a description of the merge conflict.</summary>
	/// <returns>A description of the merge conflict.</returns>
	public string Conflict { get; }

	/// <summary>Initializes a new instance of a <see cref="T:System.Data.MergeFailedEventArgs" /> class with the <see cref="T:System.Data.DataTable" /> and a description of the merge conflict.</summary>
	/// <param name="table">The <see cref="T:System.Data.DataTable" /> object.</param>
	/// <param name="conflict">A description of the merge conflict.</param>
	public MergeFailedEventArgs(DataTable table, string conflict)
	{
	}
}
