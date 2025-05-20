using System.Windows.Forms.Design;

namespace System.Windows.Forms;

/// <summary>Represents a nonselectable <see cref="T:System.Windows.Forms.ToolStripItem" /> that renders text and images and can display hyperlinks.</summary>
[ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip)]
public class ToolStripLabel : ToolStripItem
{
	private static object UIAIsLinkChangedEvent;
}
