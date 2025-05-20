using System.Runtime.InteropServices;

namespace System.Windows.Forms.CarbonInternal;

internal class HIObjectHandler : EventHandlerBase, IEventHandler
{
	internal HIObjectHandler(XplatUICarbon driver)
		: base(null)
	{
	}

	public bool ProcessEvent(IntPtr callref, IntPtr eventref, IntPtr handle, uint kind, ref MSG msg)
	{
		return false;
	}

	[PreserveSig]
	private static extern int CallNextEventHandler(IntPtr callref, IntPtr eventref);

	[PreserveSig]
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref IntPtr data);
}
