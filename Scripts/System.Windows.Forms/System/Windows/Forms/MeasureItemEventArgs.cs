using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see langword="MeasureItem" /> event of the <see cref="T:System.Windows.Forms.ListBox" />, <see cref="T:System.Windows.Forms.ComboBox" />, <see cref="T:System.Windows.Forms.CheckedListBox" />, and <see cref="T:System.Windows.Forms.MenuItem" /> controls.</summary>
public class MeasureItemEventArgs : EventArgs
{
	private Graphics graphics;

	private int index;

	private int itemHeight;

	private int itemWidth;

	/// <summary>Gets or sets the height of the item specified by the <see cref="P:System.Windows.Forms.MeasureItemEventArgs.Index" />.</summary>
	/// <returns>The height of the item measured.</returns>
	public int ItemHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the width of the item specified by the <see cref="P:System.Windows.Forms.MeasureItemEventArgs.Index" />.</summary>
	/// <returns>The width of the item measured.</returns>
	public int ItemWidth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.MeasureItemEventArgs" /> class.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> object being written to.</param>
	/// <param name="index">The index of the item for which you need the height or width.</param>
	public MeasureItemEventArgs(Graphics graphics, int index)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.MeasureItemEventArgs" /> class providing a parameter for the item height.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> object being written to.</param>
	/// <param name="index">The index of the item for which you need the height or width.</param>
	/// <param name="itemHeight">The height of the item to measure relative to the <paramref name="graphics" /> object.</param>
	public MeasureItemEventArgs(Graphics graphics, int index, int itemHeight)
	{
	}
}
