using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the <see langword="attributeGroup" /> element with the <see langword="ref" /> attribute from the XML Schema as specified by the World Wide Web Consortium (W3C). AttributesGroupRef is the reference for an attributeGroup, name property contains the attribute group being referenced. </summary>
public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated
{
	private XmlQualifiedName refName;

	/// <summary>Gets or sets the name of the referenced <see langword="attributeGroup" /> element.</summary>
	/// <returns>The name of the referenced attribute group. The value must be a QName.</returns>
	[XmlAttribute("ref")]
	public XmlQualifiedName RefName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaAttributeGroupRef" /> class.</summary>
	public XmlSchemaAttributeGroupRef()
	{
	}
}
