namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ListView.ItemChecked" /> event of the <see cref="T:System.Windows.Forms.ListView" /> control.</summary>
public class ItemCheckedEventArgs : EventArgs
{
	private ListViewItem item;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ItemCheckedEventArgs" /> class.</summary>
	/// <param name="item">The <see cref="T:System.Windows.Forms.ListViewItem" /> that is being checked or unchecked.</param>
	public ItemCheckedEventArgs(ListViewItem item)
	{
	}
}
