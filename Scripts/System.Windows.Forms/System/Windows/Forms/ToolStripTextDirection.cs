namespace System.Windows.Forms;

/// <summary>Specifies the text orientation to use with a particular <see cref="P:System.Windows.Forms.ToolStrip.LayoutStyle" />.</summary>
public enum ToolStripTextDirection
{
	/// <summary>Specifies that the text direction is inherited from the parent control.</summary>
	Inherit = 0,
	/// <summary>Specifies horizontal text orientation.</summary>
	Horizontal = 1,
	/// <summary>Specifies that text is to be rotated 90 degrees.</summary>
	Vertical90 = 2,
	/// <summary>Specifies that text is to be rotated 270 degrees.</summary>
	Vertical270 = 3
}
