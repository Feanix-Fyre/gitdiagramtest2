using System.Drawing;
using System.Windows.Forms.Theming.Default;

namespace System.Windows.Forms.Theming;

internal class ThemeElements
{
	private static ThemeElementsDefault theme;

	public static ThemeElementsDefault CurrentTheme => null;

	public static LabelPainter LabelPainter => null;

	static ThemeElements()
	{
	}

	private static ThemeElementsDefault LoadTheme(string themeName)
	{
		return null;
	}

	public static void DrawButton(Graphics g, Rectangle bounds, ButtonThemeState state, Color backColor, Color foreColor)
	{
	}

	public static void DrawFlatButton(Graphics g, Rectangle bounds, ButtonThemeState state, Color backColor, Color foreColor, FlatButtonAppearance appearance)
	{
	}

	public static void DrawPopupButton(Graphics g, Rectangle bounds, ButtonThemeState state, Color backColor, Color foreColor)
	{
	}
}
