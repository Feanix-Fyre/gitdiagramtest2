using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.CheckedListBox.ItemCheck" /> event of the <see cref="T:System.Windows.Forms.CheckedListBox" /> and <see cref="T:System.Windows.Forms.ListView" /> controls.</summary>
[ComVisible(true)]
public class ItemCheckEventArgs : EventArgs
{
	private CheckState currentValue;

	private int index;

	private CheckState newValue;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ItemCheckEventArgs" /> class.</summary>
	/// <param name="index">The zero-based index of the item to change.</param>
	/// <param name="newCheckValue">One of the <see cref="T:System.Windows.Forms.CheckState" /> values that indicates whether to change the check box for the item to be checked, unchecked, or indeterminate.</param>
	/// <param name="currentValue">One of the <see cref="T:System.Windows.Forms.CheckState" /> values that indicates whether the check box for the item is currently checked, unchecked, or indeterminate.</param>
	public ItemCheckEventArgs(int index, CheckState newCheckValue, CheckState currentValue)
	{
	}
}
