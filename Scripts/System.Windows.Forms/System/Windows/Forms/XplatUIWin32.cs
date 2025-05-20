using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Windows.Forms;

internal class XplatUIWin32 : XplatUIDriver
{
	[StructLayout((LayoutKind)0, CharSet = CharSet.Unicode)]
	private struct WNDCLASS
	{
		internal int style;

		internal WndProc lpfnWndProc;

		internal int cbClsExtra;

		internal int cbWndExtra;

		internal IntPtr hInstance;

		internal IntPtr hIcon;

		internal IntPtr hCursor;

		internal IntPtr hbrBackground;

		internal string lpszMenuName;

		internal string lpszClassName;
	}

	internal struct RECT
	{
		internal int left;

		internal int top;

		internal int right;

		internal int bottom;

		public int Height => 0;

		public int Width => 0;

		public RECT(int left, int top, int right, int bottom)
		{
			this.left = 0;
			this.top = 0;
			this.right = 0;
			this.bottom = 0;
		}

		public Rectangle ToRectangle()
		{
			return default(Rectangle);
		}

		public static RECT FromRectangle(Rectangle rectangle)
		{
			return default(RECT);
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}

	internal enum SPIAction
	{
		SPI_GETACTIVEWINDOWTRACKING = 4096,
		SPI_GETACTIVEWNDTRKTIMEOUT = 8194,
		SPI_GETANIMATION = 72,
		SPI_GETCARETWIDTH = 8198,
		SPI_GETCOMBOBOXANIMATION = 4100,
		SPI_GETDRAGFULLWINDOWS = 38,
		SPI_GETDROPSHADOW = 4132,
		SPI_GETFONTSMOOTHING = 74,
		SPI_GETFONTSMOOTHINGCONTRAST = 8204,
		SPI_GETFONTSMOOTHINGTYPE = 8202,
		SPI_GETGRADIENTCAPTIONS = 4104,
		SPI_GETHOTTRACKING = 4110,
		SPI_GETICONTITLEWRAP = 25,
		SPI_GETKEYBOARDSPEED = 10,
		SPI_GETKEYBOARDDELAY = 22,
		SPI_GETKEYBOARDCUES = 4106,
		SPI_GETKEYBOARDPREF = 68,
		SPI_GETLISTBOXSMOOTHSCROLLING = 4102,
		SPI_GETMENUANIMATION = 4098,
		SPI_GETMENUDROPALIGNMENT = 27,
		SPI_GETMENUFADE = 4114,
		SPI_GETMENUSHOWDELAY = 106,
		SPI_GETMOUSESPEED = 112,
		SPI_GETSELECTIONFADE = 4116,
		SPI_GETSNAPTODEFBUTTON = 95,
		SPI_GETTOOLTIPANIMATION = 4118,
		SPI_GETWORKAREA = 48,
		SPI_GETMOUSEHOVERWIDTH = 98,
		SPI_GETMOUSEHOVERHEIGHT = 100,
		SPI_GETMOUSEHOVERTIME = 102,
		SPI_GETUIEFFECTS = 4158,
		SPI_GETWHEELSCROLLLINES = 104
	}

	internal enum WindowPlacementFlags
	{
		SW_HIDE = 0,
		SW_SHOWNORMAL = 1,
		SW_NORMAL = 1,
		SW_SHOWMINIMIZED = 2,
		SW_SHOWMAXIMIZED = 3,
		SW_MAXIMIZE = 3,
		SW_SHOWNOACTIVATE = 4,
		SW_SHOW = 5,
		SW_MINIMIZE = 6,
		SW_SHOWMINNOACTIVE = 7,
		SW_SHOWNA = 8,
		SW_RESTORE = 9,
		SW_SHOWDEFAULT = 10,
		SW_FORCEMINIMIZE = 11,
		SW_MAX = 11
	}

	internal struct NCCALCSIZE_PARAMS
	{
		internal RECT rgrc1;

		internal RECT rgrc2;

		internal RECT rgrc3;

		internal IntPtr lppos;
	}

	[Flags]
	private enum TMEFlags
	{
		TME_HOVER = 1,
		TME_LEAVE = 2,
		TME_NONCLIENT = 0x10,
		TME_QUERY = 0x40000000,
		TME_CANCEL = int.MinValue
	}

	private struct TRACKMOUSEEVENT
	{
		internal int size;

		internal TMEFlags dwFlags;

		internal IntPtr hWnd;

		internal int dwHoverTime;
	}

	private struct PAINTSTRUCT
	{
		internal IntPtr hdc;

		internal int fErase;

		internal RECT rcPaint;

		internal int fRestore;

		internal int fIncUpdate;

		internal int Reserved1;

		internal int Reserved2;

		internal int Reserved3;

		internal int Reserved4;

		internal int Reserved5;

		internal int Reserved6;

		internal int Reserved7;

		internal int Reserved8;
	}

