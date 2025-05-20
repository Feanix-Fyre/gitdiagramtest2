using System.Runtime.InteropServices;

namespace System.Windows.Forms.CarbonInternal;

internal class Pasteboard
{
	private static IntPtr primary_pbref;

	private static IntPtr app_pbref;

	private static IntPtr internal_format;

	internal static IntPtr Primary => (IntPtr)0;

	internal static IntPtr Application => (IntPtr)0;

	static Pasteboard()
	{
	}

	internal static object Retrieve(IntPtr pbref, int key)
	{
		return null;
	}

	internal static void Store(IntPtr pbref, object data, int key)
	{
	}

	[PreserveSig]
	private static extern IntPtr CFDataCreate(IntPtr allocator, ref IntPtr buf, int length);

	[PreserveSig]
	private static extern IntPtr CFDataGetBytePtr(IntPtr data);

	[PreserveSig]
	private static extern int PasteboardClear(IntPtr pbref);

	[PreserveSig]
	private static extern int PasteboardCreate(IntPtr str, ref IntPtr pbref);

	[PreserveSig]
	private static extern int PasteboardCopyItemFlavorData(IntPtr pbref, uint itemid, uint key, ref IntPtr data);

	[PreserveSig]
	private static extern int PasteboardGetItemCount(IntPtr pbref, ref uint count);

	[PreserveSig]
	private static extern int PasteboardGetItemIdentifier(IntPtr pbref, uint itemindex, ref uint itemid);

	[PreserveSig]
	private static extern int PasteboardPutItemFlavor(IntPtr pbref, uint itemid, uint key, IntPtr data, uint flags);
}
