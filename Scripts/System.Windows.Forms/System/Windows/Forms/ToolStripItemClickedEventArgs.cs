namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ToolStrip.ItemClicked" /> event.</summary>
public class ToolStripItemClickedEventArgs : EventArgs
{
	private ToolStripItem clicked_item;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripItemClickedEventArgs" /> class, specifying the <see cref="T:System.Windows.Forms.ToolStripItem" /> that was clicked.</summary>
	/// <param name="clickedItem">The <see cref="T:System.Windows.Forms.ToolStripItem" /> that was clicked.</param>
	public ToolStripItemClickedEventArgs(ToolStripItem clickedItem)
	{
	}
}
