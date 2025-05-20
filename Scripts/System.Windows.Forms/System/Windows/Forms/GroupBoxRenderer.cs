using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace System.Windows.Forms;

/// <summary>Provides methods used to render a group box control with or without visual styles. This class cannot be inherited.</summary>
public sealed class GroupBoxRenderer
{
	private static bool always_use_visual_styles;

	/// <summary>Draws a group box control in the specified state and bounds, with the specified text, font, and color.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> used to draw the group box.</param>
	/// <param name="bounds">The <see cref="T:System.Drawing.Rectangle" /> that specifies the bounds of the group box.</param>
	/// <param name="groupBoxText">The <see cref="T:System.String" /> to draw with the group box.</param>
	/// <param name="font">The <see cref="T:System.Drawing.Font" /> to apply to <paramref name="groupBoxText" />.</param>
	/// <param name="textColor">The <see cref="T:System.Drawing.Color" /> to apply to <paramref name="groupBoxText" />.</param>
	/// <param name="state">One of the <see cref="T:System.Windows.Forms.VisualStyles.GroupBoxState" /> values that specifies the visual state of the group box.</param>
	public static void DrawGroupBox(Graphics g, Rectangle bounds, string groupBoxText, Font font, Color textColor, GroupBoxState state)
	{
	}

	/// <summary>Draws a group box control in the specified state and bounds, with the specified text, font, color, and text formatting.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> used to draw the group box.</param>
	/// <param name="bounds">The <see cref="T:System.Drawing.Rectangle" /> that specifies the bounds of the group box.</param>
	/// <param name="groupBoxText">The <see cref="T:System.String" /> to draw with the group box.</param>
	/// <param name="font">The <see cref="T:System.Drawing.Font" /> to apply to <paramref name="groupBoxText" />.</param>
	/// <param name="textColor">The <see cref="T:System.Drawing.Color" /> to apply to <paramref name="groupBoxText" />.</param>
	/// <param name="flags">A bitwise combination of the <see cref="T:System.Windows.Forms.TextFormatFlags" /> values.</param>
	/// <param name="state">One of the <see cref="T:System.Windows.Forms.VisualStyles.GroupBoxState" /> values that specifies the visual state of the group box.</param>
	public static void DrawGroupBox(Graphics g, Rectangle bounds, string groupBoxText, Font font, Color textColor, TextFormatFlags flags, GroupBoxState state)
	{
	}
}
