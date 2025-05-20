using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Defines a base class for controls that support auto-scrolling behavior.</summary>
[Designer("System.Windows.Forms.Design.ScrollableControlDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class ScrollableControl : Control
{
	/// <summary>Determines the border padding for docked controls.</summary>
	[TypeConverter(typeof(DockPaddingEdgesConverter))]
	public class DockPaddingEdges : ICloneable
	{
		private Control owner;

		/// <summary>Gets or sets the padding width for all edges of a docked control.</summary>
		/// <returns>The padding width, in pixels.</returns>
		[RefreshProperties(RefreshProperties.All)]
		public int All => 0;

		/// <summary>Gets or sets the padding width for the bottom edge of a docked control.</summary>
		/// <returns>The padding width, in pixels.</returns>
		[RefreshProperties(RefreshProperties.All)]
		public int Bottom
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the padding width for the left edge of a docked control.</summary>
		/// <returns>The padding width, in pixels.</returns>
		[RefreshProperties(RefreshProperties.All)]
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

		/// <summary>Gets or sets the padding width for the right edge of a docked control.</summary>
		/// <returns>The padding width, in pixels.</returns>
		[RefreshProperties(RefreshProperties.All)]
		public int Right
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the padding width for the top edge of a docked control.</summary>
		/// <returns>The padding width, in pixels.</returns>
		[RefreshProperties(RefreshProperties.All)]
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

		internal DockPaddingEdges(Control owner)
		{
		}

		/// <summary>Creates a new object that is a copy of the current instance.</summary>
		/// <returns>A new object that is a copy of the current instance.</returns>
		object ICloneable.Clone()
		{
			return null;
		}

		/// <summary>Determines whether the specified object is equal to the current <see cref="T:System.Windows.Forms.ScrollableControl.DockPaddingEdges" /> object.</summary>
		/// <param name="other">The object to compare with the current <see cref="T:System.Windows.Forms.ScrollableControl.DockPaddingEdges" /> object.</param>
		/// <returns>true if the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />; otherwise, false.</returns>
		public override bool Equals(object other)
		{
			return false;
		}

		/// <summary>Serves as a hash function for a particular type.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Object" />.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Returns an empty string.</summary>
		/// <returns>An empty string.</returns>
		public override string ToString()
		{
			return null;
		}

		internal void Scale(float dx, float dy)
		{
		}
	}

	/// <summary>A <see cref="T:System.ComponentModel.TypeConverter" /> for the <see cref="T:System.Windows.Forms.ScrollableControl.DockPaddingEdges" /> class.</summary>
	public class DockPaddingEdgesConverter : TypeConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ScrollableControl.DockPaddingEdgesConverter" /> class.</summary>
		public DockPaddingEdgesConverter()
		{
		}

		/// <summary>Returns a collection of properties for the type of array specified by the value parameter, using the specified context and attributes.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		/// <param name="value">An object that specifies the type of array for which to get properties.</param>
		/// <param name="attributes">An array of type attribute that is used as a filter.</param>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties that are exposed for the <see cref="T:System.Windows.Forms.ScrollableControl" />.</returns>
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return null;
		}

		/// <summary>Returns whether the current object supports properties, using the specified context.</summary>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		/// <returns>
		///   <see langword="true" /> in all cases.</returns>
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return false;
		}
	}

	private bool force_hscroll_visible;

	private bool force_vscroll_visible;

	private bool auto_scroll;

	private Size auto_scroll_margin;

	private Size auto_scroll_min_size;

	private Point scroll_position;

	private DockPaddingEdges dock_padding;

	private SizeGrip sizegrip;

	internal ImplicitHScrollBar hscrollbar;

	internal ImplicitVScrollBar vscrollbar;

	internal Size canvas_size;

	private Rectangle display_rectangle;

	private Control old_parent;

	private HScrollProperties horizontalScroll;

	private VScrollProperties verticalScroll;

	private static object OnScrollEvent;

	/// <summary>Gets or sets a value indicating whether the container enables the user to scroll to any controls placed outside of its visible boundaries.</summary>
	/// <returns>
	///   <see langword="true" /> if the container enables auto-scrolling; otherwise, <see langword="false" />. The default value is <see langword="false" />.</returns>
	[MWFCategory("Layout")]
	[Localizable(true)]
	[DefaultValue(false)]
	public virtual bool AutoScroll => false;

	/// <summary>Gets the rectangle that represents the virtual display area of the control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that represents the display area of the control.</returns>
	public override Rectangle DisplayRectangle => default(Rectangle);

	/// <summary>Gets the required creation parameters when the control handle is created.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.CreateParams" /> that contains the required creation parameters when the handle to the control is created.</returns>
	protected override CreateParams CreateParams => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ScrollableControl" /> class.</summary>
	public ScrollableControl()
	{
	}

	private void VisibleChangedHandler(object sender, EventArgs e)
	{
	}

	private void LocationChangedHandler(object sender, EventArgs e)
	{
	}

	private void ParentChangedHandler(object sender, EventArgs e)
	{
	}

	private void Parent_PaddingChanged(object sender, EventArgs e)
	{
	}

	private void Parent_SizeChanged(object sender, EventArgs e)
	{
	}

	/// <summary>Scrolls the specified child control into view on an auto-scroll enabled control.</summary>
	/// <param name="activeControl">The child control to scroll into view.</param>
	public void ScrollControlIntoView(Control activeControl)
	{
	}

	/// <summary>Adjusts the scroll bars on the container based on the current control positions and the control currently selected.</summary>
	/// <param name="displayScrollbars">
	///   <see langword="true" /> to show the scroll bars; otherwise, <see langword="false" />.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected virtual void AdjustFormScrollbars(bool displayScrollbars)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Layout" /> event.</summary>
	/// <param name="levent">A <see cref="T:System.Windows.Forms.LayoutEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnLayout(LayoutEventArgs levent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseWheel" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnMouseWheel(MouseEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.VisibleChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnVisibleChanged(EventArgs e)
	{
	}

	/// <summary>This method is not relevant for this class.</summary>
	/// <param name="dx">The horizontal scaling factor.</param>
	/// <param name="dy">The vertical scaling factor.</param>
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override void ScaleCore(float dx, float dy)
	{
	}

	/// <summary>Scales a control's location, size, padding and margin.</summary>
	/// <param name="factor">The factor by which the height and width of the control will be scaled.</param>
	/// <param name="specified">A <see cref="T:System.Windows.Forms.BoundsSpecified" /> value that specifies the bounds of the control to use when defining its size and position.</param>
	protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
	{
	}

	/// <summary>Processes Windows messages.</summary>
	/// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void WndProc(ref Message m)
	{
	}

	internal override IntPtr AfterTopMostControl()
	{
		return (IntPtr)0;
	}

	internal virtual void CalculateCanvasSize(bool canOverride)
	{
	}

	private void Recalculate(object sender, EventArgs e)
	{
	}

	private void Recalculate(bool doLayout)
	{
	}

	internal void UpdateSizeGripVisible()
	{
	}

	private void HandleScrollBar(object sender, EventArgs e)
	{
	}

	private void HandleScrollEvent(object sender, ScrollEventArgs args)
	{
	}

	private void AddScrollbars(object o, EventArgs e)
	{
	}

	private void CreateScrollbars()
	{
	}

	private void ScrollWindow(int XOffset, int YOffset)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ScrollableControl.Scroll" /> event.</summary>
	/// <param name="se">A <see cref="T:System.Windows.Forms.ScrollEventArgs" /> that contains the event data.</param>
	protected virtual void OnScroll(ScrollEventArgs se)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.PaddingChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnPaddingChanged(EventArgs e)
	{
	}

	/// <summary>Paints the background of the control.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
	protected override void OnPaintBackground(PaintEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.RightToLeftChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnRightToLeftChanged(EventArgs e)
	{
	}
}
