using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal abstract class XPathAxisIterator : XPathNodeIterator
{
	internal XPathNavigator nav;

	internal XPathNodeType type;

	internal string name;

	internal string uri;

	internal int position;

	internal bool matchSelf;

	internal bool first;

	public override XPathNavigator Current => null;

	public override int CurrentPosition => 0;

	protected virtual bool Matches => false;

	public XPathAxisIterator(XPathNavigator nav, bool matchSelf)
	{
	}

	public XPathAxisIterator(XPathNavigator nav, XPathNodeType type, bool matchSelf)
	{
	}

	public XPathAxisIterator(XPathNavigator nav, string name, string namespaceURI, bool matchSelf)
	{
	}

	public XPathAxisIterator(XPathAxisIterator it)
	{
	}
}
