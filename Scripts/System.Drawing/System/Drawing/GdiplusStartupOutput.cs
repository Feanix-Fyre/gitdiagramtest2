namespace System.Drawing;

internal struct GdiplusStartupOutput
{
	internal IntPtr NotificationHook;

	internal IntPtr NotificationUnhook;

	internal static GdiplusStartupOutput MakeGdiplusStartupOutput()
	{
		return default(GdiplusStartupOutput);
	}
}
