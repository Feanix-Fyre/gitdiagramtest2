using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ListView.ColumnWidthChanging" /> event.</summary>
public class ColumnWidthChangingEventArgs : CancelEventArgs
{
	private int column_index;

	private int new_width;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ColumnWidthChangingEventArgs" /> class with the specified column index and width.</summary>
	/// <param name="columnIndex">The index of the column whose width is changing.</param>
	/// <param name="newWidth">The new width for the column.</param>
	public ColumnWidthChangingEventArgs(int columnIndex, int newWidth)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ColumnWidthChangingEventArgs" /> class, specifying the column index and width and whether to cancel the event.</summary>
	/// <param name="columnIndex">The index of the column whose width is changing.</param>
	/// <param name="newWidth">The new width of the column.</param>
	/// <param name="cancel">
	///   <see langword="true" /> to cancel the width change; otherwise, <see langword="false" />.</param>
	public ColumnWidthChangingEventArgs(int columnIndex, int newWidth, bool cancel)
	{
	}
}
