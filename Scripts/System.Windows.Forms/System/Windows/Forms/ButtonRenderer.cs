using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace System.Windows.Forms;

/// <summary>Provides methods used to render a button control with or without visual styles. This class cannot be inherited.</summary>
public sealed class ButtonRenderer
{
	private static bool always_use_visual_styles;

	/// <summary>Draws a button control in the specified state and bounds; with the specified text, text formatting, and image; and with an optional focus rectangle.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> used to draw the button.</param>
	/// <param name="bounds">The <see cref="T:System.Drawing.Rectangle" /> that specifies the bounds of the button.</param>
	/// <param name="buttonText">The <see cref="T:System.String" /> to draw on the button.</param>
	/// <param name="font">The <see cref="T:System.Drawing.Font" /> to apply to <paramref name="buttonText" />.</param>
	/// <param name="flags">A bitwise combination of the <see cref="T:System.Windows.Forms.TextFormatFlags" /> values to apply to <paramref name="buttonText" />.</param>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> to draw on the button.</param>
	/// <param name="imageBounds">The <see cref="T:System.Drawing.Rectangle" /> that represents the dimensions of <paramref name="image" />.</param>
	/// <param name="focused">
	///   <see langword="true" /> to draw a focus rectangle on the button; otherwise, <see langword="false" />.</param>
	/// <param name="state">One of the <see cref="T:System.Windows.Forms.VisualStyles.PushButtonState" /> values that specifies the visual state of the button.</param>
	public static void DrawButton(Graphics g, Rectangle bounds, string buttonText, Font font, TextFormatFlags flags, Image image, Rectangle imageBounds, bool focused, PushButtonState state)
	{
	}

	internal static VisualStyleRenderer GetPushButtonRenderer(PushButtonState state)
	{
		return null;
	}
}
