using System.Xml;
using System.Xml.XPath;

namespace MS.Internal.Xml.Cache;

internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo
{
	private XPathNode[] _pageCurrent;

	private XPathNode[] _pageParent;

	private int _idxCurrent;

	private int _idxParent;

	private string _atomizedLocalName;

	public override string Value => null;

	public override XPathNodeType NodeType => default(XPathNodeType);

	public override string LocalName => null;

	public override string NamespaceURI => null;

	public override string Name => null;

	public override string Prefix => null;

	public override string BaseURI => null;

	public override XmlNameTable NameTable => null;

	public override object UnderlyingObject => null;

	public int LineNumber => 0;

	public int LinePosition => 0;

	public XPathDocumentNavigator(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent)
	{
	}

	public XPathDocumentNavigator(XPathDocumentNavigator nav)
	{
	}

	public override XPathNavigator Clone()
	{
		return null;
	}

	public override bool MoveToFirstAttribute()
	{
		return false;
	}

	public override bool MoveToNextAttribute()
	{
		return false;
	}

	public override bool MoveToAttribute(string localName, string namespaceURI)
	{
		return false;
	}

	public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope)
	{
		return false;
	}

	public override bool MoveToNextNamespace(XPathNamespaceScope scope)
	{
		return false;
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

	public override bool MoveTo(XPathNavigator other)
	{
		return false;
	}

	public override bool MoveToId(string id)
	{
		return false;
	}

	public override bool IsSamePosition(XPathNavigator other)
	{
		return false;
	}

	public override void MoveToRoot()
	{
	}

	public override bool MoveToChild(string localName, string namespaceURI)
	{
		return false;
	}

	public override bool MoveToNext(string localName, string namespaceURI)
	{
		return false;
	}

	public override bool MoveToChild(XPathNodeType type)
	{
		return false;
	}

	public override bool MoveToNext(XPathNodeType type)
	{
		return false;
	}

	public override bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end)
	{
		return false;
	}

	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end)
	{
		return false;
	}

	public override XPathNodeIterator SelectChildren(XPathNodeType type)
	{
		return null;
	}

	public override XPathNodeIterator SelectChildren(string name, string namespaceURI)
	{
		return null;
	}

	public override XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf)
	{
		return null;
	}

	public override XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf)
	{
		return null;
	}

	public override XmlNodeOrder ComparePosition(XPathNavigator other)
	{
		return default(XmlNodeOrder);
	}

	public override bool IsDescendant(XPathNavigator other)
	{
		return false;
	}

	private int GetPrimaryLocation()
	{
		return 0;
	}

	private int GetSecondaryLocation()
	{
		return 0;
	}

	public bool HasLineInfo()
	{
		return false;
	}

	public int GetPositionHashCode()
	{
		return 0;
	}

	public bool IsElementMatch(string localName, string namespaceURI)
	{
		return false;
	}

	public bool IsKindMatch(XPathNodeType typ)
	{
		return false;
	}

	private int GetFollowingEnd(XPathDocumentNavigator end, bool useParentOfVirtual, out XPathNode[] pageEnd)
	{
		pageEnd = null;
		return 0;
	}
}
