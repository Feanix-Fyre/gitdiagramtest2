using System.ComponentModel;

namespace System.Drawing;

/// <summary>Stores a set of four integers that represent the location and size of a rectangle</summary>
[Serializable]
public struct Rectangle : IEquatable<Rectangle>
{
	/// <summary>Represents a <see cref="T:System.Drawing.Rectangle" /> structure with its properties left uninitialized.</summary>
	public static readonly Rectangle Empty;

	private int x;

	private int y;

	private int width;

	private int height;

	/// <summary>Gets or sets the coordinates of the upper-left corner of this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <returns>A <see cref="T:System.Drawing.Point" /> that represents the upper-left corner of this <see cref="T:System.Drawing.Rectangle" /> structure.</returns>
	[Browsable(false)]
	public Point Location
	{
		get
		{
			return default(Point);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the size of this <see cref="T:System.Drawing.Rectangle" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Size" /> that represents the width and height of this <see cref="T:System.Drawing.Rectangle" /> structure.</returns>
	[Browsable(false)]
	public Size Size
	{
		get
		{
			return default(Size);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the x-coordinate of the upper-left corner of this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <returns>The x-coordinate of the upper-left corner of this <see cref="T:System.Drawing.Rectangle" /> structure. The default is 0.</returns>
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

	/// <summary>Gets or sets the y-coordinate of the upper-left corner of this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <returns>The y-coordinate of the upper-left corner of this <see cref="T:System.Drawing.Rectangle" /> structure. The default is 0.</returns>
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

	/// <summary>Gets or sets the width of this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <returns>The width of this <see cref="T:System.Drawing.Rectangle" /> structure. The default is 0.</returns>
	public int Width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the height of this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <returns>The height of this <see cref="T:System.Drawing.Rectangle" /> structure. The default is 0.</returns>
	public int Height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets the x-coordinate of the left edge of this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <returns>The x-coordinate of the left edge of this <see cref="T:System.Drawing.Rectangle" /> structure.</returns>
	[Browsable(false)]
	public int Left => 0;

	/// <summary>Gets the y-coordinate of the top edge of this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <returns>The y-coordinate of the top edge of this <see cref="T:System.Drawing.Rectangle" /> structure.</returns>
	[Browsable(false)]
	public int Top => 0;

	/// <summary>Gets the x-coordinate that is the sum of <see cref="P:System.Drawing.Rectangle.X" /> and <see cref="P:System.Drawing.Rectangle.Width" /> property values of this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <returns>The x-coordinate that is the sum of <see cref="P:System.Drawing.Rectangle.X" /> and <see cref="P:System.Drawing.Rectangle.Width" /> of this <see cref="T:System.Drawing.Rectangle" />.</returns>
	[Browsable(false)]
	public int Right => 0;

	/// <summary>Gets the y-coordinate that is the sum of the <see cref="P:System.Drawing.Rectangle.Y" /> and <see cref="P:System.Drawing.Rectangle.Height" /> property values of this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <returns>The y-coordinate that is the sum of <see cref="P:System.Drawing.Rectangle.Y" /> and <see cref="P:System.Drawing.Rectangle.Height" /> of this <see cref="T:System.Drawing.Rectangle" />.</returns>
	[Browsable(false)]
	public int Bottom => 0;

	/// <summary>Tests whether all numeric properties of this <see cref="T:System.Drawing.Rectangle" /> have values of zero.</summary>
	/// <returns>This property returns <see langword="true" /> if the <see cref="P:System.Drawing.Rectangle.Width" />, <see cref="P:System.Drawing.Rectangle.Height" />, <see cref="P:System.Drawing.Rectangle.X" />, and <see cref="P:System.Drawing.Rectangle.Y" /> properties of this <see cref="T:System.Drawing.Rectangle" /> all have values of zero; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	public bool IsEmpty => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Rectangle" /> class with the specified location and size.</summary>
	/// <param name="x">The x-coordinate of the upper-left corner of the rectangle.</param>
	/// <param name="y">The y-coordinate of the upper-left corner of the rectangle.</param>
	/// <param name="width">The width of the rectangle.</param>
	/// <param name="height">The height of the rectangle.</param>
	public Rectangle(int x, int y, int width, int height)
	{
		this.x = 0;
		this.y = 0;
		this.width = 0;
		this.height = 0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Rectangle" /> class with the specified location and size.</summary>
	/// <param name="location">A <see cref="T:System.Drawing.Point" /> that represents the upper-left corner of the rectangular region.</param>
	/// <param name="size">A <see cref="T:System.Drawing.Size" /> that represents the width and height of the rectangular region.</param>
	public Rectangle(Point location, Size size)
	{
		x = 0;
		y = 0;
		width = 0;
		height = 0;
	}

	/// <summary>Creates a <see cref="T:System.Drawing.Rectangle" /> structure with the specified edge locations.</summary>
	/// <param name="left">The x-coordinate of the upper-left corner of this <see cref="T:System.Drawing.Rectangle" /> structure.</param>
	/// <param name="top">The y-coordinate of the upper-left corner of this <see cref="T:System.Drawing.Rectangle" /> structure.</param>
	/// <param name="right">The x-coordinate of the lower-right corner of this <see cref="T:System.Drawing.Rectangle" /> structure.</param>
	/// <param name="bottom">The y-coordinate of the lower-right corner of this <see cref="T:System.Drawing.Rectangle" /> structure.</param>
	/// <returns>The new <see cref="T:System.Drawing.Rectangle" /> that this method creates.</returns>
	public static Rectangle FromLTRB(int left, int top, int right, int bottom)
	{
		return default(Rectangle);
	}

	/// <summary>Tests whether <paramref name="obj" /> is a <see cref="T:System.Drawing.Rectangle" /> structure with the same location and size of this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <param name="obj">The <see cref="T:System.Object" /> to test.</param>
	/// <returns>This method returns <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.Drawing.Rectangle" /> structure and its <see cref="P:System.Drawing.Rectangle.X" />, <see cref="P:System.Drawing.Rectangle.Y" />, <see cref="P:System.Drawing.Rectangle.Width" />, and <see cref="P:System.Drawing.Rectangle.Height" /> properties are equal to the corresponding properties of this <see cref="T:System.Drawing.Rectangle" /> structure; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(Rectangle other)
	{
		return false;
	}

	/// <summary>Tests whether two <see cref="T:System.Drawing.Rectangle" /> structures have equal location and size.</summary>
	/// <param name="left">The <see cref="T:System.Drawing.Rectangle" /> structure that is to the left of the equality operator.</param>
	/// <param name="right">The <see cref="T:System.Drawing.Rectangle" /> structure that is to the right of the equality operator.</param>
	/// <returns>This operator returns <see langword="true" /> if the two <see cref="T:System.Drawing.Rectangle" /> structures have equal <see cref="P:System.Drawing.Rectangle.X" />, <see cref="P:System.Drawing.Rectangle.Y" />, <see cref="P:System.Drawing.Rectangle.Width" />, and <see cref="P:System.Drawing.Rectangle.Height" /> properties.</returns>
	public static bool operator ==(Rectangle left, Rectangle right)
	{
		return false;
	}

	/// <summary>Tests whether two <see cref="T:System.Drawing.Rectangle" /> structures differ in location or size.</summary>
	/// <param name="left">The <see cref="T:System.Drawing.Rectangle" /> structure that is to the left of the inequality operator.</param>
	/// <param name="right">The <see cref="T:System.Drawing.Rectangle" /> structure that is to the right of the inequality operator.</param>
	/// <returns>This operator returns <see langword="true" /> if any of the <see cref="P:System.Drawing.Rectangle.X" />, <see cref="P:System.Drawing.Rectangle.Y" />, <see cref="P:System.Drawing.Rectangle.Width" /> or <see cref="P:System.Drawing.Rectangle.Height" /> properties of the two <see cref="T:System.Drawing.Rectangle" /> structures are unequal; otherwise <see langword="false" />.</returns>
	public static bool operator !=(Rectangle left, Rectangle right)
	{
		return false;
	}

	/// <summary>Determines if the specified point is contained within this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <param name="x">The x-coordinate of the point to test.</param>
	/// <param name="y">The y-coordinate of the point to test.</param>
	/// <returns>This method returns <see langword="true" /> if the point defined by <paramref name="x" /> and <paramref name="y" /> is contained within this <see cref="T:System.Drawing.Rectangle" /> structure; otherwise <see langword="false" />.</returns>
	public bool Contains(int x, int y)
	{
		return false;
	}

	/// <summary>Determines if the specified point is contained within this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <param name="pt">The <see cref="T:System.Drawing.Point" /> to test.</param>
	/// <returns>This method returns <see langword="true" /> if the point represented by <paramref name="pt" /> is contained within this <see cref="T:System.Drawing.Rectangle" /> structure; otherwise <see langword="false" />.</returns>
	public bool Contains(Point pt)
	{
		return false;
	}

	/// <summary>Determines if the rectangular region represented by <paramref name="rect" /> is entirely contained within this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
	/// <param name="rect">The <see cref="T:System.Drawing.Rectangle" /> to test.</param>
	/// <returns>This method returns <see langword="true" /> if the rectangular region represented by <paramref name="rect" /> is entirely contained within this <see cref="T:System.Drawing.Rectangle" /> structure; otherwise <see langword="false" />.</returns>
	public bool Contains(Rectangle rect)
	{
		return false;
	}

	/// <summary>Returns the hash code for this <see cref="T:System.Drawing.Rectangle" /> structure. For information about the use of hash codes, see <see cref="M:System.Object.GetHashCode" /> .</summary>
	/// <returns>An integer that represents the hash code for this rectangle.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Enlarges this <see cref="T:System.Drawing.Rectangle" /> by the specified amount.</summary>
	/// <param name="width">The amount to inflate this <see cref="T:System.Drawing.Rectangle" /> horizontally.</param>
	/// <param name="height">The amount to inflate this <see cref="T:System.Drawing.Rectangle" /> vertically.</param>
	public void Inflate(int width, int height)
	{
	}

	/// <summary>Creates and returns an enlarged copy of the specified <see cref="T:System.Drawing.Rectangle" /> structure. The copy is enlarged by the specified amount. The original <see cref="T:System.Drawing.Rectangle" /> structure remains unmodified.</summary>
	/// <param name="rect">The <see cref="T:System.Drawing.Rectangle" /> with which to start. This rectangle is not modified.</param>
	/// <param name="x">The amount to inflate this <see cref="T:System.Drawing.Rectangle" /> horizontally.</param>
	/// <param name="y">The amount to inflate this <see cref="T:System.Drawing.Rectangle" /> vertically.</param>
	/// <returns>The enlarged <see cref="T:System.Drawing.Rectangle" />.</returns>
	public static Rectangle Inflate(Rectangle rect, int x, int y)
	{
		return default(Rectangle);
	}

	/// <summary>Replaces this <see cref="T:System.Drawing.Rectangle" /> with the intersection of itself and the specified <see cref="T:System.Drawing.Rectangle" />.</summary>
	/// <param name="rect">The <see cref="T:System.Drawing.Rectangle" /> with which to intersect.</param>
	public void Intersect(Rectangle rect)
	{
	}

	/// <summary>Returns a third <see cref="T:System.Drawing.Rectangle" /> structure that represents the intersection of two other <see cref="T:System.Drawing.Rectangle" /> structures. If there is no intersection, an empty <see cref="T:System.Drawing.Rectangle" /> is returned.</summary>
	/// <param name="a">A rectangle to intersect.</param>
	/// <param name="b">A rectangle to intersect.</param>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that represents the intersection of <paramref name="a" /> and <paramref name="b" />.</returns>
	public static Rectangle Intersect(Rectangle a, Rectangle b)
	{
		return default(Rectangle);
	}

	/// <summary>Determines if this rectangle intersects with <paramref name="rect" />.</summary>
	/// <param name="rect">The rectangle to test.</param>
	/// <returns>This method returns <see langword="true" /> if there is any intersection, otherwise <see langword="false" />.</returns>
	public bool IntersectsWith(Rectangle rect)
	{
		return false;
	}

	/// <summary>Gets a <see cref="T:System.Drawing.Rectangle" /> structure that contains the union of two <see cref="T:System.Drawing.Rectangle" /> structures.</summary>
	/// <param name="a">A rectangle to union.</param>
	/// <param name="b">A rectangle to union.</param>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> structure that bounds the union of the two <see cref="T:System.Drawing.Rectangle" /> structures.</returns>
	public static Rectangle Union(Rectangle a, Rectangle b)
	{
		return default(Rectangle);
	}

	/// <summary>Adjusts the location of this rectangle by the specified amount.</summary>
	/// <param name="x">The horizontal offset.</param>
	/// <param name="y">The vertical offset.</param>
	public void Offset(int x, int y)
	{
	}

	/// <summary>Converts the attributes of this <see cref="T:System.Drawing.Rectangle" /> to a human-readable string.</summary>
	/// <returns>A string that contains the position, width, and height of this <see cref="T:System.Drawing.Rectangle" /> structure ¾ for example, {X=20, Y=20, Width=100, Height=50}</returns>
	public override string ToString()
	{
		return null;
	}
}
