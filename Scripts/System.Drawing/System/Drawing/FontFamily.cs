using System.Drawing.Text;

namespace System.Drawing;

/// <summary>Defines a group of type faces having a similar basic design and certain variations in styles. This class cannot be inherited.</summary>
public sealed class FontFamily : MarshalByRefObject, IDisposable
{
	private string name;

	private IntPtr nativeFontFamily;

	internal IntPtr NativeFamily => (IntPtr)0;

	/// <summary>Gets the name of this <see cref="T:System.Drawing.FontFamily" />.</summary>
	/// <returns>A <see cref="T:System.String" /> that represents the name of this <see cref="T:System.Drawing.FontFamily" />.</returns>
	public string Name => null;

	/// <summary>Gets a generic sans serif <see cref="T:System.Drawing.FontFamily" /> object.</summary>
	/// <returns>A <see cref="T:System.Drawing.FontFamily" /> object that represents a generic sans serif font.</returns>
	public static FontFamily GenericSansSerif => null;

	/// <summary>Returns an array that contains all the <see cref="T:System.Drawing.FontFamily" /> objects associated with the current graphics context.</summary>
	/// <returns>An array of <see cref="T:System.Drawing.FontFamily" /> objects associated with the current graphics context.</returns>
	public static FontFamily[] Families => null;

	internal FontFamily(IntPtr fntfamily)
	{
	}

	internal void refreshName()
	{
	}

	/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
	~FontFamily()
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.FontFamily" /> from the specified generic font family.</summary>
	/// <param name="genericFamily">The <see cref="T:System.Drawing.Text.GenericFontFamilies" /> from which to create the new <see cref="T:System.Drawing.FontFamily" />.</param>
	public FontFamily(GenericFontFamilies genericFamily)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.FontFamily" /> with the specified name.</summary>
	/// <param name="name">The name of the new <see cref="T:System.Drawing.FontFamily" />.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="name" /> is an empty string ("").  
	/// -or-  
	/// <paramref name="name" /> specifies a font that is not installed on the computer running the application.  
	/// -or-  
	/// <paramref name="name" /> specifies a font that is not a TrueType font.</exception>
	public FontFamily(string name)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.FontFamily" /> in the specified <see cref="T:System.Drawing.Text.FontCollection" /> with the specified name.</summary>
	/// <param name="name">A <see cref="T:System.String" /> that represents the name of the new <see cref="T:System.Drawing.FontFamily" />.</param>
	/// <param name="fontCollection">The <see cref="T:System.Drawing.Text.FontCollection" /> that contains this <see cref="T:System.Drawing.FontFamily" />.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="name" /> is an empty string ("").  
	/// -or-  
	/// <paramref name="name" /> specifies a font that is not installed on the computer running the application.  
	/// -or-  
	/// <paramref name="name" /> specifies a font that is not a TrueType font.</exception>
	public FontFamily(string name, FontCollection fontCollection)
	{
	}

	/// <summary>Returns the cell ascent, in design units, of the <see cref="T:System.Drawing.FontFamily" /> of the specified style.</summary>
	/// <param name="style">A <see cref="T:System.Drawing.FontStyle" /> that contains style information for the font.</param>
	/// <returns>The cell ascent for this <see cref="T:System.Drawing.FontFamily" /> that uses the specified <see cref="T:System.Drawing.FontStyle" />.</returns>
	public int GetCellAscent(FontStyle style)
	{
		return 0;
	}

	/// <summary>Returns the cell descent, in design units, of the <see cref="T:System.Drawing.FontFamily" /> of the specified style.</summary>
	/// <param name="style">A <see cref="T:System.Drawing.FontStyle" /> that contains style information for the font.</param>
	/// <returns>The cell descent metric for this <see cref="T:System.Drawing.FontFamily" /> that uses the specified <see cref="T:System.Drawing.FontStyle" />.</returns>
	public int GetCellDescent(FontStyle style)
	{
		return 0;
	}

	/// <summary>Releases all resources used by this <see cref="T:System.Drawing.FontFamily" />.</summary>
	public void Dispose()
	{
	}

	/// <summary>Indicates whether the specified object is a <see cref="T:System.Drawing.FontFamily" /> and is identical to this <see cref="T:System.Drawing.FontFamily" />.</summary>
	/// <param name="obj">The object to test.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.Drawing.FontFamily" /> and is identical to this <see cref="T:System.Drawing.FontFamily" />; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Gets a hash code for this <see cref="T:System.Drawing.FontFamily" />.</summary>
	/// <returns>The hash code for this <see cref="T:System.Drawing.FontFamily" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Converts this <see cref="T:System.Drawing.FontFamily" /> to a human-readable string representation.</summary>
	/// <returns>The string that represents this <see cref="T:System.Drawing.FontFamily" />.</returns>
	public override string ToString()
	{
		return null;
	}
}
