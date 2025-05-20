using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Hosts custom controls or Windows Forms controls.</summary>
public class ToolStripControlHost : ToolStripItem
{
	private Control control;

	private static object EnterEvent;

	private static object GotFocusEvent;

	private static object KeyDownEvent;

	private static object KeyPressEvent;

	private static object KeyUpEvent;

	private static object LeaveEvent;

	private static object LostFocusEvent;

	private static object ValidatedEvent;

	private static object ValidatingEvent;

	/// <summary>Gets the <see cref="T:System.Windows.Forms.Control" /> that this <see cref="T:System.Windows.Forms.ToolStripControlHost" /> is hosting.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.Control" /> that this <see cref="T:System.Windows.Forms.ToolStripControlHost" /> is hosting.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Control Control => null;

	/// <summary>Gives the focus to a control.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void Focus()
	{
	}
}
