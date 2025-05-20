using System.Runtime.InteropServices;

namespace System.Windows.Forms.CarbonInternal;

internal class ControlHandler : EventHandlerBase, IEventHandler
{
	internal ControlHandler(XplatUICarbon driver)
		: base(null)
	{
	}

	public bool ProcessEvent(IntPtr callref, IntPtr eventref, IntPtr handle, uint kind, ref MSG msg)
	{
		return false;
	}

	private void DrawBorders(Hwnd hwnd)
	{
	}

	[PreserveSig]
	private static extern int GetRegionBounds(IntPtr rgnhandle, ref Rect region);

	[PreserveSig]
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref IntPtr data);

	[PreserveSig]
	private static extern int SetEventParameter(IntPtr eventref, uint name, uint type, uint size, ref short data);

	[PreserveSig]
	private static extern int HIViewGetBounds(IntPtr handle, ref HIRect rect);

	[PreserveSig]
	private static extern int HIViewGetFrame(IntPtr handle, ref HIRect rect);

	[PreserveSig]
	private static extern bool HIViewIsVisible(IntPtr vHnd);
}
