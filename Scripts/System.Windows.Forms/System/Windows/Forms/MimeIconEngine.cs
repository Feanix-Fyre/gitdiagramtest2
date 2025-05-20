using System.Collections;
using System.Drawing;

namespace System.Windows.Forms;

internal class MimeIconEngine
{
	public static ImageList SmallIcons;

	public static ImageList LargeIcons;

	private static EPlatformHandler platform;

	internal static Hashtable MimeIconIndex;

	private static PlatformMimeIconHandler platformMimeHandler;

	private static object lock_object;

	static MimeIconEngine()
	{
	}

	public static int GetIconIndexForFile(string full_filename)
	{
		return 0;
	}

	public static int GetIconIndexForMimeType(string mime_type)
	{
		return 0;
	}

	internal static void AddIconByImage(string mime_type, Image image)
	{
	}

	private static object GetIconIndex(string mime_type)
	{
		return null;
	}
}
