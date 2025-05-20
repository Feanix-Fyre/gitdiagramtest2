using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the <see langword="element" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class is the base class for all particle types and is used to describe an element in an XML document.</summary>
public class XmlSchemaElement : XmlSchemaParticle
{
	private bool isAbstract;

	private bool hasAbstractAttribute;

	private bool isNillable;

	private bool hasNillableAttribute;

	private bool isLocalTypeDerivationChecked;

	private XmlSchemaDerivationMethod block;

	private XmlSchemaDerivationMethod final;

	private XmlSchemaForm form;

	private string defaultValue;

	private string fixedValue;

	private string name;

	private XmlQualifiedName refName;

	private XmlQualifiedName substitutionGroup;

	private XmlQualifiedName typeName;

	private XmlSchemaType type;

	private XmlQualifiedName qualifiedName;

	private XmlSchemaType elementType;

	private XmlSchemaDerivationMethod blockResolved;

	private XmlSchemaDerivationMethod finalResolved;

	private XmlSchemaObjectCollection constraints;

	private SchemaElementDecl elementDecl;

	/// <summary>Gets or sets information to indicate if the element can be used in an instance document.</summary>
	/// <returns>If <see langword="true" />, the element cannot appear in the instance document. The default is <see langword="false" />.Optional.</returns>
	[DefaultValue(false)]
	[XmlAttribute("abstract")]
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

	/// <summary>Gets or sets a <see langword="Block" /> derivation.</summary>
	/// <returns>The attribute used to block a type derivation. Default value is <see langword="XmlSchemaDerivationMethod.None" />.Optional.</returns>
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

	/// <summary>Gets or sets the default value of the element if its content is a simple type or content of the element is <see langword="textOnly" />.</summary>
	/// <returns>The default value for the element. The default is a null reference.Optional.</returns>
	[XmlAttribute("default")]
	[DefaultValue(null)]
	public string DefaultValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see langword="Final" /> property to indicate that no further derivations are allowed.</summary>
	/// <returns>The <see langword="Final" /> property. The default is <see langword="XmlSchemaDerivationMethod.None" />.Optional.</returns>
	[XmlAttribute("final")]
	[DefaultValue(XmlSchemaDerivationMethod.None)]
	public XmlSchemaDerivationMethod Final
	{
		get
		{
			return default(XmlSchemaDerivationMethod);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the fixed value.</summary>
	/// <returns>The fixed value that is predetermined and unchangeable. The default is a null reference.Optional.</returns>
	[DefaultValue(null)]
	[XmlAttribute("fixed")]
	public string FixedValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the form for the element.</summary>
	/// <returns>The form for the element. The default is the <see cref="P:System.Xml.Schema.XmlSchema.ElementFormDefault" /> value.Optional.</returns>
	[DefaultValue(XmlSchemaForm.None)]
	[XmlAttribute("form")]
	public XmlSchemaForm Form
	{
		get
		{
			return default(XmlSchemaForm);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the name of the element.</summary>
	/// <returns>The name of the element. The default is <see langword="String.Empty" />.</returns>
	[XmlAttribute("name")]
	[DefaultValue(null)]
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

	/// <summary>Gets or sets information that indicates if <see langword="xsi:nil" /> can occur in the instance data. Indicates if an explicit nil value can be assigned to the element.</summary>
	/// <returns>If nillable is <see langword="true" />, this enables an instance of the element to have the <see langword="nil" /> attribute set to <see langword="true" />. The <see langword="nil" /> attribute is defined as part of the XML Schema namespace for instances. The default is <see langword="false" />.Optional.</returns>
	[XmlAttribute("nillable")]
	[DefaultValue(false)]
	public bool IsNillable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[XmlIgnore]
	internal bool HasNillableAttribute => false;

	[XmlIgnore]
	internal bool HasAbstractAttribute => false;

	/// <summary>Gets or sets the reference name of an element declared in this schema (or another schema indicated by the specified namespace).</summary>
	/// <returns>The reference name of the element.</returns>
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

	/// <summary>Gets or sets the name of an element that is being substituted by this element.</summary>
	/// <returns>The qualified name of an element that is being substituted by this element.Optional.</returns>
	[XmlAttribute("substitutionGroup")]
	public XmlQualifiedName SubstitutionGroup
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the name of a built-in data type defined in this schema or another schema indicated by the specified namespace.</summary>
	/// <returns>The name of the built-in data type.</returns>
	[XmlAttribute("type")]
	public XmlQualifiedName SchemaTypeName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the type of the element. This can either be a complex type or a simple type.</summary>
	/// <returns>The type of the element.</returns>
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	public XmlSchemaType SchemaType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the collection of constraints on the element.</summary>
	/// <returns>The collection of constraints.</returns>
	[XmlElement("key", typeof(XmlSchemaKey))]
	[XmlElement("keyref", typeof(XmlSchemaKeyref))]
	[XmlElement("unique", typeof(XmlSchemaUnique))]
	public XmlSchemaObjectCollection Constraints => null;

	/// <summary>Gets the actual qualified name for the given element. </summary>
	/// <returns>The qualified name of the element. The post-compilation value of the <see langword="QualifiedName" /> property.</returns>
	[XmlIgnore]
	public XmlQualifiedName QualifiedName => null;

	/// <summary>Gets an <see cref="T:System.Xml.Schema.XmlSchemaType" /> object representing the type of the element based on the <see cref="P:System.Xml.Schema.XmlSchemaElement.SchemaType" /> or <see cref="P:System.Xml.Schema.XmlSchemaElement.SchemaTypeName" /> values of the element.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaType" /> object.</returns>
	[XmlIgnore]
	public XmlSchemaType ElementSchemaType => null;

	/// <summary>Gets the post-compilation value of the <see langword="Block" /> property.</summary>
	/// <returns>The post-compilation value of the <see langword="Block" /> property. The default is the <see langword="BlockDefault" /> value on the <see langword="schema" /> element.</returns>
	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved => default(XmlSchemaDerivationMethod);

	/// <summary>Gets the post-compilation value of the <see langword="Final" /> property.</summary>
	/// <returns>The post-compilation value of the <see langword="Final" /> property. Default value is the <see langword="FinalDefault" /> value on the <see langword="schema" /> element.</returns>
	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved => default(XmlSchemaDerivationMethod);

	internal bool HasConstraints => false;

	internal bool IsLocalTypeDerivationChecked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal SchemaElementDecl ElementDecl
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

	[XmlIgnore]
	internal override string NameString => null;

	internal void SetQualifiedName(XmlQualifiedName value)
	{
	}

	internal void SetElementType(XmlSchemaType value)
	{
	}

	internal void SetBlockResolved(XmlSchemaDerivationMethod value)
	{
	}

	internal void SetFinalResolved(XmlSchemaDerivationMethod value)
	{
	}

	internal override XmlSchemaObject Clone()
	{
		return null;
	}

	internal XmlSchemaObject Clone(XmlSchema parentSchema)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaElement" /> class.</summary>
	public XmlSchemaElement()
	{
	}
}
