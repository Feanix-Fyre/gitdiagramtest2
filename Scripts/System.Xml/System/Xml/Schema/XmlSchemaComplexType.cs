using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the <see langword="complexType" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class defines a complex type that determines the set of attributes and content of an element.</summary>
public class XmlSchemaComplexType : XmlSchemaType
{
	private XmlSchemaDerivationMethod block;

	private XmlSchemaContentModel contentModel;

	private XmlSchemaParticle particle;

	private XmlSchemaObjectCollection attributes;

	private XmlSchemaAnyAttribute anyAttribute;

	private XmlSchemaParticle contentTypeParticle;

	private XmlSchemaDerivationMethod blockResolved;

	private XmlSchemaObjectTable localElements;

	private XmlSchemaObjectTable attributeUses;

	private XmlSchemaAnyAttribute attributeWildcard;

	private static XmlSchemaComplexType anyTypeLax;

	private static XmlSchemaComplexType anyTypeSkip;

	private static XmlSchemaComplexType untypedAnyType;

	private byte pvFlags;

	[XmlIgnore]
	internal static XmlSchemaComplexType AnyType => null;

	[XmlIgnore]
	internal static XmlSchemaComplexType UntypedAnyType => null;

	internal static ContentValidator AnyTypeContentValidator => null;

	/// <summary>Gets or sets the information that determines if the <see langword="complexType" /> element can be used in the instance document.</summary>
	/// <returns>If <see langword="true" />, an element cannot use this <see langword="complexType" /> element directly and must use a complex type that is derived from this <see langword="complexType" /> element. The default is <see langword="false" />.Optional.</returns>
	[XmlAttribute("abstract")]
	[DefaultValue(false)]
	public bool IsAbstract
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see langword="block" /> attribute.</summary>
	/// <returns>The <see langword="block" /> attribute prevents a complex type from being used in the specified type of derivation. The default is <see langword="XmlSchemaDerivationMethod.None" />.Optional.</returns>
	[DefaultValue(XmlSchemaDerivationMethod.None)]
	[XmlAttribute("block")]
	public XmlSchemaDerivationMethod Block
	{
		get
		{
			return default(XmlSchemaDerivationMethod);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets information that determines if the complex type has a mixed content model (markup within the content).</summary>
	/// <returns>
	///     <see langword="true" />, if character data can appear between child elements of this complex type; otherwise, <see langword="false" />. The default is <see langword="false" />.Optional.</returns>
	[DefaultValue(false)]
	[XmlAttribute("mixed")]
	public override bool IsMixed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the post-compilation <see cref="T:System.Xml.Schema.XmlSchemaContentModel" /> of this complex type.</summary>
	/// <returns>The content model type that is one of the <see cref="T:System.Xml.Schema.XmlSchemaSimpleContent" /> or <see cref="T:System.Xml.Schema.XmlSchemaComplexContent" /> classes.</returns>
	[XmlElement("complexContent", typeof(XmlSchemaComplexContent))]
	[XmlElement("simpleContent", typeof(XmlSchemaSimpleContent))]
	public XmlSchemaContentModel ContentModel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the compositor type as one of the <see cref="T:System.Xml.Schema.XmlSchemaGroupRef" />, <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, or <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> classes.</summary>
	/// <returns>The compositor type.</returns>
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("all", typeof(XmlSchemaAll))]
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

	/// <summary>Gets the collection of attributes for the complex type.</summary>
	/// <returns>Contains <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> and <see cref="T:System.Xml.Schema.XmlSchemaAttributeGroupRef" /> classes.</returns>
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes => null;

	/// <summary>Gets or sets the value for the <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> component of the complex type.</summary>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> component of the complex type.</returns>
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

	/// <summary>Gets the content model of the complex type which holds the post-compilation value.</summary>
	/// <returns>The post-compilation value of the content model for the complex type.</returns>
	[XmlIgnore]
	public XmlSchemaContentType ContentType => default(XmlSchemaContentType);

	/// <summary>Gets the particle that holds the post-compilation value of the <see cref="P:System.Xml.Schema.XmlSchemaComplexType.ContentType" /> particle.</summary>
	/// <returns>The particle for the content type. The post-compilation value of the <see cref="P:System.Xml.Schema.XmlSchemaComplexType.ContentType" /> particle.</returns>
	[XmlIgnore]
	public XmlSchemaParticle ContentTypeParticle => null;

	/// <summary>Gets the value after the type has been compiled to the post-schema-validation information set (infoset). This value indicates how the type is enforced when <see langword="xsi:type" /> is used in the instance document.</summary>
	/// <returns>The post-schema-validated infoset value. The default is <see langword="BlockDefault" /> value on the <see langword="schema" /> element.</returns>
	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved => default(XmlSchemaDerivationMethod);

	/// <summary>Gets the collection of all the complied attributes of this complex type and its base types.</summary>
	/// <returns>The collection of all the attributes from this complex type and its base types. The post-compilation value of the <see langword="AttributeUses" /> property.</returns>
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeUses => null;

	/// <summary>Gets the post-compilation value for <see langword="anyAttribute" /> for this complex type and its base type(s).</summary>
	/// <returns>The post-compilation value of the <see langword="anyAttribute" /> element.</returns>
	[XmlIgnore]
	public XmlSchemaAnyAttribute AttributeWildcard => null;

	[XmlIgnore]
	internal XmlSchemaObjectTable LocalElements => null;

	internal bool HasWildCard
	{
		set
		{
		}
	}

	static XmlSchemaComplexType()
	{
	}

	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaComplexType" /> class.</summary>
	public XmlSchemaComplexType()
	{
	}

	internal void SetContentTypeParticle(XmlSchemaParticle value)
	{
	}

	internal void SetBlockResolved(XmlSchemaDerivationMethod value)
	{
	}

	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value)
	{
	}

	internal void SetAttributes(XmlSchemaObjectCollection newAttributes)
	{
	}

	internal bool ContainsIdAttribute(bool findAll)
	{
		return false;
	}

	internal override XmlSchemaObject Clone()
	{
		return null;
	}

	internal XmlSchemaObject Clone(XmlSchema parentSchema)
	{
		return null;
	}

	private void ClearCompiledState()
	{
	}

	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes)
	{
		return null;
	}

	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema)
	{
		return null;
	}

	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema)
	{
		return null;
	}

	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element)
	{
		return default(XmlSchemaForm);
	}

	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema)
	{
		return false;
	}

	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes)
	{
		return false;
	}
}
