namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Control.ControlAdded" /> and <see cref="E:System.Windows.Forms.Control.ControlRemoved" /> events.</summary>
public class ControlEventArgs : EventArgs
{
	private Control control;

	/// <summary>Gets the control object used by this event.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.Control" /> used by this event.</returns>
	public Control Control => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ControlEventArgs" /> class for the specified control.</summary>
	/// <param name="control">The <see cref="T:System.Windows.Forms.Control" /> to store in this event.</param>
	public ControlEventArgs(Control control)
	{
	}
}
