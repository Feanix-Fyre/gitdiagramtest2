using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Represents the container for multiple-document interface (MDI) child forms. This class cannot be inherited.</summary>
[ComVisible(true)]
[ToolboxItem(false)]
[DesignTimeVisible(false)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public sealed class MdiClient : Control
{
	private ImplicitHScrollBar hbar;

	private ImplicitVScrollBar vbar;

	private SizeGrip sizegrip;

	private int hbar_value;

	private int vbar_value;

	private bool lock_sizing;

	private bool initializing_scrollbars;

	private bool setting_windowstates;

	internal ArrayList mdi_child_list;

	private string form_text;

	private bool setting_form_text;

	private Form active_child;

	internal bool HorizontalScrollbarVisible => false;

	internal bool VerticalScrollbarVisible => false;

	internal Form ParentForm => null;

	/// <summary>Gets the child multiple-document interface (MDI) forms of the <see cref="T:System.Windows.Forms.MdiClient" /> control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Form" /> array that contains the child MDI forms of the <see cref="T:System.Windows.Forms.MdiClient" />.</returns>
	public Form[] MdiChildren => null;

	internal Form ActiveMdiChild => null;

	internal void SendFocusToActiveChild()
	{
	}

	internal void SetParentText(bool text_changed)
	{
	}

	internal void SizeScrollBars()
	{
	}

	private void CalcHBar(int left, int right, bool vert_vis)
	{
	}

	private void CalcVBar(int top, int bottom, bool horz_vis)
	{
	}

	private void HBarValueChanged(object sender, EventArgs e)
	{
	}

	private void VBarValueChanged(object sender, EventArgs e)
	{
	}

	internal void ArrangeIconicWindows(bool rearrange_all)
	{
	}

	internal void ChildFormClosed(Form form)
	{
	}

	internal void ActivateNextChild()
	{
	}

	internal void ActivatePreviousChild()
	{
	}

	internal void ActivateChild(Form form)
	{
	}

	internal bool SetWindowStates(MdiWindowManager wm)
	{
		return false;
	}

	private MenuStrip LookForChildMenu(Control parent)
	{
		return null;
	}

	internal void RemoveControlMenuItems(MdiWindowManager wm)
	{
	}

	internal void SetWindowState(Form form, FormWindowState old_window_state, FormWindowState new_window_state, bool is_activating_child)
	{
	}

	internal void ActivateActiveMdiChild()
	{
	}
}
