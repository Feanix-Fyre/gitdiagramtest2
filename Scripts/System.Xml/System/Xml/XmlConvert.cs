using System.Text.RegularExpressions;

namespace System.Xml;

/// <summary>Encodes and decodes XML names, and provides methods for converting between common language runtime types and XML Schema definition language (XSD) types. When converting data types, the values returned are locale-independent.</summary>
public class XmlConvert
{
	private static XmlCharType xmlCharType;

	internal static char[] crt;

	private static readonly int c_EncodedCharLength;

	private static Regex c_EncodeCharPattern;

	private static Regex c_DecodeCharPattern;

	private static string[] s_allDateTimeFormats;

	internal static readonly char[] WhitespaceChars;

	private static string[] AllDateTimeFormats => null;

	/// <summary>Converts the name to a valid XML name.</summary>
	/// <param name="name">A name to be translated. </param>
	/// <returns>Returns the name with any invalid characters replaced by an escape string.</returns>
	public static string EncodeName(string name)
	{
		return null;
	}

	/// <summary>Converts the name to a valid XML local name.</summary>
	/// <param name="name">The name to be encoded. </param>
	/// <returns>The encoded name.</returns>
	public static string EncodeLocalName(string name)
	{
		return null;
	}

	/// <summary>Decodes a name. This method does the reverse of the <see cref="M:System.Xml.XmlConvert.EncodeName(System.String)" /> and <see cref="M:System.Xml.XmlConvert.EncodeLocalName(System.String)" /> methods.</summary>
	/// <param name="name">The name to be transformed. </param>
	/// <returns>The decoded name.</returns>
	public static string DecodeName(string name)
	{
		return null;
	}

	private static string EncodeName(string name, bool first, bool local)
	{
		return null;
	}

	private static int FromHex(char digit)
	{
		return 0;
	}

	internal static byte[] FromBinHexString(string s)
	{
		return null;
	}

	internal static byte[] FromBinHexString(string s, bool allowOddCount)
	{
		return null;
	}

	internal static string ToBinHexString(byte[] inArray)
	{
		return null;
	}

	/// <summary>Verifies that the name is a valid name according to the W3C Extended Markup Language recommendation.</summary>
	/// <param name="name">The name to verify. </param>
	/// <returns>The name, if it is a valid XML name.</returns>
	/// <exception cref="T:System.Xml.XmlException">
	///         <paramref name="name" /> is not a valid XML name. </exception>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="name" /> is <see langword="null" /> or String.Empty. </exception>
	public static string VerifyName(string name)
	{
		return null;
	}

	internal static Exception TryVerifyName(string name)
	{
		return null;
	}

	internal static string VerifyQName(string name, ExceptionType exceptionType)
	{
		return null;
	}

	/// <summary>Verifies that the name is a valid <see langword="NCName" /> according to the W3C Extended Markup Language recommendation. An <see langword="NCName" /> is a name that cannot contain a colon.</summary>
	/// <param name="name">The name to verify. </param>
	/// <returns>The name, if it is a valid NCName.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="name" /> is <see langword="null" /> or String.Empty. </exception>
	/// <exception cref="T:System.Xml.XmlException">
	///         <paramref name="name" /> is not a valid non-colon name. </exception>
	public static string VerifyNCName(string name)
	{
		return null;
	}

	internal static string VerifyNCName(string name, ExceptionType exceptionType)
	{
		return null;
	}

	internal static Exception TryVerifyNCName(string name)
	{
		return null;
	}

	/// <summary>Verifies that the string is a valid token according to the W3C XML Schema Part2: Datatypes recommendation.</summary>
	/// <param name="token">The string value you wish to verify.</param>
	/// <returns>The token, if it is a valid token.</returns>
	/// <exception cref="T:System.Xml.XmlException">The string value is not a valid token.</exception>
	public static string VerifyTOKEN(string token)
	{
		return null;
	}

	internal static Exception TryVerifyTOKEN(string token)
	{
		return null;
	}

	internal static Exception TryVerifyNMTOKEN(string name)
	{
		return null;
	}

