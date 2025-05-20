using System.Runtime.InteropServices;

namespace System.Windows.Forms.CarbonInternal;

internal class EventHandler
{
	internal static EventDelegate EventHandlerDelegate;

	internal static XplatUICarbon Driver;

	internal static EventTypeSpec[] HIObjectEvents;

	internal static EventTypeSpec[] ControlEvents;

	internal static EventTypeSpec[] ApplicationEvents;

	private static EventTypeSpec[] WindowEvents;

	internal static int EventCallback(IntPtr callref, IntPtr eventref, IntPtr handle)
	{
		return 0;
	}

	internal static bool TranslateMessage(ref MSG msg)
	{
		return false;
	}

	internal static void InstallApplicationHandler()
	{
	}

	internal static void InstallControlHandler(IntPtr control)
	{
	}

	internal static void InstallWindowHandler(IntPtr window)
	{
	}

	[PreserveSig]
	private static extern IntPtr GetApplicationEventTarget();

	[PreserveSig]
	internal static extern IntPtr GetControlEventTarget(IntPtr control);

	[PreserveSig]
	internal static extern IntPtr GetWindowEventTarget(IntPtr window);

	[PreserveSig]
	internal static extern uint GetEventClass(IntPtr eventref);

	[PreserveSig]
	private static extern uint GetEventKind(IntPtr eventref);

	[PreserveSig]
	private static extern int InstallEventHandler(IntPtr window, EventDelegate event_handler, uint count, EventTypeSpec[] types, IntPtr user_data, IntPtr handlerref);
}
