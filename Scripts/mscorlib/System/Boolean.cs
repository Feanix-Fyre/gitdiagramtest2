using System.Runtime.Versioning;

namespace System;

/// <summary>Represents a Boolean (<see langword="true" /> or <see langword="false" />) value.</summary>
[Serializable]
public readonly struct Boolean : IComparable, IConvertible, IComparable<bool>, IEquatable<bool>
{
	private readonly bool m_value;

	internal const int True = 1;

	internal const int False = 0;

	internal const string TrueLiteral = "True";

	internal const string FalseLiteral = "False";

	/// <summary>Represents the Boolean value <see langword="true" /> as a string. This field is read-only.</summary>
	public static readonly string TrueString;

	/// <summary>Represents the Boolean value <see langword="false" /> as a string. This field is read-only.</summary>
	public static readonly string FalseString;

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A hash code for the current <see cref="T:System.Boolean" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Converts the value of this instance to its equivalent string representation (either "True" or "False").</summary>
	/// <returns>"True" (the value of the <see cref="F:System.Boolean.TrueString" /> property) if the value of this instance is <see langword="true" />, or "False" (the value of the <see cref="F:System.Boolean.FalseString" /> property) if the value of this instance is <see langword="false" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Converts the value of this instance to its equivalent string representation (either "True" or "False").</summary>
	/// <param name="provider">(Reserved) An <see cref="T:System.IFormatProvider" /> object.</param>
	/// <returns>
	///   <see cref="F:System.Boolean.TrueString" /> if the value of this instance is <see langword="true" />, or <see cref="F:System.Boolean.FalseString" /> if the value of this instance is <see langword="false" />.</returns>
	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
	/// <param name="obj">An object to compare to this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.Boolean" /> and has the same value as this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.Boolean" /> object.</summary>
	/// <param name="obj">A <see cref="T:System.Boolean" /> value to compare to this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> has the same value as this instance; otherwise, <see langword="false" />.</returns>
	[NonVersionable]
	public bool Equals(bool obj)
	{
		return false;
	}

	/// <summary>Compares this instance to a specified object and returns an integer that indicates their relationship to one another.</summary>
	/// <param name="obj">An object to compare to this instance, or <see langword="null" />.</param>
	/// <returns>A signed integer that indicates the relative order of this instance and <paramref name="obj" />.  
	///   Return Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   This instance is <see langword="false" /> and <paramref name="obj" /> is <see langword="true" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="obj" /> are equal (either both are <see langword="true" /> or both are <see langword="false" />).  
	///
	///   Greater than zero  
	///
	///   This instance is <see langword="true" /> and <paramref name="obj" /> is <see langword="false" />.  
	///
	///  -or-  
	///
	///  <paramref name="obj" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="obj" /> is not a <see cref="T:System.Boolean" />.</exception>
	public int CompareTo(object obj)
	{
		return 0;
	}

	/// <summary>Compares this instance to a specified <see cref="T:System.Boolean" /> object and returns an integer that indicates their relationship to one another.</summary>
	/// <param name="value">A <see cref="T:System.Boolean" /> object to compare to this instance.</param>
	/// <returns>A signed integer that indicates the relative values of this instance and <paramref name="value" />.  
	///   Return Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   This instance is <see langword="false" /> and <paramref name="value" /> is <see langword="true" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="value" /> are equal (either both are <see langword="true" /> or both are <see langword="false" />).  
	///
	///   Greater than zero  
	///
	///   This instance is <see langword="true" /> and <paramref name="value" /> is <see langword="false" />.</returns>
	public int CompareTo(bool value)
	{
		return 0;
	}

	/// <summary>Converts the specified string representation of a logical value to its <see cref="T:System.Boolean" /> equivalent.</summary>
	/// <param name="value">A string containing the value to convert.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is equivalent to <see cref="F:System.Boolean.TrueString" />; <see langword="false" /> if <paramref name="value" /> is equivalent to <see cref="F:System.Boolean.FalseString" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="value" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="value" /> is not equivalent to <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" />.</exception>
	public static bool Parse(string value)
	{
		return false;
	}

	public static bool Parse(ReadOnlySpan<char> value)
	{
		return false;
	}

	/// <summary>Tries to convert the specified string representation of a logical value to its <see cref="T:System.Boolean" /> equivalent. A return value indicates whether the conversion succeeded or failed.</summary>
	/// <param name="value">A string containing the value to convert.</param>
	/// <param name="result">When this method returns, if the conversion succeeded, contains <see langword="true" /> if <paramref name="value" /> is equal to <see cref="F:System.Boolean.TrueString" /> or <see langword="false" /> if <paramref name="value" /> is equal to <see cref="F:System.Boolean.FalseString" />. If the conversion failed, contains <see langword="false" />. The conversion fails if <paramref name="value" /> is <see langword="null" /> or is not equal to the value of either the <see cref="F:System.Boolean.TrueString" /> or <see cref="F:System.Boolean.FalseString" /> field.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> was converted successfully; otherwise, <see langword="false" />.</returns>
	public static bool TryParse(string value, out bool result)
	{
		result = default(bool);
		return false;
	}

	public static bool TryParse(ReadOnlySpan<char> value, out bool result)
	{
		result = default(bool);
		return false;
	}

	private static ReadOnlySpan<char> TrimWhiteSpaceAndNull(ReadOnlySpan<char> value)
	{
		return default(ReadOnlySpan<char>);
	}

	/// <summary>Returns the type code for the <see cref="T:System.Boolean" /> value type.</summary>
	/// <returns>The enumerated constant <see cref="F:System.TypeCode.Boolean" />.</returns>
	public TypeCode GetTypeCode()
	{
		return default(TypeCode);
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>
	///   <see langword="true" /> or <see langword="false" />.</returns>
	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return false;
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>This conversion is not supported. No value is returned.</returns>
	/// <exception cref="T:System.InvalidCastException">You attempt to convert a <see cref="T:System.Boolean" /> value to a <see cref="T:System.Char" /> value. This conversion is not supported.</exception>
	char IConvertible.ToChar(IFormatProvider provider)
	{
		return '\0';
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>1 if the value of this instance is <see langword="true" />; otherwise, 0.</returns>
	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return 0u;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return 0L;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return 0uL;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return 0f;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return 0.0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>1 if this instance is <see langword="true" />; otherwise, 0.</returns>
	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return default(decimal);
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">This parameter is ignored.</param>
	/// <returns>This conversion is not supported. No value is returned.</returns>
	/// <exception cref="T:System.InvalidCastException">You attempt to convert a <see cref="T:System.Boolean" /> value to a <see cref="T:System.DateTime" /> value. This conversion is not supported.</exception>
	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		return default(DateTime);
	}

	/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
	/// <param name="type">The desired type.</param>
	/// <param name="provider">An <see cref="T:System.IFormatProvider" /> implementation that supplies culture-specific information about the format of the returned value.</param>
	/// <returns>An object of the specified type, with a value that is equivalent to the value of this <see langword="Boolean" /> object.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The requested type conversion is not supported.</exception>
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return null;
	}
}
