using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes;

/// <summary>Represents an integer value that is either 1 or 0 to be stored in or retrieved from a database.</summary>
[Serializable]
[XmlSchemaProvider("GetXsdType")]
public struct SqlBoolean : INullable, IComparable, IXmlSerializable
{
	private byte m_value;

	/// <summary>Represents a true value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
	public static readonly SqlBoolean True;

	/// <summary>Represents a false value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
	public static readonly SqlBoolean False;

	/// <summary>Represents <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
	public static readonly SqlBoolean Null;

	/// <summary>Represents a zero value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
	public static readonly SqlBoolean Zero;

	/// <summary>Represents a one value that can be assigned to the <see cref="P:System.Data.SqlTypes.SqlBoolean.ByteValue" /> property of an instance of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</summary>
	public static readonly SqlBoolean One;

	/// <summary>Indicates whether this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure is null.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure is null; otherwise, <see langword="false" />.</returns>
	public bool IsNull => false;

	/// <summary>Gets the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure's value. This property is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">The property is set to null.</exception>
	public bool Value => false;

	/// <summary>Gets a value that indicates whether the current <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" />.</summary>
	/// <returns>
	///   <see langword="true" /> if <see langword="Value" /> is <see langword="true" />; otherwise, <see langword="false" />.</returns>
	public bool IsTrue => false;

	/// <summary>Indicates whether the current <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> is <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />.</summary>
	/// <returns>
	///   <see langword="true" /> if <see langword="Value" /> is <see langword="False" />; otherwise, <see langword="false" />.</returns>
	public bool IsFalse => false;

	/// <summary>Gets the value of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure as a byte.</summary>
	/// <returns>A byte representing the value of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</returns>
	public byte ByteValue => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure using the supplied Boolean value.</summary>
	/// <param name="value">The value for the new <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure; either <see langword="true" /> or <see langword="false" />.</param>
	public SqlBoolean(bool value)
	{
		m_value = 0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure using the specified integer value.</summary>
	/// <param name="value">The integer whose value is to be used for the new <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
	public SqlBoolean(int value)
	{
		m_value = 0;
	}

	private SqlBoolean(int value, bool fNull)
	{
		m_value = 0;
	}

	/// <summary>Converts the supplied byte value to a <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
	/// <param name="x">A byte value to be converted to <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> value that contains 0 or 1.</returns>
	public static implicit operator SqlBoolean(bool x)
	{
		return default(SqlBoolean);
	}

	/// <summary>The true operator can be used to test the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> to determine whether it is true.</summary>
	/// <param name="x">The <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to be tested.</param>
	/// <returns>
	///   <see langword="true" /> if the supplied parameter is <see cref="T:System.Data.SqlTypes.SqlBoolean" /> is <see langword="true" />; otherwise, <see langword="false" />.</returns>
	public static bool operator true(SqlBoolean x)
	{
		return false;
	}

	/// <summary>Computes the bitwise AND operation of two specified <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structures.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
	/// <returns>The result of the logical AND operation.</returns>
	public static SqlBoolean operator &(SqlBoolean x, SqlBoolean y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Computes the bitwise OR of its operands.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
	/// <returns>The results of the logical OR operation.</returns>
	public static SqlBoolean operator |(SqlBoolean x, SqlBoolean y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to a string.</summary>
	/// <returns>A string that contains the value of the <see cref="T:System.Data.SqlTypes.SqlBoolean" />. If the value is null, the string will contain "null".</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> for equality.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</param>
	/// <returns>
	///   <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator ==(SqlBoolean x, SqlBoolean y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Computes the bitwise AND operation of two specified <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structures.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
	/// <returns>The result of the logical AND operation.</returns>
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Performs a bitwise OR operation on the two specified <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structures.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure whose Value is the result of the bitwise OR operation.</returns>
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> structure to a specified object and returns an indication of their relative values.</summary>
	/// <param name="value">An object to compare, or a null reference (<see langword="Nothing" /> in Visual Basic).</param>
	/// <returns>A signed number that indicates the relative values of the instance and value.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance is less than <paramref name="value" />.  
	///
	///   Zero  
	///
	///   This instance is equal to <paramref name="value" />.  
	///
	///   A positive integer  
	///
	///   This instance is greater than <paramref name="value" />.  
	///
	///  -or-  
	///
	///  <paramref name="value" /> is a null reference (<see langword="Nothing" /> in Visual Basic).</returns>
	public int CompareTo(object value)
	{
		return 0;
	}

	/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlBoolean" /> object to the supplied <see cref="T:System.Data.SqlTypes.SqlBoolean" /> object and returns an indication of their relative values.</summary>
	/// <param name="value">A <see cref="T:System.Data.SqlTypes.SqlBoolean" /><see cref="T:System.Data.SqlTypes.SqlBoolean" /> object to compare, or a null reference (<see langword="Nothing" /> in Visual Basic).</param>
	/// <returns>A signed number that indicates the relative values of the instance and value.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance is less than <paramref name="value" />.  
	///
	///   Zero  
	///
	///   This instance is equal to <paramref name="value" />.  
	///
	///   A positive integer  
	///
	///   This instance is greater than <paramref name="value" />.  
	///
	///  -or-  
	///
	///  <paramref name="value" /> is a null reference (<see langword="Nothing" /> in Visual Basic).</returns>
	public int CompareTo(SqlBoolean value)
	{
		return 0;
	}

	/// <summary>Compares the supplied object parameter to the <see cref="T:System.Data.SqlTypes.SqlBoolean" />.</summary>
	/// <param name="value">The object to be compared.</param>
	/// <returns>
	///   <see langword="true" /> if object is an instance of <see cref="T:System.Data.SqlTypes.SqlBoolean" /> and the two are equal; otherwise, <see langword="false" />.</returns>
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
