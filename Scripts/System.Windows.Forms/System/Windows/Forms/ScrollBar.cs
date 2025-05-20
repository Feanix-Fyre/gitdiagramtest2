using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Implements the basic functionality of a scroll bar control.</summary>
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
[DefaultEvent("Scroll")]
[DefaultProperty("Value")]
public abstract class ScrollBar : Control
{
	private enum TimerType
	{
		HoldButton = 0,
		RepeatButton = 1,
		HoldThumbArea = 2,
		RepeatThumbArea = 3
	}

	internal enum ThumbMoving
	{
		None = 0,
		Forward = 1,
		Backwards = 2
	}

	private int position;

	private int minimum;

	private int maximum;

	private int large_change;

	private int small_change;

	internal int scrollbutton_height;

	internal int scrollbutton_width;

	private Rectangle first_arrow_area;

	private Rectangle second_arrow_area;

	private Rectangle thumb_pos;

	private Rectangle thumb_area;

	internal ButtonState firstbutton_state;

	internal ButtonState secondbutton_state;

	private bool firstbutton_pressed;

	private bool secondbutton_pressed;

	private bool thumb_pressed;

	private float pixel_per_pos;

	private Timer timer;

	private TimerType timer_type;

	private int thumb_size;

	internal bool use_manual_thumb_size;

	internal int manual_thumb_size;

	internal bool vert;

	internal bool implicit_control;

	private int lastclick_pos;

	private int thumbclick_offset;

	private Rectangle dirty;

	internal ThumbMoving thumb_moving;

	private bool first_button_entered;

	private bool second_button_entered;

	private bool thumb_entered;

	private static object UIAScrollEvent;

	private static object UIAValueChangeEvent;

	internal Rectangle FirstArrowArea
	{
		get
		{
			return default(Rectangle);
		}
		set
		{
		}
	}

	internal Rectangle SecondArrowArea
	{
		get
		{
			return default(Rectangle);
		}
		set
		{
		}
	}

	private int MaximumAllowed => 0;

	internal Rectangle ThumbPos
	{
		get
		{
			return default(Rectangle);
		}
		set
		{
		}
	}

	internal bool FirstButtonEntered
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	internal bool SecondButtonEntered
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	internal bool ThumbEntered
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	internal bool ThumbPressed
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Windows.Forms.ScrollBar" /> is automatically resized to fit its contents.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ScrollBar" /> should be automatically resized to fit its contents; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool AutoSize
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the background color for the control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the background color of the control. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultBackColor" /> property.</returns>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override Color BackColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the background image displayed in the control.</summary>
	/// <returns>An <see cref="T:System.Drawing.Image" /> that represents the image to display in the background of the control.</returns>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override Image BackgroundImage => null;

	/// <summary>Gets or sets the background image layout as defined in the <see cref="T:System.Windows.Forms.ImageLayout" /> enumeration.</summary>
	/// <returns>One of the values of <see cref="T:System.Windows.Forms.ImageLayout" /> (Center , None, Stretch, Tile, or Zoom). Tile is the default value.</returns>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override ImageLayout BackgroundImageLayout
	{
		get
		{
			return default(ImageLayout);
		}
		set
		{
		}
	}

	/// <summary>Gets the required creation parameters when the control handle is created.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.CreateParams" /> that contains the required creation parameters when the handle to the control is created.</returns>
	protected override CreateParams CreateParams => null;

	/// <summary>Gets the default distance between the <see cref="T:System.Windows.Forms.ScrollBar" /> control edges and its contents.</summary>
	/// <returns>
	///   <see cref="F:System.Windows.Forms.Padding.Empty" /> in all cases.</returns>
	protected override Padding DefaultMargin => default(Padding);

	/// <summary>Gets or sets the font of the text displayed by the control.</summary>
	/// <returns>The <see cref="T:System.Drawing.Font" /> to apply to the text displayed by the control. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultFont" /> property.</returns>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override Font Font
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the foreground color of the scroll bar control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the foreground color for this scroll bar control. The default is the foreground color of the parent control.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override Color ForeColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value to be added to or subtracted from the <see cref="P:System.Windows.Forms.ScrollBar.Value" /> property when the scroll box is moved a large distance.</summary>
	/// <returns>A numeric value. The default value is 10.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The assigned value is less than 0.</exception>
	[RefreshProperties(RefreshProperties.Repaint)]
	[MWFDescription("Scroll amount when clicking in the scroll area")]
	[DefaultValue(10)]
	[MWFCategory("Behaviour")]
	public int LargeChange
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the upper limit of values of the scrollable range.</summary>
	/// <returns>A numeric value. The default value is 100.</returns>
	[MWFDescription("Highest value for scrollbar")]
	[DefaultValue(100)]
	[RefreshProperties(RefreshProperties.Repaint)]
	[MWFCategory("Behaviour")]
	public int Maximum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the lower limit of values of the scrollable range.</summary>
	/// <returns>A numeric value. The default value is 0.</returns>
	[MWFDescription("Smallest value for scrollbar")]
	[MWFCategory("Behaviour")]
	[RefreshProperties(RefreshProperties.Repaint)]
	[DefaultValue(0)]
	public int Minimum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the value to be added to or subtracted from the <see cref="P:System.Windows.Forms.ScrollBar.Value" /> property when the scroll box is moved a small distance.</summary>
	/// <returns>A numeric value. The default value is 1.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The assigned value is less than 0.</exception>
	[MWFDescription("Scroll amount when clicking scroll arrows")]
	[MWFCategory("Behaviour")]
	[DefaultValue(1)]
	public int SmallChange
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the text associated with this control.</summary>
	/// <returns>The text associated with this control.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Bindable(false)]
	public override string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a numeric value that represents the current position of the scroll box on the scroll bar control.</summary>
	/// <returns>A numeric value that is within the <see cref="P:System.Windows.Forms.ScrollBar.Minimum" /> and <see cref="P:System.Windows.Forms.ScrollBar.Maximum" /> range. The default value is 0.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The assigned value is less than the <see cref="P:System.Windows.Forms.ScrollBar.Minimum" /> property value.  
	///  -or-  
	///  The assigned value is greater than the <see cref="P:System.Windows.Forms.ScrollBar.Maximum" /> property value.</exception>
	[MWFCategory("Behaviour")]
	[Bindable(true)]
	[MWFDescription("Current value for scrollbar")]
	[DefaultValue(0)]
	public int Value
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Occurs when the scroll box has been moved by either a mouse or keyboard action.</summary>
	public event ScrollEventHandler Scroll
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the <see cref="P:System.Windows.Forms.ScrollBar.Value" /> property is changed, either by a <see cref="E:System.Windows.Forms.ScrollBar.Scroll" /> event or programmatically.</summary>
	public event EventHandler ValueChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ScrollBar" /> class.</summary>
	public ScrollBar()
	{
	}

