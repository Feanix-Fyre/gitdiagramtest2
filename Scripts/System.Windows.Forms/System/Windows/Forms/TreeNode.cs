using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.Serialization;

namespace System.Windows.Forms;

/// <summary>Represents a node of a <see cref="T:System.Windows.Forms.TreeView" />.</summary>
[Serializable]
[DefaultProperty("Text")]
[TypeConverter(typeof(TreeNodeConverter))]
public class TreeNode : MarshalByRefObject, ISerializable, ICloneable
{
	private TreeView tree_view;

	internal TreeNode parent;

	private string text;

	private int image_index;

	private int selected_image_index;

	private ContextMenu context_menu;

	private ContextMenuStrip context_menu_strip;

	private string image_key;

	private string selected_image_key;

	private int state_image_index;

	private string state_image_key;

	private string tool_tip_text;

	internal TreeNodeCollection nodes;

	internal TreeViewAction check_reason;

	internal int visible_order;

	internal int width;

	internal bool is_expanded;

	private bool check;

	internal OwnerDrawPropertyBag prop_bag;

	private object tag;

	private string name;

	/// <summary>Gets or sets the background color of the tree node.</summary>
	/// <returns>The background <see cref="T:System.Drawing.Color" /> of the tree node. The default is <see cref="F:System.Drawing.Color.Empty" />.</returns>
	public Color BackColor => default(Color);

	/// <summary>Gets the bounds of the tree node.</summary>
	/// <returns>The <see cref="T:System.Drawing.Rectangle" /> that represents the bounds of the tree node.</returns>
	[Browsable(false)]
	public Rectangle Bounds => default(Rectangle);

	internal int IndentLevel => 0;

	/// <summary>Gets or sets a value indicating whether the tree node is in a checked state.</summary>
	/// <returns>
	///   <see langword="true" /> if the tree node is in a checked state; otherwise, <see langword="false" />.</returns>
	[DefaultValue(false)]
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

	/// <summary>Gets the shortcut menu that is associated with this tree node.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.ContextMenu" /> that is associated with the tree node.</returns>
	[DefaultValue(null)]
	public virtual ContextMenu ContextMenu => null;

	/// <summary>Gets or sets the shortcut menu associated with this tree node.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.ContextMenuStrip" /> associated with the tree node.</returns>
	[DefaultValue(null)]
	public virtual ContextMenuStrip ContextMenuStrip => null;

	/// <summary>Gets the first child tree node in the tree node collection.</summary>
	/// <returns>The first child <see cref="T:System.Windows.Forms.TreeNode" /> in the <see cref="P:System.Windows.Forms.TreeNode.Nodes" /> collection.</returns>
	[Browsable(false)]
	public TreeNode FirstNode => null;

	/// <summary>Gets or sets the foreground color of the tree node.</summary>
	/// <returns>The foreground <see cref="T:System.Drawing.Color" /> of the tree node.</returns>
	public Color ForeColor => default(Color);

	/// <summary>Gets or sets the image list index value of the image displayed when the tree node is in the unselected state.</summary>
	/// <returns>A zero-based index value that represents the image position in the assigned <see cref="T:System.Windows.Forms.ImageList" />.</returns>
	[DefaultValue(-1)]
	[RelatedImageList("TreeView.ImageList")]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[RefreshProperties(RefreshProperties.Repaint)]
	[Localizable(true)]
	[TypeConverter(typeof(TreeViewImageIndexConverter))]
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

	/// <summary>Gets a value indicating whether the tree node is in an editable state.</summary>
	/// <returns>
	///   <see langword="true" /> if the tree node is in editable state; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	public bool IsEditing => false;

	/// <summary>Gets a value indicating whether the tree node is in the expanded state.</summary>
	/// <returns>
	///   <see langword="true" /> if the tree node is in the expanded state; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	public bool IsExpanded => false;

	/// <summary>Gets a value indicating whether the tree node is in the selected state.</summary>
	/// <returns>
	///   <see langword="true" /> if the tree node is in the selected state; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	public bool IsSelected => false;

	/// <summary>Gets a value indicating whether the tree node is visible or partially visible.</summary>
	/// <returns>
	///   <see langword="true" /> if the tree node is visible or partially visible; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	public bool IsVisible => false;

	/// <summary>Gets the last child tree node.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.TreeNode" /> that represents the last child tree node.</returns>
	[Browsable(false)]
	public TreeNode LastNode => null;

	/// <summary>Gets the next sibling tree node.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.TreeNode" /> that represents the next sibling tree node.</returns>
	[Browsable(false)]
	public TreeNode NextNode => null;

	/// <summary>Gets or sets the font that is used to display the text on the tree node label.</summary>
	/// <returns>The <see cref="T:System.Drawing.Font" /> that is used to display the text on the tree node label.</returns>
	[Localizable(true)]
	[DefaultValue(null)]
	public Font NodeFont => null;

	/// <summary>Gets the collection of <see cref="T:System.Windows.Forms.TreeNode" /> objects assigned to the current tree node.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.TreeNodeCollection" /> that represents the tree nodes assigned to the current tree node.</returns>
	[Browsable(false)]
	[ListBindable(false)]
	public TreeNodeCollection Nodes => null;

	/// <summary>Gets the parent tree node of the current tree node.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.TreeNode" /> that represents the parent of the current tree node.</returns>
	[Browsable(false)]
	public TreeNode Parent => null;

	/// <summary>Gets the previous sibling tree node.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.TreeNode" /> that represents the previous sibling tree node.</returns>
	[Browsable(false)]
	public TreeNode PrevNode => null;

