using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms.CarbonInternal;

internal struct CarbonCursor
{
	private Bitmap bmp;

	private Bitmap mask;

	private Color cursor_color;

	private Color mask_color;

	private int hot_x;

	private int hot_y;

	private StdCursor id;

	private bool standard;

	public CarbonCursor(Bitmap bitmap, Bitmap mask, Color cursor_pixel, Color mask_pixel, int xHotSpot, int yHotSpot)
	{
		bmp = null;
		this.mask = null;
		cursor_color = default(Color);
		mask_color = default(Color);
		hot_x = 0;
		hot_y = 0;
		id = default(StdCursor);
		standard = false;
	}

	public CarbonCursor(StdCursor id)
	{
		bmp = null;
		mask = null;
		cursor_color = default(Color);
		mask_color = default(Color);
		hot_x = 0;
		hot_y = 0;
		this.id = default(StdCursor);
		standard = false;
	}

	public void SetCursor()
	{
	}

	public void SetCustomCursor()
	{
	}

	public void SetStandardCursor()
	{
	}

	[PreserveSig]
	private static extern int SetThemeCursor(ThemeCursor cursor);
}
