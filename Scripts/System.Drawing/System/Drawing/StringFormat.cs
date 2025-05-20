using System.Drawing.Text;

namespace System.Drawing;

/// <summary>Encapsulates text layout information (such as alignment, orientation and tab stops) display manipulations (such as ellipsis insertion and national digit substitution) and OpenType features. This class cannot be inherited.</summary>
public sealed class StringFormat : MarshalByRefObject, IDisposable, ICloneable
{
	private IntPtr nativeStrFmt;

	/// <summary>Gets or sets horizontal alignment of the string.</summary>
	/// <returns>A <see cref="T:System.Drawing.StringAlignment" /> enumeration that specifies the horizontal  alignment of the string.</returns>
	public StringAlignment Alignment
	{
		get
		{
			return default(StringAlignment);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the vertical alignment of the string.</summary>
	/// <returns>A <see cref="T:System.Drawing.StringAlignment" /> enumeration that represents the vertical line alignment.</returns>
	public StringAlignment LineAlignment
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a <see cref="T:System.Drawing.StringFormatFlags" /> enumeration that contains formatting information.</summary>
	/// <returns>A <see cref="T:System.Drawing.StringFormatFlags" /> enumeration that contains formatting information.</returns>
	public StringFormatFlags FormatFlags
	{
		get
		{
			return default(StringFormatFlags);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Drawing.Text.HotkeyPrefix" /> object for this <see cref="T:System.Drawing.StringFormat" /> object.</summary>
	/// <returns>The <see cref="T:System.Drawing.Text.HotkeyPrefix" /> object for this <see cref="T:System.Drawing.StringFormat" /> object, the default is <see cref="F:System.Drawing.Text.HotkeyPrefix.None" />.</returns>
	public HotkeyPrefix HotkeyPrefix
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Drawing.StringTrimming" /> enumeration for this <see cref="T:System.Drawing.StringFormat" /> object.</summary>
	/// <returns>A <see cref="T:System.Drawing.StringTrimming" /> enumeration that indicates how text drawn with this <see cref="T:System.Drawing.StringFormat" /> object is trimmed when it exceeds the edges of the layout rectangle.</returns>
	public StringTrimming Trimming
	{
		set
		{
		}
	}

	/// <summary>Gets a generic typographic <see cref="T:System.Drawing.StringFormat" /> object.</summary>
	/// <returns>A generic typographic <see cref="T:System.Drawing.StringFormat" /> object.</returns>
	public static StringFormat GenericTypographic => null;

	internal IntPtr NativeObject => (IntPtr)0;

	/// <summary>Initializes a new <see cref="T:System.Drawing.StringFormat" /> object.</summary>
	public StringFormat()
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.StringFormat" /> object with the specified <see cref="T:System.Drawing.StringFormatFlags" /> enumeration and language.</summary>
	/// <param name="options">The <see cref="T:System.Drawing.StringFormatFlags" /> enumeration for the new <see cref="T:System.Drawing.StringFormat" /> object.</param>
	/// <param name="language">A value that indicates the language of the text.</param>
	public StringFormat(StringFormatFlags options, int language)
	{
	}

	internal StringFormat(IntPtr native)
	{
	}

	/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
	~StringFormat()
	{
	}

	/// <summary>Releases all resources used by this <see cref="T:System.Drawing.StringFormat" /> object.</summary>
	public void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Drawing.StringFormat" /> object from the specified existing <see cref="T:System.Drawing.StringFormat" /> object.</summary>
	/// <param name="format">The <see cref="T:System.Drawing.StringFormat" /> object from which to initialize the new <see cref="T:System.Drawing.StringFormat" /> object.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="format" /> is <see langword="null" />.</exception>
	public StringFormat(StringFormat format)
	{
	}

	/// <summary>Creates an exact copy of this <see cref="T:System.Drawing.StringFormat" /> object.</summary>
	/// <returns>The <see cref="T:System.Drawing.StringFormat" /> object this method creates.</returns>
	public object Clone()
	{
		return null;
	}

	/// <summary>Converts this <see cref="T:System.Drawing.StringFormat" /> object to a human-readable string.</summary>
	/// <returns>A string representation of this <see cref="T:System.Drawing.StringFormat" /> object.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Sets tab stops for this <see cref="T:System.Drawing.StringFormat" /> object.</summary>
	/// <param name="firstTabOffset">The number of spaces between the beginning of a line of text and the first tab stop.</param>
	/// <param name="tabStops">An array of distances between tab stops in the units specified by the <see cref="P:System.Drawing.Graphics.PageUnit" /> property.</param>
	public void SetTabStops(float firstTabOffset, float[] tabStops)
	{
	}
}
