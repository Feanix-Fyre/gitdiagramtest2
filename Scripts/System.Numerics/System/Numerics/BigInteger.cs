using System.Globalization;

namespace System.Numerics;

/// <summary>Represents an arbitrarily large signed integer.</summary>
[Serializable]
public readonly struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger>
{
	private enum GetBytesMode
	{
		AllocateArray = 0,
		Count = 1,
		Span = 2
	}

	internal readonly int _sign;

	internal readonly uint[] _bits;

	private static readonly BigInteger s_bnMinInt;

	private static readonly BigInteger s_bnOneInt;

	private static readonly BigInteger s_bnZeroInt;

	private static readonly BigInteger s_bnMinusOneInt;

	private static readonly byte[] s_success;

	/// <summary>Gets a value that represents the number 0 (zero).</summary>
	/// <returns>An integer whose value is 0 (zero).</returns>
	public static BigInteger Zero => default(BigInteger);

	/// <summary>Gets a value that represents the number negative one (-1).</summary>
	/// <returns>An integer whose value is negative one (-1).</returns>
	public static BigInteger MinusOne => default(BigInteger);

	/// <summary>Indicates whether the value of the current <see cref="T:System.Numerics.BigInteger" /> object is <see cref="P:System.Numerics.BigInteger.Zero" />.</summary>
	/// <returns>
	///   <see langword="true" /> if the value of the <see cref="T:System.Numerics.BigInteger" /> object is <see cref="P:System.Numerics.BigInteger.Zero" />; otherwise, <see langword="false" />.</returns>
	public bool IsZero => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Numerics.BigInteger" /> structure using a 32-bit signed integer value.</summary>
	/// <param name="value">A 32-bit signed integer.</param>
	public BigInteger(int value)
	{
		_sign = 0;
		_bits = null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Numerics.BigInteger" /> structure using an unsigned 32-bit integer value.</summary>
	/// <param name="value">An unsigned 32-bit integer value.</param>
	[CLSCompliant(false)]
	public BigInteger(uint value)
	{
		_sign = 0;
		_bits = null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Numerics.BigInteger" /> structure using a 64-bit signed integer value.</summary>
	/// <param name="value">A 64-bit signed integer.</param>
	public BigInteger(long value)
	{
		_sign = 0;
		_bits = null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Numerics.BigInteger" /> structure with an unsigned 64-bit integer value.</summary>
	/// <param name="value">An unsigned 64-bit integer.</param>
	[CLSCompliant(false)]
	public BigInteger(ulong value)
	{
		_sign = 0;
		_bits = null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Numerics.BigInteger" /> structure using a single-precision floating-point value.</summary>
	/// <param name="value">A single-precision floating-point value.</param>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.NegativeInfinity" />, or <see cref="F:System.Single.PositiveInfinity" />.</exception>
	public BigInteger(float value)
	{
		_sign = 0;
		_bits = null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Numerics.BigInteger" /> structure using a double-precision floating-point value.</summary>
	/// <param name="value">A double-precision floating-point value.</param>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />.</exception>
	public BigInteger(double value)
	{
		_sign = 0;
		_bits = null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Numerics.BigInteger" /> structure using a <see cref="T:System.Decimal" /> value.</summary>
	/// <param name="value">A decimal number.</param>
	public BigInteger(decimal value)
	{
		_sign = 0;
		_bits = null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Numerics.BigInteger" /> structure using the values in a byte array.</summary>
	/// <param name="value">An array of byte values in little-endian order.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	[CLSCompliant(false)]
	public BigInteger(byte[] value)
	{
		_sign = 0;
		_bits = null;
	}

	public BigInteger(ReadOnlySpan<byte> value, bool isUnsigned = false, bool isBigEndian = false)
	{
		_sign = 0;
		_bits = null;
	}

	internal BigInteger(int n, uint[] rgu)
	{
		_sign = 0;
		_bits = null;
	}

	internal BigInteger(uint[] value, bool negative)
	{
		_sign = 0;
		_bits = null;
	}

	/// <summary>Converts the string representation of a number in a specified culture-specific format to its <see cref="T:System.Numerics.BigInteger" /> equivalent.</summary>
	/// <param name="value">A string that contains a number to convert.</param>
	/// <param name="provider">An object that provides culture-specific formatting information about <paramref name="value" />.</param>
	/// <returns>A value that is equivalent to the number specified in the <paramref name="value" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in the correct format.</exception>
	public static BigInteger Parse(string value, IFormatProvider provider)
	{
		return default(BigInteger);
	}

	/// <summary>Converts the string representation of a number in a specified style and culture-specific format to its <see cref="T:System.Numerics.BigInteger" /> equivalent.</summary>
	/// <param name="value">A string that contains a number to convert.</param>
	/// <param name="style">A bitwise combination of the enumeration values that specify the permitted format of <paramref name="value" />.</param>
	/// <param name="provider">An object that provides culture-specific formatting information about <paramref name="value" />.</param>
	/// <returns>A value that is equivalent to the number specified in the <paramref name="value" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value.  
	/// -or-  
	/// <paramref name="style" /> includes the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> or <see cref="F:System.Globalization.NumberStyles.HexNumber" /> flag along with another value.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> does not comply with the input pattern specified by <paramref name="style" />.</exception>
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider)
	{
		return default(BigInteger);
	}

	/// <summary>Returns the hash code for the current <see cref="T:System.Numerics.BigInteger" /> object.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns a value that indicates whether the current instance and a specified object have the same value.</summary>
	/// <param name="obj">The object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="obj" /> argument is a <see cref="T:System.Numerics.BigInteger" /> object, and its value is equal to the value of the current <see cref="T:System.Numerics.BigInteger" /> instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether the current instance and a signed 64-bit integer have the same value.</summary>
	/// <param name="other">The signed 64-bit integer value to compare.</param>
	/// <returns>
	///   <see langword="true" /> if the signed 64-bit integer and the current instance have the same value; otherwise, <see langword="false" />.</returns>
	public bool Equals(long other)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether the current instance and a specified <see cref="T:System.Numerics.BigInteger" /> object have the same value.</summary>
	/// <param name="other">The object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if this <see cref="T:System.Numerics.BigInteger" /> object and <paramref name="other" /> have the same value; otherwise, <see langword="false" />.</returns>
	public bool Equals(BigInteger other)
	{
		return false;
	}

	/// <summary>Compares this instance to a signed 64-bit integer and returns an integer that indicates whether the value of this instance is less than, equal to, or greater than the value of the signed 64-bit integer.</summary>
	/// <param name="other">The signed 64-bit integer to compare.</param>
	/// <returns>A signed integer value that indicates the relationship of this instance to <paramref name="other" />, as shown in the following table.  
	///   Return value  
	///
	///   Description  
	///
	///   Less than zero  
	///
	///   The current instance is less than <paramref name="other" />.  
	///
	///   Zero  
	///
	///   The current instance equals <paramref name="other" />.  
	///
	///   Greater than zero  
	///
	///   The current instance is greater than <paramref name="other" />.</returns>
	public int CompareTo(long other)
	{
		return 0;
	}

	/// <summary>Compares this instance to a second <see cref="T:System.Numerics.BigInteger" /> and returns an integer that indicates whether the value of this instance is less than, equal to, or greater than the value of the specified object.</summary>
	/// <param name="other">The object to compare.</param>
	/// <returns>A signed integer value that indicates the relationship of this instance to <paramref name="other" />, as shown in the following table.  
	///   Return value  
	///
	///   Description  
	///
	///   Less than zero  
	///
	///   The current instance is less than <paramref name="other" />.  
	///
	///   Zero  
	///
	///   The current instance equals <paramref name="other" />.  
	///
	///   Greater than zero  
	///
	///   The current instance is greater than <paramref name="other" />.</returns>
	public int CompareTo(BigInteger other)
	{
		return 0;
	}

	/// <summary>Compares this instance to a specified object and returns an integer that indicates whether the value of this instance is less than, equal to, or greater than the value of the specified object.</summary>
	/// <param name="obj">The object to compare.</param>
	/// <returns>A signed integer that indicates the relationship of the current instance to the <paramref name="obj" /> parameter, as shown in the following table.  
	///   Return value  
	///
	///   Description  
	///
	///   Less than zero  
	///
	///   The current instance is less than <paramref name="obj" />.  
	///
	///   Zero  
	///
	///   The current instance equals <paramref name="obj" />.  
	///
	///   Greater than zero  
	///
	///   The current instance is greater than <paramref name="obj" />, or the <paramref name="obj" /> parameter is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="obj" /> is not a <see cref="T:System.Numerics.BigInteger" />.</exception>
	public int CompareTo(object obj)
	{
		return 0;
	}

	/// <summary>Converts a <see cref="T:System.Numerics.BigInteger" /> value to a byte array.</summary>
	/// <returns>The value of the current <see cref="T:System.Numerics.BigInteger" /> object converted to an array of bytes.</returns>
	public byte[] ToByteArray()
	{
		return null;
	}

	public byte[] ToByteArray(bool isUnsigned = false, bool isBigEndian = false)
	{
		return null;
	}

	public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false)
	{
		bytesWritten = default(int);
		return false;
	}

	internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false)
	{
		bytesWritten = default(int);
		return false;
	}

	private byte[] TryGetBytes(GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten)
	{
		return null;
	}

	/// <summary>Converts the numeric value of the current <see cref="T:System.Numerics.BigInteger" /> object to its equivalent string representation.</summary>
	/// <returns>The string representation of the current <see cref="T:System.Numerics.BigInteger" /> value.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Converts the numeric value of the current <see cref="T:System.Numerics.BigInteger" /> object to its equivalent string representation by using the specified culture-specific formatting information.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The string representation of the current <see cref="T:System.Numerics.BigInteger" /> value in the format specified by the <paramref name="provider" /> parameter.</returns>
	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Converts the numeric value of the current <see cref="T:System.Numerics.BigInteger" /> object to its equivalent string representation by using the specified format and culture-specific format information.</summary>
	/// <param name="format">A standard or custom numeric format string.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The string representation of the current <see cref="T:System.Numerics.BigInteger" /> value as specified by the <paramref name="format" /> and <paramref name="provider" /> parameters.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> is not a valid format string.</exception>
	public string ToString(string format, IFormatProvider provider)
	{
		return null;
	}

	private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign)
	{
		return default(BigInteger);
	}

	/// <summary>Subtracts a <see cref="T:System.Numerics.BigInteger" /> value from another <see cref="T:System.Numerics.BigInteger" /> value.</summary>
	/// <param name="left">The value to subtract from (the minuend).</param>
	/// <param name="right">The value to subtract (the subtrahend).</param>
	/// <returns>The result of subtracting <paramref name="right" /> from <paramref name="left" />.</returns>
	public static BigInteger operator -(BigInteger left, BigInteger right)
	{
		return default(BigInteger);
	}

	private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign)
	{
		return default(BigInteger);
	}

	/// <summary>Defines an implicit conversion of an unsigned byte to a <see cref="T:System.Numerics.BigInteger" /> value.</summary>
	/// <param name="value">The value to convert to a <see cref="T:System.Numerics.BigInteger" />.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	public static implicit operator BigInteger(byte value)
	{
		return default(BigInteger);
	}

	/// <summary>Defines an implicit conversion of an 8-bit signed integer to a <see cref="T:System.Numerics.BigInteger" /> value.  
	///  This API is not CLS-compliant. The compliant alternative is <see cref="M:System.Numerics.BigInteger.#ctor(System.Int32)" />.</summary>
	/// <param name="value">The value to convert to a <see cref="T:System.Numerics.BigInteger" />.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	[CLSCompliant(false)]
	public static implicit operator BigInteger(sbyte value)
	{
		return default(BigInteger);
	}

	/// <summary>Defines an implicit conversion of a signed 16-bit integer to a <see cref="T:System.Numerics.BigInteger" /> value.</summary>
	/// <param name="value">The value to convert to a <see cref="T:System.Numerics.BigInteger" />.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	public static implicit operator BigInteger(short value)
	{
		return default(BigInteger);
	}

	/// <summary>Defines an implicit conversion of a 16-bit unsigned integer to a <see cref="T:System.Numerics.BigInteger" /> value.  
	///  This API is not CLS-compliant. The compliant alternative is <see cref="M:System.Numerics.BigInteger.op_Implicit(System.Int32)~System.Numerics.BigInteger" />.</summary>
	/// <param name="value">The value to convert to a <see cref="T:System.Numerics.BigInteger" />.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	[CLSCompliant(false)]
	public static implicit operator BigInteger(ushort value)
	{
		return default(BigInteger);
	}

	/// <summary>Defines an implicit conversion of a signed 32-bit integer to a <see cref="T:System.Numerics.BigInteger" /> value.</summary>
	/// <param name="value">The value to convert to a <see cref="T:System.Numerics.BigInteger" />.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	public static implicit operator BigInteger(int value)
	{
		return default(BigInteger);
	}

	/// <summary>Defines an implicit conversion of a 32-bit unsigned integer to a <see cref="T:System.Numerics.BigInteger" /> value.  
	///  This API is not CLS-compliant. The compliant alternative is <see cref="M:System.Numerics.BigInteger.op_Implicit(System.Int64)~System.Numerics.BigInteger" />.</summary>
	/// <param name="value">The value to convert to a <see cref="T:System.Numerics.BigInteger" />.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	[CLSCompliant(false)]
	public static implicit operator BigInteger(uint value)
	{
		return default(BigInteger);
	}

	/// <summary>Defines an implicit conversion of a signed 64-bit integer to a <see cref="T:System.Numerics.BigInteger" /> value.</summary>
	/// <param name="value">The value to convert to a <see cref="T:System.Numerics.BigInteger" />.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	public static implicit operator BigInteger(long value)
	{
		return default(BigInteger);
	}

	/// <summary>Defines an implicit conversion of a 64-bit unsigned integer to a <see cref="T:System.Numerics.BigInteger" /> value.  
	///  This API is not CLS-compliant. The compliant alternative is <see cref="T:System.Double" />.</summary>
	/// <param name="value">The value to convert to a <see cref="T:System.Numerics.BigInteger" />.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	[CLSCompliant(false)]
	public static implicit operator BigInteger(ulong value)
	{
		return default(BigInteger);
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Numerics.BigInteger" /> object to an unsigned byte value.</summary>
	/// <param name="value">The value to convert to a <see cref="T:System.Byte" />.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
	public static explicit operator byte(BigInteger value)
	{
		return 0;
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Numerics.BigInteger" /> object to a signed 8-bit value.  
	///  This API is not CLS-compliant. The compliant alternative is <see cref="T:System.Int16" />.</summary>
	/// <param name="value">The value to convert to a signed 8-bit value.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.SByte.MinValue" /> or is greater than <see cref="F:System.SByte.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static explicit operator sbyte(BigInteger value)
	{
		return 0;
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Numerics.BigInteger" /> object to a 16-bit signed integer value.</summary>
	/// <param name="value">The value to convert to a 16-bit signed integer.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Int16.MinValue" /> or is greater than <see cref="F:System.Int16.MaxValue" />.</exception>
	public static explicit operator short(BigInteger value)
	{
		return 0;
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Numerics.BigInteger" /> object to an unsigned 16-bit integer value.  
	///  This API is not CLS-compliant. The compliant alternative is <see cref="T:System.Int32" />.</summary>
	/// <param name="value">The value to convert to an unsigned 16-bit integer.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.UInt16.MinValue" /> or is greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static explicit operator ushort(BigInteger value)
	{
		return 0;
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Numerics.BigInteger" /> object to a 32-bit signed integer value.</summary>
	/// <param name="value">The value to convert to a 32-bit signed integer.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Int32.MinValue" /> or is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	public static explicit operator int(BigInteger value)
	{
		return 0;
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Numerics.BigInteger" /> object to an unsigned 32-bit integer value.  
	///  This API is not CLS-compliant. The compliant alternative is <see cref="T:System.Int64" />.</summary>
	/// <param name="value">The value to convert to an unsigned 32-bit integer.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.UInt32.MinValue" /> or is greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static explicit operator uint(BigInteger value)
	{
		return 0u;
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Numerics.BigInteger" /> object to a 64-bit signed integer value.</summary>
	/// <param name="value">The value to convert to a 64-bit signed integer.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Int64.MinValue" /> or is greater than <see cref="F:System.Int64.MaxValue" />.</exception>
	public static explicit operator long(BigInteger value)
	{
		return 0L;
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Numerics.BigInteger" /> object to an unsigned 64-bit integer value.  
	///  This API is not CLS-compliant. The compliant alternative is <see cref="T:System.Double" />.</summary>
	/// <param name="value">The value to convert to an unsigned 64-bit integer.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.UInt64.MinValue" /> or is greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static explicit operator ulong(BigInteger value)
	{
		return 0uL;
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Numerics.BigInteger" /> object to a single-precision floating-point value.</summary>
	/// <param name="value">The value to convert to a single-precision floating-point value.</param>
	/// <returns>An object that contains the closest possible representation of the <paramref name="value" /> parameter.</returns>
	public static explicit operator float(BigInteger value)
	{
		return 0f;
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Numerics.BigInteger" /> object to a <see cref="T:System.Double" /> value.</summary>
	/// <param name="value">The value to convert to a <see cref="T:System.Double" />.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	public static explicit operator double(BigInteger value)
	{
		return 0.0;
	}

	/// <summary>Defines an explicit conversion of a <see cref="T:System.Numerics.BigInteger" /> object to a <see cref="T:System.Decimal" /> value.</summary>
	/// <param name="value">The value to convert to a <see cref="T:System.Decimal" />.</param>
	/// <returns>An object that contains the value of the <paramref name="value" /> parameter.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
	public static explicit operator decimal(BigInteger value)
	{
		return default(decimal);
	}

	/// <summary>Shifts a <see cref="T:System.Numerics.BigInteger" /> value a specified number of bits to the left.</summary>
	/// <param name="value">The value whose bits are to be shifted.</param>
	/// <param name="shift">The number of bits to shift <paramref name="value" /> to the left.</param>
	/// <returns>A value that has been shifted to the left by the specified number of bits.</returns>
	public static BigInteger operator <<(BigInteger value, int shift)
	{
		return default(BigInteger);
	}

	/// <summary>Shifts a <see cref="T:System.Numerics.BigInteger" /> value a specified number of bits to the right.</summary>
	/// <param name="value">The value whose bits are to be shifted.</param>
	/// <param name="shift">The number of bits to shift <paramref name="value" /> to the right.</param>
	/// <returns>A value that has been shifted to the right by the specified number of bits.</returns>
	public static BigInteger operator >>(BigInteger value, int shift)
	{
		return default(BigInteger);
	}

	/// <summary>Negates a specified BigInteger value.</summary>
	/// <param name="value">The value to negate.</param>
	/// <returns>The result of the <paramref name="value" /> parameter multiplied by negative one (-1).</returns>
	public static BigInteger operator -(BigInteger value)
	{
		return default(BigInteger);
	}

	/// <summary>Adds the values of two specified <see cref="T:System.Numerics.BigInteger" /> objects.</summary>
	/// <param name="left">The first value to add.</param>
	/// <param name="right">The second value to add.</param>
	/// <returns>The sum of <paramref name="left" /> and <paramref name="right" />.</returns>
	public static BigInteger operator +(BigInteger left, BigInteger right)
	{
		return default(BigInteger);
	}

	/// <summary>Multiplies two specified <see cref="T:System.Numerics.BigInteger" /> values.</summary>
	/// <param name="left">The first value to multiply.</param>
	/// <param name="right">The second value to multiply.</param>
	/// <returns>The product of <paramref name="left" /> and <paramref name="right" />.</returns>
	public static BigInteger operator *(BigInteger left, BigInteger right)
	{
		return default(BigInteger);
	}

	/// <summary>Divides a specified <see cref="T:System.Numerics.BigInteger" /> value by another specified <see cref="T:System.Numerics.BigInteger" /> value by using integer division.</summary>
	/// <param name="dividend">The value to be divided.</param>
	/// <param name="divisor">The value to divide by.</param>
	/// <returns>The integral result of the division.</returns>
	/// <exception cref="T:System.DivideByZeroException">
	///   <paramref name="divisor" /> is 0 (zero).</exception>
	public static BigInteger operator /(BigInteger dividend, BigInteger divisor)
	{
		return default(BigInteger);
	}

	/// <summary>Returns the remainder that results from division with two specified <see cref="T:System.Numerics.BigInteger" /> values.</summary>
	/// <param name="dividend">The value to be divided.</param>
	/// <param name="divisor">The value to divide by.</param>
	/// <returns>The remainder that results from the division.</returns>
	/// <exception cref="T:System.DivideByZeroException">
	///   <paramref name="divisor" /> is 0 (zero).</exception>
	public static BigInteger operator %(BigInteger dividend, BigInteger divisor)
	{
		return default(BigInteger);
	}

	/// <summary>Returns a value that indicates whether a <see cref="T:System.Numerics.BigInteger" /> value is less than or equal to another <see cref="T:System.Numerics.BigInteger" /> value.</summary>
	/// <param name="left">The first value to compare.</param>
	/// <param name="right">The second value to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is less than or equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator <=(BigInteger left, BigInteger right)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether two <see cref="T:System.Numerics.BigInteger" /> objects have different values.</summary>
	/// <param name="left">The first value to compare.</param>
	/// <param name="right">The second value to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(BigInteger left, BigInteger right)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether a <see cref="T:System.Numerics.BigInteger" /> value is less than a 64-bit signed integer.</summary>
	/// <param name="left">The first value to compare.</param>
	/// <param name="right">The second value to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is less than <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator <(BigInteger left, long right)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether a <see cref="T:System.Numerics.BigInteger" /> value is less than or equal to a 64-bit signed integer.</summary>
	/// <param name="left">The first value to compare.</param>
	/// <param name="right">The second value to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is less than or equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator <=(BigInteger left, long right)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether a <see cref="T:System.Numerics.BigInteger" /> value and a signed long integer value are equal.</summary>
	/// <param name="left">The first value to compare.</param>
	/// <param name="right">The second value to compare.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="left" /> and <paramref name="right" /> parameters have the same value; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(BigInteger left, long right)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether a <see cref="T:System.Numerics.BigInteger" /> value and a 64-bit signed integer are not equal.</summary>
	/// <param name="left">The first value to compare.</param>
	/// <param name="right">The second value to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(BigInteger left, long right)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether a 64-bit signed integer is less than a <see cref="T:System.Numerics.BigInteger" /> value.</summary>
	/// <param name="left">The first value to compare.</param>
	/// <param name="right">The second value to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is less than <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator <(long left, BigInteger right)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether a 64-bit signed integer is less than or equal to a <see cref="T:System.Numerics.BigInteger" /> value.</summary>
	/// <param name="left">The first value to compare.</param>
	/// <param name="right">The second value to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is less than or equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator <=(long left, BigInteger right)
	{
		return false;
	}

	private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl)
	{
		xd = null;
		xl = default(int);
		return false;
	}

	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu)
	{
		return 0;
	}
}
