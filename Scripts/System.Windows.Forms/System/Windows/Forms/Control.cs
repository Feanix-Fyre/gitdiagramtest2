using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms.Layout;

namespace System.Windows.Forms;

/// <summary>Defines the base class for controls, which are components with visual representation.</summary>
[ComVisible(true)]
[DesignerSerializer("System.Windows.Forms.Design.ControlCodeDomSerializer, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ToolboxItemFilter("System.Windows.Forms")]
[Designer("System.Windows.Forms.Design.ControlDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[DefaultEvent("Click")]
[DefaultProperty("Text")]
public class Control : Component, IDisposable, IComponent, ISynchronizeInvoke, IBindableComponent, IWin32Window
{
	internal enum LayoutType
	{
		Anchor = 0,
		Dock = 1
	}

	internal class ControlNativeWindow : NativeWindow
	{
		private Control owner;

		public ControlNativeWindow(Control control)
		{
		}

		protected override void OnHandleChange()
		{
		}

		internal static Control ControlFromHandle(IntPtr hWnd)
		{
			return null;
		}

		protected override void WndProc(ref Message m)
		{
		}
	}

	private class ControlWindowTarget : IWindowTarget
	{
		private Control control;

		public ControlWindowTarget(Control control)
		{
		}

		public void OnHandleChange(IntPtr newHandle)
		{
		}

		public void OnMessage(ref Message m)
		{
		}
	}

	private class DoubleBuffer : IDisposable
	{
		public Region InvalidRegion;

		private Stack real_graphics;

		private object back_buffer;

		private Control parent;

		private bool pending_disposal;

		public DoubleBuffer(Control parent)
		{
		}

		void IDisposable.Dispose()
		{
		}

		public void Start(PaintEventArgs pe)
		{
		}

		public void End(PaintEventArgs pe)
		{
		}

		public void Invalidate()
		{
		}

		public void Dispose()
		{
		}

		~DoubleBuffer()
		{
		}
	}

	/// <summary>Represents a collection of <see cref="T:System.Windows.Forms.Control" /> objects.</summary>
	[ListBindable(false)]
	[ComVisible(false)]
	public class ControlCollection : ArrangedElementCollection, ICollection, IEnumerable, IList, ICloneable
	{
		internal class ControlCollectionEnumerator : IEnumerator
		{
			private ArrayList list;

			private int position;

			public object Current => null;

			public ControlCollectionEnumerator(ArrayList collection)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		private ArrayList impl_list;

		private Control[] all_controls;

		private Control owner;

		/// <summary>Indicates the <see cref="T:System.Windows.Forms.Control" /> at the specified indexed location in the collection.</summary>
		/// <param name="index">The index of the control to retrieve from the control collection.</param>
		/// <returns>The <see cref="T:System.Windows.Forms.Control" /> located at the specified index location within the control collection.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> value is less than zero or is greater than or equal to the number of controls in the collection.</exception>
		public new virtual Control this[int index] => null;

		internal ArrayList ImplicitControls => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Control.ControlCollection" /> class.</summary>
		/// <param name="owner">A <see cref="T:System.Windows.Forms.Control" /> representing the control that owns the control collection.</param>
		public ControlCollection(Control owner)
		{
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Add(System.Object)" />.</summary>
		/// <param name="control">The object to add to this collection.</param>
		/// <returns>The position into which the new element was inserted, or -1 to indicate that the item was not inserted into the collection.</returns>
		int IList.Add(object control)
		{
			return 0;
		}

		/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Remove(System.Object)" />.</summary>
		/// <param name="control" />
		void IList.Remove(object control)
		{
		}

		/// <summary>For a description of this member, see <see cref="M:System.ICloneable.Clone" />.</summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		object ICloneable.Clone()
		{
			return null;
		}

		/// <summary>Adds the specified control to the control collection.</summary>
		/// <param name="value">The <see cref="T:System.Windows.Forms.Control" /> to add to the control collection.</param>
		/// <exception cref="T:System.Exception">The specified control is a top-level control, or a circular control reference would result if this control were added to the control collection.</exception>
		/// <exception cref="T:System.ArgumentException">The object assigned to the <paramref name="value" /> parameter is not a <see cref="T:System.Windows.Forms.Control" />.</exception>
		public virtual void Add(Control value)
		{
		}

		internal void AddToList(Control c)
		{
		}

		internal virtual void AddImplicit(Control control)
		{
		}

		internal virtual void AddRangeImplicit(Control[] controls)
		{
		}

		public virtual void System_002ECollections_002EIList_002EClear()
		{
		}

		/// <summary>Determines whether the specified control is a member of the collection.</summary>
		/// <param name="control">The <see cref="T:System.Windows.Forms.Control" /> to locate in the collection.</param>
		/// <returns>
		///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.Control" /> is a member of the collection; otherwise, <see langword="false" />.</returns>
		public bool Contains(Control control)
		{
			return false;
		}

		internal bool ImplicitContains(Control value)
		{
			return false;
		}

		internal bool AllContains(Control value)
		{
			return false;
		}

		/// <summary>Retrieves a reference to an enumerator object that is used to iterate over a <see cref="T:System.Windows.Forms.Control.ControlCollection" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" />.</returns>
		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		internal Control[] GetAllControls()
		{
			return null;
		}

		/// <summary>Removes the specified control from the control collection.</summary>
		/// <param name="value">The <see cref="T:System.Windows.Forms.Control" /> to remove from the <see cref="T:System.Windows.Forms.Control.ControlCollection" />.</param>
		public virtual void Remove(Control value)
		{
		}

		internal virtual void RemoveImplicit(Control control)
		{
		}

		public void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		/// <summary>Sets the index of the specified child control in the collection to the specified index value.</summary>
		/// <param name="child">The <paramref name="child" /><see cref="T:System.Windows.Forms.Control" /> to search for.</param>
		/// <param name="newIndex">The new index value of the control.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="child" /> control is not in the <see cref="T:System.Windows.Forms.Control.ControlCollection" />.</exception>
		public virtual void SetChildIndex(Control child, int newIndex)
		{
		}
	}

	internal Rectangle bounds;

	private Rectangle explicit_bounds;

	internal object creator_thread;

	internal ControlNativeWindow window;

	private IWindowTarget window_target;

	private string name;

	private bool is_created;

	internal bool has_focus;

	internal bool is_visible;

	internal bool is_entered;

	internal bool is_enabled;

	private bool is_captured;

	internal bool is_toplevel;

	private bool is_recreating;

	private bool causes_validation;

	private bool is_focusing;

	private int tab_index;

	private bool tab_stop;

	private bool is_disposed;

	private bool is_disposing;

	private Size client_size;

	private Rectangle client_rect;

	private ControlStyles control_style;

	private ImeMode ime_mode;

	internal int mouse_clicks;

	private Cursor cursor;

	internal bool allow_drop;

	private Region clip_region;

	internal Color foreground_color;

	internal Color background_color;

	private Image background_image;

	internal Font font;

	private string text;

	internal BorderStyle border_style;

	private bool show_keyboard_cues;

	internal bool show_focus_cues;

	internal bool force_double_buffer;

	private LayoutEngine layout_engine;

	internal int layout_suspended;

	private bool layout_pending;

	internal AnchorStyles anchor_style;

	internal DockStyle dock_style;

	private LayoutType layout_type;

	private bool recalculate_distances;

	internal int dist_right;

	internal int dist_bottom;

	private ControlCollection child_controls;

	private Control parent;

	private BindingContext binding_context;

	private RightToLeft right_to_left;

	private ContextMenu context_menu;

	internal bool use_compatible_text_rendering;

	private bool use_wait_cursor;

	private AccessibleRole accessible_role;

	private DoubleBuffer backbuffer;

	private ControlBindingsCollection data_bindings;

	private static bool verify_thread_handle;

	private Padding padding;

	private ImageLayout backgroundimage_layout;

	private Size maximum_size;

	private Size minimum_size;

	private Padding margin;

	private ContextMenuStrip context_menu_strip;

	private bool nested_layout;

	private AutoSizeMode auto_size_mode;

	private bool suppressing_key_press;

	private MenuTracker active_tracker;

	private bool auto_size;

	private static object AutoSizeChangedEvent;

	private static object BackColorChangedEvent;

	private static object BackgroundImageLayoutChangedEvent;

	private static object BindingContextChangedEvent;

	private static object CausesValidationChangedEvent;

	private static object ChangeUICuesEvent;

	private static object ClientSizeChangedEvent;

	private static object ContextMenuChangedEvent;

	private static object ContextMenuStripChangedEvent;

	private static object ControlAddedEvent;

	private static object CursorChangedEvent;

	private static object DockChangedEvent;

	private static object DragDropEvent;

	private static object DragEnterEvent;

	private static object DragLeaveEvent;

	private static object DragOverEvent;

	private static object EnterEvent;

	private static object GiveFeedbackEvent;

	private static object HelpRequestedEvent;

	private static object ImeModeChangedEvent;

	private static object KeyUpEvent;

	private static object LayoutEvent;

	private static object LeaveEvent;

	private static object MarginChangedEvent;

	private static object MouseClickEvent;

	private static object MouseDoubleClickEvent;

	private static object MoveEvent;

	private static object PreviewKeyDownEvent;

	private static object QueryAccessibilityHelpEvent;

	private static object QueryContinueDragEvent;

	private static object RegionChangedEvent;

	private static object StyleChangedEvent;

	private static object SystemColorsChangedEvent;

	private static object TabIndexChangedEvent;

	private static object TabStopChangedEvent;

	private static object ValidatedEvent;

	internal Rectangle PaddingClientRectangle => default(Rectangle);

	internal MenuTracker ActiveTracker
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool InternalSelected => false;

	internal bool InternalContainsFocus => false;

	internal bool Entered => false;

	internal bool VisibleInternal => false;

	internal LayoutType ControlLayoutType => default(LayoutType);

	internal BorderStyle InternalBorderStyle
	{
		get
		{
			return default(BorderStyle);
		}
		set
		{
		}
	}

	internal Size InternalClientSize
	{
		set
		{
		}
	}

	internal virtual bool ActivateOnShow => false;

	internal Rectangle ExplicitBounds
	{
		get
		{
			return default(Rectangle);
		}
		set
		{
		}
	}

	internal bool ValidationFailed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool IsRecreating => false;

	internal Graphics DeviceContext => null;

	private bool UseDoubleBuffering => false;

	/// <summary>Gets the default background color of the control.</summary>
	/// <returns>The default background <see cref="T:System.Drawing.Color" /> of the control. The default is <see cref="P:System.Drawing.SystemColors.Control" />.</returns>
	public static Color DefaultBackColor => default(Color);

	/// <summary>Gets the default font of the control.</summary>
	/// <returns>The default <see cref="T:System.Drawing.Font" /> of the control. The value returned will vary depending on the user's operating system the local culture setting of their system.</returns>
	/// <exception cref="T:System.ArgumentException">The default font or the regional alternative fonts are not installed on the client computer.</exception>
	public static Font DefaultFont => null;

	/// <summary>Gets the default foreground color of the control.</summary>
	/// <returns>The default foreground <see cref="T:System.Drawing.Color" /> of the control. The default is <see cref="P:System.Drawing.SystemColors.ControlText" />.</returns>
	public static Color DefaultForeColor => default(Color);

	/// <summary>Gets a value indicating which of the modifier keys (SHIFT, CTRL, and ALT) is in a pressed state.</summary>
	/// <returns>A bitwise combination of the <see cref="T:System.Windows.Forms.Keys" /> values. The default is <see cref="F:System.Windows.Forms.Keys.None" />.</returns>
	public static Keys ModifierKeys => default(Keys);

	/// <summary>Gets the position of the mouse cursor in screen coordinates.</summary>
	/// <returns>A <see cref="T:System.Drawing.Point" /> that contains the coordinates of the mouse cursor relative to the upper-left corner of the screen.</returns>
	public static Point MousePosition => default(Point);

	/// <summary>Gets or sets a value indicating whether the control can accept data that the user drags onto it.</summary>
	/// <returns>
	///   <see langword="true" /> if drag-and-drop operations are allowed in the control; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	[MWFCategory("Behavior")]
	public virtual bool AllowDrop => false;

	/// <summary>Gets or sets the edges of the container to which a control is bound and determines how a control is resized with its parent.</summary>
	/// <returns>A bitwise combination of the <see cref="T:System.Windows.Forms.AnchorStyles" /> values. The default is <see langword="Top" /> and <see langword="Left" />.</returns>
	[Localizable(true)]
	[MWFCategory("Layout")]
	[RefreshProperties(RefreshProperties.Repaint)]
	[DefaultValue(AnchorStyles.Top | AnchorStyles.Left)]
	public virtual AnchorStyles Anchor
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
	///   <see langword="true" /> if enabled; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DefaultValue(false)]
	[RefreshProperties(RefreshProperties.All)]
	[Localizable(true)]
	[Browsable(false)]
	public virtual bool AutoSize
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the size that is the upper limit that <see cref="M:System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)" /> can specify.</summary>
	/// <returns>An ordered pair of type <see cref="T:System.Drawing.Size" /> representing the width and height of a rectangle.</returns>
	[MWFCategory("Layout")]
	[AmbientValue("{Width=0, Height=0}")]
	public virtual Size MaximumSize => default(Size);

	/// <summary>Gets or sets the size that is the lower limit that <see cref="M:System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)" /> can specify.</summary>
	/// <returns>An ordered pair of type <see cref="T:System.Drawing.Size" /> representing the width and height of a rectangle.</returns>
	[MWFCategory("Layout")]
	public virtual Size MinimumSize
	{
		get
		{
			return default(Size);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the background color for the control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the background color of the control. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultBackColor" /> property.</returns>
	[DispId(-501)]
	[MWFCategory("Appearance")]
	public virtual Color BackColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the background image displayed in the control.</summary>
	/// <returns>An <see cref="T:System.Drawing.Image" /> that represents the image to display in the background of the control.</returns>
	[DefaultValue(null)]
	[Localizable(true)]
	[MWFCategory("Appearance")]
	public virtual Image BackgroundImage => null;

	/// <summary>Gets or sets the background image layout as defined in the <see cref="T:System.Windows.Forms.ImageLayout" /> enumeration.</summary>
	/// <returns>One of the values of <see cref="T:System.Windows.Forms.ImageLayout" /> (<see cref="F:System.Windows.Forms.ImageLayout.Center" /> , <see cref="F:System.Windows.Forms.ImageLayout.None" />, <see cref="F:System.Windows.Forms.ImageLayout.Stretch" />, <see cref="F:System.Windows.Forms.ImageLayout.Tile" />, or <see cref="F:System.Windows.Forms.ImageLayout.Zoom" />). <see cref="F:System.Windows.Forms.ImageLayout.Tile" /> is the default value.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The specified enumeration value does not exist.</exception>
	[DefaultValue(ImageLayout.Tile)]
	[Localizable(true)]
	[MWFCategory("Appearance")]
	public virtual ImageLayout BackgroundImageLayout
	{
		get
		{
			return default(ImageLayout);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Windows.Forms.BindingContext" /> for the control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.BindingContext" /> for the control.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual BindingContext BindingContext
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the distance, in pixels, between the bottom edge of the control and the top edge of its container's client area.</summary>
	/// <returns>An <see cref="T:System.Int32" /> representing the distance, in pixels, between the bottom edge of the control and the top edge of its container's client area.</returns>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int Bottom => 0;

	/// <summary>Gets or sets the size and location of the control including its nonclient elements, in pixels, relative to the parent control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> in pixels relative to the parent control that represents the size and location of the control including its nonclient elements.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Rectangle Bounds
	{
		get
		{
			return default(Rectangle);
		}
		set
		{
		}
	}

	/// <summary>Gets a value indicating whether the control can receive focus.</summary>
	/// <returns>
	///   <see langword="true" /> if the control can receive focus; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool CanFocus => false;

	/// <summary>Gets a value indicating whether the control can be selected.</summary>
	/// <returns>
	///   <see langword="true" /> if the control can be selected; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Browsable(false)]
	public bool CanSelect => false;

	internal virtual bool InternalCapture
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the control has captured the mouse.</summary>
	/// <returns>
	///   <see langword="true" /> if the control has captured the mouse; otherwise, <see langword="false" />.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool Capture
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the control causes validation to be performed on any controls that require validation when it receives focus.</summary>
	/// <returns>
	///   <see langword="true" /> if the control causes validation to be performed on any controls requiring validation when it receives focus; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[MWFCategory("Focus")]
	[DefaultValue(true)]
	public bool CausesValidation
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets the rectangle that represents the client area of the control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that represents the client area of the control.</returns>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Rectangle ClientRectangle => default(Rectangle);

	/// <summary>Gets or sets the height and width of the client area of the control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that represents the dimensions of the client area of the control.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Browsable(false)]
	public Size ClientSize
	{
		get
		{
			return default(Size);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the shortcut menu associated with the control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ContextMenu" /> that represents the shortcut menu associated with the control.</returns>
	[DefaultValue(null)]
	[MWFCategory("Behavior")]
	[Browsable(false)]
	public virtual ContextMenu ContextMenu
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal virtual ContextMenu ContextMenuInternal
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the collection of controls contained within the control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Control.ControlCollection" /> representing the collection of controls contained within the control.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ControlCollection Controls => null;

	/// <summary>Gets a value indicating whether the control has been created.</summary>
	/// <returns>
	///   <see langword="true" /> if the control has been created; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public bool Created => false;

	/// <summary>Gets or sets the cursor that is displayed when the mouse pointer is over the control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Cursor" /> that represents the cursor to display when the mouse pointer is over the control.</returns>
	[AmbientValue(null)]
	[MWFCategory("Appearance")]
	public virtual Cursor Cursor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the rectangle that represents the display area of the control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that represents the display area of the control.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public virtual Rectangle DisplayRectangle => default(Rectangle);

	/// <summary>Gets or sets which control borders are docked to its parent control and determines how a control is resized with its parent.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.DockStyle" /> values. The default is <see cref="F:System.Windows.Forms.DockStyle.None" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Windows.Forms.DockStyle" /> values.</exception>
	[DefaultValue(DockStyle.None)]
	[MWFCategory("Layout")]
	[Localizable(true)]
	[RefreshProperties(RefreshProperties.Repaint)]
	public virtual DockStyle Dock
	{
		get
		{
			return default(DockStyle);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether this control should redraw its surface using a secondary buffer to reduce or prevent flicker.</summary>
	/// <returns>
	///   <see langword="true" /> if the surface of the control should be drawn using double buffering; otherwise, <see langword="false" />.</returns>
	protected virtual bool DoubleBuffered => false;

	/// <summary>Gets or sets a value indicating whether the control can respond to user interaction.</summary>
	/// <returns>
	///   <see langword="true" /> if the control can respond to user interaction; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[Localizable(true)]
	[MWFCategory("Behavior")]
	[DispId(-514)]
	public bool Enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets a value indicating whether the control has input focus.</summary>
	/// <returns>
	///   <see langword="true" /> if the control has focus; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public virtual bool Focused => false;

	/// <summary>Gets or sets the font of the text displayed by the control.</summary>
	/// <returns>The <see cref="T:System.Drawing.Font" /> to apply to the text displayed by the control. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultFont" /> property.</returns>
	[MWFCategory("Appearance")]
	[AmbientValue(null)]
	[DispId(-512)]
	[Localizable(true)]
	public virtual Font Font
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the foreground color of the control.</summary>
	/// <returns>The foreground <see cref="T:System.Drawing.Color" /> of the control. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultForeColor" /> property.</returns>
	[DispId(-513)]
	[MWFCategory("Appearance")]
	public virtual Color ForeColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	/// <summary>Gets the window handle that the control is bound to.</summary>
	/// <returns>An <see cref="T:System.IntPtr" /> that contains the window handle (<see langword="HWND" />) of the control.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(-515)]
	public IntPtr Handle => (IntPtr)0;

	/// <summary>Gets or sets the height of the control.</summary>
	/// <returns>The height of the control in pixels.</returns>
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

	/// <summary>Gets or sets the Input Method Editor (IME) mode of the control.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ImeMode" /> values. The default is <see cref="F:System.Windows.Forms.ImeMode.Inherit" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The assigned value is not one of the <see cref="T:System.Windows.Forms.ImeMode" /> enumeration values.</exception>
	[AmbientValue(ImeMode.Inherit)]
	[MWFCategory("Behavior")]
	[Localizable(true)]
	public ImeMode ImeMode
	{
		set
		{
		}
	}

	/// <summary>Gets a value indicating whether the caller must call an invoke method when making method calls to the control because the caller is on a different thread than the one the control was created on.</summary>
	/// <returns>
	///   <see langword="true" /> if the control's <see cref="P:System.Windows.Forms.Control.Handle" /> was created on a different thread than the calling thread (indicating that you must make calls to the control through an invoke method); otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Browsable(false)]
	public bool InvokeRequired => false;

	/// <summary>Gets a value indicating whether the control has been disposed of.</summary>
	/// <returns>
	///   <see langword="true" /> if the control has been disposed of; otherwise, <see langword="false" />.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool IsDisposed => false;

	/// <summary>Gets a value indicating whether the control has a handle associated with it.</summary>
	/// <returns>
	///   <see langword="true" /> if a handle has been assigned to the control; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public bool IsHandleCreated => false;

	/// <summary>Gets a cached instance of the control's layout engine.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.Layout.LayoutEngine" /> for the control's contents.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Browsable(false)]
	public virtual LayoutEngine LayoutEngine => null;

	/// <summary>Gets or sets the distance, in pixels, between the left edge of the control and the left edge of its container's client area.</summary>
	/// <returns>An <see cref="T:System.Int32" /> representing the distance, in pixels, between the left edge of the control and the left edge of its container's client area.</returns>
	[EditorBrowsable(EditorBrowsableState.Always)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public int Left
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the coordinates of the upper-left corner of the control relative to the upper-left corner of its container.</summary>
	/// <returns>The <see cref="T:System.Drawing.Point" /> that represents the upper-left corner of the control relative to the upper-left corner of its container.</returns>
	[MWFCategory("Layout")]
	[Localizable(true)]
	public Point Location
	{
		get
		{
			return default(Point);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the space between controls.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Padding" /> representing the space between controls.</returns>
	[MWFCategory("Layout")]
	[Localizable(true)]
	public Padding Margin => default(Padding);

	/// <summary>Gets or sets the name of the control.</summary>
	/// <returns>The name of the control. The default is an empty string ("").</returns>
	[Browsable(false)]
	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets padding within the control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Padding" /> representing the control's internal spacing characteristics.</returns>
	[Localizable(true)]
	[MWFCategory("Layout")]
	public Padding Padding
	{
		get
		{
			return default(Padding);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the parent container of the control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Control" /> that represents the parent or container control of the control.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Control Parent => null;

	/// <summary>Gets the size of a rectangular area into which the control can fit.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> containing the height and width, in pixels.</returns>
	[Browsable(false)]
	public Size PreferredSize => default(Size);

	/// <summary>Gets a value indicating whether the control is currently re-creating its handle.</summary>
	/// <returns>
	///   <see langword="true" /> if the control is currently re-creating its handle; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public bool RecreatingHandle => false;

	/// <summary>Gets or sets the window region associated with the control.</summary>
	/// <returns>The window <see cref="T:System.Drawing.Region" /> associated with the control.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public Region Region
	{
		set
		{
		}
	}

	/// <summary>Gets the distance, in pixels, between the right edge of the control and the left edge of its container's client area.</summary>
	/// <returns>An <see cref="T:System.Int32" /> representing the distance, in pixels, between the right edge of the control and the left edge of its container's client area.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public int Right => 0;

	/// <summary>Gets or sets a value indicating whether control's elements are aligned to support locales using right-to-left fonts.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.RightToLeft" /> values. The default is <see cref="F:System.Windows.Forms.RightToLeft.Inherit" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The assigned value is not one of the <see cref="T:System.Windows.Forms.RightToLeft" /> values.</exception>
	[AmbientValue(RightToLeft.Inherit)]
	[MWFCategory("Appearance")]
	[Localizable(true)]
	public virtual RightToLeft RightToLeft => default(RightToLeft);

	/// <summary>Gets or sets the site of the control.</summary>
	/// <returns>The <see cref="T:System.ComponentModel.ISite" /> associated with the <see cref="T:System.Windows.Forms.Control" />, if any.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public override ISite Site
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the height and width of the control.</summary>
	/// <returns>The <see cref="T:System.Drawing.Size" /> that represents the height and width of the control in pixels.</returns>
	[Localizable(true)]
	[MWFCategory("Layout")]
	public Size Size
	{
		get
		{
			return default(Size);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the tab order of the control within its container.</summary>
	/// <returns>The index value of the control within the set of controls within its container. The controls in the container are included in the tab order.</returns>
	[Localizable(true)]
	[MergableProperty(false)]
	[MWFCategory("Behavior")]
	public int TabIndex
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the user can give the focus to this control using the TAB key.</summary>
	/// <returns>
	///   <see langword="true" /> if the user can give the focus to the control using the TAB key; otherwise, <see langword="false" />. The default is <see langword="true" />.  
	///
	///  This property will always return <see langword="true" /> for an instance of the <see cref="T:System.Windows.Forms.Form" /> class.</returns>
	[DispId(-516)]
	[MWFCategory("Behavior")]
	[DefaultValue(true)]
	public bool TabStop
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
	[MWFCategory("Appearance")]
	[DispId(-517)]
	[Bindable(true)]
	[Localizable(true)]
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

	/// <summary>Gets or sets the distance, in pixels, between the top edge of the control and the top edge of its container's client area.</summary>
	/// <returns>An <see cref="T:System.Int32" /> representing the distance, in pixels, between the bottom edge of the control and the top edge of its container's client area.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public int Top
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets the parent control that is not parented by another Windows Forms control. Typically, this is the outermost <see cref="T:System.Windows.Forms.Form" /> that the control is contained in.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.Control" /> that represents the top-level control that contains the current control.</returns>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Control TopLevelControl => null;

	/// <summary>Gets or sets a value indicating whether the control and all its child controls are displayed.</summary>
	/// <returns>
	///   <see langword="true" /> if the control and all its child controls are displayed; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[Localizable(true)]
	[MWFCategory("Behavior")]
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

	/// <summary>Gets or sets the width of the control.</summary>
	/// <returns>The width of the control in pixels.</returns>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

	/// <summary>This property is not relevant for this class.</summary>
	/// <returns>The NativeWindow contained within the control.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public IWindowTarget WindowTarget => null;

	/// <summary>Determines if events can be raised on the control.</summary>
	/// <returns>
	///   <see langword="true" /> if the control is hosted as an ActiveX control whose events are not frozen; otherwise, <see langword="false" />.</returns>
	protected override bool CanRaiseEvents => false;

	/// <summary>Gets the required creation parameters when the control handle is created.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.CreateParams" /> that contains the required creation parameters when the handle to the control is created.</returns>
	protected virtual CreateParams CreateParams => null;

	/// <summary>Gets or sets the default cursor for the control.</summary>
	/// <returns>An object of type <see cref="T:System.Windows.Forms.Cursor" /> representing the current default cursor.</returns>
	protected virtual Cursor DefaultCursor => null;

	/// <summary>Gets the space, in pixels, that is specified by default between controls.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Padding" /> that represents the default space between controls.</returns>
	protected virtual Padding DefaultMargin => default(Padding);

	/// <summary>Gets the internal spacing, in pixels, of the contents of a control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Padding" /> that represents the internal spacing of the contents of a control.</returns>
	protected virtual Padding DefaultPadding => default(Padding);

	/// <summary>Gets the default size of the control.</summary>
	/// <returns>The default <see cref="T:System.Drawing.Size" /> of the control.</returns>
	protected virtual Size DefaultSize => default(Size);

	/// <summary>Gets or sets the height of the font of the control.</summary>
	/// <returns>The height of the <see cref="T:System.Drawing.Font" /> of the control in pixels.</returns>
	protected int FontHeight => 0;

	/// <summary>Gets a value that determines the scaling of child controls.</summary>
	/// <returns>
	///   <see langword="true" /> if child controls will be scaled when the <see cref="M:System.Windows.Forms.Control.Scale(System.Single)" /> method on this control is called; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual bool ScaleChildren => false;

	internal virtual bool ScaleChildrenInternal => false;

	/// <summary>Gets a value indicating whether the control should display focus rectangles.</summary>
	/// <returns>
	///   <see langword="true" /> if the control should display focus rectangles; otherwise, <see langword="false" />.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	protected internal virtual bool ShowFocusCues => false;

	internal bool ShowKeyboardCuesInternal => false;

	/// <summary>Occurs when the value of the <see cref="P:System.Windows.Forms.Control.BackgroundImage" /> property changes.</summary>
	public event EventHandler BackgroundImageChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the control is clicked.</summary>
	public event EventHandler Click
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when a control is removed from the <see cref="T:System.Windows.Forms.Control.ControlCollection" />.</summary>
	[Browsable(true)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public event ControlEventHandler ControlRemoved
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the control is double-clicked.</summary>
	public event EventHandler DoubleClick
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the <see cref="P:System.Windows.Forms.Control.Enabled" /> property value has changed.</summary>
	public event EventHandler EnabledChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the <see cref="P:System.Windows.Forms.Control.Font" /> property value changes.</summary>
	public event EventHandler FontChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the <see cref="P:System.Windows.Forms.Control.ForeColor" /> property value changes.</summary>
	public event EventHandler ForeColorChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the control receives focus.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Browsable(false)]
	public event EventHandler GotFocus
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when a handle is created for the control.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Browsable(false)]
	public event EventHandler HandleCreated
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the control's handle is in the process of being destroyed.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Browsable(false)]
	public event EventHandler HandleDestroyed
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when a control's display requires redrawing.</summary>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public event InvalidateEventHandler Invalidated
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when a key is pressed while the control has focus.</summary>
	public event KeyEventHandler KeyDown
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when a character. space or backspace key is pressed while the control has focus.</summary>
	public event KeyPressEventHandler KeyPress
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the <see cref="P:System.Windows.Forms.Control.Location" /> property value has changed.</summary>
	public event EventHandler LocationChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the control loses focus.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Browsable(false)]
	public event EventHandler LostFocus
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the control loses mouse capture.</summary>
	public event EventHandler MouseCaptureChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the mouse pointer is over the control and a mouse button is pressed.</summary>
	public event MouseEventHandler MouseDown
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the mouse pointer enters the control.</summary>
	public event EventHandler MouseEnter
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the mouse pointer rests on the control.</summary>
	public event EventHandler MouseHover
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the mouse pointer leaves the control.</summary>
	public event EventHandler MouseLeave
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the mouse pointer is moved over the control.</summary>
	public event MouseEventHandler MouseMove
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the mouse pointer is over the control and a mouse button is released.</summary>
	public event MouseEventHandler MouseUp
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the mouse wheel moves while the control has focus.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Browsable(false)]
	public event MouseEventHandler MouseWheel
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the control's padding changes.</summary>
	public event EventHandler PaddingChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the control is redrawn.</summary>
	public event PaintEventHandler Paint
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the <see cref="P:System.Windows.Forms.Control.Parent" /> property value changes.</summary>
	public event EventHandler ParentChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the control is resized.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public event EventHandler Resize
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the <see cref="P:System.Windows.Forms.Control.RightToLeft" /> property value changes.</summary>
	public event EventHandler RightToLeftChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the <see cref="P:System.Windows.Forms.Control.Size" /> property value changes.</summary>
	public event EventHandler SizeChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the <see cref="P:System.Windows.Forms.Control.Text" /> property value changes.</summary>
	public event EventHandler TextChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the control is validating.</summary>
	public event CancelEventHandler Validating
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Occurs when the <see cref="P:System.Windows.Forms.Control.Visible" /> property value changes.</summary>
	public event EventHandler VisibleChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Control" /> class with default settings.</summary>
	public Control()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.Control" /> and its child controls and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	internal IAsyncResult BeginInvokeInternal(Delegate method, object[] args)
	{
		return null;
	}

	internal IAsyncResult BeginInvokeInternal(Delegate method, object[] args, Control control)
	{
		return null;
	}

	private IntPtr GetInvokableHandle()
	{
		return (IntPtr)0;
	}

	internal void PointToClient(ref int x, ref int y)
	{
	}

	internal virtual int OverrideHeight(int height)
	{
		return 0;
	}

	private void ProcessActiveTracker(ref Message m)
	{
	}

	private Control FindControlToInvokeOn()
	{
		return null;
	}

	private void InvalidateBackBuffer()
	{
	}

	private DoubleBuffer GetBackBuffer()
	{
		return null;
	}

	private void DisposeBackBuffer()
	{
	}

	internal static void SetChildColor(Control parent)
	{
	}

	internal bool Select(Control control)
	{
		return false;
	}

	internal static IntPtr MakeParam(int low, int high)
	{
		return (IntPtr)0;
	}

	internal static int LowOrder(int param)
	{
		return 0;
	}

	internal static int HighOrder(long param)
	{
		return 0;
	}

	internal virtual void PaintControlBackground(PaintEventArgs pevent)
	{
	}

	private void DrawBackgroundImage(Graphics g)
	{
	}

	internal virtual void DndEnter(DragEventArgs e)
	{
	}

	internal virtual void DndOver(DragEventArgs e)
	{
	}

	internal virtual void DndDrop(DragEventArgs e)
	{
	}

	internal virtual void DndLeave(EventArgs e)
	{
	}

	internal virtual void DndFeedback(GiveFeedbackEventArgs e)
	{
	}

	internal virtual void DndContinueDrag(QueryContinueDragEventArgs e)
	{
	}

	internal static MouseButtons FromParamToMouseButtons(long param)
	{
		return default(MouseButtons);
	}

	internal virtual void FireEnter()
	{
	}

	internal virtual void FireLeave()
	{
	}

	internal virtual void FireValidating(CancelEventArgs ce)
	{
	}

	internal virtual void FireValidated()
	{
	}

	internal virtual bool ProcessControlMnemonic(char charCode)
	{
		return false;
	}

	private static Control FindFlatForward(Control container, Control start)
	{
		return null;
	}

	private static Control FindControlForward(Control container, Control start)
	{
		return null;
	}

	private static Control FindFlatBackward(Control container, Control start)
	{
		return null;
	}

	private static Control FindControlBackward(Control container, Control start)
	{
		return null;
	}

	internal virtual void HandleClick(int clicks, MouseEventArgs me)
	{
	}

	internal void CaptureWithConfine(Control ConfineWindow)
	{
	}

	private void CheckDataBindings()
	{
	}

	private void ChangeParent(Control new_parent)
	{
	}

	internal Size InternalSizeFromClientSize(Size clientSize)
	{
		return default(Size);
	}

	internal Size ClientSizeFromSize(Size size)
	{
		return default(Size);
	}

	internal CreateParams GetCreateParams()
	{
		return null;
	}

	internal virtual Size GetPreferredSizeCore(Size proposedSize)
	{
		return default(Size);
	}

	private void UpdateDistances()
	{
	}

	private Cursor GetAvailableCursor()
	{
		return null;
	}

	private void UpdateCursor()
	{
	}

	internal void OnSizeInitializedOrChanged()
	{
	}

	internal virtual void UpdateWindowText()
	{
	}

	/// <summary>Returns the control that is currently associated with the specified handle.</summary>
	/// <param name="handle">The window handle (<see langword="HWND" />) to search for.</param>
	/// <returns>A <see cref="T:System.Windows.Forms.Control" /> that represents the control associated with the specified handle; returns <see langword="null" /> if no control with the specified handle is found.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static Control FromHandle(IntPtr handle)
	{
		return null;
	}

	/// <summary>Determines if the specified character is the mnemonic character assigned to the control in the specified string.</summary>
	/// <param name="charCode">The character to test.</param>
	/// <param name="text">The string to search.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="charCode" /> character is the mnemonic character assigned to the control; otherwise, <see langword="false" />.</returns>
	public static bool IsMnemonic(char charCode, string text)
	{
		return false;
	}

	/// <summary>Executes the specified delegate asynchronously with the specified arguments, on the thread that the control's underlying handle was created on.</summary>
	/// <param name="method">A delegate to a method that takes parameters of the same number and type that are contained in the <paramref name="args" /> parameter.</param>
	/// <param name="args">An array of objects to pass as arguments to the given method. This can be <see langword="null" /> if no arguments are needed.</param>
	/// <returns>An <see cref="T:System.IAsyncResult" /> that represents the result of the <see cref="M:System.Windows.Forms.Control.BeginInvoke(System.Delegate)" /> operation.</returns>
	/// <exception cref="T:System.InvalidOperationException">No appropriate window handle can be found.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IAsyncResult BeginInvoke(Delegate method, params object[] args)
	{
		return null;
	}

	/// <summary>Brings the control to the front of the z-order.</summary>
	public void BringToFront()
	{
	}

	/// <summary>Retrieves a value indicating whether the specified control is a child of the control.</summary>
	/// <param name="ctl">The <see cref="T:System.Windows.Forms.Control" /> to evaluate.</param>
	/// <returns>
	///   <see langword="true" /> if the specified control is a child of the control; otherwise, <see langword="false" />.</returns>
	public bool Contains(Control ctl)
	{
		return false;
	}

	/// <summary>Forces the creation of the visible control, including the creation of the handle and any visible child controls.</summary>
	public void CreateControl()
	{
	}

	/// <summary>Creates the <see cref="T:System.Drawing.Graphics" /> for the control.</summary>
	/// <returns>The <see cref="T:System.Drawing.Graphics" /> for the control.</returns>
	public Graphics CreateGraphics()
	{
		return null;
	}

	/// <summary>Retrieves the return value of the asynchronous operation represented by the <see cref="T:System.IAsyncResult" /> passed.</summary>
	/// <param name="asyncResult">The <see cref="T:System.IAsyncResult" /> that represents a specific invoke asynchronous operation, returned when calling <see cref="M:System.Windows.Forms.Control.BeginInvoke(System.Delegate)" />.</param>
	/// <returns>The <see cref="T:System.Object" /> generated by the asynchronous operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="asyncResult" /> parameter value is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="asyncResult" /> object was not created by a preceding call of the <see cref="M:System.Windows.Forms.Control.BeginInvoke(System.Delegate)" /> method from the same control.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public object EndInvoke(IAsyncResult asyncResult)
	{
		return null;
	}

	internal Control FindRootParent()
	{
		return null;
	}

	/// <summary>Retrieves the form that the control is on.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.Form" /> that the control is on.</returns>
	public Form FindForm()
	{
		return null;
	}

	/// <summary>Sets input focus to the control.</summary>
	/// <returns>
	///   <see langword="true" /> if the input focus request was successful; otherwise, <see langword="false" />.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public bool Focus()
	{
		return false;
	}

	internal virtual bool FocusInternal(bool skip_check)
	{
		return false;
	}

	internal Control GetRealChildAtPoint(Point pt)
	{
		return null;
	}

	/// <summary>Retrieves the child control that is located at the specified coordinates.</summary>
	/// <param name="pt">A <see cref="T:System.Drawing.Point" /> that contains the coordinates where you want to look for a control. Coordinates are expressed relative to the upper-left corner of the control's client area.</param>
	/// <returns>A <see cref="T:System.Windows.Forms.Control" /> that represents the control that is located at the specified point.</returns>
	public Control GetChildAtPoint(Point pt)
	{
		return null;
	}

	/// <summary>Retrieves the child control that is located at the specified coordinates, specifying whether to ignore child controls of a certain type.</summary>
	/// <param name="pt">A <see cref="T:System.Drawing.Point" /> that contains the coordinates where you want to look for a control. Coordinates are expressed relative to the upper-left corner of the control's client area.</param>
	/// <param name="skipValue">One of the values of <see cref="T:System.Windows.Forms.GetChildAtPointSkip" />, determining whether to ignore child controls of a certain type.</param>
	/// <returns>The child <see cref="T:System.Windows.Forms.Control" /> at the specified coordinates.</returns>
	public Control GetChildAtPoint(Point pt, GetChildAtPointSkip skipValue)
	{
		return null;
	}

	/// <summary>Returns the next <see cref="T:System.Windows.Forms.ContainerControl" /> up the control's chain of parent controls.</summary>
	/// <returns>An <see cref="T:System.Windows.Forms.IContainerControl" />, that represents the parent of the <see cref="T:System.Windows.Forms.Control" />.</returns>
	public IContainerControl GetContainerControl()
	{
		return null;
	}

	internal ContainerControl InternalGetContainerControl()
	{
		return null;
	}

	/// <summary>Retrieves the next control forward or back in the tab order of child controls.</summary>
	/// <param name="ctl">The <see cref="T:System.Windows.Forms.Control" /> to start the search with.</param>
	/// <param name="forward">
	///   <see langword="true" /> to search forward in the tab order; <see langword="false" /> to search backward.</param>
	/// <returns>The next <see cref="T:System.Windows.Forms.Control" /> in the tab order.</returns>
	public Control GetNextControl(Control ctl, bool forward)
	{
		return null;
	}

	/// <summary>Retrieves the size of a rectangular area into which a control can be fitted.</summary>
	/// <param name="proposedSize">The custom-sized area for a control.</param>
	/// <returns>An ordered pair of type <see cref="T:System.Drawing.Size" /> representing the width and height of a rectangle.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public virtual Size GetPreferredSize(Size proposedSize)
	{
		return default(Size);
	}

	/// <summary>Conceals the control from the user.</summary>
	public void Hide()
	{
	}

	/// <summary>Invalidates the entire surface of the control and causes the control to be redrawn.</summary>
	public void Invalidate()
	{
	}

	/// <summary>Invalidates a specific region of the control and causes a paint message to be sent to the control. Optionally, invalidates the child controls assigned to the control.</summary>
	/// <param name="invalidateChildren">
	///   <see langword="true" /> to invalidate the control's child controls; otherwise, <see langword="false" />.</param>
	public void Invalidate(bool invalidateChildren)
	{
	}

	/// <summary>Invalidates the specified region of the control (adds it to the control's update region, which is the area that will be repainted at the next paint operation), and causes a paint message to be sent to the control.</summary>
	/// <param name="rc">A <see cref="T:System.Drawing.Rectangle" /> that represents the region to invalidate.</param>
	public void Invalidate(Rectangle rc)
	{
	}

	/// <summary>Invalidates the specified region of the control (adds it to the control's update region, which is the area that will be repainted at the next paint operation), and causes a paint message to be sent to the control. Optionally, invalidates the child controls assigned to the control.</summary>
	/// <param name="rc">A <see cref="T:System.Drawing.Rectangle" /> that represents the region to invalidate.</param>
	/// <param name="invalidateChildren">
	///   <see langword="true" /> to invalidate the control's child controls; otherwise, <see langword="false" />.</param>
	public void Invalidate(Rectangle rc, bool invalidateChildren)
	{
	}

	/// <summary>Invalidates the specified region of the control (adds it to the control's update region, which is the area that will be repainted at the next paint operation), and causes a paint message to be sent to the control.</summary>
	/// <param name="region">The <see cref="T:System.Drawing.Region" /> to invalidate.</param>
	public void Invalidate(Region region)
	{
	}

	/// <summary>Invalidates the specified region of the control (adds it to the control's update region, which is the area that will be repainted at the next paint operation), and causes a paint message to be sent to the control. Optionally, invalidates the child controls assigned to the control.</summary>
	/// <param name="region">The <see cref="T:System.Drawing.Region" /> to invalidate.</param>
	/// <param name="invalidateChildren">
	///   <see langword="true" /> to invalidate the control's child controls; otherwise, <see langword="false" />.</param>
	public void Invalidate(Region region, bool invalidateChildren)
	{
	}

	/// <summary>Executes the specified delegate, on the thread that owns the control's underlying window handle, with the specified list of arguments.</summary>
	/// <param name="method">A delegate to a method that takes parameters of the same number and type that are contained in the <paramref name="args" /> parameter.</param>
	/// <param name="args">An array of objects to pass as arguments to the specified method. This parameter can be <see langword="null" /> if the method takes no arguments.</param>
	/// <returns>An <see cref="T:System.Object" /> that contains the return value from the delegate being invoked, or <see langword="null" /> if the delegate has no return value.</returns>
	public object Invoke(Delegate method, params object[] args)
	{
		return null;
	}

	/// <summary>Forces the control to apply layout logic to all its child controls.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void PerformLayout()
	{
	}

	/// <summary>Forces the control to apply layout logic to all its child controls.</summary>
	/// <param name="affectedControl">A <see cref="T:System.Windows.Forms.Control" /> that represents the most recently changed control.</param>
	/// <param name="affectedProperty">The name of the most recently changed property on the control.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void PerformLayout(Control affectedControl, string affectedProperty)
	{
	}

	/// <summary>Computes the location of the specified screen point into client coordinates.</summary>
	/// <param name="p">The screen coordinate <see cref="T:System.Drawing.Point" /> to convert.</param>
	/// <returns>A <see cref="T:System.Drawing.Point" /> that represents the converted <see cref="T:System.Drawing.Point" />, <paramref name="p" />, in client coordinates.</returns>
	public Point PointToClient(Point p)
	{
		return default(Point);
	}

	/// <summary>Computes the location of the specified client point into screen coordinates.</summary>
	/// <param name="p">The client coordinate <see cref="T:System.Drawing.Point" /> to convert.</param>
	/// <returns>A <see cref="T:System.Drawing.Point" /> that represents the converted <see cref="T:System.Drawing.Point" />, <paramref name="p" />, in screen coordinates.</returns>
	public Point PointToScreen(Point p)
	{
		return default(Point);
	}

	internal PreProcessControlState PreProcessControlMessageInternal(ref Message msg)
	{
		return default(PreProcessControlState);
	}

	/// <summary>Preprocesses keyboard or input messages within the message loop before they are dispatched.</summary>
	/// <param name="msg">A <see cref="T:System.Windows.Forms.Message" />, passed by reference, that represents the message to process. The possible values are WM_KEYDOWN, WM_SYSKEYDOWN, WM_CHAR, and WM_SYSCHAR.</param>
	/// <returns>
	///   <see langword="true" /> if the message was processed by the control; otherwise, <see langword="false" />.</returns>
	public virtual bool PreProcessMessage(ref Message msg)
	{
		return false;
	}

	internal virtual bool InternalPreProcessMessage(ref Message msg)
	{
		return false;
	}

	/// <summary>Forces the control to invalidate its client area and immediately redraw itself and any child controls.</summary>
	public virtual void Refresh()
	{
	}

	/// <summary>Resets the <see cref="P:System.Windows.Forms.Control.Cursor" /> property to its default value.</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void ResetCursor()
	{
	}

	/// <summary>Resumes usual layout logic.</summary>
	public void ResumeLayout()
	{
	}

	/// <summary>Resumes usual layout logic, optionally forcing an immediate layout of pending layout requests.</summary>
	/// <param name="performLayout">
	///   <see langword="true" /> to execute pending layout requests; otherwise, <see langword="false" />.</param>
	public void ResumeLayout(bool performLayout)
	{
	}

	/// <summary>Scales the entire control and any child controls.</summary>
	/// <param name="dx">The horizontal scaling factor.</param>
	/// <param name="dy">The vertical scaling factor.</param>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete]
	public void Scale(float dx, float dy)
	{
	}

	/// <summary>Scales the control and all child controls by the specified scaling factor.</summary>
	/// <param name="factor">A <see cref="T:System.Drawing.SizeF" /> containing the horizontal and vertical scaling factors.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void Scale(SizeF factor)
	{
	}

	internal ContainerControl FindContainer(Control c)
	{
		return null;
	}

	private bool IsContainerAutoScaling(Control c)
	{
		return false;
	}

	/// <summary>Activates the control.</summary>
	public void Select()
	{
	}

	/// <summary>Activates the next control.</summary>
	/// <param name="ctl">The <see cref="T:System.Windows.Forms.Control" /> at which to start the search.</param>
	/// <param name="forward">
	///   <see langword="true" /> to move forward in the tab order; <see langword="false" /> to move backward in the tab order.</param>
	/// <param name="tabStopOnly">
	///   <see langword="true" /> to ignore the controls with the <see cref="P:System.Windows.Forms.Control.TabStop" /> property set to <see langword="false" />; otherwise, <see langword="false" />.</param>
	/// <param name="nested">
	///   <see langword="true" /> to include nested (children of child controls) child controls; otherwise, <see langword="false" />.</param>
	/// <param name="wrap">
	///   <see langword="true" /> to continue searching from the first control in the tab order after the last control has been reached; otherwise, <see langword="false" />.</param>
	/// <returns>
	///   <see langword="true" /> if a control was activated; otherwise, <see langword="false" />.</returns>
	public bool SelectNextControl(Control ctl, bool forward, bool tabStopOnly, bool nested, bool wrap)
	{
		return false;
	}

	/// <summary>Sends the control to the back of the z-order.</summary>
	public void SendToBack()
	{
	}

	/// <summary>Sets the specified bounds of the control to the specified location and size.</summary>
	/// <param name="x">The new <see cref="P:System.Windows.Forms.Control.Left" /> property value of the control.</param>
	/// <param name="y">The new <see cref="P:System.Windows.Forms.Control.Top" /> property value of the control.</param>
	/// <param name="width">The new <see cref="P:System.Windows.Forms.Control.Width" /> property value of the control.</param>
	/// <param name="height">The new <see cref="P:System.Windows.Forms.Control.Height" /> property value of the control.</param>
	/// <param name="specified">A bitwise combination of the <see cref="T:System.Windows.Forms.BoundsSpecified" /> values. For any parameter not specified, the current value will be used.</param>
	public void SetBounds(int x, int y, int width, int height, BoundsSpecified specified)
	{
	}

	internal void SetBoundsInternal(int x, int y, int width, int height, BoundsSpecified specified)
	{
	}

	/// <summary>Displays the control to the user.</summary>
	public void Show()
	{
	}

	/// <summary>Temporarily suspends the layout logic for the control.</summary>
	public void SuspendLayout()
	{
	}

	/// <summary>Causes the control to redraw the invalidated regions within its client area.</summary>
	public void Update()
	{
	}

	/// <summary>Creates a new instance of the control collection for the control.</summary>
	/// <returns>A new instance of <see cref="T:System.Windows.Forms.Control.ControlCollection" /> assigned to the control.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual ControlCollection CreateControlsInstance()
	{
		return null;
	}

	/// <summary>Creates a handle for the control.</summary>
	/// <exception cref="T:System.ObjectDisposedException">The object is in a disposed state.</exception>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void CreateHandle()
	{
	}

	/// <summary>Sends the specified message to the default window procedure.</summary>
	/// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void DefWndProc(ref Message m)
	{
	}

	/// <summary>Destroys the handle associated with the control.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void DestroyHandle()
	{
	}

	/// <summary>Retrieves a value indicating how a control will behave when its <see cref="P:System.Windows.Forms.Control.AutoSize" /> property is enabled.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.AutoSizeMode" /> values.</returns>
	protected internal AutoSizeMode GetAutoSizeMode()
	{
		return default(AutoSizeMode);
	}

	/// <summary>Retrieves the bounds within which the control is scaled.</summary>
	/// <param name="bounds">A <see cref="T:System.Drawing.Rectangle" /> that specifies the area for which to retrieve the display bounds.</param>
	/// <param name="factor">The height and width of the control's bounds.</param>
	/// <param name="specified">One of the values of <see cref="T:System.Windows.Forms.BoundsSpecified" /> that specifies the bounds of the control to use when defining its size and position.</param>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> representing the bounds within which the control is scaled.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified)
	{
		return default(Rectangle);
	}

	private Rectangle GetScaledBoundsOld(Rectangle bounds, SizeF factor, BoundsSpecified specified)
	{
		return default(Rectangle);
	}

	/// <summary>Retrieves the value of the specified control style bit for the control.</summary>
	/// <param name="flag">The <see cref="T:System.Windows.Forms.ControlStyles" /> bit to return the value from.</param>
	/// <returns>
	///   <see langword="true" /> if the specified control style bit is set to <see langword="true" />; otherwise, <see langword="false" />.</returns>
	protected internal bool GetStyle(ControlStyles flag)
	{
		return false;
	}

	/// <summary>Determines if the control is a top-level control.</summary>
	/// <returns>
	///   <see langword="true" /> if the control is a top-level control; otherwise, <see langword="false" />.</returns>
	protected bool GetTopLevel()
	{
		return false;
	}

	/// <summary>Called after the control has been added to another container.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void InitLayout()
	{
	}

	/// <summary>Determines if a character is an input character that the control recognizes.</summary>
	/// <param name="charCode">The character to test.</param>
	/// <returns>
	///   <see langword="true" /> if the character should be sent directly to the control and not preprocessed; otherwise, <see langword="false" />.</returns>
	protected virtual bool IsInputChar(char charCode)
	{
		return false;
	}

	internal virtual bool IsInputCharInternal(char charCode)
	{
		return false;
	}

	/// <summary>Determines whether the specified key is a regular input key or a special key that requires preprocessing.</summary>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values.</param>
	/// <returns>
	///   <see langword="true" /> if the specified key is a regular input key; otherwise, <see langword="false" />.</returns>
	protected virtual bool IsInputKey(Keys keyData)
	{
		return false;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Invalidated" /> event with a specified region of the control to invalidate.</summary>
	/// <param name="invalidatedArea">A <see cref="T:System.Drawing.Rectangle" /> representing the area to invalidate.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void NotifyInvalidate(Rectangle invalidatedArea)
	{
	}

	/// <summary>Processes a command key.</summary>
	/// <param name="msg">A <see cref="T:System.Windows.Forms.Message" />, passed by reference, that represents the window message to process.</param>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
	/// <returns>
	///   <see langword="true" /> if the character was processed by the control; otherwise, <see langword="false" />.</returns>
	protected virtual bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		return false;
	}

	/// <summary>Processes a dialog character.</summary>
	/// <param name="charCode">The character to process.</param>
	/// <returns>
	///   <see langword="true" /> if the character was processed by the control; otherwise, <see langword="false" />.</returns>
	protected virtual bool ProcessDialogChar(char charCode)
	{
		return false;
	}

	/// <summary>Processes a dialog key.</summary>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
	/// <returns>
	///   <see langword="true" /> if the key was processed by the control; otherwise, <see langword="false" />.</returns>
	protected virtual bool ProcessDialogKey(Keys keyData)
	{
		return false;
	}

	/// <summary>Processes a key message and generates the appropriate control events.</summary>
	/// <param name="m">A <see cref="T:System.Windows.Forms.Message" />, passed by reference, that represents the window message to process.</param>
	/// <returns>
	///   <see langword="true" /> if the message was processed by the control; otherwise, <see langword="false" />.</returns>
	protected virtual bool ProcessKeyEventArgs(ref Message m)
	{
		return false;
	}

	/// <summary>Processes a keyboard message.</summary>
	/// <param name="m">A <see cref="T:System.Windows.Forms.Message" />, passed by reference, that represents the window message to process.</param>
	/// <returns>
	///   <see langword="true" /> if the message was processed by the control; otherwise, <see langword="false" />.</returns>
	protected internal virtual bool ProcessKeyMessage(ref Message m)
	{
		return false;
	}

	/// <summary>Previews a keyboard message.</summary>
	/// <param name="m">A <see cref="T:System.Windows.Forms.Message" />, passed by reference, that represents the window message to process.</param>
	/// <returns>
	///   <see langword="true" /> if the message was processed by the control; otherwise, <see langword="false" />.</returns>
	protected virtual bool ProcessKeyPreview(ref Message m)
	{
		return false;
	}

	/// <summary>Processes a mnemonic character.</summary>
	/// <param name="charCode">The character to process.</param>
	/// <returns>
	///   <see langword="true" /> if the character was processed as a mnemonic by the control; otherwise, <see langword="false" />.</returns>
	protected virtual bool ProcessMnemonic(char charCode)
	{
		return false;
	}

	private void SetIsRecreating()
	{
	}

	/// <summary>Forces the re-creation of the handle for the control.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected void RecreateHandle()
	{
	}

	/// <summary>Scales a control's location, size, padding and margin.</summary>
	/// <param name="factor">The factor by which the height and width of the control will be scaled.</param>
	/// <param name="specified">A <see cref="T:System.Windows.Forms.BoundsSpecified" /> value that specifies the bounds of the control to use when defining its size and position.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void ScaleControl(SizeF factor, BoundsSpecified specified)
	{
	}

	/// <summary>This method is not relevant for this class.</summary>
	/// <param name="dx">The horizontal scaling factor.</param>
	/// <param name="dy">The vertical scaling factor.</param>
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected virtual void ScaleCore(float dx, float dy)
	{
	}

	/// <summary>Activates a child control. Optionally specifies the direction in the tab order to select the control from.</summary>
	/// <param name="directed">
	///   <see langword="true" /> to specify the direction of the control to select; otherwise, <see langword="false" />.</param>
	/// <param name="forward">
	///   <see langword="true" /> to move forward in the tab order; <see langword="false" /> to move backward in the tab order.</param>
	protected virtual void Select(bool directed, bool forward)
	{
	}

	/// <summary>Sets a value indicating how a control will behave when its <see cref="P:System.Windows.Forms.Control.AutoSize" /> property is enabled.</summary>
	/// <param name="mode">One of the <see cref="T:System.Windows.Forms.AutoSizeMode" /> values.</param>
	protected void SetAutoSizeMode(AutoSizeMode mode)
	{
	}

	/// <summary>Performs the work of setting the specified bounds of this control.</summary>
	/// <param name="x">The new <see cref="P:System.Windows.Forms.Control.Left" /> property value of the control.</param>
	/// <param name="y">The new <see cref="P:System.Windows.Forms.Control.Top" /> property value of the control.</param>
	/// <param name="width">The new <see cref="P:System.Windows.Forms.Control.Width" /> property value of the control.</param>
	/// <param name="height">The new <see cref="P:System.Windows.Forms.Control.Height" /> property value of the control.</param>
	/// <param name="specified">A bitwise combination of the <see cref="T:System.Windows.Forms.BoundsSpecified" /> values.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
	}

	internal virtual void SetBoundsCoreInternal(int x, int y, int width, int height, BoundsSpecified specified)
	{
	}

	/// <summary>Sets the size of the client area of the control.</summary>
	/// <param name="x">The client area width, in pixels.</param>
	/// <param name="y">The client area height, in pixels.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void SetClientSizeCore(int x, int y)
	{
	}

	/// <summary>Sets a specified <see cref="T:System.Windows.Forms.ControlStyles" /> flag to either <see langword="true" /> or <see langword="false" />.</summary>
	/// <param name="flag">The <see cref="T:System.Windows.Forms.ControlStyles" /> bit to set.</param>
	/// <param name="value">
	///   <see langword="true" /> to apply the specified style to the control; otherwise, <see langword="false" />.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal void SetStyle(ControlStyles flag, bool value)
	{
	}

	/// <summary>Sets the control to the specified visible state.</summary>
	/// <param name="value">
	///   <see langword="true" /> to make the control visible; otherwise, <see langword="false" />.</param>
	protected virtual void SetVisibleCore(bool value)
	{
	}

	/// <summary>Determines the size of the entire control from the height and width of its client area.</summary>
	/// <param name="clientSize">A <see cref="T:System.Drawing.Size" /> value representing the height and width of the control's client area.</param>
	/// <returns>A <see cref="T:System.Drawing.Size" /> value representing the height and width of the entire control.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual Size SizeFromClientSize(Size clientSize)
	{
		return default(Size);
	}

	/// <summary>Updates the bounds of the control with the current size and location.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected void UpdateBounds()
	{
	}

	/// <summary>Updates the bounds of the control with the specified size and location.</summary>
	/// <param name="x">The <see cref="P:System.Drawing.Point.X" /> coordinate of the control.</param>
	/// <param name="y">The <see cref="P:System.Drawing.Point.Y" /> coordinate of the control.</param>
	/// <param name="width">The <see cref="P:System.Drawing.Size.Width" /> of the control.</param>
	/// <param name="height">The <see cref="P:System.Drawing.Size.Height" /> of the control.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected void UpdateBounds(int x, int y, int width, int height)
	{
	}

	/// <summary>Updates the bounds of the control with the specified size, location, and client size.</summary>
	/// <param name="x">The <see cref="P:System.Drawing.Point.X" /> coordinate of the control.</param>
	/// <param name="y">The <see cref="P:System.Drawing.Point.Y" /> coordinate of the control.</param>
	/// <param name="width">The <see cref="P:System.Drawing.Size.Width" /> of the control.</param>
	/// <param name="height">The <see cref="P:System.Drawing.Size.Height" /> of the control.</param>
	/// <param name="clientWidth">The client <see cref="P:System.Drawing.Size.Width" /> of the control.</param>
	/// <param name="clientHeight">The client <see cref="P:System.Drawing.Size.Height" /> of the control.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected void UpdateBounds(int x, int y, int width, int height, int clientWidth, int clientHeight)
	{
	}

	/// <summary>Forces the assigned styles to be reapplied to the control.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected void UpdateStyles()
	{
	}

	private void UpdateZOrderOfChild(Control child)
	{
	}

	internal virtual IntPtr AfterTopMostControl()
	{
		return (IntPtr)0;
	}

	internal void UpdateChildrenZOrder()
	{
	}

	/// <summary>Updates the control in its parent's z-order.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected void UpdateZOrder()
	{
	}

	/// <summary>Processes Windows messages.</summary>
	/// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
	protected virtual void WndProc(ref Message m)
	{
	}

	private void WmDestroy(ref Message m)
	{
	}

	private void WmWindowPosChanged(ref Message m)
	{
	}

	private void WmPaint(ref Message m)
	{
	}

	private void WmEraseBackground(ref Message m)
	{
	}

	private void WmLButtonUp(ref Message m)
	{
	}

	private void WmLButtonDown(ref Message m)
	{
	}

	private void WmLButtonDblClick(ref Message m)
	{
	}

	private void WmMButtonUp(ref Message m)
	{
	}

	private void WmMButtonDown(ref Message m)
	{
	}

	private void WmMButtonDblClick(ref Message m)
	{
	}

	private void WmRButtonUp(ref Message m)
	{
	}

	private void WmRButtonDown(ref Message m)
	{
	}

	private void WmRButtonDblClick(ref Message m)
	{
	}

	private void WmContextMenu(ref Message m)
	{
	}

	private void WmCreate(ref Message m)
	{
	}

	private void WmMouseWheel(ref Message m)
	{
	}

	private void WmMouseMove(ref Message m)
	{
	}

	private void WmMouseEnter(ref Message m)
	{
	}

	private void WmMouseLeave(ref Message m)
	{
	}

	private void WmMouseHover(ref Message m)
	{
	}

	private void WmShowWindow(ref Message m)
	{
	}

	private void WmSysKeyUp(ref Message m)
	{
	}

	private void WmKeys(ref Message m)
	{
	}

	private void WmHelp(ref Message m)
	{
	}

	private void WmKillFocus(ref Message m)
	{
	}

	private void WmSetFocus(ref Message m)
	{
	}

	private void WmSysColorChange(ref Message m)
	{
	}

	private void WmSetCursor(ref Message m)
	{
	}

	private void WmCaptureChanged(ref Message m)
	{
	}

	private void WmChangeUIState(ref Message m)
	{
	}

	private void WmUpdateUIState(ref Message m)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.AutoSizeChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnAutoSizeChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.BackColorChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnBackColorChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.BackgroundImageLayoutChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnBackgroundImageLayoutChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.BindingContextChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnBindingContextChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.CausesValidationChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnCausesValidationChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.ChangeUICues" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.UICuesEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnChangeUICues(UICuesEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Click" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnClick(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.ClientSizeChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnClientSizeChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.ContextMenuChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnContextMenuChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.ControlAdded" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ControlEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnControlAdded(ControlEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.ControlRemoved" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ControlEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnControlRemoved(ControlEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.Control.CreateControl" /> method.</summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnCreateControl()
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.CursorChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnCursorChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.DockChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnDockChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.DoubleClick" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnDoubleClick(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.DragDrop" /> event.</summary>
	/// <param name="drgevent">A <see cref="T:System.Windows.Forms.DragEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnDragDrop(DragEventArgs drgevent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.DragEnter" /> event.</summary>
	/// <param name="drgevent">A <see cref="T:System.Windows.Forms.DragEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnDragEnter(DragEventArgs drgevent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.DragLeave" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnDragLeave(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.DragOver" /> event.</summary>
	/// <param name="drgevent">A <see cref="T:System.Windows.Forms.DragEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnDragOver(DragEventArgs drgevent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.EnabledChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnEnabledChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Enter" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnEnter(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.FontChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnFontChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.ForeColorChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnForeColorChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.GiveFeedback" /> event.</summary>
	/// <param name="gfbevent">A <see cref="T:System.Windows.Forms.GiveFeedbackEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.GotFocus" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnGotFocus(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.HandleCreated" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnHandleCreated(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.HandleDestroyed" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnHandleDestroyed(EventArgs e)
	{
	}

	internal void RaiseHelpRequested(HelpEventArgs hevent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.HelpRequested" /> event.</summary>
	/// <param name="hevent">A <see cref="T:System.Windows.Forms.HelpEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnHelpRequested(HelpEventArgs hevent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.ImeModeChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnImeModeChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Invalidated" /> event.</summary>
	/// <param name="e">An <see cref="T:System.Windows.Forms.InvalidateEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnInvalidated(InvalidateEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.KeyDown" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.KeyEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnKeyDown(KeyEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.KeyPress" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.KeyPressEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnKeyPress(KeyPressEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.KeyUp" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.KeyEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnKeyUp(KeyEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Layout" /> event.</summary>
	/// <param name="levent">A <see cref="T:System.Windows.Forms.LayoutEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnLayout(LayoutEventArgs levent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Leave" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnLeave(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.LocationChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnLocationChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.LostFocus" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnLostFocus(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseCaptureChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnMouseCaptureChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseClick" /> event.</summary>
	/// <param name="e">An <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnMouseClick(MouseEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseDoubleClick" /> event.</summary>
	/// <param name="e">An <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnMouseDoubleClick(MouseEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnMouseDown(MouseEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseEnter" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnMouseEnter(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseHover" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnMouseHover(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnMouseLeave(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseMove" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnMouseMove(MouseEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseUp" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnMouseUp(MouseEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseWheel" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnMouseWheel(MouseEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Move" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnMove(EventArgs e)
	{
	}

	/// <summary>Notifies the control of Windows messages.</summary>
	/// <param name="m">A <see cref="T:System.Windows.Forms.Message" /> that represents the Windows message.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnNotifyMessage(Message m)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.PaddingChanged" /> event.</summary>
	/// <param name="e">A <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnPaddingChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnPaint(PaintEventArgs e)
	{
	}

	internal virtual void OnPaintBackgroundInternal(PaintEventArgs e)
	{
	}

	internal virtual void OnPaintInternal(PaintEventArgs e)
	{
	}

	/// <summary>Paints the background of the control.</summary>
	/// <param name="pevent">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains information about the control to paint.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.BackColorChanged" /> event when the <see cref="P:System.Windows.Forms.Control.BackColor" /> property value of the control's container changes.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnParentBackColorChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.BindingContextChanged" /> event when the <see cref="P:System.Windows.Forms.Control.BindingContext" /> property value of the control's container changes.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnParentBindingContextChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.ParentChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnParentChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.CursorChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnParentCursorChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.EnabledChanged" /> event when the <see cref="P:System.Windows.Forms.Control.Enabled" /> property value of the control's container changes.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnParentEnabledChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.FontChanged" /> event when the <see cref="P:System.Windows.Forms.Control.Font" /> property value of the control's container changes.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnParentFontChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.ForeColorChanged" /> event when the <see cref="P:System.Windows.Forms.Control.ForeColor" /> property value of the control's container changes.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnParentForeColorChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.RightToLeftChanged" /> event when the <see cref="P:System.Windows.Forms.Control.RightToLeft" /> property value of the control's container changes.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnParentRightToLeftChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.VisibleChanged" /> event when the <see cref="P:System.Windows.Forms.Control.Visible" /> property value of the control's container changes.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnParentVisibleChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.QueryContinueDrag" /> event.</summary>
	/// <param name="qcdevent">A <see cref="T:System.Windows.Forms.QueryContinueDragEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnQueryContinueDrag(QueryContinueDragEventArgs qcdevent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.PreviewKeyDown" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.PreviewKeyDownEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.RegionChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnRegionChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnResize(EventArgs e)
	{
	}

	internal virtual void OnResizeInternal(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.RightToLeftChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnRightToLeftChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.SizeChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnSizeChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.StyleChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnStyleChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.SystemColorsChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnSystemColorsChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.TabIndexChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnTabIndexChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.TabStopChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnTabStopChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnTextChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Validated" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnValidated(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Validating" /> event.</summary>
	/// <param name="e">A <see cref="T:System.ComponentModel.CancelEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnValidating(CancelEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.VisibleChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void OnVisibleChanged(EventArgs e)
	{
	}
}
