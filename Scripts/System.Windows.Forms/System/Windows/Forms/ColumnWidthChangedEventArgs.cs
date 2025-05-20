namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ListView.ColumnWidthChanged" /> event.</summary>
public class ColumnWidthChangedEventArgs : EventArgs
{
	private int column_index;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ColumnWidthChangedEventArgs" /> class.</summary>
	/// <param name="columnIndex">The index of the column whose width is being changed.</param>
	public ColumnWidthChangedEventArgs(int columnIndex)
	{
	}
}
