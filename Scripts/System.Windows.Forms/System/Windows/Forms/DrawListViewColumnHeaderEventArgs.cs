using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ListView.DrawColumnHeader" /> event.</summary>
public class DrawListViewColumnHeaderEventArgs : EventArgs
{
	private Color backColor;

	private Rectangle bounds;

	private int columnIndex;

	private bool drawDefault;

	private Font font;

	private Color foreColor;

	private Graphics graphics;

	private ColumnHeader header;

	private ListViewItemStates state;

	/// <summary>Gets or sets a value indicating whether the column header should be drawn by the operating system instead of owner-drawn.</summary>
	/// <returns>
	///   <see langword="true" /> if the header should be drawn by the operating system; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool DrawDefault => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.DrawListViewColumnHeaderEventArgs" /> class.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> surface on which to draw.</param>
	/// <param name="bounds">The <see cref="T:System.Drawing.Rectangle" /> within which to draw.</param>
	/// <param name="columnIndex">The index of the header's column within the <see cref="P:System.Windows.Forms.ListView.Columns" /> collection.</param>
	/// <param name="header">The <see cref="T:System.Windows.Forms.ColumnHeader" /> representing the header to draw.</param>
	/// <param name="state">A bitwise combination of <see cref="T:System.Windows.Forms.ListViewItemStates" /> values indicating the current state of the column header.</param>
	/// <param name="foreColor">The foreground <see cref="T:System.Drawing.Color" /> of the header.</param>
	/// <param name="backColor">The background <see cref="T:System.Drawing.Color" /> of the header.</param>
	/// <param name="font">The <see cref="T:System.Drawing.Font" /> used for the header text.</param>
	public DrawListViewColumnHeaderEventArgs(Graphics graphics, Rectangle bounds, int columnIndex, ColumnHeader header, ListViewItemStates state, Color foreColor, Color backColor, Font font)
	{
	}
}
