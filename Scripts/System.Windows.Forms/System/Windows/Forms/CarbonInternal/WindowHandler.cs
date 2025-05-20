using System.Runtime.InteropServices;

namespace System.Windows.Forms.CarbonInternal;

internal class WindowHandler : EventHandlerBase, IEventHandler
{
	internal WindowHandler(XplatUICarbon driver)
		: base(null)
	{
	}

	public bool ProcessEvent(IntPtr callref, IntPtr eventref, IntPtr handle, uint kind, ref MSG msg)
	{
		return false;
	}

	[PreserveSig]
	private static extern int GetWindowBounds(IntPtr handle, uint region, ref Rect bounds);

	[PreserveSig]
	private static extern int HIViewSetFrame(IntPtr handle, ref HIRect bounds);
}
