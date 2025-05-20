using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Represents the World Wide Web Consortium (W3C) <see langword="any" /> element.</summary>
public class XmlSchemaAny : XmlSchemaParticle
{
	private string ns;

	private XmlSchemaContentProcessing processContents;

	private NamespaceList namespaceList;

	/// <summary>Gets or sets the namespaces containing the elements that can be used.</summary>
	/// <returns>Namespaces for elements that are available for use. The default is <see langword="##any" />.Optional.</returns>
	[XmlAttribute("namespace")]
	public string Namespace
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets information about how an application or XML processor should handle the validation of XML documents for the elements specified by the <see langword="any" /> element.</summary>
	/// <returns>One of the <see cref="T:System.Xml.Schema.XmlSchemaContentProcessing" /> values. If no <see langword="processContents" /> attribute is specified, the default is <see langword="Strict" />.</returns>
	[DefaultValue(XmlSchemaContentProcessing.None)]
	[XmlAttribute("processContents")]
	public XmlSchemaContentProcessing ProcessContents
	{
		set
		{
		}
	}

	[XmlIgnore]
	internal NamespaceList NamespaceList => null;

	[XmlIgnore]
	internal string ResolvedNamespace => null;

	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect => default(XmlSchemaContentProcessing);

	internal override string NameString => null;

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

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaAny" /> class.</summary>
	public XmlSchemaAny()
	{
	}
}
