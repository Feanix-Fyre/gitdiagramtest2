using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides methods used to paint common Windows controls and their elements. This class cannot be inherited.</summary>
public sealed class ControlPaint
{
	private static int RGBMax;

	private static int HLSMax;

	internal static void Color2HBS(Color color, out int h, out int l, out int s)
	{
		h = default(int);
		l = default(int);
		s = default(int);
	}

	private static int HueToRGB(int n1, int n2, int hue)
	{
		return 0;
	}

	internal static Color HBS2Color(int hue, int lum, int sat)
	{
		return default(Color);
	}

	/// <summary>Creates a new light color object for the control from the specified color.</summary>
	/// <param name="baseColor">The <see cref="T:System.Drawing.Color" /> to be lightened.</param>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the light color on the control.</returns>
	public static Color Light(Color baseColor)
	{
		return default(Color);
	}

	/// <summary>Creates a new light color object for the control from the specified color and lightens it by the specified percentage.</summary>
	/// <param name="baseColor">The <see cref="T:System.Drawing.Color" /> to be lightened.</param>
	/// <param name="percOfLightLight">The percentage to lighten the specified <see cref="T:System.Drawing.Color" />.</param>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the light color on the control.</returns>
	public static Color Light(Color baseColor, float percOfLightLight)
	{
		return default(Color);
	}

	/// <summary>Creates a new light color object for the control from the specified color.</summary>
	/// <param name="baseColor">The <see cref="T:System.Drawing.Color" /> to be lightened.</param>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the light color on the control.</returns>
	public static Color LightLight(Color baseColor)
	{
		return default(Color);
	}

	/// <summary>Creates a new dark color object for the control from the specified color.</summary>
	/// <param name="baseColor">The <see cref="T:System.Drawing.Color" /> to be darkened.</param>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the dark color on the control.</returns>
	public static Color Dark(Color baseColor)
	{
		return default(Color);
	}

	/// <summary>Creates a new dark color object for the control from the specified color and darkens it by the specified percentage.</summary>
	/// <param name="baseColor">The <see cref="T:System.Drawing.Color" /> to be darkened.</param>
	/// <param name="percOfDarkDark">The percentage to darken the specified <see cref="T:System.Drawing.Color" />.</param>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represent the dark color on the control.</returns>
	public static Color Dark(Color baseColor, float percOfDarkDark)
	{
		return default(Color);
	}

	/// <summary>Creates a new dark color object for the control from the specified color.</summary>
	/// <param name="baseColor">The <see cref="T:System.Drawing.Color" /> to be darkened.</param>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the dark color on the control.</returns>
	public static Color DarkDark(Color baseColor)
	{
		return default(Color);
	}

	/// <summary>Draws a border with the specified style and color, on the specified graphics surface, and within the specified bounds on a button-style control.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="bounds">The <see cref="T:System.Drawing.Rectangle" /> that represents the dimensions of the border.</param>
	/// <param name="color">The <see cref="T:System.Drawing.Color" /> of the border.</param>
	/// <param name="style">One of the <see cref="T:System.Windows.Forms.ButtonBorderStyle" /> values that specifies the style of the border.</param>
	public static void DrawBorder(Graphics graphics, Rectangle bounds, Color color, ButtonBorderStyle style)
	{
	}

