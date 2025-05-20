using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace System.Globalization;

/// <summary>Defines text properties and behaviors, such as casing, that are specific to a writing system.</summary>
[Serializable]
[ComVisible(true)]
public class TextInfo : ICloneable, IDeserializationCallback
{
	[OptionalField(VersionAdded = 2)]
	private string m_listSeparator;

	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly;

	[OptionalField(VersionAdded = 3)]
	private string m_cultureName;

	[NonSerialized]
	private CultureData m_cultureData;

	[NonSerialized]
	private string m_textInfoName;

	[NonSerialized]
	private bool? m_IsAsciiCasingSameAsInvariant;

	internal static TextInfo s_Invariant;

	[OptionalField(VersionAdded = 2)]
	private string customCultureName;

	[OptionalField(VersionAdded = 1)]
	internal int m_nDataItem;

	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride;

	[OptionalField(VersionAdded = 1)]
	internal int m_win32LangID;

	private const int wordSeparatorMask = 536672256;

	internal static TextInfo Invariant => null;

	/// <summary>Gets the American National Standards Institute (ANSI) code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</summary>
	/// <returns>The ANSI code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</returns>
	public virtual int ANSICodePage => 0;

	/// <summary>Gets the name of the culture associated with the current <see cref="T:System.Globalization.TextInfo" /> object.</summary>
	/// <returns>The name of a culture.</returns>
	[ComVisible(false)]
	public string CultureName => null;

	/// <summary>Gets or sets the string that separates items in a list.</summary>
	/// <returns>The string that separates items in a list.</returns>
	/// <exception cref="T:System.ArgumentNullException">The value in a set operation is null.</exception>
	/// <exception cref="T:System.InvalidOperationException">In a set operation, the current <see cref="T:System.Globalization.TextInfo" /> object is read-only.</exception>
	public virtual string ListSeparator => null;

	private bool IsAsciiCasingSameAsInvariant => false;

	/// <summary>Gets a value indicating whether the current <see cref="T:System.Globalization.TextInfo" /> object represents a writing system where text flows from right to left.</summary>
	/// <returns>
	///   <see langword="true" /> if text flows from right to left; otherwise, <see langword="false" />.</returns>
	[ComVisible(false)]
	public bool IsRightToLeft => false;

	internal TextInfo(CultureData cultureData)
	{
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
	}

	private void OnDeserialized()
	{
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
	}

	/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Globalization.TextInfo" /> object.</summary>
	/// <returns>A new instance of <see cref="T:System.Object" /> that is the memberwise clone of the current <see cref="T:System.Globalization.TextInfo" /> object.</returns>
	[ComVisible(false)]
	public virtual object Clone()
	{
		return null;
	}

	internal void SetReadOnlyState(bool readOnly)
	{
	}

	/// <summary>Converts the specified character to lowercase.</summary>
	/// <param name="c">The character to convert to lowercase.</param>
	/// <returns>The specified character converted to lowercase.</returns>
	public virtual char ToLower(char c)
	{
		return '\0';
	}

	/// <summary>Converts the specified string to lowercase.</summary>
	/// <param name="str">The string to convert to lowercase.</param>
	/// <returns>The specified string converted to lowercase.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="str" /> is null.</exception>
	public virtual string ToLower(string str)
	{
		return null;
	}

	private static char ToLowerAsciiInvariant(char c)
	{
		return '\0';
	}

	/// <summary>Converts the specified character to uppercase.</summary>
	/// <param name="c">The character to convert to uppercase.</param>
	/// <returns>The specified character converted to uppercase.</returns>
	public virtual char ToUpper(char c)
	{
		return '\0';
	}

	/// <summary>Converts the specified string to uppercase.</summary>
	/// <param name="str">The string to convert to uppercase.</param>
	/// <returns>The specified string converted to uppercase.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="str" /> is null.</exception>
	public virtual string ToUpper(string str)
	{
		return null;
	}

	internal static char ToUpperAsciiInvariant(char c)
	{
		return '\0';
	}

	private static bool IsAscii(char c)
	{
		return false;
	}

	/// <summary>Determines whether the specified object represents the same writing system as the current <see cref="T:System.Globalization.TextInfo" /> object.</summary>
	/// <param name="obj">The object to compare with the current <see cref="T:System.Globalization.TextInfo" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> represents the same writing system as the current <see cref="T:System.Globalization.TextInfo" />; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Serves as a hash function for the current <see cref="T:System.Globalization.TextInfo" />, suitable for hashing algorithms and data structures, such as a hash table.</summary>
	/// <returns>A hash code for the current <see cref="T:System.Globalization.TextInfo" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Globalization.TextInfo" />.</summary>
	/// <returns>A string that represents the current <see cref="T:System.Globalization.TextInfo" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Converts the specified string to title case (except for words that are entirely in uppercase, which are considered to be acronyms).</summary>
	/// <param name="str">The string to convert to title case.</param>
	/// <returns>The specified string converted to title case.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="str" /> is <see langword="null" />.</exception>
	public string ToTitleCase(string str)
	{
		return null;
	}

	private static int AddNonLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen)
	{
		return 0;
	}

	private int AddTitlecaseLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen)
	{
		return 0;
	}

	private static bool IsWordSeparator(UnicodeCategory category)
	{
		return false;
	}

	private static bool IsLetterCategory(UnicodeCategory uc)
	{
		return false;
	}

	/// <summary>Raises the deserialization event when deserialization is complete.</summary>
	/// <param name="sender">The source of the deserialization event.</param>
	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	private string ToUpperInternal(string str)
	{
		return null;
	}

	private string ToLowerInternal(string str)
	{
		return null;
	}

	private char ToUpperInternal(char c)
	{
		return '\0';
	}

	private char ToLowerInternal(char c)
	{
		return '\0';
	}

	internal void ToUpperAsciiInvariant(ReadOnlySpan<char> source, Span<char> destination)
	{
	}

	internal void ChangeCase(ReadOnlySpan<char> source, Span<char> destination, bool toUpper)
	{
	}

	internal TextInfo()
	{
	}
}
