using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the <see langword="attribute" /> element from the XML Schema as specified by the World Wide Web Consortium (W3C). Attributes provide additional information for other document elements. The attribute tag is nested between the tags of a document's element for the schema. The XML document displays attributes as named items in the opening tag of an element.</summary>
public class XmlSchemaAttribute : XmlSchemaAnnotated
{
	private string defaultValue;

	private string fixedValue;

	private string name;

	private XmlSchemaForm form;

	private XmlSchemaUse use;

	private XmlQualifiedName refName;

	private XmlQualifiedName typeName;

	private XmlQualifiedName qualifiedName;

	private XmlSchemaSimpleType type;

	private XmlSchemaSimpleType attributeType;

	private SchemaAttDef attDef;

	/// <summary>Gets or sets the default value for the attribute.</summary>
	/// <returns>The default value for the attribute. The default is a null reference.Optional.</returns>
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

	/// <summary>Gets or sets the fixed value for the attribute.</summary>
	/// <returns>The fixed value for the attribute. The default is null.Optional.</returns>
	[XmlAttribute("fixed")]
	[DefaultValue(null)]
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

	/// <summary>Gets or sets the form for the attribute.</summary>
	/// <returns>One of the <see cref="T:System.Xml.Schema.XmlSchemaForm" /> values. The default is the value of the <see cref="P:System.Xml.Schema.XmlSchema.AttributeFormDefault" /> of the schema element containing the attribute.Optional.</returns>
	[XmlAttribute("form")]
	[DefaultValue(XmlSchemaForm.None)]
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

	/// <summary>Gets or sets the name of the attribute.</summary>
	/// <returns>The name of the attribute.</returns>
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

	/// <summary>Gets or sets the name of an attribute declared in this schema (or another schema indicated by the specified namespace).</summary>
	/// <returns>The name of the attribute declared.</returns>
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

	/// <summary>Gets or sets the name of the simple type defined in this schema (or another schema indicated by the specified namespace).</summary>
	/// <returns>The name of the simple type.</returns>
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

	/// <summary>Gets or sets the attribute type to a simple type.</summary>
	/// <returns>The simple type defined in this schema.</returns>
	[XmlElement("simpleType")]
	public XmlSchemaSimpleType SchemaType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets information about how the attribute is used.</summary>
	/// <returns>One of the following values: None, Prohibited, Optional, or Required. The default is Optional.Optional.</returns>
	[XmlAttribute("use")]
	[DefaultValue(XmlSchemaUse.None)]
	public XmlSchemaUse Use
	{
		get
		{
			return default(XmlSchemaUse);
		}
		set
		{
		}
	}

	/// <summary>Gets the qualified name for the attribute.</summary>
	/// <returns>The post-compilation value of the <see langword="QualifiedName" /> property.</returns>
	[XmlIgnore]
	public XmlQualifiedName QualifiedName => null;

	/// <summary>Gets an <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> object representing the type of the attribute based on the <see cref="P:System.Xml.Schema.XmlSchemaAttribute.SchemaType" /> or <see cref="P:System.Xml.Schema.XmlSchemaAttribute.SchemaTypeName" /> of the attribute.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> object.</returns>
	[XmlIgnore]
	public XmlSchemaSimpleType AttributeSchemaType => null;

	[XmlIgnore]
	internal XmlSchemaDatatype Datatype => null;

	internal SchemaAttDef AttDef
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

	internal void SetQualifiedName(XmlQualifiedName value)
	{
	}

	internal void SetAttributeType(XmlSchemaSimpleType value)
	{
	}

	internal override XmlSchemaObject Clone()
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> class.</summary>
	public XmlSchemaAttribute()
	{
	}
}
