using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Form.FormClosing" /> event.</summary>
public class FormClosingEventArgs : CancelEventArgs
{
	private CloseReason close_reason;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.FormClosingEventArgs" /> class.</summary>
	/// <param name="closeReason">A <see cref="T:System.Windows.Forms.CloseReason" /> value that represents the reason why the form is being closed.</param>
	/// <param name="cancel">
	///   <see langword="true" /> to cancel the event; otherwise, <see langword="false" />.</param>
	public FormClosingEventArgs(CloseReason closeReason, bool cancel)
	{
	}
}
