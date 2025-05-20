using System.Windows.Forms.Design;

namespace System.Windows.Forms;

/// <summary>Represents a text box in a <see cref="T:System.Windows.Forms.ToolStrip" /> that allows the user to enter text.</summary>
[ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.MenuStrip | ToolStripItemDesignerAvailability.ContextMenuStrip)]
public class ToolStripTextBox : ToolStripControlHost
{
	private static object AcceptsTabChangedEvent;

	private static object BorderStyleChangedEvent;

	private static object HideSelectionChangedEvent;

	private static object ModifiedChangedEvent;

	private static object MultilineChangedEvent;

	private static object ReadOnlyChangedEvent;

	private static object TextBoxTextAlignChangedEvent;
}
