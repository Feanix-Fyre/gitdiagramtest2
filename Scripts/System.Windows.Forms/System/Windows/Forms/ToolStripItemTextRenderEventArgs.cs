using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderItemText" /> event.</summary>
public class ToolStripItemTextRenderEventArgs : ToolStripItemRenderEventArgs
{
	private string text;

	private Color text_color;

	private ToolStripTextDirection text_direction;

	private Font text_font;

	private TextFormatFlags text_format;

	private Rectangle text_rectangle;

	/// <summary>Gets or sets the text to be drawn on the <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <returns>A string that represents the text to be painted on the <see cref="T:System.Windows.Forms.ToolStripItem" />.</returns>
	public string Text => null;

	/// <summary>Gets or sets the color of the <see cref="T:System.Windows.Forms.ToolStripItem" /> text.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the color of the <see cref="T:System.Windows.Forms.ToolStripItem" /> text.</returns>
	public Color TextColor => default(Color);

	/// <summary>Gets or sets whether the text is drawn vertically or horizontally.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripTextDirection" /> values.</returns>
	public ToolStripTextDirection TextDirection => default(ToolStripTextDirection);

	/// <summary>Gets or sets the font of the text drawn on the <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <returns>The <see cref="T:System.Drawing.Font" /> of the text drawn on the <see cref="T:System.Windows.Forms.ToolStripItem" />.</returns>
	public Font TextFont => null;

	/// <summary>Gets or sets the display and layout information of the text drawn on the <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <returns>A bitwise combination of the <see cref="T:System.Windows.Forms.TextFormatFlags" /> values that specify the display and layout information of the drawn text.</returns>
	public TextFormatFlags TextFormat => default(TextFormatFlags);

	/// <summary>Gets or sets the rectangle that represents the bounds to draw the text in.</summary>
	/// <returns>The <see cref="T:System.Drawing.Rectangle" /> that represents the bounds to draw the text in.</returns>
	public Rectangle TextRectangle => default(Rectangle);

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripItemTextRenderEventArgs" /> class with the specified text and text properties.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> used to draw the text.</param>
	/// <param name="item">The <see cref="T:System.Windows.Forms.ToolStripItem" /> on which to draw the text.</param>
	/// <param name="text">The text to be drawn.</param>
	/// <param name="textRectangle">The <see cref="T:System.Drawing.Rectangle" /> that represents the bounds to draw the text in.</param>
	/// <param name="textColor">The <see cref="T:System.Drawing.Color" /> used to draw the text.</param>
	/// <param name="textFont">The <see cref="T:System.Drawing.Font" /> used to draw the text.</param>
	/// <param name="textAlign">The <see cref="T:System.Drawing.ContentAlignment" /> that specifies the vertical and horizontal alignment of the text in the bounding area.</param>
	public ToolStripItemTextRenderEventArgs(Graphics g, ToolStripItem item, string text, Rectangle textRectangle, Color textColor, Font textFont, ContentAlignment textAlign)
		: base(null, null)
	{
	}
}
