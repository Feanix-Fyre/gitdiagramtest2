using System.Collections;

namespace System.Windows.Forms;

internal class TitleButtons : IEnumerable
{
	public TitleButton MinimizeButton;

	public TitleButton MaximizeButton;

	public TitleButton RestoreButton;

	public TitleButton CloseButton;

	public TitleButton HelpButton;

	public TitleButton[] AllButtons;

	public bool Visible;

	private ToolTip.ToolTipWindow tooltip;

	private Timer tooltip_timer;

	private TitleButton tooltip_hovered_button;

	private TitleButton tooltip_hidden_button;

	private Form form;

	public bool AnyPushedTitleButtons => false;

	public TitleButtons(Form frm)
	{
	}

	private void ClickHandler(object sender, EventArgs e)
	{
	}

	public TitleButton FindButton(int x, int y)
	{
		return null;
	}

	public IEnumerator GetEnumerator()
	{
		return null;
	}

	public void ToolTipStart(TitleButton button)
	{
	}

	public void ToolTipTimerTick(object sender, EventArgs e)
	{
	}

	public void ToolTipShow(bool only_refresh)
	{
	}

	public void ToolTipHide(bool reset_hidden_button)
	{
	}

	public bool MouseMove(int x, int y)
	{
		return false;
	}

	public void MouseDown(int x, int y)
	{
	}

	public void MouseUp(int x, int y)
	{
	}

	internal void MouseLeave(int x, int y)
	{
	}
}
