using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderArrow" /> event.</summary>
public class ToolStripArrowRenderEventArgs : EventArgs
{
	private Color arrow_color;

	private Rectangle arrow_rectangle;

	private ArrowDirection arrow_direction;

	private Graphics graphics;

	private ToolStripItem tool_strip_item;

	/// <summary>Gets or sets the color of the <see cref="T:System.Windows.Forms.ToolStrip" /> arrow.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the color of the arrow.</returns>
	public Color ArrowColor => default(Color);

	/// <summary>Gets or sets the bounding area of the <see cref="T:System.Windows.Forms.ToolStrip" /> arrow.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that represents the bounding area.</returns>
	public Rectangle ArrowRectangle => default(Rectangle);

	/// <summary>Gets or sets the direction in which the <see cref="T:System.Windows.Forms.ToolStrip" /> arrow points.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ArrowDirection" /> values.</returns>
	public ArrowDirection Direction => default(ArrowDirection);

	/// <summary>Gets the graphics used to paint the <see cref="T:System.Windows.Forms.ToolStrip" /> arrow.</summary>
	/// <returns>The <see cref="T:System.Drawing.Graphics" /> used to paint.</returns>
	public Graphics Graphics => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripArrowRenderEventArgs" /> class.</summary>
	/// <param name="g">The graphics used to paint the <see cref="T:System.Windows.Forms.ToolStrip" /> arrow.</param>
	/// <param name="toolStripItem">The <see cref="T:System.Windows.Forms.ToolStripItem" /> on which to paint the arrow.</param>
	/// <param name="arrowRectangle">The bounding area of the <see cref="T:System.Windows.Forms.ToolStrip" /> arrow.</param>
	/// <param name="arrowColor">The color of the <see cref="T:System.Windows.Forms.ToolStrip" /> arrow.</param>
	/// <param name="arrowDirection">The direction in which the <see cref="T:System.Windows.Forms.ToolStrip" /> arrow points.</param>
	public ToolStripArrowRenderEventArgs(Graphics g, ToolStripItem toolStripItem, Rectangle arrowRectangle, Color arrowColor, ArrowDirection arrowDirection)
	{
	}
}
