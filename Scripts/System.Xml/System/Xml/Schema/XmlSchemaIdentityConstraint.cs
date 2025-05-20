using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Class for the identity constraints: <see langword="key" />, <see langword="keyref" />, and <see langword="unique" /> elements.</summary>
public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated
{
	private string name;

	private XmlSchemaXPath selector;

	private XmlSchemaObjectCollection fields;

	private XmlQualifiedName qualifiedName;

	private CompiledIdentityConstraint compiledConstraint;

	/// <summary>Gets or sets the name of the identity constraint.</summary>
	/// <returns>The name of the identity constraint.</returns>
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

	/// <summary>Gets or sets the XPath expression <see langword="selector" /> element.</summary>
	/// <returns>The XPath expression <see langword="selector" /> element.</returns>
	[XmlElement("selector", typeof(XmlSchemaXPath))]
	public XmlSchemaXPath Selector
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the collection of fields that apply as children for the XML Path Language (XPath) expression selector.</summary>
	/// <returns>The collection of fields.</returns>
	[XmlElement("field", typeof(XmlSchemaXPath))]
	public XmlSchemaObjectCollection Fields => null;

	/// <summary>Gets the qualified name of the identity constraint, which holds the post-compilation value of the <see langword="QualifiedName" /> property.</summary>
	/// <returns>The post-compilation value of the <see langword="QualifiedName" /> property.</returns>
	[XmlIgnore]
	public XmlQualifiedName QualifiedName => null;

	[XmlIgnore]
	internal CompiledIdentityConstraint CompiledConstraint
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

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaIdentityConstraint" /> class.</summary>
	public XmlSchemaIdentityConstraint()
	{
	}
}
