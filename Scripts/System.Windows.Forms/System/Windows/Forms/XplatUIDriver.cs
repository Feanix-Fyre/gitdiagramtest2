using System.Drawing;
using System.Threading;

namespace System.Windows.Forms;

internal abstract class XplatUIDriver
{
	internal delegate IntPtr WndProc(IntPtr hwnd, Msg msg, IntPtr wParam, IntPtr lParam);

	internal virtual Size Border3DSize => default(Size);

	internal virtual Size BorderSize => default(Size);

	internal virtual Size CaptionButtonSize => default(Size);

	internal virtual int DoubleClickTime => 0;

	public virtual Size MenuButtonSize => default(Size);

	internal virtual Keys ModifierKeys => default(Keys);

	internal virtual Point MousePosition => default(Point);

	internal virtual int MenuHeight => 0;

	internal virtual int HorizontalScrollBarHeight => 0;

	internal virtual bool UserClipWontExposeParent => false;

	internal virtual int VerticalScrollBarWidth => 0;

	internal abstract int CaptionHeight { get; }

	internal abstract Size DragSize { get; }

	internal abstract Size FrameBorderSize { get; }

	internal abstract bool MenuAccessKeysUnderlined { get; }

	internal virtual Size MinimizedWindowSize => default(Size);

	internal abstract Size MinimumWindowSize { get; }

	internal virtual Size MinimumFixedToolWindowSize => default(Size);

	internal virtual Size MinimumSizeableToolWindowSize => default(Size);

	internal virtual Size MinimumNoBorderWindowSize => default(Size);

	internal virtual Size MinWindowTrackSize => default(Size);

	internal abstract Rectangle VirtualScreen { get; }

	internal abstract Rectangle WorkingArea { get; }

	internal abstract bool ThemesEnabled { get; }

	internal virtual bool RequiresPositiveClientAreaSize => false;

	public virtual int ToolWindowCaptionHeight => 0;

	public virtual Size ToolWindowCaptionButtonSize => default(Size);

	internal abstract IntPtr InitializeDriver();

	internal abstract void AudibleAlert(AlertType alert);

	internal abstract void GetDisplaySize(out Size size);

	internal abstract IntPtr CreateWindow(CreateParams cp);

	internal abstract void DestroyWindow(IntPtr handle);

	internal abstract FormWindowState GetWindowState(IntPtr handle);

	internal abstract void SetWindowState(IntPtr handle, FormWindowState state);

	internal abstract void SetWindowMinMax(IntPtr handle, Rectangle maximized, Size min, Size max);

	internal abstract void SetWindowStyle(IntPtr handle, CreateParams cp);

	internal abstract void SetWindowTransparency(IntPtr handle, double transparency, Color key);

	internal abstract TransparencySupport SupportsTransparency();

	internal virtual void SetAllowDrop(IntPtr handle, bool value)
	{
	}

	internal abstract void SetBorderStyle(IntPtr handle, FormBorderStyle border_style);

	internal abstract void SetMenu(IntPtr handle, Menu menu);

	internal abstract bool Text(IntPtr handle, string text);

	internal abstract bool SetVisible(IntPtr handle, bool visible, bool activate);

	internal abstract bool IsEnabled(IntPtr handle);

	internal abstract IntPtr SetParent(IntPtr handle, IntPtr parent);

	internal abstract IntPtr GetParent(IntPtr handle);

	internal abstract void UpdateWindow(IntPtr handle);

	internal abstract PaintEventArgs PaintEventStart(ref Message msg, IntPtr handle, bool client);

	internal abstract void PaintEventEnd(ref Message msg, IntPtr handle, bool client);

	internal abstract void SetWindowPos(IntPtr handle, int x, int y, int width, int height);

	internal abstract void GetWindowPos(IntPtr handle, bool is_toplevel, out int x, out int y, out int width, out int height, out int client_width, out int client_height);

	internal abstract void Activate(IntPtr handle);

	internal abstract void EnableWindow(IntPtr handle, bool Enable);

	internal abstract void SetModal(IntPtr handle, bool Modal);

	internal abstract void Invalidate(IntPtr handle, Rectangle rc, bool clear);

	internal abstract void InvalidateNC(IntPtr handle);

	internal abstract IntPtr DefWndProc(ref Message msg);

	internal abstract void DoEvents();

