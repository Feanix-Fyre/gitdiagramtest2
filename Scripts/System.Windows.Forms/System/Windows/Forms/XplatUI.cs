using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Windows.Forms;

internal class XplatUI
{
	public class State
	{
		public static Keys ModifierKeys => default(Keys);
	}

	public delegate bool ClipboardToObject(int type, IntPtr data, out object obj);

	public delegate bool ObjectToClipboard(ref int type, object obj, out byte[] data);

	private static XplatUIDriver driver;

	private static string default_class_name;

	internal static ArrayList key_filters;

	public static bool RunningOnUnix => false;

	internal static string DefaultClassName => null;

	public static Size Border3DSize => default(Size);

	public static Size BorderSize => default(Size);

	public static Size CaptionButtonSize => default(Size);

	public static int CaptionHeight => 0;

	public static int DoubleClickTime => 0;

	public static Size DragSize => default(Size);

	public static Size FrameBorderSize => default(Size);

	public static int HorizontalScrollBarHeight => 0;

	public static bool MenuAccessKeysUnderlined => false;

	public static Size MenuButtonSize => default(Size);

	public static Size MinimizedWindowSize => default(Size);

	public static Size MinimumWindowSize => default(Size);

	public static Size MinimumFixedToolWindowSize => default(Size);

	public static Size MinimumSizeableToolWindowSize => default(Size);

	public static Size MinimumNoBorderWindowSize => default(Size);

	public static Size MinWindowTrackSize => default(Size);

	public static int MenuHeight => 0;

	public static bool RequiresPositiveClientAreaSize => false;

	public static bool UserClipWontExposeParent => false;

	public static int VerticalScrollBarWidth => 0;

	public static Rectangle VirtualScreen => default(Rectangle);

	public static Rectangle WorkingArea => default(Rectangle);

	public static bool ThemesEnabled => false;

	public static int ToolWindowCaptionHeight => 0;

	public static Size ToolWindowCaptionButtonSize => default(Size);

	static XplatUI()
	{
	}

	internal static void Activate(IntPtr handle)
	{
	}

	internal static void AudibleAlert(AlertType alert)
	{
	}

	internal static bool CalculateWindowRect(ref Rectangle ClientRect, CreateParams cp, Menu menu, out Rectangle WindowRect)
	{
		WindowRect = default(Rectangle);
		return false;
	}

	internal static void CaretVisible(IntPtr handle, bool visible)
	{
	}

	internal static void CreateCaret(IntPtr handle, int width, int height)
	{
	}

	internal static IntPtr CreateWindow(CreateParams cp)
	{
		return (IntPtr)0;
	}

	internal static void ClientToScreen(IntPtr handle, ref int x, ref int y)
	{
	}

	internal static int[] ClipboardAvailableFormats(IntPtr handle)
	{
		return null;
	}

	internal static void ClipboardClose(IntPtr handle)
	{
	}

	internal static int ClipboardGetID(IntPtr handle, string format)
	{
		return 0;
	}

	internal static IntPtr ClipboardOpen(bool primary_selection)
	{
		return (IntPtr)0;
	}

	internal static void ClipboardStore(IntPtr handle, object obj, int type, ObjectToClipboard converter)
	{
	}

	internal static object ClipboardRetrieve(IntPtr handle, int type, ClipboardToObject converter)
	{
		return null;
	}

	internal static IntPtr DefineCursor(Bitmap bitmap, Bitmap mask, Color cursor_pixel, Color mask_pixel, int xHotSpot, int yHotSpot)
	{
		return (IntPtr)0;
	}

	internal static IntPtr DefineStdCursor(StdCursor id)
	{
		return (IntPtr)0;
	}

	internal static IntPtr DefWndProc(ref Message msg)
	{
		return (IntPtr)0;
	}

	internal static void DestroyCaret(IntPtr handle)
	{
	}

	internal static void DestroyWindow(IntPtr handle)
	{
	}

	internal static IntPtr DispatchMessage(ref MSG msg)
	{
		return (IntPtr)0;
	}

	internal static void DoEvents()
	{
	}

	internal static void DrawReversibleRectangle(IntPtr handle, Rectangle rect, int line_width)
	{
	}

	internal static void EnableWindow(IntPtr handle, bool Enable)
	{
	}

	internal static void EndLoop(Thread thread)
	{
	}

	internal static IntPtr GetActive()
	{
		return (IntPtr)0;
	}

	internal static SizeF GetAutoScaleSize(Font font)
	{
		return default(SizeF);
	}

	internal static void GetCursorInfo(IntPtr cursor, out int width, out int height, out int hotspot_x, out int hotspot_y)
	{
		width = default(int);
		height = default(int);
		hotspot_x = default(int);
		hotspot_y = default(int);
	}

	internal static void GetCursorPos(IntPtr handle, out int x, out int y)
	{
		x = default(int);
		y = default(int);
	}

	internal static void GetDisplaySize(out Size size)
	{
		size = default(Size);
	}

	internal static IntPtr GetFocus()
	{
		return (IntPtr)0;
	}

	internal static bool GetFontMetrics(Graphics g, Font font, out int ascent, out int descent)
	{
		ascent = default(int);
		descent = default(int);
		return false;
	}

	internal static Point GetMenuOrigin(IntPtr handle)
	{
		return default(Point);
	}

