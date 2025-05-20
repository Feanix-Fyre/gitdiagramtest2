using System.Text;
using System.Xml.Schema;

namespace System.Xml.Serialization;

/// <summary>Represents an attribute that specifies the derived types that the <see cref="T:System.Xml.Serialization.XmlSerializer" /> can place in a serialized array.</summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
public class XmlArrayItemAttribute : Attribute
{
	private string dataType;

	private string elementName;

	private XmlSchemaForm form;

	private string ns;

	private bool isNullable;

	private bool isNullableSpecified;

	private int nestingLevel;

	private Type type;

	/// <summary>Gets or sets the XML data type of the generated XML element.</summary>
	/// <returns>An XML schema definition (XSD) data type, as defined by the World Wide Web Consortium (www.w3.org) document "XML Schema Part 2: DataTypes".</returns>
	public string DataType => null;

	/// <summary>Gets or sets the name of the generated XML element.</summary>
	/// <returns>The name of the generated XML element. The default is the member identifier.</returns>
	public string ElementName => null;

	/// <summary>Gets or sets a value that indicates whether the name of the generated XML element is qualified.</summary>
	/// <returns>One of the <see cref="T:System.Xml.Schema.XmlSchemaForm" /> values. The default is <see langword="XmlSchemaForm.None" />.</returns>
	/// <exception cref="T:System.Exception">The <see cref="P:System.Xml.Serialization.XmlArrayItemAttribute.Form" /> property is set to <see langword="XmlSchemaForm.Unqualified" /> and a <see cref="P:System.Xml.Serialization.XmlArrayItemAttribute.Namespace" /> value is specified. </exception>
	public XmlSchemaForm Form => default(XmlSchemaForm);

	/// <summary>Gets or sets the namespace of the generated XML element.</summary>
	/// <returns>The namespace of the generated XML element.</returns>
	public string Namespace => null;

	/// <summary>Gets or sets a value that indicates whether the <see cref="T:System.Xml.Serialization.XmlSerializer" /> must serialize a member as an empty XML tag with the <see langword="xsi:nil" /> attribute set to <see langword="true" />.</summary>
	/// <returns>
	///     <see langword="true" /> if the <see cref="T:System.Xml.Serialization.XmlSerializer" /> generates the <see langword="xsi:nil" /> attribute; otherwise, <see langword="false" />, and no instance is generated. The default is <see langword="true" />.</returns>
	public bool IsNullable => false;

	internal bool IsNullableSpecified => false;

	/// <summary>Gets or sets the type allowed in an array.</summary>
	/// <returns>A <see cref="T:System.Type" /> that is allowed in the array.</returns>
	public Type Type => null;

	/// <summary>Gets or sets the level in a hierarchy of XML elements that the <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> affects.</summary>
	/// <returns>The zero-based index of a set of indexes in an array of arrays.</returns>
	public int NestingLevel => 0;

	internal void AddKeyHash(StringBuilder sb)
	{
	}
}
