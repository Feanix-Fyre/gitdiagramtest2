using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the <see langword="simpleContent" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class is for simple and complex types with simple content model.</summary>
public class XmlSchemaSimpleContent : XmlSchemaContentModel
{
	private XmlSchemaContent content;

	/// <summary>Gets one of the <see cref="T:System.Xml.Schema.XmlSchemaSimpleContentRestriction" /> or <see cref="T:System.Xml.Schema.XmlSchemaSimpleContentExtension" />.</summary>
	/// <returns>The content contained within the <see langword="XmlSchemaSimpleContentRestriction" /> or <see langword="XmlSchemaSimpleContentExtension" /> class.</returns>
	[XmlElement("extension", typeof(XmlSchemaSimpleContentExtension))]
	[XmlElement("restriction", typeof(XmlSchemaSimpleContentRestriction))]
	public override XmlSchemaContent Content
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaSimpleContent" /> class.</summary>
	public XmlSchemaSimpleContent()
	{
	}
}
