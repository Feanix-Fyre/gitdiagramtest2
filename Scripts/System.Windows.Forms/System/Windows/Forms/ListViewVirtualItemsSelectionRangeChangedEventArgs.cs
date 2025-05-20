namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ListView.VirtualItemsSelectionRangeChanged" /> event.</summary>
public class ListViewVirtualItemsSelectionRangeChangedEventArgs : EventArgs
{
	private bool is_selected;

	private int end_index;

	private int start_index;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListViewVirtualItemsSelectionRangeChangedEventArgs" /> class.</summary>
	/// <param name="startIndex">The index of the first item in the range that has changed.</param>
	/// <param name="endIndex">The index of the last item in the range that has changed.</param>
	/// <param name="isSelected">
	///   <see langword="true" /> to indicate the items are selected; <see langword="false" /> to indicate the items are deselected.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="startIndex" /> is larger than <paramref name="endIndex." /></exception>
	public ListViewVirtualItemsSelectionRangeChangedEventArgs(int startIndex, int endIndex, bool isSelected)
	{
	}
}
