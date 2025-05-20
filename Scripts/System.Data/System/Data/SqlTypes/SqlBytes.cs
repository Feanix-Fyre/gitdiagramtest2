using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes;

/// <summary>Represents a mutable reference type that wraps either a <see cref="P:System.Data.SqlTypes.SqlBytes.Buffer" /> or a <see cref="P:System.Data.SqlTypes.SqlBytes.Stream" />.</summary>
[Serializable]
[DefaultMember("Item")]
[XmlSchemaProvider("GetXsdType")]
public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable
{
	internal byte[] _rgbBuf;

	private long _lCurLen;

	internal Stream _stream;

	private SqlBytesCharsState _state;

	private byte[] _rgbWorkBuf;

	/// <summary>Gets a Boolean value that indicates whether this <see cref="T:System.Data.SqlTypes.SqlBytes" /> is null.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Data.SqlTypes.SqlBytes" /> is null, <see langword="false" /> otherwise.</returns>
	public bool IsNull => false;

	/// <summary>Returns a reference to the internal buffer.</summary>
	/// <returns>A reference to the internal buffer. For <see cref="T:System.Data.SqlTypes.SqlBytes" /> instances created on top of unmanaged pointers, it returns a managed copy of the internal buffer.</returns>
	public byte[] Buffer => null;

	/// <summary>Gets the length of the value that is contained in the <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance.</summary>
	/// <returns>A <see cref="T:System.Int64" /> value representing the length of the value that is contained in the <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance.  
	///  Returns -1 if no buffer is available to the instance or if the value is null.  
	///  Returns a <see cref="P:System.IO.Stream.Length" /> for a stream-wrapped instance.</returns>
	public long Length => 0L;

	/// <summary>Returns a managed copy of the value held by this <see cref="T:System.Data.SqlTypes.SqlBytes" />.</summary>
	/// <returns>The value of this <see cref="T:System.Data.SqlTypes.SqlBytes" /> as an array of bytes.</returns>
	public byte[] Value => null;

	/// <summary>Gets a null instance of this <see cref="T:System.Data.SqlTypes.SqlBytes" />.</summary>
	/// <returns>An instance whose <see cref="P:System.Data.SqlTypes.SqlBytes.IsNull" /> property returns <see langword="true" />.</returns>
	public static SqlBytes Null => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlBytes" /> class.</summary>
	public SqlBytes()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlBytes" /> class based on the specified byte array.</summary>
	/// <param name="buffer">The array of unsigned bytes.</param>
	public SqlBytes(byte[] buffer)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlBytes" /> class based on the specified <see cref="T:System.Data.SqlTypes.SqlBinary" /> value.</summary>
	/// <param name="value">A <see cref="T:System.Data.SqlTypes.SqlBinary" /> value.</param>
	public SqlBytes(SqlBinary value)
	{
	}

	/// <summary>Sets this <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance to null.</summary>
	public void SetNull()
	{
	}

	private void CopyStreamToBuffer()
	{
	}

	internal bool FStream()
	{
		return false;
	}

	private void SetBuffer(byte[] buffer)
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
	/// <returns>A <see langword="string" /> that indicates the XSD of the specified <see langword="XmlSchemaSet" />.</returns>
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
	{
		return null;
	}

	/// <summary>Gets serialization information with all the data needed to reinstantiate this <see cref="T:System.Data.SqlTypes.SqlBytes" /> instance.</summary>
	/// <param name="info">The object to be populated with serialization information.</param>
	/// <param name="context">The destination context of the serialization.</param>
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
