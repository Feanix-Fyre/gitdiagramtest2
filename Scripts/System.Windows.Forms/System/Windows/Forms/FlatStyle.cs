namespace System.Windows.Forms;

/// <summary>Specifies the appearance of a control.</summary>
public enum FlatStyle
{
	/// <summary>The control appears flat.</summary>
	Flat = 0,
	/// <summary>A control appears flat until the mouse pointer moves over it, at which point it appears three-dimensional.</summary>
	Popup = 1,
	/// <summary>The control appears three-dimensional.</summary>
	Standard = 2,
	/// <summary>The appearance of the control is determined by the user's operating system.</summary>
	System = 3
}
