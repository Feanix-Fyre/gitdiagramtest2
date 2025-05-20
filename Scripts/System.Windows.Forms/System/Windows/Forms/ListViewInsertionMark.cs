using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Used to indicate the expected drop location when an item is dragged to a new position in a <see cref="T:System.Windows.Forms.ListView" /> control. This functionality is available only on Windows XP and later.</summary>
public sealed class ListViewInsertionMark
{
	private ListView listview_owner;

	private Rectangle bounds;

	private Color? color;

	private int index;

	/// <summary>Gets the bounding rectangle of the insertion mark.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that represents the position and size of the insertion mark.</returns>
	public Rectangle Bounds => default(Rectangle);

	/// <summary>Gets or sets the color of the insertion mark.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> value that represents the color of the insertion mark. The default value is the value of the <see cref="P:System.Windows.Forms.ListView.ForeColor" /> property.</returns>
	public Color Color => default(Color);

	/// <summary>Gets or sets the index of the item next to which the insertion mark appears.</summary>
	/// <returns>The index of the item next to which the insertion mark appears or -1 when the insertion mark is hidden.</returns>
	public int Index => 0;

	internal PointF[] TopTriangle => null;

	internal PointF[] BottomTriangle => null;

	internal Rectangle Line => default(Rectangle);

	internal ListViewInsertionMark(ListView listview)
	{
	}
}
