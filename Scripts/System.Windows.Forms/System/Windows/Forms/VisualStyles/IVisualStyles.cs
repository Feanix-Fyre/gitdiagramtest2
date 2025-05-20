using System.Drawing;

namespace System.Windows.Forms.VisualStyles;

internal interface IVisualStyles
{
	string VisualStyleInformationColorScheme { get; }

	string VisualStyleInformationFileName { get; }

	bool VisualStyleInformationIsSupportedByOS { get; }

	int UxThemeCloseThemeData(IntPtr hTheme);

	int UxThemeDrawThemeBackground(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds);

	int UxThemeDrawThemeBackground(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds, Rectangle clipRectangle);

	int UxThemeDrawThemeText(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, string text, TextFormatFlags textFlags, Rectangle bounds);

	int UxThemeGetThemeBackgroundRegion(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds, out Region result);

	int UxThemeGetThemeColor(IntPtr hTheme, int iPartId, int iStateId, ColorProperty prop, out Color result);

	int UxThemeGetThemePartSize(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, ThemeSizeType type, out Size result);

	int UxThemeGetThemeTextExtent(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, string textToDraw, TextFormatFlags flags, Rectangle bounds, out Rectangle result);

	bool UxThemeIsAppThemed();

	bool UxThemeIsThemeActive();

	bool UxThemeIsThemeBackgroundPartiallyTransparent(IntPtr hTheme, int iPartId, int iStateId);

	bool UxThemeIsThemePartDefined(IntPtr hTheme, int iPartId);

	IntPtr UxThemeOpenThemeData(IntPtr hWnd, string classList);

	void VisualStyleRendererDrawBackgroundExcludingArea(IntPtr theme, IDeviceContext dc, int part, int state, Rectangle bounds, Rectangle excludedArea);
}
