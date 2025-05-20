using System.Collections;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Mono.Unix.Native;

namespace System.Windows.Forms;

internal class XplatUIX11 : XplatUIDriver
{
	internal class XException : ApplicationException
	{
		private IntPtr Display;

		private IntPtr ResourceID;

		private IntPtr Serial;

		private XRequest RequestCode;

		private byte ErrorCode;

		private byte MinorCode;

		public override string Message => null;

		public XException(IntPtr Display, IntPtr ResourceID, IntPtr Serial, byte ErrorCode, XRequest RequestCode, byte MinorCode)
		{
		}

		public static string GetMessage(IntPtr Display, IntPtr ResourceID, IntPtr Serial, byte ErrorCode, XRequest RequestCode, byte MinorCode)
		{
			return null;
		}
	}

	private delegate bool EventPredicate(IntPtr display, ref XEvent xevent, IntPtr arg);

	private delegate IntPtr WndProcDelegate(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam);

	private static XplatUIX11 Instance;

	private static int RefCount;

	private static object XlibLock;

	private static bool themes_enabled;

	private static IntPtr DisplayHandle;

	private static int ScreenNo;

	private static IntPtr DefaultColormap;

	private static IntPtr CustomVisual;

	private static IntPtr CustomColormap;

	private static IntPtr RootWindow;

	private static IntPtr FosterParent;

	private static XErrorHandler ErrorHandler;

	private static bool ErrorExceptions;

	private int render_major_opcode;

	private int render_first_event;

	private int render_first_error;

	private static IntPtr ClipMagic;

	private static ClipboardData Clipboard;

	private static IntPtr PostAtom;

	private static IntPtr AsyncAtom;

	private static Hashtable MessageQueues;

	private static ArrayList unattached_timer_list;

	private static Pollfd[] pollfds;

	private static bool wake_waiting;

	private static object wake_waiting_lock;

	private static X11Keyboard Keyboard;

	private static X11Dnd Dnd;

	private static Socket listen;

	private static Socket wake;

	private static Socket wake_receive;

	private static byte[] network_buffer;

	private static bool detectable_key_auto_repeat;

	private static IntPtr ActiveWindow;

	private static IntPtr FocusWindow;

	private static Stack ModalWindows;

	private static IntPtr LastCursorWindow;

	private static IntPtr LastCursorHandle;

	private static IntPtr OverrideCursorHandle;

	private static CaretStruct Caret;

	private static IntPtr LastPointerWindow;

	private static IntPtr WM_PROTOCOLS;

	private static IntPtr WM_DELETE_WINDOW;

	private static IntPtr WM_TAKE_FOCUS;

	private static IntPtr _NET_DESKTOP_GEOMETRY;

	private static IntPtr _NET_CURRENT_DESKTOP;

	private static IntPtr _NET_ACTIVE_WINDOW;

	private static IntPtr _NET_WORKAREA;

	private static IntPtr _NET_WM_NAME;

	private static IntPtr _NET_WM_WINDOW_TYPE;

	private static IntPtr _NET_WM_STATE;

	private static IntPtr _NET_WM_ICON;

	private static IntPtr _NET_WM_USER_TIME;

	private static IntPtr _NET_FRAME_EXTENTS;

	private static IntPtr _NET_SYSTEM_TRAY_S;

	private static IntPtr _NET_SYSTEM_TRAY_OPCODE;

	private static IntPtr _NET_WM_STATE_MAXIMIZED_HORZ;

	private static IntPtr _NET_WM_STATE_MAXIMIZED_VERT;

	private static IntPtr _XEMBED;

	private static IntPtr _XEMBED_INFO;

	private static IntPtr _MOTIF_WM_HINTS;

	private static IntPtr _NET_WM_STATE_SKIP_TASKBAR;

	private static IntPtr _NET_WM_STATE_ABOVE;

	private static IntPtr _NET_WM_STATE_MODAL;

	private static IntPtr _NET_WM_STATE_HIDDEN;

	private static IntPtr _NET_WM_CONTEXT_HELP;

