using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ListView.SearchForVirtualItem" /> event.</summary>
public class SearchForVirtualItemEventArgs : EventArgs
{
	private SearchDirectionHint direction;

	private bool include_sub_items_in_search;

	private int index;

	private bool is_prefix_search;

	private bool is_text_search;

	private int start_index;

	private Point starting_point;

	private string text;

	/// <summary>Gets or sets the index of the <see cref="T:System.Windows.Forms.ListViewItem" /> found in the <see cref="T:System.Windows.Forms.ListView" /> .</summary>
	/// <returns>The index of the <see cref="T:System.Windows.Forms.ListViewItem" /> found in the <see cref="T:System.Windows.Forms.ListView" />.</returns>
	public int Index => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.SearchForVirtualItemEventArgs" /> class.</summary>
	/// <param name="isTextSearch">A value indicating whether the search is a text search.</param>
	/// <param name="isPrefixSearch">A value indicating whether the search is a prefix search.</param>
	/// <param name="includeSubItemsInSearch">A value indicating whether to include subitems of list items in the search.</param>
	/// <param name="text">The text of the item to search for.</param>
	/// <param name="startingPoint">The <see cref="T:System.Drawing.Point" /> at which to start the search.</param>
	/// <param name="direction">One of the <see cref="T:System.Windows.Forms.SearchDirectionHint" /> values.</param>
	/// <param name="startIndex">The index of the <see cref="T:System.Windows.Forms.ListViewItem" /> at which to start the search.</param>
	public SearchForVirtualItemEventArgs(bool isTextSearch, bool isPrefixSearch, bool includeSubItemsInSearch, string text, Point startingPoint, SearchDirectionHint direction, int startIndex)
	{
	}
}
