using System.Runtime.CompilerServices;

namespace System;

/// <summary>Converts a base data type to another base data type.</summary>
public static class Convert
{
	private static readonly sbyte[] s_decodingMap;

	internal static readonly Type[] ConvertTypes;

	private static readonly Type EnumType;

	internal static readonly char[] base64Table;

	/// <summary>A constant that represents a database column that is absent of data; that is, database null.</summary>
	public static readonly object DBNull;

	private static bool TryDecodeFromUtf16(ReadOnlySpan<char> utf16, Span<byte> bytes, out int consumed, out int written)
	{
		consumed = default(int);
		written = default(int);
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int Decode(ref char encodedChars, ref sbyte decodingMap)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void WriteThreeLowOrderBytes(ref byte destination, int value)
	{
	}

	/// <summary>Returns the <see cref="T:System.TypeCode" /> for the specified object.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <returns>The <see cref="T:System.TypeCode" /> for <paramref name="value" />, or <see cref="F:System.TypeCode.Empty" /> if <paramref name="value" /> is <see langword="null" />.</returns>
	public static TypeCode GetTypeCode(object value)
	{
		return default(TypeCode);
	}

	/// <summary>Returns an object of the specified type whose value is equivalent to the specified object. A parameter supplies culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="typeCode">The type of object to return.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>An object whose underlying type is <paramref name="typeCode" /> and whose value is equivalent to <paramref name="value" />.  
	///  -or-  
	///  A null reference (<see langword="Nothing" /> in Visual Basic), if <paramref name="value" /> is <see langword="null" /> and <paramref name="typeCode" /> is <see cref="F:System.TypeCode.Empty" />, <see cref="F:System.TypeCode.String" />, or <see cref="F:System.TypeCode.Object" />.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported.  
	///  -or-  
	///  <paramref name="value" /> is <see langword="null" /> and <paramref name="typeCode" /> specifies a value type.  
	///  -or-  
	///  <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in a format for the <paramref name="typeCode" /> type recognized by <paramref name="provider" />.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is out of the range of the <paramref name="typeCode" /> type.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="typeCode" /> is invalid.</exception>
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider)
	{
		return null;
	}

	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Returns an object of the specified type and whose value is equivalent to the specified object.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="conversionType">The type of object to return.</param>
	/// <returns>An object whose type is <paramref name="conversionType" /> and whose value is equivalent to <paramref name="value" />.  
	///  -or-  
	///  A null reference (<see langword="Nothing" /> in Visual Basic), if <paramref name="value" /> is <see langword="null" /> and <paramref name="conversionType" /> is not a value type.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported.  
	///  -or-  
	///  <paramref name="value" /> is <see langword="null" /> and <paramref name="conversionType" /> is a value type.  
	///  -or-  
	///  <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in a format recognized by <paramref name="conversionType" />.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is out of the range of <paramref name="conversionType" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="conversionType" /> is <see langword="null" />.</exception>
	public static object ChangeType(object value, Type conversionType)
	{
		return null;
	}

	/// <summary>Returns an object of the specified type whose value is equivalent to the specified object. A parameter supplies culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="conversionType">The type of object to return.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>An object whose type is <paramref name="conversionType" /> and whose value is equivalent to <paramref name="value" />.  
	///  -or-  
	///  <paramref name="value" />, if the <see cref="T:System.Type" /> of <paramref name="value" /> and <paramref name="conversionType" /> are equal.  
	///  -or-  
	///  A null reference (<see langword="Nothing" /> in Visual Basic), if <paramref name="value" /> is <see langword="null" /> and <paramref name="conversionType" /> is not a value type.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported.  
	///  -or-  
	///  <paramref name="value" /> is <see langword="null" /> and <paramref name="conversionType" /> is a value type.  
	///  -or-  
	///  <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in a format for <paramref name="conversionType" /> recognized by <paramref name="provider" />.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is out of the range of <paramref name="conversionType" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="conversionType" /> is <see langword="null" />.</exception>
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowCharOverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowByteOverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowSByteOverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowInt16OverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowUInt16OverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowInt32OverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowUInt32OverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowInt64OverflowException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowUInt64OverflowException()
	{
	}

	/// <summary>Converts the value of a specified object to an equivalent Boolean value.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> or <see langword="false" />, which reflects the value returned by invoking the <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" /> method for the underlying type of <paramref name="value" />. If <paramref name="value" /> is <see langword="null" />, the method returns <see langword="false" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is a string that does not equal <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion of <paramref name="value" /> to a <see cref="T:System.Boolean" /> is not supported.</exception>
	public static bool ToBoolean(object value)
	{
		return false;
	}

	/// <summary>Converts the value of the specified object to an equivalent Boolean value, using the specified culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>
	///   <see langword="true" /> or <see langword="false" />, which reflects the value returned by invoking the <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" /> method for the underlying type of <paramref name="value" />. If <paramref name="value" /> is <see langword="null" />, the method returns <see langword="false" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is a string that does not equal <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion of <paramref name="value" /> to a <see cref="T:System.Boolean" /> is not supported.</exception>
	public static bool ToBoolean(object value, IFormatProvider provider)
	{
		return false;
	}

	/// <summary>Converts the value of the specified 8-bit signed integer to an equivalent Boolean value.</summary>
	/// <param name="value">The 8-bit signed integer to convert.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
	[CLSCompliant(false)]
	public static bool ToBoolean(sbyte value)
	{
		return false;
	}

	/// <summary>Converts the value of the specified 8-bit unsigned integer to an equivalent Boolean value.</summary>
	/// <param name="value">The 8-bit unsigned integer to convert.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
	public static bool ToBoolean(byte value)
	{
		return false;
	}

	/// <summary>Converts the value of the specified 16-bit signed integer to an equivalent Boolean value.</summary>
	/// <param name="value">The 16-bit signed integer to convert.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
	public static bool ToBoolean(short value)
	{
		return false;
	}

	/// <summary>Converts the value of the specified 16-bit unsigned integer to an equivalent Boolean value.</summary>
	/// <param name="value">The 16-bit unsigned integer to convert.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
	[CLSCompliant(false)]
	public static bool ToBoolean(ushort value)
	{
		return false;
	}

	/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent Boolean value.</summary>
	/// <param name="value">The 32-bit signed integer to convert.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
	public static bool ToBoolean(int value)
	{
		return false;
	}

	/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent Boolean value.</summary>
	/// <param name="value">The 32-bit unsigned integer to convert.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
	[CLSCompliant(false)]
	public static bool ToBoolean(uint value)
	{
		return false;
	}

	/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent Boolean value.</summary>
	/// <param name="value">The 64-bit signed integer to convert.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
	public static bool ToBoolean(long value)
	{
		return false;
	}

	/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent Boolean value.</summary>
	/// <param name="value">The 64-bit unsigned integer to convert.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
	[CLSCompliant(false)]
	public static bool ToBoolean(ulong value)
	{
		return false;
	}

	/// <summary>Converts the specified string representation of a logical value to its Boolean equivalent.</summary>
	/// <param name="value">A string that contains the value of either <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> equals <see cref="F:System.Boolean.TrueString" />, or <see langword="false" /> if <paramref name="value" /> equals <see cref="F:System.Boolean.FalseString" /> or <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not equal to <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />.</exception>
	public static bool ToBoolean(string value)
	{
		return false;
	}

	/// <summary>Converts the specified string representation of a logical value to its Boolean equivalent, using the specified culture-specific formatting information.</summary>
	/// <param name="value">A string that contains the value of either <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information. This parameter is ignored.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> equals <see cref="F:System.Boolean.TrueString" />, or <see langword="false" /> if <paramref name="value" /> equals <see cref="F:System.Boolean.FalseString" /> or <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not equal to <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />.</exception>
	public static bool ToBoolean(string value, IFormatProvider provider)
	{
		return false;
	}

