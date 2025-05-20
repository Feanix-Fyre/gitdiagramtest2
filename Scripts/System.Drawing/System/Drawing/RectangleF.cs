using System.ComponentModel;

namespace System.Drawing;

/// <summary>Stores a set of four floating-point numbers that represent the location and size of a rectangle. For more advanced region functions, use a <see cref="T:System.Drawing.Region" /> object.</summary>
[Serializable]
public struct RectangleF : IEquatable<RectangleF>
{
	private float x;

	private float y;

	private float width;

	private float height;

	/// <summary>Gets or sets the coordinates of the upper-left corner of this <see cref="T:System.Drawing.RectangleF" /> structure.</summary>
	/// <returns>A <see cref="T:System.Drawing.PointF" /> that represents the upper-left corner of this <see cref="T:System.Drawing.RectangleF" /> structure.</returns>
	[Browsable(false)]
	public PointF Location
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the size of this <see cref="T:System.Drawing.RectangleF" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.SizeF" /> that represents the width and height of this <see cref="T:System.Drawing.RectangleF" /> structure.</returns>
	[Browsable(false)]
	public SizeF Size
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the x-coordinate of the upper-left corner of this <see cref="T:System.Drawing.RectangleF" /> structure.</summary>
	/// <returns>The x-coordinate of the upper-left corner of this <see cref="T:System.Drawing.RectangleF" /> structure. The default is 0.</returns>
	public float X
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the y-coordinate of the upper-left corner of this <see cref="T:System.Drawing.RectangleF" /> structure.</summary>
	/// <returns>The y-coordinate of the upper-left corner of this <see cref="T:System.Drawing.RectangleF" /> structure. The default is 0.</returns>
	public float Y
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the width of this <see cref="T:System.Drawing.RectangleF" /> structure.</summary>
	/// <returns>The width of this <see cref="T:System.Drawing.RectangleF" /> structure. The default is 0.</returns>
	public float Width
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the height of this <see cref="T:System.Drawing.RectangleF" /> structure.</summary>
	/// <returns>The height of this <see cref="T:System.Drawing.RectangleF" /> structure. The default is 0.</returns>
	public float Height
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	/// <summary>Gets the x-coordinate that is the sum of <see cref="P:System.Drawing.RectangleF.X" /> and <see cref="P:System.Drawing.RectangleF.Width" /> of this <see cref="T:System.Drawing.RectangleF" /> structure.</summary>
	/// <returns>The x-coordinate that is the sum of <see cref="P:System.Drawing.RectangleF.X" /> and <see cref="P:System.Drawing.RectangleF.Width" /> of this <see cref="T:System.Drawing.RectangleF" /> structure.</returns>
	[Browsable(false)]
	public float Right => 0f;

	/// <summary>Gets the y-coordinate that is the sum of <see cref="P:System.Drawing.RectangleF.Y" /> and <see cref="P:System.Drawing.RectangleF.Height" /> of this <see cref="T:System.Drawing.RectangleF" /> structure.</summary>
	/// <returns>The y-coordinate that is the sum of <see cref="P:System.Drawing.RectangleF.Y" /> and <see cref="P:System.Drawing.RectangleF.Height" /> of this <see cref="T:System.Drawing.RectangleF" /> structure.</returns>
	[Browsable(false)]
	public float Bottom => 0f;

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.RectangleF" /> class with the specified location and size.</summary>
	/// <param name="x">The x-coordinate of the upper-left corner of the rectangle.</param>
	/// <param name="y">The y-coordinate of the upper-left corner of the rectangle.</param>
	/// <param name="width">The width of the rectangle.</param>
	/// <param name="height">The height of the rectangle.</param>
	public RectangleF(float x, float y, float width, float height)
	{
		this.x = 0f;
		this.y = 0f;
		this.width = 0f;
		this.height = 0f;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.RectangleF" /> class with the specified location and size.</summary>
	/// <param name="location">A <see cref="T:System.Drawing.PointF" /> that represents the upper-left corner of the rectangular region.</param>
	/// <param name="size">A <see cref="T:System.Drawing.SizeF" /> that represents the width and height of the rectangular region.</param>
	public RectangleF(PointF location, SizeF size)
	{
		x = 0f;
		y = 0f;
		width = 0f;
		height = 0f;
	}

	/// <summary>Tests whether <paramref name="obj" /> is a <see cref="T:System.Drawing.RectangleF" /> with the same location and size of this <see cref="T:System.Drawing.RectangleF" />.</summary>
	/// <param name="obj">The <see cref="T:System.Object" /> to test.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.Drawing.RectangleF" /> and its <see langword="X" />, <see langword="Y" />, <see langword="Width" />, and <see langword="Height" /> properties are equal to the corresponding properties of this <see cref="T:System.Drawing.RectangleF" />; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(RectangleF other)
	{
		return false;
	}

	/// <summary>Tests whether two <see cref="T:System.Drawing.RectangleF" /> structures have equal location and size.</summary>
	/// <param name="left">The <see cref="T:System.Drawing.RectangleF" /> structure that is to the left of the equality operator.</param>
	/// <param name="right">The <see cref="T:System.Drawing.RectangleF" /> structure that is to the right of the equality operator.</param>
	/// <returns>
	///   <see langword="true" /> if the two specified <see cref="T:System.Drawing.RectangleF" /> structures have equal <see cref="P:System.Drawing.RectangleF.X" />, <see cref="P:System.Drawing.RectangleF.Y" />, <see cref="P:System.Drawing.RectangleF.Width" />, and <see cref="P:System.Drawing.RectangleF.Height" /> properties; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(RectangleF left, RectangleF right)
	{
		return false;
	}

	/// <summary>Gets the hash code for this <see cref="T:System.Drawing.RectangleF" /> structure. For information about the use of hash codes, see <see langword="Object.GetHashCode" />.</summary>
	/// <returns>The hash code for this <see cref="T:System.Drawing.RectangleF" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Converts the specified <see cref="T:System.Drawing.Rectangle" /> structure to a <see cref="T:System.Drawing.RectangleF" /> structure.</summary>
	/// <param name="r">The <see cref="T:System.Drawing.Rectangle" /> structure to convert.</param>
	/// <returns>The <see cref="T:System.Drawing.RectangleF" /> structure that is converted from the specified <see cref="T:System.Drawing.Rectangle" /> structure.</returns>
	public static implicit operator RectangleF(Rectangle r)
	{
		return default(RectangleF);
	}

	/// <summary>Converts the <see langword="Location" /> and <see cref="T:System.Drawing.Size" /> of this <see cref="T:System.Drawing.RectangleF" /> to a human-readable string.</summary>
	/// <returns>A string that contains the position, width, and height of this <see cref="T:System.Drawing.RectangleF" /> structure. For example, "{X=20, Y=20, Width=100, Height=50}".</returns>
	public override string ToString()
	{
		return null;
	}
}