	private static IntPtr _NET_WM_WINDOW_OPACITY;

	private static IntPtr _NET_WM_WINDOW_TYPE_UTILITY;

	private static IntPtr _NET_WM_WINDOW_TYPE_NORMAL;

	private static IntPtr CLIPBOARD;

	private static IntPtr PRIMARY;

	private static IntPtr OEMTEXT;

	private static IntPtr UTF8_STRING;

	private static IntPtr UTF16_STRING;

	private static IntPtr RICHTEXTFORMAT;

	private static IntPtr TARGETS;

	private static HoverStruct HoverState;

	private static ClickStruct ClickPending;

	private static GrabStruct Grab;

	private Point mouse_position;

	internal static MouseButtons MouseState;

	internal static bool in_doevents;

	private static int DoubleClickInterval;

	private static readonly object lockobj;

	private static Hashtable messageHold;

	private EventHandler Idle;

	internal static IntPtr Display => (IntPtr)0;

	internal override int CaptionHeight => 0;

	internal override Size DragSize => default(Size);

	internal override Size FrameBorderSize => default(Size);

	internal override bool MenuAccessKeysUnderlined => false;

	internal override Size MinimumWindowSize => default(Size);

	internal override Size MinimumFixedToolWindowSize => default(Size);

	internal override Size MinimumSizeableToolWindowSize => default(Size);

	internal override Size MinimumNoBorderWindowSize => default(Size);

	internal override Keys ModifierKeys => default(Keys);

	internal override Point MousePosition => default(Point);

	internal override Rectangle VirtualScreen => default(Rectangle);

	internal override Rectangle WorkingArea => default(Rectangle);

	internal override bool ThemesEnabled => false;

	private XplatUIX11()
	{
	}

	~XplatUIX11()
	{
	}

	public static XplatUIX11 GetInstance()
	{
		return null;
	}

	internal void SetDisplay(IntPtr display_handle)
	{
	}

	private int unixtime()
	{
		return 0;
	}

	private static void SetupAtoms()
	{
	}

	private void SendNetWMMessage(IntPtr window, IntPtr message_type, IntPtr l0, IntPtr l1, IntPtr l2)
	{
	}

	private void SendParentNotify(IntPtr child, Msg cause, int x, int y)
	{
	}

	private bool StyleSet(int s, WindowStyles ws)
	{
		return false;
	}

	private bool ExStyleSet(int ex, WindowExStyles exws)
	{
		return false;
	}

	internal static Rectangle TranslateClientRectangleToXClientRectangle(Hwnd hwnd)
	{
		return default(Rectangle);
	}

	internal static Rectangle TranslateClientRectangleToXClientRectangle(Hwnd hwnd, Control ctrl)
	{
		return default(Rectangle);
	}

	internal static Size TranslateWindowSizeToXWindowSize(CreateParams cp)
	{
		return default(Size);
	}

	internal static Size TranslateWindowSizeToXWindowSize(CreateParams cp, Size size)
	{
		return default(Size);
	}

	internal static Size TranslateXWindowSizeToWindowSize(CreateParams cp, int xWidth, int xHeight)
	{
		return default(Size);
	}

	internal static Point GetTopLevelWindowLocation(Hwnd hwnd)
	{
		return default(Point);
	}

	private void DeriveStyles(int Style, int ExStyle, out FormBorderStyle border_style, out bool border_static, out TitleStyle title_style, out int caption_height, out int tool_caption_height)
	{
		border_style = default(FormBorderStyle);
		border_static = default(bool);
		title_style = default(TitleStyle);
		caption_height = default(int);
		tool_caption_height = default(int);
	}

	private void SetHwndStyles(Hwnd hwnd, CreateParams cp)
	{
	}

	private void SetWMStyles(Hwnd hwnd, CreateParams cp)
	{
	}

	private void SetIcon(Hwnd hwnd, Icon icon)
	{
	}

	private void WakeupMain()
	{
	}

	private XEventQueue ThreadQueue(Thread thread)
	{
		return null;
	}

