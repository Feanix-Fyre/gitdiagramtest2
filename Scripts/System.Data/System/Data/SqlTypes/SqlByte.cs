using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes;

/// <summary>Represents an 8-bit unsigned integer, in the range of 0 through 255, to be stored in or retrieved from a database.</summary>
[Serializable]
[XmlSchemaProvider("GetXsdType")]
public struct SqlByte : INullable, IComparable, IXmlSerializable
{
	private bool m_fNotNull;

	private byte m_value;

	private static readonly int s_iBitNotByteMax;

	/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</summary>
	public static readonly SqlByte Null;

	/// <summary>Represents a zero value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</summary>
	public static readonly SqlByte Zero;

	/// <summary>A constant representing the smallest possible value of a <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
	public static readonly SqlByte MinValue;

	/// <summary>A constant representing the largest possible value of a <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
	public static readonly SqlByte MaxValue;

	/// <summary>Gets a Boolean value that indicates whether this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure is null.</summary>
	/// <returns>
	///   <see langword="true" /> if null. Otherwise, <see langword="false" />.</returns>
	public bool IsNull => false;

	/// <summary>Gets the value of the <see cref="T:System.Data.SqlTypes.SqlByte" /> structure. This property is read-only</summary>
	/// <returns>The value of the <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</returns>
	public byte Value => 0;

	private SqlByte(bool fNull)
	{
		m_fNotNull = false;
		m_value = 0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlByte" /> structure using the specified byte value.</summary>
	/// <param name="value">A byte value to be stored in the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property of the new <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	public SqlByte(byte value)
	{
		m_fNotNull = false;
		m_value = 0;
	}

	/// <summary>Converts the supplied byte value to a <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
	/// <param name="x">A byte value to be converted to <see cref="T:System.Data.SqlTypes.SqlByte" />.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property is equal to the supplied parameter.</returns>
	public static implicit operator SqlByte(byte x)
	{
		return default(SqlByte);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to a <see cref="T:System.String" />.</summary>
	/// <returns>A string that contains the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlByte" />. If the <see langword="Value" /> is null, the <see langword="String" /> will be a null string.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Computes the sum of the two specified <see cref="T:System.Data.SqlTypes.SqlByte" /> structures.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property contains the sum of the two operands.</returns>
	public static SqlByte operator +(SqlByte x, SqlByte y)
	{
		return default(SqlByte);
	}

	/// <summary>Subtracts the second <see cref="T:System.Data.SqlTypes.SqlByte" /> operand from the first.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <returns>The results of subtracting the second <see cref="T:System.Data.SqlTypes.SqlByte" /> operand from the first.</returns>
	public static SqlByte operator -(SqlByte x, SqlByte y)
	{
		return default(SqlByte);
	}

	/// <summary>Computes the product of the two <see cref="T:System.Data.SqlTypes.SqlByte" /> operands.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property contains the product of the multiplication.</returns>
	public static SqlByte operator *(SqlByte x, SqlByte y)
	{
		return default(SqlByte);
	}

	/// <summary>Divides its first <see cref="T:System.Data.SqlTypes.SqlByte" /> operand by its second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property contains the results of the division.</returns>
	public static SqlByte operator /(SqlByte x, SqlByte y)
	{
		return default(SqlByte);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt64" /> to <see cref="T:System.Data.SqlTypes.SqlByte" />.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure whose <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> of the <see langword="SqlInt64" /> parameter.</returns>
	public static explicit operator SqlByte(SqlInt64 x)
	{
		return default(SqlByte);
	}

	/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlByte" /> structures to determine whether they are equal.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator ==(SqlByte x, SqlByte y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlByte" /> to determine whether the first is less than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator <(SqlByte x, SqlByte y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlByte" /> to determine whether the first is greater than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator >(SqlByte x, SqlByte y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlByte" /> to determine whether the first is less than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean LessThan(SqlByte x, SqlByte y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlByte" /> to determine whether the first is greater than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlByte" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
	/// <returns>A <see langword="SqlDouble" /> structure with the same value as this <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
	public SqlDouble ToSqlDouble()
	{
		return default(SqlDouble);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to <see cref="T:System.Data.SqlTypes.SqlInt64" />.</summary>
	/// <returns>A <see langword="SqlInt64" /> structure who <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> equals the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> of this <see cref="T:System.Data.SqlTypes.SqlByte" />.</returns>
	public SqlInt64 ToSqlInt64()
	{
		return default(SqlInt64);
	}

	/// <summary>Compares this instance to the supplied <see cref="T:System.Object" /> and returns an indication of their relative values.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to be compared.</param>
	/// <returns>A signed number that indicates the relative values of the instance and the object.  
	///   Return Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   This instance is less than the object.  
	///
	///   Zero  
	///
	///   This instance is the same as the object.  
	///
	///   Greater than zero  
	///
	///   This instance is greater than the object  
	///
	///  -or-  
	///
	///  The object is a null reference (<see langword="Nothing" /> in Visual Basic)</returns>
	public int CompareTo(object value)
	{
		return 0;
	}

	/// <summary>Compares this instance to the supplied <see cref="T:System.Data.SqlTypes.SqlByte" /> object and returns an indication of their relative values.</summary>
	/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlByte" /> object to be compared.</param>
	/// <returns>A signed number that indicates the relative values of the instance and the object.  
	///   Return Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   This instance is less than the object.  
	///
	///   Zero  
	///
	///   This instance is the same as the object.  
	///
	///   Greater than zero  
	///
	///   This instance is greater than the object  
	///
	///  -or-  
	///
	///  The object is a null reference (<see langword="Nothing" /> in Visual Basic)</returns>
	public int CompareTo(SqlByte value)
	{
		return 0;
	}

	/// <summary>Compares the supplied <see cref="T:System.Object" /> parameter to the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlByte" /> object.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to be compared.</param>
	/// <returns>
	///   <see langword="true" /> if object is an instance of <see cref="T:System.Data.SqlTypes.SqlByte" /> and the two are equal; otherwise <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <returns>An <see langword="XmlSchema" />.</returns>
	XmlSchema IXmlSerializable.GetSchema()
	{
		return null;
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <param name="reader">
	///   <see langword="XmlReader" />
	/// </param>
	void IXmlSerializable.ReadXml(XmlReader reader)
	{
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <param name="writer">
	///   <see langword="XmlWriter" />
	/// </param>
	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
	}

	/// <summary>Returns the XML Schema definition language (XSD) of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <param name="schemaSet">A <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
	/// <returns>A <see langword="string" /> value that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
	{
		return null;
	}
}
