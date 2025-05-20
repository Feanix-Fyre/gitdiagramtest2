namespace System.Windows.Forms;

/// <summary>Specifies where a <see cref="T:System.Windows.Forms.ToolStripItem" /> is to be layed out.</summary>
public enum ToolStripItemPlacement
{
	/// <summary>Specifies that a <see cref="T:System.Windows.Forms.ToolStripItem" /> is to be layed out on the main <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	Main = 0,
	/// <summary>Specifies that a <see cref="T:System.Windows.Forms.ToolStripItem" /> is to be layed out on the overflow <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	Overflow = 1,
	/// <summary>Specifies that a <see cref="T:System.Windows.Forms.ToolStripItem" /> is not to be layed out on the screen.</summary>
	None = 2
}
