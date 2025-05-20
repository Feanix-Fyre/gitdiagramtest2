using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Windows.Forms;

/// <summary>Represents an item in a <see cref="T:System.Windows.Forms.ListView" /> control.</summary>
[Serializable]
[DesignTimeVisible(false)]
[ToolboxItem(false)]
[TypeConverter(typeof(ListViewItemConverter))]
[DefaultProperty("Text")]
public class ListViewItem : ISerializable, ICloneable
{
	/// <summary>Represents a subitem of a <see cref="T:System.Windows.Forms.ListViewItem" />.</summary>
	[Serializable]
	[ToolboxItem(false)]
	[DefaultProperty("Text")]
	[DesignTimeVisible(false)]
	[TypeConverter(typeof(ListViewSubItemConverter))]
	public class ListViewSubItem
	{
		[Serializable]
		private class SubItemStyle
		{
			public Color backColor;

			public Color foreColor;

			public Font font;

			public SubItemStyle()
			{
			}

			public SubItemStyle(Color foreColor, Color backColor, Font font)
			{
			}
		}

		[NonSerialized]
		internal ListViewItem owner;

		private string text;

		private string name;

		private object userData;

		private SubItemStyle style;

		[NonSerialized]
		internal Rectangle bounds;

		/// <summary>Gets or sets the background color of the subitem's text.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the background color of the subitem's text.</returns>
		public Color BackColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		/// <summary>Gets the bounding rectangle of the <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" />.</summary>
		/// <returns>The bounding <see cref="T:System.Drawing.Rectangle" /> of the <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" />.</returns>
		[Browsable(false)]
		public Rectangle Bounds => default(Rectangle);

		/// <summary>Gets or sets the font of the text displayed by the subitem.</summary>
		/// <returns>The <see cref="T:System.Drawing.Font" /> to apply to the text displayed by the control.</returns>
		[Localizable(true)]
		public Font Font => null;

		/// <summary>Gets or sets the foreground color of the subitem's text.</summary>
		/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the foreground color of the subitem's text.</returns>
		public Color ForeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the text of the subitem.</summary>
		/// <returns>The text to display for the subitem.</returns>
		[Localizable(true)]
		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal event EventHandler UIATextChanged
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> class with default values.</summary>
		public ListViewSubItem()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> class with the specified owner and text.</summary>
		/// <param name="owner">A <see cref="T:System.Windows.Forms.ListViewItem" /> that represents the item that owns the subitem.</param>
		/// <param name="text">The text to display for the subitem.</param>
		public ListViewSubItem(ListViewItem owner, string text)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> class with the specified owner, text, foreground color, background color, and font values.</summary>
		/// <param name="owner">A <see cref="T:System.Windows.Forms.ListViewItem" /> that represents the item that owns the subitem.</param>
		/// <param name="text">The text to display for the subitem.</param>
		/// <param name="foreColor">A <see cref="T:System.Drawing.Color" /> that represents the foreground color of the subitem.</param>
		/// <param name="backColor">A <see cref="T:System.Drawing.Color" /> that represents the background color of the subitem.</param>
		/// <param name="font">A <see cref="T:System.Drawing.Font" /> that represents the font to display the subitem's text in.</param>
		public ListViewSubItem(ListViewItem owner, string text, Color foreColor, Color backColor, Font font)
		{
		}

		private void OnUIATextChanged()
		{
		}

		/// <summary>Returns a string that represents the current object.</summary>
		/// <returns>A string that represents the current object.</returns>
		public override string ToString()
		{
			return null;
		}

		private void Invalidate()
		{
		}

		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
		}

