using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Displays a hierarchical collection of labeled items, each represented by a <see cref="T:System.Windows.Forms.TreeNode" />.</summary>
[DefaultEvent("AfterSelect")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Docking(DockingBehavior.Ask)]
[ComVisible(true)]
[Designer("System.Windows.Forms.Design.TreeViewDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[DefaultProperty("Nodes")]
public class TreeView : Control
{
	private string path_separator;

	private int item_height;

	private bool sorted;

	internal TreeNode root_node;

	private TreeNodeCollection nodes;

	private TreeViewAction selection_action;

	internal TreeNode selected_node;

	private TreeNode pre_selected_node;

	private TreeNode focused_node;

	internal TreeNode highlighted_node;

	private Rectangle mouse_rect;

	private bool select_mmove;

	private ImageList image_list;

	private int image_index;

	private int selected_image_index;

	private string image_key;

	private bool is_hovering;

	private TreeNode mouse_click_node;

	private string selected_image_key;

	private bool show_node_tool_tips;

	private ImageList state_image_list;

	private TreeNode tooltip_currently_showing;

	private ToolTip tooltip_window;

	private bool full_row_select;

	private bool hot_tracking;

	private int indent;

	private NodeLabelEditEventArgs edit_args;

	private LabelEditTextBox edit_text_box;

	internal TreeNode edit_node;

	private bool checkboxes;

	private bool label_edit;

	private bool scrollable;

	private bool show_lines;

	private bool show_root_lines;

	private bool show_plus_minus;

	private bool hide_selection;

	private int max_visible_order;

	internal VScrollBar vbar;

	internal HScrollBar hbar;

	private bool vbar_bounds_set;

	private bool hbar_bounds_set;

	internal int skipped_nodes;

	internal int hbar_offset;

	private int update_stack;

	private bool update_needed;

	private Pen dash;

	private Color line_color;

	private StringFormat string_format;

	private int drag_begin_x;

	private int drag_begin_y;

	private long handle_count;

	private TreeViewDrawMode draw_mode;

	private static object ItemDragEvent;

	private static object AfterCheckEvent;

	private static object AfterCollapseEvent;

	private static object AfterExpandEvent;

	private static object AfterLabelEditEvent;

	private static object AfterSelectEvent;

	private static object BeforeCheckEvent;

	private static object BeforeCollapseEvent;

	private static object BeforeExpandEvent;

	private static object BeforeLabelEditEvent;

	private static object BeforeSelectEvent;

	private static object DrawNodeEvent;

	private static object NodeMouseClickEvent;

	private static object NodeMouseDoubleClickEvent;

	private static object NodeMouseHoverEvent;

	private static object RightToLeftLayoutChangedEvent;

	private static object UIACheckBoxesChangedEvent;

	private static object UIALabelEditChangedEvent;

	private static object UIANodeTextChangedEvent;

	private static object UIACollectionChangedEvent;

	/// <summary>Gets or sets the background color for the control.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> that represents the background color of the control. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultBackColor" /> property.</returns>
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

	/// <summary>Gets or set the background image for the <see cref="T:System.Windows.Forms.TreeView" /> control.</summary>
	/// <returns>The <see cref="T:System.Drawing.Image" /> that is the background image for the <see cref="T:System.Windows.Forms.TreeView" /> control.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override Image BackgroundImage => null;

	/// <summary>Gets or sets the border style of the tree view control.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.BorderStyle" /> values. The default is <see cref="F:System.Windows.Forms.BorderStyle.Fixed3D" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The assigned value is not one of the <see cref="T:System.Windows.Forms.BorderStyle" /> values.</exception>
	[DispId(-504)]
	[DefaultValue(BorderStyle.Fixed3D)]
	public BorderStyle BorderStyle
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether check boxes are displayed next to the tree nodes in the tree view control.</summary>
	/// <returns>
	///   <see langword="true" /> if a check box is displayed next to each tree node in the tree view control; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool CheckBoxes => false;

	/// <summary>Gets or sets the foreground color of the control.</summary>
	/// <returns>The foreground <see cref="T:System.Drawing.Color" /> of the control. The default is the value of the <see cref="P:System.Windows.Forms.Control.DefaultForeColor" /> property.</returns>
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

	/// <summary>Gets or sets a value indicating whether the selected tree node remains highlighted even when the tree view has lost the focus.</summary>
	/// <returns>
	///   <see langword="true" /> if the selected tree node is not highlighted when the tree view has lost the focus; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool HideSelection
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether a tree node label takes on the appearance of a hyperlink as the mouse pointer passes over it.</summary>
	/// <returns>
	///   <see langword="true" /> if a tree node label takes on the appearance of a hyperlink as the mouse pointer passes over it; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool HotTracking
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the image-list index value of the default image that is displayed by the tree nodes.</summary>
	/// <returns>A zero-based index that represents the position of an <see cref="T:System.Drawing.Image" /> in an <see cref="T:System.Windows.Forms.ImageList" />. The default is zero.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The specified index is less than 0.</exception>
	[TypeConverter(typeof(NoneExcludedImageIndexConverter))]
	[RefreshProperties(RefreshProperties.Repaint)]
	[RelatedImageList("ImageList")]
	[Localizable(true)]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[DefaultValue(-1)]
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

	/// <summary>Gets or sets the <see cref="T:System.Windows.Forms.ImageList" /> that contains the <see cref="T:System.Drawing.Image" /> objects that are used by the tree nodes.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.ImageList" /> that contains the <see cref="T:System.Drawing.Image" /> objects that are used by the tree nodes. The default value is <see langword="null" />.</returns>
	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties.Repaint)]
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

	/// <summary>Gets or sets the distance to indent each child tree node level.</summary>
	/// <returns>The distance, in pixels, to indent each child tree node level. The default value is 19.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The assigned value is less than 0.  
	///  -or-  
	///  The assigned value is greater than 32,000.</exception>
	[Localizable(true)]
	public int Indent => 0;

	/// <summary>Gets or sets the height of each tree node in the tree view control.</summary>
	/// <returns>The height, in pixels, of each tree node in the tree view.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The assigned value is less than one.  
	///  -or-  
	///  The assigned value is greater than the <see cref="F:System.Int16.MaxValue" /> value.</exception>
	public int ItemHeight => 0;

	internal int ActualItemHeight => 0;

	/// <summary>Gets or sets a value indicating whether the label text of the tree nodes can be edited.</summary>
	/// <returns>
	///   <see langword="true" /> if the label text of the tree nodes can be edited; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool LabelEdit
	{
		set
		{
		}
	}

	/// <summary>Gets the collection of tree nodes that are assigned to the tree view control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.TreeNodeCollection" /> that represents the tree nodes assigned to the tree view control.</returns>
	[Localizable(true)]
	[MergableProperty(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public TreeNodeCollection Nodes => null;

	/// <summary>Gets or sets the image list index value of the image that is displayed when a tree node is selected.</summary>
	/// <returns>A zero-based index value that represents the position of an <see cref="T:System.Drawing.Image" /> in an <see cref="T:System.Windows.Forms.ImageList" />.</returns>
	/// <exception cref="T:System.ArgumentException">The index assigned value is less than zero.</exception>
	[Localizable(true)]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[RelatedImageList("ImageList")]
	[TypeConverter(typeof(NoneExcludedImageIndexConverter))]
	[DefaultValue(-1)]
	public int SelectedImageIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the tree node that is currently selected in the tree view control.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.TreeNode" /> that is currently selected in the tree view control.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public TreeNode SelectedNode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether lines are drawn between tree nodes in the tree view control.</summary>
	/// <returns>
	///   <see langword="true" /> if lines are drawn between tree nodes in the tree view control; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool ShowLines
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating ToolTips are shown when the mouse pointer hovers over a <see cref="T:System.Windows.Forms.TreeNode" />.</summary>
	/// <returns>
	///   <see langword="true" /> if ToolTips are shown when the mouse pointer hovers over a <see cref="T:System.Windows.Forms.TreeNode" />; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool ShowNodeToolTips => false;

	/// <summary>Gets or sets a value indicating whether plus-sign (+) and minus-sign (-) buttons are displayed next to tree nodes that contain child tree nodes.</summary>
	/// <returns>
	///   <see langword="true" /> if plus sign and minus sign buttons are displayed next to tree nodes that contain child tree nodes; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool ShowPlusMinus
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether lines are drawn between the tree nodes that are at the root of the tree view.</summary>
	/// <returns>
	///   <see langword="true" /> if lines are drawn between the tree nodes that are at the root of the tree view; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool ShowRootLines => false;

	/// <summary>Gets or sets a value indicating whether the tree nodes in the tree view are sorted.</summary>
	/// <returns>
	///   <see langword="true" /> if the tree nodes in the tree view are sorted; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool Sorted => false;

	/// <summary>Gets or sets the image list that is used to indicate the state of the <see cref="T:System.Windows.Forms.TreeView" /> and its nodes.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.ImageList" /> used for indicating the state of the <see cref="T:System.Windows.Forms.TreeView" /> and its nodes.</returns>
	[DefaultValue(null)]
	public ImageList StateImageList => null;

	/// <summary>Gets or sets the text of the <see cref="T:System.Windows.Forms.TreeView" />.</summary>
	/// <returns>
	///   <see langword="Null" /> in all cases.</returns>
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Bindable(false)]
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

	/// <summary>Gets or sets the first fully-visible tree node in the tree view control.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.TreeNode" /> that represents the first fully-visible tree node in the tree view control.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public TreeNode TopNode => null;

	/// <summary>Gets the number of tree nodes that can be fully visible in the tree view control.</summary>
	/// <returns>The number of <see cref="T:System.Windows.Forms.TreeNode" /> items that can be fully visible in the <see cref="T:System.Windows.Forms.TreeView" /> control.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int VisibleCount => 0;

	/// <summary>Gets or sets a value indicating whether the control should redraw its surface using a secondary buffer. The <see cref="P:System.Windows.Forms.TreeView.DoubleBuffered" /> property does not affect the <see cref="T:System.Windows.Forms.TreeView" /> control.</summary>
	/// <returns>
	///   <see langword="true" /> if the control uses a secondary buffer; otherwise, <see langword="false" />.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override bool DoubleBuffered => false;

	/// <summary>Gets or sets the color of the lines connecting the nodes of the <see cref="T:System.Windows.Forms.TreeView" /> control.</summary>
	/// <returns>The <see cref="T:System.Drawing.Color" /> of the lines connecting the tree nodes.</returns>
	[DefaultValue("Color [Black]")]
	public Color LineColor => default(Color);

	/// <summary>Gets or sets the key of the default image for each node in the <see cref="T:System.Windows.Forms.TreeView" /> control when it is in an unselected state.</summary>
	/// <returns>The key of the default image shown for each node <see cref="T:System.Windows.Forms.TreeView" /> control when the node is in an unselected state.</returns>
	[DefaultValue(null)]
	[RelatedImageList("ImageList")]
	[RefreshProperties(RefreshProperties.Repaint)]
	[Localizable(true)]
	[TypeConverter(typeof(ImageKeyConverter))]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	public string ImageKey => null;

	/// <summary>Gets or sets the key of the default image shown when a <see cref="T:System.Windows.Forms.TreeNode" /> is in a selected state.</summary>
	/// <returns>The key of the default image shown when a <see cref="T:System.Windows.Forms.TreeNode" /> is in a selected state.</returns>
	[DefaultValue(null)]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[TypeConverter(typeof(ImageKeyConverter))]
	[RelatedImageList("ImageList")]
	[Localizable(true)]
	[RefreshProperties(RefreshProperties.Repaint)]
	public string SelectedImageKey => null;

	/// <summary>Gets or sets the layout of the background image for the <see cref="T:System.Windows.Forms.TreeView" /> control.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.ImageLayout" /> values. The default is <see cref="F:System.Windows.Forms.ImageLayout.Tile" />.</returns>
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

	/// <summary>Gets the required creation parameters when the control handle is created.</summary>
	/// <returns>The creation parameters.</returns>
	protected override CreateParams CreateParams => null;

	/// <summary>Gets the default size of the control.</summary>
	/// <returns>The default <see cref="T:System.Drawing.Size" /> of the control.</returns>
	protected override Size DefaultSize => default(Size);

	internal override bool ScaleChildrenInternal => false;

	internal Rectangle ViewportRectangle => default(Rectangle);

	private ToolTip ToolTipWindow => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.TreeView" /> class.</summary>
	public TreeView()
	{
	}

	private Rectangle Bloat(Rectangle rect)
	{
		return default(Rectangle);
	}

	/// <summary>Disables any redrawing of the tree view.</summary>
	public void BeginUpdate()
	{
	}

	/// <summary>Enables the redrawing of the tree view.</summary>
	public void EndUpdate()
	{
	}

	/// <summary>Retrieves the tree node that is at the specified point.</summary>
	/// <param name="pt">The <see cref="T:System.Drawing.Point" /> to evaluate and retrieve the node from.</param>
	/// <returns>The <see cref="T:System.Windows.Forms.TreeNode" /> at the specified point, in tree view (client) coordinates, or <see langword="null" /> if there is no node at that location.</returns>
	public TreeNode GetNodeAt(Point pt)
	{
		return null;
	}

	/// <summary>Retrieves the tree node at the point with the specified coordinates.</summary>
	/// <param name="x">The <see cref="P:System.Drawing.Point.X" /> position to evaluate and retrieve the node from.</param>
	/// <param name="y">The <see cref="P:System.Drawing.Point.Y" /> position to evaluate and retrieve the node from.</param>
	/// <returns>The <see cref="T:System.Windows.Forms.TreeNode" /> at the specified location, in tree view (client) coordinates, or <see langword="null" /> if there is no node at that location.</returns>
	public TreeNode GetNodeAt(int x, int y)
	{
		return null;
	}

	private TreeNode GetNodeAtUseX(int x, int y)
	{
		return null;
	}

	/// <summary>Returns a <see cref="T:System.String" /> containing the name of the <see cref="T:System.ComponentModel.Component" />, if any. This method should not be overridden.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the name of the <see cref="T:System.ComponentModel.Component" />, if any, or <see langword="null" /> if the <see cref="T:System.ComponentModel.Component" /> is unnamed.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Creates a handle for the control.</summary>
	protected override void CreateHandle()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.TreeView" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Determines whether the specified key is a regular input key or a special key that requires preprocessing.</summary>
	/// <param name="keyData">One of the Keys values.</param>
	/// <returns>
	///   <see langword="true" /> if the specified key is a regular input key; otherwise, <see langword="false" />.</returns>
	protected override bool IsInputKey(Keys keyData)
	{
		return false;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.KeyDown" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.KeyEventArgs" /> that contains the event data.</param>
	protected override void OnKeyDown(KeyEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.KeyPress" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.KeyPressEventArgs" /> that contains the event data.</param>
	protected override void OnKeyPress(KeyPressEventArgs e)
	{
	}

	/// <summary>Overrides <see cref="M:System.Windows.Forms.Control.OnKeyUp(System.Windows.Forms.KeyEventArgs)" />.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.KeyEventArgs" /> that contains the event data.</param>
	protected override void OnKeyUp(KeyEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseHover" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseHover(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.</summary>
	/// <param name="e">A <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseLeave(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TreeView.NodeMouseClick" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.TreeNodeMouseClickEventArgs" /> that contains the event data.</param>
	protected virtual void OnNodeMouseClick(TreeNodeMouseClickEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TreeView.NodeMouseDoubleClick" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.TreeNodeMouseClickEventArgs" /> that contains the event data.</param>
	protected virtual void OnNodeMouseDoubleClick(TreeNodeMouseClickEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TreeView.NodeMouseHover" /> event.</summary>
	/// <param name="e">The <see cref="T:System.Windows.Forms.TreeNodeMouseHoverEventArgs" /> that contains the event data.</param>
	protected virtual void OnNodeMouseHover(TreeNodeMouseHoverEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TreeView.ItemDrag" /> event.</summary>
	/// <param name="e">An <see cref="T:System.Windows.Forms.ItemDragEventArgs" /> that contains the event data.</param>
	protected virtual void OnItemDrag(ItemDragEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TreeView.DrawNode" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.DrawTreeNodeEventArgs" /> that contains the event data.</param>
	protected virtual void OnDrawNode(DrawTreeNodeEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TreeView.AfterCheck" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.TreeViewEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnAfterCheck(TreeViewEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TreeView.AfterCollapse" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.TreeViewEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnAfterCollapse(TreeViewEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TreeView.AfterExpand" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.TreeViewEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnAfterExpand(TreeViewEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TreeView.AfterLabelEdit" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.NodeLabelEditEventArgs" /> that contains the event data.</param>
	protected virtual void OnAfterLabelEdit(NodeLabelEditEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TreeView.AfterSelect" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.TreeViewEventArgs" /> that contains the event data.</param>
	protected virtual void OnAfterSelect(TreeViewEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TreeView.BeforeCheck" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.TreeViewCancelEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnBeforeCheck(TreeViewCancelEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TreeView.BeforeCollapse" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.TreeViewCancelEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnBeforeCollapse(TreeViewCancelEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TreeView.BeforeExpand" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.TreeViewCancelEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnBeforeExpand(TreeViewCancelEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TreeView.BeforeLabelEdit" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.NodeLabelEditEventArgs" /> that contains the event data.</param>
	protected virtual void OnBeforeLabelEdit(NodeLabelEditEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.TreeView.BeforeSelect" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.TreeViewCancelEventArgs" /> that contains the event data.</param>
	protected virtual void OnBeforeSelect(TreeViewCancelEventArgs e)
	{
	}

	/// <summary>Overrides <see cref="M:System.Windows.Forms.Control.OnHandleCreated(System.EventArgs)" />.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnHandleCreated(EventArgs e)
	{
	}

	/// <summary>Overrides <see cref="M:System.Windows.Forms.Control.OnHandleDestroyed(System.EventArgs)" />.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnHandleDestroyed(EventArgs e)
	{
	}

	/// <summary>Overrides <see cref="M:System.Windows.Forms.Control.WndProc(System.Windows.Forms.Message@)" />.</summary>
	/// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
	protected override void WndProc(ref Message m)
	{
	}

	internal override void HandleClick(int clicks, MouseEventArgs me)
	{
	}

	internal override bool IsInputCharInternal(char charCode)
	{
		return false;
	}

	private TreeNode GetNodeAt(int y)
	{
		return null;
	}

	private bool IsTextArea(TreeNode node, int x)
	{
		return false;
	}

	private bool IsSelectableArea(TreeNode node, int x)
	{
		return false;
	}

	private bool IsPlusMinusArea(TreeNode node, int x)
	{
		return false;
	}

	private bool IsCheckboxArea(TreeNode node, int x)
	{
		return false;
	}

	private int CheckBoxLeft(TreeNode node)
	{
		return 0;
	}

	internal void RecalculateVisibleOrder(TreeNode start)
	{
	}

	internal void SetTop(TreeNode node)
	{
	}

	internal void SetBottom(TreeNode node)
	{
	}

	internal void UpdateBelow(TreeNode node)
	{
	}

	internal void UpdateNode(TreeNode node)
	{
	}

	internal override void OnPaintInternal(PaintEventArgs pe)
	{
	}

	internal void CreateDashPen()
	{
	}

	private void Draw(Rectangle clip, Graphics dc)
	{
	}

	private void DrawNodeState(TreeNode node, Graphics dc, int x, int y)
	{
	}

	private void DrawNodeCheckBox(TreeNode node, Graphics dc, int x, int middle)
	{
	}

	private void DrawNodeLines(TreeNode node, Graphics dc, Rectangle clip, Pen dash, int x, int y, int middle)
	{
	}

	private void DrawNodeImage(TreeNode node, Graphics dc, Rectangle clip, int x, int y)
	{
	}

	private void LabelEditFinished(object sender, EventArgs e)
	{
	}

	internal void BeginEdit(TreeNode node)
	{
	}

	private void LabelEditCancelled(object sender, EventArgs e)
	{
	}

	private void LabelTextChanged(object sender, EventArgs e)
	{
	}

	internal void EndEdit(TreeNode node)
	{
	}

	internal void CancelEdit(TreeNode node)
	{
	}

	internal int GetNodeWidth(TreeNode node)
	{
		return 0;
	}

	private void DrawSelectionAndFocus(TreeNode node, Graphics dc, Rectangle r)
	{
	}

	private void DrawStaticNode(TreeNode node, Graphics dc)
	{
	}

	private void DrawTreeNode(TreeNode node, Graphics dc, Rectangle clip)
	{
	}

	internal void UpdateScrollBars(bool force)
	{
	}

	private void SizeChangedHandler(object sender, EventArgs e)
	{
	}

	private void VScrollBarValueChanged(object sender, EventArgs e)
	{
	}

	private void SetVScrollPos(int pos, TreeNode new_top)
	{
	}

	private void HScrollBarValueChanged(object sender, EventArgs e)
	{
	}

	internal void ExpandBelow(TreeNode node, int count_to_next)
	{
	}

	internal void CollapseBelow(TreeNode node, int count_to_next)
	{
	}

	private void MouseWheelHandler(object sender, MouseEventArgs e)
	{
	}

	private void VisibleChangedHandler(object sender, EventArgs e)
	{
	}

	private void FontChangedHandler(object sender, EventArgs e)
	{
	}

	private void InvalidateNodeWidthRecursive(TreeNode node)
	{
	}

	private void GotFocusHandler(object sender, EventArgs e)
	{
	}

	private void LostFocusHandler(object sender, EventArgs e)
	{
	}

	private void MouseDownHandler(object sender, MouseEventArgs e)
	{
	}

	private void MouseUpHandler(object sender, MouseEventArgs e)
	{
	}

	private void MouseMoveHandler(object sender, MouseEventArgs e)
	{
	}

	private void DoubleClickHandler(object sender, MouseEventArgs e)
	{
	}

	private bool RectsIntersect(Rectangle r, int left, int top, int width, int height)
	{
		return false;
	}

	private bool WmContextMenu(ref Message m)
	{
		return false;
	}

	private void MouseEnteredItem(TreeNode item)
	{
	}

	private void MouseLeftItem(TreeNode item)
	{
	}

	internal void OnUIALabelEditChanged(EventArgs e)
	{
	}

	internal void OnUIANodeTextChanged(TreeViewEventArgs e)
	{
	}

	internal void OnUIACollectionChanged(object sender, CollectionChangeEventArgs e)
	{
	}
}
