using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Represents a control that allows the user to select a single item from a list that is displayed when the user clicks a <see cref="T:System.Windows.Forms.ToolStripDropDownButton" />. Although <see cref="T:System.Windows.Forms.ToolStripDropDownMenu" /> and <see cref="T:System.Windows.Forms.ToolStripDropDown" /> replace and add functionality to the <see cref="T:System.Windows.Forms.Menu" /> control of previous versions, <see cref="T:System.Windows.Forms.Menu" /> is retained for both backward compatibility and future use if you choose.</summary>
[Designer("System.Windows.Forms.Design.ToolStripDropDownDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class ToolStripDropDown : ToolStrip
{
	private bool allow_transparency;

	private bool auto_close;

	private bool drop_shadow_enabled;

	private double opacity;

	private ToolStripItem owner_item;

	private static object ClosedEvent;

	private static object ClosingEvent;

	private static object OpenedEvent;

	private static object OpeningEvent;

	private static object ScrollEvent;

	/// <summary>This property is not relevant to this class.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.AnchorStyles" /> values.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override AnchorStyles Anchor
	{
		get
		{
			return default(AnchorStyles);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> automatically adjusts its size when the form is resized.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> control automatically resizes; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
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

	/// <summary>Gets or sets the direction in which the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> is displayed relative to the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripDropDownDirection" /> values.</returns>
	public override ToolStripDropDownDirection DefaultDropDownDirection
	{
		get
		{
			return default(ToolStripDropDownDirection);
		}
		set
		{
		}
	}

	/// <summary>This property is not relevant to this class.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.DockStyle" /> values.</returns>
	[Browsable(false)]
	[DefaultValue(DockStyle.None)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public override DockStyle Dock
	{
		get
		{
			return default(DockStyle);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the font of the text displayed on the <see cref="T:System.Windows.Forms.ToolStripDropDown" />.</summary>
	/// <returns>The <see cref="T:System.Drawing.Font" /> to apply to the text displayed by the control.</returns>
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

	/// <summary>This property is not relevant to this class.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripGripStyle" /> values.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DefaultValue(ToolStripGripStyle.Hidden)]
	public new ToolStripGripStyle GripStyle
	{
		set
		{
		}
	}

	/// <summary>This property is not relevant to this class.</summary>
	/// <returns>The coordinates of the upper-left corner of the control relative to the upper-left corner of its container.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public new Point Location
	{
		get
		{
			return default(Point);
		}
		set
		{
		}
	}

	/// <summary>Determines the opacity of the form.</summary>
	/// <returns>The level of opacity for the form. The default is 1.00.</returns>
	[DefaultValue(1.0)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[TypeConverter(typeof(OpacityConverter))]
	public double Opacity => 0.0;

	/// <summary>Gets or sets the <see cref="T:System.Windows.Forms.ToolStripItem" /> that is the owner of this <see cref="T:System.Windows.Forms.ToolStripDropDown" />.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.ToolStripItem" /> that is the owner of this <see cref="T:System.Windows.Forms.ToolStripDropDown" />. The default value is <see langword="null" />.</returns>
	[DefaultValue(null)]
	[Browsable(false)]
	public ToolStripItem OwnerItem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether control's elements are aligned to support locales using right-to-left fonts.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.RightToLeft" /> values. The default is <see cref="F:System.Windows.Forms.RightToLeft.Inherit" />.</returns>
	[Localizable(true)]
	[AmbientValue(RightToLeft.Inherit)]
	public override RightToLeft RightToLeft => default(RightToLeft);

	/// <summary>Specifies the direction in which to draw the text on the item.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripTextDirection" /> values. The default is <see cref="F:System.Windows.Forms.ToolStripTextDirection.Horizontal" />.</returns>
	[Browsable(false)]
	[DefaultValue(ToolStripTextDirection.Horizontal)]
	public override ToolStripTextDirection TextDirection => default(ToolStripTextDirection);

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> is visible or hidden.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> is visible; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[Localizable(true)]
	[DefaultValue(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new bool Visible => false;

	/// <summary>Gets parameters of a new window.</summary>
	/// <returns>An object of type <see cref="T:System.Windows.Forms.CreateParams" /> used when creating a new window.</returns>
	protected override CreateParams CreateParams => null;

	/// <summary>Gets the docking location of the <see cref="T:System.Windows.Forms.ToolStrip" />, indicating which borders are docked to the container.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.DockStyle" /> values. The default is Top.</returns>
	protected override DockStyle DefaultDock => default(DockStyle);

	/// <summary>Gets the internal spacing, in pixels, of the contents of a <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Padding" /> value of <c>(0, 0, 1, 0)</c>.</returns>
	protected override Padding DefaultPadding => default(Padding);

	/// <summary>Gets a value indicating whether ToolTips are shown for the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> by default.</summary>
	/// <returns>
	///   <see langword="true" /> in all cases.</returns>
	protected override bool DefaultShowItemToolTips => false;

	/// <summary>Gets or sets a value indicating whether the form should be displayed as a topmost form.</summary>
	/// <returns>
	///   <see langword="true" /> in all cases.</returns>
	protected virtual bool TopMost => false;

	internal override bool ActivateOnShow => false;

	internal ToolStripItem TopLevelOwnerItem => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> class.</summary>
	public ToolStripDropDown()
	{
	}

	/// <summary>Closes the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> control for the specified reason.</summary>
	/// <param name="reason">One of the <see cref="T:System.Windows.Forms.ToolStripDropDownCloseReason" /> values.</param>
	public void Close(ToolStripDropDownCloseReason reason)
	{
	}

	/// <summary>Positions the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> relative to the specified screen location.</summary>
	/// <param name="screenLocation">The horizontal and vertical location of the screen's upper-left corner, in pixels.</param>
	public void Show(Point screenLocation)
	{
	}

	/// <summary>Positions the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> relative to the specified control location.</summary>
	/// <param name="control">The control (typically, a <see cref="T:System.Windows.Forms.ToolStripDropDownButton" />) that is the reference point for the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> position.</param>
	/// <param name="position">The horizontal and vertical location of the reference control's upper-left corner, in pixels.</param>
	/// <exception cref="T:System.ArgumentNullException">The control specified by the <paramref name="control" /> parameter is <see langword="null" />.</exception>
	public void Show(Control control, Point position)
	{
	}

	/// <summary>Positions the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> relative to the specified control location and with the specified direction relative to the parent control.</summary>
	/// <param name="position">The horizontal and vertical location of the reference control's upper-left corner, in pixels.</param>
	/// <param name="direction">One of the <see cref="T:System.Windows.Forms.ToolStripDropDownDirection" /> values.</param>
	public void Show(Point position, ToolStripDropDownDirection direction)
	{
	}

	/// <summary>Creates a handle for the control.</summary>
	protected override void CreateHandle()
	{
	}

	/// <summary>Applies various layout options to the <see cref="T:System.Windows.Forms.ToolStripDropDown" />.</summary>
	/// <param name="style">One of the <see cref="T:System.Windows.Forms.ToolStripLayoutStyle" /> values. The possibilities are <see cref="F:System.Windows.Forms.ToolStripLayoutStyle.Flow" />, <see cref="F:System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow" />, <see cref="F:System.Windows.Forms.ToolStripLayoutStyle.StackWithOverflow" />, <see cref="F:System.Windows.Forms.ToolStripLayoutStyle.Table" />, and <see cref="F:System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow" />.</param>
	/// <returns>The <see cref="T:System.Windows.Forms.LayoutSettings" /> for this <see cref="T:System.Windows.Forms.ToolStripDropDown" />.</returns>
	protected override LayoutSettings CreateLayoutSettings(ToolStripLayoutStyle style)
	{
		return null;
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripDropDown.Closed" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripDropDownClosedEventArgs" /> that contains the event data.</param>
	protected virtual void OnClosed(ToolStripDropDownClosedEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripDropDown.Closing" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripDropDownClosingEventArgs" /> that contains the event data.</param>
	protected virtual void OnClosing(ToolStripDropDownClosingEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.HandleCreated" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnHandleCreated(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStrip.ItemClicked" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemClickedEventArgs" /> that contains the event data.</param>
	protected override void OnItemClicked(ToolStripItemClickedEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Layout" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.LayoutEventArgs" /> that contains the event data.</param>
	protected override void OnLayout(LayoutEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.MouseUp" /> event.</summary>
	/// <param name="mea">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	protected override void OnMouseUp(MouseEventArgs mea)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripDropDown.Opened" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnOpened(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripDropDown.Opening" /> event.</summary>
	/// <param name="e">A <see cref="T:System.ComponentModel.CancelEventArgs" /> that contains the event data.</param>
	protected virtual void OnOpening(CancelEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.ParentChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnParentChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.VisibleChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnVisibleChanged(EventArgs e)
	{
	}

	/// <summary>Processes a dialog box character.</summary>
	/// <param name="charCode">The character to process.</param>
	/// <returns>
	///   <see langword="true" /> if the character was processed by the control; otherwise, <see langword="false" />.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override bool ProcessDialogChar(char charCode)
	{
		return false;
	}

	/// <summary>Processes a dialog box key.</summary>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
	/// <returns>
	///   <see langword="true" /> if the key was processed by the control; otherwise, <see langword="false" />.</returns>
	protected override bool ProcessDialogKey(Keys keyData)
	{
		return false;
	}

	/// <summary>Processes a mnemonic character.</summary>
	/// <param name="charCode">The character to process.</param>
	/// <returns>
	///   <see langword="true" /> if the character was processed as a mnemonic by the control; otherwise, <see langword="false" />.</returns>
	protected override bool ProcessMnemonic(char charCode)
	{
		return false;
	}

	/// <summary>Scales a control's location, size, padding and margin.</summary>
	/// <param name="factor">The factor by which the height and width of the control will be scaled.</param>
	/// <param name="specified">A value that specifies the bounds of the control to use when defining its size and position.</param>
	protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
	{
	}

	/// <summary>This method is not relevant to this class.</summary>
	/// <param name="dx">The horizontal scaling factor.</param>
	/// <param name="dy">The vertical scaling factor.</param>
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override void ScaleCore(float dx, float dy)
	{
	}

	/// <summary>Performs the work of setting the specified bounds of this control.</summary>
	/// <param name="x">The new <see cref="P:System.Windows.Forms.Control.Left" /> property value of the control.</param>
	/// <param name="y">The new <see cref="P:System.Windows.Forms.Control.Top" /> property value of the control.</param>
	/// <param name="width">The new <see cref="P:System.Windows.Forms.Control.Width" /> property value of the control.</param>
	/// <param name="height">The new <see cref="P:System.Windows.Forms.Control.Height" /> property value of the control.</param>
	/// <param name="specified">A bitwise combination of the <see cref="T:System.Windows.Forms.BoundsSpecified" /> values.</param>
	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
	}

	/// <summary>Adjusts the size of the owner <see cref="T:System.Windows.Forms.ToolStrip" /> to accommodate the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> if the owner <see cref="T:System.Windows.Forms.ToolStrip" /> is currently displayed, or clears and resets active <see cref="T:System.Windows.Forms.ToolStripDropDown" /> child controls of the <see cref="T:System.Windows.Forms.ToolStrip" /> if the <see cref="T:System.Windows.Forms.ToolStrip" /> is not currently displayed.</summary>
	/// <param name="visible">
	///   <see langword="true" /> if the owner <see cref="T:System.Windows.Forms.ToolStrip" /> is currently displayed; otherwise, <see langword="false" />.</param>
	protected override void SetVisibleCore(bool visible)
	{
	}

	/// <summary>Processes Windows messages.</summary>
	/// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
	protected override void WndProc(ref Message m)
	{
	}

	internal override void Dismiss(ToolStripDropDownCloseReason reason)
	{
	}

	internal override ToolStrip GetTopLevelToolStrip()
	{
		return null;
	}

	internal override bool ProcessArrowKey(Keys keyData)
	{
		return false;
	}

	internal override ToolStripItem SelectNextToolStripItem(ToolStripItem start, bool forward)
	{
		return null;
	}

	private void ToolStripMenuTracker_AppFocusChange(object sender, EventArgs e)
	{
	}

	private void ToolStripMenuTracker_AppClicked(object sender, EventArgs e)
	{
	}
}