	internal struct ICONINFO
	{
		internal bool fIcon;

		internal int xHotspot;

		internal int yHotspot;

		internal IntPtr hbmMask;

		internal IntPtr hbmColor;
	}

	internal enum SetWindowPosZOrder
	{
		HWND_TOP = 0,
		HWND_BOTTOM = 1,
		HWND_TOPMOST = -1,
		HWND_NOTOPMOST = -2
	}

	[Flags]
	internal enum SetWindowPosFlags
	{
		SWP_ASYNCWINDOWPOS = 0x4000,
		SWP_DEFERERASE = 0x2000,
		SWP_DRAWFRAME = 0x20,
		SWP_FRAMECHANGED = 0x20,
		SWP_HIDEWINDOW = 0x80,
		SWP_NOACTIVATE = 0x10,
		SWP_NOCOPYBITS = 0x100,
		SWP_NOMOVE = 2,
		SWP_NOOWNERZORDER = 0x200,
		SWP_NOREDRAW = 8,
		SWP_NOREPOSITION = 0x200,
		SWP_NOENDSCHANGING = 0x400,
		SWP_NOSIZE = 1,
		SWP_NOZORDER = 4,
		SWP_SHOWWINDOW = 0x40
	}

	private enum LoadCursorType
	{
		First = 32512,
		IDC_ARROW = 32512,
		IDC_IBEAM = 32513,
		IDC_WAIT = 32514,
		IDC_CROSS = 32515,
		IDC_UPARROW = 32516,
		IDC_SIZE = 32640,
		IDC_ICON = 32641,
		IDC_SIZENWSE = 32642,
		IDC_SIZENESW = 32643,
		IDC_SIZEWE = 32644,
		IDC_SIZENS = 32645,
		IDC_SIZEALL = 32646,
		IDC_NO = 32648,
		IDC_HAND = 32649,
		IDC_APPSTARTING = 32650,
		IDC_HELP = 32651,
		Last = 32651
	}

	private enum AncestorType
	{
		GA_PARENT = 1,
		GA_ROOT = 2,
		GA_ROOTOWNER = 3
	}

	[Flags]
	private enum WindowLong
	{
		GWL_WNDPROC = -4,
		GWL_HINSTANCE = -6,
		GWL_HWNDPARENT = -8,
		GWL_STYLE = -16,
		GWL_EXSTYLE = -20,
		GWL_USERDATA = -21,
		GWL_ID = -12
	}

	internal struct COLORREF
	{
		internal byte R;

		internal byte G;

		internal byte B;

		internal byte A;
	}

	internal struct TEXTMETRIC
	{
		internal int tmHeight;

		internal int tmAscent;

		internal int tmDescent;

		internal int tmInternalLeading;

		internal int tmExternalLeading;

		internal int tmAveCharWidth;

		internal int tmMaxCharWidth;

		internal int tmWeight;

		internal int tmOverhang;

		internal int tmDigitizedAspectX;

		internal int tmDigitizedAspectY;

		internal short tmFirstChar;

		internal short tmLastChar;

		internal short tmDefaultChar;

		internal short tmBreakChar;

		internal byte tmItalic;

		internal byte tmUnderlined;

		internal byte tmStruckOut;

		internal byte tmPitchAndFamily;

		internal byte tmCharSet;
	}

	public enum TernaryRasterOperations : uint
	{
		SRCCOPY = 13369376u,
		SRCPAINT = 15597702u,
		SRCAND = 8913094u,
		SRCINVERT = 6684742u,
		SRCERASE = 4457256u,
		NOTSRCCOPY = 3342344u,
		NOTSRCERASE = 1114278u,
		MERGECOPY = 12583114u,
		MERGEPAINT = 12255782u,
		PATCOPY = 15728673u,
		PATPAINT = 16452105u,
		PATINVERT = 5898313u,
		DSTINVERT = 5570569u,
		BLACKNESS = 66u,
		WHITENESS = 16711778u
	}

	[Flags]
	private enum ScrollWindowExFlags
	{
		SW_NONE = 0,
		SW_SCROLLCHILDREN = 1,
		SW_INVALIDATE = 2,
		SW_ERASE = 4,
		SW_SMOOTHSCROLL = 0x10
	}

