using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms.Layout;

namespace System.Windows.Forms;

/// <summary>Provides a container for Windows toolbar objects.</summary>
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[DefaultEvent("ItemClicked")]
[DefaultProperty("Items")]
[ComVisible(true)]
[Designer("System.Windows.Forms.Design.ToolStripDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[DesignerSerializer("System.Windows.Forms.Design.ToolStripCodeDomSerializer, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class ToolStrip : ScrollableControl, IDisposable, IComponent
{
	private bool allow_merge;

	private Color back_color;

	private bool can_overflow;

	private ToolStrip currently_merged_with;

	private ToolStripDropDownDirection default_drop_down_direction;

	internal ToolStripItemCollection displayed_items;

	private Color fore_color;

	private Padding grip_margin;

	private ToolStripGripStyle grip_style;

	private List<ToolStripItem> hidden_merged_items;

	private ImageList image_list;

	private Size image_scaling_size;

	private bool is_currently_merged;

	private ToolStripItemCollection items;

	private bool keyboard_active;

	private LayoutEngine layout_engine;

	private LayoutSettings layout_settings;

	private ToolStripLayoutStyle layout_style;

	private Orientation orientation;

	private ToolStripOverflowButton overflow_button;

	private List<ToolStripItem> pre_merge_items;

	private ToolStripRenderer renderer;

	private ToolStripRenderMode render_mode;

	private ToolStripTextDirection text_direction;

	private Timer tooltip_timer;

	private ToolTip tooltip_window;

	private bool show_item_tool_tips;

	private ToolStripItem mouse_currently_over;

	internal bool menu_selected;

	private ToolStripItem tooltip_currently_showing;

	private static object BeginDragEvent;

	private static object EndDragEvent;

	private static object ItemClickedEvent;

	private static object ItemRemovedEvent;

	private static object LayoutCompletedEvent;

	private static object LayoutStyleChangedEvent;

	private static object PaintGripEvent;

	private static object RendererChangedEvent;

	/// <summary>Gets or sets a value indicating whether drag-and-drop and item reordering are handled through events that you implement.</summary>
	/// <returns>
	///   <see langword="true" /> to control drag-and-drop and item reordering through events that you implement; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <see cref="P:System.Windows.Forms.ToolStrip.AllowDrop" /> and <see cref="P:System.Windows.Forms.ToolStrip.AllowItemReorder" /> are both set to <see langword="true" />.</exception>
	[System.MonoTODO("Stub, does nothing")]
	public override bool AllowDrop => false;

	/// <summary>Gets or sets a value indicating whether multiple <see cref="T:System.Windows.Forms.MenuStrip" />, <see cref="T:System.Windows.Forms.ToolStripDropDownMenu" />, <see cref="T:System.Windows.Forms.ToolStripMenuItem" />, and other types can be combined.</summary>
	/// <returns>
	///   <see langword="true" /> if combining of types is allowed; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(true)]
	public bool AllowMerge => false;

	/// <summary>Gets or sets the edges of the container to which a <see cref="T:System.Windows.Forms.ToolStrip" /> is bound and determines how a <see cref="T:System.Windows.Forms.ToolStrip" /> is resized with its parent.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.AnchorStyles" /> values.</returns>
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

	/// <summary>This property is not relevant for this class.</summary>
	/// <returns>
	///   <see langword="true" /> to automatically scroll; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.NotSupportedException">Automatic scrolling is not supported by <see cref="T:System.Windows.Forms.ToolStrip" /> controls.</exception>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override bool AutoScroll => false;

	/// <summary>Gets or sets a value indicating whether the control is automatically resized to display its entire contents.</summary>
	/// <returns>
	///   <see langword="true" /> if the control adjusts its width to closely fit its contents; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(true)]
	[DefaultValue(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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

	/// <summary>Gets or sets the background color for the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the background color of the <see cref="T:System.Windows.Forms.ToolStrip" />. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultBackColor" /> property.</returns>
	public new Color BackColor => default(Color);

	/// <summary>Gets or sets the binding context for the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.BindingContext" /> for the <see cref="T:System.Windows.Forms.ToolStrip" />.</returns>
	public override BindingContext BindingContext
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether items in the <see cref="T:System.Windows.Forms.ToolStrip" /> can be sent to an overflow menu.</summary>
	/// <returns>
	///   <see langword="true" /> to send <see cref="T:System.Windows.Forms.ToolStrip" /> items to an overflow menu; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool CanOverflow => false;

	/// <summary>Gets or sets the cursor that is displayed when the mouse pointer is over the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Cursor" /> that represents the cursor to display when the mouse pointer is over the <see cref="T:System.Windows.Forms.ToolStrip" />.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override Cursor Cursor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value representing the default direction in which a <see cref="T:System.Windows.Forms.ToolStripDropDown" /> control is displayed relative to the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripDropDownDirection" /> values.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The specified value is not one of the <see cref="T:System.Windows.Forms.ToolStripDropDownDirection" /> values.</exception>
	[Browsable(false)]
	public virtual ToolStripDropDownDirection DefaultDropDownDirection
	{
		get
		{
			return default(ToolStripDropDownDirection);
		}
		set
		{
		}
	}

	/// <summary>Retrieves the current display rectangle.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> representing the <see cref="T:System.Windows.Forms.ToolStrip" /> area for item layout.</returns>
	public override Rectangle DisplayRectangle => default(Rectangle);

	/// <summary>Gets or sets which <see cref="T:System.Windows.Forms.ToolStrip" /> borders are docked to its parent control and determines how a <see cref="T:System.Windows.Forms.ToolStrip" /> is resized with its parent.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.DockStyle" /> values. The default value is <see cref="F:System.Windows.Forms.DockStyle.Top" />.</returns>
	[DefaultValue(DockStyle.Top)]
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

	/// <summary>Gets or sets the font used to display text in the control.</summary>
	/// <returns>The current default font.</returns>
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

	/// <summary>Gets or sets the foreground color of the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> representing the foreground color.</returns>
	[Browsable(false)]
	public new Color ForeColor => default(Color);

	/// <summary>Gets the orientation of the <see cref="T:System.Windows.Forms.ToolStrip" /> move handle.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripGripDisplayStyle" /> values. Possible values are <see cref="F:System.Windows.Forms.ToolStripGripDisplayStyle.Horizontal" /> and <see cref="F:System.Windows.Forms.ToolStripGripDisplayStyle.Vertical" />.</returns>
	[Browsable(false)]
	public ToolStripGripDisplayStyle GripDisplayStyle => default(ToolStripGripDisplayStyle);

	/// <summary>Gets or sets the space around the <see cref="T:System.Windows.Forms.ToolStrip" /> move handle.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Padding" />, which represents the spacing.</returns>
	public Padding GripMargin => default(Padding);

	/// <summary>Gets the boundaries of the <see cref="T:System.Windows.Forms.ToolStrip" /> move handle.</summary>
	/// <returns>An object of type <see cref="T:System.Drawing.Rectangle" />, representing the move handle boundaries. If the boundaries are not visible, the <see cref="P:System.Windows.Forms.ToolStrip.GripRectangle" /> property returns <see cref="F:System.Drawing.Rectangle.Empty" />.</returns>
	[Browsable(false)]
	public Rectangle GripRectangle => default(Rectangle);

	/// <summary>Gets or sets whether the <see cref="T:System.Windows.Forms.ToolStrip" /> move handle is visible or hidden.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripGripStyle" /> values. The default value is <see cref="F:System.Windows.Forms.ToolStripGripStyle.Visible" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The specified value is not one of the <see cref="T:System.Windows.Forms.ToolStripGripStyle" /> values.</exception>
	[DefaultValue(ToolStripGripStyle.Visible)]
	public ToolStripGripStyle GripStyle
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the image list that contains the image displayed on a <see cref="T:System.Windows.Forms.ToolStrip" /> item.</summary>
	/// <returns>An object of type <see cref="T:System.Windows.Forms.ImageList" />.</returns>
	[Browsable(false)]
	[DefaultValue(null)]
	public ImageList ImageList => null;

	/// <summary>Gets or sets the size, in pixels, of an image used on a <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> value representing the size of the image, in pixels. The default is 16 x 16 pixels.</returns>
	[DefaultValue("{Width=16, Height=16}")]
	public Size ImageScalingSize => default(Size);

	/// <summary>Gets all the items that belong to a <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>An object of type <see cref="T:System.Windows.Forms.ToolStripItemCollection" />, representing all the elements contained by a <see cref="T:System.Windows.Forms.ToolStrip" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[MergableProperty(false)]
	public virtual ToolStripItemCollection Items => null;

	/// <summary>Passes a reference to the cached <see cref="P:System.Windows.Forms.Control.LayoutEngine" /> returned by the layout engine interface.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Layout.LayoutEngine" /> that represents the cached layout engine returned by the layout engine interface.</returns>
	public override LayoutEngine LayoutEngine => null;

	/// <summary>Gets or sets layout scheme characteristics.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.LayoutSettings" /> representing the layout scheme characteristics.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DefaultValue(null)]
	public LayoutSettings LayoutSettings => null;

	/// <summary>Gets or sets a value indicating how the <see cref="T:System.Windows.Forms.ToolStrip" /> lays out the items collection.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripLayoutStyle" /> values. The default value is <see cref="F:System.Windows.Forms.ToolStripLayoutStyle.StackWithOverflow" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value of <see cref="P:System.Windows.Forms.ToolStrip.LayoutStyle" /> is not one of the <see cref="T:System.Windows.Forms.ToolStripLayoutStyle" /> values.</exception>
	[AmbientValue(ToolStripLayoutStyle.StackWithOverflow)]
	public ToolStripLayoutStyle LayoutStyle
	{
		get
		{
			return default(ToolStripLayoutStyle);
		}
		set
		{
		}
	}

	/// <summary>Gets the orientation of the <see cref="T:System.Windows.Forms.ToolStripPanel" />.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.Orientation" /> values. The default is <see cref="F:System.Windows.Forms.Orientation.Horizontal" />.</returns>
	[Browsable(false)]
	public Orientation Orientation => default(Orientation);

	/// <summary>Gets the <see cref="T:System.Windows.Forms.ToolStripItem" /> that is the overflow button for a <see cref="T:System.Windows.Forms.ToolStrip" /> with overflow enabled.</summary>
	/// <returns>An object of type <see cref="T:System.Windows.Forms.ToolStripOverflowButton" /> with its <see cref="T:System.Windows.Forms.ToolStripItemAlignment" /> set to <see cref="F:System.Windows.Forms.ToolStripItemAlignment.Right" /> and its <see cref="T:System.Windows.Forms.ToolStripItemOverflow" /> value set to <see cref="F:System.Windows.Forms.ToolStripItemOverflow.Never" />.</returns>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public ToolStripOverflowButton OverflowButton => null;

	/// <summary>Gets or sets a <see cref="T:System.Windows.Forms.ToolStripRenderer" /> used to customize the look and feel of a <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ToolStripRenderer" /> used to customize the look and feel of a <see cref="T:System.Windows.Forms.ToolStrip" />.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public ToolStripRenderer Renderer
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value that indicates which visual styles will be applied to the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>A value that indicates the visual style to apply. The default is <see cref="F:System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value being set is not one of the <see cref="T:System.Windows.Forms.ToolStripRenderMode" /> values.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <see cref="T:System.Windows.Forms.ToolStripRenderMode" /> is set to <see cref="F:System.Windows.Forms.ToolStripRenderMode.Custom" /> without the <see cref="P:System.Windows.Forms.ToolStrip.Renderer" /> property being assigned to a new instance of <see cref="T:System.Windows.Forms.ToolStripRenderer" />.</exception>
	public ToolStripRenderMode RenderMode => default(ToolStripRenderMode);

	/// <summary>Gets or sets the direction in which to draw text on a <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripTextDirection" /> values. The default is <see cref="F:System.Windows.Forms.ToolStripTextDirection.Horizontal" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The specified value is not one of the <see cref="T:System.Windows.Forms.ToolStripTextDirection" /> values.</exception>
	[DefaultValue(ToolStripTextDirection.Horizontal)]
	public virtual ToolStripTextDirection TextDirection => default(ToolStripTextDirection);

	/// <summary>Gets the docking location of the <see cref="T:System.Windows.Forms.ToolStrip" />, indicating which borders are docked to the container.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.DockStyle" /> values. The default is <see cref="F:System.Windows.Forms.DockStyle.Top" />.</returns>
	protected virtual DockStyle DefaultDock => default(DockStyle);

	/// <summary>Gets the default spacing, in pixels, between the sizing grip and the edges of the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>
	///   <see cref="T:System.Windows.Forms.Padding" /> values representing the spacing, in pixels.</returns>
	protected virtual Padding DefaultGripMargin => default(Padding);

	/// <summary>Gets the spacing, in pixels, between the <see cref="T:System.Windows.Forms.ToolStrip" /> and the <see cref="T:System.Windows.Forms.ToolStripContainer" />.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.Padding" /> values. The default is <see cref="F:System.Windows.Forms.Padding.Empty" />.</returns>
	protected override Padding DefaultMargin => default(Padding);

	/// <summary>Gets the internal spacing, in pixels, of the contents of a <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Padding" /> value of <c>(0, 0, 1, 0)</c>.</returns>
	protected override Padding DefaultPadding => default(Padding);

	/// <summary>Gets a value indicating whether ToolTips are shown for the <see cref="T:System.Windows.Forms.ToolStrip" /> by default.</summary>
	/// <returns>
	///   <see langword="true" /> in all cases.</returns>
	protected virtual bool DefaultShowItemToolTips => false;

	/// <summary>Gets the default size of the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>The default <see cref="T:System.Drawing.Size" /> of the <see cref="T:System.Windows.Forms.ToolStrip" />.</returns>
	protected override Size DefaultSize => default(Size);

	/// <summary>Gets the subset of items that are currently displayed on the <see cref="T:System.Windows.Forms.ToolStrip" />, including items that are automatically added into the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ToolStripItemCollection" /> representing the items that are currently displayed on the <see cref="T:System.Windows.Forms.ToolStrip" />.</returns>
	protected internal virtual ToolStripItemCollection DisplayedItems => null;

	internal virtual bool KeyboardActive
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private Timer ToolTipTimer => null;

	private ToolTip ToolTipWindow => null;

	internal ToolStrip CurrentlyMergedWith
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal List<ToolStripItem> HiddenMergedItems => null;

	internal bool IsCurrentlyMerged
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Occurs when a new <see cref="T:System.Windows.Forms.ToolStripItem" /> is added to the <see cref="T:System.Windows.Forms.ToolStripItemCollection" />.</summary>
	public event ToolStripItemEventHandler ItemAdded
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStrip" /> class.</summary>
	public ToolStrip()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStrip" /> class with the specified array of <see cref="T:System.Windows.Forms.ToolStripItem" />s.</summary>
	/// <param name="items">An array of <see cref="T:System.Windows.Forms.ToolStripItem" /> objects.</param>
	public ToolStrip(params ToolStripItem[] items)
	{
	}

	/// <summary>Returns the item located at the specified point in the client area of the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <param name="point">The <see cref="T:System.Drawing.Point" /> at which to search for the <see cref="T:System.Windows.Forms.ToolStripItem" />.</param>
	/// <returns>The <see cref="T:System.Windows.Forms.ToolStripItem" /> at the specified location, or <see langword="null" /> if the <see cref="T:System.Windows.Forms.ToolStripItem" /> is not found.</returns>
	public ToolStripItem GetItemAt(Point point)
	{
		return null;
	}

	/// <summary>Returns the item located at the specified x- and y-coordinates of the <see cref="T:System.Windows.Forms.ToolStrip" /> client area.</summary>
	/// <param name="x">The horizontal coordinate, in pixels, from the left edge of the client area.</param>
	/// <param name="y">The vertical coordinate, in pixels, from the top edge of the client area.</param>
	/// <returns>The <see cref="T:System.Windows.Forms.ToolStripItem" /> located at the specified location, or <see langword="null" /> if the <see cref="T:System.Windows.Forms.ToolStripItem" /> is not found.</returns>
	public ToolStripItem GetItemAt(int x, int y)
	{
		return null;
	}

	/// <summary>Retrieves the next <see cref="T:System.Windows.Forms.ToolStripItem" /> from the specified reference point and moving in the specified direction.</summary>
	/// <param name="start">The <see cref="T:System.Windows.Forms.ToolStripItem" /> that is the reference point from which to begin the retrieval of the next item.</param>
	/// <param name="direction">One of the values of <see cref="T:System.Windows.Forms.ArrowDirection" /> that specifies the direction to move.</param>
	/// <returns>A <see cref="T:System.Windows.Forms.ToolStripItem" /> that is specified by the <paramref name="start" /> parameter and is next in the order as specified by the <paramref name="direction" /> parameter.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The specified value of the <paramref name="direction" /> parameter is not one of the values of <see cref="T:System.Windows.Forms.ArrowDirection" />.</exception>
	public virtual ToolStripItem GetNextItem(ToolStripItem start, ArrowDirection direction)
	{
		return null;
	}

	/// <summary>Returns a string that represents the <see cref="T:System.Windows.Forms.ToolStrip" /> control.</summary>
	/// <returns>A string that represents the <see cref="T:System.Windows.Forms.ToolStrip" /> control.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Creates a new instance of the control collection for the control.</summary>
	/// <returns>A new instance of <see cref="T:System.Windows.Forms.Control.ControlCollection" /> assigned to the control.</returns>
	protected override ControlCollection CreateControlsInstance()
	{
		return null;
	}

	/// <summary>Creates a default <see cref="T:System.Windows.Forms.ToolStripItem" /> with the specified text, image, and event handler on a new <see cref="T:System.Windows.Forms.ToolStrip" /> instance.</summary>
	/// <param name="text">The text to use for the <see cref="T:System.Windows.Forms.ToolStripItem" />. If the <paramref name="text" /> parameter is a hyphen (-), this method creates a <see cref="T:System.Windows.Forms.ToolStripSeparator" />.</param>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> to display on the <see cref="T:System.Windows.Forms.ToolStripItem" />.</param>
	/// <param name="onClick">An event handler that raises the <see cref="E:System.Windows.Forms.Control.Click" /> event when the <see cref="T:System.Windows.Forms.ToolStripItem" /> is clicked.</param>
	/// <returns>A <see cref="M:System.Windows.Forms.ToolStripButton.#ctor(System.String,System.Drawing.Image,System.EventHandler)" />, or a <see cref="T:System.Windows.Forms.ToolStripSeparator" /> if the <paramref name="text" /> parameter is a hyphen (-).</returns>
	protected internal virtual ToolStripItem CreateDefaultItem(string text, Image image, EventHandler onClick)
	{
		return null;
	}

	/// <summary>Specifies the visual arrangement for the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <param name="layoutStyle">The visual arrangement to be applied to the <see cref="T:System.Windows.Forms.ToolStrip" />.</param>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripLayoutStyle" /> values. The default is <see langword="null" />.</returns>
	protected virtual LayoutSettings CreateLayoutSettings(ToolStripLayoutStyle layoutStyle)
	{
		return null;
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.ToolStrip" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.DockChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnDockChanged(EventArgs e)
	{
	}

	/// <summary>Determines whether a character is an input character that the item recognizes.</summary>
	/// <param name="charCode">The character to test.</param>
	/// <returns>
	///   <see langword="true" /> if the character should be sent directly to the item and not preprocessed; otherwise, <see langword="false" />.</returns>
	protected override bool IsInputChar(char charCode)
	{
		return false;
	}

	/// <summary>Determines whether the specified key is a regular input key or a special key that requires preprocessing.</summary>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values.</param>
	/// <returns>
	///   <see langword="true" /> if the specified key is a regular input key; otherwise, <see langword="false" />.</returns>
	protected override bool IsInputKey(Keys keyData)
	{
		return false;
	}

	/// <summary>Raises the <see cref="P:System.Windows.Forms.Control.Enabled" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnEnabledChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.FontChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnFontChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.HandleCreated" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnHandleCreated(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.HandleDestroyed" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnHandleDestroyed(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Invalidated" /> event.</summary>
	/// <param name="e">An <see cref="T:System.Windows.Forms.InvalidateEventArgs" /> that contains the event data.</param>
	protected override void OnInvalidated(InvalidateEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStrip.ItemAdded" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnItemAdded(ToolStripItemEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStrip.ItemClicked" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemClickedEventArgs" /> that contains the event data.</param>
	protected virtual void OnItemClicked(ToolStripItemClickedEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStrip.ItemRemoved" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnItemRemoved(ToolStripItemEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Layout" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.LayoutEventArgs" /> that contains the event data.</param>
	protected override void OnLayout(LayoutEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStrip.LayoutCompleted" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnLayoutCompleted(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStrip.LayoutStyleChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnLayoutStyleChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Leave" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnLeave(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.LostFocus" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnLostFocus(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseCaptureChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseCaptureChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.</summary>
	/// <param name="mea">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	protected override void OnMouseDown(MouseEventArgs mea)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseLeave(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseMove" /> event.</summary>
	/// <param name="mea">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	protected override void OnMouseMove(MouseEventArgs mea)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseUp" /> event.</summary>
	/// <param name="mea">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	protected override void OnMouseUp(MouseEventArgs mea)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
	protected override void OnPaint(PaintEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event for the <see cref="T:System.Windows.Forms.ToolStrip" /> background.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains information about the control to paint.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnPaintBackground(PaintEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStrip.PaintGrip" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnPaintGrip(PaintEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStrip.RendererChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnRendererChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.RightToLeftChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnRightToLeftChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ScrollableControl.Scroll" /> event.</summary>
	/// <param name="se">A <see cref="T:System.Windows.Forms.ScrollEventArgs" /> that contains the event data.</param>
	protected override void OnScroll(ScrollEventArgs se)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.TabStopChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnTabStopChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.VisibleChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnVisibleChanged(EventArgs e)
	{
	}

	/// <summary>Processes a command key.</summary>
	/// <param name="m">A <see cref="T:System.Windows.Forms.Message" />, passed by reference, that represents the window message to process.</param>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
	/// <returns>
	///   <see langword="true" /> if the character was processed by the control; otherwise, <see langword="false" />.</returns>
	protected override bool ProcessCmdKey(ref Message m, Keys keyData)
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

	/// <summary>Activates a child control. Optionally specifies the direction in the tab order to select the control from.</summary>
	/// <param name="directed">
	///   <see langword="true" /> to specify the direction of the control to select; otherwise, <see langword="false" />.</param>
	/// <param name="forward">
	///   <see langword="true" /> to move forward in the tab order; <see langword="false" /> to move backward in the tab order.</param>
	protected override void Select(bool directed, bool forward)
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

	/// <summary>Resets the collection of displayed and overflow items after a layout is done.</summary>
	protected virtual void SetDisplayedItems()
	{
	}

	/// <summary>Enables you to change the parent <see cref="T:System.Windows.Forms.ToolStrip" /> of a <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <param name="item">The <see cref="T:System.Windows.Forms.ToolStripItem" /> whose <see cref="P:System.Windows.Forms.Control.Parent" /> property is to be changed.</param>
	/// <param name="parent">The <see cref="T:System.Windows.Forms.ToolStrip" /> that is the parent of the <see cref="T:System.Windows.Forms.ToolStripItem" /> referred to by the <paramref name="item" /> parameter.</param>
	protected internal static void SetItemParent(ToolStripItem item, ToolStrip parent)
	{
	}

	/// <summary>Retrieves a value that sets the <see cref="T:System.Windows.Forms.ToolStripItem" /> to the specified visibility state.</summary>
	/// <param name="visible">
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolStripItem" /> is visible; otherwise, <see langword="false" />.</param>
	protected override void SetVisibleCore(bool visible)
	{
	}

	/// <summary>Processes Windows messages.</summary>
	/// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
	protected override void WndProc(ref Message m)
	{
	}

	internal virtual Rectangle CalculateConnectedArea()
	{
		return default(Rectangle);
	}

	internal void ChangeSelection(ToolStripItem nextItem)
	{
	}

	internal virtual void Dismiss(ToolStripDropDownCloseReason reason)
	{
	}

	internal ToolStripItem GetCurrentlySelectedItem()
	{
		return null;
	}

	internal ToolStripItem GetCurrentlyFocusedItem()
	{
		return null;
	}

	internal override Size GetPreferredSizeCore(Size proposedSize)
	{
		return default(Size);
	}

	internal virtual Size GetToolStripPreferredSize(Size proposedSize)
	{
		return default(Size);
	}

	internal virtual ToolStrip GetTopLevelToolStrip()
	{
		return null;
	}

	internal virtual void HandleItemClick(ToolStripItem dismissingItem)
	{
	}

	internal void HideMenus(bool release, ToolStripDropDownCloseReason reason)
	{
	}

	internal void NotifySelectedChanged(ToolStripItem tsi)
	{
	}

	internal virtual bool OnMenuKey()
	{
		return false;
	}

	internal virtual bool ProcessArrowKey(Keys keyData)
	{
		return false;
	}

	internal virtual ToolStripItem SelectNextToolStripItem(ToolStripItem start, bool forward)
	{
		return null;
	}

	private void MouseEnteredItem(ToolStripItem item)
	{
	}

	private void MouseLeftItem(ToolStripItem item)
	{
	}

	private void ToolTipTimer_Tick(object o, EventArgs args)
	{
	}

	internal void BeginMerge()
	{
	}

	internal void RevertMergeItem(ToolStripItem item)
	{
	}
}
