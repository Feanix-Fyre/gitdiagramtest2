namespace System.Windows.Forms;

/// <summary>Provides the functionality for a control to act as a parent for other controls.</summary>
public interface IContainerControl
{
	/// <summary>Gets or sets the control that is active on the container control.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.Control" /> that is currently active on the container control.</returns>
	Control ActiveControl { get; set; }
}