	private void TranslatePropertyToClipboard(IntPtr property)
	{
	}

	private void AddExpose(Hwnd hwnd, bool client, int x, int y, int width, int height)
	{
	}

	private static Hwnd.Borders FrameExtents(IntPtr window)
	{
		return default(Hwnd.Borders);
	}

	private void AddConfigureNotify(XEvent xevent)
	{
	}

	private void ShowCaret()
	{
	}

	private void HideCaret()
	{
	}

	private int NextTimeout(ArrayList timers, DateTime now)
	{
		return 0;
	}

	private void CheckTimers(ArrayList timers, DateTime now)
	{
	}

	private void WaitForHwndMessage(Hwnd hwnd, Msg message)
	{
	}

	private void WaitForHwndMessage(Hwnd hwnd, Msg message, bool process)
	{
	}

	private void MapWindow(Hwnd hwnd, WindowType windows)
	{
	}

	private void UnmapWindow(Hwnd hwnd, WindowType windows)
	{
	}

	private void UpdateMessageQueue(XEventQueue queue)
	{
	}

	private IntPtr GetMousewParam(int Delta)
	{
		return (IntPtr)0;
	}

	private IntPtr XGetParent(IntPtr handle)
	{
		return (IntPtr)0;
	}

	private int HandleError(IntPtr display, ref XErrorEvent error_event)
	{
		return 0;
	}

	private void AccumulateDestroyedHandles(Control c, ArrayList list)
	{
	}

	private void CleanupCachedWindows(Hwnd hwnd)
	{
	}

	private void PerformNCCalc(Hwnd hwnd)
	{
	}

	private void MouseHover(object sender, EventArgs e)
	{
	}

	private void CaretCallback(object sender, EventArgs e)
	{
	}

	internal override IntPtr InitializeDriver()
	{
		return (IntPtr)0;
	}

	internal override void Activate(IntPtr handle)
	{
	}

	internal override void AudibleAlert(AlertType alert)
	{
	}

	internal override void CaretVisible(IntPtr handle, bool visible)
	{
	}

	internal override bool CalculateWindowRect(ref Rectangle ClientRect, CreateParams cp, Menu menu, out Rectangle WindowRect)
	{
		WindowRect = default(Rectangle);
		return false;
	}

	internal override void ClientToScreen(IntPtr handle, ref int x, ref int y)
	{
	}

	internal override int[] ClipboardAvailableFormats(IntPtr handle)
	{
		return null;
	}

	internal override void ClipboardClose(IntPtr handle)
	{
	}

	internal override int ClipboardGetID(IntPtr handle, string format)
	{
		return 0;
	}

	internal override IntPtr ClipboardOpen(bool primary_selection)
	{
		return (IntPtr)0;
	}

	internal override object ClipboardRetrieve(IntPtr handle, int type, XplatUI.ClipboardToObject converter)
	{
		return null;
	}

	internal override void ClipboardStore(IntPtr handle, object obj, int type, XplatUI.ObjectToClipboard converter)
	{
	}

	internal override void CreateCaret(IntPtr handle, int width, int height)
	{
	}

	internal override IntPtr CreateWindow(CreateParams cp)
	{
		return (IntPtr)0;
	}

	internal override IntPtr DefineCursor(Bitmap bitmap, Bitmap mask, Color cursor_pixel, Color mask_pixel, int xHotSpot, int yHotSpot)
	{
		return (IntPtr)0;
	}

	internal override IntPtr DefineStdCursor(StdCursor id)
	{
		return (IntPtr)0;
	}

	internal static CursorFontShape StdCursorToFontShape(StdCursor id)
	{
		return default(CursorFontShape);
	}

	internal override IntPtr DefWndProc(ref Message msg)
	{
		return (IntPtr)0;
	}

	internal override void DestroyCaret(IntPtr handle)
	{
	}

	internal override void DestroyWindow(IntPtr handle)
	{
	}

	internal override IntPtr DispatchMessage(ref MSG msg)
	{
		return (IntPtr)0;
	}