	internal enum SystemMetrics
	{
		SM_CXSCREEN = 0,
		SM_CYSCREEN = 1,
		SM_CXVSCROLL = 2,
		SM_CYHSCROLL = 3,
		SM_CYCAPTION = 4,
		SM_CXBORDER = 5,
		SM_CYBORDER = 6,
		SM_CXDLGFRAME = 7,
		SM_CYDLGFRAME = 8,
		SM_CYVTHUMB = 9,
		SM_CXHTHUMB = 10,
		SM_CXICON = 11,
		SM_CYICON = 12,
		SM_CXCURSOR = 13,
		SM_CYCURSOR = 14,
		SM_CYMENU = 15,
		SM_CXFULLSCREEN = 16,
		SM_CYFULLSCREEN = 17,
		SM_CYKANJIWINDOW = 18,
		SM_MOUSEPRESENT = 19,
		SM_CYVSCROLL = 20,
		SM_CXHSCROLL = 21,
		SM_DEBUG = 22,
		SM_SWAPBUTTON = 23,
		SM_RESERVED1 = 24,
		SM_RESERVED2 = 25,
		SM_RESERVED3 = 26,
		SM_RESERVED4 = 27,
		SM_CXMIN = 28,
		SM_CYMIN = 29,
		SM_CXSIZE = 30,
		SM_CYSIZE = 31,
		SM_CXFRAME = 32,
		SM_CYFRAME = 33,
		SM_CXMINTRACK = 34,
		SM_CYMINTRACK = 35,
		SM_CXDOUBLECLK = 36,
		SM_CYDOUBLECLK = 37,
		SM_CXICONSPACING = 38,
		SM_CYICONSPACING = 39,
		SM_MENUDROPALIGNMENT = 40,
		SM_PENWINDOWS = 41,
		SM_DBCSENABLED = 42,
		SM_CMOUSEBUTTONS = 43,
		SM_CXFIXEDFRAME = 7,
		SM_CYFIXEDFRAME = 8,
		SM_CXSIZEFRAME = 32,
		SM_CYSIZEFRAME = 33,
		SM_SECURE = 44,
		SM_CXEDGE = 45,
		SM_CYEDGE = 46,
		SM_CXMINSPACING = 47,
		SM_CYMINSPACING = 48,
		SM_CXSMICON = 49,
		SM_CYSMICON = 50,
		SM_CYSMCAPTION = 51,
		SM_CXSMSIZE = 52,
		SM_CYSMSIZE = 53,
		SM_CXMENUSIZE = 54,
		SM_CYMENUSIZE = 55,
		SM_ARRANGE = 56,
		SM_CXMINIMIZED = 57,
		SM_CYMINIMIZED = 58,
		SM_CXMAXTRACK = 59,
		SM_CYMAXTRACK = 60,
		SM_CXMAXIMIZED = 61,
		SM_CYMAXIMIZED = 62,
		SM_NETWORK = 63,
		SM_CLEANBOOT = 67,
		SM_CXDRAG = 68,
		SM_CYDRAG = 69,
		SM_SHOWSOUNDS = 70,
		SM_CXMENUCHECK = 71,
		SM_CYMENUCHECK = 72,
		SM_SLOWMACHINE = 73,
		SM_MIDEASTENABLED = 74,
		SM_MOUSEWHEELPRESENT = 75,
		SM_XVIRTUALSCREEN = 76,
		SM_YVIRTUALSCREEN = 77,
		SM_CXVIRTUALSCREEN = 78,
		SM_CYVIRTUALSCREEN = 79,
		SM_CMONITORS = 80,
		SM_SAMEDISPLAYFORMAT = 81,
		SM_IMMENABLED = 82,
		SM_CXFOCUSBORDER = 83,
		SM_CYFOCUSBORDER = 84,
		SM_TABLETPC = 86,
		SM_MEDIACENTER = 87,
		SM_CMETRICS = 88
	}

	[Flags]
	internal enum GAllocFlags : uint
	{
		GMEM_FIXED = 0u,
		GMEM_MOVEABLE = 2u,
		GMEM_NOCOMPACT = 0x10u,
		GMEM_NODISCARD = 0x20u,
		GMEM_ZEROINIT = 0x40u,
		GMEM_MODIFY = 0x80u,
		GMEM_DISCARDABLE = 0x100u,
		GMEM_NOT_BANKED = 0x1000u,
		GMEM_SHARE = 0x2000u,
		GMEM_DDESHARE = 0x2000u,
		GMEM_NOTIFY = 0x4000u,
		GMEM_LOWER = 0x1000u,
		GMEM_VALID_FLAGS = 0x7F72u,
		GMEM_INVALID_HANDLE = 0x8000u,
		GHND = 0x42u,
		GPTR = 0x40u
	}

	internal enum ROP2DrawMode
	{
		R2_BLACK = 1,
		R2_NOTMERGEPEN = 2,
		R2_MASKNOTPEN = 3,
		R2_NOTCOPYPEN = 4,
		R2_MASKPENNOT = 5,
		R2_NOT = 6,
		R2_XORPEN = 7,
		R2_NOTMASKPEN = 8,
		R2_MASKPEN = 9,
		R2_NOTXORPEN = 10,
		R2_NOP = 11,
		R2_MERGENOTPEN = 12,
		R2_COPYPEN = 13,
		R2_MERGEPENNOT = 14,
		R2_MERGEPEN = 15,
		R2_WHITE = 16,
		R2_LAST = 16
	}

