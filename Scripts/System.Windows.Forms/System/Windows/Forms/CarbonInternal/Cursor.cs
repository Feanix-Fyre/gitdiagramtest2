using System.Drawing;

namespace System.Windows.Forms.CarbonInternal;

internal class Cursor
{
	internal static CarbonCursor defcur;

	internal static IntPtr DefineCursor(Bitmap bitmap, Bitmap mask, Color cursor_pixel, Color mask_pixel, int xHotSpot, int yHotSpot)
	{
		return (IntPtr)0;
	}

	internal static IntPtr DefineStdCursor(StdCursor id)
	{
		return (IntPtr)0;
	}

	internal static void SetCursor(IntPtr cursor)
	{
	}
}
