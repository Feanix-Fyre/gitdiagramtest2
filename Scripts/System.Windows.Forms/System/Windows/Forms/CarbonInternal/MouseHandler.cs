using System.Runtime.InteropServices;

namespace System.Windows.Forms.CarbonInternal;

internal class MouseHandler : EventHandlerBase, IEventHandler
{
	internal static ClickStruct ClickPending;

	internal MouseHandler(XplatUICarbon driver)
		: base(null)
	{
	}

	public bool ProcessEvent(IntPtr callref, IntPtr eventref, IntPtr handle, uint kind, ref MSG msg)
	{
		return false;
	}

	internal bool TranslateMessage(ref MSG msg)
	{
		return false;
	}

	private void UpdateMouseState(int button, bool down)
	{
	}

	[PreserveSig]
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref QDPoint data);

	[PreserveSig]
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref int data);

	[PreserveSig]
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref ushort data);

	[PreserveSig]
	internal static extern short FindWindow(QDPoint point, ref IntPtr handle);

	[PreserveSig]
	internal static extern int GetWindowBounds(IntPtr handle, uint region, ref Rect bounds);

	[PreserveSig]
	internal static extern int HIViewConvertPoint(ref CGPoint point, IntPtr source_view, IntPtr target_view);

	[PreserveSig]
	internal static extern IntPtr HIViewGetRoot(IntPtr handle);

	[PreserveSig]
	internal static extern int HIViewGetSubviewHit(IntPtr content_view, ref CGPoint point, bool tval, ref IntPtr hit_view);

	[PreserveSig]
	internal static extern int HIViewFindByID(IntPtr root_window, HIViewID id, ref IntPtr view_handle);
}
