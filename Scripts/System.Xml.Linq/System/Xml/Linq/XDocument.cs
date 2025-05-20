namespace System.Xml.Linq;

/// <summary>Represents an XML document. For the components and usage of an <see cref="T:System.Xml.Linq.XDocument" /> object, see XDocument Class Overview.</summary>
public class XDocument : XContainer
{
	private XDeclaration _declaration;

	/// <summary>Gets or sets the XML declaration for this document.</summary>
	/// <returns>An <see cref="T:System.Xml.Linq.XDeclaration" /> that contains the XML declaration for this document.</returns>
	public XDeclaration Declaration
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the node type for this node.</summary>
	/// <returns>The node type. For <see cref="T:System.Xml.Linq.XDocument" /> objects, this value is <see cref="F:System.Xml.XmlNodeType.Document" />.</returns>
	public override XmlNodeType NodeType => default(XmlNodeType);

	/// <summary>Gets the root element of the XML Tree for this document.</summary>
	/// <returns>The root <see cref="T:System.Xml.Linq.XElement" /> of the XML tree.</returns>
	public XElement Root => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XDocument" /> class.</summary>
	public XDocument()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XDocument" /> class from an existing <see cref="T:System.Xml.Linq.XDocument" /> object.</summary>
	/// <param name="other">The <see cref="T:System.Xml.Linq.XDocument" /> object that will be copied.</param>
	public XDocument(XDocument other)
	{
	}

	/// <summary>Write this document to an <see cref="T:System.Xml.XmlWriter" />.</summary>
	/// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
	public override void WriteTo(XmlWriter writer)
	{
	}

	internal override void AddAttribute(XAttribute a)
	{
	}

	internal override void AddAttributeSkipNotify(XAttribute a)
	{
	}

	internal override XNode CloneNode()
	{
		return null;
	}

	private T GetFirstNode<T>() where T : XNode
	{
		return null;
	}

	internal static bool IsWhitespace(string s)
	{
		return false;
	}

	internal override void ValidateNode(XNode node, XNode previous)
	{
	}

	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter)
	{
	}

	internal override void ValidateString(string s)
	{
	}
}
