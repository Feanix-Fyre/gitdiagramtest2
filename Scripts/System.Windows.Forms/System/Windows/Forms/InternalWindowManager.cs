using System.Drawing;

namespace System.Windows.Forms;

internal abstract class InternalWindowManager
{
	public enum State
	{
		Idle = 0,
		Moving = 1,
		Sizing = 2
	}

	[Flags]
	public enum FormPos
	{
		None = 0,
		TitleBar = 1,
		Top = 2,
		Left = 4,
		Right = 8,
		Bottom = 0x10,
		TopLeft = 6,
		TopRight = 0xA,
		BottomLeft = 0x14,
		BottomRight = 0x18,
		AnyEdge = 0x1E
	}

	private TitleButtons title_buttons;

	internal Form form;

	internal Point start;

	internal State state;

	protected Point clicked_point;

	private FormPos sizing_edge;

	internal Rectangle virtual_position;

	private Rectangle normal_bounds;

	private Rectangle iconic_bounds;

	public Form Form => null;

	public int IconWidth => 0;

	public TitleButtons TitleButtons => null;

	internal Rectangle NormalBounds
	{
		get
		{
			return default(Rectangle);
		}
		set
		{
		}
	}

	internal Size IconicSize => default(Size);

	internal Rectangle IconicBounds
	{
		get
		{
			return default(Rectangle);
		}
		set
		{
		}
	}

	internal virtual Rectangle MaximizedBounds => default(Rectangle);

	public bool ShowIcon => false;

	public virtual bool IsActive => false;

	public bool IsMaximized => false;

	public bool IsMinimized => false;

	public bool IsSizable => false;

	public bool HasBorders => false;

	public bool IsToolWindow => false;

	public int TitleBarHeight => 0;

	public int BorderWidth => 0;

	public virtual int MenuHeight => 0;

	public InternalWindowManager(Form form)
	{
	}

	public virtual void UpdateWindowState(FormWindowState old_window_state, FormWindowState new_window_state, bool force)
	{
	}

	public virtual void UpdateWindowDecorations(FormWindowState window_state)
	{
	}

	public virtual bool WndProc(ref Message m)
	{
		return false;
	}

	protected virtual bool HandleNCPaint(ref Message m)
	{
		return false;
	}

	protected virtual bool HandleNCCalcSize(ref Message m)
	{
		return false;
	}

	protected virtual XplatUIWin32.RECT NCCalcSize(XplatUIWin32.RECT proposed_window_rect)
	{
		return default(XplatUIWin32.RECT);
	}

	protected virtual bool HandleNCHitTest(ref Message m)
	{
		return false;
	}

	public virtual void UpdateBorderStyle(FormBorderStyle border_style)
	{
	}

	public virtual void SetWindowState(FormWindowState old_state, FormWindowState window_state)
	{
	}

	public virtual FormWindowState GetWindowState()
	{
		return default(FormWindowState);
	}

	public virtual void PointToClient(ref int x, ref int y)
	{
	}

	public virtual void PointToScreen(ref int x, ref int y)
	{
	}

	protected virtual bool ShouldRemoveWindowManager(FormBorderStyle style)
	{
		return false;
	}

	public bool IconRectangleContains(int x, int y)
	{
		return false;
	}

	protected virtual void Activate()
	{
	}

	private void FormSizeChangedHandler(object sender, EventArgs e)
	{
	}

	protected virtual bool HandleRButtonDown(ref Message m)
	{
		return false;
	}

	protected virtual bool HandleLButtonDown(ref Message m)
	{
		return false;
	}

	protected virtual bool HandleLButtonDblClick(ref Message m)
	{
		return false;
	}

	protected virtual bool HandleNCMouseLeave(ref Message m)
	{
		return false;
	}

	protected virtual bool HandleNCMouseMove(ref Message m)
	{
		return false;
	}

	protected virtual bool HandleNCLButtonDown(ref Message m)
	{
		return false;
	}

	protected virtual void HandleNCLButtonDblClick(ref Message m)
	{
	}

	protected virtual void HandleTitleBarDoubleClick(int x, int y)
	{
	}

	protected virtual void HandleTitleBarLeave(int x, int y)
	{
	}

	protected virtual void HandleTitleBarMouseMove(int x, int y)
	{
	}

	protected virtual void HandleTitleBarUp(int x, int y)
	{
	}

	protected virtual void HandleTitleBarDown(int x, int y)
	{
	}

	private bool HandleMouseMove(Form form, ref Message m)
	{
		return false;
	}

	private void HandleMouseLeave(ref Message m)
	{
	}

	protected virtual void HandleWindowMove(Message m)
	{
	}

	private void HandleSizing(Message m)
	{
	}

	protected void UpdateVP(Rectangle r)
	{
	}

	protected void UpdateVP(int x, int y, int w, int h)
	{
	}

	protected virtual void HandleLButtonUp(ref Message m)
	{
	}

	private bool HandleNCLButtonUp(ref Message m)
	{
		return false;
	}

	protected void DrawTitleButton(Graphics dc, TitleButton button, Rectangle clip)
	{
	}

	public virtual void DrawMaximizedButtons(object sender, PaintEventArgs pe)
	{
	}

	protected Point MouseMove(Point pos)
	{
		return default(Point);
	}

	protected virtual void DrawVirtualPosition(Rectangle virtual_position)
	{
	}

	protected virtual void ClearVirtualPosition()
	{
	}

	protected virtual void OnWindowFinishedMoving()
	{
	}

	protected virtual void NCPointToClient(ref int x, ref int y)
	{
	}

	protected virtual void NCClientToNC(ref int x, ref int y)
	{
	}

	internal Point GetMenuOrigin()
	{
		return default(Point);
	}

	protected FormPos FormPosForCoords(int x, int y)
	{
		return default(FormPos);
	}
}
