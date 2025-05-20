namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ToolStripDropDown.Closed" /> event.</summary>
public class ToolStripDropDownClosedEventArgs : EventArgs
{
	private ToolStripDropDownCloseReason close_reason;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripDropDownClosedEventArgs" /> class.</summary>
	/// <param name="reason">One of the <see cref="T:System.Windows.Forms.ToolStripDropDownCloseReason" /> values.</param>
	public ToolStripDropDownClosedEventArgs(ToolStripDropDownCloseReason reason)
	{
	}
}
