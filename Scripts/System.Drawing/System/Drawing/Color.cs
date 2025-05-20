using System.Diagnostics;

namespace System.Drawing;

/// <summary>Represents an ARGB (alpha, red, green, blue) color.</summary>
[Serializable]
[DebuggerDisplay("{NameAndARGBValue}")]
public readonly struct Color : IEquatable<Color>
{
	/// <summary>Represents a color that is <see langword="null" />.</summary>
	public static readonly Color Empty;

	private readonly string name;

	private readonly long value;

	private readonly short knownColor;

	private readonly short state;

	/// <summary>Gets a system-defined color.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> representing a system-defined color.</returns>
	public static Color Transparent => default(Color);

	/// <summary>Gets a system-defined color that has an ARGB value of #FF000000.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> representing a system-defined color.</returns>
	public static Color Black => default(Color);

	/// <summary>Gets a system-defined color that has an ARGB value of #FF0000FF.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> representing a system-defined color.</returns>
	public static Color Blue => default(Color);

	/// <summary>Gets a system-defined color that has an ARGB value of #FF808080.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> strcture representing a system-defined color.</returns>
	public static Color Gray => default(Color);

	/// <summary>Gets a system-defined color that has an ARGB value of #FF87CEEB.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> representing a system-defined color.</returns>
	public static Color SkyBlue => default(Color);

	/// <summary>Gets a system-defined color that has an ARGB value of #FFF5DEB3.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> representing a system-defined color.</returns>
	public static Color Wheat => default(Color);

	/// <summary>Gets a system-defined color that has an ARGB value of #FFFFFFFF.</summary>
	/// <returns>A <see cref="T:System.Drawing.Color" /> representing a system-defined color.</returns>
	public static Color White => default(Color);

	/// <summary>Gets the red component value of this <see cref="T:System.Drawing.Color" /> structure.</summary>
	/// <returns>The red component value of this <see cref="T:System.Drawing.Color" />.</returns>
	public byte R => 0;

	/// <summary>Gets the green component value of this <see cref="T:System.Drawing.Color" /> structure.</summary>
	/// <returns>The green component value of this <see cref="T:System.Drawing.Color" />.</returns>
	public byte G => 0;

	/// <summary>Gets the blue component value of this <see cref="T:System.Drawing.Color" /> structure.</summary>
	/// <returns>The blue component value of this <see cref="T:System.Drawing.Color" />.</returns>
	public byte B => 0;

	/// <summary>Gets the alpha component value of this <see cref="T:System.Drawing.Color" /> structure.</summary>
	/// <returns>The alpha component value of this <see cref="T:System.Drawing.Color" />.</returns>
	public byte A => 0;

	/// <summary>Gets a value indicating whether this <see cref="T:System.Drawing.Color" /> structure is a predefined color. Predefined colors are represented by the elements of the <see cref="T:System.Drawing.KnownColor" /> enumeration.</summary>
	/// <returns>
	///   <see langword="true" /> if this <see cref="T:System.Drawing.Color" /> was created from a predefined color by using either the <see cref="M:System.Drawing.Color.FromName(System.String)" /> method or the <see cref="M:System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor)" /> method; otherwise, <see langword="false" />.</returns>
	public bool IsKnownColor => false;

	/// <summary>Specifies whether this <see cref="T:System.Drawing.Color" /> structure is uninitialized.</summary>
	/// <returns>This property returns <see langword="true" /> if this color is uninitialized; otherwise, <see langword="false" />.</returns>
	public bool IsEmpty => false;

	/// <summary>Gets a value indicating whether this <see cref="T:System.Drawing.Color" /> structure is a system color. A system color is a color that is used in a Windows display element. System colors are represented by elements of the <see cref="T:System.Drawing.KnownColor" /> enumeration.</summary>
	/// <returns>
	///   <see langword="true" /> if this <see cref="T:System.Drawing.Color" /> was created from a system color by using either the <see cref="M:System.Drawing.Color.FromName(System.String)" /> method or the <see cref="M:System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor)" /> method; otherwise, <see langword="false" />.</returns>
	public bool IsSystemColor => false;

	/// <summary>Gets the name of this <see cref="T:System.Drawing.Color" />.</summary>
	/// <returns>The name of this <see cref="T:System.Drawing.Color" />.</returns>
	public string Name => null;

	private long Value => 0L;

	internal Color(KnownColor knownColor)
	{
		name = null;
		value = 0L;
		this.knownColor = 0;
		state = 0;
	}

	private Color(long value, short state, string name, KnownColor knownColor)
	{
		this.name = null;
		this.value = 0L;
		this.knownColor = 0;
		this.state = 0;
	}

	private static void CheckByte(int value, string name)
	{
	}

	private static long MakeArgb(byte alpha, byte red, byte green, byte blue)
	{
		return 0L;
	}

	/// <summary>Creates a <see cref="T:System.Drawing.Color" /> structure from a 32-bit ARGB value.</summary>
	/// <param name="argb">A value specifying the 32-bit ARGB value.</param>
	/// <returns>The <see cref="T:System.Drawing.Color" /> structure that this method creates.</returns>
	public static Color FromArgb(int argb)
	{
		return default(Color);
	}

	/// <summary>Creates a <see cref="T:System.Drawing.Color" /> structure from the four ARGB component (alpha, red, green, and blue) values. Although this method allows a 32-bit value to be passed for each component, the value of each component is limited to 8 bits.</summary>
	/// <param name="alpha">The alpha component. Valid values are 0 through 255.</param>
	/// <param name="red">The red component. Valid values are 0 through 255.</param>
	/// <param name="green">The green component. Valid values are 0 through 255.</param>
	/// <param name="blue">The blue component. Valid values are 0 through 255.</param>
	/// <returns>The <see cref="T:System.Drawing.Color" /> that this method creates.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="alpha" />, <paramref name="red" />, <paramref name="green" />, or <paramref name="blue" /> is less than 0 or greater than 255.</exception>
	public static Color FromArgb(int alpha, int red, int green, int blue)
	{
		return default(Color);
	}

	/// <summary>Creates a <see cref="T:System.Drawing.Color" /> structure from the specified 8-bit color values (red, green, and blue). The alpha value is implicitly 255 (fully opaque). Although this method allows a 32-bit value to be passed for each color component, the value of each component is limited to 8 bits.</summary>
	/// <param name="red">The red component value for the new <see cref="T:System.Drawing.Color" />. Valid values are 0 through 255.</param>
	/// <param name="green">The green component value for the new <see cref="T:System.Drawing.Color" />. Valid values are 0 through 255.</param>
	/// <param name="blue">The blue component value for the new <see cref="T:System.Drawing.Color" />. Valid values are 0 through 255.</param>
	/// <returns>The <see cref="T:System.Drawing.Color" /> that this method creates.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="red" />, <paramref name="green" />, or <paramref name="blue" /> is less than 0 or greater than 255.</exception>
	public static Color FromArgb(int red, int green, int blue)
	{
		return default(Color);
	}

	/// <summary>Creates a <see cref="T:System.Drawing.Color" /> structure from the specified predefined color.</summary>
	/// <param name="color">An element of the <see cref="T:System.Drawing.KnownColor" /> enumeration.</param>
	/// <returns>The <see cref="T:System.Drawing.Color" /> that this method creates.</returns>
	public static Color FromKnownColor(KnownColor color)
	{
		return default(Color);
	}

	/// <summary>Creates a <see cref="T:System.Drawing.Color" /> structure from the specified name of a predefined color.</summary>
	/// <param name="name">A string that is the name of a predefined color. Valid names are the same as the names of the elements of the <see cref="T:System.Drawing.KnownColor" /> enumeration.</param>
	/// <returns>The <see cref="T:System.Drawing.Color" /> that this method creates.</returns>
	public static Color FromName(string name)
	{
		return default(Color);
	}

	/// <summary>Gets the hue-saturation-lightness (HSL) lightness value for this <see cref="T:System.Drawing.Color" /> structure.</summary>
	/// <returns>The lightness of this <see cref="T:System.Drawing.Color" />. The lightness ranges from 0.0 through 1.0, where 0.0 represents black and 1.0 represents white.</returns>
	public float GetBrightness()
	{
		return 0f;
	}

	/// <summary>Gets the 32-bit ARGB value of this <see cref="T:System.Drawing.Color" /> structure.</summary>
	/// <returns>The 32-bit ARGB value of this <see cref="T:System.Drawing.Color" />.</returns>
	public int ToArgb()
	{
		return 0;
	}

	/// <summary>Gets the <see cref="T:System.Drawing.KnownColor" /> value of this <see cref="T:System.Drawing.Color" /> structure.</summary>
	/// <returns>An element of the <see cref="T:System.Drawing.KnownColor" /> enumeration, if the <see cref="T:System.Drawing.Color" /> is created from a predefined color by using either the <see cref="M:System.Drawing.Color.FromName(System.String)" /> method or the <see cref="M:System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor)" /> method; otherwise, 0.</returns>
	public KnownColor ToKnownColor()
	{
		return default(KnownColor);
	}

	/// <summary>Converts this <see cref="T:System.Drawing.Color" /> structure to a human-readable string.</summary>
	/// <returns>A string that is the name of this <see cref="T:System.Drawing.Color" />, if the <see cref="T:System.Drawing.Color" /> is created from a predefined color by using either the <see cref="M:System.Drawing.Color.FromName(System.String)" /> method or the <see cref="M:System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor)" /> method; otherwise, a string that consists of the ARGB component names and their values.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Tests whether two specified <see cref="T:System.Drawing.Color" /> structures are equivalent.</summary>
	/// <param name="left">The <see cref="T:System.Drawing.Color" /> that is to the left of the equality operator.</param>
	/// <param name="right">The <see cref="T:System.Drawing.Color" /> that is to the right of the equality operator.</param>
	/// <returns>
	///   <see langword="true" /> if the two <see cref="T:System.Drawing.Color" /> structures are equal; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(Color left, Color right)
	{
		return false;
	}

	/// <summary>Tests whether two specified <see cref="T:System.Drawing.Color" /> structures are different.</summary>
	/// <param name="left">The <see cref="T:System.Drawing.Color" /> that is to the left of the inequality operator.</param>
	/// <param name="right">The <see cref="T:System.Drawing.Color" /> that is to the right of the inequality operator.</param>
	/// <returns>
	///   <see langword="true" /> if the two <see cref="T:System.Drawing.Color" /> structures are different; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(Color left, Color right)
	{
		return false;
	}

	/// <summary>Tests whether the specified object is a <see cref="T:System.Drawing.Color" /> structure and is equivalent to this <see cref="T:System.Drawing.Color" /> structure.</summary>
	/// <param name="obj">The object to test.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.Drawing.Color" /> structure equivalent to this <see cref="T:System.Drawing.Color" /> structure; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(Color other)
	{
		return false;
	}

	/// <summary>Returns a hash code for this <see cref="T:System.Drawing.Color" /> structure.</summary>
	/// <returns>An integer value that specifies the hash code for this <see cref="T:System.Drawing.Color" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
