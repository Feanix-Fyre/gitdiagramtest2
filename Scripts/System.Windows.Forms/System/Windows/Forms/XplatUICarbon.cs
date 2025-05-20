using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms.CarbonInternal;

namespace System.Windows.Forms;

internal class XplatUICarbon : XplatUIDriver
{
	private static XplatUICarbon Instance;

	private static int RefCount;

	private static bool themes_enabled;

	internal static IntPtr FocusWindow;

	internal static IntPtr ActiveWindow;

	internal static IntPtr ReverseWindow;

	internal static IntPtr CaretWindow;

	internal static Hwnd MouseHwnd;

	internal static MouseButtons MouseState;

	internal static Hover Hover;

	internal static HwndDelegate HwndDelegate;

	internal Point mouse_position;

	internal ApplicationHandler ApplicationHandler;

	internal ControlHandler ControlHandler;

	internal HIObjectHandler HIObjectHandler;

	internal KeyboardHandler KeyboardHandler;

	internal MouseHandler MouseHandler;

	internal WindowHandler WindowHandler;

	internal static GrabStruct Grab;

	internal static Caret Caret;

	private static Dnd Dnd;

	private static Hashtable WindowMapping;

	private static Hashtable HandleMapping;

	private static IntPtr FosterParent;

	private static IntPtr Subclass;

	private static int MenuBarHeight;

	internal static ArrayList UtilityWindows;

	private static Queue MessageQueue;

	private static bool GetMessageResult;

	private static bool ReverseWindowMapped;

	private ArrayList TimerList;

	private static bool in_doevents;

	private static readonly object instancelock;

	private static readonly object queuelock;

	private EventHandler Idle;

	internal override Point MousePosition => default(Point);

	internal override int CaptionHeight => 0;

	internal override Size DragSize => default(Size);

	internal override Size FrameBorderSize => default(Size);

	internal override bool MenuAccessKeysUnderlined => false;

	internal override Size MinimumWindowSize => default(Size);

	internal override Keys ModifierKeys => default(Keys);

	internal override Rectangle VirtualScreen => default(Rectangle);

	internal override Rectangle WorkingArea => default(Rectangle);

	internal override bool ThemesEnabled => false;

	private XplatUICarbon()
	{
	}

	~XplatUICarbon()
	{
	}

	public static XplatUICarbon GetInstance()
	{
		return null;
	}

	internal void AddExpose(Hwnd hwnd, bool client, HIRect rect)
	{
	}

	internal void FlushQueue()
	{
	}

	internal static Rectangle[] GetClippingRectangles(IntPtr handle)
	{
		return null;
	}

	internal IntPtr GetMousewParam(int Delta)
	{
		return (IntPtr)0;
	}

	internal IntPtr HandleToWindow(IntPtr handle)
	{
		return (IntPtr)0;
	}

	internal void Initialize()
	{
	}

	internal void PerformNCCalc(Hwnd hwnd)
	{
	}

	internal void ScreenToClient(IntPtr handle, ref QDPoint point)
	{
	}

	internal static Rectangle TranslateClientRectangleToQuartzClientRectangle(Hwnd hwnd)
	{
		return default(Rectangle);
	}

	internal static Rectangle TranslateClientRectangleToQuartzClientRectangle(Hwnd hwnd, Control ctrl)
	{
		return default(Rectangle);
	}

	internal static Size TranslateWindowSizeToQuartzWindowSize(CreateParams cp)
	{
		return default(Size);
	}

	internal static Size TranslateWindowSizeToQuartzWindowSize(CreateParams cp, Size size)
	{
		return default(Size);
	}

	internal static Size TranslateQuartzWindowSizeToWindowSize(CreateParams cp, int width, int height)
	{
		return default(Size);
	}

	private void CaretCallback(object sender, EventArgs e)
	{
	}

	private void HoverCallback(object sender, EventArgs e)
	{
	}

	private Point ConvertScreenPointToClient(IntPtr handle, Point point)
	{
		return default(Point);
	}

	private Point ConvertClientPointToScreen(IntPtr handle, Point point)
	{
		return default(Point);
	}

	private double NextTimeout()
	{
		return 0.0;
	}

	private void CheckTimers(DateTime now)
	{
	}

	private void WaitForHwndMessage(Hwnd hwnd, Msg message)
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

	private void ShowCaret()
	{
	}

	private void HideCaret()
	{
	}

	private void AccumulateDestroyedHandles(Control c, ArrayList list)
	{
	}

	private void CleanupCachedWindows(Hwnd hwnd)
	{
	}

	private void AddExpose(Hwnd hwnd, bool client, int x, int y, int width, int height)
	{
	}

	internal void EnqueueMessage(MSG msg)
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

	internal override void CaretVisible(IntPtr hwnd, bool visible)
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

	internal override void MenuToScreen(IntPtr handle, ref int x, ref int y)
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

	internal override void CreateCaret(IntPtr hwnd, int width, int height)
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

	internal override IntPtr DefWndProc(ref Message msg)
	{
		return (IntPtr)0;
	}

