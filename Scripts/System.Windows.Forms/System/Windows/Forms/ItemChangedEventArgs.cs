namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.CurrencyManager.ItemChanged" /> event.</summary>
public class ItemChangedEventArgs : EventArgs
{
	private int index;

	/// <summary>Indicates the position of the item being changed within the list.</summary>
	/// <returns>The zero-based index to the item being changed.</returns>
	public int Index => 0;

	internal ItemChangedEventArgs(int index)
	{
	}
}
