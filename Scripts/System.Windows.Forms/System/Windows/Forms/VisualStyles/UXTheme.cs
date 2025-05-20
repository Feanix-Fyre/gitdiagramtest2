using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Windows.Forms.VisualStyles;

internal class UXTheme
{
	public struct SIZE
	{
		public int cx;

		public int cy;

		public Size ToSize()
		{
			return default(Size);
		}
	}

	[PreserveSig]
	public static extern int CloseThemeData(IntPtr hTheme);

	[PreserveSig]
	public static extern int DrawThemeBackground(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref XplatUIWin32.RECT pRect, ref XplatUIWin32.RECT pClipRect);

	[PreserveSig]
	public static extern int DrawThemeBackground(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref XplatUIWin32.RECT pRect, IntPtr pClipRect);

	[PreserveSig]
	public static extern int DrawThemeText(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, string text, int textLength, uint textFlags, uint textFlags2, ref XplatUIWin32.RECT pRect);

	[PreserveSig]
	public static extern IntPtr OpenThemeData(IntPtr hWnd, string classList);

	[PreserveSig]
	public static extern int GetThemeBackgroundRegion(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref XplatUIWin32.RECT pRect, out IntPtr pRegion);

	[PreserveSig]
	public static extern int GetThemeColor(IntPtr hTheme, int iPartId, int iStateId, int iPropId, out int pColor);

	[PreserveSig]
	public static extern int GetThemePartSize(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, IntPtr pRect, int eSize, out SIZE size);

	[PreserveSig]
	public static extern int GetThemeTextExtent(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, string text, int textLength, int textFlags, ref XplatUIWin32.RECT boundingRect, out XplatUIWin32.RECT extentRect);

	[PreserveSig]
	public static extern int IsThemeBackgroundPartiallyTransparent(IntPtr hTheme, int iPartId, int iStateId);

	[PreserveSig]
	public static extern bool IsThemePartDefined(IntPtr hTheme, int iPartId, int iStateId);

	[PreserveSig]
	public static extern bool IsThemeActive();

	[PreserveSig]
	public static extern bool IsAppThemed();

	[PreserveSig]
	public static extern int GetCurrentThemeName(StringBuilder stringThemeName, int lengthThemeName, StringBuilder stringColorName, int lengthColorName, StringBuilder stringSizeName, int lengthSizeName);
}
