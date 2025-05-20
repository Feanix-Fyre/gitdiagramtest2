using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Represents a Windows combo box control.</summary>
[DefaultEvent("SelectedIndexChanged")]
[DefaultBindingProperty("Text")]
[Designer("System.Windows.Forms.Design.ComboBoxDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[DefaultProperty("Items")]
public class ComboBox : ListControl
{
	/// <summary>Represents the collection of items in a <see cref="T:System.Windows.Forms.ComboBox" />.</summary>
	[ListBindable(false)]
	public class ObjectCollection : ICollection, IEnumerable, IList
	{
		private class ObjectComparer : IComparer
		{
			private ListControl owner;

			public ObjectComparer(ListControl owner)
			{
			}

			public int Compare(object x, object y)
			{
				return 0;
			}
		}

		private ComboBox owner;

		internal ArrayList object_items;

		private static object UIACollectionChangedEvent;

		/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Windows.Forms.ComboBox.ObjectCollection" />.</returns>
		object ICollection.SyncRoot => null;

		/// <summary>For a description of this member, see <see cref="P:System.Collections.IList.IsFixedSize" />.</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool IList.IsFixedSize => false;

		/// <summary>Gets the number of items in the collection.</summary>
		/// <returns>The number of items in the collection.</returns>
		public int Count => 0;

		/// <summary>Gets a value indicating whether this collection can be modified.</summary>
		/// <returns>Always <see langword="false" />.</returns>
		public bool IsReadOnly => false;

		/// <summary>Retrieves the item at the specified index within the collection.</summary>
		/// <param name="index">The index of the item in the collection to retrieve.</param>
		/// <returns>An object representing the item located at the specified index within the collection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The index was less than zero.  
		///  -or-  
		///  The <paramref name="index" /> was greater of equal to the count of items in the collection.</exception>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public virtual object this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of <see cref="T:System.Windows.Forms.ComboBox.ObjectCollection" />.</summary>
		/// <param name="owner">The <see cref="T:System.Windows.Forms.ComboBox" /> that owns this object collection.</param>
		public ObjectCollection(ComboBox owner)
		{
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.ICollection.CopyTo(System.Array,System.Int32)" />.</summary>
		/// <param name="destination">The one-dimensional array that is the destination of the elements copied from the collection. The array must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in the array at which copying begins.</param>
		void ICollection.CopyTo(Array destination, int index)
		{
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Add(System.Object)" />.</summary>
		/// <param name="item">An object that represents the item to add to the collection.</param>
		/// <returns>The zero-based index of the item in the collection.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="item" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.SystemException">There is insufficient space available to store the new item.</exception>
		int IList.Add(object item)
		{
			return 0;
		}

		internal void OnUIACollectionChangedEvent(CollectionChangeEventArgs args)
		{
		}

		/// <summary>Adds an item to the list of items for a <see cref="T:System.Windows.Forms.ComboBox" />.</summary>
		/// <param name="item">An object representing the item to add to the collection.</param>
		/// <returns>The zero-based index of the item in the collection.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="item" /> parameter was <see langword="null" />.</exception>
		public int Add(object item)
		{
			return 0;
		}

		/// <summary>Removes all items from the <see cref="T:System.Windows.Forms.ComboBox" />.</summary>
		public void Clear()
		{
		}

		/// <summary>Determines if the specified item is located within the collection.</summary>
		/// <param name="value">An object representing the item to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the item is located within the collection; otherwise, <see langword="false" />.</returns>
		public bool Contains(object value)
		{
			return false;
		}

		/// <summary>Copies the entire collection into an existing array of objects at a specified location within the array.</summary>
		/// <param name="destination">The object array to copy the collection to.</param>
		/// <param name="arrayIndex">The location in the destination array to copy the collection to.</param>
		public void CopyTo(object[] destination, int arrayIndex)
		{
		}

		/// <summary>Returns an enumerator that can be used to iterate through the item collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that represents the item collection.</returns>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>Retrieves the index within the collection of the specified item.</summary>
		/// <param name="value">An object representing the item to locate in the collection.</param>
		/// <returns>The zero-based index where the item is located within the collection; otherwise, -1.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter was <see langword="null" />.</exception>
		public int IndexOf(object value)
		{
			return 0;
		}

		/// <summary>Inserts an item into the collection at the specified index.</summary>
		/// <param name="index">The zero-based index location where the item is inserted.</param>
		/// <param name="item">An object representing the item to insert.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="item" /> was <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> was less than zero.  
		///  -or-  
		///  The <paramref name="index" /> was greater than the count of items in the collection.</exception>
		public void Insert(int index, object item)
		{
		}

		/// <summary>Removes the specified item from the <see cref="T:System.Windows.Forms.ComboBox" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to remove from the list.</param>
		public void Remove(object value)
		{
		}

		/// <summary>Removes an item from the <see cref="T:System.Windows.Forms.ComboBox" /> at the specified index.</summary>
		/// <param name="index">The index of the item to remove.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="value" /> parameter was less than zero.  
		///  -or-  
		///  The <paramref name="value" /> parameter was greater than or equal to the count of items in the collection.</exception>
		public void RemoveAt(int index)
		{
		}

		private int AddItem(object item, bool suspend)
		{
			return 0;
		}

		internal void AddRange(IList items)
		{
		}

		internal void Sort()
		{
		}
	}

	internal class ComboTextBox : TextBox
	{
		private ComboBox owner;

		public override bool Focused => false;

		internal override bool ActivateOnShow => false;

		public ComboTextBox(ComboBox owner)
		{
		}

		private void OwnerLostFocusHandler(object o, EventArgs args)
		{
		}

		protected override void OnKeyDown(KeyEventArgs args)
		{
		}

		internal override void OnAutoCompleteValueSelected(EventArgs args)
		{
		}

		internal void SetSelectable(bool selectable)
		{
		}

		internal void ActivateCaret(bool active)
		{
		}

		internal override void OnTextUpdate()
		{
		}

		protected override void OnGotFocus(EventArgs e)
		{
		}

		protected override void OnLostFocus(EventArgs e)
		{
		}
	}

	internal class ComboListBox : Control
	{
		private class VScrollBarLB : VScrollBar
		{
			internal override bool InternalCapture
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public void FireMouseDown(MouseEventArgs e)
			{
			}

			public void FireMouseUp(MouseEventArgs e)
			{
			}

			public void FireMouseMove(MouseEventArgs e)
			{
			}

			private MouseEventArgs TranslateEvent(MouseEventArgs e)
			{
				return null;
			}
		}

		private ComboBox owner;

		private VScrollBarLB vscrollbar_ctrl;

		private int top_item;

		private int last_item;

		internal int page_size;

		private Rectangle textarea_drawable;

		private int highlighted_index;

		private bool scrollbar_grabbed;

		protected override CreateParams CreateParams => null;

		internal override bool InternalCapture
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal override bool ActivateOnShow => false;

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

		private bool InScrollBar => false;

		public ComboListBox(ComboBox owner)
		{
		}

		internal void CalcListBoxArea()
		{
		}

		private void Draw(Rectangle clip, Graphics dc)
		{
		}

		private Rectangle GetItemDisplayRectangle(int index, int top_index)
		{
			return default(Rectangle);
		}

		public void HideWindow()
		{
		}

		private int IndexFromPointDisplayRectangle(int x, int y)
		{
			return 0;
		}

		public void InvalidateItem(int index)
		{
		}

		public int LastVisibleItem()
		{
			return 0;
		}

		public int FirstVisibleItem()
		{
			return 0;
		}

		public void EnsureTop(int item)
		{
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		internal override void OnPaintInternal(PaintEventArgs pevent)
		{
		}

		public bool ShowWindow()
		{
			return false;
		}

		public void UpdateLastVisibleItem()
		{
		}

		public void Scroll(int delta)
		{
		}

		private void OnMouseWheelCLB(object sender, MouseEventArgs me)
		{
		}

		private void VerticalScrollEvent(object sender, EventArgs e)
		{
		}

		protected override void WndProc(ref Message m)
		{
		}
	}

	private DrawMode draw_mode;

	private ComboBoxStyle dropdown_style;

	private int dropdown_width;

	private int selected_index;

	private ObjectCollection items;

	private bool suspend_ctrlupdate;

	private int maxdrop_items;

	private bool integral_height;

	private bool sorted;

	private ComboListBox listbox_ctrl;

	private ComboTextBox textbox_ctrl;

	private bool process_textchanged_event;

	private bool process_texchanged_autoscroll;

	private bool item_height_specified;

	private int item_height;

	private int requested_height;

	private Hashtable item_heights;

	private bool show_dropdown_button;

	private ButtonState button_state;

	private bool dropped_down;

	private Rectangle text_area;

	private Rectangle button_area;

	private Rectangle listbox_area;

	private bool drop_down_button_entered;

	private AutoCompleteStringCollection auto_complete_custom_source;

	private AutoCompleteMode auto_complete_mode;

	private AutoCompleteSource auto_complete_source;

	private FlatStyle flat_style;

	private int drop_down_height;

	private static object DrawItemEvent;

	private static object DropDownEvent;

	private static object DropDownStyleChangedEvent;

	private static object MeasureItemEvent;

	private static object SelectionChangeCommittedEvent;

	private static object DropDownClosedEvent;

	private static object TextUpdateEvent;

	/// <summary>Gets or sets the background color for the control.</summary>
	/// <returns>A color object that represents the background color of the control. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultBackColor" /> property.</returns>
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

	/// <summary>This property is not relevant to this class.</summary>
	/// <returns>The background image displayed in the control.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override Image BackgroundImage => null;

	/// <summary>Gets or sets the background image layout as defined in the <see cref="T:System.Windows.Forms.ImageLayout" /> enumeration.</summary>
	/// <returns>One of the values of <see cref="T:System.Windows.Forms.ImageLayout" /> (<see langword="Center" />, <see langword="None" />, <see langword="Stretch" />, <see langword="Tile" />, or <see langword="Zoom" />).</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The specified value is not one of the values of <see cref="T:System.Windows.Forms.ImageLayout" />.</exception>
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

	/// <summary>Gets the default size of the control.</summary>
	/// <returns>The default size of the control.</returns>
	protected override Size DefaultSize => default(Size);

	/// <summary>Gets or sets a value indicating whether your code or the operating system will handle drawing of elements in the list.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.DrawMode" /> enumeration values. The default is <see cref="F:System.Windows.Forms.DrawMode.Normal" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value is not a valid <see cref="T:System.Windows.Forms.DrawMode" /> enumeration value.</exception>
	[RefreshProperties(RefreshProperties.Repaint)]
	[MWFCategory("Behavior")]
	[DefaultValue(DrawMode.Normal)]
	public DrawMode DrawMode
	{
		get
		{
			return default(DrawMode);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the height in pixels of the drop-down portion of the <see cref="T:System.Windows.Forms.ComboBox" />.</summary>
	/// <returns>The height, in pixels, of the drop-down box.</returns>
	/// <exception cref="T:System.ArgumentException">The specified value is less than one.</exception>
	[DefaultValue(106)]
	[MWFCategory("Behavior")]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(true)]
	public int DropDownHeight => 0;

	/// <summary>Gets or sets a value specifying the style of the combo box.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ComboBoxStyle" /> values. The default is <see langword="DropDown" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The assigned value is not one of the <see cref="T:System.Windows.Forms.ComboBoxStyle" /> values.</exception>
	[RefreshProperties(RefreshProperties.Repaint)]
	[DefaultValue(ComboBoxStyle.DropDown)]
	[MWFCategory("Appearance")]
	public ComboBoxStyle DropDownStyle
	{
		get
		{
			return default(ComboBoxStyle);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the width of the of the drop-down portion of a combo box.</summary>
	/// <returns>The width, in pixels, of the drop-down box.</returns>
	/// <exception cref="T:System.ArgumentException">The specified value is less than one.</exception>
	[MWFCategory("Behavior")]
	public int DropDownWidth => 0;

	/// <summary>Gets or sets a value indicating whether the combo box is displaying its drop-down portion.</summary>
	/// <returns>
	///   <see langword="true" /> if the drop-down portion is displayed; otherwise, <see langword="false" />. The default is false.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool DroppedDown => false;

	/// <summary>Gets or sets the appearance of the <see cref="T:System.Windows.Forms.ComboBox" />.</summary>
	/// <returns>One of the enumeration values that specifies the appearance of the control. The options are <see langword="Flat" />, <see langword="Popup" />, <see langword="Standard" />, and <see langword="System" />. The default is <see langword="Standard" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The specified value is not one of the values of <see cref="T:System.Windows.Forms.FlatStyle" />.</exception>
	[DefaultValue(FlatStyle.Standard)]
	[Localizable(true)]
	[MWFCategory("Appearance")]
	public FlatStyle FlatStyle => default(FlatStyle);

	/// <summary>Gets a value indicating whether the <see cref="T:System.Windows.Forms.ComboBox" /> has focus.</summary>
	/// <returns>
	///   <see langword="true" /> if this control has focus; otherwise, <see langword="false" />.</returns>
	public override bool Focused => false;

	/// <summary>Gets or sets the foreground color of the control.</summary>
	/// <returns>The foreground color of the control. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultForeColor" /> property.</returns>
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

	/// <summary>Gets or sets a value indicating whether the control should resize to avoid showing partial items.</summary>
	/// <returns>
	///   <see langword="true" /> if the list portion can contain only complete items; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[Localizable(true)]
	[DefaultValue(true)]
	[MWFCategory("Behavior")]
	public bool IntegralHeight => false;

	/// <summary>Gets or sets the height of an item in the combo box.</summary>
	/// <returns>The height, in pixels, of an item in the combo box.</returns>
	/// <exception cref="T:System.ArgumentException">The item height value is less than zero.</exception>
	[Localizable(true)]
	[MWFCategory("Behavior")]
	public int ItemHeight => 0;

	/// <summary>Gets an object representing the collection of the items contained in this <see cref="T:System.Windows.Forms.ComboBox" />.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ComboBox.ObjectCollection" /> representing the items in the <see cref="T:System.Windows.Forms.ComboBox" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[MergableProperty(false)]
	[MWFCategory("Data")]
	[Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[Localizable(true)]
	public ObjectCollection Items => null;

	/// <summary>Gets or sets the maximum number of items to be shown in the drop-down portion of the <see cref="T:System.Windows.Forms.ComboBox" />.</summary>
	/// <returns>The maximum number of items of in the drop-down portion. The minimum for this property is 1 and the maximum is 100.</returns>
	/// <exception cref="T:System.ArgumentException">The maximum number is set less than one or greater than 100.</exception>
	[Localizable(true)]
	[DefaultValue(8)]
	[MWFCategory("Behavior")]
	public int MaxDropDownItems
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the size that is the upper limit that the <see cref="M:System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)" /> method can specify.</summary>
	/// <returns>An ordered pair of type <see cref="T:System.Drawing.Size" /> representing the width and height of a rectangle.</returns>
	public override Size MaximumSize => default(Size);

	/// <summary>Gets or sets the size that is the lower limit that the <see cref="M:System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)" /> method can specify.</summary>
	/// <returns>An ordered pair of type <see cref="T:System.Drawing.Size" /> representing the width and height of a rectangle.</returns>
	public override Size MinimumSize
	{
		get
		{
			return default(Size);
		}
		set
		{
		}
	}

	/// <summary>Gets the preferred height of the <see cref="T:System.Windows.Forms.ComboBox" />.</summary>
	/// <returns>The preferred height, in pixels, of the item area of the combo box.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public int PreferredHeight => 0;

	/// <summary>Gets or sets the index specifying the currently selected item.</summary>
	/// <returns>A zero-based index of the currently selected item. A value of negative one (-1) is returned if no item is selected.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The specified index is less than or equal to -2.  
	///  -or-  
	///  The specified index is greater than or equal to the number of items in the combo box.</exception>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override int SelectedIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets currently selected item in the <see cref="T:System.Windows.Forms.ComboBox" />.</summary>
	/// <returns>The object that is the currently selected item or <see langword="null" /> if there is no currently selected item.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[Bindable(true)]
	public object SelectedItem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the items in the combo box are sorted.</summary>
	/// <returns>
	///   <see langword="true" /> if the combo box is sorted; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">An attempt was made to sort a <see cref="T:System.Windows.Forms.ComboBox" /> that is attached to a data source.</exception>
	[MWFCategory("Behavior")]
	[DefaultValue(false)]
	public bool Sorted => false;

	/// <summary>Gets or sets the text associated with this control.</summary>
	/// <returns>The text associated with this control.</returns>
	[Bindable(true)]
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

	internal Rectangle ButtonArea => default(Rectangle);

	internal Rectangle TextArea => default(Rectangle);

	internal override bool InternalCapture
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool DropDownButtonEntered
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

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

	/// <summary>Occurs when the <see cref="P:System.Windows.Forms.ComboBox.SelectedIndex" /> property has changed.</summary>
	public event EventHandler SelectedIndexChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ComboBox" /> class.</summary>
	public ComboBox()
	{
	}

	private void SetTextBoxAutoCompleteData()
	{
	}

	/// <summary>Maintains performance when items are added to the <see cref="T:System.Windows.Forms.ComboBox" /> one at a time.</summary>
	public void BeginUpdate()
	{
	}

	/// <summary>Creates a handle for the control.</summary>
	protected override void CreateHandle()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.ComboBox" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Resumes painting the <see cref="T:System.Windows.Forms.ComboBox" /> control after painting is suspended by the <see cref="M:System.Windows.Forms.ComboBox.BeginUpdate" /> method.</summary>
	public void EndUpdate()
	{
	}

	private int FindStringExact(string s, int startIndex, bool ignoreCase)
	{
		return 0;
	}

	/// <summary>Returns the height of an item in the <see cref="T:System.Windows.Forms.ComboBox" />.</summary>
	/// <param name="index">The index of the item to return the height of.</param>
	/// <returns>The height, in pixels, of the item at the specified index.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> is less than zero.  
	///  -or-  
	///  The <paramref name="index" /> is greater than count of items in the list.</exception>
	public int GetItemHeight(int index)
	{
		return 0;
	}

	/// <summary>Determines whether the specified key is a regular input key or a special key that requires preprocessing.</summary>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values.</param>
	/// <returns>
	///   <see langword="true" /> if the specified key is a regular input key; otherwise, <see langword="false" />.</returns>
	protected override bool IsInputKey(Keys keyData)
	{
		return false;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.BackColorChanged" /> event.</summary>
	/// <param name="e">The event data.</param>
	protected override void OnBackColorChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ComboBox.DrawItem" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.DrawItemEventArgs" /> that contains the event data.</param>
	protected virtual void OnDrawItem(DrawItemEventArgs e)
	{
	}

	internal void HandleDrawItem(DrawItemEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ComboBox.DropDown" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnDropDown(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ComboBox.DropDownClosed" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnDropDownClosed(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ComboBox.DropDownStyleChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnDropDownStyleChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.FontChanged" /> event.</summary>
	/// <param name="e">The event data.</param>
	protected override void OnFontChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.ForeColorChanged" /> event.</summary>
	/// <param name="e">The event data.</param>
	protected override void OnForeColorChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.GotFocus" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnGotFocus(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.LostFocus" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnLostFocus(EventArgs e)
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

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.KeyPress" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.KeyPressEventArgs" /> that contains the event data.</param>
	protected override void OnKeyPress(KeyPressEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ComboBox.MeasureItem" /> event.</summary>
	/// <param name="e">The <see cref="T:System.Windows.Forms.MeasureItemEventArgs" /> that was raised.</param>
	protected virtual void OnMeasureItem(MeasureItemEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.BackColorChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnParentBackColorChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnResize(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ComboBox.SelectedIndexChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnSelectedIndexChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.DomainUpDown.SelectedItemChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnSelectedItemChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ListControl.SelectedValueChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnSelectedValueChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ComboBox.SelectionChangeCommitted" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnSelectionChangeCommitted(EventArgs e)
	{
	}

	/// <summary>Refreshes the item contained at the specified location.</summary>
	/// <param name="index">The location of the item to refresh.</param>
	protected override void RefreshItem(int index)
	{
	}

	/// <summary>Processes a key message and generates the appropriate control events.</summary>
	/// <param name="m">A message object, passed by reference, that represents the window message to process.</param>
	/// <returns>
	///   <see langword="true" /> if the message was processed by the control; otherwise, <see langword="false" />.</returns>
	protected override bool ProcessKeyEventArgs(ref Message m)
	{
		return false;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.KeyDown" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.KeyEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnKeyDown(KeyEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Validating" /> event.</summary>
	/// <param name="e">A <see cref="T:System.ComponentModel.CancelEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnValidating(CancelEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnTextChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ComboBox.TextUpdate" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnTextUpdate(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseLeave(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseEnter" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseEnter(EventArgs e)
	{
	}

	/// <summary>Scales a control's location, size, padding and margin.</summary>
	/// <param name="factor">The factor by which the height and width of the control will be scaled.</param>
	/// <param name="specified">A  value that specifies the bounds of the control to use when defining its size and position.</param>
	protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
	{
	}

	/// <summary>Sets the size and location of the <see cref="T:System.Windows.Forms.ComboBox" />.</summary>
	/// <param name="x">The horizontal location in pixels of the control.</param>
	/// <param name="y">The vertical location in pixels of the control.</param>
	/// <param name="width">The width in pixels of the control.</param>
	/// <param name="height">The height in pixels of the control.</param>
	/// <param name="specified">One of the <see cref="T:System.Windows.Forms.BoundsSpecified" /> values.</param>
	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
	}

	/// <summary>When overridden in a derived class, sets the specified array of objects in a collection in the derived class.</summary>
	/// <param name="value">An array of items.</param>
	protected override void SetItemsCore(IList value)
	{
	}

	/// <summary>Returns a string that represents the <see cref="T:System.Windows.Forms.ComboBox" /> control.</summary>
	/// <returns>A <see cref="T:System.String" /> that represents the current <see cref="T:System.Windows.Forms.ComboBox" />. The string includes the type and the number of items in the <see cref="T:System.Windows.Forms.ComboBox" /> control.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Processes Windows messages.</summary>
	/// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
	protected override void WndProc(ref Message m)
	{
	}

	private void LayoutComboBox()
	{
	}

	private void CreateComboListBox()
	{
	}

	internal void Draw(Rectangle clip, Graphics dc)
	{
	}

	internal void DropDownListBox()
	{
	}

	internal void DropDownListBoxFinished()
	{
	}

	private int FindStringCaseInsensitive(string search)
	{
		return 0;
	}

	internal int FindStringCaseInsensitive(string search, int start_index)
	{
		return 0;
	}

	internal override bool IsInputCharInternal(char charCode)
	{
		return false;
	}

	internal void RestoreContextMenu()
	{
	}

	private void OnKeyDownCB(object sender, KeyEventArgs e)
	{
	}

	private void SetSelectedIndex(int value, bool supressAutoScroll)
	{
	}

	private void FindMatchOrSetIndex(int index)
	{
	}

	private void OnMouseDownCB(object sender, MouseEventArgs e)
	{
	}

	private void OnMouseEnter(object sender, EventArgs e)
	{
	}

	private void OnMouseLeave(object sender, EventArgs e)
	{
	}

	private void OnMouseMoveCB(object sender, MouseEventArgs e)
	{
	}

	private void OnMouseUpCB(object sender, MouseEventArgs e)
	{
	}

	private void OnMouseWheelCB(object sender, MouseEventArgs me)
	{
	}

	internal override void OnPaintInternal(PaintEventArgs pevent)
	{
	}

	private void OnTextBoxClick(object sender, EventArgs e)
	{
	}

	private void OnTextChangedEdit(object sender, EventArgs e)
	{
	}

	private void OnTextKeyPress(object sender, KeyPressEventArgs e)
	{
	}

	internal void SetControlText(string s, bool suppressTextChanged)
	{
	}

	internal void SetControlText(string s, bool suppressTextChanged, bool supressAutoScroll)
	{
	}

	private void UpdateComboBoxBounds()
	{
	}

	private int SnapHeight(int height)
	{
		return 0;
	}

	private void UpdatedItems()
	{
	}
}