	internal static bool GetMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax)
	{
		return false;
	}

	internal static IntPtr GetParent(IntPtr handle)
	{
		return (IntPtr)0;
	}

	internal static IntPtr GetPreviousWindow(IntPtr handle)
	{
		return (IntPtr)0;
	}

	internal static void GetWindowPos(IntPtr handle, bool is_toplevel, out int x, out int y, out int width, out int height, out int client_width, out int client_height)
	{
		x = default(int);
		y = default(int);
		width = default(int);
		height = default(int);
		client_width = default(int);
		client_height = default(int);
	}

	internal static FormWindowState GetWindowState(IntPtr handle)
	{
		return default(FormWindowState);
	}

	internal static void GrabInfo(out IntPtr handle, out bool GrabConfined, out Rectangle GrabArea)
	{
		handle = default(IntPtr);
		GrabConfined = default(bool);
		GrabArea = default(Rectangle);
	}

	internal static void GrabWindow(IntPtr handle, IntPtr ConfineToHwnd)
	{
	}

	internal static void Invalidate(IntPtr handle, Rectangle rc, bool clear)
	{
	}

	internal static void InvalidateNC(IntPtr handle)
	{
	}

	internal static bool IsEnabled(IntPtr handle)
	{
		return false;
	}

	internal static void KillTimer(Timer timer)
	{
	}

	internal static void PaintEventEnd(ref Message msg, IntPtr handle, bool client)
	{
	}

	internal static PaintEventArgs PaintEventStart(ref Message msg, IntPtr handle, bool client)
	{
		return null;
	}

	internal static bool PostMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam)
	{
		return false;
	}

	internal static void PostQuitMessage(int exitCode)
	{
	}

	internal static void RequestAdditionalWM_NCMessages(IntPtr handle, bool hover, bool leave)
	{
	}

	internal static void RequestNCRecalc(IntPtr handle)
	{
	}

	internal static void ResetMouseHover(IntPtr handle)
	{
	}

	internal static void ScreenToClient(IntPtr handle, ref int x, ref int y)
	{
	}

	internal static void ScreenToMenu(IntPtr handle, ref int x, ref int y)
	{
	}

	internal static void ScrollWindow(IntPtr handle, Rectangle rectangle, int XAmount, int YAmount, bool with_children)
	{
	}

	internal static void ScrollWindow(IntPtr handle, int XAmount, int YAmount, bool with_children)
	{
	}

	internal static void SendAsyncMethod(AsyncMethodData data)
	{
	}

	internal static IntPtr SendMessage(IntPtr handle, Msg message, IntPtr wParam, IntPtr lParam)
	{
		return (IntPtr)0;
	}

	internal static void SetAllowDrop(IntPtr handle, bool value)
	{
	}

	internal static void SetBorderStyle(IntPtr handle, FormBorderStyle border_style)
	{
	}

	internal static void SetCaretPos(IntPtr handle, int x, int y)
	{
	}

	internal static void SetClipRegion(IntPtr handle, Region region)
	{
	}

	internal static void SetCursor(IntPtr handle, IntPtr cursor)
	{
	}

	internal static void SetCursorPos(IntPtr handle, int x, int y)
	{
	}

	internal static void SetFocus(IntPtr handle)
	{
	}

	internal static void SetIcon(IntPtr handle, Icon icon)
	{
	}

	internal static void SetMenu(IntPtr handle, Menu menu)
	{
	}

	internal static void SetModal(IntPtr handle, bool Modal)
	{
	}

	internal static IntPtr SetParent(IntPtr handle, IntPtr hParent)
	{
		return (IntPtr)0;
	}

	internal static void SetTimer(Timer timer)
	{
	}

	internal static bool SetTopmost(IntPtr handle, bool Enabled)
	{
		return false;
	}

	internal static bool SetOwner(IntPtr handle, IntPtr hWndOwner)
	{
		return false;
	}

	internal static bool SetVisible(IntPtr handle, bool visible, bool activate)
	{
		return false;
	}

	internal static void SetWindowMinMax(IntPtr handle, Rectangle maximized, Size min, Size max)
	{
	}

	internal static void SetWindowPos(IntPtr handle, int x, int y, int width, int height)
	{
	}

	internal static void SetWindowState(IntPtr handle, FormWindowState state)
	{
	}

	internal static void SetWindowStyle(IntPtr handle, CreateParams cp)
	{
	}

	internal static void SetWindowTransparency(IntPtr handle, double transparency, Color key)
	{
	}

	internal static bool SetZOrder(IntPtr handle, IntPtr AfterhWnd, bool Top, bool Bottom)
	{
		return false;
	}

	internal static object StartLoop(Thread thread)
	{
		return null;
	}

	internal static TransparencySupport SupportsTransparency()
	{
		return default(TransparencySupport);
	}

	internal static bool Text(IntPtr handle, string text)
	{
		return false;
	}

	internal static bool TranslateMessage(ref MSG msg)
	{
		return false;
	}

	internal static void UngrabWindow(IntPtr handle)
	{
	}

	internal static void UpdateWindow(IntPtr handle)
	{
	}

	internal static void CreateOffscreenDrawable(IntPtr handle, int width, int height, out object offscreen_drawable)
	{
		offscreen_drawable = null;
	}

	internal static void DestroyOffscreenDrawable(object offscreen_drawable)
	{
	}

	internal static Graphics GetOffscreenGraphics(object offscreen_drawable)
	{
		return null;
	}

	internal static void BlitFromOffscreen(IntPtr dest_handle, Graphics dest_dc, object offscreen_drawable, Graphics offscreen_dc, Rectangle r)
	{
	}

	internal static bool FilterKey(KeyFilterData key)
	{
		return false;
	}

	[PreserveSig]
	private static extern int uname(IntPtr buf);
}
