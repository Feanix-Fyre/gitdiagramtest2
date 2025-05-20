using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Control.Invalidated" /> event.</summary>
public class InvalidateEventArgs : EventArgs
{
	private Rectangle invalidated_rectangle;

	/// <summary>Gets the <see cref="T:System.Drawing.Rectangle" /> that contains the invalidated window area.</summary>
	/// <returns>The invalidated window area.</returns>
	public Rectangle InvalidRect => default(Rectangle);

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.InvalidateEventArgs" /> class.</summary>
	/// <param name="invalidRect">The <see cref="T:System.Drawing.Rectangle" /> that contains the invalidated window area.</param>
	public InvalidateEventArgs(Rectangle invalidRect)
	{
	}
}
