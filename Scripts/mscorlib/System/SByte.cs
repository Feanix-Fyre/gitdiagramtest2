using System.Globalization;
using System.Runtime.Versioning;

namespace System;

/// <summary>Represents an 8-bit signed integer.</summary>
[Serializable]
[CLSCompliant(false)]
public readonly struct SByte : IComparable, IConvertible, IFormattable, IComparable<sbyte>, IEquatable<sbyte>, ISpanFormattable
{
	private readonly sbyte m_value;

	/// <summary>Represents the largest possible value of <see cref="T:System.SByte" />. This field is constant.</summary>
	public const sbyte MaxValue = 127;

	/// <summary>Represents the smallest possible value of <see cref="T:System.SByte" />. This field is constant.</summary>
	public const sbyte MinValue = -128;

	/// <summary>Compares this instance to a specified object and returns an indication of their relative values.</summary>
	/// <param name="obj">An object to compare, or <see langword="null" />.</param>
	/// <returns>A signed number indicating the relative values of this instance and <paramref name="obj" />.  
	///   Return Value  
	///
	///   Description  
	///
	///   Less than zero  
	///
	///   This instance is less than <paramref name="obj" />.  
	///
	///   Zero  
	///
	///   This instance is equal to <paramref name="obj" />.  
	///
	///   Greater than zero  
	///
	///   This instance is greater than <paramref name="obj" />.  
	///
	///  -or-  
	///
	///  <paramref name="obj" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="obj" /> is not an <see cref="T:System.SByte" />.</exception>
	public int CompareTo(object obj)
	{
		return 0;
	}

	/// <summary>Compares this instance to a specified 8-bit signed integer and returns an indication of their relative values.</summary>
	/// <param name="value">An 8-bit signed integer to compare.</param>
	/// <returns>A signed integer that indicates the relative order of this instance and <paramref name="value" />.  
	///   Return Value  
	///
	///   Description  
	///
	///   Less than zero  
	///
	///   This instance is less than <paramref name="value" />.  
	///
	///   Zero  
	///
	///   This instance is equal to <paramref name="value" />.  
	///
	///   Greater than zero  
	///
	///   This instance is greater than <paramref name="value" />.</returns>
	public int CompareTo(sbyte value)
	{
		return 0;
	}

	/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
	/// <param name="obj">An object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is an instance of <see cref="T:System.SByte" /> and equals the value of this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.SByte" /> value.</summary>
	/// <param name="obj">An <see cref="T:System.SByte" /> value to compare to this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> has the same value as this instance; otherwise, <see langword="false" />.</returns>
	[NonVersionable]
	public bool Equals(sbyte obj)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Converts the numeric value of this instance to its equivalent string representation.</summary>
	/// <returns>The string representation of the value of this instance, consisting of a negative sign if the value is negative, and a sequence of digits ranging from 0 to 9 with no leading zeroes.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The string representation of the value of this instance, as specified by <paramref name="provider" />.</returns>
	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary>
	/// <param name="format">A standard or custom numeric format string.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.</exception>
	public string ToString(string format, IFormatProvider provider)
	{
		return null;
	}

	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
	{
		charsWritten = default(int);
		return false;
	}

	/// <summary>Converts the string representation of a number in a specified culture-specific format to its 8-bit signed integer equivalent.</summary>
	/// <param name="s">A string that represents a number to convert. The string is interpreted using the <see cref="F:System.Globalization.NumberStyles.Integer" /> style.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. If <paramref name="provider" /> is <see langword="null" />, the thread current culture is used.</param>
	/// <returns>An 8-bit signed integer that is equivalent to the number specified in <paramref name="s" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="s" /> is not in the correct format.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="s" /> represents a number less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte Parse(string s, IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the string representation of a number that is in a specified style and culture-specific format to its 8-bit signed equivalent.</summary>
	/// <param name="s">A string that contains the number to convert. The string is interpreted by using the style specified by <paramref name="style" />.</param>
	/// <param name="style">A bitwise combination of the enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. If <paramref name="provider" /> is <see langword="null" />, the thread current culture is used.</param>
	/// <returns>An 8-bit signed byte value that is equivalent to the number specified in the <paramref name="s" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value.  
	/// -or-  
	/// <paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="s" /> is not in a format that is compliant with <paramref name="style" />.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="s" /> represents a number that is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />.  
	/// -or-  
	/// <paramref name="s" /> includes non-zero, fractional digits.</exception>
	[CLSCompliant(false)]
	public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		return 0;
	}

	private static sbyte Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info)
	{
		return 0;
	}

	/// <summary>Tries to convert the string representation of a number in a specified style and culture-specific format to its <see cref="T:System.SByte" /> equivalent, and returns a value that indicates whether the conversion succeeded.</summary>
	/// <param name="s">A string representing a number to convert.</param>
	/// <param name="style">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />.</param>
	/// <param name="result">When this method returns, contains the 8-bit signed integer value equivalent to the number contained in <paramref name="s" />, if the conversion succeeded, or zero if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is <see langword="null" /> or <see cref="F:System.String.Empty" />, is not in a format compliant with <paramref name="style" />, or represents a number less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />. This parameter is passed uninitialized; any value originally supplied in <paramref name="result" /> will be overwritten.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="s" /> was converted successfully; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value.  
	/// -or-  
	/// <paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception>
	[CLSCompliant(false)]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result)
	{
		result = default(sbyte);
		return false;
	}

	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out sbyte result)
	{
		result = default(sbyte);
		return false;
	}

	/// <summary>Returns the <see cref="T:System.TypeCode" /> for value type <see cref="T:System.SByte" />.</summary>
	/// <returns>The enumerated constant, <see cref="F:System.TypeCode.SByte" />.</returns>
	public TypeCode GetTypeCode()
	{
		return default(TypeCode);
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is unused.</param>
	/// <returns>
	///   <see langword="true" /> if the value of the current instance is not zero; otherwise, <see langword="false" />.</returns>
	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return false;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.Char" />.</returns>
	char IConvertible.ToChar(IFormatProvider provider)
	{
		return '\0';
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, unchanged.</returns>
	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is unused.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.Byte" />.</returns>
	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to an <see cref="T:System.Int16" />.</returns>
	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt16" />.</returns>
	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to an <see cref="T:System.Int32" />.</returns>
	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt32" />.</returns>
	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return 0u;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to an <see cref="T:System.Int64" />.</returns>
	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return 0L;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt64" />.</returns>
	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return 0uL;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.Single" />.</returns>
	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return 0f;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.Double" />.</returns>
	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return 0.0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is unused.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.Decimal" />.</returns>
	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return default(decimal);
	}

	/// <summary>This conversion is not supported. Attempting to do so throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>None. This conversion is not supported.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		return default(DateTime);
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> to which to convert this <see cref="T:System.SByte" /> value.</param>
	/// <param name="provider">A <see cref="T:System.IFormatProvider" /> implementation that provides information about the format of the returned value.</param>
	/// <returns>The value of the current instance, converted to an object of type <paramref name="type" />.</returns>
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return null;
	}
}