	internal abstract bool PeekMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax, uint flags);

	internal abstract void PostQuitMessage(int exitCode);

	internal abstract bool GetMessage(object queue_id, ref MSG msg, IntPtr hWnd, int wFilterMin, int wFilterMax);

	internal abstract bool TranslateMessage(ref MSG msg);

	internal abstract IntPtr DispatchMessage(ref MSG msg);

	internal abstract bool SetZOrder(IntPtr hWnd, IntPtr AfterhWnd, bool Top, bool Bottom);

	internal abstract bool SetTopmost(IntPtr hWnd, bool Enabled);

	internal abstract bool SetOwner(IntPtr hWnd, IntPtr hWndOwner);

	internal abstract bool CalculateWindowRect(ref Rectangle ClientRect, CreateParams cp, Menu menu, out Rectangle WindowRect);

	internal abstract void SetClipRegion(IntPtr hwnd, Region region);

	internal abstract void SetCursor(IntPtr hwnd, IntPtr cursor);

	internal abstract IntPtr DefineCursor(Bitmap bitmap, Bitmap mask, Color cursor_pixel, Color mask_pixel, int xHotSpot, int yHotSpot);

	internal abstract IntPtr DefineStdCursor(StdCursor id);

	internal abstract void GetCursorInfo(IntPtr cursor, out int width, out int height, out int hotspot_x, out int hotspot_y);

	internal abstract void GetCursorPos(IntPtr hwnd, out int x, out int y);

	internal abstract void SetCursorPos(IntPtr hwnd, int x, int y);

	internal abstract void ScreenToClient(IntPtr hwnd, ref int x, ref int y);

	internal abstract void ClientToScreen(IntPtr hwnd, ref int x, ref int y);

	internal abstract void GrabWindow(IntPtr hwnd, IntPtr ConfineToHwnd);

	internal abstract void GrabInfo(out IntPtr hwnd, out bool GrabConfined, out Rectangle GrabArea);

	internal abstract void UngrabWindow(IntPtr hwnd);

	internal abstract void SendAsyncMethod(AsyncMethodData method);

	internal abstract void SetTimer(Timer timer);

	internal abstract void KillTimer(Timer timer);

	internal abstract void CreateCaret(IntPtr hwnd, int width, int height);

	internal abstract void DestroyCaret(IntPtr hwnd);

	internal abstract void SetCaretPos(IntPtr hwnd, int x, int y);

	internal abstract void CaretVisible(IntPtr hwnd, bool visible);

	internal abstract IntPtr GetFocus();

	internal abstract void SetFocus(IntPtr hwnd);

	internal abstract IntPtr GetActive();

	internal abstract IntPtr GetPreviousWindow(IntPtr hwnd);

	internal abstract void ScrollWindow(IntPtr hwnd, Rectangle rectangle, int XAmount, int YAmount, bool with_children);

	internal abstract void ScrollWindow(IntPtr hwnd, int XAmount, int YAmount, bool with_children);

	internal abstract bool GetFontMetrics(Graphics g, Font font, out int ascent, out int descent);

	internal abstract Point GetMenuOrigin(IntPtr hwnd);

	internal abstract void MenuToScreen(IntPtr hwnd, ref int x, ref int y);

	internal abstract void ScreenToMenu(IntPtr hwnd, ref int x, ref int y);

	internal abstract void SetIcon(IntPtr handle, Icon icon);

	internal abstract void ClipboardClose(IntPtr handle);

	internal abstract IntPtr ClipboardOpen(bool primary_selection);

	internal abstract int ClipboardGetID(IntPtr handle, string format);

	internal abstract void ClipboardStore(IntPtr handle, object obj, int id, XplatUI.ObjectToClipboard converter);

	internal abstract int[] ClipboardAvailableFormats(IntPtr handle);

	internal abstract object ClipboardRetrieve(IntPtr handle, int id, XplatUI.ClipboardToObject converter);

	internal abstract void DrawReversibleRectangle(IntPtr handle, Rectangle rect, int line_width);

	internal abstract SizeF GetAutoScaleSize(Font font);

	internal abstract IntPtr SendMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam);

	internal abstract bool PostMessage(IntPtr hwnd, Msg message, IntPtr wParam, IntPtr lParam);

	internal abstract object StartLoop(Thread thread);

	internal abstract void EndLoop(Thread thread);

	internal abstract void RequestNCRecalc(IntPtr hwnd);

	internal abstract void ResetMouseHover(IntPtr hwnd);

	internal abstract void RequestAdditionalWM_NCMessages(IntPtr hwnd, bool hover, bool leave);

	internal virtual void CreateOffscreenDrawable(IntPtr handle, int width, int height, out object offscreen_drawable)
	{
		offscreen_drawable = null;
	}

	internal virtual void DestroyOffscreenDrawable(object offscreen_drawable)
	{
	}

	internal virtual Graphics GetOffscreenGraphics(object offscreen_drawable)
	{
		return null;
	}

	internal virtual void BlitFromOffscreen(IntPtr dest_handle, Graphics dest_dc, object offscreen_drawable, Graphics offscreen_dc, Rectangle r)
	{
	}
}
