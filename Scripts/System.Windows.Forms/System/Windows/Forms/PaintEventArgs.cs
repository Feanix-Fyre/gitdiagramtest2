using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Control.Paint" /> event.</summary>
public class PaintEventArgs : EventArgs, IDisposable
{
	private Graphics graphics;

	private Rectangle clip_rectangle;

	internal bool Handled;

	private bool disposed;

	/// <summary>Gets the rectangle in which to paint.</summary>
	/// <returns>The <see cref="T:System.Drawing.Rectangle" /> in which to paint.</returns>
	public Rectangle ClipRectangle => default(Rectangle);

	/// <summary>Gets the graphics used to paint.</summary>
	/// <returns>The <see cref="T:System.Drawing.Graphics" /> object used to paint. The <see cref="T:System.Drawing.Graphics" /> object provides methods for drawing objects on the display device.</returns>
	public Graphics Graphics => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.PaintEventArgs" /> class with the specified graphics and clipping rectangle.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> used to paint the item.</param>
	/// <param name="clipRect">The <see cref="T:System.Drawing.Rectangle" /> that represents the rectangle in which to paint.</param>
	public PaintEventArgs(Graphics graphics, Rectangle clipRect)
	{
	}

	/// <summary>Releases all resources used by the <see cref="T:System.Windows.Forms.PaintEventArgs" />.</summary>
	public void Dispose()
	{
	}

	internal Graphics SetGraphics(Graphics g)
	{
		return null;
	}

	internal void SetClip(Rectangle clip)
	{
	}

	/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
	~PaintEventArgs()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.PaintEventArgs" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}
}
