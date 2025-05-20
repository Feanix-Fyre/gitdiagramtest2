using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System;

/// <summary>Represents a globally unique identifier (GUID).</summary>
[Serializable]
[NonVersionable]
public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>, ISpanFormattable
{
	[Flags]
	private enum GuidStyles
	{
		None = 0,
		AllowParenthesis = 1,
		AllowBraces = 2,
		AllowDashes = 4,
		AllowHexPrefix = 8,
		RequireParenthesis = 0x10,
		RequireBraces = 0x20,
		RequireDashes = 0x40,
		RequireHexPrefix = 0x80,
		HexFormat = 0xA0,
		NumberFormat = 0,
		DigitFormat = 0x40,
		BraceFormat = 0x60,
		ParenthesisFormat = 0x50,
		Any = 0xF
	}

	private enum GuidParseThrowStyle
	{
		None = 0,
		All = 1,
		AllButOverflow = 2
	}

	private enum ParseFailureKind
	{
		None = 0,
		ArgumentNull = 1,
		Format = 2,
		FormatWithParameter = 3,
		NativeException = 4,
		FormatWithInnerException = 5
	}

	private struct GuidResult
	{
		internal Guid _parsedGuid;

		internal GuidParseThrowStyle _throwStyle;

		private ParseFailureKind _failure;

		private string _failureMessageID;

		private object _failureMessageFormatArgument;

		private string _failureArgumentName;

		private Exception _innerException;

		internal void Init(GuidParseThrowStyle canThrow)
		{
		}

		internal void SetFailure(Exception nativeException)
		{
		}

		internal void SetFailure(ParseFailureKind failure, string failureMessageID)
		{
		}

		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
		{
		}

		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException)
		{
		}

		internal Exception GetGuidParseException()
		{
			return null;
		}
	}

	/// <summary>A read-only instance of the <see cref="T:System.Guid" /> structure whose value is all zeros.</summary>
	public static readonly Guid Empty;

	private int _a;

	private short _b;

	private short _c;

	private byte _d;

	private byte _e;

	private byte _f;

	private byte _g;

	private byte _h;

	private byte _i;

	private byte _j;

	private byte _k;

	/// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> structure.</summary>
	/// <returns>A new GUID object.</returns>
	public static Guid NewGuid()
	{
		return default(Guid);
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> structure by using the specified array of bytes.</summary>
	/// <param name="b">A 16-element byte array containing values with which to initialize the GUID.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="b" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="b" /> is not 16 bytes long.</exception>
	public Guid(byte[] b)
	{
		_a = 0;
		_b = 0;
		_c = 0;
		_d = 0;
		_e = 0;
		_f = 0;
		_g = 0;
		_h = 0;
		_i = 0;
		_j = 0;
		_k = 0;
	}

	public Guid(ReadOnlySpan<byte> b)
	{
		_a = 0;
		_b = 0;
		_c = 0;
		_d = 0;
		_e = 0;
		_f = 0;
		_g = 0;
		_h = 0;
		_i = 0;
		_j = 0;
		_k = 0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> structure by using the specified integers and byte array.</summary>
	/// <param name="a">The first 4 bytes of the GUID.</param>
	/// <param name="b">The next 2 bytes of the GUID.</param>
	/// <param name="c">The next 2 bytes of the GUID.</param>
	/// <param name="d">The remaining 8 bytes of the GUID.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="d" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="d" /> is not 8 bytes long.</exception>
	public Guid(int a, short b, short c, byte[] d)
	{
		_a = 0;
		_b = 0;
		_c = 0;
		_d = 0;
		_e = 0;
		_f = 0;
		_g = 0;
		_h = 0;
		_i = 0;
		_j = 0;
		_k = 0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> structure by using the specified integers and bytes.</summary>
	/// <param name="a">The first 4 bytes of the GUID.</param>
	/// <param name="b">The next 2 bytes of the GUID.</param>
	/// <param name="c">The next 2 bytes of the GUID.</param>
	/// <param name="d">The next byte of the GUID.</param>
	/// <param name="e">The next byte of the GUID.</param>
	/// <param name="f">The next byte of the GUID.</param>
	/// <param name="g">The next byte of the GUID.</param>
	/// <param name="h">The next byte of the GUID.</param>
	/// <param name="i">The next byte of the GUID.</param>
	/// <param name="j">The next byte of the GUID.</param>
	/// <param name="k">The next byte of the GUID.</param>
	public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
	{
		_a = 0;
		_b = 0;
		_c = 0;
		_d = 0;
		_e = 0;
		_f = 0;
		_g = 0;
		_h = 0;
		_i = 0;
		_j = 0;
		_k = 0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> structure by using the value represented by the specified string.</summary>
	/// <param name="g">A string that contains a GUID in one of the following formats ("d" represents a hexadecimal digit whose case is ignored):  
	///  32 contiguous digits:  
	///  dddddddddddddddddddddddddddddddd  
	///  -or-  
	///  Groups of 8, 4, 4, 4, and 12 digits with hyphens between the groups. The entire GUID can optionally be enclosed in matching braces or parentheses:  
	///  dddddddd-dddd-dddd-dddd-dddddddddddd  
	///  -or-  
	///  {dddddddd-dddd-dddd-dddd-dddddddddddd}  
	///  -or-  
	///  (dddddddd-dddd-dddd-dddd-dddddddddddd)  
	///  -or-  
	///  Groups of 8, 4, and 4 digits, and a subset of eight groups of 2 digits, with each group prefixed by "0x" or "0X", and separated by commas. The entire GUID, as well as the subset, is enclosed in matching braces:  
	///  {0xdddddddd, 0xdddd, 0xdddd,{0xdd,0xdd,0xdd,0xdd,0xdd,0xdd,0xdd,0xdd}}  
	///  All braces, commas, and "0x" prefixes are required. All embedded spaces are ignored. All leading zeros in a group are ignored.  
	///  The digits shown in a group are the maximum number of meaningful digits that can appear in that group. You can specify from 1 to the number of digits shown for a group. The specified digits are assumed to be the low-order digits of the group.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="g" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">The format of <paramref name="g" /> is invalid.</exception>
	/// <exception cref="T:System.OverflowException">The format of <paramref name="g" /> is invalid.</exception>
	public Guid(string g)
	{
		_a = 0;
		_b = 0;
		_c = 0;
		_d = 0;
		_e = 0;
		_f = 0;
		_g = 0;
		_h = 0;
		_i = 0;
		_j = 0;
		_k = 0;
	}

	/// <summary>Converts the string representation of a GUID to the equivalent <see cref="T:System.Guid" /> structure.</summary>
	/// <param name="input">The string to convert.</param>
	/// <returns>A structure that contains the value that was parsed.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="input" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="input" /> is not in a recognized format.</exception>
	public static Guid Parse(string input)
	{
		return default(Guid);
	}

	public static Guid Parse(ReadOnlySpan<char> input)
	{
		return default(Guid);
	}

	/// <summary>Converts the string representation of a GUID to the equivalent <see cref="T:System.Guid" /> structure.</summary>
	/// <param name="input">The GUID to convert.</param>
	/// <param name="result">The structure that will contain the parsed value. If the method returns <see langword="true" />, <paramref name="result" /> contains a valid <see cref="T:System.Guid" />. If the method returns <see langword="false" />, <paramref name="result" /> equals <see cref="F:System.Guid.Empty" />.</param>
	/// <returns>
	///   <see langword="true" /> if the parse operation was successful; otherwise, <see langword="false" />.</returns>
	public static bool TryParse(string input, out Guid result)
	{
		result = default(Guid);
		return false;
	}

	public static bool TryParse(ReadOnlySpan<char> input, out Guid result)
	{
		result = default(Guid);
		return false;
	}

	/// <summary>Converts the string representation of a GUID to the equivalent <see cref="T:System.Guid" /> structure, provided that the string is in the specified format.</summary>
	/// <param name="input">The GUID to convert.</param>
	/// <param name="format">One of the following specifiers that indicates the exact format to use when interpreting <paramref name="input" />: "N", "D", "B", "P", or "X".</param>
	/// <param name="result">The structure that will contain the parsed value. If the method returns <see langword="true" />, <paramref name="result" /> contains a valid <see cref="T:System.Guid" />. If the method returns <see langword="false" />, <paramref name="result" /> equals <see cref="F:System.Guid.Empty" />.</param>
	/// <returns>
	///   <see langword="true" /> if the parse operation was successful; otherwise, <see langword="false" />.</returns>
	public static bool TryParseExact(string input, string format, out Guid result)
	{
		result = default(Guid);
		return false;
	}

	public static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, out Guid result)
	{
		result = default(Guid);
		return false;
	}

	private static bool TryParseGuid(ReadOnlySpan<char> guidString, GuidStyles flags, ref GuidResult result)
	{
		return false;
	}

	private static bool TryParseGuidWithHexPrefix(ReadOnlySpan<char> guidString, ref GuidResult result)
	{
		return false;
	}

	private static bool TryParseGuidWithNoStyle(ReadOnlySpan<char> guidString, ref GuidResult result)
	{
		return false;
	}

	private static bool TryParseGuidWithDashes(ReadOnlySpan<char> guidString, ref GuidResult result)
	{
		return false;
	}

	private static bool StringToShort(ReadOnlySpan<char> str, int requiredLength, int flags, out short result, ref GuidResult parseResult)
	{
		result = default(short);
		return false;
	}

	private static bool StringToShort(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out short result, ref GuidResult parseResult)
	{
		result = default(short);
		return false;
	}

	private static bool StringToInt(ReadOnlySpan<char> str, int requiredLength, int flags, out int result, ref GuidResult parseResult)
	{
		result = default(int);
		return false;
	}

	private static bool StringToInt(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out int result, ref GuidResult parseResult)
	{
		result = default(int);
		return false;
	}

	private static bool StringToLong(ReadOnlySpan<char> str, ref int parsePos, int flags, out long result, ref GuidResult parseResult)
	{
		result = default(long);
		return false;
	}

	private static ReadOnlySpan<char> EatAllWhitespace(ReadOnlySpan<char> str)
	{
		return default(ReadOnlySpan<char>);
	}

	private static bool IsHexPrefix(ReadOnlySpan<char> str, int i)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void WriteByteHelper(Span<byte> destination)
	{
	}

	/// <summary>Returns a 16-element byte array that contains the value of this instance.</summary>
	/// <returns>A 16-element byte array.</returns>
	public byte[] ToByteArray()
	{
		return null;
	}

	/// <summary>Returns a string representation of the value of this instance in registry format.</summary>
	/// <returns>The value of this <see cref="T:System.Guid" />, formatted by using the "D" format specifier as follows:  
	///  xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx  
	///  where the value of the GUID is represented as a series of lowercase hexadecimal digits in groups of 8, 4, 4, 4, and 12 digits and separated by hyphens. An example of a return value is "382c74c3-721d-4f34-80e5-57657b6cbc27". To convert the hexadecimal digits from a through f to uppercase, call the <see cref="M:System.String.ToUpper" /> method on the returned string.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>The hash code for this instance.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
	/// <param name="o">The object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="o" /> is a <see cref="T:System.Guid" /> that has the same value as this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object o)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Guid" /> object represent the same value.</summary>
	/// <param name="g">An object to compare to this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="g" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
	public bool Equals(Guid g)
	{
		return false;
	}

	private int GetResult(uint me, uint them)
	{
		return 0;
	}

	/// <summary>Compares this instance to a specified object and returns an indication of their relative values.</summary>
	/// <param name="value">An object to compare, or <see langword="null" />.</param>
	/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.  
	///   Return value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance is less than <paramref name="value" />.  
	///
	///   Zero  
	///
	///   This instance is equal to <paramref name="value" />.  
	///
	///   A positive integer  
	///
	///   This instance is greater than <paramref name="value" />, or <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="value" /> is not a <see cref="T:System.Guid" />.</exception>
	public int CompareTo(object value)
	{
		return 0;
	}

	/// <summary>Compares this instance to a specified <see cref="T:System.Guid" /> object and returns an indication of their relative values.</summary>
	/// <param name="value">An object to compare to this instance.</param>
	/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.  
	///   Return value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance is less than <paramref name="value" />.  
	///
	///   Zero  
	///
	///   This instance is equal to <paramref name="value" />.  
	///
	///   A positive integer  
	///
	///   This instance is greater than <paramref name="value" />.</returns>
	public int CompareTo(Guid value)
	{
		return 0;
	}

	/// <summary>Indicates whether the values of two specified <see cref="T:System.Guid" /> objects are equal.</summary>
	/// <param name="a">The first object to compare.</param>
	/// <param name="b">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="a" /> and <paramref name="b" /> are equal; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(Guid a, Guid b)
	{
		return false;
	}

	/// <summary>Indicates whether the values of two specified <see cref="T:System.Guid" /> objects are not equal.</summary>
	/// <param name="a">The first object to compare.</param>
	/// <param name="b">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="a" /> and <paramref name="b" /> are not equal; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(Guid a, Guid b)
	{
		return false;
	}

	/// <summary>Returns a string representation of the value of this <see cref="T:System.Guid" /> instance, according to the provided format specifier.</summary>
	/// <param name="format">A single format specifier that indicates how to format the value of this <see cref="T:System.Guid" />. The <paramref name="format" /> parameter can be "N", "D", "B", "P", or "X". If <paramref name="format" /> is <see langword="null" /> or an empty string (""), "D" is used.</param>
	/// <returns>The value of this <see cref="T:System.Guid" />, represented as a series of lowercase hexadecimal digits in the specified format.</returns>
	/// <exception cref="T:System.FormatException">The value of <paramref name="format" /> is not <see langword="null" />, an empty string (""), "N", "D", "B", "P", or "X".</exception>
	public string ToString(string format)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static char HexToChar(int a)
	{
		return '\0';
	}

	private unsafe static int HexsToChars(char* guidChars, int a, int b)
	{
		return 0;
	}

	private unsafe static int HexsToCharsHexOutput(char* guidChars, int a, int b)
	{
		return 0;
	}

	/// <summary>Returns a string representation of the value of this instance of the <see cref="T:System.Guid" /> class, according to the provided format specifier and culture-specific format information.</summary>
	/// <param name="format">A single format specifier that indicates how to format the value of this <see cref="T:System.Guid" />. The <paramref name="format" /> parameter can be "N", "D", "B", "P", or "X". If <paramref name="format" /> is <see langword="null" /> or an empty string (""), "D" is used.</param>
	/// <param name="provider">(Reserved) An object that supplies culture-specific formatting information.</param>
	/// <returns>The value of this <see cref="T:System.Guid" />, represented as a series of lowercase hexadecimal digits in the specified format.</returns>
	/// <exception cref="T:System.FormatException">The value of <paramref name="format" /> is not <see langword="null" />, an empty string (""), "N", "D", "B", "P", or "X".</exception>
	public string ToString(string format, IFormatProvider provider)
	{
		return null;
	}

	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>))
	{
		charsWritten = default(int);
		return false;
	}

	bool ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
	{
		charsWritten = default(int);
		return false;
	}
}
