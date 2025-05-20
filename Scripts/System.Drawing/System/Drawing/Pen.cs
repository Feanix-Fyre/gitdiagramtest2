using System.Drawing.Drawing2D;

namespace System.Drawing;

/// <summary>Defines an object used to draw lines and curves. This class cannot be inherited.</summary>
public sealed class Pen : MarshalByRefObject, ICloneable, IDisposable
{
	internal IntPtr nativeObject;

	internal bool isModifiable;

	private Color color;

	private CustomLineCap startCap;

	private CustomLineCap endCap;

	/// <summary>Gets or sets the style used for dashed lines drawn with this <see cref="T:System.Drawing.Pen" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Drawing2D.DashStyle" /> that represents the style used for dashed lines drawn with this <see cref="T:System.Drawing.Pen" />.</returns>
	/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Drawing.Pen.DashStyle" /> property is set on an immutable <see cref="T:System.Drawing.Pen" />, such as those returned by the <see cref="T:System.Drawing.Pens" /> class.</exception>
	public DashStyle DashStyle
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the width of this <see cref="T:System.Drawing.Pen" />, in units of the <see cref="T:System.Drawing.Graphics" /> object used for drawing.</summary>
	/// <returns>The width of this <see cref="T:System.Drawing.Pen" />.</returns>
	/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Drawing.Pen.Width" /> property is set on an immutable <see cref="T:System.Drawing.Pen" />, such as those returned by the <see cref="T:System.Drawing.Pens" /> class.</exception>
	public float Width => 0f;

	internal IntPtr NativePen => (IntPtr)0;

	internal Pen(IntPtr p)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Pen" /> class with the specified <see cref="T:System.Drawing.Brush" />.</summary>
	/// <param name="brush">A <see cref="T:System.Drawing.Brush" /> that determines the fill properties of this <see cref="T:System.Drawing.Pen" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="brush" /> is <see langword="null" />.</exception>
	public Pen(Brush brush)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Pen" /> class with the specified color.</summary>
	/// <param name="color">A <see cref="T:System.Drawing.Color" /> structure that indicates the color of this <see cref="T:System.Drawing.Pen" />.</param>
	public Pen(Color color)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Pen" /> class with the specified <see cref="T:System.Drawing.Brush" /> and <see cref="P:System.Drawing.Pen.Width" />.</summary>
	/// <param name="brush">A <see cref="T:System.Drawing.Brush" /> that determines the characteristics of this <see cref="T:System.Drawing.Pen" />.</param>
	/// <param name="width">The width of the new <see cref="T:System.Drawing.Pen" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="brush" /> is <see langword="null" />.</exception>
	public Pen(Brush brush, float width)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Pen" /> class with the specified <see cref="T:System.Drawing.Color" /> and <see cref="P:System.Drawing.Pen.Width" /> properties.</summary>
	/// <param name="color">A <see cref="T:System.Drawing.Color" /> structure that indicates the color of this <see cref="T:System.Drawing.Pen" />.</param>
	/// <param name="width">A value indicating the width of this <see cref="T:System.Drawing.Pen" />.</param>
	public Pen(Color color, float width)
	{
	}

	/// <summary>Creates an exact copy of this <see cref="T:System.Drawing.Pen" />.</summary>
	/// <returns>An <see cref="T:System.Object" /> that can be cast to a <see cref="T:System.Drawing.Pen" />.</returns>
	public object Clone()
	{
		return null;
	}

	/// <summary>Releases all resources used by this <see cref="T:System.Drawing.Pen" />.</summary>
	public void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
	~Pen()
	{
	}
}
