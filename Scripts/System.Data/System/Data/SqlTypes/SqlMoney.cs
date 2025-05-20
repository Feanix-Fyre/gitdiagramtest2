using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes;

/// <summary>Represents a currency value ranging from -2 63 (or -922,337,203,685,477.5808) to 2 63 -1 (or +922,337,203,685,477.5807) with an accuracy to a ten-thousandth of currency unit to be stored in or retrieved from a database.</summary>
[Serializable]
[XmlSchemaProvider("GetXsdType")]
public struct SqlMoney : INullable, IComparable, IXmlSerializable
{
	private bool _fNotNull;

	private long _value;

	internal static readonly int s_iMoneyScale;

	private static readonly long s_lTickBase;

	private static readonly double s_dTickBase;

	private static readonly long s_minLong;

	private static readonly long s_maxLong;

	/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> class.</summary>
	public static readonly SqlMoney Null;

	/// <summary>Represents the zero value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> class.</summary>
	public static readonly SqlMoney Zero;

	/// <summary>Represents the minimum value that can be assigned to <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> class.</summary>
	public static readonly SqlMoney MinValue;

	/// <summary>Represents the maximum value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> class.</summary>
	public static readonly SqlMoney MaxValue;

	/// <summary>Returns a Boolean value that indicates whether this <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure is null.</summary>
	/// <returns>
	///   <see langword="true" /> if null. Otherwise, <see langword="false" />.</returns>
	public bool IsNull => false;

	/// <summary>Gets the monetary value of an instance of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure. This property is read-only.</summary>
	/// <returns>The monetary value of an instance of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</returns>
	/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">The property is set to null.</exception>
	public decimal Value => default(decimal);

	private SqlMoney(bool fNull)
	{
		_fNotNull = false;
		_value = 0L;
	}

