using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see langword="Scroll" /> event.</summary>
[ComVisible(true)]
public class ScrollEventArgs : EventArgs
{
	private ScrollEventType type;

	private int new_value;

	private int old_value;

	private ScrollOrientation scroll_orientation;

	/// <summary>Gets or sets the new <see cref="P:System.Windows.Forms.ScrollBar.Value" /> of the scroll bar.</summary>
	/// <returns>The numeric value that the <see cref="P:System.Windows.Forms.ScrollBar.Value" /> property will be changed to.</returns>
	public int NewValue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ScrollEventArgs" /> class using the given values for the <see cref="P:System.Windows.Forms.ScrollEventArgs.Type" /> and <see cref="P:System.Windows.Forms.ScrollEventArgs.NewValue" /> properties.</summary>
	/// <param name="type">One of the <see cref="T:System.Windows.Forms.ScrollEventType" /> values.</param>
	/// <param name="newValue">The new value for the scroll bar.</param>
	public ScrollEventArgs(ScrollEventType type, int newValue)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ScrollEventArgs" /> class using the given values for the <see cref="P:System.Windows.Forms.ScrollEventArgs.Type" />, <see cref="P:System.Windows.Forms.ScrollEventArgs.OldValue" />, <see cref="P:System.Windows.Forms.ScrollEventArgs.NewValue" />, and <see cref="P:System.Windows.Forms.ScrollEventArgs.ScrollOrientation" /> properties.</summary>
	/// <param name="type">One of the <see cref="T:System.Windows.Forms.ScrollEventType" /> values.</param>
	/// <param name="oldValue">The old value for the scroll bar.</param>
	/// <param name="newValue">The new value for the scroll bar.</param>
	/// <param name="scroll">One of the <see cref="T:System.Windows.Forms.ScrollOrientation" /> values.</param>
	public ScrollEventArgs(ScrollEventType type, int oldValue, int newValue, ScrollOrientation scroll)
	{
	}
}