	internal static Exception TryVerifyNormalizedString(string str)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.Boolean" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <returns>A string representation of the <see langword="Boolean" />, that is, "true" or "false".</returns>
	public static string ToString(bool value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.Char" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <returns>A string representation of the <see langword="Char" />.</returns>
	public static string ToString(char value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.Decimal" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <returns>A string representation of the <see langword="Decimal" />.</returns>
	public static string ToString(decimal value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.SByte" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <returns>A string representation of the <see langword="SByte" />.</returns>
	[CLSCompliant(false)]
	public static string ToString(sbyte value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.Int16" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <returns>A string representation of the <see langword="Int16" />.</returns>
	public static string ToString(short value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.Int32" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <returns>A string representation of the <see langword="Int32" />.</returns>
	public static string ToString(int value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.Int64" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <returns>A string representation of the <see langword="Int64" />.</returns>
	public static string ToString(long value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.Byte" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <returns>A string representation of the <see langword="Byte" />.</returns>
	public static string ToString(byte value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.UInt16" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <returns>A string representation of the <see langword="UInt16" />.</returns>
	[CLSCompliant(false)]
	public static string ToString(ushort value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.UInt32" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <returns>A string representation of the <see langword="UInt32" />.</returns>
	[CLSCompliant(false)]
	public static string ToString(uint value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.UInt64" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <returns>A string representation of the <see langword="UInt64" />.</returns>
	[CLSCompliant(false)]
	public static string ToString(ulong value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.Single" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <returns>A string representation of the <see langword="Single" />.</returns>
	public static string ToString(float value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.Double" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <returns>A string representation of the <see langword="Double" />.</returns>
	public static string ToString(double value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.TimeSpan" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <returns>A string representation of the <see langword="TimeSpan" />.</returns>
	public static string ToString(TimeSpan value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.DateTime" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <param name="format">The format structure that defines how to display the converted string. Valid formats include "yyyy-MM-ddTHH:mm:sszzzzzz" and its subsets. </param>
	/// <returns>A string representation of the <see langword="DateTime" /> in the specified format.</returns>
	public static string ToString(DateTime value, string format)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.DateTime" /> to a <see cref="T:System.String" /> using the <see cref="T:System.Xml.XmlDateTimeSerializationMode" /> specified.</summary>
	/// <param name="value">The <see cref="T:System.DateTime" /> value to convert.</param>
	/// <param name="dateTimeOption">One of the <see cref="T:System.Xml.XmlDateTimeSerializationMode" /> values that specify how to treat the <see cref="T:System.DateTime" /> value.</param>
	/// <returns>A <see cref="T:System.String" /> equivalent of the <see cref="T:System.DateTime" />.</returns>
	/// <exception cref="T:System.ArgumentException">The <paramref name="dateTimeOption" /> value is not valid.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> or <paramref name="dateTimeOption" /> value is <see langword="null" />.</exception>
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption)
	{
		return null;
	}

	/// <summary>Converts the supplied <see cref="T:System.DateTimeOffset" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The <see cref="T:System.DateTimeOffset" /> to be converted.</param>
	/// <returns>A <see cref="T:System.String" /> representation of the supplied <see cref="T:System.DateTimeOffset" />.</returns>
	public static string ToString(DateTimeOffset value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.Guid" /> to a <see cref="T:System.String" />.</summary>
	/// <param name="value">The value to convert. </param>
	/// <returns>A string representation of the <see langword="Guid" />.</returns>
	public static string ToString(Guid value)
	{
		return null;
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Boolean" /> equivalent.</summary>
	/// <param name="s">The string to convert. </param>
	/// <returns>A <see langword="Boolean" /> value, that is, <see langword="true" /> or <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="s" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> does not represent a <see langword="Boolean" /> value. </exception>
	public static bool ToBoolean(string s)
	{
		return false;
	}

	internal static Exception TryToBoolean(string s, out bool result)
	{
		result = default(bool);
		return null;
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Char" /> equivalent.</summary>
	/// <param name="s">The string containing a single character to convert. </param>
	/// <returns>A <see langword="Char" /> representing the single character.</returns>
	/// <exception cref="T:System.ArgumentNullException">The value of the <paramref name="s" /> parameter is <see langword="null" />. </exception>
	/// <exception cref="T:System.FormatException">The <paramref name="s" /> parameter contains more than one character. </exception>
	public static char ToChar(string s)
	{
		return '\0';
	}

	internal static Exception TryToChar(string s, out char result)
	{
		result = default(char);
		return null;
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Decimal" /> equivalent.</summary>
	/// <param name="s">The string to convert. </param>
	/// <returns>A <see langword="Decimal" /> equivalent of the string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="s" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> is not in the correct format. </exception>
	/// <exception cref="T:System.OverflowException">
	///         <paramref name="s" /> represents a number less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
	public static decimal ToDecimal(string s)
	{
		return default(decimal);
	}

	internal static Exception TryToDecimal(string s, out decimal result)
	{
		result = default(decimal);
		return null;
	}

	internal static decimal ToInteger(string s)
	{
		return default(decimal);
	}

	internal static Exception TryToInteger(string s, out decimal result)
	{
		result = default(decimal);
		return null;
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.SByte" /> equivalent.</summary>
	/// <param name="s">The string to convert. </param>
	/// <returns>An <see langword="SByte" /> equivalent of the string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="s" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> is not in the correct format. </exception>
	/// <exception cref="T:System.OverflowException">
	///         <paramref name="s" /> represents a number less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />. </exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(string s)
	{
		return 0;
	}

	internal static Exception TryToSByte(string s, out sbyte result)
	{
		result = default(sbyte);
		return null;
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Int16" /> equivalent.</summary>
	/// <param name="s">The string to convert. </param>
	/// <returns>An <see langword="Int16" /> equivalent of the string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="s" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> is not in the correct format. </exception>
	/// <exception cref="T:System.OverflowException">
	///         <paramref name="s" /> represents a number less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />. </exception>
	public static short ToInt16(string s)
	{
		return 0;
	}

	internal static Exception TryToInt16(string s, out short result)
	{
		result = default(short);
		return null;
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Int32" /> equivalent.</summary>
	/// <param name="s">The string to convert. </param>
	/// <returns>An <see langword="Int32" /> equivalent of the string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="s" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> is not in the correct format. </exception>
	/// <exception cref="T:System.OverflowException">
	///         <paramref name="s" /> represents a number less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />. </exception>
	public static int ToInt32(string s)
	{
		return 0;
	}

	internal static Exception TryToInt32(string s, out int result)
	{
		result = default(int);
		return null;
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Int64" /> equivalent.</summary>
	/// <param name="s">The string to convert. </param>
	/// <returns>An <see langword="Int64" /> equivalent of the string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="s" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> is not in the correct format. </exception>
	/// <exception cref="T:System.OverflowException">
	///         <paramref name="s" /> represents a number less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />. </exception>
	public static long ToInt64(string s)
	{
		return 0L;
	}

	internal static Exception TryToInt64(string s, out long result)
	{
		result = default(long);
		return null;
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Byte" /> equivalent.</summary>
	/// <param name="s">The string to convert. </param>
	/// <returns>A <see langword="Byte" /> equivalent of the string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="s" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> is not in the correct format. </exception>
	/// <exception cref="T:System.OverflowException">
	///         <paramref name="s" /> represents a number less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
	public static byte ToByte(string s)
	{
		return 0;
	}

	internal static Exception TryToByte(string s, out byte result)
	{
		result = default(byte);
		return null;
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.UInt16" /> equivalent.</summary>
	/// <param name="s">The string to convert. </param>
	/// <returns>A <see langword="UInt16" /> equivalent of the string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="s" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> is not in the correct format. </exception>
	/// <exception cref="T:System.OverflowException">
	///         <paramref name="s" /> represents a number less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />. </exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(string s)
	{
		return 0;
	}

	internal static Exception TryToUInt16(string s, out ushort result)
	{
		result = default(ushort);
		return null;
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.UInt32" /> equivalent.</summary>
	/// <param name="s">The string to convert. </param>
	/// <returns>A <see langword="UInt32" /> equivalent of the string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="s" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> is not in the correct format. </exception>
	/// <exception cref="T:System.OverflowException">
	///         <paramref name="s" /> represents a number less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
	[CLSCompliant(false)]
	public static uint ToUInt32(string s)
	{
		return 0u;
	}

	internal static Exception TryToUInt32(string s, out uint result)
	{
		result = default(uint);
		return null;
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.UInt64" /> equivalent.</summary>
	/// <param name="s">The string to convert. </param>
	/// <returns>A <see langword="UInt64" /> equivalent of the string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="s" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> is not in the correct format. </exception>
	/// <exception cref="T:System.OverflowException">
	///         <paramref name="s" /> represents a number less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />. </exception>
	[CLSCompliant(false)]
	public static ulong ToUInt64(string s)
	{
		return 0uL;
	}

	internal static Exception TryToUInt64(string s, out ulong result)
	{
		result = default(ulong);
		return null;
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Single" /> equivalent.</summary>
	/// <param name="s">The string to convert. </param>
	/// <returns>A <see langword="Single" /> equivalent of the string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="s" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> is not in the correct format. </exception>
	/// <exception cref="T:System.OverflowException">
	///         <paramref name="s" /> represents a number less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />. </exception>
	public static float ToSingle(string s)
	{
		return 0f;
	}

	internal static Exception TryToSingle(string s, out float result)
	{
		result = default(float);
		return null;
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Double" /> equivalent.</summary>
	/// <param name="s">The string to convert. </param>
	/// <returns>A <see langword="Double" /> equivalent of the string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="s" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> is not in the correct format. </exception>
	/// <exception cref="T:System.OverflowException">
	///         <paramref name="s" /> represents a number less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />. </exception>
	public static double ToDouble(string s)
	{
		return 0.0;
	}

	internal static Exception TryToDouble(string s, out double result)
	{
		result = default(double);
		return null;
	}

	internal static double ToXPathDouble(object o)
	{
		return 0.0;
	}

	internal static double XPathRound(double value)
	{
		return 0.0;
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.TimeSpan" /> equivalent.</summary>
	/// <param name="s">The string to convert. The string format must conform to the W3C XML Schema Part 2: Datatypes recommendation for duration.</param>
	/// <returns>A <see langword="TimeSpan" /> equivalent of the string.</returns>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> is not in correct format to represent a <see langword="TimeSpan" /> value. </exception>
	public static TimeSpan ToTimeSpan(string s)
	{
		return default(TimeSpan);
	}

	internal static Exception TryToTimeSpan(string s, out TimeSpan result)
	{
		result = default(TimeSpan);
		return null;
	}

	private static void CreateAllDateTimeFormats()
	{
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.DateTime" /> equivalent.</summary>
	/// <param name="s">The string to convert. </param>
	/// <returns>A <see langword="DateTime" /> equivalent of the string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="s" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> is an empty string or is not in the correct format. </exception>
	[Obsolete("Use XmlConvert.ToDateTime() that takes in XmlDateTimeSerializationMode")]
	public static DateTime ToDateTime(string s)
	{
		return default(DateTime);
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.DateTime" /> equivalent.</summary>
	/// <param name="s">The string to convert. </param>
	/// <param name="formats">An array containing the format structures to apply to the converted <see langword="DateTime" />. Valid formats include "yyyy-MM-ddTHH:mm:sszzzzzz" and its subsets. </param>
	/// <returns>A <see langword="DateTime" /> equivalent of the string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="s" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> or an element of <paramref name="formats" /> is String.Empty -or- 
	///         <paramref name="s" /> does not contain a date and time that corresponds to any of the elements of <paramref name="formats" />. </exception>
	public static DateTime ToDateTime(string s, string[] formats)
	{
		return default(DateTime);
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.DateTime" /> using the <see cref="T:System.Xml.XmlDateTimeSerializationMode" /> specified</summary>
	/// <param name="s">The <see cref="T:System.String" /> value to convert.</param>
	/// <param name="dateTimeOption">One of the <see cref="T:System.Xml.XmlDateTimeSerializationMode" /> values that specify whether the date should be converted to local time or preserved as Coordinated Universal Time (UTC), if it is a UTC date.</param>
	/// <returns>A <see cref="T:System.DateTime" /> equivalent of the <see cref="T:System.String" />.</returns>
	/// <exception cref="T:System.NullReferenceException">
	///         <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="dateTimeOption" /> value is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///         <paramref name="s" /> is an empty string or is not in a valid format.</exception>
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption)
	{
		return default(DateTime);
	}

	/// <summary>Converts the supplied <see cref="T:System.String" /> to a <see cref="T:System.DateTimeOffset" /> equivalent.</summary>
	/// <param name="s">The string to convert.
	///       Note   The string must conform to a subset of the W3C Recommendation for the XML dateTime type. For more information see http://www.w3.org/TR/xmlschema-2/#dateTime.</param>
	/// <returns>The <see cref="T:System.DateTimeOffset" /> equivalent of the supplied string.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///         <paramref name="s" /> is <see langword="null" />. </exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The argument passed to this method is outside the range of allowable values. For information about allowable values, see <see cref="T:System.DateTimeOffset" />.</exception>
	/// <exception cref="T:System.FormatException">The argument passed to this method does not conform to a subset of the W3C Recommendations for the XML dateTime type. For more information see http://www.w3.org/TR/xmlschema-2/#dateTime.</exception>
	public static DateTimeOffset ToDateTimeOffset(string s)
	{
		return default(DateTimeOffset);
	}

	/// <summary>Converts the <see cref="T:System.String" /> to a <see cref="T:System.Guid" /> equivalent.</summary>
	/// <param name="s">The string to convert. </param>
	/// <returns>A <see langword="Guid" /> equivalent of the string.</returns>
	public static Guid ToGuid(string s)
	{
		return default(Guid);
	}

	internal static Exception TryToGuid(string s, out Guid result)
	{
		result = default(Guid);
		return null;
	}

	private static DateTime SwitchToLocalTime(DateTime value)
	{
		return default(DateTime);
	}

	private static DateTime SwitchToUtcTime(DateTime value)
	{
		return default(DateTime);
	}

	internal static Uri ToUri(string s)
	{
		return null;
	}

	internal static Exception TryToUri(string s, out Uri result)
	{
		result = null;
		return null;
	}

	internal static bool StrEqual(char[] chars, int strPos1, int strLen1, string str2)
	{
		return false;
	}

	internal static string TrimString(string value)
	{
		return null;
	}

	internal static string TrimStringStart(string value)
	{
		return null;
	}

	internal static string TrimStringEnd(string value)
	{
		return null;
	}

	internal static string[] SplitString(string value)
	{
		return null;
	}

	internal static bool IsNegativeZero(double value)
	{
		return false;
	}

	private static long DoubleToInt64Bits(double value)
	{
		return 0L;
	}

	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType)
	{
	}

	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos)
	{
		return null;
	}

	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos)
	{
		return null;
	}

	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType)
	{
		return null;
	}

	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos)
	{
		return null;
	}

	internal static Exception CreateInvalidSurrogatePairException(char low, char hi)
	{
		return null;
	}

	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType)
	{
		return null;
	}

	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos)
	{
		return null;
	}

	internal static Exception CreateInvalidHighSurrogateCharException(char hi)
	{
		return null;
	}

	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType)
	{
		return null;
	}

	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos)
	{
		return null;
	}

	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType)
	{
		return null;
	}

	internal static Exception CreateInvalidCharException(char invChar, char nextChar)
	{
		return null;
	}

	internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType)
	{
		return null;
	}

	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType)
	{
		return null;
	}

	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName)
	{
		return null;
	}
}
