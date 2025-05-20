namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ListView.ItemSelectionChanged" /> event.</summary>
public class ListViewItemSelectionChangedEventArgs : EventArgs
{
	private bool is_selected;

	private ListViewItem item;

	private int item_index;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListViewItemSelectionChangedEventArgs" /> class.</summary>
	/// <param name="item">The <see cref="T:System.Windows.Forms.ListViewItem" /> whose selection state has changed.</param>
	/// <param name="itemIndex">The index of the <see cref="T:System.Windows.Forms.ListViewItem" /> whose selection state has changed.</param>
	/// <param name="isSelected">
	///   <see langword="true" /> to indicate the item's state has changed to selected; <see langword="false" /> to indicate the item's state has changed to deselected.</param>
	public ListViewItemSelectionChangedEventArgs(ListViewItem item, int itemIndex, bool isSelected)
	{
	}
}
