using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the <see langword="simpleType" /> element for simple content from XML Schema as specified by the World Wide Web Consortium (W3C). This class defines a simple type. Simple types can specify information and constraints for the value of attributes or elements with text-only content.</summary>
public class XmlSchemaSimpleType : XmlSchemaType
{
	private XmlSchemaSimpleTypeContent content;

	/// <summary>Gets or sets one of <see cref="T:System.Xml.Schema.XmlSchemaSimpleTypeUnion" />, <see cref="T:System.Xml.Schema.XmlSchemaSimpleTypeList" />, or <see cref="T:System.Xml.Schema.XmlSchemaSimpleTypeRestriction" />.</summary>
	/// <returns>One of <see langword="XmlSchemaSimpleTypeUnion" />, <see langword="XmlSchemaSimpleTypeList" />, or <see langword="XmlSchemaSimpleTypeRestriction" />.</returns>
	[XmlElement("list", typeof(XmlSchemaSimpleTypeList))]
	[XmlElement("union", typeof(XmlSchemaSimpleTypeUnion))]
	[XmlElement("restriction", typeof(XmlSchemaSimpleTypeRestriction))]
	public XmlSchemaSimpleTypeContent Content
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> class.</summary>
	public XmlSchemaSimpleType()
	{
	}

	internal override XmlSchemaObject Clone()
	{
		return null;
	}
}
