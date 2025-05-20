namespace System.Windows.Forms;

/// <summary>Encapsulates properties related to scrolling.</summary>
public abstract class ScrollProperties
{
	private ScrollableControl parentControl;

	internal ScrollBar scroll_bar;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ScrollProperties" /> class.</summary>
	/// <param name="container">The <see cref="T:System.Windows.Forms.ScrollableControl" /> whose scrolling properties this object describes.</param>
	protected ScrollProperties(ScrollableControl container)
	{
	}
}
