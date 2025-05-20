using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes;

/// <summary>Represents a GUID to be stored in or retrieved from a database.</summary>
[Serializable]
[XmlSchemaProvider("GetXsdType")]
public struct SqlGuid : INullable, IComparable, IXmlSerializable
{
	private static readonly int s_sizeOfGuid;

	private static readonly int[] s_rgiGuidOrder;

	private byte[] m_value;

	/// <summary>Represents a <see cref="T:System.DBNull" /> that can be assigned to this instance of the <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure.</summary>
	public static readonly SqlGuid Null;

	/// <summary>Gets a Boolean value that indicates whether this <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure is null.</summary>
	/// <returns>
	///   <see langword="true" /> if <see langword="null" />. Otherwise, <see langword="false" />.</returns>
	public bool IsNull => false;

	/// <summary>Gets the value of the <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure. This property is read-only.</summary>
	/// <returns>A <see cref="T:System.Guid" /> structure.</returns>
	public Guid Value => default(Guid);

	private SqlGuid(bool fNull)
	{
		m_value = null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure using the specified <see cref="T:System.Guid" /> parameter.</summary>
	/// <param name="g">A <see cref="T:System.Guid" /></param>
	public SqlGuid(Guid g)
	{
		m_value = null;
	}

	/// <summary>Converts the supplied <see cref="T:System.Guid" /> parameter to <see cref="T:System.Data.SqlTypes.SqlGuid" />.</summary>
	/// <param name="x">A <see cref="T:System.Guid" />.</param>
	/// <returns>A new <see cref="T:System.Data.SqlTypes.SqlGuid" /> whose <see cref="P:System.Data.SqlTypes.SqlGuid.Value" /> is equal to the <see cref="T:System.Guid" /> parameter.</returns>
	public static implicit operator SqlGuid(Guid x)
	{
		return default(SqlGuid);
	}

	/// <summary>Converts this <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure to a <see cref="T:System.String" />.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the string representation of the <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure.</returns>
	public override string ToString()
	{
		return null;
	}

	private static EComparison Compare(SqlGuid x, SqlGuid y)
	{
		return default(EComparison);
	}

	/// <summary>Performs a logical comparison of two <see cref="T:System.Data.SqlTypes.SqlGuid" /> structures to determine whether they are equal.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the two instances are equal or <see cref="F:System.Data.SqlTypes.SqlBoolean.False" /> if the two instances are not equal. If either instance of <see cref="T:System.Data.SqlTypes.SqlGuid" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator ==(SqlGuid x, SqlGuid y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlGuid" /> to determine whether the first is less than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is less than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlGuid" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator <(SqlGuid x, SqlGuid y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares two instances of <see cref="T:System.Data.SqlTypes.SqlGuid" /> to determine whether the first is greater than the second.</summary>
	/// <param name="x">A <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure.</param>
	/// <param name="y">A <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure.</param>
	/// <returns>A <see cref="T:System.Data.SqlTypes.SqlBoolean" /> that is <see cref="F:System.Data.SqlTypes.SqlBoolean.True" /> if the first instance is greater than the second instance. Otherwise, <see cref="F:System.Data.SqlTypes.SqlBoolean.False" />. If either instance of <see cref="T:System.Data.SqlTypes.SqlGuid" /> is null, the <see cref="P:System.Data.SqlTypes.SqlBoolean.Value" /> of the <see cref="T:System.Data.SqlTypes.SqlBoolean" /> will be <see cref="F:System.Data.SqlTypes.SqlBoolean.Null" />.</returns>
	public static SqlBoolean operator >(SqlGuid x, SqlGuid y)
	{
		return default(SqlBoolean);
	}

	/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure to the supplied object and returns an indication of their relative values. Compares more than the last 6 bytes, but treats the last 6 bytes as the most significant ones in comparisons.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to be compared.</param>
	/// <returns>A signed number that indicates the relative values of the instance and the object.  
	///   Return Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   This instance is less than object.  
	///
	///   Zero  
	///
	///   This instance is the same as object.  
	///
	///   Greater than zero  
	///
	///   This instance is greater than object  
	///
	///  -or-  
	///
	///  object is a null reference (<see langword="Nothing" />)</returns>
	public int CompareTo(object value)
	{
		return 0;
	}

	/// <summary>Compares this <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure to the supplied <see cref="T:System.Data.SqlTypes.SqlGuid" /> and returns an indication of their relative values. Compares more than the last 6 bytes, but treats the last 6 bytes as the most significant ones in comparisons.</summary>
	/// <param name="value">The <see cref="T:System.Data.SqlTypes.SqlGuid" /> to be compared.</param>
	/// <returns>A signed number that indicates the relative values of the instance and the object.  
	///   Return Value  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///   This instance is less than object.  
	///
	///   Zero  
	///
	///   This instance is the same as object.  
	///
	///   Greater than zero  
	///
	///   This instance is greater than object  
	///
	///  -or-  
	///
	///  object is a null reference (<see langword="Nothing" />).</returns>
	public int CompareTo(SqlGuid value)
	{
		return 0;
	}

	/// <summary>Compares the supplied object parameter to the <see cref="P:System.Data.SqlTypes.SqlGuid.Value" /> property of the <see cref="T:System.Data.SqlTypes.SqlGuid" /> object.</summary>
	/// <param name="value">The object to be compared.</param>
	/// <returns>
	///   <see langword="true" /> if object is an instance of <see cref="T:System.Data.SqlTypes.SqlGuid" /> and the two are equal; otherwise <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Returns the hash code of this <see cref="T:System.Data.SqlTypes.SqlGuid" /> structure.</summary>
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