	/// <summary>Gets or sets the image list index value of the image that is displayed when the tree node is in the selected state.</summary>
	/// <returns>A zero-based index value that represents the image position in an <see cref="T:System.Windows.Forms.ImageList" />.</returns>
	[DefaultValue(-1)]
	[Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[RelatedImageList("TreeView.ImageList")]
	[TypeConverter(typeof(TreeViewImageIndexConverter))]
	[RefreshProperties(RefreshProperties.Repaint)]
	[Localizable(true)]
	public int SelectedImageIndex => 0;

	/// <summary>Gets or sets the object that contains data about the tree node.</summary>
	/// <returns>An <see cref="T:System.Object" /> that contains data about the tree node. The default is <see langword="null" />.</returns>
	[DefaultValue(null)]
	[Localizable(false)]
	[TypeConverter(typeof(StringConverter))]
	[Bindable(true)]
	public object Tag
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the text displayed in the label of the tree node.</summary>
	/// <returns>The text displayed in the label of the tree node.</returns>
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

	/// <summary>Gets or sets the text that appears when the mouse pointer hovers over a <see cref="T:System.Windows.Forms.TreeNode" />.</summary>
	/// <returns>Gets the text that appears when the mouse pointer hovers over a <see cref="T:System.Windows.Forms.TreeNode" />.</returns>
	[Localizable(false)]
	[DefaultValue(null)]
	public string ToolTipText => null;

	/// <summary>Gets the parent tree view that the tree node is assigned to.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.TreeView" /> that represents the parent tree view that the tree node is assigned to, or <see langword="null" /> if the node has not been assigned to a tree view.</returns>
	[Browsable(false)]
	public TreeView TreeView => null;

	internal bool ArePreviousNodesExpanded => false;

	internal bool IsRoot => false;

	/// <summary>Gets the position of the tree node in the tree node collection.</summary>
	/// <returns>A zero-based index value that represents the position of the tree node in the <see cref="P:System.Windows.Forms.TreeNode.Nodes" /> collection.</returns>
	public int Index => 0;

	internal Image StateImage => null;

	internal int Image => 0;

	internal TreeNode(TreeView tree_view)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.TreeNode" /> class using the specified serialization information and context.</summary>
	/// <param name="serializationInfo">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that contains the data to deserialize the class.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the source and destination of the serialized stream.</param>
	protected TreeNode(SerializationInfo serializationInfo, StreamingContext context)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.TreeNode" /> class.</summary>
	public TreeNode()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.TreeNode" /> class with the specified label text.</summary>
	/// <param name="text">The label <see cref="P:System.Windows.Forms.TreeNode.Text" /> of the new tree node.</param>
	public TreeNode(string text)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.TreeNode" /> class with the specified label text and images to display when the tree node is in a selected and unselected state.</summary>
	/// <param name="text">The label <see cref="P:System.Windows.Forms.TreeNode.Text" /> of the new tree node.</param>
	/// <param name="imageIndex">The index value of <see cref="T:System.Drawing.Image" /> to display when the tree node is unselected.</param>
	/// <param name="selectedImageIndex">The index value of <see cref="T:System.Drawing.Image" /> to display when the tree node is selected.</param>
	public TreeNode(string text, int imageIndex, int selectedImageIndex)
	{
	}

	/// <summary>Populates a serialization information object with the data needed to serialize the <see cref="T:System.Windows.Forms.TreeNode" />.</summary>
	/// <param name="si">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that contains the data to serialize the <see cref="T:System.Windows.Forms.TreeNode" />.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the destination information for this serialization.</param>
	void ISerializable.GetObjectData(SerializationInfo si, StreamingContext context)
	{
	}

	/// <summary>Copies the tree node and the entire subtree rooted at this tree node.</summary>
	/// <returns>The <see cref="T:System.Object" /> that represents the cloned <see cref="T:System.Windows.Forms.TreeNode" />.</returns>
	public virtual object Clone()
	{
		return null;
	}

	internal int GetY()
	{
		return 0;
	}

	internal int GetX()
	{
		return 0;
	}

	internal int GetLinesX()
	{
		return 0;
	}

	internal int GetImageX()
	{
		return 0;
	}

	/// <summary>Initiates the editing of the tree node label.</summary>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="P:System.Windows.Forms.TreeView.LabelEdit" /> is set to <see langword="false" />.</exception>
	public void BeginEdit()
	{
	}

	/// <summary>Collapses the tree node.</summary>
	public void Collapse()
	{
	}

	/// <summary>Ends the editing of the tree node label.</summary>
	/// <param name="cancel">
	///   <see langword="true" /> if the editing of the tree node label text was canceled without being saved; otherwise, <see langword="false" />.</param>
	public void EndEdit(bool cancel)
	{
	}

	/// <summary>Expands the tree node.</summary>
	public void Expand()
	{
	}

	/// <summary>Expands all the child tree nodes.</summary>
	public void ExpandAll()
	{
	}

	/// <summary>Ensures that the tree node is visible, expanding tree nodes and scrolling the tree view control as necessary.</summary>
	public void EnsureVisible()
	{
	}

	/// <summary>Removes the current tree node from the tree view control.</summary>
	public void Remove()
	{
	}

	/// <summary>Toggles the tree node to either the expanded or collapsed state.</summary>
	public void Toggle()
	{
	}

	/// <summary>Returns a string that represents the current object.</summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString()
	{
		return null;
	}

	private void Expand(bool byInternal)
	{
	}

	private void CollapseInternal(bool byInternal)
	{
	}

	private int CountToNext()
	{
		return 0;
	}

	private bool HasFocusInChildren()
	{
		return false;
	}

	private void ExpandRecursive(TreeNode node)
	{
	}

	private void ExpandParentRecursive(TreeNode node)
	{
	}

	internal void SetNodes(TreeNodeCollection nodes)
	{
	}

	internal void Invalidate()
	{
	}

	internal void InvalidateWidth()
	{
	}
}
