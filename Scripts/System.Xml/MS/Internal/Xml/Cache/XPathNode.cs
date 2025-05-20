using System.Xml.XPath;

namespace MS.Internal.Xml.Cache;

internal struct XPathNode
{
	private XPathNodeInfoAtom _info;

	private ushort _idxSibling;

	private ushort _idxParent;

	private ushort _idxSimilar;

	private ushort _posOffset;

	private uint _props;

	private string _value;

	public XPathNodeType NodeType => default(XPathNodeType);

	public string Prefix => null;

	public string LocalName => null;

	public string Name => null;

	public string NamespaceUri => null;

	public XPathDocument Document => null;

	public string BaseUri => null;

	public int LineNumber => 0;

	public int LinePosition => 0;

	public int CollapsedLinePosition => 0;

	public XPathNodePageInfo PageInfo => null;

	public bool IsXmlNamespaceNode => false;

	public bool HasSibling => false;

	public bool HasCollapsedText => false;

	public bool HasAttribute => false;

	public bool HasContentChild => false;

	public bool HasElementChild => false;

	public bool IsAttrNmsp => false;

	public bool IsText => false;

	public bool HasNamespaceDecls => false;

	public string Value => null;

	public int GetRoot(out XPathNode[] pageNode)
	{
		pageNode = null;
		return 0;
	}

	public int GetParent(out XPathNode[] pageNode)
	{
		pageNode = null;
		return 0;
	}

	public int GetSibling(out XPathNode[] pageNode)
	{
		pageNode = null;
		return 0;
	}

	public int GetSimilarElement(out XPathNode[] pageNode)
	{
		pageNode = null;
		return 0;
	}

	public bool NameMatch(string localName, string namespaceName)
	{
		return false;
	}

	public bool ElementMatch(string localName, string namespaceName)
	{
		return false;
	}
}