	internal void SetValues(int maximum, int large_change)
	{
	}

	internal void SetValues(int minimum, int maximum, int small_change, int large_change)
	{
	}

	/// <summary>Returns the bounds to use when the <see cref="T:System.Windows.Forms.ScrollBar" /> is scaled by a specified amount.</summary>
	/// <param name="bounds">A <see cref="T:System.Drawing.Rectangle" /> that specifies the initial bounds.</param>
	/// <param name="factor">A <see cref="T:System.Drawing.SizeF" /> that indicates the amount the current bounds should be increased by.</param>
	/// <param name="specified">A bitwise combination of the <see cref="T:System.Windows.Forms.BoundsSpecified" /> values that indicate the how to define the control's size and position returned by <see cref="M:System.Windows.Forms.ScrollBar.GetScaledBounds(System.Drawing.Rectangle,System.Drawing.SizeF,System.Windows.Forms.BoundsSpecified)" />.</param>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> specifying the scaled bounds.</returns>
	protected override Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified)
	{
		return default(Rectangle);
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.EnabledChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnEnabledChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.HandleCreated" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnHandleCreated(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ScrollBar.Scroll" /> event.</summary>
	/// <param name="se">A <see cref="T:System.Windows.Forms.ScrollEventArgs" /> that contains the event data.</param>
	protected virtual void OnScroll(ScrollEventArgs se)
	{
	}

	private void SendWMScroll(ScrollBarCommands cmd)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ScrollBar.ValueChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnValueChanged(EventArgs e)
	{
	}

	/// <summary>Returns a string that represents the <see cref="T:System.Windows.Forms.ScrollBar" /> control.</summary>
	/// <returns>A string that represents the current <see cref="T:System.Windows.Forms.ScrollBar" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Overrides the <see cref="M:System.Windows.Forms.Control.WndProc(System.Windows.Forms.Message@)" /> method.</summary>
	/// <param name="m">A Windows Message object.</param>
	protected override void WndProc(ref Message m)
	{
	}

	private void CalcButtonSizes()
	{
	}

	private void CalcThumbArea()
	{
	}

	private void LargeIncrement()
	{
	}

	private void LargeDecrement()
	{
	}

	private void OnResizeSB(object o, EventArgs e)
	{
	}

	internal override void OnPaintInternal(PaintEventArgs pevent)
	{
	}

	private void OnTimer(object source, EventArgs e)
	{
	}

	private void MoveThumb(Rectangle original_thumbpos, int value)
	{
	}

	private void OnMouseMoveSB(object sender, MouseEventArgs e)
	{
	}

	private void OnMouseDownSB(object sender, MouseEventArgs e)
	{
	}

	private void OnMouseUpSB(object sender, MouseEventArgs e)
	{
	}

	private void OnKeyDownSB(object o, KeyEventArgs key)
	{
	}

	internal void SafeValueSet(int value)
	{
	}

	private void SetEndPosition()
	{
	}

	private void SetHomePosition()
	{
	}

	private void SmallIncrement()
	{
	}

	private void SmallDecrement()
	{
	}

	private void SetHoldButtonClickTimer()
	{
	}

	private void SetRepeatButtonTimer()
	{
	}

	private void SetHoldThumbAreaTimer()
	{
	}

	private void SetRepeatThumbAreaTimer()
	{
	}

	private void UpdatePos(int newPos, bool update_thumbpos)
	{
	}

	private void UpdateThumbPos(int pixel, bool dirty, bool update_value)
	{
	}

	private void SetValue(int value)
	{
	}

	private void ClearDirty()
	{
	}

	private void Dirty(Rectangle r)
	{
	}

	private void DirtyThumbArea()
	{
	}

	private void InvalidateDirty()
	{
	}

	private void OnMouseEnter(object sender, EventArgs e)
	{
	}

	private void OnMouseLeave(object sender, EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseWheel" /> event</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /></param>
	protected override void OnMouseWheel(MouseEventArgs e)
	{
	}

	internal void OnUIAScroll(ScrollEventArgs args)
	{
	}

	internal void OnUIAValueChanged(ScrollEventArgs args)
	{
	}
}