	/// <summary>Draws a border on a button-style control with the specified styles, colors, and border widths; on the specified graphics surface; and within the specified bounds.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="bounds">The <see cref="T:System.Drawing.Rectangle" /> that represents the dimensions of the border.</param>
	/// <param name="leftColor">The <see cref="T:System.Drawing.Color" /> of the left of the border.</param>
	/// <param name="leftWidth">The width of the left border.</param>
	/// <param name="leftStyle">One of the <see cref="T:System.Windows.Forms.ButtonBorderStyle" /> values that specifies the style of the left border.</param>
	/// <param name="topColor">The <see cref="T:System.Drawing.Color" /> of the top of the border.</param>
	/// <param name="topWidth">The width of the top border.</param>
	/// <param name="topStyle">One of the <see cref="T:System.Windows.Forms.ButtonBorderStyle" /> values that specifies the style of the top border.</param>
	/// <param name="rightColor">The <see cref="T:System.Drawing.Color" /> of the right of the border.</param>
	/// <param name="rightWidth">The width of the right border.</param>
	/// <param name="rightStyle">One of the <see cref="T:System.Windows.Forms.ButtonBorderStyle" /> values that specifies the style of the right border.</param>
	/// <param name="bottomColor">The <see cref="T:System.Drawing.Color" /> of the bottom of the border.</param>
	/// <param name="bottomWidth">The width of the bottom border.</param>
	/// <param name="bottomStyle">One of the <see cref="T:System.Windows.Forms.ButtonBorderStyle" /> values that specifies the style of the bottom border.</param>
	public static void DrawBorder(Graphics graphics, Rectangle bounds, Color leftColor, int leftWidth, ButtonBorderStyle leftStyle, Color topColor, int topWidth, ButtonBorderStyle topStyle, Color rightColor, int rightWidth, ButtonBorderStyle rightStyle, Color bottomColor, int bottomWidth, ButtonBorderStyle bottomStyle)
	{
	}

	/// <summary>Draws a three-dimensional style border with the specified style, on the specified graphics surface, and within the specified bounds on a control.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="rectangle">The <see cref="T:System.Drawing.Rectangle" /> that represents the dimensions of the border.</param>
	/// <param name="style">One of the <see cref="T:System.Windows.Forms.Border3DStyle" /> values that specifies the style of the border.</param>
	public static void DrawBorder3D(Graphics graphics, Rectangle rectangle, Border3DStyle style)
	{
	}

	/// <summary>Draws a three-dimensional style border with the specified style, on the specified graphics surface and sides, and within the specified bounds on a control.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="rectangle">The <see cref="T:System.Drawing.Rectangle" /> that represents the dimensions of the border.</param>
	/// <param name="style">One of the <see cref="T:System.Windows.Forms.Border3DStyle" /> values that specifies the style of the border.</param>
	/// <param name="sides">One of the <see cref="T:System.Windows.Forms.Border3DSide" /> values that specifies the side of the rectangle to draw the border on.</param>
	public static void DrawBorder3D(Graphics graphics, Rectangle rectangle, Border3DStyle style, Border3DSide sides)
	{
	}

	/// <summary>Draws a button control in the specified state, on the specified graphics surface, and within the specified bounds.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="rectangle">The <see cref="T:System.Drawing.Rectangle" /> that represents the dimensions of the button.</param>
	/// <param name="state">A bitwise combination of the <see cref="T:System.Windows.Forms.ButtonState" /> values that specifies the state to draw the button in.</param>
	public static void DrawButton(Graphics graphics, Rectangle rectangle, ButtonState state)
	{
	}

	/// <summary>Draws the specified caption button control in the specified state, on the specified graphics surface, and within the specified bounds.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="rectangle">The <see cref="T:System.Drawing.Rectangle" /> that represents the dimensions of the caption button.</param>
	/// <param name="button">One of the <see cref="T:System.Windows.Forms.CaptionButton" /> values that specifies the type of caption button to draw.</param>
	/// <param name="state">A bitwise combination of the <see cref="T:System.Windows.Forms.ButtonState" /> values that specifies the state to draw the button in.</param>
	public static void DrawCaptionButton(Graphics graphics, Rectangle rectangle, CaptionButton button, ButtonState state)
	{
	}

	/// <summary>Draws a check box control in the specified state, on the specified graphics surface, and within the specified bounds.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="rectangle">The <see cref="T:System.Drawing.Rectangle" /> that represents the dimensions of the check box.</param>
	/// <param name="state">A bitwise combination of the <see cref="T:System.Windows.Forms.ButtonState" /> values that specifies the state to draw the check box in.</param>
	public static void DrawCheckBox(Graphics graphics, Rectangle rectangle, ButtonState state)
	{
	}

