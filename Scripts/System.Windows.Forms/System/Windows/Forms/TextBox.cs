using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Represents a Windows text box control.</summary>
[ComVisible(true)]
[Designer("System.Windows.Forms.Design.TextBoxDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class TextBox : TextBoxBase
{
	private class AutoCompleteListBox : Control
	{
		private TextBox owner;

		private VScrollBar vscroll;

		private int top_item;

		private int last_item;

		internal int page_size;

		private int item_height;

		private int highlighted_index;

		private bool user_defined_size;

		private bool resizing;

		private Rectangle resizer_bounds;

		protected override CreateParams CreateParams => null;

		public int HighlightedIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal override bool ActivateOnShow => false;

		public AutoCompleteListBox(TextBox tb)
		{
		}

		public void Scroll(int lines)
		{
		}

		public void EnsureVisible(int index)
		{
		}

		private void VScrollValueChanged(object o, EventArgs args)
		{
		}

		private int GetLastVisibleItem()
		{
			return 0;
		}

		private Rectangle GetItemBounds(int index)
		{
			return default(Rectangle);
		}

		private int GetItemAt(Point loc)
		{
			return 0;
		}

		private void LayoutListBox()
		{
		}

		public void HideListBox(bool set_text)
		{
		}

		public void ShowListBox()
		{
		}

		protected override void OnResize(EventArgs args)
		{
		}

		protected override void OnMouseDown(MouseEventArgs args)
		{
		}

		protected override void OnMouseMove(MouseEventArgs args)
		{
		}

		protected override void OnMouseUp(MouseEventArgs args)
		{
		}

		internal override void OnPaintInternal(PaintEventArgs args)
		{
		}
	}

	private ContextMenu menu;

	private MenuItem undo;

	private MenuItem cut;

	private MenuItem copy;

	private MenuItem paste;

	private MenuItem delete;

	private MenuItem select_all;

	private bool use_system_password_char;

	private AutoCompleteStringCollection auto_complete_custom_source;

	private AutoCompleteMode auto_complete_mode;

	private AutoCompleteSource auto_complete_source;

	private AutoCompleteListBox auto_complete_listbox;

	private string auto_complete_original_text;

	private int auto_complete_selected_index;

	private List<string> auto_complete_matches;

	private ComboBox auto_complete_cb_source;

	private static object TextAlignChangedEvent;

	internal bool IsAutoCompleteAvailable => false;

	internal ComboBox AutoCompleteInternalSource
	{
		set
		{
		}
	}

	internal bool CanNavigateAutoCompleteList => false;

	/// <summary>Gets or sets a custom <see cref="T:System.Collections.Specialized.StringCollection" /> to use when the <see cref="P:System.Windows.Forms.TextBox.AutoCompleteSource" /> property is set to <see langword="CustomSource" />.</summary>
	/// <returns>A <see cref="T:System.Collections.Specialized.StringCollection" /> to use with <see cref="P:System.Windows.Forms.TextBox.AutoCompleteSource" />.</returns>
	[Localizable(true)]
	[System.MonoTODO("AutoCompletion algorithm is currently not implemented.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(true)]
	[Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public AutoCompleteStringCollection AutoCompleteCustomSource
	{
		set
		{
		}
	}

	/// <summary>Gets or sets an option that controls how automatic completion works for the <see cref="T:System.Windows.Forms.TextBox" />.</summary>
	/// <returns>One of the values of <see cref="T:System.Windows.Forms.AutoCompleteMode" />. The following are the values.  
	///  <see cref="F:System.Windows.Forms.AutoCompleteMode.Append" /> Appends the remainder of the most likely candidate string to the existing characters, highlighting the appended characters.  
	///  <see cref="F:System.Windows.Forms.AutoCompleteMode.Suggest" /> Displays the auxiliary drop-down list associated with the edit control. This drop-down is populated with one or more suggested completion strings.  
	///  <see cref="F:System.Windows.Forms.AutoCompleteMode.SuggestAppend" /> Appends both <see langword="Suggest" /> and <see langword="Append" /> options.  
	///  <see cref="F:System.Windows.Forms.AutoCompleteMode.None" /> Disables automatic completion. This is the default.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The specified value is not one of the values of <see cref="T:System.Windows.Forms.AutoCompleteMode" />.</exception>
	[System.MonoTODO("AutoCompletion algorithm is currently not implemented.")]
	[DefaultValue(AutoCompleteMode.None)]
	[Browsable(true)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public AutoCompleteMode AutoCompleteMode
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value specifying the source of complete strings used for automatic completion.</summary>
	/// <returns>One of the values of <see cref="T:System.Windows.Forms.AutoCompleteSource" />. The options are <see langword="AllSystemSources" />, <see langword="AllUrl" />, <see langword="FileSystem" />, <see langword="HistoryList" />, <see langword="RecentlyUsedList" />, <see langword="CustomSource" />, and <see langword="None" />. The default is <see langword="None" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The specified value is not one of the values of <see cref="T:System.Windows.Forms.AutoCompleteSource" />.</exception>
	[Browsable(true)]
	[TypeConverter(typeof(TextBoxAutoCompleteSourceConverter))]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[DefaultValue(AutoCompleteSource.None)]
	[System.MonoTODO("AutoCompletion algorithm is currently not implemented.")]
	public AutoCompleteSource AutoCompleteSource
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the text in the <see cref="T:System.Windows.Forms.TextBox" /> control should appear as the default password character.</summary>
	/// <returns>
	///   <see langword="true" /> if the text in the <see cref="T:System.Windows.Forms.TextBox" /> control should appear as the default password character; otherwise, <see langword="false" />.</returns>
	[DefaultValue(false)]
	[RefreshProperties(RefreshProperties.Repaint)]
	public bool UseSystemPasswordChar
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the character used to mask characters of a password in a single-line <see cref="T:System.Windows.Forms.TextBox" /> control.</summary>
	/// <returns>The character used to mask characters entered in a single-line <see cref="T:System.Windows.Forms.TextBox" /> control. Set the value of this property to 0 (character value) if you do not want the control to mask characters as they are typed. Equals 0 (character value) by default.</returns>
	[DefaultValue('\0')]
	[MWFCategory("Behavior")]
	[Localizable(true)]
	[RefreshProperties(RefreshProperties.Repaint)]
	public char PasswordChar => '\0';

	/// <summary>Gets or sets which scroll bars should appear in a multiline <see cref="T:System.Windows.Forms.TextBox" /> control.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ScrollBars" /> enumeration values that indicates whether a multiline <see cref="T:System.Windows.Forms.TextBox" /> control appears with no scroll bars, a horizontal scroll bar, a vertical scroll bar, or both. The default is <see langword="ScrollBars.None" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">A value that is not within the range of valid values for the enumeration was assigned to the property.</exception>
	[Localizable(true)]
	[MWFCategory("Appearance")]
	[DefaultValue(ScrollBars.None)]
	public ScrollBars ScrollBars
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the text associated with this control.</summary>
	/// <returns>The text associated with this control.</returns>
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

	/// <summary>Gets or sets how text is aligned in a <see cref="T:System.Windows.Forms.TextBox" /> control.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.HorizontalAlignment" /> enumeration values that specifies how text is aligned in the control. The default is <see langword="HorizontalAlignment.Left" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">A value that is not within the range of valid values for the enumeration was assigned to the property.</exception>
	[Localizable(true)]
	[MWFCategory("Appearance")]
	[DefaultValue(HorizontalAlignment.Left)]
	public HorizontalAlignment TextAlign
	{
		set
		{
		}
	}

	/// <summary>Gets the required creation parameters when the control handle is created.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.CreateParams" /> that contains the required creation parameters when the handle to the control is created.</returns>
	protected override CreateParams CreateParams => null;

	internal override ContextMenu ContextMenuInternal
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether this is a multiline <see cref="T:System.Windows.Forms.TextBox" /> control.</summary>
	/// <returns>
	///   <see langword="true" /> if the control is a multiline <see cref="T:System.Windows.Forms.TextBox" /> control; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public override bool Multiline
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.TextBox" /> class.</summary>
	public TextBox()
	{
	}

	private void TextBox_RightToLeftChanged(object sender, EventArgs e)
	{
	}

	private void TextBox_LostFocus(object sender, EventArgs e)
	{
	}

	private void TextBox_MouseWheel(object o, MouseEventArgs args)
	{
	}

	private void ProcessAutoCompleteInput(ref Message m, bool deleting_chars)
	{
	}

	private void ShowAutoCompleteListBox(bool deleting_chars)
	{
	}

	internal void HideAutoCompleteList()
	{
	}

	private bool NavigateAutoCompleteList(Keys key)
	{
		return false;
	}

	private void AppendAutoCompleteMatch(int index)
	{
	}

	internal virtual void OnAutoCompleteValueSelected(EventArgs args)
	{
	}

	private void UpdateAlignment()
	{
	}

	internal override Color ChangeBackColor(Color backColor)
	{
		return default(Color);
	}

	private void OnAutoCompleteCustomSourceChanged(object sender, CollectionChangeEventArgs e)
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.TextBox" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Determines whether the specified key is an input key or a special key that requires preprocessing.</summary>
	/// <param name="keyData">One of the key's values.</param>
	/// <returns>
	///   <see langword="true" /> if the specified key is an input key; otherwise, <see langword="false" />.</returns>
	protected override bool IsInputKey(Keys keyData)
	{
		return false;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.GotFocus" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnGotFocus(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.HandleCreated" /> event.</summary>
	/// <param name="e">The event data.</param>
	protected override void OnHandleCreated(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TextBox.TextAlignChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnTextAlignChanged(EventArgs e)
	{
	}

	/// <summary>Processes Windows messages.</summary>
	/// <param name="m">A Windows Message object.</param>
	protected override void WndProc(ref Message m)
	{
	}

	internal void RestoreContextMenu()
	{
	}

	private void menu_Popup(object sender, EventArgs e)
	{
	}

	private void undo_Click(object sender, EventArgs e)
	{
	}

	private void cut_Click(object sender, EventArgs e)
	{
	}

	private void copy_Click(object sender, EventArgs e)
	{
	}

	private void paste_Click(object sender, EventArgs e)
	{
	}

	private void delete_Click(object sender, EventArgs e)
	{
	}

	private void select_all_Click(object sender, EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.BackColorChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnBackColorChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.FontChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnFontChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.Control.OnHandleDestroyed(System.EventArgs)" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnHandleDestroyed(EventArgs e)
	{
	}
}
