using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ListView.ItemDrag" /> event of the <see cref="T:System.Windows.Forms.ListView" /> and <see cref="T:System.Windows.Forms.TreeView" /> controls.</summary>
[ComVisible(true)]
public class ItemDragEventArgs : EventArgs
{
	private MouseButtons button;

	private object item;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ItemDragEventArgs" /> class with a specified mouse button and the item that is being dragged.</summary>
	/// <param name="button">A bitwise combination of <see cref="T:System.Windows.Forms.MouseButtons" /> values that indicates which mouse buttons were pressed.</param>
	/// <param name="item">The item being dragged.</param>
	public ItemDragEventArgs(MouseButtons button, object item)
	{
	}
}
