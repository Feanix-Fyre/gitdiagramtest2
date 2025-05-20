using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Windows.Forms;

internal class X11Keyboard : IDisposable
{
	private class XIMCallbackContext
	{
		private XIMCallback startCB;

		private XIMCallback doneCB;

		private XIMCallback drawCB;

		private XIMCallback caretCB;

		private IntPtr pStartCB;

		private IntPtr pDoneCB;

		private IntPtr pDrawCB;

		private IntPtr pCaretCB;

		private IntPtr pStartCBN;

		private IntPtr pDoneCBN;

		private IntPtr pDrawCBN;

		private IntPtr pCaretCBN;

		public XIMCallbackContext(IntPtr clientWindow)
		{
		}

		~XIMCallbackContext()
		{
		}

		private int DoPreeditStart(IntPtr xic, IntPtr clientData, IntPtr callData)
		{
			return 0;
		}

		private int DoPreeditDone(IntPtr xic, IntPtr clientData, IntPtr callData)
		{
			return 0;
		}

		private int DoPreeditDraw(IntPtr xic, IntPtr clientData, IntPtr callData)
		{
			return 0;
		}

		private int DoPreeditCaret(IntPtr xic, IntPtr clientData, IntPtr callData)
		{
			return 0;
		}

		public IntPtr CreateXic(IntPtr window, IntPtr xim)
		{
			return (IntPtr)0;
		}
	}

	private class XIMPositionContext
	{
		public CaretStruct Caret;

		public int X;

		public int Y;
	}

	internal static object XlibLock;

	private IntPtr display;

	private IntPtr client_window;

	private IntPtr xim;

	private Hashtable xic_table;

	private XIMPositionContext positionContext;

	private XIMCallbackContext callbackContext;

	private XIMProperties ximStyle;

	private EventMask xic_event_mask;

	private StringBuilder lookup_buffer;

	private byte[] utf8_buffer;

	private int min_keycode;

	private int max_keycode;

	private int keysyms_per_keycode;

	private int syms;

	private int[] keyc2vkey;

	private int[] keyc2scan;

	private byte[] key_state_table;

	private int lcid;

	private bool num_state;

	private bool cap_state;

	private bool initialized;

	private bool menu_state;

	private int NumLockMask;

	private int AltGrMask;

	private string stored_keyevent_string;

	private static readonly int[] nonchar_key_vkey;

	private static readonly int[] nonchar_key_scan;

	private static readonly int[] nonchar_vkey_key;

	public IntPtr ClientWindow => (IntPtr)0;

	public EventMask KeyEventMask => default(EventMask);

	public Keys ModifierKeys => default(Keys);

	public X11Keyboard(IntPtr display, IntPtr clientWindow)
	{
	}

	void IDisposable.Dispose()
	{
	}

	public void DestroyICForWindow(IntPtr window)
	{
	}

	public void EnsureLayoutInitialized()
	{
	}

	private void SetupXIM()
	{
	}

	private void CreateXicForWindow(IntPtr window)
	{
	}

	private IntPtr GetXic(IntPtr window)
	{
		return (IntPtr)0;
	}

	private bool FilterKey(XEvent e, int vkey)
	{
		return false;
	}

	public void FocusIn(IntPtr window)
	{
	}

	public void FocusOut(IntPtr window)
	{
	}

	public bool ResetKeyState(IntPtr hwnd, ref MSG msg)
	{
		return false;
	}

	public void PreFilter(XEvent xevent)
	{
	}

	public void KeyEvent(IntPtr hwnd, XEvent xevent, ref MSG msg)
	{
	}

	public bool TranslateMessage(ref MSG msg)
	{
		return false;
	}

	public int ToUnicode(int vkey, int scan, out string buffer)
	{
		buffer = null;
		return 0;
	}

	internal string GetCompositionString()
	{
		return null;
	}

	private MSG SendImeComposition(string s)
	{
		return default(MSG);
	}

	private MSG SendKeyboardInput(VirtualKeys vkey, int scan, int keycode, KeybdEventFlags dw_flags, int time)
	{
		return default(MSG);
	}

	private IntPtr GenerateLParam(MSG m, int keyCode)
	{
		return (IntPtr)0;
	}

	private void GenerateMessage(VirtualKeys vkey, int scan, int key_code, XEventName type, int event_time)
	{
	}

	private void UpdateKeyState(XEvent xevent)
	{
	}

	private void SetState(VirtualKeys key, bool state)
	{
	}

	public int EventToVkey(XEvent e)
	{
		return 0;
	}

	private void CreateConversionArray(KeyboardLayouts layouts, KeyboardLayout layout)
	{
	}

