namespace System.Drawing;

/// <summary>Defines a brush of a single color. Brushes are used to fill graphics shapes, such as rectangles, ellipses, pies, polygons, and paths. This class cannot be inherited.</summary>
public sealed class SolidBrush : Brush
{
	private Color _color;

	private bool _immutable;

	/// <summary>Initializes a new <see cref="T:System.Drawing.SolidBrush" /> object of the specified color.</summary>
	/// <param name="color">A <see cref="T:System.Drawing.Color" /> structure that represents the color of this brush.</param>
	public SolidBrush(Color color)
	{
	}

	internal SolidBrush(Color color, bool immutable)
	{
	}

	internal SolidBrush(IntPtr nativeBrush)
	{
	}

	/// <summary>Creates an exact copy of this <see cref="T:System.Drawing.SolidBrush" /> object.</summary>
	/// <returns>The <see cref="T:System.Drawing.SolidBrush" /> object that this method creates.</returns>
	public override object Clone()
	{
		return null;
	}

	protected override void Dispose(bool disposing)
	{
	}
}
