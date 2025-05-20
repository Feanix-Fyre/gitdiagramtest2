using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class XPathDescendantIterator : XPathAxisIterator
{
	private int _level;

	public XPathDescendantIterator(XPathNavigator nav, XPathNodeType type, bool matchSelf)
		: base(null, matchSelf: false)
	{
	}

	public XPathDescendantIterator(XPathNavigator nav, string name, string namespaceURI, bool matchSelf)
		: base(null, matchSelf: false)
	{
	}

	public XPathDescendantIterator(XPathDescendantIterator it)
		: base(null, matchSelf: false)
	{
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}

	public override bool MoveNext()
	{
		return false;
	}
}
