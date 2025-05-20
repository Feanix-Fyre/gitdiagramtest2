using System.Runtime.InteropServices;

namespace System.Windows.Forms.CarbonInternal;

internal class KeyboardHandler : EventHandlerBase, IEventHandler
{
	internal static byte[] key_filter_table;

	internal static byte[] key_modifier_table;

	internal static byte[] key_translation_table;

	internal static byte[] char_translation_table;

	internal static bool translate_modifier;

	internal string ComposedString;

	internal Keys ModifierKeys => default(Keys);

	internal KeyboardHandler(XplatUICarbon driver)
		: base(null)
	{
	}

	static KeyboardHandler()
	{
	}

	private void ModifierToVirtualKey(int i, ref MSG msg, bool down)
	{
	}

	public void ProcessModifiers(IntPtr eventref, ref MSG msg)
	{
	}

	public void ProcessText(IntPtr eventref, ref MSG msg)
	{
	}

	public void ProcessKeyPress(IntPtr eventref, ref MSG msg)
	{
	}

	public bool ProcessEvent(IntPtr callref, IntPtr eventref, IntPtr handle, uint kind, ref MSG msg)
	{
		return false;
	}

	public bool TranslateMessage(ref MSG msg)
	{
		return false;
	}

	[PreserveSig]
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, ref uint outsize, IntPtr data);

	[PreserveSig]
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, IntPtr data);

	[PreserveSig]
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref byte data);

	[PreserveSig]
	private static extern int GetEventParameter(IntPtr eventref, uint name, uint type, IntPtr outtype, uint size, IntPtr outsize, ref uint data);
}