	internal override void DestroyCaret(IntPtr hwnd)
	{
	}

	internal override void DestroyWindow(IntPtr handle)
	{
	}

	internal override IntPtr DispatchMessage(ref MSG msg)
	{
		return (IntPtr)0;
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

	internal void Exit()
	{
	}

	internal override IntPtr GetActive()
	{
		return (IntPtr)0;
	}

	[System.MonoTODO]
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

	internal override bool GetMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax)
	{
		return false;
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

	internal override FormWindowState GetWindowState(IntPtr hwnd)
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

	internal override PaintEventArgs PaintEventStart(ref Message msg, IntPtr handle, bool client)
	{
		return null;
	}

	internal override void PaintEventEnd(ref Message msg, IntPtr handle, bool client)
	{
	}

	internal override bool PeekMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax, uint flags)
	{
		return false;
	}

	internal override bool PostMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam)
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

	[System.MonoTODO]
	internal override void ResetMouseHover(IntPtr handle)
	{
	}

	internal override void ScreenToClient(IntPtr handle, ref int x, ref int y)
	{
	}

	internal override void ScreenToMenu(IntPtr handle, ref int x, ref int y)
	{
	}

	internal override void ScrollWindow(IntPtr handle, Rectangle area, int XAmount, int YAmount, bool clear)
	{
	}

	internal override void ScrollWindow(IntPtr handle, int XAmount, int YAmount, bool clear)
	{
	}

	[System.MonoTODO]
	internal override void SendAsyncMethod(AsyncMethodData method)
	{
	}

	[System.MonoTODO]
	internal override IntPtr SendMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam)
	{
		return (IntPtr)0;
	}

	internal override void SetCaretPos(IntPtr hwnd, int x, int y)
	{
	}

	internal override void SetClipRegion(IntPtr hwnd, Region region)
	{
	}

	internal override void SetCursor(IntPtr window, IntPtr cursor)
	{
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

	internal override bool SetTopmost(IntPtr hWnd, bool Enabled)
	{
		return false;
	}

	internal override bool SetOwner(IntPtr hWnd, IntPtr hWndOwner)
	{
		return false;
	}

	internal override bool SetVisible(IntPtr handle, bool visible, bool activate)
	{
		return false;
	}

	internal override void SetAllowDrop(IntPtr handle, bool value)
	{
	}

	internal override void SetBorderStyle(IntPtr handle, FormBorderStyle border_style)
	{
	}

	internal override void SetMenu(IntPtr handle, Menu menu)
	{
	}

	internal override void SetWindowMinMax(IntPtr handle, Rectangle maximized, Size min, Size max)
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

	internal override TransparencySupport SupportsTransparency()
	{
		return default(TransparencySupport);
	}

	internal override bool SetZOrder(IntPtr handle, IntPtr after_handle, bool Top, bool Bottom)
	{
		return false;
	}

	internal override object StartLoop(Thread thread)
	{
		return null;
	}

	internal override bool Text(IntPtr handle, string text)
	{
		return false;
	}

	internal override void UpdateWindow(IntPtr handle)
	{
	}

	internal override bool TranslateMessage(ref MSG msg)
	{
		return false;
	}

	internal void SizeWindow(Rectangle rect, IntPtr window)
	{
	}

	internal override void DrawReversibleRectangle(IntPtr handle, Rectangle rect, int line_width)
	{
	}

	internal override SizeF GetAutoScaleSize(Font font)
	{
		return default(SizeF);
	}

	[PreserveSig]
	private static extern int HIViewConvertPoint(ref CGPoint point, IntPtr pView, IntPtr cView);

	[PreserveSig]
	private static extern int HIViewChangeFeatures(IntPtr aView, ulong bitsin, ulong bitsout);

	[PreserveSig]
	private static extern int HIViewFindByID(IntPtr rootWnd, HIViewID id, ref IntPtr outPtr);

	[PreserveSig]
	private static extern int HIGrowBoxViewSetTransparent(IntPtr GrowBox, bool transparency);

	[PreserveSig]
	private static extern IntPtr HIViewGetRoot(IntPtr hWnd);

	[PreserveSig]
	private static extern int HIObjectCreate(IntPtr cfStr, uint what, ref IntPtr hwnd);

	[PreserveSig]
	private static extern int HIObjectRegisterSubclass(IntPtr classid, IntPtr superclassid, uint options, EventDelegate upp, uint count, EventTypeSpec[] list, IntPtr state, ref IntPtr cls);

	[PreserveSig]
	private static extern int HIViewPlaceInSuperviewAt(IntPtr view, float x, float y);

	[PreserveSig]
	private static extern int HIViewAddSubview(IntPtr parentHnd, IntPtr childHnd);

	[PreserveSig]
	private static extern IntPtr HIViewGetPreviousView(IntPtr aView);

	[PreserveSig]
	private static extern IntPtr HIViewGetSuperview(IntPtr aView);

	[PreserveSig]
	private static extern int HIViewRemoveFromSuperview(IntPtr aView);

	[PreserveSig]
	private static extern int HIViewSetVisible(IntPtr vHnd, bool visible);

	[PreserveSig]
	private static extern bool HIViewIsVisible(IntPtr vHnd);

	[PreserveSig]
	private static extern int HIViewSetZOrder(IntPtr hWnd, int cmd, IntPtr oHnd);

	[PreserveSig]
	private static extern int HIViewNewTrackingArea(IntPtr inView, IntPtr inShape, ulong inID, ref IntPtr outRef);

	[PreserveSig]
	private static extern IntPtr HIViewGetWindow(IntPtr aView);

	[PreserveSig]
	private static extern int HIViewSetFrame(IntPtr view_handle, ref HIRect bounds);

	[PreserveSig]
	private static extern void SetRect(ref Rect r, short left, short top, short right, short bottom);

	[PreserveSig]
	private static extern int ActivateWindow(IntPtr windowHnd, bool inActivate);

	[PreserveSig]
	private static extern int SetAutomaticControlDragTrackingEnabledForWindow(IntPtr window, bool enabled);

	[PreserveSig]
	private static extern IntPtr GetEventDispatcherTarget();

	[PreserveSig]
	private static extern int SendEventToEventTarget(IntPtr evt, IntPtr target);

	[PreserveSig]
	private static extern int ReleaseEvent(IntPtr evt);

	[PreserveSig]
	private static extern int ReceiveNextEvent(uint evtCount, IntPtr evtTypes, double timeout, bool processEvt, ref IntPtr evt);

	[PreserveSig]
	private static extern bool IsWindowCollapsed(IntPtr hWnd);

	[PreserveSig]
	private static extern bool IsWindowInStandardState(IntPtr hWnd, IntPtr a, IntPtr b);

	[PreserveSig]
	private static extern void CollapseWindow(IntPtr hWnd, bool collapse);

	[PreserveSig]
	private static extern void ZoomWindow(IntPtr hWnd, short partCode, bool front);

	[PreserveSig]
	private static extern int GetWindowAttributes(IntPtr hWnd, ref WindowAttributes outAttributes);

	[PreserveSig]
	private static extern int ChangeWindowAttributes(IntPtr hWnd, WindowAttributes inAttributes, WindowAttributes outAttributes);

	[PreserveSig]
	internal static extern int GetGlobalMouse(ref QDPoint outData);

	[PreserveSig]
	private static extern int BeginAppModalStateForWindow(IntPtr window);

	[PreserveSig]
	private static extern int EndAppModalStateForWindow(IntPtr window);

	[PreserveSig]
	private static extern int CreateNewWindow(WindowClass klass, WindowAttributes attributes, ref Rect r, ref IntPtr window);

	[PreserveSig]
	private static extern int DisposeWindow(IntPtr wHnd);

	[PreserveSig]
	internal static extern int ShowWindow(IntPtr wHnd);

	[PreserveSig]
	internal static extern int HideWindow(IntPtr wHnd);

	[PreserveSig]
	internal static extern bool IsWindowVisible(IntPtr wHnd);

	[PreserveSig]
	private static extern int SetWindowBounds(IntPtr wHnd, uint reg, ref Rect rect);

	[PreserveSig]
	private static extern int GetWindowBounds(IntPtr wHnd, uint reg, ref Rect rect);

	[PreserveSig]
	private static extern int SetControlTitleWithCFString(IntPtr hWnd, IntPtr titleCFStr);

	[PreserveSig]
	private static extern int SetWindowTitleWithCFString(IntPtr hWnd, IntPtr titleCFStr);

	[PreserveSig]
	internal static extern IntPtr __CFStringMakeConstantString(string cString);

	[PreserveSig]
	private static extern short GetMBarHeight();

	[PreserveSig]
	private static extern void AlertSoundPlay();

	[PreserveSig]
	private static extern HIRect CGDisplayBounds(IntPtr displayID);

	[PreserveSig]
	private static extern IntPtr CGMainDisplayID();

	[PreserveSig]
	private static extern void CGDisplayMoveCursorToPoint(IntPtr display, CGPoint point);

	[PreserveSig]
	private static extern int GetCurrentProcess(ref ProcessSerialNumber psn);

	[PreserveSig]
	private static extern int TransformProcessType(ref ProcessSerialNumber psn, uint type);

	[PreserveSig]
	private static extern int SetFrontProcess(ref ProcessSerialNumber psn);

	[PreserveSig]
	private static extern IntPtr CGColorSpaceCreateDeviceRGB();

	[PreserveSig]
	private static extern IntPtr CGDataProviderCreateWithData(IntPtr info, IntPtr[] data, int size, IntPtr releasefunc);

	[PreserveSig]
	private static extern IntPtr CGImageCreate(int width, int height, int bitsPerComponent, int bitsPerPixel, int bytesPerRow, IntPtr colorspace, uint bitmapInfo, IntPtr provider, IntPtr decode, int shouldInterpolate, int intent);

	[PreserveSig]
	private static extern void SetApplicationDockTileImage(IntPtr imageRef);

	[PreserveSig]
	private static extern void RestoreApplicationDockTileImage();
}
