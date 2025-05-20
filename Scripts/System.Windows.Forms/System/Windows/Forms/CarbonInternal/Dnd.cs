using System.Runtime.InteropServices;

namespace System.Windows.Forms.CarbonInternal;

internal class Dnd
{
	private static DragDropEffects effects;

	private static DragTrackingDelegate DragTrackingHandler;

	internal Dnd()
	{
	}

	static Dnd()
	{
	}

	internal static void TrackingCallback(short message, IntPtr window, IntPtr data, IntPtr dragref)
	{
	}

	internal static DragDropEffects DragActionsToEffects(uint actions)
	{
		return default(DragDropEffects);
	}

	internal static DataObject DragToDataObject(IntPtr dragref)
	{
		return null;
	}

	internal static bool HandleEvent(IntPtr callref, IntPtr eventref, IntPtr handle, uint kind, ref MSG msg)
	{
		return false;
	}

	public void SetAllowDrop(Hwnd hwnd, bool allow)
	{
	}

	[PreserveSig]
	private static extern int InstallTrackingHandler(DragTrackingDelegate callback, IntPtr window, IntPtr data);

	[PreserveSig]
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref IntPtr data);

	[PreserveSig]
	private static extern int SetEventParameter(IntPtr eventref, uint name, uint type, uint size, ref bool data);

	[PreserveSig]
	private static extern int SetControlDragTrackingEnabled(IntPtr view, bool enabled);

	[PreserveSig]
	private static extern int CountDragItems(IntPtr dragref, ref uint count);

	[PreserveSig]
	private static extern int CountDragItemFlavors(IntPtr dragref, IntPtr itemref, ref uint count);

	[PreserveSig]
	private static extern int GetDragItemReferenceNumber(IntPtr dragref, uint index, ref IntPtr itemref);

	[PreserveSig]
	private static extern int GetDragAllowableActions(IntPtr dragref, ref uint actions);
}
