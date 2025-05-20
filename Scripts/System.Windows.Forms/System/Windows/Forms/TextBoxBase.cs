using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Implements the basic functionality required by text controls.</summary>
[ComVisible(true)]
[DefaultBindingProperty("Text")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[DefaultEvent("TextChanged")]
[Designer("System.Windows.Forms.Design.TextBoxBaseDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public abstract class TextBoxBase : Control
{
	internal class LinkRectangle
	{
		private Rectangle link_area_rectangle;

		private LineTag link_tag;

		public Rectangle LinkAreaRectangle => default(Rectangle);

		public LineTag LinkTag
		{
			set
			{
			}
		}

		public LinkRectangle(Rectangle rect)
		{
		}

		public void Scroll(int x_change, int y_change)
		{
		}
	}

	internal HorizontalAlignment alignment;

	internal bool accepts_tab;

	internal bool accepts_return;

	internal bool auto_size;

	internal bool backcolor_set;

	internal CharacterCasing character_casing;

	internal bool hide_selection;

	private int max_length;

	internal bool modified;

	internal char password_char;

	internal bool read_only;

	internal bool word_wrap;

	internal Document document;

	internal ImplicitHScrollBar hscroll;

	internal ImplicitVScrollBar vscroll;

	internal RichTextBoxScrollBars scrollbars;

	internal Timer scroll_timer;

	internal bool richtext;

	internal bool show_selection;

	internal ArrayList list_links;

	private LinkRectangle current_link;

	private bool enable_links;

	internal bool has_been_focused;

	internal int selection_length;

	internal bool show_caret_w_selection;

	internal int canvas_width;

	internal int canvas_height;

	internal static int track_width;

	internal static int track_border;

	internal DateTime click_last;

	internal int click_point_x;

	internal int click_point_y;

	internal CaretSelection click_mode;

	internal BorderStyle actual_border_style;

	internal bool shortcuts_enabled;

	private static object AcceptsTabChangedEvent;

	private static object AutoSizeChangedEvent;

	private static object BorderStyleChangedEvent;

	private static object HideSelectionChangedEvent;

	private static object ModifiedChangedEvent;

	private static object MultilineChangedEvent;

	private static object ReadOnlyChangedEvent;

	private static object HScrolledEvent;

	private static object VScrolledEvent;

	/// <summary>Gets or sets a value indicating whether the height of the control automatically adjusts when the font assigned to the control is changed.</summary>
	/// <returns>
	///   <see langword="true" /> if the height of the control automatically adjusts when the font is changed; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[Localizable(true)]
	[MWFCategory("Behavior")]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DefaultValue(true)]
	[RefreshProperties(RefreshProperties.Repaint)]
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
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the background of the control.</returns>
	[DispId(-501)]
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

	/// <summary>This property is not relevant for this class.</summary>
	/// <returns>The background image for the object.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override Image BackgroundImage => null;

	/// <summary>Gets or sets the border type of the text box control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.BorderStyle" /> that represents the border type of the text box control. The default is <see langword="Fixed3D" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">A value that is not within the range of valid values for the enumeration was assigned to the property.</exception>
	[DefaultValue(BorderStyle.Fixed3D)]
	[DispId(-504)]
	[MWFCategory("Appearance")]
	public BorderStyle BorderStyle
	{
		get
		{
			return default(BorderStyle);
		}
		set
		{
		}
	}

	/// <summary>Gets a value indicating whether the user can undo the previous operation in a text box control.</summary>
	/// <returns>
	///   <see langword="true" /> if the user can undo the previous operation performed in a text box control; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool CanUndo => false;

	/// <summary>Gets or sets the foreground color of the control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the control's foreground color.</returns>
	[DispId(-513)]
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

	/// <summary>Gets or sets a value indicating whether the selected text in the text box control remains highlighted when the control loses focus.</summary>
	/// <returns>
	///   <see langword="true" /> if the selected text does not appear highlighted when the text box control loses focus; <see langword="false" />, if the selected text remains highlighted when the text box control loses focus. The default is <see langword="true" />.</returns>
	[MWFCategory("Behavior")]
	[DefaultValue(true)]
	public bool HideSelection
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the lines of text in a text box control.</summary>
	/// <returns>An array of strings that contains the text in a text box control.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MergableProperty(false)]
	[Localizable(true)]
	[MWFCategory("Appearance")]
	[Editor("System.Windows.Forms.Design.StringArrayEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public string[] Lines => null;

	/// <summary>Gets or sets the maximum number of characters the user can type or paste into the text box control.</summary>
	/// <returns>The number of characters that can be entered into the control. The default is 32767.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value assigned to the property is less than 0.</exception>
	[Localizable(true)]
	[MWFCategory("Behavior")]
	[DefaultValue(32767)]
	public virtual int MaxLength
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value that indicates that the text box control has been modified by the user since the control was created or its contents were last set.</summary>
	/// <returns>
	///   <see langword="true" /> if the control's contents have been modified; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool Modified
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether this is a multiline text box control.</summary>
	/// <returns>
	///   <see langword="true" /> if the control is a multiline text box control; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	[Localizable(true)]
	[MWFCategory("Behavior")]
	[RefreshProperties(RefreshProperties.All)]
	public virtual bool Multiline
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets the preferred height for a text box.</summary>
	/// <returns>The preferred height of a text box.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Browsable(false)]
	public int PreferredHeight => 0;

	/// <summary>Gets or sets a value indicating whether text in the text box is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the text box is read-only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[RefreshProperties(RefreshProperties.Repaint)]
	[DefaultValue(false)]
	[MWFCategory("Behavior")]
	public bool ReadOnly
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating the currently selected text in the control.</summary>
	/// <returns>A string that represents the currently selected text in the text box.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual string SelectedText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the number of characters selected in the text box.</summary>
	/// <returns>The number of characters selected in the text box.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The assigned value is less than zero.</exception>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SelectionLength
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the starting point of text selected in the text box.</summary>
	/// <returns>The starting position of text selected in the text box.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The assigned value is less than zero.</exception>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int SelectionStart
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the current text in the text box.</summary>
	/// <returns>The text displayed in the control.</returns>
	[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[Localizable(true)]
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

	/// <summary>Gets the length of text in the control.</summary>
	/// <returns>The number of characters contained in the text of the control.</returns>
	[Browsable(false)]
	public virtual int TextLength => 0;

	/// <summary>Indicates whether a multiline text box control automatically wraps words to the beginning of the next line when necessary.</summary>
	/// <returns>
	///   <see langword="true" /> if the multiline text box control wraps words; <see langword="false" /> if the text box control automatically scrolls horizontally when the user types past the right edge of the control. The default is <see langword="true" />.</returns>
	[Localizable(true)]
	[MWFCategory("Behavior")]
	[DefaultValue(true)]
	public bool WordWrap
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>This property is not relevant for this class.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ImageLayout" /> values.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
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

	/// <summary>Gets or sets the default cursor for the control.</summary>
	/// <returns>An object of type <see cref="T:System.Windows.Forms.Cursor" /> representing the current default cursor.</returns>
	protected override Cursor DefaultCursor => null;

	/// <summary>Gets the required creation parameters when the control handle is created.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.CreateParams" /> that contains the required creation parameters when the handle to the control is created.</returns>
	protected override CreateParams CreateParams => null;

	/// <summary>Gets the default size of the control.</summary>
	/// <returns>The default <see cref="T:System.Drawing.Size" /> of the control.</returns>
	protected override Size DefaultSize => default(Size);

	/// <summary>Gets or sets a value indicating whether control drawing is done in a buffer before the control is displayed. This property is not relevant for this class.</summary>
	/// <returns>
	///   <see langword="true" /> to implement double buffering on the control; otherwise, <see langword="false" />.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override bool DoubleBuffered => false;

	internal override bool ScaleChildrenInternal => false;

	internal bool ShowSelection
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal int TopMargin
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Occurs when the text box is clicked.</summary>
	[Browsable(true)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public new event EventHandler Click
	{
		add
		{
		}
		remove
		{
		}
	}

	internal TextBoxBase()
	{
	}

	internal string CaseAdjust(string s)
	{
		return null;
	}

	internal override Size GetPreferredSizeCore(Size proposedSize)
	{
		return default(Size);
	}

	internal override void HandleClick(int clicks, MouseEventArgs me)
	{
	}

	internal override void PaintControlBackground(PaintEventArgs pevent)
	{
	}

	/// <summary>Copies the current selection in the text box to the Clipboard.</summary>
	public void Copy()
	{
	}

	/// <summary>Moves the current selection in the text box to the Clipboard.</summary>
	public void Cut()
	{
	}

	/// <summary>Replaces the current selection in the text box with the contents of the Clipboard.</summary>
	public void Paste()
	{
	}

	/// <summary>Scrolls the contents of the control to the current caret position.</summary>
	public void ScrollToCaret()
	{
	}

	/// <summary>Selects all text in the text box.</summary>
	public void SelectAll()
	{
	}

	internal void SelectAllNoScroll()
	{
	}

	/// <summary>Returns a string that represents the <see cref="T:System.Windows.Forms.TextBoxBase" /> control.</summary>
	/// <returns>A string that represents the current <see cref="T:System.Windows.Forms.TextBoxBase" />. The string includes the type and the <see cref="T:System.Windows.Forms.TextBoxBase" /> property of the control.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Undoes the last edit operation in the text box.</summary>
	[MonoInternalNote("Deleting is classed as Typing, instead of its own Undo event")]
	public void Undo()
	{
	}

	/// <summary>Creates a handle for the control.</summary>
	protected override void CreateHandle()
	{
	}

	internal virtual void HandleLinkClicked(LinkRectangle link_clicked)
	{
	}

	/// <summary>Determines whether the specified key is an input key or a special key that requires preprocessing.</summary>
	/// <param name="keyData">One of the Keys value.</param>
	/// <returns>
	///   <see langword="true" /> if the specified key is an input key; otherwise, <see langword="false" />.</returns>
	protected override bool IsInputKey(Keys keyData)
	{
		return false;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TextBoxBase.BorderStyleChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnBorderStyleChanged(EventArgs e)
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

	/// <summary>Raise the <see cref="E:System.Windows.Forms.TextBoxBase.HideSelectionChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnHideSelectionChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TextBoxBase.ModifiedChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnModifiedChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TextBoxBase.MultilineChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnMultilineChanged(EventArgs e)
	{
	}

	/// <summary>This method is not relevant for this class.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnPaddingChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TextBoxBase.ReadOnlyChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnReadOnlyChanged(EventArgs e)
	{
	}

	/// <summary>Processes a command key.</summary>
	/// <param name="msg">A <see cref="T:System.Windows.Forms.Message" />, passed by reference that represents the window message to process.</param>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the shortcut key to process.</param>
	/// <returns>
	///   <see langword="true" /> if the command key was processed by the control; otherwise, <see langword="false" />.</returns>
	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		return false;
	}

	/// <summary>Processes a dialog key.</summary>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
	/// <returns>
	///   <see langword="true" /> if the key was processed by the control; otherwise, <see langword="false" />.</returns>
	protected override bool ProcessDialogKey(Keys keyData)
	{
		return false;
	}

	private bool ProcessKey(Keys keyData)
	{
		return false;
	}

	internal virtual void RaiseSelectionChanged()
	{
	}

	private void HandleBackspace(bool control)
	{
	}

	private void HandleEnter()
	{
	}

	/// <summary>Sets the specified bounds of the <see cref="T:System.Windows.Forms.TextBoxBase" /> control.</summary>
	/// <param name="x">The new <see cref="P:System.Windows.Forms.Control.Left" /> property value of the control.</param>
	/// <param name="y">The new <see cref="P:System.Windows.Forms.Control.Top" /> property value of the control.</param>
	/// <param name="width">The new <see cref="P:System.Windows.Forms.Control.Width" /> property value of the control.</param>
	/// <param name="height">Not used.</param>
	/// <param name="specified">A bitwise combination of the <see cref="T:System.Windows.Forms.BoundsSpecified" /> values.</param>
	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
	}

	/// <summary>Processes Windows messages.</summary>
	/// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
	protected override void WndProc(ref Message m)
	{
	}

	internal Graphics CreateGraphicsInternal()
	{
		return null;
	}

	internal override void OnPaintInternal(PaintEventArgs pevent)
	{
	}

	internal void Draw(Graphics g, Rectangle clippingArea)
	{
	}

	private void FixupHeight()
	{
	}

	private bool IsDoubleClick(MouseEventArgs e)
	{
		return false;
	}

	private void TextBoxBase_MouseDown(object sender, MouseEventArgs e)
	{
	}

	private void TextBoxBase_MouseUp(object sender, MouseEventArgs e)
	{
	}

	private void SizeControls()
	{
	}

	private void PositionControls()
	{
	}

	internal RightToLeft GetInheritedRtoL()
	{
		return default(RightToLeft);
	}

	private void TextBoxBase_SizeChanged(object sender, EventArgs e)
	{
	}

	private void TextBoxBase_RightToLeftChanged(object o, EventArgs e)
	{
	}

	private void TextBoxBase_MouseWheel(object sender, MouseEventArgs e)
	{
	}

	internal virtual void SelectWord()
	{
	}

	internal void CalculateDocument()
	{
	}

	internal void CalculateScrollBars()
	{
	}

	private void document_WidthChanged(object sender, EventArgs e)
	{
	}

	private void document_HeightChanged(object sender, EventArgs e)
	{
	}

	private void ScrollLinks(int xChange, int yChange)
	{
	}

	private void hscroll_ValueChanged(object sender, EventArgs e)
	{
	}

	private void vscroll_ValueChanged(object sender, EventArgs e)
	{
	}

	private void TextBoxBase_MouseMove(object sender, MouseEventArgs e)
	{
	}

	private void TextBoxBase_FontOrColorChanged(object sender, EventArgs e)
	{
	}

	private void ScrollTimerTickHandler(object sender, EventArgs e)
	{
	}

	internal void CaretMoved(object sender, EventArgs e)
	{
	}

	internal bool Paste(IDataObject clip, DataFormats.Format format, bool obey_length)
	{
		return false;
	}

	internal virtual Color ChangeBackColor(Color backColor)
	{
		return default(Color);
	}

	internal override bool IsInputCharInternal(char charCode)
	{
		return false;
	}

	internal virtual void OnTextUpdate()
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnTextChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseUp" /> event.</summary>
	/// <param name="mevent">The event data.</param>
	protected override void OnMouseUp(MouseEventArgs mevent)
	{
	}
}
