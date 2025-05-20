using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

internal class GnomeUtil
{
	private enum GnomeIconLookupFlags
	{
		GNOME_ICON_LOOKUP_FLAGS_NONE = 0,
		GNOME_ICON_LOOKUP_FLAGS_EMBEDDING_TEXT = 1,
		GNOME_ICON_LOOKUP_FLAGS_SHOW_SMALL_IMAGES_AS_THEMSELVES = 2,
		GNOME_ICON_LOOKUP_FLAGS_ALLOW_SVG_AS_THEMSELVES = 4
	}

	private enum GtkIconLookupFlags
	{
		GTK_ICON_LOOKUP_NO_SVG = 1,
		GTK_ICON_LOOKUP_FORCE_SVG = 2,
		GTK_ICON_LOOKUP_USE_BUILTIN = 4
	}

	private static bool inited;

	private static IntPtr default_icon_theme;

	[PreserveSig]
	private static extern bool gdk_pixbuf_save_to_buffer(IntPtr pixbuf, out IntPtr buffer, out UIntPtr buffer_size, string type, out IntPtr error, IntPtr option_dummy);

	[PreserveSig]
	private static extern void g_free(IntPtr mem);

	[PreserveSig]
	private static extern bool gdk_init_check(IntPtr argc, IntPtr argv);

	[PreserveSig]
	private static extern void g_object_unref(IntPtr nativeObject);

	[PreserveSig]
	private static extern string gnome_icon_lookup(IntPtr icon_theme, IntPtr thumbnail_factory, string file_uri, string custom_icon, IntPtr file_info, string mime_type, GnomeIconLookupFlags flags, IntPtr result);

	[PreserveSig]
	private static extern IntPtr gtk_icon_theme_get_default();

	[PreserveSig]
	private static extern IntPtr gtk_icon_theme_load_icon(IntPtr icon_theme, string icon_name, int size, GtkIconLookupFlags flags, out IntPtr error);

	private static void Init()
	{
	}

	public static Image GetIcon(string file_name, string mime_type, int size)
	{
		return null;
	}

	public static Image GetIcon(string icon, int size)
	{
		return null;
	}

	public static Image GdkPixbufToImage(IntPtr pixbuf)
	{
		return null;
	}
}
