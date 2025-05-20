using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ToolStripDropDown.Closing" /> event.</summary>
public class ToolStripDropDownClosingEventArgs : CancelEventArgs
{
	private ToolStripDropDownCloseReason close_reason;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripDropDownClosingEventArgs" /> class with the specified reason for closing.</summary>
	/// <param name="reason">One of the <see cref="T:System.Windows.Forms.ToolStripDropDownCloseReason" /> values.</param>
	public ToolStripDropDownClosingEventArgs(ToolStripDropDownCloseReason reason)
	{
	}
}
