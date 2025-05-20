using System.Runtime.InteropServices;

namespace System;

/// <summary>Provides the base class for enumerations.</summary>
[Serializable]
[ComVisible(true)]
public abstract class Enum : ValueType, IComparable, IFormattable, IConvertible
{
	private enum ParseFailureKind
	{
		None = 0,
		Argument = 1,
		ArgumentNull = 2,
		ArgumentWithParameter = 3,
		UnhandledException = 4
	}

	private struct EnumResult
	{
		internal object parsedEnum;

		internal bool canThrow;

		internal ParseFailureKind m_failure;

		internal string m_failureMessageID;

		internal string m_failureParameter;

		internal object m_failureMessageFormatArgument;

		internal Exception m_innerException;

		internal void Init(bool canMethodThrow)
		{
		}

		internal void SetFailure(Exception unhandledException)
		{
		}

		internal void SetFailure(ParseFailureKind failure, string failureParameter)
		{
		}

		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
		{
		}

		internal Exception GetEnumParseException()
		{
			return null;
		}
	}

	private class ValuesAndNames
	{
		public ulong[] Values;

		public string[] Names;

		public ValuesAndNames(ulong[] values, string[] names)
		{
		}
	}

	private static readonly char[] enumSeperatorCharArray;

	private const string enumSeperator = ", ";