	internal enum PenStyle
	{
		PS_SOLID = 0,
		PS_DASH = 1,
		PS_DOT = 2,
		PS_DASHDOT = 3,
		PS_DASHDOTDOT = 4,
		PS_NULL = 5,
		PS_INSIDEFRAME = 6,
		PS_USERSTYLE = 7,
		PS_ALTERNATE = 8
	}

	[Flags]
	internal enum SndFlags
	{
		SND_SYNC = 0,
		SND_ASYNC = 1,
		SND_NODEFAULT = 2,
		SND_MEMORY = 4,
		SND_LOOP = 8,
		SND_NOSTOP = 0x10,
		SND_NOWAIT = 0x2000,
		SND_ALIAS = 0x10000,
		SND_ALIAS_ID = 0x110000,
		SND_FILENAME = 0x20000,
		SND_RESOURCE = 0x40004,
		SND_PURGE = 0x40,
		SND_APPLICATION = 0x80
	}

	[Flags]
	internal enum LayeredWindowAttributes
	{
		LWA_COLORKEY = 1,
		LWA_ALPHA = 2
	}

	private class WinBuffer
	{
		public IntPtr hdc;

		public IntPtr bitmap;

		public WinBuffer(IntPtr hdc, IntPtr bitmap)
		{
		}
	}

	private static XplatUIWin32 instance;

	private static int ref_count;

	private static IntPtr FosterParent;

	internal static MouseButtons mouse_state;

	internal static Point mouse_position;

	internal static bool grab_confined;

	internal static IntPtr grab_hwnd;

	internal static Rectangle grab_area;

	internal static WndProc wnd_proc;

	internal static IntPtr prev_mouse_hwnd;

	internal static bool caret_visible;

	internal static bool themes_enabled;

	private Hashtable timer_list;

	private static Queue message_queue;

	private static IntPtr clip_magic;

	private static int scroll_width;

	private static int scroll_height;

	private static Hashtable wm_nc_registered;

	private static RECT clipped_cursor_rect;

	private Hashtable registered_classes;

	private Hwnd HwndCreating;

	private TransparencySupport support;

	private bool queried_transparency_support;

	public override Size MenuButtonSize => default(Size);

	internal override Keys ModifierKeys => default(Keys);

	internal override Point MousePosition => default(Point);

	internal override int HorizontalScrollBarHeight => 0;

	internal override bool UserClipWontExposeParent => false;

	internal override int VerticalScrollBarWidth => 0;

	internal override int MenuHeight => 0;

	internal override Size Border3DSize => default(Size);

	internal override Size BorderSize => default(Size);

	internal override Size CaptionButtonSize => default(Size);

	internal override int CaptionHeight => 0;

	internal override Size DragSize => default(Size);

	internal override int DoubleClickTime => 0;

	internal override Size FrameBorderSize => default(Size);

	internal override bool MenuAccessKeysUnderlined => false;

	internal override Size MinimizedWindowSize => default(Size);

	internal override Size MinimumWindowSize => default(Size);

	internal override Size MinWindowTrackSize => default(Size);

	internal override Rectangle VirtualScreen => default(Rectangle);

	internal override Rectangle WorkingArea => default(Rectangle);

	internal override bool ThemesEnabled => false;

	internal override bool RequiresPositiveClientAreaSize => false;

	public override int ToolWindowCaptionHeight => 0;

	public override Size ToolWindowCaptionButtonSize => default(Size);

	private XplatUIWin32()
	{
	}

	private string RegisterWindowClass(int classStyle)
	{
		return null;
	}

	private static bool RetrieveMessage(ref MSG msg)
	{
		return false;
	}

	private static bool StoreMessage(ref MSG msg)
	{
		return false;
	}

	internal static string AnsiToString(IntPtr ansi_data)
	{
		return null;
	}

	internal static string UnicodeToString(IntPtr unicode_data)
	{
		return null;
	}

	internal static Image DIBtoImage(IntPtr dib_data)
	{
		return null;
	}

	internal static byte[] ImageToDIB(Image image)
	{
		return null;
	}

	internal static IntPtr DupGlobalMem(IntPtr mem)
	{
		return (IntPtr)0;
	}

	public static XplatUIWin32 GetInstance()
	{
		return null;
	}

	internal override IntPtr InitializeDriver()
	{
		return (IntPtr)0;
	}

	private string GetSoundAlias(AlertType alert)
	{
		return null;
	}

	internal override void AudibleAlert(AlertType alert)
	{
	}

	internal override void GetDisplaySize(out Size size)
	{
		size = default(Size);
	}

	internal override IntPtr CreateWindow(CreateParams cp)
	{
		return (IntPtr)0;
	}

	internal override void DestroyWindow(IntPtr handle)
	{
	}

	internal override void SetWindowMinMax(IntPtr handle, Rectangle maximized, Size min, Size max)
	{
	}

	internal override FormWindowState GetWindowState(IntPtr handle)
	{
		return default(FormWindowState);
	}

	internal override void SetWindowState(IntPtr hwnd, FormWindowState state)
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

