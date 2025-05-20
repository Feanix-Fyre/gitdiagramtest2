namespace System.Drawing;

/// <summary>Represents an ordered pair of integer x- and y-coordinates that defines a point in a two-dimensional plane.</summary>
[Serializable]
public struct Point : IEquatable<Point>
{
	/// <summary>Represents a <see cref="T:System.Drawing.Point" /> that has <see cref="P:System.Drawing.Point.X" /> and <see cref="P:System.Drawing.Point.Y" /> values set to zero.</summary>
	public static readonly Point Empty;

	private int x;

	private int y;

	/// <summary>Gets or sets the x-coordinate of this <see cref="T:System.Drawing.Point" />.</summary>
	/// <returns>The x-coordinate of this <see cref="T:System.Drawing.Point" />.</returns>
	public int X
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the y-coordinate of this <see cref="T:System.Drawing.Point" />.</summary>
	/// <returns>The y-coordinate of this <see cref="T:System.Drawing.Point" />.</returns>
	public int Y
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Point" /> class with the specified coordinates.</summary>
	/// <param name="x">The horizontal position of the point.</param>
	/// <param name="y">The vertical position of the point.</param>
	public Point(int x, int y)
	{
		this.x = 0;
		this.y = 0;
	}

	/// <summary>Converts the specified <see cref="T:System.Drawing.Point" /> structure to a <see cref="T:System.Drawing.PointF" /> structure.</summary>
	/// <param name="p">The <see cref="T:System.Drawing.Point" /> to be converted.</param>
	/// <returns>The <see cref="T:System.Drawing.PointF" /> that results from the conversion.</returns>
	public static implicit operator PointF(Point p)
	{
		return default(PointF);
	}

	/// <summary>Translates a <see cref="T:System.Drawing.Point" /> by a given <see cref="T:System.Drawing.Size" />.</summary>
	/// <param name="pt">The <see cref="T:System.Drawing.Point" /> to translate.</param>
	/// <param name="sz">A <see cref="T:System.Drawing.Size" /> that specifies the pair of numbers to add to the coordinates of <paramref name="pt" />.</param>
	/// <returns>The translated <see cref="T:System.Drawing.Point" />.</returns>
	public static Point operator +(Point pt, Size sz)
	{
		return default(Point);
	}

	/// <summary>Compares two <see cref="T:System.Drawing.Point" /> objects. The result specifies whether the values of the <see cref="P:System.Drawing.Point.X" /> and <see cref="P:System.Drawing.Point.Y" /> properties of the two <see cref="T:System.Drawing.Point" /> objects are equal.</summary>
	/// <param name="left">A <see cref="T:System.Drawing.Point" /> to compare.</param>
	/// <param name="right">A <see cref="T:System.Drawing.Point" /> to compare.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="P:System.Drawing.Point.X" /> and <see cref="P:System.Drawing.Point.Y" /> values of <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(Point left, Point right)
	{
		return false;
	}

	/// <summary>Compares two <see cref="T:System.Drawing.Point" /> objects. The result specifies whether the values of the <see cref="P:System.Drawing.Point.X" /> or <see cref="P:System.Drawing.Point.Y" /> properties of the two <see cref="T:System.Drawing.Point" /> objects are unequal.</summary>
	/// <param name="left">A <see cref="T:System.Drawing.Point" /> to compare.</param>
	/// <param name="right">A <see cref="T:System.Drawing.Point" /> to compare.</param>
	/// <returns>
	///   <see langword="true" /> if the values of either the <see cref="P:System.Drawing.Point.X" /> properties or the <see cref="P:System.Drawing.Point.Y" /> properties of <paramref name="left" /> and <paramref name="right" /> differ; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(Point left, Point right)
	{
		return false;
	}

	/// <summary>Adds the specified <see cref="T:System.Drawing.Size" /> to the specified <see cref="T:System.Drawing.Point" />.</summary>
	/// <param name="pt">The <see cref="T:System.Drawing.Point" /> to add.</param>
	/// <param name="sz">The <see cref="T:System.Drawing.Size" /> to add</param>
	/// <returns>The <see cref="T:System.Drawing.Point" /> that is the result of the addition operation.</returns>
	public static Point Add(Point pt, Size sz)
	{
		return default(Point);
	}

	/// <summary>Specifies whether this <see cref="T:System.Drawing.Point" /> contains the same coordinates as the specified <see cref="T:System.Object" />.</summary>
	/// <param name="obj">The <see cref="T:System.Object" /> to test.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.Drawing.Point" /> and has the same coordinates as this <see cref="T:System.Drawing.Point" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(Point other)
	{
		return false;
	}

	/// <summary>Returns a hash code for this <see cref="T:System.Drawing.Point" />.</summary>
	/// <returns>An integer value that specifies a hash value for this <see cref="T:System.Drawing.Point" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Translates this <see cref="T:System.Drawing.Point" /> by the specified amount.</summary>
	/// <param name="dx">The amount to offset the x-coordinate.</param>
	/// <param name="dy">The amount to offset the y-coordinate.</param>
	public void Offset(int dx, int dy)
	{
	}

	/// <summary>Converts this <see cref="T:System.Drawing.Point" /> to a human-readable string.</summary>
	/// <returns>A string that represents this <see cref="T:System.Drawing.Point" />.</returns>
	public override string ToString()
	{
		return null;
	}
}
