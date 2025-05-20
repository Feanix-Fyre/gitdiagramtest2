using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ListView.ItemMouseHover" /> event.</summary>
[ComVisible(true)]
public class ListViewItemMouseHoverEventArgs : EventArgs
{
	private ListViewItem item;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ListViewItemMouseHoverEventArgs" /> class.</summary>
	/// <param name="item">The <see cref="T:System.Windows.Forms.ListViewItem" /> the mouse pointer is currently hovering over.</param>
	public ListViewItemMouseHoverEventArgs(ListViewItem item)
	{
	}
}
