namespace System.Windows.Forms;

/// <summary>Determines whether a <see cref="T:System.Windows.Forms.ToolStripItem" /> is placed in the overflow <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
public enum ToolStripItemOverflow
{
	/// <summary>Specifies that a <see cref="T:System.Windows.Forms.ToolStripItem" /> is never a candidate for the overflow <see cref="T:System.Windows.Forms.ToolStrip" />. If the <see cref="T:System.Windows.Forms.ToolStripItem" /> cannot fit on the main <see cref="T:System.Windows.Forms.ToolStrip" />, it will not be shown.</summary>
	Never = 0,
	/// <summary>Specifies that a <see cref="T:System.Windows.Forms.ToolStripItem" /> is permanently shown in the overflow <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	Always = 1,
	/// <summary>Specifies that a <see cref="T:System.Windows.Forms.ToolStripItem" /> drifts between the main <see cref="T:System.Windows.Forms.ToolStrip" /> and the overflow <see cref="T:System.Windows.Forms.ToolStrip" /> as required if space is not available on the main <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	AsNeeded = 2
}