	private KeyboardLayout DetectLayout(KeyboardLayouts layouts)
	{
		return null;
	}

	private int MapDeadKeySym(int val)
	{
		return 0;
	}

	private XIMProperties[] GetSupportedInputStyles(IntPtr xim)
	{
		return null;
	}

	private XIMProperties[] GetPreferredStyles()
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerable GetMatchingStylesInPreferredOrder(IntPtr xim)
	{
		return null;
	}

	private IntPtr CreateXic(IntPtr window, IntPtr xim)
	{
		return (IntPtr)0;
	}

	private IntPtr CreateOverTheSpotXic(IntPtr window, IntPtr xim)
	{
		return (IntPtr)0;
	}

	private IntPtr CreateOnTheSpotXic(IntPtr window, IntPtr xim)
	{
		return (IntPtr)0;
	}

	internal void SetCaretPos(CaretStruct caret, IntPtr handle, int x, int y)
	{
	}

	internal void MoveCurrentCaretPos()
	{
	}

	private int LookupString(ref XEvent xevent, int len, out XKeySym keysym, out IntPtr status)
	{
		keysym = default(XKeySym);
		status = default(IntPtr);
		return 0;
	}

	[PreserveSig]
	private static extern IntPtr XOpenIM(IntPtr display, IntPtr rdb, IntPtr res_name, IntPtr res_class);

	[PreserveSig]
	private static extern IntPtr XCreateIC(IntPtr xim, string name, XIMProperties im_style, string name2, IntPtr value2, IntPtr terminator);

	[PreserveSig]
	private static extern IntPtr XCreateIC(IntPtr xim, string name, XIMProperties im_style, string name2, IntPtr value2, string name3, IntPtr value3, IntPtr terminator);

	[PreserveSig]
	private static extern IntPtr XVaCreateNestedList(int dummy, IntPtr name0, XPoint value0, IntPtr terminator);

	[PreserveSig]
	private static extern IntPtr XVaCreateNestedList(int dummy, IntPtr name0, XPoint value0, IntPtr name1, IntPtr value1, IntPtr terminator);

	[PreserveSig]
	private static extern IntPtr XVaCreateNestedList(int dummy, IntPtr name0, IntPtr value0, IntPtr name1, IntPtr value1, IntPtr name2, IntPtr value2, IntPtr name3, IntPtr value3, IntPtr terminator);

	[PreserveSig]
	private static extern IntPtr XCreateFontSet(IntPtr display, string name, out IntPtr list, out int count, IntPtr terminator);

	[PreserveSig]
	private static extern void XFreeStringList(IntPtr ptr);

	[PreserveSig]
	private static extern void XCloseIM(IntPtr xim);

	[PreserveSig]
	private static extern void XDestroyIC(IntPtr xic);

	[PreserveSig]
	private static extern string XGetIMValues(IntPtr xim, string name, out IntPtr value, IntPtr terminator);

	[PreserveSig]
	private static extern string XGetICValues(IntPtr xic, string name, out EventMask value, IntPtr terminator);

	[PreserveSig]
	private static extern void XSetICValues(IntPtr xic, string name, IntPtr value, IntPtr terminator);

	[PreserveSig]
	private static extern void XSetICFocus(IntPtr xic);

	[PreserveSig]
	private static extern void XUnsetICFocus(IntPtr xic);

	[PreserveSig]
	private static extern string Xutf8ResetIC(IntPtr xic);

	[PreserveSig]
	private static extern bool XSupportsLocale();

	[PreserveSig]
	private static extern bool XSetLocaleModifiers(string mods);

	[PreserveSig]
	internal static extern int XLookupString(ref XEvent xevent, StringBuilder buffer, int num_bytes, out IntPtr keysym, IntPtr status);

	[PreserveSig]
	internal static extern int Xutf8LookupString(IntPtr xic, ref XEvent xevent, byte[] buffer, int num_bytes, out IntPtr keysym, out IntPtr status);

	[PreserveSig]
	private static extern IntPtr XGetKeyboardMapping(IntPtr display, byte first_keycode, int keycode_count, out int keysyms_per_keycode_return);

	[PreserveSig]
	private static extern void XDisplayKeycodes(IntPtr display, out int min, out int max);

	[PreserveSig]
	private static extern uint XKeycodeToKeysym(IntPtr display, int keycode, int index);

	[PreserveSig]
	private static extern int XKeysymToKeycode(IntPtr display, IntPtr keysym);

	private static int XKeysymToKeycode(IntPtr display, int keysym)
	{
		return 0;
	}

	[PreserveSig]
	internal static extern IntPtr XGetModifierMapping(IntPtr display);

	[PreserveSig]
	internal static extern int XFreeModifiermap(IntPtr modmap);
}
