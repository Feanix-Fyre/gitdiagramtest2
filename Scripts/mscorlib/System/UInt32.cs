using System.Globalization;
using System.Runtime.Versioning;

namespace System;

/// <summary>Represents a 32-bit unsigned integer.</summary>
[Serializable]
[CLSCompliant(false)]
public readonly struct UInt32 : IComparable, IConvertible, IFormattable, IComparable<uint>, IEquatable<uint>, ISpanFormattable
{
	private readonly uint m_value;

	/// <summary>Represents the largest possible value of <see cref="T:System.UInt32" />. This field is constant.</summary>
	public const uint MaxValue = 4294967295u;

	/// <summary>Represents the smallest possible value of <see cref="T:System.UInt32" />. This field is constant.</summary>
	public const uint MinValue = 0u;

	/// <summary>Compares this instance to a specified object and returns an indication of their relative values.</summary>
	/// <param name="value">An object to compare, or <see langword="null" />.</param>
	/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.  
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
	///   This instance is greater than <paramref name="value" />.  
	///
	///  -or-  
	///
	///  <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="value" /> is not a <see cref="T:System.UInt32" />.</exception>
	public int CompareTo(object value)
	{
		return 0;
	}

	/// <summary>Compares this instance to a specified 32-bit unsigned integer and returns an indication of their relative values.</summary>
	/// <param name="value">An unsigned integer to compare.</param>
	/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.  
	///   Return value  
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
	public int CompareTo(uint value)
	{
		return 0;
	}

	/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
	/// <param name="obj">An object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is an instance of <see cref="T:System.UInt32" /> and equals the value of this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.UInt32" />.</summary>
	/// <param name="obj">A value to compare to this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> has the same value as this instance; otherwise, <see langword="false" />.</returns>
	[NonVersionable]
	public bool Equals(uint obj)
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
	/// <returns>The string representation of the value of this instance, consisting of a sequence of digits ranging from 0 to 9, without a sign or leading zeroes.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The string representation of the value of this instance, which consists of a sequence of digits ranging from 0 to 9, without a sign or leading zeros.</returns>
	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format.</summary>
	/// <param name="format">A numeric format string.</param>
	/// <returns>The string representation of the value of this instance as specified by <paramref name="format" />.</returns>
	/// <exception cref="T:System.FormatException">The <paramref name="format" /> parameter is invalid.</exception>
	public string ToString(string format)
	{
		return null;
	}

	/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary>
	/// <param name="format">A numeric format string.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information about this instance.</param>
	/// <returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
	/// <exception cref="T:System.FormatException">The <paramref name="format" /> parameter is invalid.</exception>
	public string ToString(string format, IFormatProvider provider)
	{
		return null;
	}

	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
	{
		charsWritten = default(int);
		return false;
	}

	/// <summary>Converts the string representation of a number to its 32-bit unsigned integer equivalent.</summary>
	/// <param name="s">A string representing the number to convert.</param>
	/// <returns>A 32-bit unsigned integer equivalent to the number contained in <paramref name="s" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">The <paramref name="s" /> parameter is not of the correct format.</exception>
	/// <exception cref="T:System.OverflowException">The <paramref name="s" /> parameter represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static uint Parse(string s)
	{
		return 0u;
	}

	/// <summary>Converts the string representation of a number in a specified style to its 32-bit unsigned integer equivalent.</summary>
	/// <param name="s">A string representing the number to convert. The string is interpreted by using the style specified by the <paramref name="style" /> parameter.</param>
	/// <param name="style">A bitwise combination of the enumeration values that specify the permitted format of <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
	/// <returns>A 32-bit unsigned integer equivalent to the number specified in <paramref name="s" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value.  
	/// -or-  
	/// <paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="s" /> is not in a format compliant with <paramref name="style" />.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="s" /> represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.  
	/// -or-  
	/// <paramref name="s" /> includes non-zero, fractional digits.</exception>
	[CLSCompliant(false)]
	public static uint Parse(string s, NumberStyles style)
	{
		return 0u;
	}

	/// <summary>Converts the string representation of a number in a specified culture-specific format to its 32-bit unsigned integer equivalent.</summary>
	/// <param name="s">A string that represents the number to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />.</param>
	/// <returns>A 32-bit unsigned integer equivalent to the number specified in <paramref name="s" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="s" /> is not in the correct style.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="s" /> represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static uint Parse(string s, IFormatProvider provider)
	{
		return 0u;
	}

	/// <summary>Converts the string representation of a number in a specified style and culture-specific format to its 32-bit unsigned integer equivalent.</summary>
	/// <param name="s">A string representing the number to convert. The string is interpreted by using the style specified by the <paramref name="style" /> parameter.</param>
	/// <param name="style">A bitwise combination of enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />.</param>
	/// <returns>A 32-bit unsigned integer equivalent to the number specified in <paramref name="s" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value.  
	/// -or-  
	/// <paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="s" /> is not in a format compliant with <paramref name="style" />.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="s" /> represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.  
	/// -or-  
	/// <paramref name="s" /> includes non-zero, fractional digits.</exception>
	[CLSCompliant(false)]
	public static uint Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		return 0u;
	}

	/// <summary>Tries to convert the string representation of a number to its 32-bit unsigned integer equivalent. A return value indicates whether the conversion succeeded or failed.</summary>
	/// <param name="s">A string that represents the number to convert.</param>
	/// <param name="result">When this method returns, contains the 32-bit unsigned integer value that is equivalent to the number contained in <paramref name="s" />, if the conversion succeeded, or zero if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is <see langword="null" /> or <see cref="F:System.String.Empty" />, is not of the correct format, or represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />. This parameter is passed uninitialized; any value originally supplied in <paramref name="result" /> will be overwritten.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="s" /> was converted successfully; otherwise, <see langword="false" />.</returns>
	[CLSCompliant(false)]
	public static bool TryParse(string s, out uint result)
	{
		result = default(uint);
		return false;
	}

	/// <summary>Tries to convert the string representation of a number in a specified style and culture-specific format to its 32-bit unsigned integer equivalent. A return value indicates whether the conversion succeeded or failed.</summary>
	/// <param name="s">A string that represents the number to convert. The string is interpreted by using the style specified by the <paramref name="style" /> parameter.</param>
	/// <param name="style">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />.</param>
	/// <param name="result">When this method returns, contains the 32-bit unsigned integer value equivalent to the number contained in <paramref name="s" />, if the conversion succeeded, or zero if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is <see langword="null" /> or <see cref="F:System.String.Empty" />, is not in a format compliant with <paramref name="style" />, or represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />. This parameter is passed uninitialized; any value originally supplied in <paramref name="result" /> will be overwritten.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="s" /> was converted successfully; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value.  
	/// -or-  
	/// <paramref name="style" /> is not a combination of <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> and <see cref="F:System.Globalization.NumberStyles.HexNumber" /> values.</exception>
	[CLSCompliant(false)]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result)
	{
		result = default(uint);
		return false;
	}

	/// <summary>Returns the <see cref="T:System.TypeCode" /> for value type <see cref="T:System.UInt32" />.</summary>
	/// <returns>The enumerated constant, <see cref="F:System.TypeCode.UInt32" />.</returns>
	public TypeCode GetTypeCode()
	{
		return default(TypeCode);
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
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
	/// <returns>The value of the current instance, converted to an <see cref="T:System.SByte" />.</returns>
	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
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
	/// <returns>The value of the current instance, unchanged.</returns>
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
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>The value of the current instance, converted to a <see cref="T:System.Decimal" />.</returns>
	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return default(decimal);
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>This conversion is not supported. No value is returned.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		return default(DateTime);
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
	/// <param name="type">The type to which to convert this <see cref="T:System.UInt32" /> value.</param>
	/// <param name="provider">An <see cref="T:System.IFormatProvider" /> implementation that supplies culture-specific information about the format of the returned value.</param>
	/// <returns>The value of the current instance, converted to <paramref name="type" />.</returns>
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return null;
	}
}
