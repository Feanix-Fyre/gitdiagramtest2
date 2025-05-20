namespace System.Windows.Forms.CarbonInternal;

internal class ApplicationHandler : EventHandlerBase, IEventHandler
{
	internal ApplicationHandler(XplatUICarbon driver)
		: base(null)
	{
	}

	public bool ProcessEvent(IntPtr callref, IntPtr eventref, IntPtr handle, uint kind, ref MSG msg)
	{
		return false;
	}
}
