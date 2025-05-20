using System.Xml.XPath;

namespace MS.Internal.Xml.Cache;

internal sealed class XPathNodeInfoAtom
{
	private string _localName;

	private string _namespaceUri;

	private string _prefix;

	private string _baseUri;

	private XPathNode[] _pageParent;

	private XPathNode[] _pageSibling;

	private XPathNode[] _pageSimilar;

	private XPathDocument _doc;

	private int _lineNumBase;

	private int _linePosBase;

	private XPathNodePageInfo _pageInfo;

	public XPathNodePageInfo PageInfo => null;

	public string LocalName => null;

	public string NamespaceUri => null;

	public string Prefix => null;

	public string BaseUri => null;

	public XPathNode[] SiblingPage => null;

	public XPathNode[] SimilarElementPage => null;

	public XPathNode[] ParentPage => null;

	public XPathDocument Document => null;

	public int LineNumberBase => 0;

	public int LinePositionBase => 0;
}
