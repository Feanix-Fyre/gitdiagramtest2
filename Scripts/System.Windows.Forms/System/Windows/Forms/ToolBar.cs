using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Represents a Windows toolbar. Although <see cref="T:System.Windows.Forms.ToolStrip" /> replaces and adds functionality to the <see cref="T:System.Windows.Forms.ToolBar" /> control of previous versions, <see cref="T:System.Windows.Forms.ToolBar" /> is retained for both backward compatibility and future use if you choose.</summary>
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
[DefaultEvent("ButtonClick")]
[DefaultProperty("Buttons")]
[Designer("System.Windows.Forms.Design.ToolBarDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
public class ToolBar : Control
{
	/// <summary>Encapsulates a collection of <see cref="T:System.Windows.Forms.ToolBarButton" /> controls for use by the <see cref="T:System.Windows.Forms.ToolBar" /> class.</summary>
	public class ToolBarButtonCollection : ICollection, IEnumerable, IList
	{
		private ArrayList list;

		private ToolBar owner;

		private bool redraw;

		private static object UIACollectionChangedEvent;

		/// <summary>Gets a value indicating whether access to the collection is synchronized (thread safe).</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the collection of buttons.</summary>
		object ICollection.SyncRoot => null;

		/// <summary>Gets a value indicating whether the collection has a fixed size.</summary>
		/// <returns>
		///   <see langword="false" /> in all cases.</returns>
		bool IList.IsFixedSize => false;

		/// <summary>Gets or sets the item at a specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>The element at the specified index.</returns>
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

		/// <summary>Gets the number of buttons in the toolbar button collection.</summary>
		/// <returns>The number of the <see cref="T:System.Windows.Forms.ToolBarButton" /> controls assigned to the toolbar.</returns>
		[Browsable(false)]
		public int Count => 0;

		/// <summary>Gets a value indicating whether the collection is read-only.</summary>
		/// <returns>
		///   <see langword="true" /> if the collection is read-only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		public bool IsReadOnly => false;

		/// <summary>Gets or sets the toolbar button at the specified indexed location in the toolbar button collection.</summary>
		/// <param name="index">The indexed location of the <see cref="T:System.Windows.Forms.ToolBarButton" /> in the collection.</param>
		/// <returns>A <see cref="T:System.Windows.Forms.ToolBarButton" /> that represents the toolbar button at the specified indexed location.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="index" /> value is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> value is less than zero.  
		///  -or-  
		///  The <paramref name="index" /> value is greater than the number of buttons in the collection, and the collection of buttons is not <see langword="null" />.</exception>
		public virtual ToolBarButton this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolBar.ToolBarButtonCollection" /> class and assigns it to the specified toolbar.</summary>
		/// <param name="owner">The <see cref="T:System.Windows.Forms.ToolBar" /> that is the parent of the collection of <see cref="T:System.Windows.Forms.ToolBarButton" /> controls.</param>
		public ToolBarButtonCollection(ToolBar owner)
		{
		}

		/// <summary>Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
		/// <param name="dest">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ICollection" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="dest" /> at which copying begins.</param>
		void ICollection.CopyTo(Array dest, int index)
		{
		}

		/// <summary>Adds the specified toolbar button to the end of the toolbar button collection.</summary>
		/// <param name="button">The <see cref="T:System.Windows.Forms.ToolBarButton" /> to be added after all existing buttons.</param>
		/// <returns>The zero-based index value of the <see cref="T:System.Windows.Forms.ToolBarButton" /> added to the collection.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="button" /> is not a <see cref="T:System.Windows.Forms.ToolBarButton" />.</exception>
		int IList.Add(object button)
		{
			return 0;
		}

		/// <summary>Determines whether the collection contains a specific value.</summary>
		/// <param name="button">The item to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the item is found in the collection; otherwise, <see langword="false" />.</returns>
		bool IList.Contains(object button)
		{
			return false;
		}

		/// <summary>Determines the index of a specific item in the collection.</summary>
		/// <param name="button">The item to locate in the collection.</param>
		/// <returns>The index of <paramref name="button" /> if found in the list; otherwise, -1.</returns>
		int IList.IndexOf(object button)
		{
			return 0;
		}

		/// <summary>Inserts an existing toolbar button in the toolbar button collection at the specified location.</summary>
		/// <param name="index">The indexed location within the collection to insert the toolbar button.</param>
		/// <param name="button">The <see cref="T:System.Windows.Forms.ToolBarButton" /> to insert.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="button" /> is not a <see cref="T:System.Windows.Forms.ToolBarButton" />.</exception>
		void IList.Insert(int index, object button)
		{
		}

		/// <summary>Removes the first occurrence of an item from the collection.</summary>
		/// <param name="button">The <see cref="T:System.Object" /> to remove from the <see cref="T:System.Collections.IList" />.</param>
		void IList.Remove(object button)
		{
		}

		internal void OnUIACollectionChanged(CollectionChangeEventArgs e)
		{
		}

		/// <summary>Adds the specified toolbar button to the end of the toolbar button collection.</summary>
		/// <param name="button">The <see cref="T:System.Windows.Forms.ToolBarButton" /> to be added after all existing buttons.</param>
		/// <returns>The zero-based index value of the <see cref="T:System.Windows.Forms.ToolBarButton" /> added to the collection.</returns>
		public int Add(ToolBarButton button)
		{
			return 0;
		}

		/// <summary>Adds a collection of toolbar buttons to this toolbar button collection.</summary>
		/// <param name="buttons">The collection of <see cref="T:System.Windows.Forms.ToolBarButton" /> controls to add to this <see cref="T:System.Windows.Forms.ToolBar.ToolBarButtonCollection" /> contained in an array.</param>
		public void AddRange(ToolBarButton[] buttons)
		{
		}

		/// <summary>Removes all buttons from the toolbar button collection.</summary>
		public void Clear()
		{
		}

		/// <summary>Determines if the specified toolbar button is a member of the collection.</summary>
		/// <param name="button">The <see cref="T:System.Windows.Forms.ToolBarButton" /> to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolBarButton" /> is a member of the collection; otherwise, <see langword="false" />.</returns>
		public bool Contains(ToolBarButton button)
		{
			return false;
		}

		/// <summary>Returns an enumerator that can be used to iterate through the toolbar button collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that represents the tree node collection.</returns>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>Retrieves the index of the specified toolbar button in the collection.</summary>
		/// <param name="button">The <see cref="T:System.Windows.Forms.ToolBarButton" /> to locate in the collection.</param>
		/// <returns>The zero-based index of the item found in the collection; otherwise, -1.</returns>
		public int IndexOf(ToolBarButton button)
		{
			return 0;
		}

		/// <summary>Inserts an existing toolbar button in the toolbar button collection at the specified location.</summary>
		/// <param name="index">The indexed location within the collection to insert the toolbar button.</param>
		/// <param name="button">The <see cref="T:System.Windows.Forms.ToolBarButton" /> to insert.</param>
		public void Insert(int index, ToolBarButton button)
		{
		}

		/// <summary>Removes a given button from the toolbar button collection.</summary>
		/// <param name="button">The <see cref="T:System.Windows.Forms.ToolBarButton" /> to remove from the collection.</param>
		public void Remove(ToolBarButton button)
		{
		}

		/// <summary>Removes a given button from the toolbar button collection.</summary>
		/// <param name="index">The indexed location of the <see cref="T:System.Windows.Forms.ToolBarButton" /> in the collection.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> value is less than 0, or it is greater than the number of buttons in the collection.</exception>
		public void RemoveAt(int index)
		{
		}
	}

	private bool size_specified;

	private ToolBarItem current_item;

	internal ToolBarItem[] items;

	internal Size default_size;

	private static object ButtonDropDownEvent;

	private ToolBarAppearance appearance;

	private bool autosize;

	private ToolBarButtonCollection buttons;

	private Size button_size;

	private bool divider;

	private bool drop_down_arrows;

	private ImageList image_list;

	private ImeMode ime_mode;

	private bool show_tooltips;

	private ToolBarTextAlign text_alignment;

	private bool wrappable;

	private ToolBarButton button_for_focus;

	private int requested_size;

	private ToolTip tip_window;

	private Timer tipdown_timer;

	/// <summary>Gets the required creation parameters when the control handle is created.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.CreateParams" /> that contains the required creation parameters when the handle to the control is created.</returns>
	protected override CreateParams CreateParams => null;

	/// <summary>Gets the default size of the control.</summary>
	/// <returns>The default <see cref="T:System.Drawing.Size" /> of the control.</returns>
	protected override Size DefaultSize => default(Size);

	/// <summary>This member is not meaningful for this control.</summary>
	/// <returns>A <see cref="T:System.Boolean" /> value.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override bool DoubleBuffered => false;

	/// <summary>Gets or set the value that determines the appearance of a toolbar control and its buttons.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolBarAppearance" /> values. The default is <see langword="ToolBarAppearance.Normal" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The assigned value is not one of the <see cref="T:System.Windows.Forms.ToolBarAppearance" /> values.</exception>
	[DefaultValue(ToolBarAppearance.Normal)]
	[Localizable(true)]
	public ToolBarAppearance Appearance
	{
		get
		{
			return default(ToolBarAppearance);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the toolbar adjusts its size automatically, based on the size of the buttons and the dock style.</summary>
	/// <returns>
	///   <see langword="true" /> if the toolbar adjusts its size automatically, based on the size of the buttons and dock style; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[EditorBrowsable(EditorBrowsableState.Always)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
	[Localizable(true)]
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

	/// <summary>Gets or sets the background color.</summary>
	/// <returns>The background color.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
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

	/// <summary>Gets or sets the background image.</summary>
	/// <returns>The background image.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override Image BackgroundImage => null;

	/// <summary>Gets or sets the layout for background image.</summary>
	/// <returns>The layout for background image.</returns>
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

	/// <summary>Gets the collection of <see cref="T:System.Windows.Forms.ToolBarButton" /> controls assigned to the toolbar control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ToolBar.ToolBarButtonCollection" /> that contains a collection of <see cref="T:System.Windows.Forms.ToolBarButton" /> controls.</returns>
	[Localizable(true)]
	[MergableProperty(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ToolBarButtonCollection Buttons => null;

	/// <summary>Gets or sets the size of the buttons on the toolbar control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> object that represents the size of the <see cref="T:System.Windows.Forms.ToolBarButton" /> controls on the toolbar. The default size has a width of 24 pixels and a height of 22 pixels, or large enough to accommodate the <see cref="T:System.Drawing.Image" /> and text, whichever is greater.</returns>
	/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Drawing.Size.Width" /> or <see cref="P:System.Drawing.Size.Height" /> property of the <see cref="T:System.Drawing.Size" /> object is less than 0.</exception>
	[RefreshProperties(RefreshProperties.All)]
	[Localizable(true)]
	public Size ButtonSize
	{
		get
		{
			return default(Size);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the toolbar displays a divider.</summary>
	/// <returns>
	///   <see langword="true" /> if the toolbar displays a divider; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool Divider
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets which control borders are docked to its parent control and determines how a control is resized with its parent.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.DockStyle" /> values. The default is <see cref="F:System.Windows.Forms.DockStyle.None" />.</returns>
	[DefaultValue(DockStyle.Top)]
	[Localizable(true)]
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

	/// <summary>Gets or sets a value indicating whether drop-down buttons on a toolbar display down arrows.</summary>
	/// <returns>
	///   <see langword="true" /> if drop-down toolbar buttons display down arrows; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	[Localizable(true)]
	public bool DropDownArrows
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the forecolor .</summary>
	/// <returns>The forecolor.</returns>
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

	/// <summary>Gets or sets the collection of images available to the toolbar button controls.</summary>
	/// <returns>An <see cref="T:System.Windows.Forms.ImageList" /> that contains images available to the <see cref="T:System.Windows.Forms.ToolBarButton" /> controls. The default is <see langword="null" />.</returns>
	[DefaultValue(null)]
	public ImageList ImageList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the size of the images in the image list assigned to the toolbar.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that represents the size of the images (in the <see cref="T:System.Windows.Forms.ImageList" />) assigned to the <see cref="T:System.Windows.Forms.ToolBar" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Browsable(false)]
	public Size ImageSize => default(Size);

	/// <summary>This member is not meaningful for this control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.RightToLeft" /> value.</returns>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override RightToLeft RightToLeft => default(RightToLeft);

	/// <summary>Gets or sets a value indicating whether the toolbar displays a ToolTip for each button.</summary>
	/// <returns>
	///   <see langword="true" /> if the toolbar display a ToolTip for each button; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[Localizable(true)]
	[DefaultValue(false)]
	public bool ShowToolTips
	{
		set
		{
		}
	}

	/// <summary>This property is not meaningful for this control.</summary>
	/// <returns>This property is not meaningful for this control.</returns>
	[DefaultValue(false)]
	public new bool TabStop
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the text for the toolbar.</summary>
	/// <returns>The text for the toolbar.</returns>
	[Bindable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
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

	/// <summary>Gets or sets the alignment of text in relation to each image displayed on the toolbar button controls.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ToolBarTextAlign" /> values. The default is <see langword="ToolBarTextAlign.Underneath" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The assigned value is not one of the <see cref="T:System.Windows.Forms.ToolBarTextAlign" /> values.</exception>
	[DefaultValue(ToolBarTextAlign.Underneath)]
	[Localizable(true)]
	public ToolBarTextAlign TextAlign
	{
		get
		{
			return default(ToolBarTextAlign);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the toolbar buttons wrap to the next line if the toolbar becomes too small to display all the buttons on the same line.</summary>
	/// <returns>
	///   <see langword="true" /> if the toolbar buttons wrap to another line if the toolbar becomes too small to display all the buttons on the same line; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
	[DefaultValue(true)]
	[Localizable(true)]
	public bool Wrappable => false;

	private Timer TipDownTimer => null;

	internal bool SizeSpecified => false;

	internal bool Vertical => false;

	private Size AdjustedButtonSize => default(Size);

	/// <summary>Occurs when the <see cref="P:System.Windows.Forms.ToolBar.BackgroundImage" /> property changes.</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public new event EventHandler BackgroundImageChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when a <see cref="T:System.Windows.Forms.ToolBarButton" /> on the <see cref="T:System.Windows.Forms.ToolBar" /> is clicked.</summary>
	public event ToolBarButtonClickEventHandler ButtonClick
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolBar" /> class.</summary>
	public ToolBar()
	{
	}

	/// <summary>Returns a string that represents the <see cref="T:System.Windows.Forms.ToolBar" /> control.</summary>
	/// <returns>A String that represents the current <see cref="T:System.Windows.Forms.ToolBar" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Creates a handle for the control.</summary>
	protected override void CreateHandle()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.ToolBar" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	private void PerformButtonClick(ToolBarButtonClickEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolBar.ButtonClick" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolBarButtonClickEventArgs" /> that contains the event data.</param>
	protected virtual void OnButtonClick(ToolBarButtonClickEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolBar.ButtonDropDown" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolBarButtonClickEventArgs" /> that contains the event data.</param>
	protected virtual void OnButtonDropDown(ToolBarButtonClickEventArgs e)
	{
	}

	internal void ShowDropDownMenu(ToolBarItem item)
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

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnResize(EventArgs e)
	{
	}

	/// <summary>Scales a control's location, size, padding and margin.</summary>
	/// <param name="factor">The factor by which the height and width of the control will be scaled.</param>
	/// <param name="specified">A <see cref="T:System.Windows.Forms.BoundsSpecified" /> value that specifies the bounds of the control to use when defining its size and position.</param>
	protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
	{
	}

	/// <summary>This method is not relevant for this class.</summary>
	/// <param name="dx">The horizontal scaling factor.</param>
	/// <param name="dy">The vertical scaling factor.</param>
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override void ScaleCore(float dx, float dy)
	{
	}

	/// <summary>Sets the specified bounds of the <see cref="T:System.Windows.Forms.ToolBar" /> control.</summary>
	/// <param name="x">The new <see langword="Left" /> property value of the control.</param>
	/// <param name="y">The new <see langword="Top" /> property value of the control.</param>
	/// <param name="width">The new <see langword="Width" /> property value of the control.</param>
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

	internal override bool InternalPreProcessMessage(ref Message msg)
	{
		return false;
	}

	private void FocusChanged(object sender, EventArgs args)
	{
	}

	private bool HandleKeyDown(ref Message msg, Keys key_data)
	{
		return false;
	}

	private bool HandleKeyOnDropDown(ref Message msg, Keys key_data)
	{
		return false;
	}

	private void HighlightButton(int offset)
	{
	}

	private void ToolBar_BackgroundImageChanged(object sender, EventArgs args)
	{
	}

	private void ToolBar_MouseDown(object sender, MouseEventArgs me)
	{
	}

	private void ToolBar_MouseUp(object sender, MouseEventArgs me)
	{
	}

	private ToolBarItem ItemAtPoint(Point pt)
	{
		return null;
	}

	private void PopDownTip(object o, EventArgs args)
	{
	}

	private void ToolBar_MouseHover(object sender, EventArgs e)
	{
	}

	private void ToolBar_MouseLeave(object sender, EventArgs e)
	{
	}

	private void ToolBar_MouseMove(object sender, MouseEventArgs me)
	{
	}

	internal override void OnPaintInternal(PaintEventArgs pevent)
	{
	}

	internal void Redraw(bool recalculate)
	{
	}

	internal void Redraw(bool recalculate, bool force)
	{
	}

	private Size CalcButtonSize()
	{
		return default(Size);
	}

	private bool LayoutToolBar()
	{
		return false;
	}
}