	internal SqlMoney(long value, int ignored)
	{
		_fNotNull = false;
		_value = 0L;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> class with the specified integer value.</summary>
	/// <param name="value">The monetary value to initialize.</param>
	public SqlMoney(int value)
	{
		_fNotNull = false;
		_value = 0L;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> class with the specified long integer value.</summary>
	/// <param name="value">The monetary value to initialize.</param>
	public SqlMoney(long value)
	{
		_fNotNull = false;
		_value = 0L;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> class with the specified <see cref="T:System.Decimal" /> value.</summary>
	/// <param name="value">The monetary value to initialize.</param>
	public SqlMoney(decimal value)
	{
		_fNotNull = false;
		_value = 0L;
	}

	/// <summary>Converts the Value of this instance of <see cref="T:System.Data.SqlTypes.SqlMoney" /> as a <see cref="T:System.Decimal" /> structure.</summary>
	/// <returns>A <see cref="T:System.Decimal" /> structure whose value equals the <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> property of this <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</returns>
	public decimal ToDecimal()
	{
		return default(decimal);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure to a <see cref="T:System.Double" />.</summary>
	/// <returns>A double with a value equal to this <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</returns>
	public double ToDouble()
	{
		return 0.0;
	}

	/// <summary>Converts the <see cref="T:System.Decimal" /> parameter to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
	/// <param name="x">The <see cref="T:System.Decimal" /> value to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure whose <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> equals the value of the <see cref="T:System.Decimal" /> parameter.</returns>
	public static implicit operator SqlMoney(decimal x)
	{
		return default(SqlMoney);
	}

	/// <summary>This implicit operator converts the supplied <see cref="T:System.Int64" /> parameter to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
	/// <param name="x">The <see cref="T:System.Int64" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure whose <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> property is equal to the value of the <see cref="T:System.Int64" /> parameter.</returns>
	public static implicit operator SqlMoney(long x)
	{
		return default(SqlMoney);
	}

	/// <summary>Converts this instance of <see cref="T:System.Data.SqlTypes.SqlMoney" /> to string.</summary>
	/// <returns>A string whose value is the string representation of the value of this <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>The unary minus operator negates the <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure to be negated.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure whose <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> contains the results of the negation.</returns>
	public static SqlMoney operator -(SqlMoney x)
	{
		return default(SqlMoney);
	}

	/// <summary>Calculates the sum of the two <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameters.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> stucture whose <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> contains the sum of the two <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameters.</returns>
	public static SqlMoney operator +(SqlMoney x, SqlMoney y)
	{
		return default(SqlMoney);
	}

	/// <summary>The subtraction operator subtracts the second <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter from the first.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure that contains the results of the subtraction.</returns>
	public static SqlMoney operator -(SqlMoney x, SqlMoney y)
	{
		return default(SqlMoney);
	}

	/// <summary>The multiplicaion operator calculates the product of the two <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameters.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure whose <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> contains the product of the multiplication.</returns>
	public static SqlMoney operator *(SqlMoney x, SqlMoney y)
	{
		return default(SqlMoney);
	}

	/// <summary>The division operator divides the first <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameter by the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure whose <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> contains the results of the division.</returns>
	public static SqlMoney operator /(SqlMoney x, SqlMoney y)
	{
		return default(SqlMoney);
	}

	/// <summary>This implicit operator converts the supplied <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlByte" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure whose <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> property is equal to the <see cref="P:System.Data.SqlTypes.SqlByte.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlByte" /> parameter.</returns>
	public static implicit operator SqlMoney(SqlByte x)
	{
		return default(SqlMoney);
	}

	/// <summary>This implicit operator converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt16" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure whose <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlInt16.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt16" /> parameter.</returns>
	public static implicit operator SqlMoney(SqlInt16 x)
	{
		return default(SqlMoney);
	}

	/// <summary>This implicit operator converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt32" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure whose <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlInt32.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt32" /> parameter.</returns>
	public static implicit operator SqlMoney(SqlInt32 x)
	{
		return default(SqlMoney);
	}

	/// <summary>This implicit operator converts the supplied <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlInt64" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure whose <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlInt64.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlInt64" /> parameter.</returns>
	public static implicit operator SqlMoney(SqlInt64 x)
	{
		return default(SqlMoney);
	}

	/// <summary>This operator converts the supplied <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter to <see cref="T:System.Data.SqlTypes.SqlMoney" />.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlDecimal" /> structure to be converted.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure whose <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> property equals the <see cref="P:System.Data.SqlTypes.SqlDecimal.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlDecimal" /> parameter.</returns>
	public static explicit operator SqlMoney(SqlDecimal x)
	{
		return default(SqlMoney);
	}

	/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameters to determine whether they are equal.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlMoney" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator ==(SqlMoney x, SqlMoney y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameters to determine whether the first is less than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlMoney" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator <(SqlMoney x, SqlMoney y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameters to determine whether the first is greater than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlMoney" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator >(SqlMoney x, SqlMoney y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameters to determine whether the first is less than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlMoney" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Performs a logical comparison of the two <see cref="T:System.Data.SqlTypes.SqlMoney" /> parameters to determine whether the first is greater than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlMoney" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure to <see cref="T:System.Data.SqlTypes.SqlDouble" />.</summary>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDouble" /> equal to the value of this <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
	public SqlDouble ToSqlDouble()
	{
		return default(SqlDouble);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlMoney" /> structure to <see cref="T:System.Data.SqlTypes.SqlDecimal" />.</summary>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlDecimal" /> equal to the value of this <see cref="T:System.Data.SqlTypes.SqlMoney" />.</returns>
	public SqlDecimal ToSqlDecimal()
	{
		return default(SqlDecimal);
	}

	/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlMoney" /> instance to the supplied <see cref="T:System.Object" /> and returns an indication of their relative values.</summary>
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

	/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlMoney" /> instance to the supplied <see cref="T:System.Data.SqlTypes.SqlMoney" /> and returns an indication of their relative values.</summary>
	/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlMoney" /> to be compared.</param>
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
	public int CompareTo(SqlMoney value)
	{
		return 0;
	}

	/// <summary>Compares the supplied object parameter to the <see cref="P:System.Data.SqlTypes.SqlMoney.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlMoney" /> object.</summary>
	/// <param name="value">The object to be compared.</param>
	/// <returns>
	///   <see langword="true" /> if the object is an instance of <see cref="T:System.Data.SqlTypes.SqlMoney" /> and the two are equal; otherwise, <see langword="false" />.</returns>
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
	/// <param name="schemaSet">An <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
	/// <returns>A <see langword="string" /> that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
	{
		return null;
	}
}
