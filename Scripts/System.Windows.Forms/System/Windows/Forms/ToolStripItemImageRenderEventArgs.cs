using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderItemImage" /> event.</summary>
public class ToolStripItemImageRenderEventArgs : ToolStripItemRenderEventArgs
{
	private Image image;

	private Rectangle image_rectangle;

	/// <summary>Gets the image painted on the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>The <see cref="T:System.Drawing.Image" /> painted on the <see cref="T:System.Windows.Forms.ToolStrip" />.</returns>
	public Image Image => null;

	/// <summary>Gets the rectangle that represents the bounding area of the image.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that represents the bounding area of the image.</returns>
	public Rectangle ImageRectangle => default(Rectangle);

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripItemImageRenderEventArgs" /> class for the specified <see cref="T:System.Windows.Forms.ToolStripItem" /> within the specified space and that has the specified properties.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> used to paint the image.</param>
	/// <param name="item">The <see cref="T:System.Windows.Forms.ToolStripItem" />.</param>
	/// <param name="imageRectangle">The bounding area of the image.</param>
	public ToolStripItemImageRenderEventArgs(Graphics g, ToolStripItem item, Rectangle imageRectangle)
		: base(null, null)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripItemImageRenderEventArgs" /> class for the specified <see cref="T:System.Windows.Forms.ToolStripItem" /> that displays an image within the specified space and that has the specified properties.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> used to paint the image.</param>
	/// <param name="item">The <see cref="T:System.Windows.Forms.ToolStripItem" /> on which to draw the image.</param>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> to paint.</param>
	/// <param name="imageRectangle">The bounding area of the image.</param>
	public ToolStripItemImageRenderEventArgs(Graphics g, ToolStripItem item, Image image, Rectangle imageRectangle)
		: base(null, null)
	{
	}
}