	private static ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames)
	{
		return null;
	}

	private static string InternalFormattedHexString(object value)
	{
		return null;
	}

	private static string InternalFormat(RuntimeType eT, object value)
	{
		return null;
	}

	private static string InternalFlagsFormat(RuntimeType eT, object value)
	{
		return null;
	}

	internal static ulong ToUInt64(object value)
	{
		return 0uL;
	}

	private static int InternalCompareTo(object o1, object o2)
	{
		return 0;
	}

	internal static RuntimeType InternalGetUnderlyingType(RuntimeType enumType)
	{
		return null;
	}

	private static bool GetEnumValuesAndNames(RuntimeType enumType, out ulong[] values, out string[] names)
	{
		values = null;
		names = null;
		return false;
	}

	private static object InternalBoxEnum(RuntimeType enumType, long value)
	{
		return null;
	}

	/// <summary>Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object. The return value indicates whether the conversion succeeded.</summary>
	/// <param name="value">The case-sensitive string representation of the enumeration name or underlying value to convert.</param>
	/// <param name="result">When this method returns, <paramref name="result" /> contains an object of type TEnum whose value is represented by <paramref name="value" /> if the parse operation succeeds. If the parse operation fails, <paramref name="result" /> contains the default value of the underlying type of TEnum. Note that this value need not be a member of the TEnum enumeration. This parameter is passed uninitialized.</param>
	/// <typeparam name="TEnum">The enumeration type to which to convert <paramref name="value" />.</typeparam>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="value" /> parameter was converted successfully; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="TEnum" /> is not an enumeration type.</exception>
	public static bool TryParse<TEnum>(string value, out TEnum result) where TEnum : struct
	{
		result = default(TEnum);
		return false;
	}

	/// <summary>Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object. A parameter specifies whether the operation is case-sensitive. The return value indicates whether the conversion succeeded.</summary>
	/// <param name="value">The string representation of the enumeration name or underlying value to convert.</param>
	/// <param name="ignoreCase">
	///   <see langword="true" /> to ignore case; <see langword="false" /> to consider case.</param>
	/// <param name="result">When this method returns, <paramref name="result" /> contains an object of type TEnum whose value is represented by <paramref name="value" /> if the parse operation succeeds. If the parse operation fails, <paramref name="result" /> contains the default value of the underlying type of TEnum. Note that this value need not be a member of the TEnum enumeration. This parameter is passed uninitialized.</param>
	/// <typeparam name="TEnum">The enumeration type to which to convert <paramref name="value" />.</typeparam>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="value" /> parameter was converted successfully; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="TEnum" /> is not an enumeration type.</exception>
	public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct
	{
		result = default(TEnum);
		return false;
	}

	/// <summary>Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object.</summary>
	/// <param name="enumType">An enumeration type.</param>
	/// <param name="value">A string containing the name or value to convert.</param>
	/// <returns>An object of type <paramref name="enumType" /> whose value is represented by <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> or <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.  
	/// -or-  
	/// <paramref name="value" /> is either an empty string or only contains white space.  
	/// -or-  
	/// <paramref name="value" /> is a name, but not one of the named constants defined for the enumeration.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is outside the range of the underlying type of <paramref name="enumType" />.</exception>
	[ComVisible(true)]
	public static object Parse(Type enumType, string value)
	{
		return null;
	}

	/// <summary>Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object. A parameter specifies whether the operation is case-insensitive.</summary>
	/// <param name="enumType">An enumeration type.</param>
	/// <param name="value">A string containing the name or value to convert.</param>
	/// <param name="ignoreCase">
	///   <see langword="true" /> to ignore case; <see langword="false" /> to regard case.</param>
	/// <returns>An object of type <paramref name="enumType" /> whose value is represented by <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> or <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.  
	/// -or-  
	/// <paramref name="value" /> is either an empty string ("") or only contains white space.  
	/// -or-  
	/// <paramref name="value" /> is a name, but not one of the named constants defined for the enumeration.</exception>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> is outside the range of the underlying type of <paramref name="enumType" />.</exception>
	[ComVisible(true)]
	public static object Parse(Type enumType, string value, bool ignoreCase)
	{
		return null;
	}

	private static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref EnumResult parseResult)
	{
		return false;
	}

	/// <summary>Returns the underlying type of the specified enumeration.</summary>
	/// <param name="enumType">The enumeration whose underlying type will be retrieved.</param>
	/// <returns>The underlying type of <paramref name="enumType" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.</exception>
	[ComVisible(true)]
	public static Type GetUnderlyingType(Type enumType)
	{
		return null;
	}

	/// <summary>Retrieves an array of the values of the constants in a specified enumeration.</summary>
	/// <param name="enumType">An enumeration type.</param>
	/// <returns>An array that contains the values of the constants in <paramref name="enumType" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The method is invoked by reflection in a reflection-only context,  
	///  -or-  
	///  <paramref name="enumType" /> is a type from an assembly loaded in a reflection-only context.</exception>
	[ComVisible(true)]
	public static Array GetValues(Type enumType)
	{
		return null;
	}

	internal static ulong[] InternalGetValues(RuntimeType enumType)
	{
		return null;
	}

	/// <summary>Retrieves the name of the constant in the specified enumeration that has the specified value.</summary>
	/// <param name="enumType">An enumeration type.</param>
	/// <param name="value">The value of a particular enumerated constant in terms of its underlying type.</param>
	/// <returns>A string containing the name of the enumerated constant in <paramref name="enumType" /> whose value is <paramref name="value" />; or <see langword="null" /> if no such constant is found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> or <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.  
	/// -or-  
	/// <paramref name="value" /> is neither of type <paramref name="enumType" /> nor does it have the same underlying type as <paramref name="enumType" />.</exception>
	[ComVisible(true)]
	public static string GetName(Type enumType, object value)
	{
		return null;
	}

	/// <summary>Retrieves an array of the names of the constants in a specified enumeration.</summary>
	/// <param name="enumType">An enumeration type.</param>
	/// <returns>A string array of the names of the constants in <paramref name="enumType" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> parameter is not an <see cref="T:System.Enum" />.</exception>
	[ComVisible(true)]
	public static string[] GetNames(Type enumType)
	{
		return null;
	}

	internal static string[] InternalGetNames(RuntimeType enumType)
	{
		return null;
	}

	/// <summary>Converts the specified object with an integer value to an enumeration member.</summary>
	/// <param name="enumType">The enumeration type to return.</param>
	/// <param name="value">The value convert to an enumeration member.</param>
	/// <returns>An enumeration object whose value is <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> or <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.  
	/// -or-  
	/// <paramref name="value" /> is not type <see cref="T:System.SByte" />, <see cref="T:System.Int16" />, <see cref="T:System.Int32" />, <see cref="T:System.Int64" />, <see cref="T:System.Byte" />, <see cref="T:System.UInt16" />, <see cref="T:System.UInt32" />, or <see cref="T:System.UInt64" />.</exception>
	[ComVisible(true)]
	public static object ToObject(Type enumType, object value)
	{
		return null;
	}

	/// <summary>Returns a Boolean telling whether a given integral value, or its name as a string, exists in a specified enumeration.</summary>
	/// <param name="enumType">An enumeration type.</param>
	/// <param name="value">The value or name of a constant in <paramref name="enumType" />.</param>
	/// <returns>
	///   <see langword="true" /> if a constant in <paramref name="enumType" /> has a value equal to <paramref name="value" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> or <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> is not an <see langword="Enum" />.  
	/// -or-  
	/// The type of <paramref name="value" /> is an enumeration, but it is not an enumeration of type <paramref name="enumType" />.  
	/// -or-  
	/// The type of <paramref name="value" /> is not an underlying type of <paramref name="enumType" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="value" /> is not type <see cref="T:System.SByte" />, <see cref="T:System.Int16" />, <see cref="T:System.Int32" />, <see cref="T:System.Int64" />, <see cref="T:System.Byte" />, <see cref="T:System.UInt16" />, <see cref="T:System.UInt32" />, or <see cref="T:System.UInt64" />, or <see cref="T:System.String" />.</exception>
	[ComVisible(true)]
	public static bool IsDefined(Type enumType, object value)
	{
		return false;
	}

	/// <summary>Converts the specified value of a specified enumerated type to its equivalent string representation according to the specified format.</summary>
	/// <param name="enumType">The enumeration type of the value to convert.</param>
	/// <param name="value">The value to convert.</param>
	/// <param name="format">The output format to use.</param>
	/// <returns>A string representation of <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="enumType" />, <paramref name="value" />, or <paramref name="format" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="enumType" /> parameter is not an <see cref="T:System.Enum" /> type.  
	///  -or-  
	///  The <paramref name="value" /> is from an enumeration that differs in type from <paramref name="enumType" />.  
	///  -or-  
	///  The type of <paramref name="value" /> is not an underlying type of <paramref name="enumType" />.</exception>
	/// <exception cref="T:System.FormatException">The <paramref name="format" /> parameter contains an invalid value.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="format" /> equals "X", but the enumeration type is unknown.</exception>
	[ComVisible(true)]
	public static string Format(Type enumType, object value, string format)
	{
		return null;
	}

	private object get_value()
	{
		return null;
	}

	internal object GetValue()
	{
		return null;
	}

	private bool InternalHasFlag(Enum flags)
	{
		return false;
	}

	private int get_hashcode()
	{
		return 0;
	}

	/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
	/// <param name="obj">An object to compare with this instance, or <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is an enumeration value of the same type and with the same underlying value as this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns the hash code for the value of this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Converts the value of this instance to its equivalent string representation.</summary>
	/// <returns>The string representation of the value of this instance.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>This method overload is obsolete; use <see cref="M:System.Enum.ToString(System.String)" />.</summary>
	/// <param name="format">A format specification.</param>
	/// <param name="provider">(Obsolete.)</param>
	/// <returns>The string representation of the value of this instance as specified by <paramref name="format" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> does not contain a valid format specification.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="format" /> equals "X", but the enumeration type is unknown.</exception>
	[Obsolete("The provider argument is not used. Please use ToString(String).")]
	public string ToString(string format, IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Compares this instance to a specified object and returns an indication of their relative values.</summary>
	/// <param name="target">An object to compare, or <see langword="null" />.</param>
	/// <returns>A signed number that indicates the relative values of this instance and <paramref name="target" />.  
	///   Value  
	///
	///   Meaning  
	///
	///   Less than zero  
	///
	///   The value of this instance is less than the value of <paramref name="target" />.  
	///
	///   Zero  
	///
	///   The value of this instance is equal to the value of <paramref name="target" />.  
	///
	///   Greater than zero  
	///
	///   The value of this instance is greater than the value of <paramref name="target" />.  
	///
	///  -or-  
	///
	///  <paramref name="target" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="target" /> and this instance are not the same type.</exception>
	/// <exception cref="T:System.InvalidOperationException">This instance is not type <see cref="T:System.SByte" />, <see cref="T:System.Int16" />, <see cref="T:System.Int32" />, <see cref="T:System.Int64" />, <see cref="T:System.Byte" />, <see cref="T:System.UInt16" />, <see cref="T:System.UInt32" />, or <see cref="T:System.UInt64" />.</exception>
	/// <exception cref="T:System.NullReferenceException">This instance is null.</exception>
	public int CompareTo(object target)
	{
		return 0;
	}

	/// <summary>Converts the value of this instance to its equivalent string representation using the specified format.</summary>
	/// <param name="format">A format string.</param>
	/// <returns>The string representation of the value of this instance as specified by <paramref name="format" />.</returns>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="format" /> contains an invalid specification.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="format" /> equals "X", but the enumeration type is unknown.</exception>
	public string ToString(string format)
	{
		return null;
	}

	/// <summary>This method overload is obsolete; use <see cref="M:System.Enum.ToString" />.</summary>
	/// <param name="provider">(obsolete)</param>
	/// <returns>The string representation of the value of this instance.</returns>
	[Obsolete("The provider argument is not used. Please use ToString().")]
	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Determines whether one or more bit fields are set in the current instance.</summary>
	/// <param name="flag">An enumeration value.</param>
	/// <returns>
	///   <see langword="true" /> if the bit field or bit fields that are set in <paramref name="flag" /> are also set in the current instance; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="flag" /> is a different type than the current instance.</exception>
	public bool HasFlag(Enum flag)
	{
		return false;
	}

	/// <summary>Returns the type code of the underlying type of this enumeration member.</summary>
	/// <returns>The type code of the underlying type of this instance.</returns>
	/// <exception cref="T:System.InvalidOperationException">The enumeration type is unknown.</exception>
	public TypeCode GetTypeCode()
	{
		return default(TypeCode);
	}

	/// <summary>Converts the current value to a Boolean value based on the underlying type.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>This member always throws an exception.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return false;
	}

	/// <summary>Converts the current value to a Unicode character based on the underlying type.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>This member always throws an exception.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	char IConvertible.ToChar(IFormatProvider provider)
	{
		return '\0';
	}

	/// <summary>Converts the current value to an 8-bit signed integer based on the underlying type.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The converted value.</returns>
	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the current value to an 8-bit unsigned integer based on the underlying type.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The converted value.</returns>
	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the current value to a 16-bit signed integer based on the underlying type.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The converted value.</returns>
	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the current value to a 16-bit unsigned integer based on the underlying type.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The converted value.</returns>
	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the current value to a 32-bit signed integer based on the underlying type.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The converted value.</returns>
	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>Converts the current value to a 32-bit unsigned integer based on the underlying type.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The converted value.</returns>
	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return 0u;
	}

	/// <summary>Converts the current value to a 64-bit signed integer based on the underlying type.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The converted value.</returns>
	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return 0L;
	}

	/// <summary>Converts the current value to a 64-bit unsigned integer based on the underlying type.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The converted value.</returns>
	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return 0uL;
	}

	/// <summary>Converts the current value to a single-precision floating-point number based on the underlying type.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>This member always throws an exception.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return 0f;
	}

	/// <summary>Converts the current value to a double-precision floating point number based on the underlying type.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>This member always throws an exception.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return 0.0;
	}

	/// <summary>Converts the current value to a <see cref="T:System.Decimal" /> based on the underlying type.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>This member always throws an exception.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return default(decimal);
	}

	/// <summary>Converts the current value to a <see cref="T:System.DateTime" /> based on the underlying type.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>This member always throws an exception.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		return default(DateTime);
	}

	/// <summary>Converts the current value to a specified type based on the underlying type.</summary>
	/// <param name="type">The type to convert to.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>The converted value.</returns>
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Converts the specified 8-bit signed integer value to an enumeration member.</summary>
	/// <param name="enumType">The enumeration type to return.</param>
	/// <param name="value">The value to convert to an enumeration member.</param>
	/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.</exception>
	[ComVisible(true)]
	[CLSCompliant(false)]
	public static object ToObject(Type enumType, sbyte value)
	{
		return null;
	}

	/// <summary>Converts the specified 16-bit signed integer to an enumeration member.</summary>
	/// <param name="enumType">The enumeration type to return.</param>
	/// <param name="value">The value to convert to an enumeration member.</param>
	/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.</exception>
	[ComVisible(true)]
	public static object ToObject(Type enumType, short value)
	{
		return null;
	}

	/// <summary>Converts the specified 32-bit signed integer to an enumeration member.</summary>
	/// <param name="enumType">The enumeration type to return.</param>
	/// <param name="value">The value to convert to an enumeration member.</param>
	/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.</exception>
	[ComVisible(true)]
	public static object ToObject(Type enumType, int value)
	{
		return null;
	}

	/// <summary>Converts the specified 8-bit unsigned integer to an enumeration member.</summary>
	/// <param name="enumType">The enumeration type to return.</param>
	/// <param name="value">The value to convert to an enumeration member.</param>
	/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.</exception>
	[ComVisible(true)]
	public static object ToObject(Type enumType, byte value)
	{
		return null;
	}

	/// <summary>Converts the specified 16-bit unsigned integer value to an enumeration member.</summary>
	/// <param name="enumType">The enumeration type to return.</param>
	/// <param name="value">The value to convert to an enumeration member.</param>
	/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.</exception>
	[CLSCompliant(false)]
	[ComVisible(true)]
	public static object ToObject(Type enumType, ushort value)
	{
		return null;
	}

	/// <summary>Converts the specified 32-bit unsigned integer value to an enumeration member.</summary>
	/// <param name="enumType">The enumeration type to return.</param>
	/// <param name="value">The value to convert to an enumeration member.</param>
	/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.</exception>
	[CLSCompliant(false)]
	[ComVisible(true)]
	public static object ToObject(Type enumType, uint value)
	{
		return null;
	}

	/// <summary>Converts the specified 64-bit signed integer to an enumeration member.</summary>
	/// <param name="enumType">The enumeration type to return.</param>
	/// <param name="value">The value to convert to an enumeration member.</param>
	/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.</exception>
	[ComVisible(true)]
	public static object ToObject(Type enumType, long value)
	{
		return null;
	}

	/// <summary>Converts the specified 64-bit unsigned integer value to an enumeration member.</summary>
	/// <param name="enumType">The enumeration type to return.</param>
	/// <param name="value">The value to convert to an enumeration member.</param>
	/// <returns>An instance of the enumeration set to <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="enumType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="enumType" /> is not an <see cref="T:System.Enum" />.</exception>
	[CLSCompliant(false)]
	[ComVisible(true)]
	public static object ToObject(Type enumType, ulong value)
	{
		return null;
	}

	private static object ToObject(Type enumType, char value)
	{
		return null;
	}

	private static object ToObject(Type enumType, bool value)
	{
		return null;
	}

	public static TEnum Parse<TEnum>(string value) where TEnum : struct
	{
		return default(TEnum);
	}

	public static TEnum Parse<TEnum>(string value, bool ignoreCase) where TEnum : struct
	{
		return default(TEnum);
	}

	public static bool TryParse(Type enumType, string value, bool ignoreCase, out object result)
	{
		result = null;
		return false;
	}

	public static bool TryParse(Type enumType, string value, out object result)
	{
		result = null;
		return false;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Enum" /> class.</summary>
	protected Enum()
	{
	}
}