	private IntPtr GetReversibleControlGC(Control control, int line_width)
	{
		return (IntPtr)0;
	}

	internal override void DrawReversibleRectangle(IntPtr handle, Rectangle rect, int line_width)
	{
	}

	internal override void DoEvents()
	{
	}

	internal override void EnableWindow(IntPtr handle, bool Enable)
	{
	}

	internal override void EndLoop(Thread thread)
	{
	}

	internal override IntPtr GetActive()
	{
		return (IntPtr)0;
	}

	internal override void GetCursorInfo(IntPtr cursor, out int width, out int height, out int hotspot_x, out int hotspot_y)
	{
		width = default(int);
		height = default(int);
		hotspot_x = default(int);
		hotspot_y = default(int);
	}

	internal override void GetDisplaySize(out Size size)
	{
		size = default(Size);
	}

	internal override SizeF GetAutoScaleSize(Font font)
	{
		return default(SizeF);
	}

	internal override IntPtr GetParent(IntPtr handle)
	{
		return (IntPtr)0;
	}

	internal override IntPtr GetPreviousWindow(IntPtr handle)
	{
		return (IntPtr)0;
	}

	internal override void GetCursorPos(IntPtr handle, out int x, out int y)
	{
		x = default(int);
		y = default(int);
	}

	internal override IntPtr GetFocus()
	{
		return (IntPtr)0;
	}

	internal override bool GetFontMetrics(Graphics g, Font font, out int ascent, out int descent)
	{
		ascent = default(int);
		descent = default(int);
		return false;
	}

	internal override Point GetMenuOrigin(IntPtr handle)
	{
		return default(Point);
	}

	[System.MonoTODO("Implement filtering")]
	internal override bool GetMessage(object queue_id, ref MSG msg, IntPtr handle, int wFilterMin, int wFilterMax)
	{
		return false;
	}

	private HitTest NCHitTest(Hwnd hwnd, int x, int y)
	{
		return default(HitTest);
	}

	internal override void GetWindowPos(IntPtr handle, bool is_toplevel, out int x, out int y, out int width, out int height, out int client_width, out int client_height)
	{
		x = default(int);
		y = default(int);
		width = default(int);
		height = default(int);
		client_width = default(int);
		client_height = default(int);
	}

	internal override FormWindowState GetWindowState(IntPtr handle)
	{
		return default(FormWindowState);
	}

	private FormWindowState UpdateWindowState(IntPtr handle)
	{
		return default(FormWindowState);
	}

	internal override void GrabInfo(out IntPtr handle, out bool GrabConfined, out Rectangle GrabArea)
	{
		handle = default(IntPtr);
		GrabConfined = default(bool);
		GrabArea = default(Rectangle);
	}

	internal override void GrabWindow(IntPtr handle, IntPtr confine_to_handle)
	{
	}

	internal override void UngrabWindow(IntPtr hwnd)
	{
	}

	private void WindowUngrabbed(IntPtr hwnd)
	{
	}

	internal override void Invalidate(IntPtr handle, Rectangle rc, bool clear)
	{
	}

	internal override void InvalidateNC(IntPtr handle)
	{
	}

	internal override bool IsEnabled(IntPtr handle)
	{
		return false;
	}

	internal override void KillTimer(Timer timer)
	{
	}

	internal override void MenuToScreen(IntPtr handle, ref int x, ref int y)
	{
	}

	internal override PaintEventArgs PaintEventStart(ref Message msg, IntPtr handle, bool client)
	{
		return null;
	}

	internal override void PaintEventEnd(ref Message msg, IntPtr handle, bool client)
	{
	}

