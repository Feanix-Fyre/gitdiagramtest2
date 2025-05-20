using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Drawing;

/// <summary>Defines a particular format for text, including font face, size, and style attributes. This class cannot be inherited.</summary>
[Serializable]
[Editor("System.Drawing.Design.FontEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
[ComVisible(true)]
[TypeConverter(typeof(FontConverter))]
public sealed class Font : MarshalByRefObject, ISerializable, ICloneable, IDisposable
{
	private IntPtr fontObject;

	private string systemFontName;

	private string originalFontName;

	private float _size;

	private object olf;

	private static int CharSetOffset;

	private bool _bold;

	private FontFamily _fontFamily;

	private byte _gdiCharSet;

	private bool _gdiVerticalFont;

	private bool _italic;

	private string _name;

	private float _sizeInPoints;

	private bool _strikeout;

	private FontStyle _style;

	private bool _underline;

	private GraphicsUnit _unit;

	private int _hashCode;

	internal IntPtr NativeObject => (IntPtr)0;

	/// <summary>Gets a value that indicates whether this <see cref="T:System.Drawing.Font" /> is bold.</summary>
	/// <returns>
	///   <see langword="true" /> if this <see cref="T:System.Drawing.Font" /> is bold; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool Bold => false;

	/// <summary>Gets the <see cref="T:System.Drawing.FontFamily" /> associated with this <see cref="T:System.Drawing.Font" />.</summary>
	/// <returns>The <see cref="T:System.Drawing.FontFamily" /> associated with this <see cref="T:System.Drawing.Font" />.</returns>
	[Browsable(false)]
	public FontFamily FontFamily => null;

	/// <summary>Gets a byte value that specifies the GDI character set that this <see cref="T:System.Drawing.Font" /> uses.</summary>
	/// <returns>A byte value that specifies the GDI character set that this <see cref="T:System.Drawing.Font" /> uses. The default is 1.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public byte GdiCharSet => 0;

	/// <summary>Gets a Boolean value that indicates whether this <see cref="T:System.Drawing.Font" /> is derived from a GDI vertical font.</summary>
	/// <returns>
	///   <see langword="true" /> if this <see cref="T:System.Drawing.Font" /> is derived from a GDI vertical font; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool GdiVerticalFont => false;

	/// <summary>Gets the line spacing of this font.</summary>
	/// <returns>The line spacing, in pixels, of this font.</returns>
	[Browsable(false)]
	public int Height => 0;

	/// <summary>Gets a value that indicates whether this font has the italic style applied.</summary>
	/// <returns>
	///   <see langword="true" /> to indicate this font has the italic style applied; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool Italic => false;

	/// <summary>Gets the face name of this <see cref="T:System.Drawing.Font" />.</summary>
	/// <returns>A string representation of the face name of this <see cref="T:System.Drawing.Font" />.</returns>
	[TypeConverter(typeof(FontConverter.FontNameConverter))]
	[Editor("System.Drawing.Design.FontNameEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public string Name => null;

	/// <summary>Gets the em-size of this <see cref="T:System.Drawing.Font" /> measured in the units specified by the <see cref="P:System.Drawing.Font.Unit" /> property.</summary>
	/// <returns>The em-size of this <see cref="T:System.Drawing.Font" />.</returns>
	public float Size => 0f;

	/// <summary>Gets a value that indicates whether this <see cref="T:System.Drawing.Font" /> specifies a horizontal line through the font.</summary>
	/// <returns>
	///   <see langword="true" /> if this <see cref="T:System.Drawing.Font" /> has a horizontal line through it; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool Strikeout => false;

	/// <summary>Gets style information for this <see cref="T:System.Drawing.Font" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.FontStyle" /> enumeration that contains style information for this <see cref="T:System.Drawing.Font" />.</returns>
	[Browsable(false)]
	public FontStyle Style => default(FontStyle);

	/// <summary>Gets a value that indicates whether this <see cref="T:System.Drawing.Font" /> is underlined.</summary>
	/// <returns>
	///   <see langword="true" /> if this <see cref="T:System.Drawing.Font" /> is underlined; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool Underline => false;

	/// <summary>Gets the unit of measure for this <see cref="T:System.Drawing.Font" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.GraphicsUnit" /> that represents the unit of measure for this <see cref="T:System.Drawing.Font" />.</returns>
	[TypeConverter(typeof(FontConverter.FontUnitConverter))]
	public GraphicsUnit Unit => default(GraphicsUnit);

	private void CreateFont(string familyName, float emSize, FontStyle style, GraphicsUnit unit, byte charSet, bool isVertical)
	{
	}

	private Font(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.</summary>
	/// <param name="si">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
	/// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext" />) for this serialization.</param>
	void ISerializable.GetObjectData(SerializationInfo si, StreamingContext context)
	{
	}

	/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
	~Font()
	{
	}

	/// <summary>Releases all resources used by this <see cref="T:System.Drawing.Font" />.</summary>
	public void Dispose()
	{
	}

	internal void unitConversion(GraphicsUnit fromUnit, GraphicsUnit toUnit, float nSrc, out float nTrg)
	{
		nTrg = default(float);
	}

	private void setProperties(FontFamily family, float emSize, FontStyle style, GraphicsUnit unit, byte charSet, bool isVertical)
	{
	}

	/// <summary>Returns a handle to this <see cref="T:System.Drawing.Font" />.</summary>
	/// <returns>A Windows handle to this <see cref="T:System.Drawing.Font" />.</returns>
	/// <exception cref="T:System.ComponentModel.Win32Exception">The operation was unsuccessful.</exception>
	public IntPtr ToHfont()
	{
		return (IntPtr)0;
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.Font" /> that uses the specified existing <see cref="T:System.Drawing.Font" /> and <see cref="T:System.Drawing.FontStyle" /> enumeration.</summary>
	/// <param name="prototype">The existing <see cref="T:System.Drawing.Font" /> from which to create the new <see cref="T:System.Drawing.Font" />.</param>
	/// <param name="newStyle">The <see cref="T:System.Drawing.FontStyle" /> to apply to the new <see cref="T:System.Drawing.Font" />. Multiple values of the <see cref="T:System.Drawing.FontStyle" /> enumeration can be combined with the <see langword="OR" /> operator.</param>
	public Font(Font prototype, FontStyle newStyle)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.Font" /> using a specified size and unit. Sets the style to <see cref="F:System.Drawing.FontStyle.Regular" />.</summary>
	/// <param name="family">The <see cref="T:System.Drawing.FontFamily" /> of the new <see cref="T:System.Drawing.Font" />.</param>
	/// <param name="emSize">The em-size of the new font in the units specified by the <paramref name="unit" /> parameter.</param>
	/// <param name="unit">The <see cref="T:System.Drawing.GraphicsUnit" /> of the new font.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="family" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="emSize" /> is less than or equal to 0, evaluates to infinity, or is not a valid number.</exception>
	public Font(FontFamily family, float emSize, GraphicsUnit unit)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.Font" /> using a specified size and unit. The style is set to <see cref="F:System.Drawing.FontStyle.Regular" />.</summary>
	/// <param name="familyName">A string representation of the <see cref="T:System.Drawing.FontFamily" /> for the new <see cref="T:System.Drawing.Font" />.</param>
	/// <param name="emSize">The em-size of the new font in the units specified by the <paramref name="unit" /> parameter.</param>
	/// <param name="unit">The <see cref="T:System.Drawing.GraphicsUnit" /> of the new font.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="emSize" /> is less than or equal to 0, evaluates to infinity, or is not a valid number.</exception>
	public Font(string familyName, float emSize, GraphicsUnit unit)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.Font" /> using a specified size.</summary>
	/// <param name="family">The <see cref="T:System.Drawing.FontFamily" /> of the new <see cref="T:System.Drawing.Font" />.</param>
	/// <param name="emSize">The em-size, in points, of the new font.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="emSize" /> is less than or equal to 0, evaluates to infinity, or is not a valid number.</exception>
	public Font(FontFamily family, float emSize)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.Font" /> using a specified size and style.</summary>
	/// <param name="family">The <see cref="T:System.Drawing.FontFamily" /> of the new <see cref="T:System.Drawing.Font" />.</param>
	/// <param name="emSize">The em-size, in points, of the new font.</param>
	/// <param name="style">The <see cref="T:System.Drawing.FontStyle" /> of the new font.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="emSize" /> is less than or equal to 0, evaluates to infinity, or is not a valid number.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="family" /> is <see langword="null" />.</exception>
	public Font(FontFamily family, float emSize, FontStyle style)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.Font" /> using a specified size, style, and unit.</summary>
	/// <param name="family">The <see cref="T:System.Drawing.FontFamily" /> of the new <see cref="T:System.Drawing.Font" />.</param>
	/// <param name="emSize">The em-size of the new font in the units specified by the <paramref name="unit" /> parameter.</param>
	/// <param name="style">The <see cref="T:System.Drawing.FontStyle" /> of the new font.</param>
	/// <param name="unit">The <see cref="T:System.Drawing.GraphicsUnit" /> of the new font.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="emSize" /> is less than or equal to 0, evaluates to infinity, or is not a valid number.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="family" /> is <see langword="null" />.</exception>
	public Font(FontFamily family, float emSize, FontStyle style, GraphicsUnit unit)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.Font" /> using a specified size, style, unit, and character set.</summary>
	/// <param name="family">The <see cref="T:System.Drawing.FontFamily" /> of the new <see cref="T:System.Drawing.Font" />.</param>
	/// <param name="emSize">The em-size of the new font in the units specified by the <paramref name="unit" /> parameter.</param>
	/// <param name="style">The <see cref="T:System.Drawing.FontStyle" /> of the new font.</param>
	/// <param name="unit">The <see cref="T:System.Drawing.GraphicsUnit" /> of the new font.</param>
	/// <param name="gdiCharSet">A <see cref="T:System.Byte" /> that specifies a  
	///  GDI character set to use for the new font.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="emSize" /> is less than or equal to 0, evaluates to infinity, or is not a valid number.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="family" /> is <see langword="null" />.</exception>
	public Font(FontFamily family, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.Font" /> using a specified size, style, unit, and character set.</summary>
	/// <param name="family">The <see cref="T:System.Drawing.FontFamily" /> of the new <see cref="T:System.Drawing.Font" />.</param>
	/// <param name="emSize">The em-size of the new font in the units specified by the <paramref name="unit" /> parameter.</param>
	/// <param name="style">The <see cref="T:System.Drawing.FontStyle" /> of the new font.</param>
	/// <param name="unit">The <see cref="T:System.Drawing.GraphicsUnit" /> of the new font.</param>
	/// <param name="gdiCharSet">A <see cref="T:System.Byte" /> that specifies a  
	///  GDI character set to use for this font.</param>
	/// <param name="gdiVerticalFont">A Boolean value indicating whether the new font is derived from a GDI vertical font.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="emSize" /> is less than or equal to 0, evaluates to infinity, or is not a valid number.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="family" /> is <see langword="null" /></exception>
	public Font(FontFamily family, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet, bool gdiVerticalFont)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.Font" /> using a specified size.</summary>
	/// <param name="familyName">A string representation of the <see cref="T:System.Drawing.FontFamily" /> for the new <see cref="T:System.Drawing.Font" />.</param>
	/// <param name="emSize">The em-size, in points, of the new font.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="emSize" /> is less than or equal to 0, evaluates to infinity or is not a valid number.</exception>
	public Font(string familyName, float emSize)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.Font" /> using a specified size and style.</summary>
	/// <param name="familyName">A string representation of the <see cref="T:System.Drawing.FontFamily" /> for the new <see cref="T:System.Drawing.Font" />.</param>
	/// <param name="emSize">The em-size, in points, of the new font.</param>
	/// <param name="style">The <see cref="T:System.Drawing.FontStyle" /> of the new font.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="emSize" /> is less than or equal to 0, evaluates to infinity, or is not a valid number.</exception>
	public Font(string familyName, float emSize, FontStyle style)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.Font" /> using a specified size, style, and unit.</summary>
	/// <param name="familyName">A string representation of the <see cref="T:System.Drawing.FontFamily" /> for the new <see cref="T:System.Drawing.Font" />.</param>
	/// <param name="emSize">The em-size of the new font in the units specified by the <paramref name="unit" /> parameter.</param>
	/// <param name="style">The <see cref="T:System.Drawing.FontStyle" /> of the new font.</param>
	/// <param name="unit">The <see cref="T:System.Drawing.GraphicsUnit" /> of the new font.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="emSize" /> is less than or equal to 0, evaluates to infinity or is not a valid number.</exception>
	public Font(string familyName, float emSize, FontStyle style, GraphicsUnit unit)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.Font" /> using a specified size, style, unit, and character set.</summary>
	/// <param name="familyName">A string representation of the <see cref="T:System.Drawing.FontFamily" /> for the new <see cref="T:System.Drawing.Font" />.</param>
	/// <param name="emSize">The em-size of the new font in the units specified by the <paramref name="unit" /> parameter.</param>
	/// <param name="style">The <see cref="T:System.Drawing.FontStyle" /> of the new font.</param>
	/// <param name="unit">The <see cref="T:System.Drawing.GraphicsUnit" /> of the new font.</param>
	/// <param name="gdiCharSet">A <see cref="T:System.Byte" /> that specifies a GDI character set to use for this font.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="emSize" /> is less than or equal to 0, evaluates to infinity, or is not a valid number.</exception>
	public Font(string familyName, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.Font" /> using the specified size, style, unit, and character set.</summary>
	/// <param name="familyName">A string representation of the <see cref="T:System.Drawing.FontFamily" /> for the new <see cref="T:System.Drawing.Font" />.</param>
	/// <param name="emSize">The em-size of the new font in the units specified by the <paramref name="unit" /> parameter.</param>
	/// <param name="style">The <see cref="T:System.Drawing.FontStyle" /> of the new font.</param>
	/// <param name="unit">The <see cref="T:System.Drawing.GraphicsUnit" /> of the new font.</param>
	/// <param name="gdiCharSet">A <see cref="T:System.Byte" /> that specifies a GDI character set to use for this font.</param>
	/// <param name="gdiVerticalFont">A Boolean value indicating whether the new <see cref="T:System.Drawing.Font" /> is derived from a GDI vertical font.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="emSize" /> is less than or equal to 0, evaluates to infinity, or is not a valid number.</exception>
	public Font(string familyName, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet, bool gdiVerticalFont)
	{
	}

	internal Font(string familyName, float emSize, string systemName)
	{
	}

	/// <summary>Creates an exact copy of this <see cref="T:System.Drawing.Font" />.</summary>
	/// <returns>The <see cref="T:System.Drawing.Font" /> this method creates, cast as an <see cref="T:System.Object" />.</returns>
	public object Clone()
	{
		return null;
	}

	/// <summary>Indicates whether the specified object is a <see cref="T:System.Drawing.Font" /> and has the same <see cref="P:System.Drawing.Font.FontFamily" />, <see cref="P:System.Drawing.Font.GdiVerticalFont" />, <see cref="P:System.Drawing.Font.GdiCharSet" />, <see cref="P:System.Drawing.Font.Style" />, <see cref="P:System.Drawing.Font.Size" />, and <see cref="P:System.Drawing.Font.Unit" /> property values as this <see cref="T:System.Drawing.Font" />.</summary>
	/// <param name="obj">The object to test.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="obj" /> parameter is a <see cref="T:System.Drawing.Font" /> and has the same <see cref="P:System.Drawing.Font.FontFamily" />, <see cref="P:System.Drawing.Font.GdiVerticalFont" />, <see cref="P:System.Drawing.Font.GdiCharSet" />, <see cref="P:System.Drawing.Font.Style" />, <see cref="P:System.Drawing.Font.Size" />, and <see cref="P:System.Drawing.Font.Unit" /> property values as this <see cref="T:System.Drawing.Font" />; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Gets the hash code for this <see cref="T:System.Drawing.Font" />.</summary>
	/// <returns>The hash code for this <see cref="T:System.Drawing.Font" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns the line spacing, in pixels, of this font.</summary>
	/// <returns>The line spacing, in pixels, of this font.</returns>
	public float GetHeight()
	{
		return 0f;
	}

	/// <summary>Creates a GDI logical font (LOGFONT) structure from this <see cref="T:System.Drawing.Font" />.</summary>
	/// <param name="logFont">An <see cref="T:System.Object" /> to represent the <see langword="LOGFONT" /> structure that this method creates.</param>
	public void ToLogFont(object logFont)
	{
	}

	/// <summary>Creates a GDI logical font (LOGFONT) structure from this <see cref="T:System.Drawing.Font" />.</summary>
	/// <param name="logFont">An <see cref="T:System.Object" /> to represent the <see langword="LOGFONT" /> structure that this method creates.</param>
	/// <param name="graphics">A <see cref="T:System.Drawing.Graphics" /> that provides additional information for the <see langword="LOGFONT" /> structure.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="graphics" /> is <see langword="null" />.</exception>
	public void ToLogFont(object logFont, Graphics graphics)
	{
	}

	/// <summary>Returns the height, in pixels, of this <see cref="T:System.Drawing.Font" /> when drawn to a device with the specified vertical resolution.</summary>
	/// <param name="dpi">The vertical resolution, in dots per inch, used to calculate the height of the font.</param>
	/// <returns>The height, in pixels, of this <see cref="T:System.Drawing.Font" />.</returns>
	public float GetHeight(float dpi)
	{
		return 0f;
	}

	/// <summary>Returns a human-readable string representation of this <see cref="T:System.Drawing.Font" />.</summary>
	/// <returns>A string that represents this <see cref="T:System.Drawing.Font" />.</returns>
	public override string ToString()
	{
		return null;
	}
}
