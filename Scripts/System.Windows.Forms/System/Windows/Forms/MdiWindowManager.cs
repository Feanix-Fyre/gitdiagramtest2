using System.Drawing;

namespace System.Windows.Forms;

internal class MdiWindowManager : InternalWindowManager
{
	private MainMenu merged_menu;

	private MainMenu maximized_menu;

	private MenuItem icon_menu;

	private ContextMenu icon_popup_menu;

	internal bool was_minimized;

	private PaintEventHandler draw_maximized_buttons;

	internal EventHandler form_closed_handler;

	private MdiClient mdi_container;

	private Rectangle prev_virtual_position;

	private Point icon_clicked;

	private DateTime icon_clicked_time;

	private bool icon_dont_show_popup;

	private TitleButtons maximized_title_buttons;

	private bool is_visible_pending;

	private byte last_activation_event;

	public override int MenuHeight => 0;

	internal bool IsVisiblePending
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private TitleButtons MaximizedTitleButtons => null;

	internal override Rectangle MaximizedBounds => default(Rectangle);

	public MainMenu MergedMenu => null;

	public MainMenu MaximizedMenu => null;

	public override bool IsActive => false;

	public MdiWindowManager(Form form, MdiClient mdi_container)
		: base(null)
	{
	}

	public void RaiseActivated()
	{
	}

	public void RaiseDeactivate()
	{
	}

	private void FormVisibleChangedHandler(object sender, EventArgs e)
	{
	}

	private void FormTextChangedHandler(object sender, EventArgs e)
	{
	}

	private void FormLocationChangedHandler(object sender, EventArgs e)
	{
	}

	private void FormSizeChangedHandler(object sender, EventArgs e)
	{
	}

	private MainMenu CreateMergedMenu()
	{
		return null;
	}

	private MainMenu CreateMaximizedMenu()
	{
		return null;
	}

	private void CreateIconMenus()
	{
	}

	private void ClickIconMenuItem(object sender, EventArgs e)
	{
	}

	internal void ShowPopup(Point pnt)
	{
	}

	private void RestoreItemHandler(object sender, EventArgs e)
	{
	}

	private void MoveItemHandler(object sender, EventArgs e)
	{
	}

	private void SizeItemHandler(object sender, EventArgs e)
	{
	}

	private void MinimizeItemHandler(object sender, EventArgs e)
	{
	}

	private void MaximizeItemHandler(object sender, EventArgs e)
	{
	}

	private void CloseItemHandler(object sender, EventArgs e)
	{
	}

	private void NextItemHandler(object sender, EventArgs e)
	{
	}

	private void DrawIconMenuItem(object sender, DrawItemEventArgs de)
	{
	}

	private void MeasureIconMenuItem(object sender, MeasureItemEventArgs me)
	{
	}

	private void MenuChangedHandler(object sender, EventArgs e)
	{
	}

	public override void PointToClient(ref int x, ref int y)
	{
	}

	public override void PointToScreen(ref int x, ref int y)
	{
	}

	public override void UpdateWindowDecorations(FormWindowState window_state)
	{
	}

	public override void SetWindowState(FormWindowState old_state, FormWindowState window_state)
	{
	}

	private void FormClosed(object sender, EventArgs e)
	{
	}

	public override void DrawMaximizedButtons(object sender, PaintEventArgs pe)
	{
	}

	public bool HandleMenuMouseDown(MainMenu menu, int x, int y)
	{
		return false;
	}

	public void HandleMenuMouseUp(MainMenu menu, int x, int y)
	{
	}

	public void HandleMenuMouseLeave(MainMenu menu, int x, int y)
	{
	}

	public void HandleMenuMouseMove(MainMenu menu, int x, int y)
	{
	}

	protected override void HandleTitleBarLeave(int x, int y)
	{
	}

	protected override void HandleTitleBarUp(int x, int y)
	{
	}

	protected override void HandleTitleBarDoubleClick(int x, int y)
	{
	}

	protected override void HandleTitleBarDown(int x, int y)
	{
	}

	protected override void HandleTitleBarMouseMove(int x, int y)
	{
	}

	protected override bool HandleLButtonDblClick(ref Message m)
	{
		return false;
	}

	protected override bool HandleLButtonDown(ref Message m)
	{
		return false;
	}

	protected override bool ShouldRemoveWindowManager(FormBorderStyle style)
	{
		return false;
	}

	protected override void HandleWindowMove(Message m)
	{
	}

	protected override bool HandleNCMouseMove(ref Message m)
	{
		return false;
	}

	protected override void DrawVirtualPosition(Rectangle virtual_position)
	{
	}

	protected override void ClearVirtualPosition()
	{
	}

	protected override void OnWindowFinishedMoving()
	{
	}

	protected override void Activate()
	{
	}
}
