using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Represents a standard Windows label.</summary>
[ToolboxItem("System.Windows.Forms.Design.AutoSizeToolboxItem,System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ComVisible(true)]
[Designer("System.Windows.Forms.Design.LabelDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[DefaultProperty("Text")]
[DefaultBindingProperty("Text")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class Label : Control
{
	private bool autosize;

	private Image image;

	private FlatStyle flat_style;

	private bool use_mnemonic;

	private int image_index;

	private string image_key;

	private ImageList image_list;

	internal ContentAlignment image_align;

	internal StringFormat string_format;

	internal ContentAlignment text_align;

	private static SizeF req_witdthsize;

	private static object AutoSizeChangedEvent;

	private static object TextAlignChangedEvent;

	/// <summary>Gets or sets a value indicating whether the control is automatically resized to display its entire contents.</summary>
	/// <returns>
	///   <see langword="true" /> if the control adjusts its width to closely fit its contents; otherwise, <see langword="false" />.  
	///
	///  When added to a form using the designer, the default value is <see langword="true" />. When instantiated from code, the default value is <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[DefaultValue(false)]
	[RefreshProperties(RefreshProperties.All)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Localizable(true)]
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

	/// <summary>Gets or sets the image rendered on the background of the control.</summary>
	/// <returns>An <see cref="T:System.Drawing.Image" /> that represents the background image of the control. The default is <see langword="null" />.</returns>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override Image BackgroundImage => null;

	/// <summary>This property is not relevant for this class.</summary>
	/// <returns>An <see cref="T:System.Windows.Forms.ImageLayout" /> object.</returns>
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

	/// <summary>Gets or sets the border style for the control.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.BorderStyle" /> values. The default is <see langword="BorderStyle.None" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Windows.Forms.BorderStyle" /> values.</exception>
	[DefaultValue(BorderStyle.None)]
	[DispId(-504)]
	public virtual BorderStyle BorderStyle => default(BorderStyle);

	/// <summary>Gets the required creation parameters when the control handle is created.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.CreateParams" /> that contains the required creation parameters when the handle to the control is created.</returns>
	protected override CreateParams CreateParams => null;

	/// <summary>Gets the space, in pixels, that is specified by default between controls.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Padding" /> value that represents the default space between controls.</returns>
	protected override Padding DefaultMargin => default(Padding);

	/// <summary>Gets the default size of the control.</summary>
	/// <returns>The default <see cref="T:System.Drawing.Size" /> of the control.</returns>
	protected override Size DefaultSize => default(Size);

	/// <summary>Gets or sets the flat style appearance of the label control.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.FlatStyle" /> values. The default value is <see langword="Standard" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Windows.Forms.FlatStyle" /> values.</exception>
	[DefaultValue(FlatStyle.Standard)]
	public FlatStyle FlatStyle
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the image that is displayed on a <see cref="T:System.Windows.Forms.Label" />.</summary>
	/// <returns>An <see cref="T:System.Drawing.Image" /> displayed on the <see cref="T:System.Windows.Forms.Label" />. The default is <see langword="null" />.</returns>
	[Localizable(true)]
	public Image Image => null;

	/// <summary>Gets or sets the alignment of an image that is displayed in the control.</summary>
	/// <returns>One of the <see cref="T:System.Drawing.ContentAlignment" /> values. The default is <see langword="ContentAlignment.MiddleCenter" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Drawing.ContentAlignment" /> values.</exception>
	[Localizable(true)]
	[DefaultValue(ContentAlignment.MiddleCenter)]
	public ContentAlignment ImageAlign => default(ContentAlignment);

	/// <summary>Gets or sets a value indicating whether the user can tab to the <see cref="T:System.Windows.Forms.Label" />. This property is not used by this class.</summary>
	/// <returns>This property is not used by this class. The default is <see langword="false" />.</returns>
	[Browsable(false)]
	[DefaultValue(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public new bool TabStop
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the alignment of text in the label.</summary>
	/// <returns>One of the <see cref="T:System.Drawing.ContentAlignment" /> values. The default is <see cref="F:System.Drawing.ContentAlignment.TopLeft" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Drawing.ContentAlignment" /> values.</exception>
	[Localizable(true)]
	[DefaultValue(ContentAlignment.TopLeft)]
	public virtual ContentAlignment TextAlign
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the control interprets an ampersand character (&amp;) in the control's <see cref="P:System.Windows.Forms.Control.Text" /> property to be an access key prefix character.</summary>
	/// <returns>
	///   <see langword="true" /> if the label doesn't display the ampersand character and underlines the character after the ampersand in its displayed text and treats the underlined character as an access key; otherwise, <see langword="false" /> if the ampersand character is displayed in the text of the control. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool UseMnemonic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the text associated with this control.</summary>
	/// <returns>The text associated with this control.</returns>
	[SettingsBindable(true)]
	[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
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

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Label" /> class.</summary>
	public Label()
	{
	}

	internal virtual Size InternalGetPreferredSize(Size proposed)
	{
		return default(Size);
	}

	/// <summary>Retrieves the size of a rectangular area into which a control can be fitted.</summary>
	/// <param name="proposedSize">The custom-sized area for a control.</param>
	/// <returns>An ordered pair of type <see cref="T:System.Drawing.Size" /> representing the width and height of a rectangle.</returns>
	public override Size GetPreferredSize(Size proposedSize)
	{
		return default(Size);
	}

	/// <summary>Determines the size and location of an image drawn within the <see cref="T:System.Windows.Forms.Label" /> control based on the alignment of the control.</summary>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> used to determine size and location when drawn within the control.</param>
	/// <param name="r">A <see cref="T:System.Drawing.Rectangle" /> that represents the area to draw the image in.</param>
	/// <param name="align">The alignment of content within the control.</param>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that represents the size and location of the specified image within the control.</returns>
	protected Rectangle CalcImageRenderBounds(Image image, Rectangle r, ContentAlignment align)
	{
		return default(Rectangle);
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.Label" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Draws an <see cref="T:System.Drawing.Image" /> within the specified bounds.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> surface on which to draw.</param>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> to draw.</param>
	/// <param name="r">The <see cref="T:System.Drawing.Rectangle" /> bounds to draw within.</param>
	/// <param name="align">The alignment of the image to draw within the <see cref="T:System.Windows.Forms.Label" />.</param>
	protected internal void DrawImage(Graphics g, Image image, Rectangle r, ContentAlignment align)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.EnabledChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnEnabledChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.FontChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnFontChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.PaddingChanged" /> event.</summary>
	/// <param name="e">A <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnPaddingChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
	protected override void OnPaint(PaintEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.ParentChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnParentChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.RightToLeftChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnRightToLeftChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Label.TextAlignChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnTextAlignChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnTextChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.VisibleChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnVisibleChanged(EventArgs e)
	{
	}

	/// <summary>Processes a mnemonic character.</summary>
	/// <param name="charCode">The character to process.</param>
	/// <returns>
	///   <see langword="true" /> if the character was processed as a mnemonic by the control; otherwise, <see langword="false" />.</returns>
	protected override bool ProcessMnemonic(char charCode)
	{
		return false;
	}

	/// <summary>Sets the specified bounds of the label.</summary>
	/// <param name="x">The new <see cref="P:System.Windows.Forms.Control.Left" /> property value of the control.</param>
	/// <param name="y">The new <see cref="P:System.Windows.Forms.Control.Top" /> property value of the control.</param>
	/// <param name="width">The new <see cref="P:System.Windows.Forms.Control.Width" /> property value of the control.</param>
	/// <param name="height">The new <see cref="P:System.Windows.Forms.Control.Height" /> property value of the control.</param>
	/// <param name="specified">A bitwise combination of the <see cref="T:System.Windows.Forms.BoundsSpecified" /> values. For any parameter not specified, the current value will be used.</param>
	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Windows.Forms.Label" />.</summary>
	/// <returns>A string that represents the current <see cref="T:System.Windows.Forms.Label" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Processes Windows messages.</summary>
	/// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
	protected override void WndProc(ref Message m)
	{
	}

	private void CalcAutoSize()
	{
	}

	private void OnHandleCreatedLB(object o, EventArgs e)
	{
	}

	private void SetUseMnemonic(bool use)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseEnter" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseEnter(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseLeave(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.HandleDestroyed" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnHandleDestroyed(EventArgs e)
	{
	}
}
