using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the <see langword="redefine" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class can be used to allow simple and complex types, groups and attribute groups from external schema files to be redefined in the current schema. This class can also be used to provide versioning for the schema elements.</summary>
public class XmlSchemaRedefine : XmlSchemaExternal
{
	private XmlSchemaObjectCollection items;

	private XmlSchemaObjectTable attributeGroups;

	private XmlSchemaObjectTable types;

	private XmlSchemaObjectTable groups;

	/// <summary>Gets the collection of the following classes: <see cref="T:System.Xml.Schema.XmlSchemaAnnotation" />, <see cref="T:System.Xml.Schema.XmlSchemaAttributeGroup" />, <see cref="T:System.Xml.Schema.XmlSchemaComplexType" />, <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" />, and <see cref="T:System.Xml.Schema.XmlSchemaGroup" />.</summary>
	/// <returns>The elements contained within the redefine element.</returns>
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	public XmlSchemaObjectCollection Items => null;

	/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> , for all attributes in the schema, which holds the post-compilation value of the <see langword="AttributeGroups" /> property.</summary>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> for all attributes in the schema. The post-compilation value of the <see langword="AttributeGroups" /> property.</returns>
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups => null;

	/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />, for all simple and complex types in the schema, which holds the post-compilation value of the <see langword="SchemaTypes" /> property.</summary>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> for all schema types in the schema. The post-compilation value of the <see langword="SchemaTypes" /> property.</returns>
	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes => null;

	/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />, for all groups in the schema, which holds the post-compilation value of the <see langword="Groups" /> property.</summary>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> for all groups in the schema. The post-compilation value of the <see langword="Groups" /> property.</returns>
	[XmlIgnore]
	public XmlSchemaObjectTable Groups => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaRedefine" /> class.</summary>
	public XmlSchemaRedefine()
	{
	}

	internal override void AddAnnotation(XmlSchemaAnnotation annotation)
	{
	}
}