	/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent Boolean value.</summary>
	/// <param name="value">The single-precision floating-point number to convert.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
	public static bool ToBoolean(float value)
	{
		return false;
	}

	/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent Boolean value.</summary>
	/// <param name="value">The double-precision floating-point number to convert.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
	public static bool ToBoolean(double value)
	{
		return false;
	}

	/// <summary>Converts the value of the specified decimal number to an equivalent Boolean value.</summary>
	/// <param name="value">The number to convert.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is not zero; otherwise, <see langword="false" />.</returns>
	public static bool ToBoolean(decimal value)
	{
		return false;
	}

	/// <summary>Converts the value of the specified object to a Unicode character.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <returns>A Unicode character that is equivalent to value, or <see cref="F:System.Char.MinValue" /> if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is a null string.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion of <paramref name="value" /> to a <see cref="T:System.Char" /> is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" /> or greater than <see cref="F:System.Char.MaxValue" />.</exception>
	public static char ToChar(object value)
	{
		return '\0';
	}

	/// <summary>Converts the value of the specified object to its equivalent Unicode character, using the specified culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A Unicode character that is equivalent to <paramref name="value" />, or <see cref="F:System.Char.MinValue" /> if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is a null string.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion of <paramref name="value" /> to a <see cref="T:System.Char" /> is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" /> or greater than <see cref="F:System.Char.MaxValue" />.</exception>
	public static char ToChar(object value, IFormatProvider provider)
	{
		return '\0';
	}

	/// <summary>Converts the value of the specified 8-bit signed integer to its equivalent Unicode character.</summary>
	/// <param name="value">The 8-bit signed integer to convert.</param>
	/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" />.</exception>
	[CLSCompliant(false)]
	public static char ToChar(sbyte value)
	{
		return '\0';
	}

	/// <summary>Converts the value of the specified 8-bit unsigned integer to its equivalent Unicode character.</summary>
	/// <param name="value">The 8-bit unsigned integer to convert.</param>
	/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
	public static char ToChar(byte value)
	{
		return '\0';
	}

	/// <summary>Converts the value of the specified 16-bit signed integer to its equivalent Unicode character.</summary>
	/// <param name="value">The 16-bit signed integer to convert.</param>
	/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" />.</exception>
	public static char ToChar(short value)
	{
		return '\0';
	}

	/// <summary>Converts the value of the specified 16-bit unsigned integer to its equivalent Unicode character.</summary>
	/// <param name="value">The 16-bit unsigned integer to convert.</param>
	/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static char ToChar(ushort value)
	{
		return '\0';
	}

	/// <summary>Converts the value of the specified 32-bit signed integer to its equivalent Unicode character.</summary>
	/// <param name="value">The 32-bit signed integer to convert.</param>
	/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" /> or greater than <see cref="F:System.Char.MaxValue" />.</exception>
	public static char ToChar(int value)
	{
		return '\0';
	}

	/// <summary>Converts the value of the specified 32-bit unsigned integer to its equivalent Unicode character.</summary>
	/// <param name="value">The 32-bit unsigned integer to convert.</param>
	/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Char.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static char ToChar(uint value)
	{
		return '\0';
	}

	/// <summary>Converts the value of the specified 64-bit signed integer to its equivalent Unicode character.</summary>
	/// <param name="value">The 64-bit signed integer to convert.</param>
	/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Char.MinValue" /> or greater than <see cref="F:System.Char.MaxValue" />.</exception>
	public static char ToChar(long value)
	{
		return '\0';
	}

	/// <summary>Converts the value of the specified 64-bit unsigned integer to its equivalent Unicode character.</summary>
	/// <param name="value">The 64-bit unsigned integer to convert.</param>
	/// <returns>A Unicode character that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Char.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static char ToChar(ulong value)
	{
		return '\0';
	}

	/// <summary>Converts the first character of a specified string to a Unicode character.</summary>
	/// <param name="value">A string of length 1.</param>
	/// <returns>A Unicode character that is equivalent to the first and only character in <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">The length of <paramref name="value" /> is not 1.</exception>
	public static char ToChar(string value)
	{
		return '\0';
	}

	/// <summary>Converts the first character of a specified string to a Unicode character, using specified culture-specific formatting information.</summary>
	/// <param name="value">A string of length 1 or <see langword="null" />.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information. This parameter is ignored.</param>
	/// <returns>A Unicode character that is equivalent to the first and only character in <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">The length of <paramref name="value" /> is not 1.</exception>
	public static char ToChar(string value, IFormatProvider provider)
	{
		return '\0';
	}

