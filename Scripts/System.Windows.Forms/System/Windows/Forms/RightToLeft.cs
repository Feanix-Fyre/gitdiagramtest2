namespace System.Windows.Forms;

/// <summary>Specifies a value indicating whether the text appears from right to left, such as when using Hebrew or Arabic fonts.</summary>
public enum RightToLeft
{
	/// <summary>The text reads from left to right. This is the default.</summary>
	No = 0,
	/// <summary>The text reads from right to left.</summary>
	Yes = 1,
	/// <summary>The direction the text read is inherited from the parent control.</summary>
	Inherit = 2
}
