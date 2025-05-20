using System.Xml.Schema;
using System.Xml.XPath;

namespace System.Xml;

internal sealed class DocumentXPathNavigator : XPathNavigator, IHasXmlNode
{
	private XmlDocument document;

	private XmlNode source;

	private int attributeIndex;

	private XmlElement namespaceParent;

	public override XmlNameTable NameTable => null;

	public override XPathNodeType NodeType => default(XPathNodeType);

	public override string LocalName => null;

	public override string NamespaceURI => null;

	public override string Name => null;

	public override string Prefix => null;

	public override string Value => null;

	private string ValueDocument => null;

	private string ValueText => null;

	public override string BaseURI => null;

	public override string XmlLang => null;

	public override object UnderlyingObject => null;

	public override IXmlSchemaInfo SchemaInfo => null;

	public DocumentXPathNavigator(XmlDocument document, XmlNode node)
	{
	}

	public DocumentXPathNavigator(DocumentXPathNavigator other)
	{
	}

	public override XPathNavigator Clone()
	{
		return null;
	}

	public override bool MoveToAttribute(string localName, string namespaceURI)
	{
		return false;
	}

	public override bool MoveToFirstAttribute()
	{
		return false;
	}

	public override bool MoveToNextAttribute()
	{
		return false;
	}

	public override bool MoveToNamespace(string name)
	{
		return false;
	}

	public override bool MoveToFirstNamespace(XPathNamespaceScope scope)
	{
		return false;
	}

	private static bool MoveToFirstNamespaceLocal(XmlAttributeCollection attributes, ref int index)
	{
		return false;
	}

	private static bool MoveToFirstNamespaceGlobal(ref XmlAttributeCollection attributes, ref int index)
	{
		return false;
	}

	public override bool MoveToNextNamespace(XPathNamespaceScope scope)
	{
		return false;
	}

	private static bool MoveToNextNamespaceLocal(XmlAttributeCollection attributes, ref int index)
	{
		return false;
	}

	private static bool MoveToNextNamespaceGlobal(ref XmlAttributeCollection attributes, ref int index)
	{
		return false;
	}

	private bool PathHasDuplicateNamespace(XmlElement top, XmlElement bottom, string localName)
	{
		return false;
	}

	public override string LookupNamespace(string prefix)
	{
		return null;
	}

	public override bool MoveToNext()
	{
		return false;
	}

	public override bool MoveToFirstChild()
	{
		return false;
	}

	public override bool MoveToParent()
	{
		return false;
	}

	public override void MoveToRoot()
	{
	}

	public override bool MoveTo(XPathNavigator other)
	{
		return false;
	}

	public override bool MoveToId(string id)
	{
		return false;
	}

	public override bool MoveToChild(string localName, string namespaceUri)
	{
		return false;
	}

	public override bool MoveToChild(XPathNodeType type)
	{
		return false;
	}

	public override bool MoveToFollowing(string localName, string namespaceUri, XPathNavigator end)
	{
		return false;
	}

	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end)
	{
		return false;
	}

	public override bool MoveToNext(string localName, string namespaceUri)
	{
		return false;
	}

	public override bool MoveToNext(XPathNodeType type)
	{
		return false;
	}

	public override bool IsSamePosition(XPathNavigator other)
	{
		return false;
	}

	public override bool IsDescendant(XPathNavigator other)
	{
		return false;
	}

	private static XmlNode OwnerNode(XmlNode node)
	{
		return null;
	}

	private static int GetDepth(XmlNode node)
	{
		return 0;
	}

	private XmlNodeOrder Compare(XmlNode node1, XmlNode node2)
	{
		return default(XmlNodeOrder);
	}

	public override XmlNodeOrder ComparePosition(XPathNavigator other)
	{
		return default(XmlNodeOrder);
	}

	XmlNode IHasXmlNode.GetNode()
	{
		return null;
	}

	public override XPathNodeIterator SelectDescendants(string localName, string namespaceURI, bool matchSelf)
	{
		return null;
	}

	public override XPathNodeIterator SelectDescendants(XPathNodeType nt, bool includeSelf)
	{
		return null;
	}

	internal void ResetPosition(XmlNode node)
	{
	}

	private static bool ResetAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, out int index)
	{
		index = default(int);
		return false;
	}

	private static bool CheckAttributePosition(XmlAttribute attribute, out XmlAttributeCollection attributes, int index)
	{
		attributes = null;
		return false;
	}

	private void CalibrateText()
	{
	}

	private XmlNode ParentNode(XmlNode node)
	{
		return null;
	}

	private XmlNode ParentNodeTail(XmlNode parent)
	{
		return null;
	}

	private XmlNode FirstChild(XmlNode node)
	{
		return null;
	}

	private XmlNode FirstChildTail(XmlNode child)
	{
		return null;
	}

	private XmlNode NextSibling(XmlNode node)
	{
		return null;
	}

	private XmlNode NextSiblingTail(XmlNode node, XmlNode sibling)
	{
		return null;
	}

	private XmlNode PreviousText(XmlNode node)
	{
		return null;
	}

	private XmlNode PreviousTextTail(XmlNode node, XmlNode text)
	{
		return null;
	}

	private static bool IsDescendant(XmlNode top, XmlNode bottom)
	{
		return false;
	}

	private static bool IsValidChild(XmlNode parent, XmlNode child)
	{
		return false;
	}

	private XmlNode TextEnd(XmlNode node)
	{
		return null;
	}
}
