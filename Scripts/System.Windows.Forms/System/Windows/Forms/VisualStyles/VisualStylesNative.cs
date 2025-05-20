using System.Drawing;

namespace System.Windows.Forms.VisualStyles;

internal class VisualStylesNative : IVisualStyles
{
	public string VisualStyleInformationColorScheme => null;

	public string VisualStyleInformationFileName => null;

	public bool VisualStyleInformationIsSupportedByOS => false;

	public int UxThemeCloseThemeData(IntPtr hTheme)
	{
		return 0;
	}

	public int UxThemeDrawThemeBackground(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds)
	{
		return 0;
	}

	public int UxThemeDrawThemeBackground(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds, Rectangle clipRectangle)
	{
		return 0;
	}

	public int UxThemeDrawThemeText(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, string text, TextFormatFlags textFlags, Rectangle bounds)
	{
		return 0;
	}

	public int UxThemeGetThemeBackgroundRegion(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds, out Region result)
	{
		result = null;
		return 0;
	}

	public int UxThemeGetThemeColor(IntPtr hTheme, int iPartId, int iStateId, ColorProperty prop, out Color result)
	{
		result = default(Color);
		return 0;
	}

	public int UxThemeGetThemePartSize(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, ThemeSizeType type, out Size result)
	{
		result = default(Size);
		return 0;
	}

	public int UxThemeGetThemeTextExtent(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, string textToDraw, TextFormatFlags flags, Rectangle bounds, out Rectangle result)
	{
		result = default(Rectangle);
		return 0;
	}

	public bool UxThemeIsAppThemed()
	{
		return false;
	}

	public bool UxThemeIsThemeActive()
	{
		return false;
	}

	public bool UxThemeIsThemePartDefined(IntPtr hTheme, int iPartId)
	{
		return false;
	}

	public bool UxThemeIsThemeBackgroundPartiallyTransparent(IntPtr hTheme, int iPartId, int iStateId)
	{
		return false;
	}

	public IntPtr UxThemeOpenThemeData(IntPtr hWnd, string classList)
	{
		return (IntPtr)0;
	}

	public static bool IsSupported()
	{
		return false;
	}

	public void VisualStyleRendererDrawBackgroundExcludingArea(IntPtr theme, IDeviceContext dc, int part, int state, Rectangle bounds, Rectangle excludedArea)
	{
	}
}
