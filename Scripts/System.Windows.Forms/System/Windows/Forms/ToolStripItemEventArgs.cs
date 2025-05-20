namespace System.Windows.Forms;

/// <summary>Provides data for <see cref="T:System.Windows.Forms.ToolStripItem" /> events.</summary>
public class ToolStripItemEventArgs : EventArgs
{
	private ToolStripItem item;

	/// <summary>Gets a <see cref="T:System.Windows.Forms.ToolStripItem" /> for which to handle events.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ToolStripItem" /> for which to handle events.</returns>
	public ToolStripItem Item => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripItemEventArgs" /> class, specifying a <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <param name="item">The <see cref="T:System.Windows.Forms.ToolStripItem" /> for which to specify events.</param>
	public ToolStripItemEventArgs(ToolStripItem item)
	{
	}
}
