using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the World Wide Web Consortium (W3C) <see langword="anyAttribute" /> element.</summary>
public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
{
	private string ns;

	private XmlSchemaContentProcessing processContents;

	private NamespaceList namespaceList;

	/// <summary>Gets or sets the namespaces containing the attributes that can be used.</summary>
	/// <returns>Namespaces for attributes that are available for use. The default is <see langword="##any" />.Optional.</returns>
	[XmlAttribute("namespace")]
	public string Namespace
	{
		set
		{
		}
	}

	/// <summary>Gets or sets information about how an application or XML processor should handle the validation of XML documents for the attributes specified by the <see langword="anyAttribute" /> element.</summary>
	/// <returns>One of the <see cref="T:System.Xml.Schema.XmlSchemaContentProcessing" /> values. If no <see langword="processContents" /> attribute is specified, the default is <see langword="Strict" />.</returns>
	[XmlAttribute("processContents")]
	[DefaultValue(XmlSchemaContentProcessing.None)]
	public XmlSchemaContentProcessing ProcessContents
	{
		get
		{
			return default(XmlSchemaContentProcessing);
		}
		set
		{
		}
	}

	[XmlIgnore]
	internal NamespaceList NamespaceList => null;

	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect => default(XmlSchemaContentProcessing);

	internal void BuildNamespaceList(string targetNamespace)
	{
	}

	internal void BuildNamespaceListV1Compat(string targetNamespace)
	{
	}

	internal bool Allows(XmlQualifiedName qname)
	{
		return false;
	}

	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super)
	{
		return false;
	}

	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat)
	{
		return null;
	}

	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> class.</summary>
	public XmlSchemaAnyAttribute()
	{
	}
}