		internal void SetBounds(int x, int y, int width, int height)
		{
		}
	}

	/// <summary>Represents a collection of <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> objects stored in a <see cref="T:System.Windows.Forms.ListViewItem" />.</summary>
	public class ListViewSubItemCollection : ICollection, IEnumerable, IList
	{
		private ArrayList list;

		internal ListViewItem owner;

		/// <summary>Gets a value indicating whether access to the collection is synchronized (thread safe).</summary>
		/// <returns>
		///   <see langword="true" /> in all cases.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>The object used to synchronize the collection.</returns>
		object ICollection.SyncRoot => null;

		/// <summary>Gets a value indicating whether the collection has a fixed size.</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool IList.IsFixedSize => false;

		/// <summary>Gets or sets the <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> at the specified index within the collection.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>A <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> that represents the item located at the specified index within the collection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The index parameter is less than 0 or greater than or equal to the value of the Count property of the <see cref="T:System.Windows.Forms.ListView.ColumnHeaderCollection" />.</exception>
		/// <exception cref="T:System.ArgumentException">The object is not a <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" />.</exception>
		object IList.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets the number of subitems in the collection.</summary>
		/// <returns>The number of subitems in the collection.</returns>
		[Browsable(false)]
		public int Count => 0;

		/// <summary>Gets a value indicating whether the collection is read-only.</summary>
		/// <returns>
		///   <see langword="true" /> if the collection is read-only; otherwise, <see langword="false" />.</returns>
		public bool IsReadOnly => false;

		/// <summary>Gets or sets the subitem at the specified index within the collection.</summary>
		/// <param name="index">The index of the item in the collection to retrieve.</param>
		/// <returns>A <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> representing the subitem located at the specified index within the collection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> parameter is less than zero or greater than or equal to the value of the <see cref="P:System.Windows.Forms.ListViewItem.ListViewSubItemCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItemCollection" />.</exception>
		public ListViewSubItem this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ListViewSubItemCollection(ListViewItem owner, string text)
		{
		}

		/// <summary>Copies the item and collection of subitems into an array.</summary>
		/// <param name="dest">An array of <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" />.</param>
		/// <param name="index">The zero-based index in array at which copying begins.</param>
		/// <exception cref="T:System.ArrayTypeMismatchException">The array type is not compatible with <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" />.</exception>
		void ICollection.CopyTo(Array dest, int index)
		{
		}

		/// <summary>Adds an existing <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> to the collection.</summary>
		/// <param name="item">The <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> to add to the collection.</param>
		/// <returns>The zero-based index that indicates the location of the object that was added to the collection.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="item" /> is not a <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" />.</exception>
		int IList.Add(object item)
		{
			return 0;
		}

		/// <summary>Determines whether the specified subitem is located in the collection.</summary>
		/// <param name="subItem">An object that represents the subitem to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the subitem is contained in the collection; otherwise, <see langword="false" />.</returns>
		bool IList.Contains(object subItem)
		{
			return false;
		}

		/// <summary>Returns the index within the collection of the specified subitem.</summary>
		/// <param name="subItem">An object that represents the subitem to locate in the collection.</param>
		/// <returns>The zero-based index of the subitem if it is in the collection; otherwise, -1.</returns>
		int IList.IndexOf(object subItem)
		{
			return 0;
		}

		/// <summary>Inserts a subitem into the collection at the specified index.</summary>
		/// <param name="index">The zero-based index location where the item is inserted.</param>
		/// <param name="item">An object that represents the subitem to insert into the collection.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="item" /> is not a <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The index parameter is less than 0 or greater than or equal to the value of the Count property of the <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItemCollection" />.</exception>
		void IList.Insert(int index, object item)
		{
		}

		/// <summary>Removes a specified item from the collection.</summary>
		/// <param name="item">The item to remove from the collection.</param>
		void IList.Remove(object item)
		{
		}

		/// <summary>Adds an existing <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> to the collection.</summary>
		/// <param name="item">The <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> to add to the collection.</param>
		/// <returns>The <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> that was added to the collection.</returns>
		public ListViewSubItem Add(ListViewSubItem item)
		{
			return null;
		}

		/// <summary>Adds a subitem to the collection with specified text.</summary>
		/// <param name="text">The text to display for the subitem.</param>
		/// <returns>The <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> that was added to the collection.</returns>
		public ListViewSubItem Add(string text)
		{
			return null;
		}

		/// <summary>Adds a subitem to the collection with specified text, foreground color, background color, and font settings.</summary>
		/// <param name="text">The text to display for the subitem.</param>
		/// <param name="foreColor">A <see cref="T:System.Drawing.Color" /> that represents the foreground color of the subitem.</param>
		/// <param name="backColor">A <see cref="T:System.Drawing.Color" /> that represents the background color of the subitem.</param>
		/// <param name="font">A <see cref="T:System.Drawing.Font" /> that represents the typeface to display the subitem's text in.</param>
		/// <returns>The <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> that was added to the collection.</returns>
		public ListViewSubItem Add(string text, Color foreColor, Color backColor, Font font)
		{
			return null;
		}

		private void AddSubItem(ListViewSubItem subItem)
		{
		}

		/// <summary>Removes all subitems and the parent <see cref="T:System.Windows.Forms.ListViewItem" /> from the collection.</summary>
		public void Clear()
		{
		}

		/// <summary>Determines whether the specified subitem is located in the collection.</summary>
		/// <param name="subItem">A <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> representing the subitem to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the subitem is contained in the collection; otherwise, <see langword="false" />.</returns>
		public bool Contains(ListViewSubItem subItem)
		{
			return false;
		}

		/// <summary>Returns an enumerator to use to iterate through the subitem collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that represents the subitem collection.</returns>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>Returns the index within the collection of the specified subitem.</summary>
		/// <param name="subItem">A <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> representing the subitem to locate in the collection.</param>
		/// <returns>The zero-based index of the subitem's location in the collection. If the subitem is not located in the collection, the return value is negative one (-1).</returns>
		public int IndexOf(ListViewSubItem subItem)
		{
			return 0;
		}

		/// <summary>Inserts a subitem into the collection at the specified index.</summary>
		/// <param name="index">The zero-based index location where the item is inserted.</param>
		/// <param name="item">A <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItem" /> representing the subitem to insert into the collection.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> parameter is less than zero or greater than the value of the <see cref="P:System.Windows.Forms.ListViewItem.ListViewSubItemCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItemCollection" />.</exception>
		public void Insert(int index, ListViewSubItem item)
		{
		}

		/// <summary>Removes a specified item from the collection.</summary>
		/// <param name="item">The item to remove from the collection.</param>
		public void Remove(ListViewSubItem item)
		{
		}

		/// <summary>Removes the subitem at the specified index within the collection.</summary>
		/// <param name="index">The zero-based index of the subitem to remove.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> parameter is less than zero or greater than or equal to the value of the <see cref="P:System.Windows.Forms.ListViewItem.ListViewSubItemCollection.Count" /> property of the <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItemCollection" />.</exception>
		public void RemoveAt(int index)
		{
		}

		private void OnUIASubItemTextChanged(object sender, EventArgs args)
		{
		}
	}

	private int image_index;

	private bool is_checked;

	private int state_image_index;

	private ListViewSubItemCollection sub_items;

	private object tag;

	private bool use_item_style;

	private int display_index;

	private ListViewGroup group;

	private string name;

	private string image_key;

	private string tooltip_text;

	private int indent_count;

	private Point position;

	private Rectangle bounds;

	private Rectangle checkbox_rect;

	private Rectangle icon_rect;

	private Rectangle item_rect;

	private Rectangle label_rect;

	private ListView owner;

	private Font font;

	private Font hot_font;

	private bool selected;

	private Rectangle text_bounds;

	private EventHandler UIATextChanged;

	private LabelEditEventHandler UIASubItemTextChanged;

	/// <summary>Gets or sets the background color of the item's text.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the background color of the item's text.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Color BackColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	/// <summary>Gets the bounding rectangle of the item, including subitems.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that represents the bounding rectangle of the item.</returns>
	[Browsable(false)]
	public Rectangle Bounds => default(Rectangle);

	/// <summary>Gets or sets a value indicating whether the item is checked.</summary>
	/// <returns>
	///   <see langword="true" /> if the item is checked; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	[RefreshProperties(RefreshProperties.Repaint)]
	public bool Checked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the item has focus within the <see cref="T:System.Windows.Forms.ListView" /> control.</summary>
	/// <returns>
	///   <see langword="true" /> if the item has focus; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool Focused
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
	/// <returns>The <see cref="T:System.Drawing.Font" /> to apply to the text displayed by the control. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultFont" /> property if the <see cref="T:System.Windows.Forms.ListViewItem" /> is not associated with a <see cref="T:System.Windows.Forms.ListView" /> control; otherwise, the font specified in the <see cref="P:System.Windows.Forms.Control.Font" /> property for the <see cref="T:System.Windows.Forms.ListView" /> control is used.</returns>
	[Localizable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Font Font => null;

	/// <summary>Gets or sets the foreground color of the item's text.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the foreground color of the item's text.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Color ForeColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the index of the image that is displayed for the item.</summary>
	/// <returns>The zero-based index of the image in the <see cref="T:System.Windows.Forms.ImageList" /> that is displayed for the item. The default is -1.</returns>
	/// <exception cref="T:System.ArgumentException">The value specified is less than -1.</exception>
	[Localizable(true)]
	[RefreshProperties(RefreshProperties.Repaint)]
	[TypeConverter(typeof(NoneExcludedImageIndexConverter))]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[DefaultValue(-1)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int ImageIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the key for the image that is displayed for the item.</summary>
	/// <returns>The key for the image that is displayed for the <see cref="T:System.Windows.Forms.ListViewItem" />.</returns>
	[TypeConverter(typeof(ImageKeyConverter))]
	[RefreshProperties(RefreshProperties.Repaint)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue(null)]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[Localizable(true)]
	public string ImageKey => null;

	/// <summary>Gets or sets the number of small image widths by which to indent the <see cref="T:System.Windows.Forms.ListViewItem" />.</summary>
	/// <returns>The number of small image widths by which to indent the <see cref="T:System.Windows.Forms.ListViewItem" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">When setting <see cref="P:System.Windows.Forms.ListViewItem.IndentCount" />, the number specified is less than 0.</exception>
	[DefaultValue(0)]
	public int IndentCount => 0;

	/// <summary>Gets the zero-based index of the item within the <see cref="T:System.Windows.Forms.ListView" /> control.</summary>
	/// <returns>The zero-based index of the item within the <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> of the <see cref="T:System.Windows.Forms.ListView" /> control, or -1 if the item is not associated with a <see cref="T:System.Windows.Forms.ListView" /> control.</returns>
	[Browsable(false)]
	public int Index => 0;

	/// <summary>Gets the <see cref="T:System.Windows.Forms.ListView" /> control that contains the item.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ListView" /> that contains the <see cref="T:System.Windows.Forms.ListViewItem" />.</returns>
	[Browsable(false)]
	public ListView ListView => null;

	/// <summary>Gets or sets a value indicating whether the item is selected.</summary>
	/// <returns>
	///   <see langword="true" /> if the item is selected; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool Selected
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets a collection containing all subitems of the item.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ListViewItem.ListViewSubItemCollection" /> that contains the subitems.</returns>
	[Editor("System.Windows.Forms.Design.ListViewSubItemCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public ListViewSubItemCollection SubItems => null;

	/// <summary>Gets or sets the text of the item.</summary>
	/// <returns>The text to display for the item. This should not exceed 259 characters.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Localizable(true)]
	public string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the <see cref="P:System.Windows.Forms.ListViewItem.Font" />, <see cref="P:System.Windows.Forms.ListViewItem.ForeColor" />, and <see cref="P:System.Windows.Forms.ListViewItem.BackColor" /> properties for the item are used for all its subitems.</summary>
	/// <returns>
	///   <see langword="true" /> if all subitems use the font, foreground color, and background color settings of the item; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool UseItemStyleForSubItems => false;

	/// <summary>Gets or sets the group to which the item is assigned.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.ListViewGroup" /> to which the item is assigned.</returns>
	[Localizable(true)]
	[DefaultValue(null)]
	public ListViewGroup Group => null;

	/// <summary>Gets or sets the text shown when the mouse pointer rests on the <see cref="T:System.Windows.Forms.ListViewItem" />.</summary>
	/// <returns>The text shown when the mouse pointer rests on the <see cref="T:System.Windows.Forms.ListViewItem" />.</returns>
	[DefaultValue(null)]
	public string ToolTipText => null;

	internal Rectangle CheckRectReal => default(Rectangle);

	internal Rectangle TextBounds => default(Rectangle);

	internal int DisplayIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal bool Hot => false;

	internal Font HotFont => null;

	internal ListView Owner
	{
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListViewItem" /> class with default values.</summary>
	public ListViewItem()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListViewItem" /> class with the specified item text.</summary>
	/// <param name="text">The text to display for the item. This should not exceed 259 characters.</param>
	public ListViewItem(string text)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListViewItem" /> class with the specified item text and the image index position of the item's icon.</summary>
	/// <param name="text">The text to display for the item. This should not exceed 259 characters.</param>
	/// <param name="imageIndex">The zero-based index of the image within the <see cref="T:System.Windows.Forms.ImageList" /> associated with the <see cref="T:System.Windows.Forms.ListView" /> that contains the item.</param>
	public ListViewItem(string text, int imageIndex)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListViewItem" /> class with the specified serialization information and streaming context.</summary>
	/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> containing information about the <see cref="T:System.Windows.Forms.ListViewItem" /> to be initialized.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that indicates the source destination and context information of a serialized stream.</param>
	protected ListViewItem(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Serializes the item.</summary>
	/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the data needed to serialize the item.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that represents the source and destination of the stream being serialized.</param>
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal void OnUIATextChanged()
	{
	}

	internal void OnUIASubItemTextChanged(LabelEditEventArgs args)
	{
	}

	/// <summary>Creates an identical copy of the item.</summary>
	/// <returns>An object that represents an item that has the same text, image, and subitems associated with it as the cloned item.</returns>
	public virtual object Clone()
	{
		return null;
	}

	/// <summary>Ensures that the item is visible within the control, scrolling the contents of the control, if necessary.</summary>
	public virtual void EnsureVisible()
	{
	}

	/// <summary>Retrieves the specified portion of the bounding rectangle for the item.</summary>
	/// <param name="portion">One of the <see cref="T:System.Windows.Forms.ItemBoundsPortion" /> values that represents a portion of the item for which to retrieve the bounding rectangle.</param>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that represents the bounding rectangle for the specified portion of the item.</returns>
	public Rectangle GetBounds(ItemBoundsPortion portion)
	{
		return default(Rectangle);
	}

	/// <summary>Returns a string that represents the current object.</summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Deserializes the item.</summary>
	/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the data needed to deserialize the item.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that represents the source and destination of the stream being deserialized.</param>
	protected virtual void Deserialize(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Serializes the item.</summary>
	/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the data needed to serialize the item.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that represents the source and destination of the stream being serialized.</param>
	protected virtual void Serialize(SerializationInfo info, StreamingContext context)
	{
	}

	internal void SetGroup(ListViewGroup group)
	{
	}

	internal void SetPosition(Point position)
	{
	}

	private void UpdateFocusedState()
	{
	}

	internal void Invalidate()
	{
	}

	internal void Layout()
	{
	}
}
