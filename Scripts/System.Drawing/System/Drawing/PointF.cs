namespace System.Drawing;

/// <summary>Represents an ordered pair of floating-point x- and y-coordinates that defines a point in a two-dimensional plane.</summary>
[Serializable]
public struct PointF : IEquatable<PointF>
{
	private float x;

	private float y;

	/// <summary>Gets or sets the x-coordinate of this <see cref="T:System.Drawing.PointF" />.</summary>
	/// <returns>The x-coordinate of this <see cref="T:System.Drawing.PointF" />.</returns>
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

	/// <summary>Gets or sets the y-coordinate of this <see cref="T:System.Drawing.PointF" />.</summary>
	/// <returns>The y-coordinate of this <see cref="T:System.Drawing.PointF" />.</returns>
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

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.PointF" /> class with the specified coordinates.</summary>
	/// <param name="x">The horizontal position of the point.</param>
	/// <param name="y">The vertical position of the point.</param>
	public PointF(float x, float y)
	{
		this.x = 0f;
		this.y = 0f;
	}

	/// <summary>Compares two <see cref="T:System.Drawing.PointF" /> structures. The result specifies whether the values of the <see cref="P:System.Drawing.PointF.X" /> and <see cref="P:System.Drawing.PointF.Y" /> properties of the two <see cref="T:System.Drawing.PointF" /> structures are equal.</summary>
	/// <param name="left">A <see cref="T:System.Drawing.PointF" /> to compare.</param>
	/// <param name="right">A <see cref="T:System.Drawing.PointF" /> to compare.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="P:System.Drawing.PointF.X" /> and <see cref="P:System.Drawing.PointF.Y" /> values of the left and right <see cref="T:System.Drawing.PointF" /> structures are equal; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(PointF left, PointF right)
	{
		return false;
	}

	/// <summary>Specifies whether this <see cref="T:System.Drawing.PointF" /> contains the same coordinates as the specified <see cref="T:System.Object" />.</summary>
	/// <param name="obj">The <see cref="T:System.Object" /> to test.</param>
	/// <returns>This method returns <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.Drawing.PointF" /> and has the same coordinates as this <see cref="T:System.Drawing.Point" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(PointF other)
	{
		return false;
	}

	/// <summary>Returns a hash code for this <see cref="T:System.Drawing.PointF" /> structure.</summary>
	/// <returns>An integer value that specifies a hash value for this <see cref="T:System.Drawing.PointF" /> structure.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Converts this <see cref="T:System.Drawing.PointF" /> to a human readable string.</summary>
	/// <returns>A string that represents this <see cref="T:System.Drawing.PointF" />.</returns>
	public override string ToString()
	{
		return null;
	}
}
