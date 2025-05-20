using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes;

/// <summary>Represents a floating-point number within the range of -1.79E +308 through 1.79E +308 to be stored in or retrieved from a database.</summary>
[Serializable]
[XmlSchemaProvider("GetXsdType")]
public struct SqlDouble : INullable, IComparable, IXmlSerializable
{
	private bool m_fNotNull;

	private double m_value;

	/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</summary>
	public static readonly SqlDouble Null;

	/// <summary>Represents a zero value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</summary>
	public static readonly SqlDouble Zero;

	/// <summary>A constant representing the minimum possible value of <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
	public static readonly SqlDouble MinValue;

	/// <summary>A constant representing the maximum value for a <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</summary>
	public static readonly SqlDouble MaxValue;

	/// <summary>Returns a Boolean value that indicates whether this <see cref="T:System.Data.SqlTypes.SqlDouble" /> instance is null.</summary>
	/// <returns>
	///   <see langword="true" /> if <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is null. Otherwise, <see langword="false" />.</returns>
	public bool IsNull => false;

	/// <summary>Gets the value of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure. This property is read-only.</summary>
	/// <returns>The value of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</returns>
	public double Value => 0.0;

	private SqlDouble(bool fNull)
	{
		m_fNotNull = false;
		m_value = 0.0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure using the supplied double parameter to set the new <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure's <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> property.</summary>
	/// <param name="value">A double whose value will be used for the new <see cref="T:System.Data.SqlTypes.SqlDouble" />.</param>
	public SqlDouble(double value)
	{
		m_fNotNull = false;
		m_value = 0.0;
	}

	/// <summary>Converts the supplied double value to a <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
	/// <param name="x">The double value to convert.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDouble" /> with the same value as the specified double parameter.</returns>
	public static implicit operator SqlDouble(double x)
	{
		return default(SqlDouble);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to a string.</summary>
	/// <returns>A string representing the <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> of this <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Returns the negated value of the specified <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure that contains the negated value.</returns>
	public static SqlDouble operator -(SqlDouble x)
	{
		return default(SqlDouble);
	}

	/// <summary>The addition operator computes the sum of the two <see cref="T:System.Data.SqlTypes.SqlDouble" /> operands.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <returns>The sum of the two <see cref="T:System.Data.SqlTypes.SqlDouble" /> operands.</returns>
	public static SqlDouble operator +(SqlDouble x, SqlDouble y)
	{
		return default(SqlDouble);
	}

	/// <summary>The subtraction operator the second <see cref="T:System.Data.SqlTypes.SqlDouble" /> operand from the first.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <returns>The results of the subtraction operation.</returns>
	public static SqlDouble operator -(SqlDouble x, SqlDouble y)
	{
		return default(SqlDouble);
	}

	/// <summary>The multiplication operator computes the product of the two <see cref="T:System.Data.SqlTypes.SqlDouble" /> operands.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <returns>The product of the two <see cref="T:System.Data.SqlTypes.SqlDouble" /> operands.</returns>
	public static SqlDouble operator *(SqlDouble x, SqlDouble y)
	{
		return default(SqlDouble);
	}

	/// <summary>The division operator divides the first <see cref="T:System.Data.SqlTypes.SqlDouble" /> operand by the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure that contains the results of the division operation.</returns>
	public static SqlDouble operator /(SqlDouble x, SqlDouble y)
	{
		return default(SqlDouble);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlByte" /> is <see cref="F:System.Data.SqlTypes.SqlByte.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
	public static implicit operator SqlDouble(SqlByte x)
	{
		return default(SqlDouble);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlInt16" /> is <see cref="F:System.Data.SqlTypes.SqlInt16.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
	public static implicit operator SqlDouble(SqlInt16 x)
	{
		return default(SqlDouble);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlInt32" /> is <see cref="F:System.Data.SqlTypes.SqlInt32.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
	public static implicit operator SqlDouble(SqlInt32 x)
	{
		return default(SqlDouble);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlInt64" /> is <see cref="F:System.Data.SqlTypes.SqlInt64.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
	public static implicit operator SqlDouble(SqlInt64 x)
	{
		return default(SqlDouble);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlSingle" /> is <see cref="F:System.Data.SqlTypes.SqlSingle.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
	public static implicit operator SqlDouble(SqlSingle x)
	{
		return default(SqlDouble);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlMoney" /> is <see cref="F:System.Data.SqlTypes.SqlMoney.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
	public static implicit operator SqlDouble(SqlMoney x)
	{
		return default(SqlDouble);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure whose <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter. If the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> is <see cref="F:System.Data.SqlTypes.SqlDecimal.Null" />, the <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure will be <see cref="F:System.Data.SqlTypes.SqlDouble.Null" />.</returns>
	public static implicit operator SqlDouble(SqlDecimal x)
	{
		return default(SqlDouble);
	}

	/// <summary>Performs a logical comparison on two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether they are equal.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <returns>
	///   <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />.</returns>
	public static SqlBoolean operator ==(SqlDouble x, SqlDouble y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether the first is less than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDouble" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator <(SqlDouble x, SqlDouble y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether the first is greater than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDouble" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator >(SqlDouble x, SqlDouble y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether the first is less than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDouble" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlDouble" /> to determine whether the first is greater than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlDouble" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlDouble" /> structure to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
	/// <returns>A new <see langword="SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> of this <see cref="T:System.Data.SqlTypes.SqlDouble" />.</returns>
	public SqlSingle ToSqlSingle()
	{
		return default(SqlSingle);
	}

	/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlDouble" /> instance to the supplied <see cref="T:System.Object" /> and returns an indication of their relative values.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to compare.</param>
	/// <returns>A signed number that indicates the relative values of the instance and the object.  
	///   Return value  
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
	///  The object is a null reference (<see langword="Nothing" /> in Visual Basic).</returns>
	public int CompareTo(object value)
	{
		return 0;
	}

	/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlDouble" /> instance to the supplied <see cref="T:System.Data.SqlTypes.SqlDouble" /> and returns an indication of their relative values.</summary>
	/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlDouble" /> to be compared.</param>
	/// <returns>A signed number that indicates the relative values of the instance and the object.  
	///   Return value  
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
	public int CompareTo(SqlDouble value)
	{
		return 0;
	}

	/// <summary>Compares the supplied object parameter to the <see cref="P:System.Data.SqlTypes.SqlDateTime.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> object.</summary>
	/// <param name="value">The object to be compared.</param>
	/// <returns>
	///   <see langword="true" /> if the two values are equal. Otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Returns the hash code for this <see cref="T:System.Data.SqlTypes.SqlDouble" /> structre.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <returns>An XML schema consumed by .NET Framework.</returns>
	XmlSchema IXmlSerializable.GetSchema()
	{
		return null;
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <param name="reader">A <see cref="T:System.Xml.XmlReader" />.</param>
	void IXmlSerializable.ReadXml(XmlReader reader)
	{
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <param name="writer">A <see cref="T:System.Xml.XmlWriter" />.</param>
	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
	}

	/// <summary>Returns the XML Schema definition language (XSD) of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <param name="schemaSet">An <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
	/// <returns>A <see langword="string" /> value that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
	{
		return null;
	}
}
