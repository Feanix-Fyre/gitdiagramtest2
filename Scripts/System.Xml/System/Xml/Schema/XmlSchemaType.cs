using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>The base class for all simple types and complex types.</summary>
public class XmlSchemaType : XmlSchemaAnnotated
{
	private string name;

	private XmlSchemaDerivationMethod final;

	private XmlSchemaDerivationMethod derivedBy;

	private XmlSchemaType baseSchemaType;

	private XmlSchemaDatatype datatype;

	private XmlSchemaDerivationMethod finalResolved;

	private SchemaElementDecl elementDecl;

	private XmlQualifiedName qname;

	private XmlSchemaType redefined;

	private XmlSchemaContentType contentType;

	/// <summary>Gets or sets the name of the type.</summary>
	/// <returns>The name of the type.</returns>
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

	/// <summary>Gets or sets the final attribute of the type derivation that indicates if further derivations are allowed.</summary>
	/// <returns>One of the valid <see cref="T:System.Xml.Schema.XmlSchemaDerivationMethod" /> values. The default is <see cref="F:System.Xml.Schema.XmlSchemaDerivationMethod.None" />.</returns>
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

	/// <summary>Gets the qualified name for the type built from the <see langword="Name" /> attribute of this type. This is a post-schema-compilation property.</summary>
	/// <returns>The <see cref="T:System.Xml.XmlQualifiedName" /> for the type built from the <see langword="Name" /> attribute of this type.</returns>
	[XmlIgnore]
	public XmlQualifiedName QualifiedName => null;

	/// <summary>Gets the post-compilation value of the <see cref="P:System.Xml.Schema.XmlSchemaType.Final" /> property.</summary>
	/// <returns>The post-compilation value of the <see cref="P:System.Xml.Schema.XmlSchemaType.Final" /> property. The default is the <see langword="finalDefault" /> attribute value of the <see langword="schema" /> element.</returns>
	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved => default(XmlSchemaDerivationMethod);

	/// <summary>Gets the post-compilation value for the base type of this schema type.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaType" /> object representing the base type of this schema type.</returns>
	[XmlIgnore]
	public XmlSchemaType BaseXmlSchemaType => null;

	/// <summary>Gets the post-compilation information on how this element was derived from its base type.</summary>
	/// <returns>One of the valid <see cref="T:System.Xml.Schema.XmlSchemaDerivationMethod" /> values.</returns>
	[XmlIgnore]
	public XmlSchemaDerivationMethod DerivedBy => default(XmlSchemaDerivationMethod);

	/// <summary>Gets the post-compilation value for the data type of the complex type.</summary>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaDatatype" /> post-schema-compilation value.</returns>
	[XmlIgnore]
	public XmlSchemaDatatype Datatype => null;

	/// <summary>Gets or sets a value indicating if this type has a mixed content model. This property is only valid in a complex type.</summary>
	/// <returns>
	///     <see langword="true" /> if the type has a mixed content model; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[XmlIgnore]
	public virtual bool IsMixed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlTypeCode" /> of the type.</summary>
	/// <returns>One of the <see cref="T:System.Xml.Schema.XmlTypeCode" /> values.</returns>
	[XmlIgnore]
	public XmlTypeCode TypeCode => default(XmlTypeCode);

	[XmlIgnore]
	internal XmlValueConverter ValueConverter => null;

	internal XmlSchemaContentType SchemaContentType => default(XmlSchemaContentType);

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
	internal XmlSchemaType Redefined
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

	/// <summary>Returns an <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> that represents the built-in simple type of the simple type that is specified by the qualified name.</summary>
	/// <param name="qualifiedName">The <see cref="T:System.Xml.XmlQualifiedName" /> of the simple type.</param>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> that represents the built-in simple type.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.XmlQualifiedName" /> parameter is <see langword="null" />.</exception>
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName)
	{
		return null;
	}

	/// <summary>Returns an <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> that represents the built-in simple type of the specified simple type.</summary>
	/// <param name="typeCode">One of the <see cref="T:System.Xml.Schema.XmlTypeCode" /> values representing the simple type.</param>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> that represents the built-in simple type.</returns>
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode)
	{
		return null;
	}

	/// <summary>Returns an <see cref="T:System.Xml.Schema.XmlSchemaComplexType" /> that represents the built-in complex type of the complex type specified by qualified name.</summary>
	/// <param name="qualifiedName">The <see cref="T:System.Xml.XmlQualifiedName" /> of the complex type.</param>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaComplexType" /> that represents the built-in complex type.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <see cref="T:System.Xml.XmlQualifiedName" /> parameter is <see langword="null" />.</exception>
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName)
	{
		return null;
	}

	internal void SetQualifiedName(XmlQualifiedName value)
	{
	}

	internal void SetFinalResolved(XmlSchemaDerivationMethod value)
	{
	}

	internal void SetBaseSchemaType(XmlSchemaType value)
	{
	}

	internal void SetDerivedBy(XmlSchemaDerivationMethod value)
	{
	}

	internal void SetDatatype(XmlSchemaDatatype value)
	{
	}

	internal void SetContentType(XmlSchemaContentType value)
	{
	}

	/// <summary>Returns a value indicating if the derived schema type specified is derived from the base schema type specified</summary>
	/// <param name="derivedType">The derived <see cref="T:System.Xml.Schema.XmlSchemaType" /> to test.</param>
	/// <param name="baseType">The base <see cref="T:System.Xml.Schema.XmlSchemaType" /> to test the derived <see cref="T:System.Xml.Schema.XmlSchemaType" /> against.</param>
	/// <param name="except">One of the <see cref="T:System.Xml.Schema.XmlSchemaDerivationMethod" /> values representing a type derivation method to exclude from testing.</param>
	/// <returns>
	///     <see langword="true" /> if the derived type is derived from the base type; otherwise, <see langword="false" />.</returns>
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except)
	{
		return false;
	}

	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except)
	{
		return false;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaType" /> class.</summary>
	public XmlSchemaType()
	{
	}
}
