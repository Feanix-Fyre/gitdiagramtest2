using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Represents a small rectangular pop-up window that displays a brief description of a control's purpose when the user rests the pointer on the control.</summary>
[ProvideProperty("ToolTip", typeof(Control))]
[DefaultEvent("Popup")]
[ToolboxItemFilter("System.Windows.Forms", ToolboxItemFilterType.Allow)]
public class ToolTip : Component, IExtenderProvider
{
	internal class ToolTipWindow : Control
	{
		private Control associated_control;

		internal Icon icon;

		internal string title;

		internal Rectangle icon_rect;

		internal Rectangle title_rect;

		internal Rectangle text_rect;

		protected override CreateParams CreateParams => null;

		internal override bool ActivateOnShow => false;

		public event DrawToolTipEventHandler Draw
		{
			add
			{
			}
			remove
			{
			}
		}

		public event PopupEventHandler Popup
		{
			add
			{
			}
			remove
			{
			}
		}

		internal event PopupEventHandler UnPopup
		{
			add
			{
			}
			remove
			{
			}
		}

		internal ToolTipWindow()
		{
		}

		protected override void OnCreateControl()
		{
		}

		protected override void OnPaint(PaintEventArgs pevent)
		{
		}

		protected override void OnTextChanged(EventArgs args)
		{
		}

		protected override void WndProc(ref Message m)
		{
		}

		internal virtual void OnDraw(DrawToolTipEventArgs e)
		{
		}

		internal virtual void OnPopup(PopupEventArgs e)
		{
		}

		private void ToolTipWindow_VisibleChanged(object sender, EventArgs e)
		{
		}

		private void OnUIAToolTip_VisibleChanged(object sender, EventArgs e)
		{
		}

		private void OnUnPopup(PopupEventArgs e)
		{
		}

		public void Present(Control control, string text)
		{
		}
	}

	private enum TipState
	{
		Initial = 0,
		Show = 1,
		Down = 2
	}

	internal bool is_active;

	internal int automatic_delay;

	internal int autopop_delay;

	internal int initial_delay;

	internal int re_show_delay;

	internal bool show_always;

	internal Color back_color;

	internal Color fore_color;

	internal ToolTipWindow tooltip_window;

	internal Hashtable tooltip_strings;

	internal ArrayList controls;

	internal Control active_control;

	internal Control last_control;

	internal Timer timer;

	private Form hooked_form;

	private bool isBalloon;

	private bool owner_draw;

	private bool stripAmpersands;

	private bool useAnimation;

	private bool useFading;

	private TipState state;

	private static object PopupEvent;

	private static object DrawEvent;

	private static PopupEventHandler UIAUnPopup;

	private static ControlEventHandler UIAToolTipHookUp;

	private static ControlEventHandler UIAToolTipUnhookUp;

	/// <summary>Gets or sets a value indicating whether the ToolTip is currently active.</summary>
	/// <returns>
	///   <see langword="true" /> if the ToolTip is currently active; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool Active
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the time that passes before the ToolTip appears.</summary>
	/// <returns>The period of time, in milliseconds, that the pointer must remain stationary on a control before the ToolTip window is displayed.</returns>
	[RefreshProperties(RefreshProperties.All)]
	public int InitialDelay
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the ToolTip is drawn by the operating system or by code that you provide.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolTip" /> is drawn by code that you provide; <see langword="false" /> if the <see cref="T:System.Windows.Forms.ToolTip" /> is drawn by the operating system. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool OwnerDraw => false;

	/// <summary>Gets or sets the length of time that must transpire before subsequent ToolTip windows appear as the pointer moves from one control to another.</summary>
	/// <returns>The length of time, in milliseconds, that it takes subsequent ToolTip windows to appear.</returns>
	[RefreshProperties(RefreshProperties.All)]
	public int ReshowDelay
	{
		set
		{
		}
	}

	internal bool Visible => false;

	internal event PopupEventHandler UnPopup
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolTip" /> without a specified container.</summary>
	public ToolTip()
	{
	}

	internal static void OnUIAUnPopup(object sender, PopupEventArgs args)
	{
	}

	internal static void OnUIAToolTipHookUp(object sender, ControlEventArgs args)
	{
	}

	internal static void OnUIAToolTipUnhookUp(object sender, ControlEventArgs args)
	{
	}

	/// <summary>Releases the unmanaged resources and performs other cleanup operations before the <see cref="T:System.Windows.Forms.Cursor" /> is reclaimed by the garbage collector.</summary>
	~ToolTip()
	{
	}

	/// <summary>Returns <see langword="true" /> if the ToolTip can offer an extender property to the specified target component.</summary>
	/// <param name="target">The target object to add an extender property to.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolTip" /> class can offer one or more extender properties; otherwise, <see langword="false" />.</returns>
	public bool CanExtend(object target)
	{
		return false;
	}

	/// <summary>Associates ToolTip text with the specified control.</summary>
	/// <param name="control">The <see cref="T:System.Windows.Forms.Control" /> to associate the ToolTip text with.</param>
	/// <param name="caption">The ToolTip text to display when the pointer is on the control.</param>
	public void SetToolTip(Control control, string caption)
	{
	}

	/// <summary>Returns a string representation for this control.</summary>
	/// <returns>A <see cref="T:System.String" /> containing a description of the <see cref="T:System.Windows.Forms.ToolTip" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Hides the specified ToolTip window.</summary>
	/// <param name="win">The <see cref="T:System.Windows.Forms.IWin32Window" /> of the associated window or control that the ToolTip is associated with.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="win" /> is <see langword="null" />.</exception>
	public void Hide(IWin32Window win)
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.ComponentModel.Component" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	private void UnhookFormEvents()
	{
	}

	private void Form_Resize(object sender, EventArgs e)
	{
	}

	private void Form_Closed(object sender, EventArgs e)
	{
	}

	private void Form_Deactivate(object sender, EventArgs e)
	{
	}

	internal void Present(Control control, string text)
	{
	}

	private void control_MouseEnter(object sender, EventArgs e)
	{
	}

	private void ShowTooltip(Control control)
	{
	}

	private void timer_Tick(object sender, EventArgs e)
	{
	}

	private void tooltip_window_Popup(object sender, PopupEventArgs e)
	{
	}

	private void tooltip_window_Draw(object sender, DrawToolTipEventArgs e)
	{
	}

	private bool MouseInControl(Control control, bool fuzzy)
	{
		return false;
	}

	private void control_MouseLeave(object sender, EventArgs e)
	{
	}

	private void control_MouseDown(object sender, MouseEventArgs e)
	{
	}

	private void control_MouseMove(object sender, MouseEventArgs e)
	{
	}

	internal void OnDraw(DrawToolTipEventArgs e)
	{
	}

	internal void OnPopup(PopupEventArgs e)
	{
	}

	internal void OnUnPopup(PopupEventArgs e)
	{
	}
}