	internal override void UpdateWindow(IntPtr handle)
	{
	}

	internal override PaintEventArgs PaintEventStart(ref Message msg, IntPtr handle, bool client)
	{
		return null;
	}

	internal override void PaintEventEnd(ref Message m, IntPtr handle, bool client)
	{
	}

	internal override void SetWindowPos(IntPtr handle, int x, int y, int width, int height)
	{
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

	internal override void Activate(IntPtr handle)
	{
	}

	internal override void Invalidate(IntPtr handle, Rectangle rc, bool clear)
	{
	}

	internal override void InvalidateNC(IntPtr handle)
	{
	}

	private IntPtr InternalWndProc(IntPtr hWnd, Msg msg, IntPtr wParam, IntPtr lParam)
	{
		return (IntPtr)0;
	}

	internal override IntPtr DefWndProc(ref Message msg)
	{
		return (IntPtr)0;
	}

	internal override void DoEvents()
	{
	}

	internal override bool PeekMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax, uint flags)
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

	internal override bool GetMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax)
	{
		return false;
	}

	private bool GetMessage(ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax, bool blocking)
	{
		return false;
	}

	internal override bool TranslateMessage(ref MSG msg)
	{
		return false;
	}

	internal override IntPtr DispatchMessage(ref MSG msg)
	{
		return (IntPtr)0;
	}

	internal override bool SetZOrder(IntPtr hWnd, IntPtr AfterhWnd, bool Top, bool Bottom)
	{
		return false;
	}

	internal override bool SetTopmost(IntPtr hWnd, bool Enabled)
	{
		return false;
	}

	internal override bool SetOwner(IntPtr hWnd, IntPtr hWndOwner)
	{
		return false;
	}

	internal override bool Text(IntPtr handle, string text)
	{
		return false;
	}

	internal override bool SetVisible(IntPtr handle, bool visible, bool activate)
	{
		return false;
	}

	internal override bool IsEnabled(IntPtr handle)
	{
		return false;
	}

	internal override IntPtr SetParent(IntPtr handle, IntPtr parent)
	{
		return (IntPtr)0;
	}

	internal override IntPtr GetParent(IntPtr handle)
	{
		return (IntPtr)0;
	}

	internal override IntPtr GetPreviousWindow(IntPtr handle)
	{
		return (IntPtr)0;
	}

	internal override void GrabWindow(IntPtr hWnd, IntPtr ConfineToHwnd)
	{
	}

	internal override void GrabInfo(out IntPtr hWnd, out bool GrabConfined, out Rectangle GrabArea)
	{
		hWnd = default(IntPtr);
		GrabConfined = default(bool);
		GrabArea = default(Rectangle);
	}

	internal override void UngrabWindow(IntPtr hWnd)
	{
	}

	internal override bool CalculateWindowRect(ref Rectangle ClientRect, CreateParams cp, Menu menu, out Rectangle WindowRect)
	{
		WindowRect = default(Rectangle);
		return false;
	}

	internal override void SetCursor(IntPtr window, IntPtr cursor)
	{
	}

	internal override IntPtr DefineCursor(Bitmap bitmap, Bitmap mask, Color cursor_pixel, Color mask_pixel, int xHotSpot, int yHotSpot)
	{
		return (IntPtr)0;
	}

	[System.MonoTODO("Define the missing cursors")]
	internal override IntPtr DefineStdCursor(StdCursor id)
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

	internal override void SetCursorPos(IntPtr handle, int x, int y)
	{
	}

	internal override void SetClipRegion(IntPtr hwnd, Region region)
	{
	}

	internal override void EnableWindow(IntPtr handle, bool Enable)
	{
	}

	internal override void EndLoop(Thread thread)
	{
	}

	internal override object StartLoop(Thread thread)
	{
		return null;
	}

	internal override void SetModal(IntPtr handle, bool Modal)
	{
	}

	internal override void GetCursorPos(IntPtr handle, out int x, out int y)
	{
		x = default(int);
		y = default(int);
	}

	internal override void ScreenToClient(IntPtr handle, ref int x, ref int y)
	{
	}

	internal override void ClientToScreen(IntPtr handle, ref int x, ref int y)
	{
	}

	internal override void ScreenToMenu(IntPtr handle, ref int x, ref int y)
	{
	}

	internal override void MenuToScreen(IntPtr handle, ref int x, ref int y)
	{
	}

	internal override void SendAsyncMethod(AsyncMethodData method)
	{
	}

	internal override void SetTimer(Timer timer)
	{
	}

	internal override void KillTimer(Timer timer)
	{
	}

	internal override void CreateCaret(IntPtr hwnd, int width, int height)
	{
	}

	internal override void DestroyCaret(IntPtr hwnd)
	{
	}

	internal override void SetCaretPos(IntPtr hwnd, int x, int y)
	{
	}

	internal override void CaretVisible(IntPtr hwnd, bool visible)
	{
	}

