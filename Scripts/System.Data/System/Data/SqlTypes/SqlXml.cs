using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes;

/// <summary>Represents XML data stored in or retrieved from a server.</summary>
[Serializable]
[XmlSchemaProvider("GetXsdType")]
public sealed class SqlXml : INullable, IXmlSerializable
{
	private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate;

	private static readonly XmlReaderSettings s_defaultXmlReaderSettings;

	private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput;

	private static MethodInfo s_createSqlReaderMethodInfo;

	private MethodInfo _createSqlReaderMethodInfo;

	private bool _fNotNull;

	private Stream _stream;

	private bool _firstCreateReader;

	private static MethodInfo CreateSqlReaderMethodInfo => null;

	/// <summary>Indicates whether this instance represents a null <see cref="T:System.Data.SqlTypes.SqlXml" /> value.</summary>
	/// <returns>
	///   <see langword="true" /> if <see langword="Value" /> is null. Otherwise, <see langword="false" />.</returns>
	public bool IsNull => false;

	/// <summary>Creates a new <see cref="T:System.Data.SqlTypes.SqlXml" /> instance.</summary>
	public SqlXml()
	{
	}

	/// <summary>Gets the value of the XML content of this <see cref="T:System.Data.SqlTypes.SqlXml" /> as a <see cref="T:System.Xml.XmlReader" />.</summary>
	/// <returns>A <see cref="T:System.Xml.XmlReader" />-derived instance that contains the XML content. The actual type may vary (for example, the return value might be <see cref="T:System.Xml.XmlTextReader" />) depending on how the information is represented internally, on the server.</returns>
	/// <exception cref="T:System.Data.SqlTypes.SqlNullValueException">Attempt was made to access this property on a null instance of <see cref="T:System.Data.SqlTypes.SqlXml" />.</exception>
	public XmlReader CreateReader()
	{
		return null;
	}

	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = false, bool throwTargetInvocationExceptions = false)
	{
		return null;
	}

	private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate()
	{
		return null;
	}

	private void SetNull()
	{
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.GetSchema" />.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchema" /> that describes the XML representation of the object that is produced by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" /> method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" /> method.</returns>
	XmlSchema IXmlSerializable.GetSchema()
	{
		return null;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" />.</summary>
	/// <param name="r">An XmlReader.</param>
	void IXmlSerializable.ReadXml(XmlReader r)
	{
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" />.</summary>
	/// <param name="writer">An XmlWriter</param>
	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
	}

	/// <summary>Returns the XML Schema definition language (XSD) of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</summary>
	/// <param name="schemaSet">An <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</param>
	/// <returns>A string that indicates the XSD of the specified <see cref="T:System.Xml.Schema.XmlSchemaSet" />.</returns>
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
	{
		return null;
	}
}
