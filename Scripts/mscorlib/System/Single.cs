using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System;

/// <summary>Represents a single-precision floating-point number.</summary>
[Serializable]
public readonly struct Single : IComparable, IConvertible, IFormattable, IComparable<float>, IEquatable<float>, ISpanFormattable
{
	private readonly float m_value;

	/// <summary>Represents the smallest possible value of <see cref="T:System.Single" />. This field is constant.</summary>
	public const float MinValue = -3.4028235E+38f;

	/// <summary>Represents the smallest positive <see cref="T:System.Single" /> value that is greater than zero. This field is constant.</summary>
	public const float Epsilon = 1E-45f;

	/// <summary>Represents the largest possible value of <see cref="T:System.Single" />. This field is constant.</summary>
	public const float MaxValue = 3.4028235E+38f;

	/// <summary>Represents positive infinity. This field is constant.</summary>
	public const float PositiveInfinity = 1f / 0f;

	/// <summary>Represents negative infinity. This field is constant.</summary>
	public const float NegativeInfinity = -1f / 0f;

	/// <summary>Represents not a number (<see langword="NaN" />). This field is constant.</summary>
	public const float NaN = 0f / 0f;

	internal const float NegativeZero = 0f;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[NonVersionable]
	public static bool IsFinite(float f)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether the specified number evaluates to negative or positive infinity.</summary>
	/// <param name="f">A single-precision floating-point number.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="f" /> evaluates to <see cref="F:System.Single.PositiveInfinity" /> or <see cref="F:System.Single.NegativeInfinity" />; otherwise, <see langword="false" />.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[NonVersionable]
	public static bool IsInfinity(float f)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether the specified value is not a number (<see cref="F:System.Single.NaN" />).</summary>
	/// <param name="f">A single-precision floating-point number.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="f" /> evaluates to not a number (<see cref="F:System.Single.NaN" />); otherwise, <see langword="false" />.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[NonVersionable]
	public static bool IsNaN(float f)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether the specified number evaluates to negative infinity.</summary>
	/// <param name="f">A single-precision floating-point number.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="f" /> evaluates to <see cref="F:System.Single.NegativeInfinity" />; otherwise, <see langword="false" />.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[NonVersionable]
	public static bool IsNegativeInfinity(float f)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether the specified number evaluates to positive infinity.</summary>
	/// <param name="f">A single-precision floating-point number.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="f" /> evaluates to <see cref="F:System.Single.PositiveInfinity" />; otherwise, <see langword="false" />.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[NonVersionable]
	public static bool IsPositiveInfinity(float f)
	{
		return false;
	}

	/// <summary>Compares this instance to a specified object and returns an integer that indicates whether the value of this instance is less than, equal to, or greater than the value of the specified object.</summary>
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
	///  -or-  
	///
	///  This instance is not a number (<see cref="F:System.Single.NaN" />) and <paramref name="value" /> is a number.  
	///
	///   Zero  
	///
	///   This instance is equal to <paramref name="value" />.  
	///
	///  -or-  
	///
	///  This instance and value are both not a number (<see cref="F:System.Single.NaN" />), <see cref="F:System.Single.PositiveInfinity" />, or <see cref="F:System.Single.NegativeInfinity" />.  
	///
	///   Greater than zero  
	///
	///   This instance is greater than <paramref name="value" />.  
	///
	///  -or-  
	///
	///  This instance is a number and <paramref name="value" /> is not a number (<see cref="F:System.Single.NaN" />).  
	///
	///  -or-  
	///
	///  <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="value" /> is not a <see cref="T:System.Single" />.</exception>
	public int CompareTo(object value)
	{
		return 0;
	}

	/// <summary>Compares this instance to a specified single-precision floating-point number and returns an integer that indicates whether the value of this instance is less than, equal to, or greater than the value of the specified single-precision floating-point number.</summary>
	/// <param name="value">A single-precision floating-point number to compare.</param>
	/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.  
	///   Return Value  
	///
	///   Description  
	///
	///   Less than zero  
	///
	///   This instance is less than <paramref name="value" />.  
	///
	///  -or-  
	///
	///  This instance is not a number (<see cref="F:System.Single.NaN" />) and <paramref name="value" /> is a number.  
	///
	///   Zero  
	///
	///   This instance is equal to <paramref name="value" />.  
	///
	///  -or-  
	///
	///  Both this instance and <paramref name="value" /> are not a number (<see cref="F:System.Single.NaN" />), <see cref="F:System.Single.PositiveInfinity" />, or <see cref="F:System.Single.NegativeInfinity" />.  
	///
	///   Greater than zero  
	///
	///   This instance is greater than <paramref name="value" />.  
	///
	///  -or-  
	///
	///  This instance is a number and <paramref name="value" /> is not a number (<see cref="F:System.Single.NaN" />).</returns>
	public int CompareTo(float value)
	{
		return 0;
	}

	/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
	/// <param name="obj">An object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is an instance of <see cref="T:System.Single" /> and equals the value of this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Single" /> object represent the same value.</summary>
	/// <param name="obj">An object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
	public bool Equals(float obj)
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
	/// <returns>The string representation of the value of this instance.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns>
	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Converts the numeric value of this instance to its equivalent string representation, using the specified format.</summary>
	/// <param name="format">A numeric format string.</param>
	/// <returns>The string representation of the value of this instance as specified by <paramref name="format" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is invalid.</exception>
	public string ToString(string format)
	{
		return null;
	}

	/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary>
	/// <param name="format">A numeric format string.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
	public string ToString(string format, IFormatProvider provider)
	{
		return null;
	}

	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
	{
		charsWritten = default(int);
		return false;
	}

	/// <summary>Converts the string representation of a number in a specified culture-specific format to its single-precision floating-point number equivalent.</summary>
	/// <param name="s">A string that contains a number to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />.</param>
	/// <returns>A single-precision floating-point number equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="s" /> does not represent a number in a valid format.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="s" /> represents a number less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />.</exception>
	public static float Parse(string s, IFormatProvider provider)
	{
		return 0f;
	}

	/// <summary>Converts the string representation of a number in a specified style and culture-specific format to its single-precision floating-point number equivalent.</summary>
	/// <param name="s">A string that contains a number to convert.</param>
	/// <param name="style">A bitwise combination of enumeration values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Float" /> combined with <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />.</param>
	/// <returns>A single-precision floating-point number equivalent to the numeric value or symbol specified in <paramref name="s" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="s" /> does not represent a numeric value.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value.  
	/// -or-  
	/// <paramref name="style" /> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="s" /> represents a number that is less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />.</exception>
	public static float Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		return 0f;
	}

	/// <summary>Converts the string representation of a number to its single-precision floating-point number equivalent. A return value indicates whether the conversion succeeded or failed.</summary>
	/// <param name="s">A string representing a number to convert.</param>
	/// <param name="result">When this method returns, contains single-precision floating-point number equivalent to the numeric value or symbol contained in <paramref name="s" />, if the conversion succeeded, or zero if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is <see langword="null" /> or <see cref="F:System.String.Empty" />, is not a number in a valid format, or represents a number less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />. This parameter is passed uninitialized; any value originally supplied in <paramref name="result" /> will be overwritten.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="s" /> was converted successfully; otherwise, <see langword="false" />.</returns>
	public static bool TryParse(string s, out float result)
	{
		result = default(float);
		return false;
	}

	/// <summary>Converts the string representation of a number in a specified style and culture-specific format to its single-precision floating-point number equivalent. A return value indicates whether the conversion succeeded or failed.</summary>
	/// <param name="s">A string representing a number to convert.</param>
	/// <param name="style">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Float" /> combined with <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />.</param>
	/// <param name="result">When this method returns, contains the single-precision floating-point number equivalent to the numeric value or symbol contained in <paramref name="s" />, if the conversion succeeded, or zero if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is <see langword="null" /> or <see cref="F:System.String.Empty" />, is not in a format compliant with <paramref name="style" />, represents a number less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />, or if <paramref name="style" /> is not a valid combination of <see cref="T:System.Globalization.NumberStyles" /> enumerated constants. This parameter is passed uninitialized; any value originally supplied in <paramref name="result" /> will be overwritten.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="s" /> was converted successfully; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value.  
	/// -or-  
	/// <paramref name="style" /> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value.</exception>
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result)
	{
		result = default(float);
		return false;
	}

	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out float result)
	{
		result = default(float);
		return false;
	}

	/// <summary>Returns the <see cref="T:System.TypeCode" /> for value type <see cref="T:System.Single" />.</summary>
	/// <returns>The enumerated constant, <see cref="F:System.TypeCode.Single" />.</returns>
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

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>This conversion is not supported. No value is returned.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
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
	/// <returns>The value of the current instance, unchanged.</returns>
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
	/// <param name="type">The type to which to convert this <see cref="T:System.Single" /> value.</param>
	/// <param name="provider">An object that supplies information about the format of the returned value.</param>
	/// <returns>The value of the current instance, converted to <paramref name="type" />.</returns>
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return null;
	}
}
