namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ListView.RetrieveVirtualItem" /> event.</summary>
public class RetrieveVirtualItemEventArgs : EventArgs
{
	private ListViewItem item;

	private int item_index;

	/// <summary>Gets or sets the item retrieved from the cache.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.ListViewItem" /> retrieved from the cache.</returns>
	public ListViewItem Item => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.RetrieveVirtualItemEventArgs" /> class.</summary>
	/// <param name="itemIndex">The index of the item to retrieve.</param>
	public RetrieveVirtualItemEventArgs(int itemIndex)
	{
	}
}
