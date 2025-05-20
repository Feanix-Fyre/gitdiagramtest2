using System.ComponentModel;
using System.Drawing;
using System.Runtime.Serialization;

namespace System.Windows.Forms;

/// <summary>Represents a group of items displayed within a <see cref="T:System.Windows.Forms.ListView" /> control.</summary>
[Serializable]
[TypeConverter(typeof(ListViewGroupConverter))]
[ToolboxItem(false)]
[DesignTimeVisible(false)]
[DefaultProperty("Header")]
public sealed class ListViewGroup : ISerializable
{
	internal string header;

	private string name;

	private HorizontalAlignment header_alignment;

	private ListView list_view_owner;

	private ListView.ListViewItemCollection items;

	private object tag;

	private Rectangle header_bounds;

	internal int starting_row;

	internal int starting_item;

	internal int rows;

	internal int current_item;

	internal Point items_area_location;

	private bool is_default_group;

	private int item_count;

	/// <summary>Gets or sets the header text for the group.</summary>
	/// <returns>The text to display for the group header. The default is "ListViewGroup".</returns>
	public string Header => null;

	/// <summary>Gets or sets the alignment of the group header text.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.HorizontalAlignment" /> values that specifies the alignment of the header text. The default is <see cref="F:System.Windows.Forms.HorizontalAlignment.Left" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The specified value when setting this property is not a valid <see cref="T:System.Windows.Forms.HorizontalAlignment" /> value.</exception>
	[DefaultValue(HorizontalAlignment.Left)]
	public HorizontalAlignment HeaderAlignment => default(HorizontalAlignment);

	/// <summary>Gets a collection containing all items associated with this group.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> that contains all the items in the group. If there are no items in the group, an empty <see cref="T:System.Windows.Forms.ListView.ListViewItemCollection" /> object is returned.</returns>
	[Browsable(false)]
	public ListView.ListViewItemCollection Items => null;

	/// <summary>Gets the <see cref="T:System.Windows.Forms.ListView" /> control that contains this group.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.ListView" /> control that contains this group.</returns>
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public ListView ListView => null;

	internal ListView ListViewOwner
	{
		set
		{
		}
	}

	internal Rectangle HeaderBounds
	{
		get
		{
			return default(Rectangle);
		}
		set
		{
		}
	}

	internal bool IsDefault
	{
		set
		{
		}
	}

	internal int ItemCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListViewGroup" /> class using the default header text of "ListViewGroup" and the default left header alignment.</summary>
	public ListViewGroup()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListViewGroup" /> class using the specified value to initialize the <see cref="P:System.Windows.Forms.ListViewGroup.Header" /> property and using the default left header alignment.</summary>
	/// <param name="header">The text to display for the group header.</param>
	public ListViewGroup(string header)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListViewGroup" /> class using the specified header text and the specified header alignment.</summary>
	/// <param name="header">The text to display for the group header.</param>
	/// <param name="headerAlignment">One of the <see cref="T:System.Windows.Forms.HorizontalAlignment" /> values that specifies the alignment of the header text.</param>
	public ListViewGroup(string header, HorizontalAlignment headerAlignment)
	{
	}

	private ListViewGroup(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
	/// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext" />) for this serialization.</param>
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal int GetActualItemCount()
	{
		return 0;
	}

	/// <summary>Returns a string that represents the current object.</summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString()
	{
		return null;
	}
}