	[System.MonoTODO("Implement filtering and PM_NOREMOVE")]
	internal override bool PeekMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax, uint flags)
	{
		return false;
	}

	internal override bool PostMessage(IntPtr handle, Msg message, IntPtr wparam, IntPtr lparam)
	{
		return false;
	}

	internal override void PostQuitMessage(int exitCode)
	{
	}

	internal override void RequestAdditionalWM_NCMessages(IntPtr hwnd, bool hover, bool leave)
	{
	}

	internal override void RequestNCRecalc(IntPtr handle)
	{
	}

	internal override void ResetMouseHover(IntPtr handle)
	{
	}

	internal override void ScreenToClient(IntPtr handle, ref int x, ref int y)
	{
	}

	internal override void ScreenToMenu(IntPtr handle, ref int x, ref int y)
	{
	}

	private bool GraphicsExposePredicate(IntPtr display, ref XEvent xevent, IntPtr arg)
	{
		return false;
	}

	private void ProcessGraphicsExpose(Hwnd hwnd)
	{
	}

	internal override void ScrollWindow(IntPtr handle, Rectangle area, int XAmount, int YAmount, bool with_children)
	{
	}

	internal override void ScrollWindow(IntPtr handle, int XAmount, int YAmount, bool with_children)
	{
	}

	private Rectangle GetDirtyArea(Rectangle total_area, Rectangle valid_area, int XAmount, int YAmount)
	{
		return default(Rectangle);
	}

	private Rectangle GetTotalVisibleArea(IntPtr handle)
	{
		return default(Rectangle);
	}

	internal override void SendAsyncMethod(AsyncMethodData method)
	{
	}

	internal override IntPtr SendMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam)
	{
		return (IntPtr)0;
	}

	internal override void SetAllowDrop(IntPtr handle, bool value)
	{
	}

	internal override void SetBorderStyle(IntPtr handle, FormBorderStyle border_style)
	{
	}

	internal override void SetCaretPos(IntPtr handle, int x, int y)
	{
	}

	internal override void SetClipRegion(IntPtr handle, Region region)
	{
	}

	internal override void SetCursor(IntPtr handle, IntPtr cursor)
	{
	}

	private void QueryPointer(IntPtr display, IntPtr w, out IntPtr root, out IntPtr child, out int root_x, out int root_y, out int child_x, out int child_y, out int mask)
	{
		root = default(IntPtr);
		child = default(IntPtr);
		root_x = default(int);
		root_y = default(int);
		child_x = default(int);
		child_y = default(int);
		mask = default(int);
	}

	internal override void SetCursorPos(IntPtr handle, int x, int y)
	{
	}

	internal override void SetFocus(IntPtr handle)
	{
	}

	internal override void SetIcon(IntPtr handle, Icon icon)
	{
	}

	internal override void SetMenu(IntPtr handle, Menu menu)
	{
	}

	internal override void SetModal(IntPtr handle, bool Modal)
	{
	}

	internal override IntPtr SetParent(IntPtr handle, IntPtr parent)
	{
		return (IntPtr)0;
	}

	internal override void SetTimer(Timer timer)
	{
	}

	internal override bool SetTopmost(IntPtr handle, bool enabled)
	{
		return false;
	}

	internal override bool SetOwner(IntPtr handle, IntPtr handle_owner)
	{
		return false;
	}

	internal override bool SetVisible(IntPtr handle, bool visible, bool activate)
	{
		return false;
	}

	internal override void SetWindowMinMax(IntPtr handle, Rectangle maximized, Size min, Size max)
	{
	}

	internal void SetWindowMinMax(IntPtr handle, Rectangle maximized, Size min, Size max, CreateParams cp)
	{
	}

	internal override void SetWindowPos(IntPtr handle, int x, int y, int width, int height)
	{
	}

	internal override void SetWindowState(IntPtr handle, FormWindowState state)
	{
	}

	internal override void SetWindowStyle(IntPtr handle, CreateParams cp)
	{
	}

	internal override void SetWindowTransparency(IntPtr handle, double transparency, Color key)
	{
	}

	internal override bool SetZOrder(IntPtr handle, IntPtr after_handle, bool top, bool bottom)
	{
		return false;
	}

	internal override object StartLoop(Thread thread)
	{
		return null;
	}

	internal override TransparencySupport SupportsTransparency()
	{
		return default(TransparencySupport);
	}

	internal override bool Text(IntPtr handle, string text)
	{
		return false;
	}

	internal override bool TranslateMessage(ref MSG msg)
	{
		return false;
	}

	internal override void UpdateWindow(IntPtr handle)
	{
	}

	internal override void CreateOffscreenDrawable(IntPtr handle, int width, int height, out object offscreen_drawable)
	{
		offscreen_drawable = null;
	}

	internal override void DestroyOffscreenDrawable(object offscreen_drawable)
	{
	}

	internal override Graphics GetOffscreenGraphics(object offscreen_drawable)
	{
		return null;
	}

	internal override void BlitFromOffscreen(IntPtr dest_handle, Graphics dest_dc, object offscreen_drawable, Graphics offscreen_dc, Rectangle r)
	{
	}

	[PreserveSig]
	internal static extern IntPtr XOpenDisplay(IntPtr display);

	[PreserveSig]
	internal static extern int XCloseDisplay(IntPtr display);

	[PreserveSig]
	internal static extern IntPtr XSynchronize(IntPtr display, bool onoff);

	[PreserveSig]
	internal static extern IntPtr XCreateWindow(IntPtr display, IntPtr parent, int x, int y, int width, int height, int border_width, int depth, int xclass, IntPtr visual, UIntPtr valuemask, ref XSetWindowAttributes attributes);

	[PreserveSig]
	internal static extern IntPtr XCreateSimpleWindow(IntPtr display, IntPtr parent, int x, int y, int width, int height, int border_width, UIntPtr border, UIntPtr background);

	[PreserveSig]
	internal static extern int XMapWindow(IntPtr display, IntPtr window);

	[PreserveSig]
	internal static extern int XUnmapWindow(IntPtr display, IntPtr window);

	[PreserveSig]
	internal static extern IntPtr XRootWindow(IntPtr display, int screen_number);

	[PreserveSig]
	internal static extern IntPtr XNextEvent(IntPtr display, ref XEvent xevent);

	[PreserveSig]
	internal static extern int XConnectionNumber(IntPtr display);

	[PreserveSig]
	internal static extern int XPending(IntPtr display);

	[PreserveSig]
	internal static extern IntPtr XSelectInput(IntPtr display, IntPtr window, IntPtr mask);

	[PreserveSig]
	internal static extern int XDestroyWindow(IntPtr display, IntPtr window);

	[PreserveSig]
	internal static extern int XReparentWindow(IntPtr display, IntPtr window, IntPtr parent, int x, int y);

	[PreserveSig]
	private static extern int XMoveResizeWindow(IntPtr display, IntPtr window, int x, int y, int width, int height);

	internal static int MoveResizeWindow(IntPtr display, IntPtr window, int x, int y, int width, int height)
	{
		return 0;
	}

	[PreserveSig]
	internal static extern int XGetWindowAttributes(IntPtr display, IntPtr window, ref XWindowAttributes attributes);

	[PreserveSig]
	internal static extern int XFlush(IntPtr display);

	[PreserveSig]
	internal static extern int XStoreName(IntPtr display, IntPtr window, string window_name);

	[PreserveSig]
	internal static extern int XSendEvent(IntPtr display, IntPtr window, bool propagate, IntPtr event_mask, ref XEvent send_event);

	[PreserveSig]
	internal static extern int XQueryTree(IntPtr display, IntPtr window, out IntPtr root_return, out IntPtr parent_return, out IntPtr children_return, out int nchildren_return);

	[PreserveSig]
	internal static extern int XFree(IntPtr data);

	[PreserveSig]
	internal static extern int XRaiseWindow(IntPtr display, IntPtr window);

	[PreserveSig]
	internal static extern uint XLowerWindow(IntPtr display, IntPtr window);

	[PreserveSig]
	internal static extern uint XConfigureWindow(IntPtr display, IntPtr window, ChangeWindowFlags value_mask, ref XWindowChanges values);

	[PreserveSig]
	internal static extern IntPtr XInternAtom(IntPtr display, string atom_name, bool only_if_exists);

	[PreserveSig]
	internal static extern int XInternAtoms(IntPtr display, string[] atom_names, int atom_count, bool only_if_exists, IntPtr[] atoms);

	[PreserveSig]
	internal static extern int XSetWMProtocols(IntPtr display, IntPtr window, IntPtr[] protocols, int count);

	[PreserveSig]
	internal static extern int XGrabPointer(IntPtr display, IntPtr window, bool owner_events, EventMask event_mask, GrabMode pointer_mode, GrabMode keyboard_mode, IntPtr confine_to, IntPtr cursor, IntPtr timestamp);

	[PreserveSig]
	internal static extern int XUngrabPointer(IntPtr display, IntPtr timestamp);

	[PreserveSig]
	internal static extern bool XQueryPointer(IntPtr display, IntPtr window, out IntPtr root, out IntPtr child, out int root_x, out int root_y, out int win_x, out int win_y, out int keys_buttons);

	[PreserveSig]
	internal static extern bool XTranslateCoordinates(IntPtr display, IntPtr src_w, IntPtr dest_w, int src_x, int src_y, out int intdest_x_return, out int dest_y_return, out IntPtr child_return);

	[PreserveSig]
	internal static extern bool XGetGeometry(IntPtr display, IntPtr window, out IntPtr root, out int x, out int y, out int width, out int height, out int border_width, out int depth);

	[PreserveSig]
	internal static extern uint XWarpPointer(IntPtr display, IntPtr src_w, IntPtr dest_w, int src_x, int src_y, uint src_width, uint src_height, int dest_x, int dest_y);

	[PreserveSig]
	internal static extern int XDefaultScreen(IntPtr display);

	[PreserveSig]
	internal static extern IntPtr XDefaultColormap(IntPtr display, int screen_number);

	[PreserveSig]
	internal static extern int XAllocColor(IntPtr display, IntPtr Colormap, ref XColor colorcell_def);

	[PreserveSig]
	internal static extern int XSetTransientForHint(IntPtr display, IntPtr window, IntPtr prop_window);

	[PreserveSig]
	internal static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, ref MotifWmHints data, int nelements);

	[PreserveSig]
	internal static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, ref IntPtr value, int nelements);

	[PreserveSig]
	internal static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, int[] data, int nelements);

	[PreserveSig]
	internal static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, IntPtr[] data, int nelements);

	[PreserveSig]
	internal static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, IntPtr atoms, int nelements);

	[PreserveSig]
	internal static extern int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, string text, int text_length);

	[PreserveSig]
	internal static extern int XDeleteProperty(IntPtr display, IntPtr window, IntPtr property);

	[PreserveSig]
	internal static extern IntPtr XCreateGC(IntPtr display, IntPtr window, IntPtr valuemask, ref XGCValues values);

	[PreserveSig]
	internal static extern int XFreeGC(IntPtr display, IntPtr gc);

	[PreserveSig]
	internal static extern int XSetFunction(IntPtr display, IntPtr gc, GXFunction function);

	[PreserveSig]
	internal static extern int XDrawLine(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int x2, int y2);

	[PreserveSig]
	internal static extern int XDrawRectangle(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int width, int height);

	[PreserveSig]
	internal static extern int XCopyArea(IntPtr display, IntPtr src, IntPtr dest, IntPtr gc, int src_x, int src_y, int width, int height, int dest_x, int dest_y);

	[PreserveSig]
	internal static extern int XGetWindowProperty(IntPtr display, IntPtr window, IntPtr atom, IntPtr long_offset, IntPtr long_length, bool delete, IntPtr req_type, out IntPtr actual_type, out int actual_format, out IntPtr nitems, out IntPtr bytes_after, ref IntPtr prop);

	[PreserveSig]
	internal static extern int XIconifyWindow(IntPtr display, IntPtr window, int screen_number);

	[PreserveSig]
	internal static extern int XDefineCursor(IntPtr display, IntPtr window, IntPtr cursor);

	[PreserveSig]
	internal static extern int XUndefineCursor(IntPtr display, IntPtr window);

	[PreserveSig]
	internal static extern IntPtr XCreateFontCursor(IntPtr display, CursorFontShape shape);

	[PreserveSig]
	internal static extern IntPtr XCreatePixmapCursor(IntPtr display, IntPtr source, IntPtr mask, ref XColor foreground_color, ref XColor background_color, int x_hot, int y_hot);

	[PreserveSig]
	internal static extern IntPtr XCreatePixmapFromBitmapData(IntPtr display, IntPtr drawable, byte[] data, int width, int height, IntPtr fg, IntPtr bg, int depth);

	[PreserveSig]
	internal static extern IntPtr XCreatePixmap(IntPtr display, IntPtr d, int width, int height, int depth);

	[PreserveSig]
	internal static extern IntPtr XFreePixmap(IntPtr display, IntPtr pixmap);

	[PreserveSig]
	internal static extern int XQueryBestCursor(IntPtr display, IntPtr drawable, int width, int height, out int best_width, out int best_height);

	[PreserveSig]
	internal static extern int XQueryExtension(IntPtr display, string extension_name, ref int major, ref int first_event, ref int first_error);

	[PreserveSig]
	internal static extern IntPtr XWhitePixel(IntPtr display, int screen_no);

	[PreserveSig]
	internal static extern IntPtr XBlackPixel(IntPtr display, int screen_no);

	[PreserveSig]
	internal static extern void XGrabServer(IntPtr display);

	[PreserveSig]
	internal static extern void XUngrabServer(IntPtr display);

	[PreserveSig]
	internal static extern void XGetWMNormalHints(IntPtr display, IntPtr window, ref XSizeHints hints, out IntPtr supplied_return);

	[PreserveSig]
	internal static extern void XSetWMNormalHints(IntPtr display, IntPtr window, ref XSizeHints hints);

	[PreserveSig]
	internal static extern void XSetZoomHints(IntPtr display, IntPtr window, ref XSizeHints hints);

	[PreserveSig]
	internal static extern void XSetWMHints(IntPtr display, IntPtr window, ref XWMHints wmhints);

	[PreserveSig]
	internal static extern IntPtr XSetErrorHandler(XErrorHandler error_handler);

	[PreserveSig]
	internal static extern IntPtr XGetErrorText(IntPtr display, byte code, StringBuilder buffer, int length);

	[PreserveSig]
	internal static extern int XInitThreads();

	[PreserveSig]
	internal static extern int XConvertSelection(IntPtr display, IntPtr selection, IntPtr target, IntPtr property, IntPtr requestor, IntPtr time);

	[PreserveSig]
	internal static extern IntPtr XGetSelectionOwner(IntPtr display, IntPtr selection);

	[PreserveSig]
	internal static extern int XSetSelectionOwner(IntPtr display, IntPtr selection, IntPtr owner, IntPtr time);

	[PreserveSig]
	internal static extern int XSetPlaneMask(IntPtr display, IntPtr gc, IntPtr mask);

	[PreserveSig]
	internal static extern int XSetForeground(IntPtr display, IntPtr gc, UIntPtr foreground);

	[PreserveSig]
	internal static extern int XSetBackground(IntPtr display, IntPtr gc, UIntPtr background);

	[PreserveSig]
	internal static extern int XBell(IntPtr display, int percent);

	[PreserveSig]
	internal static extern int XChangeActivePointerGrab(IntPtr display, EventMask event_mask, IntPtr cursor, IntPtr time);

	[PreserveSig]
	internal static extern bool XFilterEvent(ref XEvent xevent, IntPtr window);

	[PreserveSig]
	internal static extern void XkbSetDetectableAutoRepeat(IntPtr display, bool detectable, IntPtr supported);

	[PreserveSig]
	internal static extern void XPeekEvent(IntPtr display, ref XEvent xevent);

	[PreserveSig]
	internal static extern void XIfEvent(IntPtr display, ref XEvent xevent, Delegate event_predicate, IntPtr arg);
}
