using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class XPathChildIterator : XPathAxisIterator
{
	public XPathChildIterator(XPathNavigator nav, XPathNodeType type)
		: base(null, matchSelf: false)
	{
	}

	public XPathChildIterator(XPathNavigator nav, string name, string namespaceURI)
		: base(null, matchSelf: false)
	{
	}

	public XPathChildIterator(XPathChildIterator it)
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
