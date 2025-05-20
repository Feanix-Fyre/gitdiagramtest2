using System.Reflection;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes;

/// <summary>
///   <see cref="T:System.Data.SqlTypes.SqlChars" /> is a mutable reference type that wraps a <see cref="T:System.Char" /> array or a <see cref="T:System.Data.SqlTypes.SqlString" /> instance.</summary>
[Serializable]
[DefaultMember("Item")]
[XmlSchemaProvider("GetXsdType")]
public sealed class SqlChars : INullable, IXmlSerializable, ISerializable
{
	internal char[] _rgchBuf;

	private long _lCurLen;

	internal SqlStreamChars _stream;

	private SqlBytesCharsState _state;

	private char[] _rgchWorkBuf;

	/// <summary>Gets a Boolean value that indicates whether this <see cref="T:System.Data.SqlTypes.SqlChars" /> is null.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Data.SqlTypes.SqlChars" /> is null. Otherwise, <see langword="false" />.</returns>
	public bool IsNull => false;

	/// <summary>Returns a reference to the internal buffer.</summary>
	/// <returns>A reference to the internal buffer. For <see cref="T:System.Data.SqlTypes.SqlChars" /> instances created on top of unmanaged pointers, it returns a managed copy of the internal buffer.</returns>
	public char[] Buffer => null;

	/// <summary>Gets the length of the value that is contained in the <see cref="T:System.Data.SqlTypes.SqlChars" /> instance.</summary>
	/// <returns>A <see cref="T:System.Int64" /> value that indicates the length in characters of the value that is contained in the <see cref="T:System.Data.SqlTypes.SqlChars" /> instance.  
	///  Returns -1 if no buffer is available to the instance, or if the value is null.  
	///  Returns a <see cref="P:System.IO.Stream.Length" /> for a stream-wrapped instance.</returns>
	public long Length => 0L;

	/// <summary>Returns a managed copy of the value held by this <see cref="T:System.Data.SqlTypes.SqlChars" />.</summary>
	/// <returns>The value of this <see cref="T:System.Data.SqlTypes.SqlChars" /> as an array of characters.</returns>
	public char[] Value => null;

	/// <summary>Returns a null instance of this <see cref="T:System.Data.SqlTypes.SqlChars" />.</summary>
	/// <returns>An instance whose <see cref="P:System.Data.SqlTypes.SqlChars.IsNull" /> property returns <see langword="true" />. For more information, see Handling Null Values.</returns>
	public static SqlChars Null => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlChars" /> class.</summary>
	public SqlChars()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlChars" /> class based on the specified character array.</summary>
	/// <param name="buffer">A <see cref="T:System.Char" /> array.</param>
	public SqlChars(char[] buffer)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlChars" /> class based on the specified <see cref="T:System.Data.SqlTypes.SqlString" /> value.</summary>
	/// <param name="value">A <see cref="T:System.Data.SqlTypes.SqlString" />.</param>
	public SqlChars(SqlString value)
	{
	}

	/// <summary>Sets this <see cref="T:System.Data.SqlTypes.SqlChars" /> instance to null.</summary>
	public void SetNull()
	{
	}

	internal bool FStream()
	{
		return false;
	}

	private void CopyStreamToBuffer()
	{
	}

	private void SetBuffer(char[] buffer)
	{
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <returns>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</returns>
	XmlSchema IXmlSerializable.GetSchema()
	{
		return null;
	}

	/// <summary>This member supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
	/// <param name="r">
	///   <see langword="XmlReader" />
	/// </param>
	void IXmlSerializable.ReadXml(XmlReader r)
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

	/// <summary>Gets serialization information with all the data needed to reinstantiate this <see cref="T:System.Data.SqlTypes.SqlChars" /> instance.</summary>
	/// <param name="info">The object to be populated with serialization information.</param>
	/// <param name="context">The destination context of the serialization.</param>
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
