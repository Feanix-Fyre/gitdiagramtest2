using System.Globalization;
using System.Runtime.Versioning;

namespace System;

/// <summary>Represents a character as a UTF-16 code unit.</summary>
[Serializable]
public readonly struct Char : IComparable, IComparable<char>, IEquatable<char>, IConvertible
{
	private readonly char m_value;

	/// <summary>Represents the largest possible value of a <see cref="T:System.Char" />. This field is constant.</summary>
	public const char MaxValue = '\uffff';

	/// <summary>Represents the smallest possible value of a <see cref="T:System.Char" />. This field is constant.</summary>
	public const char MinValue = '\0';

	private static readonly byte[] s_categoryForLatin1;

	internal const int UNICODE_PLANE00_END = 65535;

	internal const int UNICODE_PLANE01_START = 65536;

	internal const int UNICODE_PLANE16_END = 1114111;

	internal const int HIGH_SURROGATE_START = 55296;

	internal const int LOW_SURROGATE_END = 57343;

	private static bool IsLatin1(char ch)
	{
		return false;
	}

	private static bool IsAscii(char ch)
	{
		return false;
	}

	private static UnicodeCategory GetLatin1UnicodeCategory(char ch)
	{
		return default(UnicodeCategory);
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
	/// <param name="obj">An object to compare with this instance or <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is an instance of <see cref="T:System.Char" /> and equals the value of this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether this instance is equal to the specified <see cref="T:System.Char" /> object.</summary>
	/// <param name="obj">An object to compare to this instance.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="obj" /> parameter equals the value of this instance; otherwise, <see langword="false" />.</returns>
	[NonVersionable]
	public bool Equals(char obj)
	{
		return false;
	}

	/// <summary>Compares this instance to a specified object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="T:System.Object" />.</summary>
	/// <param name="value">An object to compare this instance to, or <see langword="null" />.</param>
	/// <returns>A signed number indicating the position of this instance in the sort order in relation to the <paramref name="value" /> parameter.  
	///   Return Value  
	///
	///   Description  
	///
	///   Less than zero  
	///
	///   This instance precedes <paramref name="value" />.  
	///
	///   Zero  
	///
	///   This instance has the same position in the sort order as <paramref name="value" />.  
	///
	///   Greater than zero  
	///
	///   This instance follows <paramref name="value" />.  
	///
	///  -or-  
	///
	///  <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="value" /> is not a <see cref="T:System.Char" /> object.</exception>
	public int CompareTo(object value)
	{
		return 0;
	}

	/// <summary>Compares this instance to a specified <see cref="T:System.Char" /> object and indicates whether this instance precedes, follows, or appears in the same position in the sort order as the specified <see cref="T:System.Char" /> object.</summary>
	/// <param name="value">A <see cref="T:System.Char" /> object to compare.</param>
	/// <returns>A signed number indicating the position of this instance in the sort order in relation to the <paramref name="value" /> parameter.  
	///   Return Value  
	///
	///   Description  
	///
	///   Less than zero  
	///
	///   This instance precedes <paramref name="value" />.  
	///
	///   Zero  
	///
	///   This instance has the same position in the sort order as <paramref name="value" />.  
	///
	///   Greater than zero  
	///
	///   This instance follows <paramref name="value" />.</returns>
	public int CompareTo(char value)
	{
		return 0;
	}

	/// <summary>Converts the value of this instance to its equivalent string representation.</summary>
	/// <returns>The string representation of the value of this instance.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Converts the value of this instance to its equivalent string representation using the specified culture-specific format information.</summary>
	/// <param name="provider">(Reserved) An object that supplies culture-specific formatting information.</param>
	/// <returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns>
	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Converts the specified Unicode character to its equivalent string representation.</summary>
	/// <param name="c">The Unicode character to convert.</param>
	/// <returns>The string representation of the value of <paramref name="c" />.</returns>
	public static string ToString(char c)
	{
		return null;
	}

	/// <summary>Converts the value of the specified string to its equivalent Unicode character.</summary>
	/// <param name="s">A string that contains a single character, or <see langword="null" />.</param>
	/// <returns>A Unicode character equivalent to the sole character in <paramref name="s" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">The length of <paramref name="s" /> is not 1.</exception>
	public static char Parse(string s)
	{
		return '\0';
	}

	/// <summary>Converts the value of the specified string to its equivalent Unicode character. A return code indicates whether the conversion succeeded or failed.</summary>
	/// <param name="s">A string that contains a single character, or <see langword="null" />.</param>
	/// <param name="result">When this method returns, contains a Unicode character equivalent to the sole character in <paramref name="s" />, if the conversion succeeded, or an undefined value if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is <see langword="null" /> or the length of <paramref name="s" /> is not 1. This parameter is passed uninitialized.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="s" /> parameter was converted successfully; otherwise, <see langword="false" />.</returns>
	public static bool TryParse(string s, out char result)
	{
		result = default(char);
		return false;
	}

	/// <summary>Indicates whether the specified Unicode character is categorized as a decimal digit.</summary>
	/// <param name="c">The Unicode character to evaluate.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="c" /> is a decimal digit; otherwise, <see langword="false" />.</returns>
	public static bool IsDigit(char c)
	{
		return false;
	}

	internal static bool CheckLetter(UnicodeCategory uc)
	{
		return false;
	}

	/// <summary>Indicates whether the specified Unicode character is categorized as a Unicode letter.</summary>
	/// <param name="c">The Unicode character to evaluate.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="c" /> is a letter; otherwise, <see langword="false" />.</returns>
	public static bool IsLetter(char c)
	{
		return false;
	}

	private static bool IsWhiteSpaceLatin1(char c)
	{
		return false;
	}

	/// <summary>Indicates whether the specified Unicode character is categorized as white space.</summary>
	/// <param name="c">The Unicode character to evaluate.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="c" /> is white space; otherwise, <see langword="false" />.</returns>
	public static bool IsWhiteSpace(char c)
	{
		return false;
	}

	/// <summary>Indicates whether the specified Unicode character is categorized as an uppercase letter.</summary>
	/// <param name="c">The Unicode character to evaluate.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="c" /> is an uppercase letter; otherwise, <see langword="false" />.</returns>
	public static bool IsUpper(char c)
	{
		return false;
	}

	/// <summary>Indicates whether the specified Unicode character is categorized as a lowercase letter.</summary>
	/// <param name="c">The Unicode character to evaluate.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="c" /> is a lowercase letter; otherwise, <see langword="false" />.</returns>
	public static bool IsLower(char c)
	{
		return false;
	}

	internal static bool CheckPunctuation(UnicodeCategory uc)
	{
		return false;
	}

	/// <summary>Indicates whether the specified Unicode character is categorized as a punctuation mark.</summary>
	/// <param name="c">The Unicode character to evaluate.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="c" /> is a punctuation mark; otherwise, <see langword="false" />.</returns>
	public static bool IsPunctuation(char c)
	{
		return false;
	}

	internal static bool CheckLetterOrDigit(UnicodeCategory uc)
	{
		return false;
	}

	/// <summary>Indicates whether the specified Unicode character is categorized as a letter or a decimal digit.</summary>
	/// <param name="c">The Unicode character to evaluate.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="c" /> is a letter or a decimal digit; otherwise, <see langword="false" />.</returns>
	public static bool IsLetterOrDigit(char c)
	{
		return false;
	}

	/// <summary>Converts the value of a specified Unicode character to its uppercase equivalent using specified culture-specific formatting information.</summary>
	/// <param name="c">The Unicode character to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules.</param>
	/// <returns>The uppercase equivalent of <paramref name="c" />, modified according to <paramref name="culture" />, or the unchanged value of <paramref name="c" /> if <paramref name="c" /> is already uppercase, has no uppercase equivalent, or is not alphabetic.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="culture" /> is <see langword="null" />.</exception>
	public static char ToUpper(char c, CultureInfo culture)
	{
		return '\0';
	}

	/// <summary>Converts the value of a Unicode character to its uppercase equivalent.</summary>
	/// <param name="c">The Unicode character to convert.</param>
	/// <returns>The uppercase equivalent of <paramref name="c" />, or the unchanged value of <paramref name="c" /> if <paramref name="c" /> is already uppercase, has no uppercase equivalent, or is not alphabetic.</returns>
	public static char ToUpper(char c)
	{
		return '\0';
	}

	/// <summary>Converts the value of a Unicode character to its uppercase equivalent using the casing rules of the invariant culture.</summary>
	/// <param name="c">The Unicode character to convert.</param>
	/// <returns>The uppercase equivalent of the <paramref name="c" /> parameter, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already uppercase or not alphabetic.</returns>
	public static char ToUpperInvariant(char c)
	{
		return '\0';
	}

	/// <summary>Converts the value of a specified Unicode character to its lowercase equivalent using specified culture-specific formatting information.</summary>
	/// <param name="c">The Unicode character to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules.</param>
	/// <returns>The lowercase equivalent of <paramref name="c" />, modified according to <paramref name="culture" />, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already lowercase or not alphabetic.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="culture" /> is <see langword="null" />.</exception>
	public static char ToLower(char c, CultureInfo culture)
	{
		return '\0';
	}

	/// <summary>Converts the value of a Unicode character to its lowercase equivalent.</summary>
	/// <param name="c">The Unicode character to convert.</param>
	/// <returns>The lowercase equivalent of <paramref name="c" />, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already lowercase or not alphabetic.</returns>
	public static char ToLower(char c)
	{
		return '\0';
	}

	/// <summary>Converts the value of a Unicode character to its lowercase equivalent using the casing rules of the invariant culture.</summary>
	/// <param name="c">The Unicode character to convert.</param>
	/// <returns>The lowercase equivalent of the <paramref name="c" /> parameter, or the unchanged value of <paramref name="c" />, if <paramref name="c" /> is already lowercase or not alphabetic.</returns>
	public static char ToLowerInvariant(char c)
	{
		return '\0';
	}

	/// <summary>Returns the <see cref="T:System.TypeCode" /> for value type <see cref="T:System.Char" />.</summary>
	/// <returns>The enumerated constant, <see cref="F:System.TypeCode.Char" />.</returns>
	public TypeCode GetTypeCode()
	{
		return default(TypeCode);
	}

	/// <summary>Note This conversion is not supported. Attempting to do so throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>This conversion is not supported. No value is returned.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported.</exception>
	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return false;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current <see cref="T:System.Char" /> object unchanged.</returns>
	char IConvertible.ToChar(IFormatProvider provider)
	{
		return '\0';
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object. (Specify <see langword="null" /> because the <paramref name="provider" /> parameter is ignored.)</param>
	/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object. (Specify <see langword="null" /> because the <paramref name="provider" /> parameter is ignored.)</param>
	/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return 0u;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return 0L;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
	/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object. (Specify <see langword="null" /> because the <paramref name="provider" /> parameter is ignored.)</param>
	/// <returns>The converted value of the current <see cref="T:System.Char" /> object.</returns>
	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return 0uL;
	}

	/// <summary>Note This conversion is not supported. Attempting to do so throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>No value is returned.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported.</exception>
	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return 0f;
	}

	/// <summary>Note This conversion is not supported. Attempting to do so throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>No value is returned.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported.</exception>
	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return 0.0;
	}

	/// <summary>Note This conversion is not supported. Attempting to do so throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>No value is returned.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported.</exception>
	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return default(decimal);
	}

	/// <summary>Note This conversion is not supported. Attempting to do so throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>No value is returned.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported.</exception>
	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		return default(DateTime);
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
	/// <param name="type">A <see cref="T:System.Type" /> object.</param>
	/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object.</param>
	/// <returns>An object of the specified type.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The value of the current <see cref="T:System.Char" /> object cannot be converted to the type specified by the <paramref name="type" /> parameter.</exception>
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Indicates whether the specified Unicode character is categorized as a control character.</summary>
	/// <param name="c">The Unicode character to evaluate.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="c" /> is a control character; otherwise, <see langword="false" />.</returns>
	public static bool IsControl(char c)
	{
		return false;
	}

	internal static bool CheckNumber(UnicodeCategory uc)
	{
		return false;
	}

	/// <summary>Indicates whether the specified Unicode character is categorized as a number.</summary>
	/// <param name="c">The Unicode character to evaluate.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="c" /> is a number; otherwise, <see langword="false" />.</returns>
	public static bool IsNumber(char c)
	{
		return false;
	}

	/// <summary>Indicates whether the character at the specified position in a specified string is categorized as a number.</summary>
	/// <param name="s">A string.</param>
	/// <param name="index">The position of the character to evaluate in <paramref name="s" />.</param>
	/// <returns>
	///   <see langword="true" /> if the character at position <paramref name="index" /> in <paramref name="s" /> is a number; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />.</exception>
	public static bool IsNumber(string s, int index)
	{
		return false;
	}

	internal static bool CheckSeparator(UnicodeCategory uc)
	{
		return false;
	}

	private static bool IsSeparatorLatin1(char c)
	{
		return false;
	}

	/// <summary>Indicates whether the specified Unicode character is categorized as a separator character.</summary>
	/// <param name="c">The Unicode character to evaluate.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="c" /> is a separator character; otherwise, <see langword="false" />.</returns>
	public static bool IsSeparator(char c)
	{
		return false;
	}

	/// <summary>Indicates whether the specified character has a surrogate code unit.</summary>
	/// <param name="c">The Unicode character to evaluate.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="c" /> is either a high surrogate or a low surrogate; otherwise, <see langword="false" />.</returns>
	public static bool IsSurrogate(char c)
	{
		return false;
	}

	/// <summary>Indicates whether the character at the specified position in a specified string has a surrogate code unit.</summary>
	/// <param name="s">A string.</param>
	/// <param name="index">The position of the character to evaluate in <paramref name="s" />.</param>
	/// <returns>
	///   <see langword="true" /> if the character at position <paramref name="index" /> in <paramref name="s" /> is a either a high surrogate or a low surrogate; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />.</exception>
	public static bool IsSurrogate(string s, int index)
	{
		return false;
	}

	/// <summary>Indicates whether the character at the specified position in a specified string is categorized as white space.</summary>
	/// <param name="s">A string.</param>
	/// <param name="index">The position of the character to evaluate in <paramref name="s" />.</param>
	/// <returns>
	///   <see langword="true" /> if the character at position <paramref name="index" /> in <paramref name="s" /> is white space; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />.</exception>
	public static bool IsWhiteSpace(string s, int index)
	{
		return false;
	}

	/// <summary>Categorizes a specified Unicode character into a group identified by one of the <see cref="T:System.Globalization.UnicodeCategory" /> values.</summary>
	/// <param name="c">The Unicode character to categorize.</param>
	/// <returns>A <see cref="T:System.Globalization.UnicodeCategory" /> value that identifies the group that contains <paramref name="c" />.</returns>
	public static UnicodeCategory GetUnicodeCategory(char c)
	{
		return default(UnicodeCategory);
	}

	/// <summary>Categorizes the character at the specified position in a specified string into a group identified by one of the <see cref="T:System.Globalization.UnicodeCategory" /> values.</summary>
	/// <param name="s">A <see cref="T:System.String" />.</param>
	/// <param name="index">The character position in <paramref name="s" />.</param>
	/// <returns>A <see cref="T:System.Globalization.UnicodeCategory" /> enumerated constant that identifies the group that contains the character at position <paramref name="index" /> in <paramref name="s" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero or greater than the last position in <paramref name="s" />.</exception>
	public static UnicodeCategory GetUnicodeCategory(string s, int index)
	{
		return default(UnicodeCategory);
	}

	/// <summary>Indicates whether the specified <see cref="T:System.Char" /> object is a high surrogate.</summary>
	/// <param name="c">The Unicode character to evaluate.</param>
	/// <returns>
	///   <see langword="true" /> if the numeric value of the <paramref name="c" /> parameter ranges from U+D800 through U+DBFF; otherwise, <see langword="false" />.</returns>
	public static bool IsHighSurrogate(char c)
	{
		return false;
	}

	/// <summary>Indicates whether the <see cref="T:System.Char" /> object at the specified position in a string is a high surrogate.</summary>
	/// <param name="s">A string.</param>
	/// <param name="index">The position of the character to evaluate in <paramref name="s" />.</param>
	/// <returns>
	///   <see langword="true" /> if the numeric value of the specified character in the <paramref name="s" /> parameter ranges from U+D800 through U+DBFF; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is not a position within <paramref name="s" />.</exception>
	public static bool IsHighSurrogate(string s, int index)
	{
		return false;
	}

	/// <summary>Indicates whether the specified <see cref="T:System.Char" /> object is a low surrogate.</summary>
	/// <param name="c">The character to evaluate.</param>
	/// <returns>
	///   <see langword="true" /> if the numeric value of the <paramref name="c" /> parameter ranges from U+DC00 through U+DFFF; otherwise, <see langword="false" />.</returns>
	public static bool IsLowSurrogate(char c)
	{
		return false;
	}

	/// <summary>Indicates whether the two specified <see cref="T:System.Char" /> objects form a surrogate pair.</summary>
	/// <param name="highSurrogate">The character to evaluate as the high surrogate of a surrogate pair.</param>
	/// <param name="lowSurrogate">The character to evaluate as the low surrogate of a surrogate pair.</param>
	/// <returns>
	///   <see langword="true" /> if the numeric value of the <paramref name="highSurrogate" /> parameter ranges from U+D800 through U+DBFF, and the numeric value of the <paramref name="lowSurrogate" /> parameter ranges from U+DC00 through U+DFFF; otherwise, <see langword="false" />.</returns>
	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate)
	{
		return false;
	}

	/// <summary>Converts the value of a UTF-16 encoded surrogate pair into a Unicode code point.</summary>
	/// <param name="highSurrogate">A high surrogate code unit (that is, a code unit ranging from U+D800 through U+DBFF).</param>
	/// <param name="lowSurrogate">A low surrogate code unit (that is, a code unit ranging from U+DC00 through U+DFFF).</param>
	/// <returns>The 21-bit Unicode code point represented by the <paramref name="highSurrogate" /> and <paramref name="lowSurrogate" /> parameters.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="highSurrogate" /> is not in the range U+D800 through U+DBFF, or <paramref name="lowSurrogate" /> is not in the range U+DC00 through U+DFFF.</exception>
	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate)
	{
		return 0;
	}
}
