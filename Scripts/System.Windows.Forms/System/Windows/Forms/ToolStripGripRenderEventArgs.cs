using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderGrip" /> event.</summary>
public class ToolStripGripRenderEventArgs : ToolStripRenderEventArgs
{
	private Rectangle grip_bounds;

	private ToolStripGripDisplayStyle grip_display_style;

	private ToolStripGripStyle grip_style;

	/// <summary>Gets the rectangle representing the area in which to paint the move handle.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that represents the area in which to paint the move handle.</returns>
	public Rectangle GripBounds => default(Rectangle);

	/// <summary>Gets the style that indicates whether the move handle is displayed vertically or horizontally.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripGripDisplayStyle" /> values.</returns>
	public ToolStripGripDisplayStyle GripDisplayStyle => default(ToolStripGripDisplayStyle);

	/// <summary>Gets the style that indicates whether or not the move handle is visible.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripGripDisplayStyle" /> values.</returns>
	public ToolStripGripStyle GripStyle => default(ToolStripGripStyle);

	internal ToolStripGripRenderEventArgs(Graphics g, ToolStrip toolStrip, Rectangle gripBounds, ToolStripGripDisplayStyle displayStyle, ToolStripGripStyle gripStyle)
		: base(null, null)
	{
	}
}
