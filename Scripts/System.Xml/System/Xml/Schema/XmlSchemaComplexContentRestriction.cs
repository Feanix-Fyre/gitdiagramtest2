using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the <see langword="restriction" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class is for complex types with a complex content model derived by restriction. It restricts the contents of the complex type to a subset of the inherited complex type.</summary>
public class XmlSchemaComplexContentRestriction : XmlSchemaContent
{
	private XmlSchemaParticle particle;

	private XmlSchemaObjectCollection attributes;

	private XmlSchemaAnyAttribute anyAttribute;

	private XmlQualifiedName baseTypeName;

	/// <summary>Gets or sets the name of a complex type from which this type is derived by restriction.</summary>
	/// <returns>The name of the complex type from which this type is derived by restriction.</returns>
	[XmlAttribute("base")]
	public XmlQualifiedName BaseTypeName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets one of the <see cref="T:System.Xml.Schema.XmlSchemaGroupRef" />, <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, or <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> classes.</summary>
	/// <returns>One of the <see cref="T:System.Xml.Schema.XmlSchemaGroupRef" />, <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, or <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> classes.</returns>
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaParticle Particle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the collection of attributes for the complex type. Contains the <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> and <see cref="T:System.Xml.Schema.XmlSchemaAttributeGroupRef" /> elements.</summary>
	/// <returns>The collection of attributes for the complex type.</returns>
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes => null;

	/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> component of the complex content model.</summary>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> component of the complex content model.</returns>
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

	internal void SetAttributes(XmlSchemaObjectCollection newAttributes)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaComplexContentRestriction" /> class.</summary>
	public XmlSchemaComplexContentRestriction()
	{
	}
}
