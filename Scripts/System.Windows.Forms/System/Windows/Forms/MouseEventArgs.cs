using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Control.MouseUp" />, <see cref="E:System.Windows.Forms.Control.MouseDown" />, and <see cref="E:System.Windows.Forms.Control.MouseMove" /> events.</summary>
[ComVisible(true)]
public class MouseEventArgs : EventArgs
{
	private MouseButtons buttons;

	private int clicks;

	private int delta;

	private int x;

	private int y;

	/// <summary>Gets which mouse button was pressed.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.MouseButtons" /> values.</returns>
	public MouseButtons Button => default(MouseButtons);

	/// <summary>Gets the number of times the mouse button was pressed and released.</summary>
	/// <returns>An <see cref="T:System.Int32" /> that contains the number of times the mouse button was pressed and released.</returns>
	public int Clicks => 0;

	/// <summary>Gets a signed count of the number of detents the mouse wheel has rotated, multiplied by the WHEEL_DELTA constant. A detent is one notch of the mouse wheel.</summary>
	/// <returns>A signed count of the number of detents the mouse wheel has rotated, multiplied by the WHEEL_DELTA constant.</returns>
	public int Delta => 0;

	/// <summary>Gets the x-coordinate of the mouse during the generating mouse event.</summary>
	/// <returns>The x-coordinate of the mouse, in pixels.</returns>
	public int X => 0;

	/// <summary>Gets the y-coordinate of the mouse during the generating mouse event.</summary>
	/// <returns>The y-coordinate of the mouse, in pixels.</returns>
	public int Y => 0;

	/// <summary>Gets the location of the mouse during the generating mouse event.</summary>
	/// <returns>A <see cref="T:System.Drawing.Point" /> that contains the x- and y- mouse coordinates, in pixels, relative to the upper-left corner of the form.</returns>
	public Point Location => default(Point);

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.MouseEventArgs" /> class.</summary>
	/// <param name="button">One of the <see cref="T:System.Windows.Forms.MouseButtons" /> values that indicate which mouse button was pressed.</param>
	/// <param name="clicks">The number of times a mouse button was pressed.</param>
	/// <param name="x">The x-coordinate of a mouse click, in pixels.</param>
	/// <param name="y">The y-coordinate of a mouse click, in pixels.</param>
	/// <param name="delta">A signed count of the number of detents the wheel has rotated.</param>
	public MouseEventArgs(MouseButtons button, int clicks, int x, int y, int delta)
	{
	}
}