	/// <summary>Draws a focus rectangle on the specified graphics surface and within the specified bounds.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="rectangle">The <see cref="T:System.Drawing.Rectangle" /> that represents the dimensions of the grab handle glyph.</param>
	public static void DrawFocusRectangle(Graphics graphics, Rectangle rectangle)
	{
	}

	/// <summary>Draws a focus rectangle on the specified graphics surface and within the specified bounds.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="rectangle">The <see cref="T:System.Drawing.Rectangle" /> that represents the dimensions of the grab handle glyph.</param>
	/// <param name="foreColor">The <see cref="T:System.Drawing.Color" /> that is the foreground color of the object to draw the focus rectangle on.</param>
	/// <param name="backColor">The <see cref="T:System.Drawing.Color" /> that is the background color of the object to draw the focus rectangle on.</param>
	public static void DrawFocusRectangle(Graphics graphics, Rectangle rectangle, Color foreColor, Color backColor)
	{
	}

	/// <summary>Draws the specified image in a disabled state.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> to draw.</param>
	/// <param name="x">The x-coordinate of the top left of the border image.</param>
	/// <param name="y">The y-coordinate of the top left of the border image.</param>
	/// <param name="background">The <see cref="T:System.Drawing.Color" /> of the background behind the image.</param>
	public static void DrawImageDisabled(Graphics graphics, Image image, int x, int y, Color background)
	{
	}

	/// <summary>Draws the specified menu glyph on a menu item control within the specified bounds and on the specified surface.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="rectangle">The <see cref="T:System.Drawing.Rectangle" /> that represents the dimensions of the glyph.</param>
	/// <param name="glyph">One of the <see cref="T:System.Windows.Forms.MenuGlyph" /> values that specifies the image to draw.</param>
	public static void DrawMenuGlyph(Graphics graphics, Rectangle rectangle, MenuGlyph glyph)
	{
	}

	/// <summary>Draws a three-state check box control in the specified state, on the specified graphics surface, and within the specified bounds.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="rectangle">The <see cref="T:System.Drawing.Rectangle" /> that represents the dimensions of the check box.</param>
	/// <param name="state">A bitwise combination of the <see cref="T:System.Windows.Forms.ButtonState" /> values that specifies the state to draw the check box in.</param>
	public static void DrawMixedCheckBox(Graphics graphics, Rectangle rectangle, ButtonState state)
	{
	}

	/// <summary>Draws a size grip on a form with the specified bounds and background color and on the specified graphics surface.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="backColor">The <see cref="T:System.Drawing.Color" /> of the background used to determine the colors of the size grip.</param>
	/// <param name="bounds">The <see cref="T:System.Drawing.Rectangle" /> that represents the dimensions of the size grip.</param>
	public static void DrawSizeGrip(Graphics graphics, Color backColor, Rectangle bounds)
	{
	}

	/// <summary>Draws the specified string in a disabled state on the specified graphics surface; within the specified bounds; and in the specified font, color, and format.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> to draw on.</param>
	/// <param name="s">The string to draw.</param>
	/// <param name="font">The <see cref="T:System.Drawing.Font" /> to draw the string with.</param>
	/// <param name="color">The <see cref="T:System.Drawing.Color" /> of the background behind the string.</param>
	/// <param name="layoutRectangle">The <see cref="T:System.Drawing.RectangleF" /> that represents the dimensions of the string.</param>
	/// <param name="format">The <see cref="T:System.Drawing.StringFormat" /> to apply to the string.</param>
	public static void DrawStringDisabled(Graphics graphics, string s, Font font, Color color, RectangleF layoutRectangle, StringFormat format)
	{
	}
}
