using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace System.Windows.Forms;

/// <summary>Provides methods used to render a check box control with or without visual styles. This class cannot be inherited.</summary>
public sealed class CheckBoxRenderer
{
	private static bool always_use_visual_styles;

	/// <summary>Draws a check box control in the specified state and location.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> used to draw the check box.</param>
	/// <param name="glyphLocation">The <see cref="T:System.Drawing.Point" /> to draw the check box glyph at.</param>
	/// <param name="state">One of the <see cref="T:System.Windows.Forms.VisualStyles.CheckBoxState" /> values that specifies the visual state of the check box.</param>
	public static void DrawCheckBox(Graphics g, Point glyphLocation, CheckBoxState state)
	{
	}

	/// <summary>Draws a check box control in the specified state and location; with the specified text, text formatting, and image; and with an optional focus rectangle.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> used to draw the check box.</param>
	/// <param name="glyphLocation">The <see cref="T:System.Drawing.Point" /> to draw the check box glyph at.</param>
	/// <param name="textBounds">The <see cref="T:System.Drawing.Rectangle" /> to draw <paramref name="checkBoxText" /> in.</param>
	/// <param name="checkBoxText">The <see cref="T:System.String" /> to draw with the check box.</param>
	/// <param name="font">The <see cref="T:System.Drawing.Font" /> to apply to <paramref name="checkBoxText" />.</param>
	/// <param name="flags">A bitwise combination of the <see cref="T:System.Windows.Forms.TextFormatFlags" /> values.</param>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> to draw with the check box.</param>
	/// <param name="imageBounds">The <see cref="T:System.Drawing.Rectangle" /> that represents the dimensions of <paramref name="image" />.</param>
	/// <param name="focused">
	///   <see langword="true" /> to draw a focus rectangle; otherwise, <see langword="false" />.</param>
	/// <param name="state">One of the <see cref="T:System.Windows.Forms.VisualStyles.CheckBoxState" /> values that specifies the visual state of the check box.</param>
	public static void DrawCheckBox(Graphics g, Point glyphLocation, Rectangle textBounds, string checkBoxText, Font font, TextFormatFlags flags, Image image, Rectangle imageBounds, bool focused, CheckBoxState state)
	{
	}

	/// <summary>Returns the size of the check box glyph.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> this operation will use.</param>
	/// <param name="state">One of the <see cref="T:System.Windows.Forms.VisualStyles.CheckBoxState" /> values that specifies the visual state of the check box.</param>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that represents the size of the check box glyph.</returns>
	public static Size GetGlyphSize(Graphics g, CheckBoxState state)
	{
		return default(Size);
	}

	private static VisualStyleRenderer GetCheckBoxRenderer(CheckBoxState state)
	{
		return null;
	}
}
