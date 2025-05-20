namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Control.Layout" /> event. This class cannot be inherited.</summary>
public sealed class LayoutEventArgs : EventArgs
{
	private Control affected_control;

	private string affected_property;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.LayoutEventArgs" /> class with the specified control and property affected.</summary>
	/// <param name="affectedControl">The <see cref="T:System.Windows.Forms.Control" /> affected by the layout change.</param>
	/// <param name="affectedProperty">The property affected by the layout change.</param>
	public LayoutEventArgs(Control affectedControl, string affectedProperty)
	{
	}
}
