using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the World Wide Web Consortium (W3C) <see langword="appinfo" /> element.</summary>
public class XmlSchemaAppInfo : XmlSchemaObject
{
	private string source;

	private XmlNode[] markup;

	/// <summary>Gets or sets the source of the application information.</summary>
	/// <returns>A Uniform Resource Identifier (URI) reference. The default is <see langword="String.Empty" />.Optional.</returns>
	[XmlAttribute("source", DataType = "anyURI")]
	public string Source
	{
		set
		{
		}
	}

	/// <summary>Gets or sets an array of <see cref="T:System.Xml.XmlNode" /> objects that represents the <see langword="appinfo" /> child nodes.</summary>
	/// <returns>An array of <see cref="T:System.Xml.XmlNode" /> objects that represents the <see langword="appinfo" /> child nodes.</returns>
	[XmlText]
	[XmlAnyElement]
	public XmlNode[] Markup
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaAppInfo" /> class.</summary>
	public XmlSchemaAppInfo()
	{
	}
}
