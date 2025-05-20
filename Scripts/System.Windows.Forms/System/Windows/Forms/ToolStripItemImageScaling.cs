namespace System.Windows.Forms;

/// <summary>Specifies whether the size of the image on a <see cref="T:System.Windows.Forms.ToolStripItem" /> is automatically adjusted to fit on a <see cref="T:System.Windows.Forms.ToolStrip" /> while retaining the original image proportions.</summary>
public enum ToolStripItemImageScaling
{
	/// <summary>Specifies that the size of the image on a <see cref="T:System.Windows.Forms.ToolStripItem" /> is not automatically adjusted to fit on a <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	None = 0,
	/// <summary>Specifies that the size of the image on a <see cref="T:System.Windows.Forms.ToolStripItem" /> is automatically adjusted to fit on a <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	SizeToFit = 1
}