	/// <summary>Converts the value of the specified object to an 8-bit signed integer.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />.</param>
	/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(object value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified object to an 8-bit signed integer, using the specified culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(object value, IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the specified Boolean value to the equivalent 8-bit signed integer.</summary>
	/// <param name="value">The Boolean value to convert.</param>
	/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
	[CLSCompliant(false)]
	public static sbyte ToSByte(bool value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified Unicode character to the equivalent 8-bit signed integer.</summary>
	/// <param name="value">The Unicode character to convert.</param>
	/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(char value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 8-bit signed integer.</summary>
	/// <param name="value">The 8-bit unsigned integer to convert.</param>
	/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(byte value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 16-bit signed integer to the equivalent 8-bit signed integer.</summary>
	/// <param name="value">The 16-bit signed integer to convert.</param>
	/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(short value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 8-bit signed integer.</summary>
	/// <param name="value">The 16-bit unsigned integer to convert.</param>
	/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(ushort value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 8-bit signed integer.</summary>
	/// <param name="value">The 32-bit signed integer to convert.</param>
	/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(int value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 8-bit signed integer.</summary>
	/// <param name="value">The 32-bit unsigned integer to convert.</param>
	/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(uint value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 8-bit signed integer.</summary>
	/// <param name="value">The 64-bit signed integer to convert.</param>
	/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(long value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 8-bit signed integer.</summary>
	/// <param name="value">The 64-bit unsigned integer to convert.</param>
	/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(ulong value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 8-bit signed integer.</summary>
	/// <param name="value">The single-precision floating-point number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 8-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(float value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 8-bit signed integer.</summary>
	/// <param name="value">The double-precision floating-point number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 8-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(double value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified decimal number to an equivalent 8-bit signed integer.</summary>
	/// <param name="value">The decimal number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 8-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.SByte.MaxValue" /> or less than <see cref="F:System.SByte.MinValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(decimal value)
	{
		return 0;
	}

	/// <summary>Converts the specified string representation of a number to an equivalent 8-bit signed integer, using the specified culture-specific formatting information.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(string value, IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified object to an 8-bit unsigned integer.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />.</param>
	/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in the property format for a <see cref="T:System.Byte" /> value.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement <see cref="T:System.IConvertible" />.  
	/// -or-  
	/// Conversion from <paramref name="value" /> to the <see cref="T:System.Byte" /> type is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
	public static byte ToByte(object value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified object to an 8-bit unsigned integer, using the specified culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in the property format for a <see cref="T:System.Byte" /> value.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement <see cref="T:System.IConvertible" />.  
	/// -or-  
	/// Conversion from <paramref name="value" /> to the <see cref="T:System.Byte" /> type is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
	public static byte ToByte(object value, IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the specified Boolean value to the equivalent 8-bit unsigned integer.</summary>
	/// <param name="value">The Boolean value to convert.</param>
	/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
	public static byte ToByte(bool value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified Unicode character to the equivalent 8-bit unsigned integer.</summary>
	/// <param name="value">The Unicode character to convert.</param>
	/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is greater than <see cref="F:System.Byte.MaxValue" />.</exception>
	public static byte ToByte(char value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 8-bit signed integer to an equivalent 8-bit unsigned integer.</summary>
	/// <param name="value">The 8-bit signed integer to be converted.</param>
	/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" />.</exception>
	[CLSCompliant(false)]
	public static byte ToByte(sbyte value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 16-bit signed integer to an equivalent 8-bit unsigned integer.</summary>
	/// <param name="value">The 16-bit signed integer to convert.</param>
	/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
	public static byte ToByte(short value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 16-bit unsigned integer to an equivalent 8-bit unsigned integer.</summary>
	/// <param name="value">The 16-bit unsigned integer to convert.</param>
	/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static byte ToByte(ushort value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 8-bit unsigned integer.</summary>
	/// <param name="value">The 32-bit signed integer to convert.</param>
	/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
	public static byte ToByte(int value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 8-bit unsigned integer.</summary>
	/// <param name="value">The 32-bit unsigned integer to convert.</param>
	/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static byte ToByte(uint value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 8-bit unsigned integer.</summary>
	/// <param name="value">The 64-bit signed integer to convert.</param>
	/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
	public static byte ToByte(long value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 8-bit unsigned integer.</summary>
	/// <param name="value">The 64-bit unsigned integer to convert.</param>
	/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static byte ToByte(ulong value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 8-bit unsigned integer.</summary>
	/// <param name="value">A single-precision floating-point number.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 8-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" /> or less than <see cref="F:System.Byte.MinValue" />.</exception>
	public static byte ToByte(float value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 8-bit unsigned integer.</summary>
	/// <param name="value">The double-precision floating-point number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 8-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" /> or less than <see cref="F:System.Byte.MinValue" />.</exception>
	public static byte ToByte(double value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified decimal number to an equivalent 8-bit unsigned integer.</summary>
	/// <param name="value">The number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 8-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Byte.MaxValue" /> or less than <see cref="F:System.Byte.MinValue" />.</exception>
	public static byte ToByte(decimal value)
	{
		return 0;
	}

	/// <summary>Converts the specified string representation of a number to an equivalent 8-bit unsigned integer.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
	public static byte ToByte(string value)
	{
		return 0;
	}

	/// <summary>Converts the specified string representation of a number to an equivalent 8-bit unsigned integer, using specified culture-specific formatting information.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>An 8-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
	public static byte ToByte(string value, IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified object to a 16-bit signed integer.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />.</param>
	/// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format for an <see cref="T:System.Int16" /> type.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />.</exception>
	public static short ToInt16(object value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified object to a 16-bit signed integer, using the specified culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format for an <see cref="T:System.Int16" /> type.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement <see cref="T:System.IConvertible" />.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />.</exception>
	public static short ToInt16(object value, IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the specified Boolean value to the equivalent 16-bit signed integer.</summary>
	/// <param name="value">The Boolean value to convert.</param>
	/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
	public static short ToInt16(bool value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified Unicode character to the equivalent 16-bit signed integer.</summary>
	/// <param name="value">The Unicode character to convert.</param>
	/// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" />.</exception>
	public static short ToInt16(char value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 16-bit signed integer.</summary>
	/// <param name="value">The 8-bit signed integer to convert.</param>
	/// <returns>A 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static short ToInt16(sbyte value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 16-bit signed integer.</summary>
	/// <param name="value">The 8-bit unsigned integer to convert.</param>
	/// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	public static short ToInt16(byte value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 16-bit signed integer.</summary>
	/// <param name="value">The 16-bit unsigned integer to convert.</param>
	/// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static short ToInt16(ushort value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 16-bit signed integer.</summary>
	/// <param name="value">The 32-bit signed integer to convert.</param>
	/// <returns>The 16-bit signed integer equivalent of <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />.</exception>
	public static short ToInt16(int value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 16-bit signed integer.</summary>
	/// <param name="value">The 32-bit unsigned integer to convert.</param>
	/// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static short ToInt16(uint value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 16-bit signed integer.</summary>
	/// <param name="value">The 64-bit signed integer to convert.</param>
	/// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />.</exception>
	public static short ToInt16(long value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 16-bit signed integer.</summary>
	/// <param name="value">The 64-bit unsigned integer to convert.</param>
	/// <returns>A 16-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static short ToInt16(ulong value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 16-bit signed integer.</summary>
	/// <param name="value">The single-precision floating-point number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 16-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />.</exception>
	public static short ToInt16(float value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 16-bit signed integer.</summary>
	/// <param name="value">The double-precision floating-point number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 16-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />.</exception>
	public static short ToInt16(double value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified decimal number to an equivalent 16-bit signed integer.</summary>
	/// <param name="value">The decimal number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 16-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int16.MaxValue" /> or less than <see cref="F:System.Int16.MinValue" />.</exception>
	public static short ToInt16(decimal value)
	{
		return 0;
	}

	/// <summary>Converts the specified string representation of a number to an equivalent 16-bit signed integer, using the specified culture-specific formatting information.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A 16-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />.</exception>
	public static short ToInt16(string value, IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified object to a 16-bit unsigned integer.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />.</param>
	/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the  <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(object value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified object to a 16-bit unsigned integer, using the specified culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the  <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(object value, IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the specified Boolean value to the equivalent 16-bit unsigned integer.</summary>
	/// <param name="value">The Boolean value to convert.</param>
	/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
	[CLSCompliant(false)]
	public static ushort ToUInt16(bool value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified Unicode character to the equivalent 16-bit unsigned integer.</summary>
	/// <param name="value">The Unicode character to convert.</param>
	/// <returns>The 16-bit unsigned integer equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static ushort ToUInt16(char value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 16-bit unsigned integer.</summary>
	/// <param name="value">The 8-bit signed integer to convert.</param>
	/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero.</exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(sbyte value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 16-bit unsigned integer.</summary>
	/// <param name="value">The 8-bit unsigned integer to convert.</param>
	/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static ushort ToUInt16(byte value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 16-bit signed integer to the equivalent 16-bit unsigned integer.</summary>
	/// <param name="value">The 16-bit signed integer to convert.</param>
	/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero.</exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(short value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 16-bit unsigned integer.</summary>
	/// <param name="value">The 32-bit signed integer to convert.</param>
	/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(int value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 16-bit unsigned integer.</summary>
	/// <param name="value">The 32-bit unsigned integer to convert.</param>
	/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(uint value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 16-bit unsigned integer.</summary>
	/// <param name="value">The 64-bit signed integer to convert.</param>
	/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(long value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 16-bit unsigned integer.</summary>
	/// <param name="value">The 64-bit unsigned integer to convert.</param>
	/// <returns>A 16-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(ulong value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 16-bit unsigned integer.</summary>
	/// <param name="value">The single-precision floating-point number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 16-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(float value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 16-bit unsigned integer.</summary>
	/// <param name="value">The double-precision floating-point number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 16-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(double value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified decimal number to an equivalent 16-bit unsigned integer.</summary>
	/// <param name="value">The decimal number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 16-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(decimal value)
	{
		return 0;
	}

	/// <summary>Converts the specified string representation of a number to an equivalent 16-bit unsigned integer, using the specified culture-specific formatting information.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A 16-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(string value, IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified object to a 32-bit signed integer.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />.</param>
	/// <returns>A 32-bit signed integer equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the  <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	public static int ToInt32(object value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified object to a 32-bit signed integer, using the specified culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement <see cref="T:System.IConvertible" />.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	public static int ToInt32(object value, IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the specified Boolean value to the equivalent 32-bit signed integer.</summary>
	/// <param name="value">The Boolean value to convert.</param>
	/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
	public static int ToInt32(bool value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified Unicode character to the equivalent 32-bit signed integer.</summary>
	/// <param name="value">The Unicode character to convert.</param>
	/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	public static int ToInt32(char value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 32-bit signed integer.</summary>
	/// <param name="value">The 8-bit unsigned integer to convert.</param>
	/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	public static int ToInt32(byte value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 16-bit signed integer to an equivalent 32-bit signed integer.</summary>
	/// <param name="value">The 16-bit signed integer to convert.</param>
	/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	public static int ToInt32(short value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 32-bit signed integer.</summary>
	/// <param name="value">The 16-bit unsigned integer to convert.</param>
	/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static int ToInt32(ushort value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 32-bit signed integer.</summary>
	/// <param name="value">The 32-bit unsigned integer to convert.</param>
	/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static int ToInt32(uint value)
	{
		return 0;
	}

	/// <summary>Returns the specified 32-bit signed integer; no actual conversion is performed.</summary>
	/// <param name="value">The 32-bit signed integer to return.</param>
	/// <returns>
	///   <paramref name="value" /> is returned unchanged.</returns>
	public static int ToInt32(int value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 32-bit signed integer.</summary>
	/// <param name="value">The 64-bit signed integer to convert.</param>
	/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" /> or less than <see cref="F:System.Int32.MinValue" />.</exception>
	public static int ToInt32(long value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 32-bit signed integer.</summary>
	/// <param name="value">The 64-bit unsigned integer to convert.</param>
	/// <returns>A 32-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static int ToInt32(ulong value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 32-bit signed integer.</summary>
	/// <param name="value">The single-precision floating-point number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 32-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" /> or less than <see cref="F:System.Int32.MinValue" />.</exception>
	public static int ToInt32(float value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 32-bit signed integer.</summary>
	/// <param name="value">The double-precision floating-point number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 32-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" /> or less than <see cref="F:System.Int32.MinValue" />.</exception>
	public static int ToInt32(double value)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified decimal number to an equivalent 32-bit signed integer.</summary>
	/// <param name="value">The decimal number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 32-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int32.MaxValue" /> or less than <see cref="F:System.Int32.MinValue" />.</exception>
	public static int ToInt32(decimal value)
	{
		return 0;
	}

	/// <summary>Converts the specified string representation of a number to an equivalent 32-bit signed integer.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <returns>A 32-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	public static int ToInt32(string value)
	{
		return 0;
	}

	/// <summary>Converts the specified string representation of a number to an equivalent 32-bit signed integer, using the specified culture-specific formatting information.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A 32-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	public static int ToInt32(string value, IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the value of the specified object to a 32-bit unsigned integer.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />.</param>
	/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static uint ToUInt32(object value)
	{
		return 0u;
	}

	/// <summary>Converts the value of the specified object to a 32-bit unsigned integer, using the specified culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static uint ToUInt32(object value, IFormatProvider provider)
	{
		return 0u;
	}

	/// <summary>Converts the specified Boolean value to the equivalent 32-bit unsigned integer.</summary>
	/// <param name="value">The Boolean value to convert.</param>
	/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
	[CLSCompliant(false)]
	public static uint ToUInt32(bool value)
	{
		return 0u;
	}

	/// <summary>Converts the value of the specified Unicode character to the equivalent 32-bit unsigned integer.</summary>
	/// <param name="value">The Unicode character to convert.</param>
	/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static uint ToUInt32(char value)
	{
		return 0u;
	}

	/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 32-bit unsigned integer.</summary>
	/// <param name="value">The 8-bit signed integer to convert.</param>
	/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero.</exception>
	[CLSCompliant(false)]
	public static uint ToUInt32(sbyte value)
	{
		return 0u;
	}

	/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 32-bit unsigned integer.</summary>
	/// <param name="value">The 8-bit unsigned integer to convert.</param>
	/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static uint ToUInt32(byte value)
	{
		return 0u;
	}

	/// <summary>Converts the value of the specified 16-bit signed integer to the equivalent 32-bit unsigned integer.</summary>
	/// <param name="value">The 16-bit signed integer to convert.</param>
	/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero.</exception>
	[CLSCompliant(false)]
	public static uint ToUInt32(short value)
	{
		return 0u;
	}

	/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 32-bit unsigned integer.</summary>
	/// <param name="value">The 16-bit unsigned integer to convert.</param>
	/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static uint ToUInt32(ushort value)
	{
		return 0u;
	}

	/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 32-bit unsigned integer.</summary>
	/// <param name="value">The 32-bit signed integer to convert.</param>
	/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero.</exception>
	[CLSCompliant(false)]
	public static uint ToUInt32(int value)
	{
		return 0u;
	}

	/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 32-bit unsigned integer.</summary>
	/// <param name="value">The 64-bit signed integer to convert.</param>
	/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static uint ToUInt32(long value)
	{
		return 0u;
	}

	/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 32-bit unsigned integer.</summary>
	/// <param name="value">The 64-bit unsigned integer to convert.</param>
	/// <returns>A 32-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static uint ToUInt32(ulong value)
	{
		return 0u;
	}

	/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 32-bit unsigned integer.</summary>
	/// <param name="value">The single-precision floating-point number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 32-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static uint ToUInt32(float value)
	{
		return 0u;
	}

	/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 32-bit unsigned integer.</summary>
	/// <param name="value">The double-precision floating-point number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 32-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static uint ToUInt32(double value)
	{
		return 0u;
	}

	/// <summary>Converts the value of the specified decimal number to an equivalent 32-bit unsigned integer.</summary>
	/// <param name="value">The decimal number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 32-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static uint ToUInt32(decimal value)
	{
		return 0u;
	}

	/// <summary>Converts the specified string representation of a number to an equivalent 32-bit unsigned integer, using the specified culture-specific formatting information.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A 32-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static uint ToUInt32(string value, IFormatProvider provider)
	{
		return 0u;
	}

	/// <summary>Converts the value of the specified object to a 64-bit signed integer.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />.</param>
	/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />.</exception>
	public static long ToInt64(object value)
	{
		return 0L;
	}

	/// <summary>Converts the value of the specified object to a 64-bit signed integer, using the specified culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />.</exception>
	public static long ToInt64(object value, IFormatProvider provider)
	{
		return 0L;
	}

	/// <summary>Converts the specified Boolean value to the equivalent 64-bit signed integer.</summary>
	/// <param name="value">The Boolean value to convert.</param>
	/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
	public static long ToInt64(bool value)
	{
		return 0L;
	}

	/// <summary>Converts the value of the specified Unicode character to the equivalent 64-bit signed integer.</summary>
	/// <param name="value">The Unicode character to convert.</param>
	/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	public static long ToInt64(char value)
	{
		return 0L;
	}

	/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 64-bit signed integer.</summary>
	/// <param name="value">The 8-bit signed integer to convert.</param>
	/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static long ToInt64(sbyte value)
	{
		return 0L;
	}

	/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 64-bit signed integer.</summary>
	/// <param name="value">The 8-bit unsigned integer to convert.</param>
	/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	public static long ToInt64(byte value)
	{
		return 0L;
	}

	/// <summary>Converts the value of the specified 16-bit signed integer to an equivalent 64-bit signed integer.</summary>
	/// <param name="value">The 16-bit signed integer to convert.</param>
	/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	public static long ToInt64(short value)
	{
		return 0L;
	}

	/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 64-bit signed integer.</summary>
	/// <param name="value">The 16-bit unsigned integer to convert.</param>
	/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static long ToInt64(ushort value)
	{
		return 0L;
	}

	/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 64-bit signed integer.</summary>
	/// <param name="value">The 32-bit signed integer to convert.</param>
	/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	public static long ToInt64(int value)
	{
		return 0L;
	}

	/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 64-bit signed integer.</summary>
	/// <param name="value">The 32-bit unsigned integer to convert.</param>
	/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static long ToInt64(uint value)
	{
		return 0L;
	}

	/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent 64-bit signed integer.</summary>
	/// <param name="value">The 64-bit unsigned integer to convert.</param>
	/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int64.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static long ToInt64(ulong value)
	{
		return 0L;
	}

	/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 64-bit signed integer.</summary>
	/// <param name="value">The single-precision floating-point number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 64-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int64.MaxValue" /> or less than <see cref="F:System.Int64.MinValue" />.</exception>
	public static long ToInt64(float value)
	{
		return 0L;
	}

	/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 64-bit signed integer.</summary>
	/// <param name="value">The double-precision floating-point number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 64-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int64.MaxValue" /> or less than <see cref="F:System.Int64.MinValue" />.</exception>
	public static long ToInt64(double value)
	{
		return 0L;
	}

	/// <summary>Converts the value of the specified decimal number to an equivalent 64-bit signed integer.</summary>
	/// <param name="value">The decimal number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 64-bit signed integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Int64.MaxValue" /> or less than <see cref="F:System.Int64.MinValue" />.</exception>
	public static long ToInt64(decimal value)
	{
		return 0L;
	}

	/// <summary>Converts the specified string representation of a number to an equivalent 64-bit signed integer.</summary>
	/// <param name="value">A string that contains a number to convert.</param>
	/// <returns>A 64-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />.</exception>
	public static long ToInt64(string value)
	{
		return 0L;
	}

	/// <summary>Converts the specified string representation of a number to an equivalent 64-bit signed integer, using the specified culture-specific formatting information.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A 64-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />.</exception>
	public static long ToInt64(string value, IFormatProvider provider)
	{
		return 0L;
	}

	/// <summary>Converts the value of the specified object to a 64-bit unsigned integer.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />.</param>
	/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ulong ToUInt64(object value)
	{
		return 0uL;
	}

	/// <summary>Converts the value of the specified object to a 64-bit unsigned integer, using the specified culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ulong ToUInt64(object value, IFormatProvider provider)
	{
		return 0uL;
	}

	/// <summary>Converts the specified Boolean value to the equivalent 64-bit unsigned integer.</summary>
	/// <param name="value">The Boolean value to convert.</param>
	/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
	[CLSCompliant(false)]
	public static ulong ToUInt64(bool value)
	{
		return 0uL;
	}

	/// <summary>Converts the value of the specified Unicode character to the equivalent 64-bit unsigned integer.</summary>
	/// <param name="value">The Unicode character to convert.</param>
	/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static ulong ToUInt64(char value)
	{
		return 0uL;
	}

	/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent 64-bit unsigned integer.</summary>
	/// <param name="value">The 8-bit signed integer to convert.</param>
	/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero.</exception>
	[CLSCompliant(false)]
	public static ulong ToUInt64(sbyte value)
	{
		return 0uL;
	}

	/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent 64-bit unsigned integer.</summary>
	/// <param name="value">The 8-bit unsigned integer to convert.</param>
	/// <returns>A 64-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static ulong ToUInt64(byte value)
	{
		return 0uL;
	}

	/// <summary>Converts the value of the specified 16-bit signed integer to the equivalent 64-bit unsigned integer.</summary>
	/// <param name="value">The 16-bit signed integer to convert.</param>
	/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero.</exception>
	[CLSCompliant(false)]
	public static ulong ToUInt64(short value)
	{
		return 0uL;
	}

	/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent 64-bit unsigned integer.</summary>
	/// <param name="value">The 16-bit unsigned integer to convert.</param>
	/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static ulong ToUInt64(ushort value)
	{
		return 0uL;
	}

	/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent 64-bit unsigned integer.</summary>
	/// <param name="value">The 32-bit signed integer to convert.</param>
	/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero.</exception>
	[CLSCompliant(false)]
	public static ulong ToUInt64(int value)
	{
		return 0uL;
	}

	/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent 64-bit unsigned integer.</summary>
	/// <param name="value">The 32-bit unsigned integer to convert.</param>
	/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static ulong ToUInt64(uint value)
	{
		return 0uL;
	}

	/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent 64-bit unsigned integer.</summary>
	/// <param name="value">The 64-bit signed integer to convert.</param>
	/// <returns>A 64-bit unsigned integer that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero.</exception>
	[CLSCompliant(false)]
	public static ulong ToUInt64(long value)
	{
		return 0uL;
	}

	/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent 64-bit unsigned integer.</summary>
	/// <param name="value">The single-precision floating-point number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 64-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ulong ToUInt64(float value)
	{
		return 0uL;
	}

	/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent 64-bit unsigned integer.</summary>
	/// <param name="value">The double-precision floating-point number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 64-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ulong ToUInt64(double value)
	{
		return 0uL;
	}

	/// <summary>Converts the value of the specified decimal number to an equivalent 64-bit unsigned integer.</summary>
	/// <param name="value">The decimal number to convert.</param>
	/// <returns>
	///   <paramref name="value" />, rounded to the nearest 64-bit unsigned integer. If <paramref name="value" /> is halfway between two whole numbers, the even number is returned; that is, 4.5 is converted to 4, and 5.5 is converted to 6.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is less than zero or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ulong ToUInt64(decimal value)
	{
		return 0uL;
	}

	/// <summary>Converts the specified string representation of a number to an equivalent 64-bit unsigned integer, using the specified culture-specific formatting information.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A 64-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ulong ToUInt64(string value, IFormatProvider provider)
	{
		return 0uL;
	}

	/// <summary>Converts the value of the specified object to a single-precision floating-point number.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />.</param>
	/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />.</exception>
	public static float ToSingle(object value)
	{
		return 0f;
	}

	/// <summary>Converts the value of the specified object to an single-precision floating-point number, using the specified culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement <see cref="T:System.IConvertible" />.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />.</exception>
	public static float ToSingle(object value, IFormatProvider provider)
	{
		return 0f;
	}

	/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent single-precision floating-point number.</summary>
	/// <param name="value">The 8-bit signed integer to convert.</param>
	/// <returns>An 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static float ToSingle(sbyte value)
	{
		return 0f;
	}

	/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent single-precision floating-point number.</summary>
	/// <param name="value">The 8-bit unsigned integer to convert.</param>
	/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
	public static float ToSingle(byte value)
	{
		return 0f;
	}

	/// <summary>Converts the value of the specified 16-bit signed integer to an equivalent single-precision floating-point number.</summary>
	/// <param name="value">The 16-bit signed integer to convert.</param>
	/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
	public static float ToSingle(short value)
	{
		return 0f;
	}

	/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent single-precision floating-point number.</summary>
	/// <param name="value">The 16-bit unsigned integer to convert.</param>
	/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static float ToSingle(ushort value)
	{
		return 0f;
	}

	/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent single-precision floating-point number.</summary>
	/// <param name="value">The 32-bit signed integer to convert.</param>
	/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
	public static float ToSingle(int value)
	{
		return 0f;
	}

	/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent single-precision floating-point number.</summary>
	/// <param name="value">The 32-bit unsigned integer to convert.</param>
	/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static float ToSingle(uint value)
	{
		return 0f;
	}

	/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent single-precision floating-point number.</summary>
	/// <param name="value">The 64-bit signed integer to convert.</param>
	/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
	public static float ToSingle(long value)
	{
		return 0f;
	}

	/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent single-precision floating-point number.</summary>
	/// <param name="value">The 64-bit unsigned integer to convert.</param>
	/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static float ToSingle(ulong value)
	{
		return 0f;
	}

	/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent single-precision floating-point number.</summary>
	/// <param name="value">The double-precision floating-point number to convert.</param>
	/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.  
	///  <paramref name="value" /> is rounded using rounding to nearest. For example, when rounded to two decimals, the value 2.345 becomes 2.34 and the value 2.355 becomes 2.36.</returns>
	public static float ToSingle(double value)
	{
		return 0f;
	}

	/// <summary>Converts the value of the specified decimal number to an equivalent single-precision floating-point number.</summary>
	/// <param name="value">The decimal number to convert.</param>
	/// <returns>A single-precision floating-point number that is equivalent to <paramref name="value" />.  
	///  <paramref name="value" /> is rounded using rounding to nearest. For example, when rounded to two decimals, the value 2.345 becomes 2.34 and the value 2.355 becomes 2.36.</returns>
	public static float ToSingle(decimal value)
	{
		return 0f;
	}

	/// <summary>Converts the specified string representation of a number to an equivalent single-precision floating-point number.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <returns>A single-precision floating-point number that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not a number in a valid format.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />.</exception>
	public static float ToSingle(string value)
	{
		return 0f;
	}

	/// <summary>Converts the specified string representation of a number to an equivalent single-precision floating-point number, using the specified culture-specific formatting information.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A single-precision floating-point number that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not a number in a valid format.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Single.MinValue" /> or greater than <see cref="F:System.Single.MaxValue" />.</exception>
	public static float ToSingle(string value, IFormatProvider provider)
	{
		return 0f;
	}

	/// <summary>Converts the specified Boolean value to the equivalent single-precision floating-point number.</summary>
	/// <param name="value">The Boolean value to convert.</param>
	/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
	public static float ToSingle(bool value)
	{
		return 0f;
	}

	/// <summary>Converts the value of the specified object to a double-precision floating-point number.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface, or <see langword="null" />.</param>
	/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format for a <see cref="T:System.Double" /> type.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />.</exception>
	public static double ToDouble(object value)
	{
		return 0.0;
	}

	/// <summary>Converts the value of the specified object to an double-precision floating-point number, using the specified culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />, or zero if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format for a <see cref="T:System.Double" /> type.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />.</exception>
	public static double ToDouble(object value, IFormatProvider provider)
	{
		return 0.0;
	}

	/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent double-precision floating-point number.</summary>
	/// <param name="value">The 8-bit signed integer to convert.</param>
	/// <returns>The 8-bit signed integer that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static double ToDouble(sbyte value)
	{
		return 0.0;
	}

	/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent double-precision floating-point number.</summary>
	/// <param name="value">The 8-bit unsigned integer to convert.</param>
	/// <returns>The double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
	public static double ToDouble(byte value)
	{
		return 0.0;
	}

	/// <summary>Converts the value of the specified 16-bit signed integer to an equivalent double-precision floating-point number.</summary>
	/// <param name="value">The 16-bit signed integer to convert.</param>
	/// <returns>A double-precision floating-point number equivalent to <paramref name="value" />.</returns>
	public static double ToDouble(short value)
	{
		return 0.0;
	}

	/// <summary>Converts the value of the specified 16-bit unsigned integer to the equivalent double-precision floating-point number.</summary>
	/// <param name="value">The 16-bit unsigned integer to convert.</param>
	/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static double ToDouble(ushort value)
	{
		return 0.0;
	}

	/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent double-precision floating-point number.</summary>
	/// <param name="value">The 32-bit signed integer to convert.</param>
	/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
	public static double ToDouble(int value)
	{
		return 0.0;
	}

	/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent double-precision floating-point number.</summary>
	/// <param name="value">The 32-bit unsigned integer to convert.</param>
	/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static double ToDouble(uint value)
	{
		return 0.0;
	}

	/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent double-precision floating-point number.</summary>
	/// <param name="value">The 64-bit signed integer to convert.</param>
	/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
	public static double ToDouble(long value)
	{
		return 0.0;
	}

	/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent double-precision floating-point number.</summary>
	/// <param name="value">The 64-bit unsigned integer to convert.</param>
	/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static double ToDouble(ulong value)
	{
		return 0.0;
	}

	/// <summary>Converts the value of the specified single-precision floating-point number to an equivalent double-precision floating-point number.</summary>
	/// <param name="value">The single-precision floating-point number.</param>
	/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
	public static double ToDouble(float value)
	{
		return 0.0;
	}

	/// <summary>Converts the value of the specified decimal number to an equivalent double-precision floating-point number.</summary>
	/// <param name="value">The decimal number to convert.</param>
	/// <returns>A double-precision floating-point number that is equivalent to <paramref name="value" />.</returns>
	public static double ToDouble(decimal value)
	{
		return 0.0;
	}

	/// <summary>Converts the specified string representation of a number to an equivalent double-precision floating-point number, using the specified culture-specific formatting information.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A double-precision floating-point number that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not a number in a valid format.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Double.MinValue" /> or greater than <see cref="F:System.Double.MaxValue" />.</exception>
	public static double ToDouble(string value, IFormatProvider provider)
	{
		return 0.0;
	}

	/// <summary>Converts the specified Boolean value to the equivalent double-precision floating-point number.</summary>
	/// <param name="value">The Boolean value to convert.</param>
	/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
	public static double ToDouble(bool value)
	{
		return 0.0;
	}

	/// <summary>Converts the value of the specified object to an equivalent decimal number, using the specified culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A decimal number that is equivalent to <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not in an appropriate format for a <see cref="T:System.Decimal" /> type.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
	public static decimal ToDecimal(object value, IFormatProvider provider)
	{
		return default(decimal);
	}

	/// <summary>Converts the value of the specified 8-bit signed integer to the equivalent decimal number.</summary>
	/// <param name="value">The 8-bit signed integer to convert.</param>
	/// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static decimal ToDecimal(sbyte value)
	{
		return default(decimal);
	}

	/// <summary>Converts the value of the specified 8-bit unsigned integer to the equivalent decimal number.</summary>
	/// <param name="value">The 8-bit unsigned integer to convert.</param>
	/// <returns>The decimal number that is equivalent to <paramref name="value" />.</returns>
	public static decimal ToDecimal(byte value)
	{
		return default(decimal);
	}

	/// <summary>Converts the value of the specified 16-bit signed integer to an equivalent decimal number.</summary>
	/// <param name="value">The 16-bit signed integer to convert.</param>
	/// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
	public static decimal ToDecimal(short value)
	{
		return default(decimal);
	}

	/// <summary>Converts the value of the specified 16-bit unsigned integer to an equivalent decimal number.</summary>
	/// <param name="value">The 16-bit unsigned integer to convert.</param>
	/// <returns>The decimal number that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static decimal ToDecimal(ushort value)
	{
		return default(decimal);
	}

	/// <summary>Converts the value of the specified 32-bit signed integer to an equivalent decimal number.</summary>
	/// <param name="value">The 32-bit signed integer to convert.</param>
	/// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
	public static decimal ToDecimal(int value)
	{
		return default(decimal);
	}

	/// <summary>Converts the value of the specified 32-bit unsigned integer to an equivalent decimal number.</summary>
	/// <param name="value">The 32-bit unsigned integer to convert.</param>
	/// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static decimal ToDecimal(uint value)
	{
		return default(decimal);
	}

	/// <summary>Converts the value of the specified 64-bit signed integer to an equivalent decimal number.</summary>
	/// <param name="value">The 64-bit signed integer to convert.</param>
	/// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
	public static decimal ToDecimal(long value)
	{
		return default(decimal);
	}

	/// <summary>Converts the value of the specified 64-bit unsigned integer to an equivalent decimal number.</summary>
	/// <param name="value">The 64-bit unsigned integer to convert.</param>
	/// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
	[CLSCompliant(false)]
	public static decimal ToDecimal(ulong value)
	{
		return default(decimal);
	}

	/// <summary>Converts the value of the specified single-precision floating-point number to the equivalent decimal number.</summary>
	/// <param name="value">The single-precision floating-point number to convert.</param>
	/// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />.</exception>
	public static decimal ToDecimal(float value)
	{
		return default(decimal);
	}

	/// <summary>Converts the value of the specified double-precision floating-point number to an equivalent decimal number.</summary>
	/// <param name="value">The double-precision floating-point number to convert.</param>
	/// <returns>A decimal number that is equivalent to <paramref name="value" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />.</exception>
	public static decimal ToDecimal(double value)
	{
		return default(decimal);
	}

	/// <summary>Converts the specified string representation of a number to an equivalent decimal number, using the specified culture-specific formatting information.</summary>
	/// <param name="value">A string that contains a number to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A decimal number that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not a number in a valid format.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> represents a number that is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.</exception>
	public static decimal ToDecimal(string value, IFormatProvider provider)
	{
		return default(decimal);
	}

	/// <summary>Converts the specified Boolean value to the equivalent decimal number.</summary>
	/// <param name="value">The Boolean value to convert.</param>
	/// <returns>The number 1 if <paramref name="value" /> is <see langword="true" />; otherwise, 0.</returns>
	public static decimal ToDecimal(bool value)
	{
		return default(decimal);
	}

	/// <summary>Converts the value of the specified object to a <see cref="T:System.DateTime" /> object, using the specified culture-specific formatting information.</summary>
	/// <param name="value">An object that implements the <see cref="T:System.IConvertible" /> interface.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The date and time equivalent of the value of <paramref name="value" />, or the date and time equivalent of <see cref="F:System.DateTime.MinValue" /> if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not a valid date and time value.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IConvertible" /> interface.  
	/// -or-  
	/// The conversion is not supported.</exception>
	public static DateTime ToDateTime(object value, IFormatProvider provider)
	{
		return default(DateTime);
	}

	/// <summary>Converts the specified string representation of a number to an equivalent date and time, using the specified culture-specific formatting information.</summary>
	/// <param name="value">A string that contains a date and time to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The date and time equivalent of the value of <paramref name="value" />, or the date and time equivalent of <see cref="F:System.DateTime.MinValue" /> if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not a properly formatted date and time string.</exception>
	public static DateTime ToDateTime(string value, IFormatProvider provider)
	{
		return default(DateTime);
	}

	/// <summary>Converts the value of the specified object to its equivalent string representation using the specified culture-specific formatting information.</summary>
	/// <param name="value">An object that supplies the value to convert, or <see langword="null" />.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The string representation of <paramref name="value" />, or <see cref="F:System.String.Empty" /> if <paramref name="value" /> is an object whose value is <see langword="null" />. If <paramref name="value" /> is <see langword="null" />, the method returns <see langword="null" />.</returns>
	public static string ToString(object value, IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Converts the value of the specified Unicode character to its equivalent string representation, using the specified culture-specific formatting information.</summary>
	/// <param name="value">The Unicode character to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information. This parameter is ignored.</param>
	/// <returns>The string representation of <paramref name="value" />.</returns>
	public static string ToString(char value, IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Converts the value of the specified 32-bit signed integer to its equivalent string representation, using the specified culture-specific formatting information.</summary>
	/// <param name="value">The 32-bit signed integer to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The string representation of <paramref name="value" />.</returns>
	public static string ToString(int value, IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Converts the string representation of a number in a specified base to an equivalent 8-bit unsigned integer.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16.</param>
	/// <returns>An 8-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="fromBase" /> is not 2, 8, 10, or 16.  
	/// -or-  
	/// <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="value" /> is <see cref="F:System.String.Empty" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" />, which represents a base 10 unsigned number, is prefixed with a negative sign.  
	/// -or-  
	/// <paramref name="value" /> represents a number that is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />.</exception>
	public static byte ToByte(string value, int fromBase)
	{
		return 0;
	}

	/// <summary>Converts the string representation of a number in a specified base to an equivalent 8-bit signed integer.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16.</param>
	/// <returns>An 8-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="fromBase" /> is not 2, 8, 10, or 16.  
	/// -or-  
	/// <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="value" /> is <see cref="F:System.String.Empty" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.  
	/// -or-  
	/// <paramref name="value" /> represents a number that is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static sbyte ToSByte(string value, int fromBase)
	{
		return 0;
	}

	/// <summary>Converts the string representation of a number in a specified base to an equivalent 16-bit signed integer.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16.</param>
	/// <returns>A 16-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="fromBase" /> is not 2, 8, 10, or 16.  
	/// -or-  
	/// <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="value" /> is <see cref="F:System.String.Empty" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.  
	/// -or-  
	/// <paramref name="value" /> represents a number that is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />.</exception>
	public static short ToInt16(string value, int fromBase)
	{
		return 0;
	}

	/// <summary>Converts the string representation of a number in a specified base to an equivalent 16-bit unsigned integer.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16.</param>
	/// <returns>A 16-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="fromBase" /> is not 2, 8, 10, or 16.  
	/// -or-  
	/// <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="value" /> is <see cref="F:System.String.Empty" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign.  
	/// -or-  
	/// <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ushort ToUInt16(string value, int fromBase)
	{
		return 0;
	}

	/// <summary>Converts the string representation of a number in a specified base to an equivalent 32-bit signed integer.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16.</param>
	/// <returns>A 32-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="fromBase" /> is not 2, 8, 10, or 16.  
	/// -or-  
	/// <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="value" /> is <see cref="F:System.String.Empty" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.  
	/// -or-  
	/// <paramref name="value" /> represents a number that is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	public static int ToInt32(string value, int fromBase)
	{
		return 0;
	}

	/// <summary>Converts the string representation of a number in a specified base to an equivalent 32-bit unsigned integer.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16.</param>
	/// <returns>A 32-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="fromBase" /> is not 2, 8, 10, or 16.  
	/// -or-  
	/// <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="value" /> is <see cref="F:System.String.Empty" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign.  
	/// -or-  
	/// <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static uint ToUInt32(string value, int fromBase)
	{
		return 0u;
	}

	/// <summary>Converts the string representation of a number in a specified base to an equivalent 64-bit signed integer.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16.</param>
	/// <returns>A 64-bit signed integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="fromBase" /> is not 2, 8, 10, or 16.  
	/// -or-  
	/// <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="value" /> is <see cref="F:System.String.Empty" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" />, which represents a non-base 10 signed number, is prefixed with a negative sign.  
	/// -or-  
	/// <paramref name="value" /> represents a number that is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />.</exception>
	public static long ToInt64(string value, int fromBase)
	{
		return 0L;
	}

	/// <summary>Converts the string representation of a number in a specified base to an equivalent 64-bit unsigned integer.</summary>
	/// <param name="value">A string that contains the number to convert.</param>
	/// <param name="fromBase">The base of the number in <paramref name="value" />, which must be 2, 8, 10, or 16.</param>
	/// <returns>A 64-bit unsigned integer that is equivalent to the number in <paramref name="value" />, or 0 (zero) if <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="fromBase" /> is not 2, 8, 10, or 16.  
	/// -or-  
	/// <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="value" /> is <see cref="F:System.String.Empty" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> contains a character that is not a valid digit in the base specified by <paramref name="fromBase" />. The exception message indicates that there are no digits to convert if the first character in <paramref name="value" /> is invalid; otherwise, the message indicates that <paramref name="value" /> contains invalid trailing characters.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" />, which represents a non-base 10 unsigned number, is prefixed with a negative sign.  
	/// -or-  
	/// <paramref name="value" /> represents a number that is less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
	[CLSCompliant(false)]
	public static ulong ToUInt64(string value, int fromBase)
	{
		return 0uL;
	}

	/// <summary>Converts the value of an 8-bit unsigned integer to its equivalent string representation in a specified base.</summary>
	/// <param name="value">The 8-bit unsigned integer to convert.</param>
	/// <param name="toBase">The base of the return value, which must be 2, 8, 10, or 16.</param>
	/// <returns>The string representation of <paramref name="value" /> in base <paramref name="toBase" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="toBase" /> is not 2, 8, 10, or 16.</exception>
	public static string ToString(byte value, int toBase)
	{
		return null;
	}

	/// <summary>Converts the value of a 32-bit signed integer to its equivalent string representation in a specified base.</summary>
	/// <param name="value">The 32-bit signed integer to convert.</param>
	/// <param name="toBase">The base of the return value, which must be 2, 8, 10, or 16.</param>
	/// <returns>The string representation of <paramref name="value" /> in base <paramref name="toBase" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="toBase" /> is not 2, 8, 10, or 16.</exception>
	public static string ToString(int value, int toBase)
	{
		return null;
	}

	/// <summary>Converts the value of a 64-bit signed integer to its equivalent string representation in a specified base.</summary>
	/// <param name="value">The 64-bit signed integer to convert.</param>
	/// <param name="toBase">The base of the return value, which must be 2, 8, 10, or 16.</param>
	/// <returns>The string representation of <paramref name="value" /> in base <paramref name="toBase" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="toBase" /> is not 2, 8, 10, or 16.</exception>
	public static string ToString(long value, int toBase)
	{
		return null;
	}

	/// <summary>Converts an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits.</summary>
	/// <param name="inArray">An array of 8-bit unsigned integers.</param>
	/// <returns>The string representation, in base 64, of the contents of <paramref name="inArray" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="inArray" /> is <see langword="null" />.</exception>
	public static string ToBase64String(byte[] inArray)
	{
		return null;
	}

	/// <summary>Converts a subset of an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits. Parameters specify the subset as an offset in the input array, and the number of elements in the array to convert.</summary>
	/// <param name="inArray">An array of 8-bit unsigned integers.</param>
	/// <param name="offset">An offset in <paramref name="inArray" />.</param>
	/// <param name="length">The number of elements of <paramref name="inArray" /> to convert.</param>
	/// <returns>The string representation in base 64 of <paramref name="length" /> elements of <paramref name="inArray" />, starting at position <paramref name="offset" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="inArray" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="length" /> is negative.  
	/// -or-  
	/// <paramref name="offset" /> plus <paramref name="length" /> is greater than the length of <paramref name="inArray" />.</exception>
	public static string ToBase64String(byte[] inArray, int offset, int length)
	{
		return null;
	}

	/// <summary>Converts a subset of an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits. Parameters specify the subset as an offset in the input array, the number of elements in the array to convert, and whether to insert line breaks in the return value.</summary>
	/// <param name="inArray">An array of 8-bit unsigned integers.</param>
	/// <param name="offset">An offset in <paramref name="inArray" />.</param>
	/// <param name="length">The number of elements of <paramref name="inArray" /> to convert.</param>
	/// <param name="options">
	///   <see cref="F:System.Base64FormattingOptions.InsertLineBreaks" /> to insert a line break every 76 characters, or <see cref="F:System.Base64FormattingOptions.None" /> to not insert line breaks.</param>
	/// <returns>The string representation in base 64 of <paramref name="length" /> elements of <paramref name="inArray" />, starting at position <paramref name="offset" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="inArray" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="length" /> is negative.  
	/// -or-  
	/// <paramref name="offset" /> plus <paramref name="length" /> is greater than the length of <paramref name="inArray" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="options" /> is not a valid <see cref="T:System.Base64FormattingOptions" /> value.</exception>
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options)
	{
		return null;
	}

	public static string ToBase64String(ReadOnlySpan<byte> bytes, Base64FormattingOptions options = Base64FormattingOptions.None)
	{
		return null;
	}

	/// <summary>Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array encoded with base-64 digits. Parameters specify the subsets as offsets in the input and output arrays, and the number of elements in the input array to convert.</summary>
	/// <param name="inArray">An input array of 8-bit unsigned integers.</param>
	/// <param name="offsetIn">A position within <paramref name="inArray" />.</param>
	/// <param name="length">The number of elements of <paramref name="inArray" /> to convert.</param>
	/// <param name="outArray">An output array of Unicode characters.</param>
	/// <param name="offsetOut">A position within <paramref name="outArray" />.</param>
	/// <returns>A 32-bit signed integer containing the number of bytes in <paramref name="outArray" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="inArray" /> or <paramref name="outArray" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offsetIn" />, <paramref name="offsetOut" />, or <paramref name="length" /> is negative.  
	/// -or-  
	/// <paramref name="offsetIn" /> plus <paramref name="length" /> is greater than the length of <paramref name="inArray" />.  
	/// -or-  
	/// <paramref name="offsetOut" /> plus the number of elements to return is greater than the length of <paramref name="outArray" />.</exception>
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut)
	{
		return 0;
	}

	/// <summary>Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array encoded with base-64 digits. Parameters specify the subsets as offsets in the input and output arrays, the number of elements in the input array to convert, and whether line breaks are inserted in the output array.</summary>
	/// <param name="inArray">An input array of 8-bit unsigned integers.</param>
	/// <param name="offsetIn">A position within <paramref name="inArray" />.</param>
	/// <param name="length">The number of elements of <paramref name="inArray" /> to convert.</param>
	/// <param name="outArray">An output array of Unicode characters.</param>
	/// <param name="offsetOut">A position within <paramref name="outArray" />.</param>
	/// <param name="options">
	///   <see cref="F:System.Base64FormattingOptions.InsertLineBreaks" /> to insert a line break every 76 characters, or <see cref="F:System.Base64FormattingOptions.None" /> to not insert line breaks.</param>
	/// <returns>A 32-bit signed integer containing the number of bytes in <paramref name="outArray" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="inArray" /> or <paramref name="outArray" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offsetIn" />, <paramref name="offsetOut" />, or <paramref name="length" /> is negative.  
	/// -or-  
	/// <paramref name="offsetIn" /> plus <paramref name="length" /> is greater than the length of <paramref name="inArray" />.  
	/// -or-  
	/// <paramref name="offsetOut" /> plus the number of elements to return is greater than the length of <paramref name="outArray" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="options" /> is not a valid <see cref="T:System.Base64FormattingOptions" /> value.</exception>
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options)
	{
		return 0;
	}

	private unsafe static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks)
	{
		return 0;
	}

	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks)
	{
		return 0;
	}

	/// <summary>Converts the specified string, which encodes binary data as base-64 digits, to an equivalent 8-bit unsigned integer array.</summary>
	/// <param name="s">The string to convert.</param>
	/// <returns>An array of 8-bit unsigned integers that is equivalent to <paramref name="s" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">The length of <paramref name="s" />, ignoring white-space characters, is not zero or a multiple of 4.  
	///  -or-  
	///  The format of <paramref name="s" /> is invalid. <paramref name="s" /> contains a non-base-64 character, more than two padding characters, or a non-white space-character among the padding characters.</exception>
	public static byte[] FromBase64String(string s)
	{
		return null;
	}

	public static bool TryFromBase64Chars(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten)
	{
		bytesWritten = default(int);
		return false;
	}

	private static void CopyToTempBufferWithoutWhiteSpace(ReadOnlySpan<char> chars, Span<char> tempBuffer, out int consumed, out int charsWritten)
	{
		consumed = default(int);
		charsWritten = default(int);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool IsSpace(this char c)
	{
		return false;
	}

	/// <summary>Converts a subset of a Unicode character array, which encodes binary data as base-64 digits, to an equivalent 8-bit unsigned integer array. Parameters specify the subset in the input array and the number of elements to convert.</summary>
	/// <param name="inArray">A Unicode character array.</param>
	/// <param name="offset">A position within <paramref name="inArray" />.</param>
	/// <param name="length">The number of elements in <paramref name="inArray" /> to convert.</param>
	/// <returns>An array of 8-bit unsigned integers equivalent to <paramref name="length" /> elements at position <paramref name="offset" /> in <paramref name="inArray" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="inArray" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="length" /> is less than 0.  
	/// -or-  
	/// <paramref name="offset" /> plus <paramref name="length" /> indicates a position not within <paramref name="inArray" />.</exception>
	/// <exception cref="T:System.FormatException">The length of <paramref name="inArray" />, ignoring white-space characters, is not zero or a multiple of 4.  
	///  -or-  
	///  The format of <paramref name="inArray" /> is invalid. <paramref name="inArray" /> contains a non-base-64 character, more than two padding characters, or a non-white-space character among the padding characters.</exception>
	public static byte[] FromBase64CharArray(char[] inArray, int offset, int length)
	{
		return null;
	}

	private unsafe static byte[] FromBase64CharPtr(char* inputPtr, int inputLength)
	{
		return null;
	}

	private unsafe static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength)
	{
		return 0;
	}
}