	internal override IntPtr GetFocus()
	{
		return (IntPtr)0;
	}

	internal override void SetFocus(IntPtr hwnd)
	{
	}

	internal override IntPtr GetActive()
	{
		return (IntPtr)0;
	}

	internal override bool GetFontMetrics(Graphics g, Font font, out int ascent, out int descent)
	{
		ascent = default(int);
		descent = default(int);
		return false;
	}

	internal override void ScrollWindow(IntPtr hwnd, Rectangle rectangle, int XAmount, int YAmount, bool with_children)
	{
	}

	internal override void ScrollWindow(IntPtr hwnd, int XAmount, int YAmount, bool with_children)
	{
	}

	internal override void SetBorderStyle(IntPtr handle, FormBorderStyle border_style)
	{
	}

	internal override void SetMenu(IntPtr handle, Menu menu)
	{
	}

	internal override Point GetMenuOrigin(IntPtr handle)
	{
		return default(Point);
	}

	internal override void SetIcon(IntPtr hwnd, Icon icon)
	{
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

	internal override int[] ClipboardAvailableFormats(IntPtr handle)
	{
		return null;
	}

	internal override object ClipboardRetrieve(IntPtr handle, int type, XplatUI.ClipboardToObject converter)
	{
		return null;
	}

	internal override void ClipboardStore(IntPtr handle, object obj, int type, XplatUI.ObjectToClipboard converter)
	{
	}

	internal static byte[] StringToUnicode(string text)
	{
		return null;
	}

	internal static byte[] StringToAnsi(string text)
	{
		return null;
	}

	private void SetClipboardData(uint type, byte[] data)
	{
	}

	internal static IntPtr CopyToMoveableMemory(byte[] data)
	{
		return (IntPtr)0;
	}

	internal override void SetAllowDrop(IntPtr hwnd, bool allowed)
	{
	}

	internal override void DrawReversibleRectangle(IntPtr handle, Rectangle rect, int line_width)
	{
	}

	internal override SizeF GetAutoScaleSize(Font font)
	{
		return default(SizeF);
	}

	internal override IntPtr SendMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam)
	{
		return (IntPtr)0;
	}

