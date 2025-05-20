using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see langword="DrawItem" /> event.</summary>
public class DrawItemEventArgs : EventArgs
{
	private Graphics graphics;

	private Font font;

	private Rectangle rect;

	private int index;

	private DrawItemState state;

	private Color fore_color;

	private Color back_color;

	/// <summary>Gets the graphics surface to draw the item on.</summary>
	/// <returns>The <see cref="T:System.Drawing.Graphics" /> surface to draw the item on.</returns>
	public Graphics Graphics => null;

	/// <summary>Gets the font that is assigned to the item being drawn.</summary>
	/// <returns>The <see cref="T:System.Drawing.Font" /> that is assigned to the item being drawn.</returns>
	public Font Font => null;

	/// <summary>Gets the rectangle that represents the bounds of the item that is being drawn.</summary>
	/// <returns>The <see cref="T:System.Drawing.Rectangle" /> that represents the bounds of the item that is being drawn.</returns>
	public Rectangle Bounds => default(Rectangle);

	/// <summary>Gets the index value of the item that is being drawn.</summary>
	/// <returns>The numeric value that represents the <see cref="P:System.Windows.Forms.Control.ControlCollection.Item(System.Int32)" /> value of the item being drawn.</returns>
	public int Index => 0;

	/// <summary>Gets the state of the item being drawn.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.DrawItemState" /> that represents the state of the item being drawn.</returns>
	public DrawItemState State => default(DrawItemState);

	/// <summary>Gets the background color of the item that is being drawn.</summary>
	/// <returns>The background <see cref="T:System.Drawing.Color" /> of the item that is being drawn.</returns>
	public Color BackColor => default(Color);

	/// <summary>Gets the foreground color of the of the item being drawn.</summary>
	/// <returns>The foreground <see cref="T:System.Drawing.Color" /> of the item being drawn.</returns>
	public Color ForeColor => default(Color);

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.DrawItemEventArgs" /> class for the specified control with the specified font, state, surface to draw on, and the bounds to draw within.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> surface on which to draw.</param>
	/// <param name="font">The <see cref="T:System.Drawing.Font" /> to use, usually the parent control's <see cref="T:System.Drawing.Font" /> property.</param>
	/// <param name="rect">The <see cref="T:System.Drawing.Rectangle" /> bounds to draw within.</param>
	/// <param name="index">The <see cref="T:System.Windows.Forms.Control.ControlCollection" /> index value of the item that is being drawn.</param>
	/// <param name="state">The control's <see cref="T:System.Windows.Forms.DrawItemState" /> information.</param>
	public DrawItemEventArgs(Graphics graphics, Font font, Rectangle rect, int index, DrawItemState state)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.DrawItemEventArgs" /> class for the specified control with the specified font, state, foreground color, background color, surface to draw on, and the bounds to draw within.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> surface on which to draw.</param>
	/// <param name="font">The <see cref="T:System.Drawing.Font" /> to use, usually the parent control's <see cref="T:System.Drawing.Font" /> property.</param>
	/// <param name="rect">The <see cref="T:System.Drawing.Rectangle" /> bounds to draw within.</param>
	/// <param name="index">The <see cref="T:System.Windows.Forms.Control.ControlCollection" /> index value of the item that is being drawn.</param>
	/// <param name="state">The control's <see cref="T:System.Windows.Forms.DrawItemState" /> information.</param>
	/// <param name="foreColor">The foreground <see cref="T:System.Drawing.Color" /> to draw the control with.</param>
	/// <param name="backColor">The background <see cref="T:System.Drawing.Color" /> to draw the control with.</param>
	public DrawItemEventArgs(Graphics graphics, Font font, Rectangle rect, int index, DrawItemState state, Color foreColor, Color backColor)
	{
	}
}
