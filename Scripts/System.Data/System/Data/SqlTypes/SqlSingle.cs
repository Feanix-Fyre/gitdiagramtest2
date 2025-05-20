using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes;

/// <summary>Represents a floating point number within the range of -3.40E +38 through 3.40E +38 to be stored in or retrieved from a database.</summary>
[Serializable]
[XmlSchemaProvider("GetXsdType")]
public struct SqlSingle : INullable, IComparable, IXmlSerializable
{
	private bool _fNotNull;

	private float _value;

	/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</summary>
	public static readonly SqlSingle Null;

	/// <summary>Represents the zero value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> class.</summary>
	public static readonly SqlSingle Zero;

	/// <summary>Represents the minimum value that can be assigned to <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> class.</summary>
	public static readonly SqlSingle MinValue;

	/// <summary>Represents the maximum value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> class.</summary>
	public static readonly SqlSingle MaxValue;

	/// <summary>Indicates whether this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure is null.</summary>
	/// <returns>
	///   <see langword="true" /> if null. Otherwise, <see langword="false" />.</returns>
	public bool IsNull => false;

	/// <summary>Gets the value of this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure. This property is read-only.</summary>
	/// <returns>A floating point value in the range -3.40E+38 through 3.40E+38.</returns>
	public float Value => 0f;

	private SqlSingle(bool fNull)
	{
		_fNotNull = false;
		_value = 0f;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</summary>
	/// <param name="value">A floating point number which will be used as the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> of the new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	public SqlSingle(float value)
	{
		_fNotNull = false;
		_value = 0f;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure using the supplied double parameter.</summary>
	/// <param name="value">A double value which will be used as the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> of the new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	public SqlSingle(double value)
	{
		_fNotNull = false;
		_value = 0f;
	}

	/// <summary>Converts the specified floating point value to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
	/// <param name="x">The float value to be converted to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure that contains the value of the specified float.</returns>
	public static implicit operator SqlSingle(float x)
	{
		return default(SqlSingle);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to <see cref="T:System.String" />.</summary>
	/// <returns>A <see langword="String" /> object representing the value of this <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Negates the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> of the specified <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure that contains the negated value.</returns>
	public static SqlSingle operator -(SqlSingle x)
	{
		return default(SqlSingle);
	}

	/// <summary>Computes the sum of the two specified <see cref="T:System.Data.SqlTypes.SqlSingle" /> structures.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure that contains the sum of the two specified <see cref="T:System.Data.SqlTypes.SqlSingle" /> structures.</returns>
	public static SqlSingle operator +(SqlSingle x, SqlSingle y)
	{
		return default(SqlSingle);
	}

	/// <summary>Subtracts the second <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure from the first.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure that contains the results of the subtraction.</returns>
	public static SqlSingle operator -(SqlSingle x, SqlSingle y)
	{
		return default(SqlSingle);
	}

	/// <summary>Computes the product of the two specified <see cref="T:System.Data.SqlTypes.SqlSingle" /> structures.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure that contains the product of the multiplication.</returns>
	public static SqlSingle operator *(SqlSingle x, SqlSingle y)
	{
		return default(SqlSingle);
	}

	/// <summary>Divides the first <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure by the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure that contains the results of the division.</returns>
	public static SqlSingle operator /(SqlSingle x, SqlSingle y)
	{
		return default(SqlSingle);
	}

	/// <summary>This implicit operator converts the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlByte" /> to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter.</returns>
	public static implicit operator SqlSingle(SqlByte x)
	{
		return default(SqlSingle);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter.</returns>
	public static implicit operator SqlSingle(SqlInt16 x)
	{
		return default(SqlSingle);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter.</returns>
	public static implicit operator SqlSingle(SqlInt32 x)
	{
		return default(SqlSingle);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter.</returns>
	public static implicit operator SqlSingle(SqlInt64 x)
	{
		return default(SqlSingle);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter.</returns>
	public static implicit operator SqlSingle(SqlMoney x)
	{
		return default(SqlSingle);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter.</returns>
	public static implicit operator SqlSingle(SqlDecimal x)
	{
		return default(SqlSingle);
	}

	/// <summary>Converts the supplied <see cref="T:System.Data.SqlTypes.SqlDouble" /> parameter to <see cref="T:System.Data.SqlTypes.SqlSingle" />.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlDouble" /> parameter to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure whose <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> is equal to the <see cref="P:System.Data.SqlTypes.SqlDouble.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlDouble" /> parameter.</returns>
	public static explicit operator SqlSingle(SqlDouble x)
	{
		return default(SqlSingle);
	}

	/// <summary>Performs a logical comparison of the two SqlSingle parameters to determine whether they are equal.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator ==(SqlSingle x, SqlSingle y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameters to determine whether the first is less than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator <(SqlSingle x, SqlSingle y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlSingle" /> operands to determine whether the first is greater than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator >(SqlSingle x, SqlSingle y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlSingle" /> parameters to determine whether the first is less than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlSingle" /> operands to determine whether the first is greater than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlSingle" /> structure to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
	/// <returns>A new <see langword="SqlDouble" /> equal to the value of this <see cref="T:System.Data.SqlTypes.SqlSingle" />.</returns>
	public SqlDouble ToSqlDouble()
	{
		return default(SqlDouble);
	}

	/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlSingle" /> instance to the supplied <see cref="T:System.Object" /> and returns an indication of their relative values.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to be compared.</param>
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
	public int CompareTo(object value)
	{
		return 0;
	}

	/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlSingle" /> instance to the supplied <see cref="T:System.Data.SqlTypes.SqlSingle" /> and returns an indication of their relative values.</summary>
	/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlSingle" /> to be compared.</param>
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
	public int CompareTo(SqlSingle value)
	{
		return 0;
	}

	/// <summary>Compares the supplied object parameter to the <see cref="P:System.Data.SqlTypes.SqlSingle.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlSingle" /> object.</summary>
	/// <param name="value">The object to be compared.</param>
	/// <returns>
	///   <see langword="true" /> if the object is an instance of <see cref="T:System.Data.SqlTypes.SqlSingle" /> and the two are equal. Otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Gets the hash code for this instance.</summary>
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
