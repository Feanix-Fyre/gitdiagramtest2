using System.Collections;
using System.Drawing;

namespace System.Windows.Forms;

internal class TextBoxTextRenderer
{
	private static Size max_size;

	private static bool use_textrenderer;

	private static StringFormat sf_nonprinting;

	private static StringFormat sf_printing;

	private static Hashtable measure_cache;

	static TextBoxTextRenderer()
	{
	}

	public static void DrawText(Graphics g, string text, Font font, Color color, float x, float y, bool showNonPrint)
	{
	}

	public static SizeF MeasureText(Graphics g, string text, Font font)
	{
		return default(SizeF);
	}
}
