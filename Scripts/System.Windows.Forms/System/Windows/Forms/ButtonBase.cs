using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Implements the basic functionality common to button controls.</summary>
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Designer("System.Windows.Forms.Design.ButtonBaseDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[ComVisible(true)]
public abstract class ButtonBase : Control
{
	private FlatStyle flat_style;

	private int image_index;

	internal Image image;

	internal ImageList image_list;

	private ContentAlignment image_alignment;

	internal ContentAlignment text_alignment;

	private bool is_default;

	internal bool is_pressed;

	internal StringFormat text_format;

	internal bool paint_as_acceptbutton;

	private FlatButtonAppearance flat_button_appearance;

	private string image_key;

	private TextImageRelation text_image_relation;

	private TextFormatFlags text_format_flags;

	private bool use_mnemonic;

	private bool use_visual_style_back_color;

	/// <summary>Gets or sets a value that indicates whether the control resizes based on its contents.</summary>
	/// <returns>
	///   <see langword="true" /> if the control automatically resizes based on its contents; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[MWFCategory("Layout")]
	[Browsable(true)]
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

	/// <summary>Gets or sets the background color of the control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> value representing the background color.</returns>
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

	/// <summary>Gets the appearance of the border and the colors used to indicate check state and mouse state.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.FlatButtonAppearance" /> values.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	[MWFCategory("Appearance")]
	public FlatButtonAppearance FlatAppearance => null;

	/// <summary>Gets or sets the flat style appearance of the button control.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.FlatStyle" /> values. The default value is <see langword="Standard" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Windows.Forms.FlatStyle" /> values.</exception>
	[Localizable(true)]
	[MWFDescription("Determines look of button")]
	[DefaultValue(FlatStyle.Standard)]
	[MWFCategory("Appearance")]
	public FlatStyle FlatStyle
	{
		get
		{
			return default(FlatStyle);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the image that is displayed on a button control.</summary>
	/// <returns>The <see cref="T:System.Drawing.Image" /> displayed on the button control. The default value is <see langword="null" />.</returns>
	[Localizable(true)]
	[MWFDescription("Sets image to be displayed on button face")]
	[MWFCategory("Appearance")]
	public Image Image => null;

	/// <summary>Gets or sets the alignment of the image on the button control.</summary>
	/// <returns>One of the <see cref="T:System.Drawing.ContentAlignment" /> values. The default value is <see langword="MiddleCenter" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Drawing.ContentAlignment" /> values.</exception>
	[MWFDescription("Sets the alignment of the image to be displayed on button face")]
	[Localizable(true)]
	[MWFCategory("Appearance")]
	[DefaultValue(ContentAlignment.MiddleCenter)]
	public ContentAlignment ImageAlign => default(ContentAlignment);

	/// <summary>Gets or sets the image list index value of the image displayed on the button control.</summary>
	/// <returns>A zero-based index, which represents the image position in an <see cref="T:System.Windows.Forms.ImageList" />. The default is -1.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The assigned value is less than the lower bounds of the <see cref="P:System.Windows.Forms.ButtonBase.ImageIndex" />.</exception>
	[TypeConverter(typeof(ImageIndexConverter))]
	[DefaultValue(-1)]
	[Localizable(true)]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[MWFDescription("Index of image to display, if ImageList is used for button face images")]
	[MWFCategory("Appearance")]
	[RefreshProperties(RefreshProperties.Repaint)]
	public int ImageIndex => 0;

	/// <summary>Gets or sets the Input Method Editor (IME) mode supported by this control. This property is not relevant for this class.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ImeMode" /> values.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public new ImeMode ImeMode
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the text associated with this control.</summary>
	/// <returns>The text associated with this control.</returns>
	[SettingsBindable(true)]
	[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
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

	/// <summary>Gets or sets the alignment of the text on the button control.</summary>
	/// <returns>One of the <see cref="T:System.Drawing.ContentAlignment" /> values. The default is <see langword="MiddleCenter" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Drawing.ContentAlignment" /> values.</exception>
	[DefaultValue(ContentAlignment.MiddleCenter)]
	[MWFCategory("Appearance")]
	[MWFDescription("Alignment for button text")]
	[Localizable(true)]
	public virtual ContentAlignment TextAlign
	{
		get
		{
			return default(ContentAlignment);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the position of text and image relative to each other.</summary>
	/// <returns>One of the values of <see cref="T:System.Windows.Forms.TextImageRelation" />. The default is <see cref="F:System.Windows.Forms.TextImageRelation.Overlay" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value is not one of the <see cref="T:System.Windows.Forms.TextImageRelation" /> values.</exception>
	[MWFCategory("Appearance")]
	[Localizable(true)]
	[DefaultValue(TextImageRelation.Overlay)]
	public TextImageRelation TextImageRelation => default(TextImageRelation);

	/// <summary>Gets or sets a value that determines whether to use the <see cref="T:System.Drawing.Graphics" /> class (GDI+) or the <see cref="T:System.Windows.Forms.TextRenderer" /> class (GDI) to render text.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Drawing.Graphics" /> class should be used to perform text rendering for compatibility with versions 1.0 and 1.1. of the .NET Framework; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[MWFCategory("Behavior")]
	[DefaultValue(false)]
	public bool UseCompatibleTextRendering => false;

	/// <summary>Gets or sets a value indicating whether the first character that is preceded by an ampersand (&amp;) is used as the mnemonic key of the control.</summary>
	/// <returns>
	///   <see langword="true" /> if the first character that is preceded by an ampersand (&amp;) is used as the mnemonic key of the control; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[MWFCategory("Appearance")]
	[DefaultValue(true)]
	public bool UseMnemonic => false;

	/// <summary>Gets or sets a value that determines if the background is drawn using visual styles, if supported.</summary>
	/// <returns>
	///   <see langword="true" /> if the background is drawn using visual styles; otherwise, <see langword="false" />.</returns>
	[MWFCategory("Appearance")]
	public bool UseVisualStyleBackColor
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets the required creation parameters when the control handle is created.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.CreateParams" /> that contains the required creation parameters when the handle to the control is created.</returns>
	protected override CreateParams CreateParams => null;

	/// <summary>Gets the default size of the control.</summary>
	/// <returns>The default <see cref="T:System.Drawing.Size" /> of the control.</returns>
	protected override Size DefaultSize => default(Size);

	/// <summary>Gets or sets a value indicating whether the button control is the default button.</summary>
	/// <returns>
	///   <see langword="true" /> if the button control is the default button; otherwise, <see langword="false" />.</returns>
	protected internal bool IsDefault
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool Pressed => false;

	internal TextFormatFlags TextFormatFlags => default(TextFormatFlags);

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ButtonBase" /> class.</summary>
	protected ButtonBase()
	{
	}

	/// <summary>Retrieves the size of a rectangular area into which a control can be fitted.</summary>
	/// <param name="proposedSize">The custom-sized area for a control.</param>
	/// <returns>An ordered pair of type <see cref="T:System.Drawing.Size" /> representing the width and height of a rectangle.</returns>
	public override Size GetPreferredSize(Size proposedSize)
	{
		return default(Size);
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.ButtonBase" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.EnabledChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnEnabledChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.GotFocus" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnGotFocus(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.ButtonBase.OnKeyUp(System.Windows.Forms.KeyEventArgs)" /> event.</summary>
	/// <param name="kevent">A <see cref="T:System.Windows.Forms.KeyEventArgs" /> that contains the event data.</param>
	protected override void OnKeyDown(KeyEventArgs kevent)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.ButtonBase.OnKeyUp(System.Windows.Forms.KeyEventArgs)" /> event.</summary>
	/// <param name="kevent">A <see cref="T:System.Windows.Forms.KeyEventArgs" /> that contains the event data.</param>
	protected override void OnKeyUp(KeyEventArgs kevent)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.ButtonBase.OnLostFocus(System.EventArgs)" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnLostFocus(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.Control.OnMouseDown(System.Windows.Forms.MouseEventArgs)" /> event.</summary>
	/// <param name="mevent">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	protected override void OnMouseDown(MouseEventArgs mevent)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.Control.OnMouseEnter(System.EventArgs)" /> event.</summary>
	/// <param name="eventargs">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseEnter(EventArgs eventargs)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.Control.OnMouseLeave(System.EventArgs)" /> event.</summary>
	/// <param name="eventargs">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseLeave(EventArgs eventargs)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.Control.OnMouseMove(System.Windows.Forms.MouseEventArgs)" /> event.</summary>
	/// <param name="mevent">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	protected override void OnMouseMove(MouseEventArgs mevent)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.ButtonBase.OnMouseUp(System.Windows.Forms.MouseEventArgs)" /> event.</summary>
	/// <param name="mevent">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	protected override void OnMouseUp(MouseEventArgs mevent)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.ButtonBase.OnPaint(System.Windows.Forms.PaintEventArgs)" /> event.</summary>
	/// <param name="pevent">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
	protected override void OnPaint(PaintEventArgs pevent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.ParentChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnParentChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnTextChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.VisibleChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
	protected override void OnVisibleChanged(EventArgs e)
	{
	}

	/// <summary>Processes Windows messages.</summary>
	/// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
	protected override void WndProc(ref Message m)
	{
	}

	internal virtual void Draw(PaintEventArgs pevent)
	{
	}

	internal virtual void HaveDoubleClick()
	{
	}

	internal override void OnPaintBackgroundInternal(PaintEventArgs e)
	{
	}
}
