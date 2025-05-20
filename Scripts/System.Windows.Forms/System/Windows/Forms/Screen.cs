using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Represents a display device or multiple display devices on a single system.</summary>
public class Screen
{
	private static Screen[] all_screens;

	private bool primary;

	private Rectangle bounds;

	private Rectangle workarea;

	private string name;

	private int bits_per_pixel;

	/// <summary>Gets the primary display.</summary>
	/// <returns>The primary display.</returns>
	public static Screen PrimaryScreen => null;

	/// <summary>Gets the bounds of the display.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" />, representing the bounds of the display.</returns>
	public Rectangle Bounds => default(Rectangle);

	/// <summary>Gets the device name associated with a display.</summary>
	/// <returns>The device name associated with a display.</returns>
	public string DeviceName => null;

	/// <summary>Gets a value indicating whether a particular display is the primary device.</summary>
	/// <returns>
	///   <see langword="true" /> if this display is primary; otherwise, <see langword="false" />.</returns>
	public bool Primary => false;

	/// <summary>Gets the working area of the display. The working area is the desktop area of the display, excluding taskbars, docked windows, and docked tool bars.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" />, representing the working area of the display.</returns>
	public Rectangle WorkingArea => default(Rectangle);

	private Screen(bool primary, string name, Rectangle bounds, Rectangle workarea)
	{
	}

	/// <summary>Retrieves a <see cref="T:System.Windows.Forms.Screen" /> for the display that contains the largest portion of the specified control.</summary>
	/// <param name="control">A <see cref="T:System.Windows.Forms.Control" /> for which to retrieve a <see cref="T:System.Windows.Forms.Screen" />.</param>
	/// <returns>A <see cref="T:System.Windows.Forms.Screen" /> for the display that contains the largest region of the specified control. In multiple display environments where no display contains the control, the display closest to the specified control is returned.</returns>
	public static Screen FromControl(Control control)
	{
		return null;
	}

	/// <summary>Retrieves a <see cref="T:System.Windows.Forms.Screen" /> for the display that contains the specified point.</summary>
	/// <param name="point">A <see cref="T:System.Drawing.Point" /> that specifies the location for which to retrieve a <see cref="T:System.Windows.Forms.Screen" />.</param>
	/// <returns>A <see cref="T:System.Windows.Forms.Screen" /> for the display that contains the point. In multiple display environments where no display contains the point, the display closest to the specified point is returned.</returns>
	public static Screen FromPoint(Point point)
	{
		return null;
	}

	/// <summary>Retrieves the working area for the display that contains the largest region of the specified control. The working area is the desktop area of the display, excluding taskbars, docked windows, and docked tool bars.</summary>
	/// <param name="ctl">The <see cref="T:System.Windows.Forms.Control" /> for which to retrieve the working area.</param>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that specifies the working area. In multiple display environments where no display contains the specified control, the display closest to the control is returned.</returns>
	public static Rectangle GetWorkingArea(Control ctl)
	{
		return default(Rectangle);
	}

	/// <summary>Gets or sets a value indicating whether the specified object is equal to this <see langword="Screen" />.</summary>
	/// <param name="obj">The object to compare to this <see cref="T:System.Windows.Forms.Screen" />.</param>
	/// <returns>
	///   <see langword="true" /> if the specified object is equal to this <see cref="T:System.Windows.Forms.Screen" />; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Computes and retrieves a hash code for an object.</summary>
	/// <returns>A hash code for an object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Retrieves a string representing this object.</summary>
	/// <returns>A string representation of the object.</returns>
	public override string ToString()
	{
		return null;
	}
}