	internal override bool PostMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam)
	{
		return false;
	}

	internal override void CreateOffscreenDrawable(IntPtr handle, int width, int height, out object offscreen_drawable)
	{
		offscreen_drawable = null;
	}

	internal override Graphics GetOffscreenGraphics(object offscreen_drawable)
	{
		return null;
	}

	internal override void BlitFromOffscreen(IntPtr dest_handle, Graphics dest_dc, object offscreen_drawable, Graphics offscreen_dc, Rectangle r)
	{
	}

	internal override void DestroyOffscreenDrawable(object offscreen_drawable)
	{
	}

	[PreserveSig]
	private static extern uint Win32GetLastError();

	[PreserveSig]
	internal static extern IntPtr Win32CreateWindow(WindowExStyles dwExStyle, string lpClassName, string lpWindowName, WindowStyles dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lParam);

	[PreserveSig]
	internal static extern bool Win32DestroyWindow(IntPtr hWnd);

	[PreserveSig]
	internal static extern bool Win32PeekMessage(ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax, uint flags);

	[PreserveSig]
	internal static extern bool Win32GetMessage(ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax);

	[PreserveSig]
	internal static extern bool Win32TranslateMessage(ref MSG msg);

	[PreserveSig]
	internal static extern IntPtr Win32DispatchMessage(ref MSG msg);

	[PreserveSig]
	internal static extern bool Win32MoveWindow(IntPtr hWnd, int x, int y, int width, int height, bool repaint);

	[PreserveSig]
	internal static extern bool Win32SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, SetWindowPosFlags Flags);

	[PreserveSig]
	internal static extern bool Win32SetWindowPos(IntPtr hWnd, SetWindowPosZOrder pos, int x, int y, int cx, int cy, SetWindowPosFlags Flags);

	[PreserveSig]
	internal static extern bool Win32SetWindowText(IntPtr hWnd, string lpString);

	[PreserveSig]
	internal static extern IntPtr Win32SetParent(IntPtr hWnd, IntPtr hParent);

	[PreserveSig]
	private static extern bool Win32RegisterClass(ref WNDCLASS wndClass);

	[PreserveSig]
	private static extern IntPtr Win32LoadCursor(IntPtr hInstance, LoadCursorType type);

	[PreserveSig]
	private static extern IntPtr Win32SetCursor(IntPtr hCursor);

	[PreserveSig]
	private static extern IntPtr Win32CreateCursor(IntPtr hInstance, int xHotSpot, int yHotSpot, int nWidth, int nHeight, byte[] pvANDPlane, byte[] pvORPlane);

	[PreserveSig]
	private static extern IntPtr Win32DefWindowProc(IntPtr hWnd, Msg Msg, IntPtr wParam, IntPtr lParam);

	[PreserveSig]
	private static extern IntPtr Win32PostQuitMessage(int nExitCode);

	[PreserveSig]
	private static extern IntPtr Win32UpdateWindow(IntPtr hWnd);

	[PreserveSig]
	private static extern bool Win32GetUpdateRect(IntPtr hWnd, ref RECT rect, bool erase);

	[PreserveSig]
	private static extern IntPtr Win32BeginPaint(IntPtr hWnd, ref PAINTSTRUCT ps);

	[PreserveSig]
	private static extern IntPtr Win32ValidateRect(IntPtr hWnd, ref RECT rect);

	[PreserveSig]
	private static extern bool Win32EndPaint(IntPtr hWnd, ref PAINTSTRUCT ps);

	[PreserveSig]
	private static extern IntPtr Win32GetDC(IntPtr hWnd);

	[PreserveSig]
	private static extern IntPtr Win32GetWindowDC(IntPtr hWnd);

	[PreserveSig]
	private static extern IntPtr Win32ReleaseDC(IntPtr hWnd, IntPtr hDC);

	[PreserveSig]
	private static extern IntPtr Win32MessageBox(IntPtr hParent, string pText, string pCaption, uint uType);

	[PreserveSig]
	private static extern IntPtr Win32InvalidateRect(IntPtr hWnd, ref RECT lpRect, bool bErase);

	[PreserveSig]
	private static extern IntPtr Win32SetCapture(IntPtr hWnd);

	[PreserveSig]
	private static extern IntPtr Win32ReleaseCapture();

	[PreserveSig]
	private static extern IntPtr Win32GetWindowRect(IntPtr hWnd, out RECT rect);

	[PreserveSig]
	private static extern IntPtr Win32GetClientRect(IntPtr hWnd, out RECT rect);

	[PreserveSig]
	private static extern bool Win32ScreenToClient(IntPtr hWnd, ref POINT pt);

	[PreserveSig]
	private static extern bool Win32ClientToScreen(IntPtr hWnd, ref POINT pt);

	[PreserveSig]
	private static extern IntPtr Win32GetParent(IntPtr hWnd);

	[PreserveSig]
	private static extern IntPtr Win32GetAncestor(IntPtr hWnd, AncestorType flags);

	[PreserveSig]
	private static extern IntPtr Win32SetActiveWindow(IntPtr hWnd);

	[PreserveSig]
	private static extern bool Win32AdjustWindowRectEx(ref RECT lpRect, int dwStyle, bool bMenu, int dwExStyle);

	[PreserveSig]
	private static extern bool Win32GetCursorPos(out POINT lpPoint);

	[PreserveSig]
	private static extern bool Win32SetCursorPos(int x, int y);

	[PreserveSig]
	private static extern bool Win32TrackMouseEvent(ref TRACKMOUSEEVENT tme);

	[PreserveSig]
	private static extern uint Win32SetWindowLong(IntPtr hwnd, WindowLong index, uint value);

	[PreserveSig]
	private static extern uint Win32GetWindowLong(IntPtr hwnd, WindowLong index);

	[PreserveSig]
	private static extern uint Win32SetLayeredWindowAttributes(IntPtr hwnd, COLORREF crKey, byte bAlpha, LayeredWindowAttributes dwFlags);

	[PreserveSig]
	private static extern uint Win32GetLayeredWindowAttributes(IntPtr hwnd, out COLORREF pcrKey, out byte pbAlpha, out LayeredWindowAttributes pwdFlags);

	[PreserveSig]
	public static extern bool Win32DeleteObject(IntPtr o);

	[PreserveSig]
	private static extern short Win32GetKeyState(VirtualKeys nVirtKey);

	[PreserveSig]
	private static extern IntPtr Win32GetDesktopWindow();

	[PreserveSig]
	private static extern IntPtr Win32SetTimer(IntPtr hwnd, int nIDEvent, uint uElapse, IntPtr timerProc);

	[PreserveSig]
	private static extern IntPtr Win32KillTimer(IntPtr hwnd, int nIDEvent);

	[PreserveSig]
	private static extern IntPtr Win32ShowWindow(IntPtr hwnd, WindowPlacementFlags nCmdShow);

	[PreserveSig]
	private static extern IntPtr Win32EnableWindow(IntPtr hwnd, bool Enabled);

	[PreserveSig]
	internal static extern IntPtr Win32SetFocus(IntPtr hwnd);

	[PreserveSig]
	internal static extern IntPtr Win32GetFocus();

	[PreserveSig]
	internal static extern bool Win32CreateCaret(IntPtr hwnd, IntPtr hBitmap, int nWidth, int nHeight);

	[PreserveSig]
	private static extern bool Win32DestroyCaret();

	[PreserveSig]
	private static extern bool Win32ShowCaret(IntPtr hwnd);

	[PreserveSig]
	private static extern bool Win32HideCaret(IntPtr hwnd);

	[PreserveSig]
	private static extern bool Win32SetCaretPos(int X, int Y);

	[PreserveSig]
	internal static extern bool Win32GetTextMetrics(IntPtr hdc, ref TEXTMETRIC tm);

	[PreserveSig]
	internal static extern IntPtr Win32SelectObject(IntPtr hdc, IntPtr hgdiobject);

	[PreserveSig]
	private static extern bool Win32ScrollWindowEx(IntPtr hwnd, int dx, int dy, IntPtr prcScroll, ref RECT prcClip, IntPtr hrgnUpdate, IntPtr prcUpdate, ScrollWindowExFlags flags);

	[PreserveSig]
	private static extern bool Win32ScrollWindowEx(IntPtr hwnd, int dx, int dy, IntPtr prcScroll, IntPtr prcClip, IntPtr hrgnUpdate, IntPtr prcUpdate, ScrollWindowExFlags flags);

	[PreserveSig]
	private static extern IntPtr Win32GetActiveWindow();

	[PreserveSig]
	private static extern int Win32GetSystemMetrics(SystemMetrics nIndex);

	[PreserveSig]
	internal static extern IntPtr Win32CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

	[PreserveSig]
	private static extern bool IsWindowEnabled(IntPtr hwnd);

	[PreserveSig]
	private static extern IntPtr Win32SendMessage(IntPtr hwnd, Msg msg, IntPtr wParam, IntPtr lParam);

	[PreserveSig]
	private static extern bool Win32PostMessage(IntPtr hwnd, Msg msg, IntPtr wParam, IntPtr lParam);

	[PreserveSig]
	private static extern bool Win32SystemParametersInfo(SPIAction uiAction, uint uiParam, ref RECT rect, uint fWinIni);

	[PreserveSig]
	private static extern bool Win32SystemParametersInfo(SPIAction uiAction, uint uiParam, ref int value, uint fWinIni);

	[PreserveSig]
	private static extern bool Win32OpenClipboard(IntPtr hwnd);

	[PreserveSig]
	private static extern bool Win32EmptyClipboard();

	[PreserveSig]
	private static extern uint Win32RegisterClipboardFormat(string format);

	[PreserveSig]
	private static extern bool Win32CloseClipboard();

	[PreserveSig]
	private static extern uint Win32EnumClipboardFormats(uint format);

	[PreserveSig]
	private static extern IntPtr Win32GetClipboardData(uint format);

	[PreserveSig]
	private static extern IntPtr Win32SetClipboardData(uint format, IntPtr handle);

	[PreserveSig]
	internal static extern IntPtr Win32GlobalAlloc(GAllocFlags Flags, int dwBytes);

	[PreserveSig]
	internal static extern void Win32CopyMemory(IntPtr Destination, IntPtr Source, int length);

	[PreserveSig]
	internal static extern uint Win32GlobalSize(IntPtr hMem);

	[PreserveSig]
	internal static extern IntPtr Win32GlobalLock(IntPtr hMem);

	[PreserveSig]
	internal static extern IntPtr Win32GlobalUnlock(IntPtr hMem);

	[PreserveSig]
	internal static extern int Win32SetROP2(IntPtr hdc, ROP2DrawMode fnDrawMode);

	[PreserveSig]
	internal static extern bool Win32MoveToEx(IntPtr hdc, int x, int y, IntPtr lpPoint);

	[PreserveSig]
	internal static extern bool Win32LineTo(IntPtr hdc, int x, int y);

	[PreserveSig]
	internal static extern IntPtr Win32CreatePen(PenStyle fnPenStyle, int nWidth, IntPtr color);

	[PreserveSig]
	internal static extern int Win32ExcludeClipRect(IntPtr hdc, int left, int top, int right, int bottom);

	[PreserveSig]
	internal static extern int Win32ExtSelectClipRgn(IntPtr hdc, IntPtr hrgn, int mode);

	[PreserveSig]
	internal static extern IntPtr Win32PlaySound(string pszSound, IntPtr hmod, SndFlags fdwSound);

	[PreserveSig]
	private static extern int Win32GetDoubleClickTime();

	[PreserveSig]
	internal static extern int Win32SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool redraw);

	[PreserveSig]
	internal static extern bool Win32ClipCursor(ref RECT lpRect);

	[PreserveSig]
	internal static extern bool Win32GetClipCursor(out RECT lpRect);

	[PreserveSig]
	internal static extern bool Win32BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjSource, int nXSrc, int nYSrc, TernaryRasterOperations dwRop);

	[PreserveSig]
	internal static extern IntPtr Win32CreateCompatibleDC(IntPtr hdc);

	[PreserveSig]
	internal static extern bool Win32DeleteDC(IntPtr hdc);

	[PreserveSig]
	internal static extern IntPtr Win32CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);

	[PreserveSig]
	internal static extern bool Win32GetIconInfo(IntPtr hIcon, out ICONINFO piconinfo);
}
