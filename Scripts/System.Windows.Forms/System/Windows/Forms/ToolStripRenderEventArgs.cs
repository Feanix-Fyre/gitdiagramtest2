using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="M:System.Windows.Forms.ToolStripRenderer.OnRenderImageMargin(System.Windows.Forms.ToolStripRenderEventArgs)" />, <see cref="M:System.Windows.Forms.ToolStripRenderer.OnRenderToolStripBorder(System.Windows.Forms.ToolStripRenderEventArgs)" />, and <see cref="M:System.Windows.Forms.ToolStripRenderer.OnRenderToolStripBackground(System.Windows.Forms.ToolStripRenderEventArgs)" /> methods.</summary>
public class ToolStripRenderEventArgs : EventArgs
{
	private Rectangle affected_bounds;

	private Color back_color;

	private Rectangle connected_area;

	private Graphics graphics;

	private ToolStrip tool_strip;

	/// <summary>Gets the <see cref="T:System.Drawing.Rectangle" /> representing the bounds of the area to be painted.</summary>
	/// <returns>The <see cref="T:System.Drawing.Rectangle" /> representing the bounds of the area to be painted.</returns>
	public Rectangle AffectedBounds => default(Rectangle);

	/// <summary>Gets the <see cref="T:System.Drawing.Rectangle" /> representing the overlap area between a <see cref="T:System.Windows.Forms.ToolStripDropDown" /> and its <see cref="P:System.Windows.Forms.ToolStripDropDown.OwnerItem" />.</summary>
	/// <returns>The <see cref="T:System.Drawing.Rectangle" /> representing the overlap area between a <see cref="T:System.Windows.Forms.ToolStripDropDown" /> and its <see cref="P:System.Windows.Forms.ToolStripDropDown.OwnerItem" />.</returns>
	public Rectangle ConnectedArea => default(Rectangle);

	/// <summary>Gets the <see cref="T:System.Drawing.Graphics" /> used to paint.</summary>
	/// <returns>The <see cref="T:System.Drawing.Graphics" /> used to paint.</returns>
	public Graphics Graphics => null;

	/// <summary>Gets the <see cref="T:System.Windows.Forms.ToolStrip" /> to be painted.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.ToolStrip" /> to be painted.</returns>
	public ToolStrip ToolStrip => null;

	internal Rectangle InternalConnectedArea
	{
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripRenderEventArgs" /> class for the specified <see cref="T:System.Windows.Forms.ToolStrip" /> and using the specified <see cref="T:System.Drawing.Graphics" />.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> to use for painting.</param>
	/// <param name="toolStrip">The <see cref="T:System.Windows.Forms.ToolStrip" /> to paint.</param>
	public ToolStripRenderEventArgs(Graphics g, ToolStrip toolStrip)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripRenderEventArgs" /> class for the specified <see cref="T:System.Windows.Forms.ToolStrip" />, using the specified <see cref="T:System.Drawing.Graphics" /> to paint the specified bounds with the specified <see cref="T:System.Drawing.Color" />.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> to use for painting.</param>
	/// <param name="toolStrip">The <see cref="T:System.Windows.Forms.ToolStrip" /> to paint.</param>
	/// <param name="affectedBounds">The <see cref="T:System.Drawing.Rectangle" /> representing the bounds of the area to be painted.</param>
	/// <param name="backColor">The <see cref="T:System.Drawing.Color" /> that the background of the <see cref="T:System.Windows.Forms.ToolStrip" /> is painted with.</param>
	public ToolStripRenderEventArgs(Graphics g, ToolStrip toolStrip, Rectangle affectedBounds, Color backColor)
	{
	}
}
