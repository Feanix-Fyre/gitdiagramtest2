using System.Runtime.Serialization;

namespace System;

/// <summary>Represents a nonexistent value. This class cannot be inherited.</summary>
[Serializable]
public sealed class DBNull : ISerializable, IConvertible
{
	/// <summary>Represents the sole instance of the <see cref="T:System.DBNull" /> class.</summary>
	public static readonly DBNull Value;

	private DBNull()
	{
	}

	private DBNull(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and returns the data needed to serialize the <see cref="T:System.DBNull" /> object.</summary>
	/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing information required to serialize the <see cref="T:System.DBNull" /> object.</param>
	/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.DBNull" /> object.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Returns an empty string (<see cref="F:System.String.Empty" />).</summary>
	/// <returns>An empty string (<see cref="F:System.String.Empty" />).</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Returns an empty string using the specified <see cref="T:System.IFormatProvider" />.</summary>
	/// <param name="provider">The <see cref="T:System.IFormatProvider" /> to be used to format the return value.  
	///  -or-  
	///  <see langword="null" /> to obtain the format information from the current locale setting of the operating system.</param>
	/// <returns>An empty string (<see cref="F:System.String.Empty" />).</returns>
	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Gets the <see cref="T:System.TypeCode" /> value for <see cref="T:System.DBNull" />.</summary>
	/// <returns>The <see cref="T:System.TypeCode" /> value for <see cref="T:System.DBNull" />, which is <see cref="F:System.TypeCode.DBNull" />.</returns>
	public TypeCode GetTypeCode()
	{
		return default(TypeCode);
	}

	/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>None. The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return false;
	}

	/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>None. The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
	char IConvertible.ToChar(IFormatProvider provider)
	{
		return '\0';
	}

	/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>None. The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>None. The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>None. The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>None. The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>None. The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>None. The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return 0u;
	}

	/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>None. The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return 0L;
	}

	/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>None. The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return 0uL;
	}

	/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>None. The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return 0f;
	}

	/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>None. The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return 0.0;
	}

	/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>None. The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return default(decimal);
	}

	/// <summary>This conversion is not supported. Attempting to make this conversion throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>None. The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		return default(DateTime);
	}

	/// <summary>Converts the current <see cref="T:System.DBNull" /> object to the specified type.</summary>
	/// <param name="type">The type to convert the current <see cref="T:System.DBNull" /> object to.</param>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface and is used to augment the conversion. If <see langword="null" /> is specified, format information is obtained from the current culture.</param>
	/// <returns>The boxed equivalent of the current <see cref="T:System.DBNull" /> object, if that conversion is supported; otherwise, an exception is thrown and no value is returned.</returns>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DBNull" /> type.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.</exception>
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return null;
	}
}
