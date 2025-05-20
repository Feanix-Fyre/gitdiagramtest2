using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ToolTip.Draw" /> event.</summary>
public class DrawToolTipEventArgs : EventArgs
{
	private Control associated_control;

	private IWin32Window associated_window;

	private Color back_color;

	private Font font;

	private Rectangle bounds;

	private Color fore_color;

	private Graphics graphics;

	private string tooltip_text;

	/// <summary>Gets the size and location of the <see cref="T:System.Windows.Forms.ToolTip" /> to draw.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that represents the bounds of the <see cref="T:System.Windows.Forms.ToolTip" /> to draw.</returns>
	public Rectangle Bounds => default(Rectangle);

	/// <summary>Gets the graphics surface used to draw the <see cref="T:System.Windows.Forms.ToolTip" />.</summary>
	/// <returns>The <see cref="T:System.Drawing.Graphics" /> on which to draw the <see cref="T:System.Windows.Forms.ToolTip" />.</returns>
	public Graphics Graphics => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.DrawToolTipEventArgs" /> class.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> context used to draw the ToolTip.</param>
	/// <param name="associatedWindow">The <see cref="T:System.Windows.Forms.IWin32Window" /> that the ToolTip is bound to.</param>
	/// <param name="associatedControl">The <see cref="T:System.Windows.Forms.Control" /> that the ToolTip is being created for.</param>
	/// <param name="bounds">A <see cref="T:System.Drawing.Rectangle" /> that outlines the area where the ToolTip is to be displayed.</param>
	/// <param name="toolTipText">A <see cref="T:System.String" /> containing the text for the ToolTip.</param>
	/// <param name="backColor">The <see cref="T:System.Drawing.Color" /> of the ToolTip background.</param>
	/// <param name="foreColor">The <see cref="T:System.Drawing.Color" /> of the ToolTip text.</param>
	/// <param name="font">The <see cref="T:System.Drawing.Font" /> used to draw the ToolTip text.</param>
	public DrawToolTipEventArgs(Graphics graphics, IWin32Window associatedWindow, Control associatedControl, Rectangle bounds, string toolTipText, Color backColor, Color foreColor, Font font)
	{
	}
}
