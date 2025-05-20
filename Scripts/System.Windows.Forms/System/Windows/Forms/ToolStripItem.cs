using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Represents the abstract base class that manages events and layout for all the elements that a <see cref="T:System.Windows.Forms.ToolStrip" /> or <see cref="T:System.Windows.Forms.ToolStripDropDown" /> can contain.</summary>
[Designer("System.Windows.Forms.Design.ToolStripItemDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[DefaultEvent("Click")]
[DefaultProperty("Text")]
[ToolboxItem(false)]
[DesignTimeVisible(false)]
public abstract class ToolStripItem : Component, IDisposable, IComponent
{
	private ToolStripItemAlignment alignment;

	private AnchorStyles anchor;

	private bool available;

	private bool auto_size;

	private bool auto_tool_tip;

	private Color back_color;

	private Image background_image;

	private ImageLayout background_image_layout;

	private Rectangle bounds;

	private bool can_select;

	private ToolStripItemDisplayStyle display_style;

	private DockStyle dock;

	private bool enabled;

	private Size explicit_size;

	private Font font;

	private Color fore_color;

	private Image image;

	private ContentAlignment image_align;

	private int image_index;

	private string image_key;

	private ToolStripItemImageScaling image_scaling;

	private Color image_transparent_color;

	private bool is_disposed;

	internal bool is_pressed;

	private bool is_selected;

	private Padding margin;

	private MergeAction merge_action;

	private int merge_index;

	private string name;

	private ToolStripItemOverflow overflow;

	private ToolStrip owner;

	internal ToolStripItem owner_item;

	private Padding padding;

	private ToolStripItemPlacement placement;

	private RightToLeft right_to_left;

	private bool right_to_left_auto_mirror_image;

	private string text;

	private ContentAlignment text_align;

	private ToolStripTextDirection text_direction;

	private TextImageRelation text_image_relation;

	private string tool_tip_text;

	private bool visible;

	private EventHandler frame_handler;

	private ToolStrip parent;

	private Size text_size;

	private static object AvailableChangedEvent;

	private static object BackColorChangedEvent;

	private static object DisplayStyleChangedEvent;

	private static object DoubleClickEvent;

	private static object DragDropEvent;

	private static object DragEnterEvent;

	private static object DragLeaveEvent;

	private static object DragOverEvent;

	private static object EnabledChangedEvent;

	private static object ForeColorChangedEvent;

	private static object GiveFeedbackEvent;

	private static object LocationChangedEvent;

	private static object MouseDownEvent;

	private static object MouseEnterEvent;

	private static object MouseHoverEvent;

	private static object MouseLeaveEvent;

	private static object MouseMoveEvent;

	private static object MouseUpEvent;

	private static object OwnerChangedEvent;

	private static object PaintEvent;

	private static object QueryAccessibilityHelpEvent;

	private static object QueryContinueDragEvent;

	private static object RightToLeftChangedEvent;

	private static object TextChangedEvent;

	private static object VisibleChangedEvent;

	private static object UIASelectionChangedEvent;

	/// <summary>Gets or sets a value indicating whether the item aligns towards the beginning or end of the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripItemAlignment" /> values. The default is <see cref="F:System.Windows.Forms.ToolStripItemAlignment.Left" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Windows.Forms.ToolStripItemAlignment" /> values.</exception>
	[DefaultValue(ToolStripItemAlignment.Left)]
	public ToolStripItemAlignment Alignment
	{
		get
		{
			return default(ToolStripItemAlignment);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the edges of the container to which a <see cref="T:System.Windows.Forms.ToolStripItem" /> is bound and determines how a <see cref="T:System.Windows.Forms.ToolStripItem" /> is resized with its parent.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.AnchorStyles" /> values.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value is not one of the <see cref="T:System.Windows.Forms.AnchorStyles" /> values.</exception>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue(AnchorStyles.Top | AnchorStyles.Left)]
	public AnchorStyles Anchor => default(AnchorStyles);

	/// <summary>Gets or sets a value indicating whether the item is automatically sized.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolStripItem" /> is automatically sized; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
	[DefaultValue(true)]
	[Localizable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[RefreshProperties(RefreshProperties.All)]
	public bool AutoSize
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Windows.Forms.ToolStripItem" /> should be placed on a <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolStripItem" /> is placed on a <see cref="T:System.Windows.Forms.ToolStrip" />; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool Available
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the background color for the item.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the background color of the item. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultBackColor" /> property.</returns>
	public virtual Color BackColor => default(Color);

	/// <summary>Gets or sets the background image displayed in the item.</summary>
	/// <returns>An <see cref="T:System.Drawing.Image" /> that represents the image to display in the background of the item.</returns>
	[Localizable(true)]
	[DefaultValue(null)]
	public virtual Image BackgroundImage => null;

	/// <summary>Gets or sets the background image layout used for the <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ImageLayout" /> values. The default value is <see cref="F:System.Windows.Forms.ImageLayout.Tile" />.</returns>
	[DefaultValue(ImageLayout.Tile)]
	[Localizable(true)]
	public virtual ImageLayout BackgroundImageLayout => default(ImageLayout);

	/// <summary>Gets the size and location of the item.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that represents the size and location of the <see cref="T:System.Windows.Forms.ToolStripItem" />.</returns>
	[Browsable(false)]
	public virtual Rectangle Bounds => default(Rectangle);

	/// <summary>Gets a value indicating whether the item can be selected.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolStripItem" /> can be selected; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	public virtual bool CanSelect => false;

	/// <summary>Gets the area where content, such as text and icons, can be placed within a <see cref="T:System.Windows.Forms.ToolStripItem" /> without overwriting background borders.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> containing four integers that represent the location and size of <see cref="T:System.Windows.Forms.ToolStripItem" /> contents, excluding its border.</returns>
	[Browsable(false)]
	public Rectangle ContentRectangle => default(Rectangle);

	/// <summary>Gets or sets whether text and images are displayed on a <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripItemDisplayStyle" /> values. The default is <see cref="F:System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText" /> .</returns>
	public virtual ToolStripItemDisplayStyle DisplayStyle
	{
		set
		{
		}
	}

	/// <summary>Gets a value indicating whether the object has been disposed of.</summary>
	/// <returns>
	///   <see langword="true" /> if the control has been disposed of; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	public bool IsDisposed => false;

	/// <summary>Gets or sets which <see cref="T:System.Windows.Forms.ToolStripItem" /> borders are docked to its parent control and determines how a <see cref="T:System.Windows.Forms.ToolStripItem" /> is resized with its parent.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.DockStyle" /> values. The default is <see cref="F:System.Windows.Forms.DockStyle.None" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Windows.Forms.DockStyle" /> values.</exception>
	[DefaultValue(DockStyle.None)]
	[Browsable(false)]
	public DockStyle Dock => default(DockStyle);

	/// <summary>Gets or sets a value indicating whether the parent control of the <see cref="T:System.Windows.Forms.ToolStripItem" /> is enabled.</summary>
	/// <returns>
	///   <see langword="true" /> if the parent control of the <see cref="T:System.Windows.Forms.ToolStripItem" /> is enabled; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[Localizable(true)]
	[DefaultValue(true)]
	public virtual bool Enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the font of the text displayed by the item.</summary>
	/// <returns>The <see cref="T:System.Drawing.Font" /> to apply to the text displayed by the <see cref="T:System.Windows.Forms.ToolStripItem" />. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultFont" /> property.</returns>
	[Localizable(true)]
	public virtual Font Font => null;

	/// <summary>Gets or sets the foreground color of the item.</summary>
	/// <returns>The foreground <see cref="T:System.Drawing.Color" /> of the item. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultForeColor" /> property.</returns>
	public virtual Color ForeColor => default(Color);

	/// <summary>Gets or sets the height, in pixels, of a <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <returns>An <see cref="T:System.Int32" /> representing the height, in pixels.</returns>
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int Height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the image that is displayed on a <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <returns>The <see cref="T:System.Drawing.Image" /> to be displayed.</returns>
	[Localizable(true)]
	public virtual Image Image
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the color to treat as transparent in a <see cref="T:System.Windows.Forms.ToolStripItem" /> image.</summary>
	/// <returns>One of the <see cref="T:System.Drawing.Color" /> values.</returns>
	[Localizable(true)]
	public Color ImageTransparentColor => default(Color);

	/// <summary>Gets a value indicating whether the container of the current <see cref="T:System.Windows.Forms.Control" /> is a <see cref="T:System.Windows.Forms.ToolStripDropDown" />.</summary>
	/// <returns>
	///   <see langword="true" /> if the container of the current <see cref="T:System.Windows.Forms.Control" /> is a <see cref="T:System.Windows.Forms.ToolStripDropDown" />; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	public bool IsOnDropDown => false;

	/// <summary>Gets or sets the space between the item and adjacent items.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Padding" /> representing the space between the item and adjacent items.</returns>
	public Padding Margin => default(Padding);

	/// <summary>Gets or sets how child menus are merged with parent menus.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.MergeAction" /> values. The default is <see cref="F:System.Windows.Forms.MergeAction.MatchOnly" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Windows.Forms.MergeAction" /> values.</exception>
	[DefaultValue(MergeAction.Append)]
	public MergeAction MergeAction => default(MergeAction);

	/// <summary>Gets or sets the position of a merged item within the current <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>An integer representing the index of the merged item, if a match is found, or -1 if a match is not found.</returns>
	[DefaultValue(-1)]
	public int MergeIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets whether the item is attached to the <see cref="T:System.Windows.Forms.ToolStrip" /> or <see cref="T:System.Windows.Forms.ToolStripOverflowButton" /> or can float between the two.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripItemOverflow" /> values. The default is <see cref="F:System.Windows.Forms.ToolStripItemOverflow.AsNeeded" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Windows.Forms.ToolStripItemOverflow" /> values.</exception>
	[DefaultValue(ToolStripItemOverflow.AsNeeded)]
	public ToolStripItemOverflow Overflow
	{
		get
		{
			return default(ToolStripItemOverflow);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the owner of this item.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.ToolStrip" /> that owns or is to own the <see cref="T:System.Windows.Forms.ToolStripItem" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public ToolStrip Owner => null;

	/// <summary>Gets the parent <see cref="T:System.Windows.Forms.ToolStripItem" /> of this <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <returns>The parent <see cref="T:System.Windows.Forms.ToolStripItem" /> of this <see cref="T:System.Windows.Forms.ToolStripItem" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public ToolStripItem OwnerItem => null;

	/// <summary>Gets the current layout of the item.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripItemPlacement" /> values.</returns>
	[Browsable(false)]
	public ToolStripItemPlacement Placement => default(ToolStripItemPlacement);

	/// <summary>Gets a value indicating whether the state of the item is pressed.</summary>
	/// <returns>
	///   <see langword="true" /> if the state of the item is pressed; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool Pressed => false;

	/// <summary>Gets or sets a value indicating whether items are to be placed from right to left and text is to be written from right to left.</summary>
	/// <returns>
	///   <see langword="true" /> if items are to be placed from right to left and text is to be written from right to left; otherwise, <see langword="false" />.</returns>
	[System.MonoTODO("RTL not implemented")]
	[Localizable(true)]
	public virtual RightToLeft RightToLeft => default(RightToLeft);

	/// <summary>Mirrors automatically the <see cref="T:System.Windows.Forms.ToolStripItem" /> image when the <see cref="P:System.Windows.Forms.ToolStripItem.RightToLeft" /> property is set to <see cref="F:System.Windows.Forms.RightToLeft.Yes" />.</summary>
	/// <returns>
	///   <see langword="true" /> to automatically mirror the image; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[Localizable(true)]
	[DefaultValue(false)]
	public bool RightToLeftAutoMirrorImage => false;

	/// <summary>Gets a value indicating whether the item is selected.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolStripItem" /> is selected; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual bool Selected => false;

	/// <summary>Gets or sets the size of the item.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" />, representing the width and height of a rectangle.</returns>
	[Localizable(true)]
	public virtual Size Size
	{
		get
		{
			return default(Size);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the text that is to be displayed on the item.</summary>
	/// <returns>A string representing the item's text. The default value is the empty string ("").</returns>
	[Localizable(true)]
	[DefaultValue(null)]
	public virtual string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the alignment of the text on a <see cref="T:System.Windows.Forms.ToolStripLabel" />.</summary>
	/// <returns>One of the <see cref="T:System.Drawing.ContentAlignment" /> values. The default is <see cref="F:System.Drawing.ContentAlignment.MiddleRight" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Drawing.ContentAlignment" /> values.</exception>
	[DefaultValue(ContentAlignment.MiddleCenter)]
	[Localizable(true)]
	public virtual ContentAlignment TextAlign => default(ContentAlignment);

	/// <summary>Gets the orientation of text used on a <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripTextDirection" /> values.</returns>
	public virtual ToolStripTextDirection TextDirection => default(ToolStripTextDirection);

	/// <summary>Gets or sets the text that appears as a <see cref="T:System.Windows.Forms.ToolTip" /> for a control.</summary>
	/// <returns>A string representing the ToolTip text.</returns>
	[Localizable(true)]
	[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string ToolTipText
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the item is displayed.</summary>
	/// <returns>
	///   <see langword="true" /> if the item is displayed; otherwise, <see langword="false" />.</returns>
	[Localizable(true)]
	public bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the width in pixels of a <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <returns>An <see cref="T:System.Int32" /> representing the width in pixels.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public int Width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets a value indicating whether to display the <see cref="T:System.Windows.Forms.ToolTip" /> that is defined as the default.</summary>
	/// <returns>
	///   <see langword="false" /> in all cases.</returns>
	protected virtual bool DefaultAutoToolTip => false;

	/// <summary>Gets a value indicating what is displayed on the <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolStripItemDisplayStyle" /> values. The default is <see cref="F:System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText" />.</returns>
	protected virtual ToolStripItemDisplayStyle DefaultDisplayStyle => default(ToolStripItemDisplayStyle);

	/// <summary>Gets the default margin of an item.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Padding" /> representing the margin.</returns>
	protected internal virtual Padding DefaultMargin => default(Padding);

	/// <summary>Gets the internal spacing characteristics of the item.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.Padding" /> values.</returns>
	protected virtual Padding DefaultPadding => default(Padding);

	/// <summary>Gets the default size of the item.</summary>
	/// <returns>The default <see cref="T:System.Drawing.Size" /> of the <see cref="T:System.Windows.Forms.ToolStripItem" />.</returns>
	protected virtual Size DefaultSize => default(Size);

	/// <summary>Gets or sets the parent container of the <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ToolStrip" /> that is the parent container of the <see cref="T:System.Windows.Forms.ToolStripItem" />.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	protected internal ToolStrip Parent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static Font DefaultFont => null;

	internal virtual ToolStripTextDirection DefaultTextDirection => default(ToolStripTextDirection);

	internal bool ShowMargin => false;

	internal bool UseImageMargin => false;

	internal virtual bool InternalVisible => false;

	internal ToolStrip InternalOwner
	{
		set
		{
		}
	}

	internal Point Location
	{
		get
		{
			return default(Point);
		}
		set
		{
		}
	}

	internal int Top
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int Left
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int Right => 0;

	internal int Bottom => 0;

	/// <summary>Occurs when the <see cref="T:System.Windows.Forms.ToolStripItem" /> is clicked.</summary>
	public event EventHandler Click
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripItem" /> class.</summary>
	protected ToolStripItem()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripItem" /> class with the specified display text, image, event handler, and name.</summary>
	/// <param name="text">The text to display on the <see cref="T:System.Windows.Forms.ToolStripItem" />.</param>
	/// <param name="image">The Image to display on the <see cref="T:System.Windows.Forms.ToolStripItem" />.</param>
	/// <param name="onClick">The event handler for the <see cref="E:System.Windows.Forms.ToolStripItem.Click" /> event.</param>
	/// <param name="name">The name of the <see cref="T:System.Windows.Forms.ToolStripItem" />.</param>
	protected ToolStripItem(string text, Image image, EventHandler onClick, string name)
	{
	}

	/// <summary>Retrieves the <see cref="T:System.Windows.Forms.ToolStrip" /> that is the container of the current <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ToolStrip" /> that is the container of the current <see cref="T:System.Windows.Forms.ToolStripItem" />.</returns>
	public ToolStrip GetCurrentParent()
	{
		return null;
	}

	/// <summary>Retrieves the size of a rectangular area into which a control can be fit.</summary>
	/// <param name="constrainingSize">The custom-sized area for a control.</param>
	/// <returns>A <see cref="T:System.Drawing.Size" /> ordered pair, representing the width and height of a rectangle.</returns>
	public virtual Size GetPreferredSize(Size constrainingSize)
	{
		return default(Size);
	}

	/// <summary>Invalidates the entire surface of the <see cref="T:System.Windows.Forms.ToolStripItem" /> and causes it to be redrawn.</summary>
	public void Invalidate()
	{
	}

	/// <summary>Generates a <see langword="Click" /> event for a <see langword="ToolStripItem" />.</summary>
	public void PerformClick()
	{
	}

	/// <summary>Selects the item.</summary>
	public void Select()
	{
	}

	/// <summary>Returns a <see cref="T:System.String" /> containing the name of the <see cref="T:System.ComponentModel.Component" />, if any. This method should not be overridden.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the name of the <see cref="T:System.ComponentModel.Component" />, if any, or <see langword="null" /> if the <see cref="T:System.ComponentModel.Component" /> is unnamed.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.ToolStripItem" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Raises the AvailableChanged event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnAvailableChanged(EventArgs e)
	{
	}

	/// <summary>Occurs when the <see cref="P:System.Windows.Forms.ToolStripItem.Bounds" /> property changes.</summary>
	protected virtual void OnBoundsChanged()
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.Click" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnClick(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.DisplayStyleChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnDisplayStyleChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.EnabledChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnEnabledChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.FontChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnFontChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Layout" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.LayoutEventArgs" /> that contains the event data.</param>
	protected virtual void OnLayout(LayoutEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.LocationChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnLocationChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.MouseDown" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.MouseEnter" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnMouseEnter(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.MouseHover" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnMouseHover(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.MouseLeave" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnMouseLeave(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.MouseMove" /> event.</summary>
	/// <param name="mea">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	protected virtual void OnMouseMove(MouseEventArgs mea)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.MouseUp" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	protected virtual void OnMouseUp(MouseEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.OwnerChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnOwnerChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.FontChanged" /> event when the <see cref="P:System.Windows.Forms.ToolStripItem.Font" /> property has changed on the parent of the <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <param name="e">A <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal virtual void OnOwnerFontChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.Paint" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
	protected virtual void OnPaint(PaintEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.ParentChanged" /> event.</summary>
	/// <param name="oldParent">The original parent of the item.</param>
	/// <param name="newParent">The new parent of the item.</param>
	protected virtual void OnParentChanged(ToolStrip oldParent, ToolStrip newParent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.EnabledChanged" /> event when the <see cref="P:System.Windows.Forms.ToolStripItem.Enabled" /> property value of the item's container changes.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected internal virtual void OnParentEnabledChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.RightToLeftChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal virtual void OnParentRightToLeftChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.RightToLeftChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnRightToLeftChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.TextChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnTextChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.VisibleChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnVisibleChanged(EventArgs e)
	{
	}

	/// <summary>Processes a command key.</summary>
	/// <param name="m">A <see cref="T:System.Windows.Forms.Message" />, passed by reference, that represents the window message to process.</param>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
	/// <returns>
	///   <see langword="false" /> in all cases.</returns>
	protected internal virtual bool ProcessCmdKey(ref Message m, Keys keyData)
	{
		return false;
	}

	/// <summary>Processes a dialog key.</summary>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
	/// <returns>
	///   <see langword="true" /> if the key was processed by the item; otherwise, <see langword="false" />.</returns>
	protected internal virtual bool ProcessDialogKey(Keys keyData)
	{
		return false;
	}

	/// <summary>Processes a mnemonic character.</summary>
	/// <param name="charCode">The character to process.</param>
	/// <returns>
	///   <see langword="true" /> in all cases.</returns>
	protected internal virtual bool ProcessMnemonic(char charCode)
	{
		return false;
	}

	/// <summary>Sets the size and location of the item.</summary>
	/// <param name="bounds">A <see cref="T:System.Drawing.Rectangle" /> that represents the size and location of the <see cref="T:System.Windows.Forms.ToolStripItem" /></param>
	protected internal virtual void SetBounds(Rectangle bounds)
	{
	}

	/// <summary>Sets the <see cref="T:System.Windows.Forms.ToolStripItem" /> to the specified visible state.</summary>
	/// <param name="visible">
	///   <see langword="true" /> to make the <see cref="T:System.Windows.Forms.ToolStripItem" /> visible; otherwise, <see langword="false" />.</param>
	protected virtual void SetVisibleCore(bool visible)
	{
	}

	internal Rectangle AlignInRectangle(Rectangle outer, Size inner, ContentAlignment align)
	{
		return default(Rectangle);
	}

	internal void CalculateAutoSize()
	{
	}

	internal virtual Size CalculatePreferredSize(Size constrainingSize)
	{
		return default(Size);
	}

	internal void CalculateTextAndImageRectangles(out Rectangle text_rect, out Rectangle image_rect)
	{
		text_rect = default(Rectangle);
		image_rect = default(Rectangle);
	}

	internal void CalculateTextAndImageRectangles(Rectangle contentRectangle, out Rectangle text_rect, out Rectangle image_rect)
	{
		text_rect = default(Rectangle);
		image_rect = default(Rectangle);
	}

	internal virtual void Dismiss(ToolStripDropDownCloseReason reason)
	{
	}

	internal virtual ToolStrip GetTopLevelToolStrip()
	{
		return null;
	}

	private void LayoutTextBeforeOrAfterImage(Rectangle totalArea, bool textFirst, Size textSize, Size imageSize, ContentAlignment textAlign, ContentAlignment imageAlign, out Rectangle textRect, out Rectangle imageRect)
	{
		textRect = default(Rectangle);
		imageRect = default(Rectangle);
	}

	private HorizontalAlignment GetHorizontalAlignment(ContentAlignment align)
	{
		return default(HorizontalAlignment);
	}

	internal Size GetImageSize()
	{
		return default(Size);
	}

	internal string GetToolTip()
	{
		return null;
	}

	internal void FireEvent(EventArgs e, ToolStripItemEventType met)
	{
	}

	internal virtual void HandleClick(EventArgs e)
	{
	}

	internal virtual void SetPlacement(ToolStripItemPlacement placement)
	{
	}

	private void BeginAnimation()
	{
	}

	private void OnAnimateImage(object sender, EventArgs e)
	{
	}

	private void StopAnimation()
	{
	}

	private void UpdateAnimatedImage(object sender, EventArgs e)
	{
	}

	internal void OnUIASelectionChanged()
	{
	}
}
