using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the <see langword="documentation" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class specifies information to be read or used by humans within an <see langword="annotation" />.</summary>
public class XmlSchemaDocumentation : XmlSchemaObject
{
	private string source;

	private string language;

	private XmlNode[] markup;

	private static XmlSchemaSimpleType languageType;

	/// <summary>Gets or sets the Uniform Resource Identifier (URI) source of the information.</summary>
	/// <returns>A URI reference. The default is <see langword="String.Empty" />.Optional.</returns>
	[XmlAttribute("source", DataType = "anyURI")]
	public string Source
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the <see langword="xml:lang" /> attribute. This serves as an indicator of the language used in the contents.</summary>
	/// <returns>The <see langword="xml:lang" /> attribute.Optional.</returns>
	[XmlAttribute("xml:lang")]
	public string Language
	{
		set
		{
		}
	}

	/// <summary>Gets or sets an array of <see langword="XmlNodes" /> that represents the documentation child nodes.</summary>
	/// <returns>The array that represents the documentation child nodes.</returns>
	[XmlAnyElement]
	[XmlText]
	public XmlNode[] Markup
	{
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaDocumentation" /> class.</summary>
	public XmlSchemaDocumentation()
	{
	}
}
