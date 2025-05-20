using System.Drawing;

namespace System.Windows.Forms.VisualStyles;

internal class VisualStylesGtkPlus : IVisualStyles
{
	private enum ThemeHandle
	{
		BUTTON = 1,
		COMBOBOX = 2,
		EDIT = 3,
		HEADER = 4,
		PROGRESS = 5,
		REBAR = 6,
		SCROLLBAR = 7,
		SPIN = 8,
		STATUS = 9,
		TAB = 10,
		TOOLBAR = 11,
		TRACKBAR = 12,
		TREEVIEW = 13
	}

	private static GtkPlus GtkPlus => null;

	public string VisualStyleInformationColorScheme => null;

	public string VisualStyleInformationFileName => null;

	public bool VisualStyleInformationIsSupportedByOS => false;

	public static bool Initialize()
	{
		return false;
	}

	public int UxThemeCloseThemeData(IntPtr hTheme)
	{
		return 0;
	}

	public int UxThemeDrawThemeBackground(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds, Rectangle clipRectangle)
	{
		return 0;
	}

	public int UxThemeDrawThemeBackground(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds)
	{
		return 0;
	}

	private bool DrawBackground(ThemeHandle themeHandle, IDeviceContext dc, int part, int state, Rectangle bounds, Rectangle clipRectangle, Rectangle excludedArea)
	{
		return false;
	}

	private static bool GetGtkPlusState(SCROLLBARSTYLESTATES state, out GtkPlusState result)
	{
		result = default(GtkPlusState);
		return false;
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

	private bool GetPartSize(ThemeHandle themeHandle, IDeviceContext dc, int part, int state, Rectangle bounds, bool rectangleSpecified, ThemeSizeType type, out Size result)
	{
		result = default(Size);
		return false;
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

	public bool UxThemeIsThemeBackgroundPartiallyTransparent(IntPtr hTheme, int iPartId, int iStateId)
	{
		return false;
	}

	public bool UxThemeIsThemePartDefined(IntPtr hTheme, int iPartId)
	{
		return false;
	}

	public IntPtr UxThemeOpenThemeData(IntPtr hWnd, string classList)
	{
		return (IntPtr)0;
	}

	public void VisualStyleRendererDrawBackgroundExcludingArea(IntPtr theme, IDeviceContext dc, int part, int state, Rectangle bounds, Rectangle excludedArea)
	{
	}
}
