using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ListView.DrawItem" /> event.</summary>
public class DrawListViewItemEventArgs : EventArgs
{
	private Rectangle bounds;

	private bool drawDefault;

	private Graphics graphics;

	private ListViewItem item;

	private int itemIndex;

	private ListViewItemStates state;

	/// <summary>Gets or sets a property indicating whether the <see cref="T:System.Windows.Forms.ListView" /> control will use the default drawing for the <see cref="T:System.Windows.Forms.ListViewItem" />.</summary>
	/// <returns>
	///   <see langword="true" /> if the system draws the item; <see langword="false" /> if the event handler draws the item. The default value is <see langword="false" />.</returns>
	public bool DrawDefault => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.DrawListViewItemEventArgs" /> class.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> surface on which to draw.</param>
	/// <param name="item">The <see cref="T:System.Windows.Forms.ListViewItem" /> to draw.</param>
	/// <param name="bounds">The <see cref="T:System.Drawing.Rectangle" /> within which to draw.</param>
	/// <param name="itemIndex">The index of the <see cref="T:System.Windows.Forms.ListViewItem" /> within the <see cref="P:System.Windows.Forms.ListView.Items" /> collection.</param>
	/// <param name="state">A bitwise combination of <see cref="T:System.Windows.Forms.ListViewItemStates" /> values indicating the current state of the <see cref="T:System.Windows.Forms.ListViewItem" /> to draw.</param>
	public DrawListViewItemEventArgs(Graphics graphics, ListViewItem item, Rectangle bounds, int itemIndex, ListViewItemStates state)
	{
	}
}
