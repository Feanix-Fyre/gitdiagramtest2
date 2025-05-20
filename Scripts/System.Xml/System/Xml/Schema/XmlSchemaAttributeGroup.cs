using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the <see langword="attributeGroup" /> element from the XML Schema as specified by the World Wide Web Consortium (W3C). AttributesGroups provides a mechanism to group a set of attribute declarations so that they can be incorporated as a group into complex type definitions.</summary>
public class XmlSchemaAttributeGroup : XmlSchemaAnnotated
{
	private string name;

	private XmlSchemaObjectCollection attributes;

	private XmlSchemaAnyAttribute anyAttribute;

	private XmlQualifiedName qname;

	private XmlSchemaAttributeGroup redefined;

	private XmlSchemaObjectTable attributeUses;

	private XmlSchemaAnyAttribute attributeWildcard;

	private int selfReferenceCount;

	/// <summary>Gets or sets the name of the attribute group.</summary>
	/// <returns>The name of the attribute group.</returns>
	[XmlAttribute("name")]
	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the collection of attributes for the attribute group. Contains <see langword="XmlSchemaAttribute" /> and <see langword="XmlSchemaAttributeGroupRef" /> elements.</summary>
	/// <returns>The collection of attributes for the attribute group.</returns>
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes => null;

	/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> component of the attribute group.</summary>
	/// <returns>The World Wide Web Consortium (W3C) <see langword="anyAttribute" /> element.</returns>
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the qualified name of the attribute group.</summary>
	/// <returns>The qualified name of the attribute group.</returns>
	[XmlIgnore]
	public XmlQualifiedName QualifiedName => null;

	[XmlIgnore]
	internal XmlSchemaObjectTable AttributeUses => null;

	[XmlIgnore]
	internal XmlSchemaAnyAttribute AttributeWildcard
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the redefined attribute group property from the XML Schema.</summary>
	/// <returns>The redefined attribute group property.</returns>
	[XmlIgnore]
	public XmlSchemaAttributeGroup RedefinedAttributeGroup => null;

	[XmlIgnore]
	internal XmlSchemaAttributeGroup Redefined
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[XmlIgnore]
	internal int SelfReferenceCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[XmlIgnore]
	internal override string NameAttribute
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal void SetQualifiedName(XmlQualifiedName value)
	{
	}

	internal override XmlSchemaObject Clone()
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaAttributeGroup" /> class.</summary>
	public XmlSchemaAttributeGroup()
	{
	}
}
