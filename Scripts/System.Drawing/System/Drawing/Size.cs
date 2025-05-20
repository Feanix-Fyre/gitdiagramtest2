using System.ComponentModel;

namespace System.Drawing;

/// <summary>Stores an ordered pair of integers, which specify a <see cref="P:System.Drawing.Size.Height" /> and <see cref="P:System.Drawing.Size.Width" />.</summary>
[Serializable]
public struct Size : IEquatable<Size>
{
	/// <summary>Gets a <see cref="T:System.Drawing.Size" /> structure that has a <see cref="P:System.Drawing.Size.Height" /> and <see cref="P:System.Drawing.Size.Width" /> value of 0.</summary>
	public static readonly Size Empty;

	private int width;

	private int height;

	/// <summary>Tests whether this <see cref="T:System.Drawing.Size" /> structure has width and height of 0.</summary>
	/// <returns>This property returns <see langword="true" /> when this <see cref="T:System.Drawing.Size" /> structure has both a width and height of 0; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	public bool IsEmpty => false;

	/// <summary>Gets or sets the horizontal component of this <see cref="T:System.Drawing.Size" /> structure.</summary>
	/// <returns>The horizontal component of this <see cref="T:System.Drawing.Size" /> structure, typically measured in pixels.</returns>
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

	/// <summary>Gets or sets the vertical component of this <see cref="T:System.Drawing.Size" /> structure.</summary>
	/// <returns>The vertical component of this <see cref="T:System.Drawing.Size" /> structure, typically measured in pixels.</returns>
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

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Size" /> structure from the specified dimensions.</summary>
	/// <param name="width">The width component of the new <see cref="T:System.Drawing.Size" />.</param>
	/// <param name="height">The height component of the new <see cref="T:System.Drawing.Size" />.</param>
	public Size(int width, int height)
	{
		this.width = 0;
		this.height = 0;
	}

	/// <summary>Converts the specified <see cref="T:System.Drawing.Size" /> structure to a <see cref="T:System.Drawing.SizeF" /> structure.</summary>
	/// <param name="p">The <see cref="T:System.Drawing.Size" /> structure to convert.</param>
	/// <returns>The <see cref="T:System.Drawing.SizeF" /> structure to which this operator converts.</returns>
	public static implicit operator SizeF(Size p)
	{
		return default(SizeF);
	}

	/// <summary>Adds the width and height of one <see cref="T:System.Drawing.Size" /> structure to the width and height of another <see cref="T:System.Drawing.Size" /> structure.</summary>
	/// <param name="sz1">The first <see cref="T:System.Drawing.Size" /> to add.</param>
	/// <param name="sz2">The second <see cref="T:System.Drawing.Size" /> to add.</param>
	/// <returns>A <see cref="T:System.Drawing.Size" /> structure that is the result of the addition operation.</returns>
	public static Size operator +(Size sz1, Size sz2)
	{
		return default(Size);
	}

	/// <summary>Tests whether two <see cref="T:System.Drawing.Size" /> structures are equal.</summary>
	/// <param name="sz1">The <see cref="T:System.Drawing.Size" /> structure on the left side of the equality operator.</param>
	/// <param name="sz2">The <see cref="T:System.Drawing.Size" /> structure on the right of the equality operator.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="sz1" /> and <paramref name="sz2" /> have equal width and height; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(Size sz1, Size sz2)
	{
		return false;
	}

	/// <summary>Tests whether two <see cref="T:System.Drawing.Size" /> structures are different.</summary>
	/// <param name="sz1">The <see cref="T:System.Drawing.Size" /> structure on the left of the inequality operator.</param>
	/// <param name="sz2">The <see cref="T:System.Drawing.Size" /> structure on the right of the inequality operator.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="sz1" /> and <paramref name="sz2" /> differ either in width or height; <see langword="false" /> if <paramref name="sz1" /> and <paramref name="sz2" /> are equal.</returns>
	public static bool operator !=(Size sz1, Size sz2)
	{
		return false;
	}

	/// <summary>Adds the width and height of one <see cref="T:System.Drawing.Size" /> structure to the width and height of another <see cref="T:System.Drawing.Size" /> structure.</summary>
	/// <param name="sz1">The first <see cref="T:System.Drawing.Size" /> structure to add.</param>
	/// <param name="sz2">The second <see cref="T:System.Drawing.Size" /> structure to add.</param>
	/// <returns>A <see cref="T:System.Drawing.Size" /> structure that is the result of the addition operation.</returns>
	public static Size Add(Size sz1, Size sz2)
	{
		return default(Size);
	}

	/// <summary>Converts the specified <see cref="T:System.Drawing.SizeF" /> structure to a <see cref="T:System.Drawing.Size" /> structure by rounding the values of the <see cref="T:System.Drawing.Size" /> structure to the next higher integer values.</summary>
	/// <param name="value">The <see cref="T:System.Drawing.SizeF" /> structure to convert.</param>
	/// <returns>The <see cref="T:System.Drawing.Size" /> structure this method converts to.</returns>
	public static Size Ceiling(SizeF value)
	{
		return default(Size);
	}

	/// <summary>Converts the specified <see cref="T:System.Drawing.SizeF" /> structure to a <see cref="T:System.Drawing.Size" /> structure by truncating the values of the <see cref="T:System.Drawing.SizeF" /> structure to the next lower integer values.</summary>
	/// <param name="value">The <see cref="T:System.Drawing.SizeF" /> structure to convert.</param>
	/// <returns>The <see cref="T:System.Drawing.Size" /> structure this method converts to.</returns>
	public static Size Truncate(SizeF value)
	{
		return default(Size);
	}

	/// <summary>Tests to see whether the specified object is a <see cref="T:System.Drawing.Size" /> structure with the same dimensions as this <see cref="T:System.Drawing.Size" /> structure.</summary>
	/// <param name="obj">The <see cref="T:System.Object" /> to test.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.Drawing.Size" /> and has the same width and height as this <see cref="T:System.Drawing.Size" />; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(Size other)
	{
		return false;
	}

	/// <summary>Returns a hash code for this <see cref="T:System.Drawing.Size" /> structure.</summary>
	/// <returns>An integer value that specifies a hash value for this <see cref="T:System.Drawing.Size" /> structure.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Creates a human-readable string that represents this <see cref="T:System.Drawing.Size" /> structure.</summary>
	/// <returns>A string that represents this <see cref="T:System.Drawing.Size" />.</returns>
	public override string ToString()
	{
		return null;
	}
}
