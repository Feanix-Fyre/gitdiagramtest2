using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class XPathSingletonIterator : ResetableIterator
{
	private XPathNavigator _nav;

	private int _position;

	public override XPathNavigator Current => null;

	public override int CurrentPosition => 0;

	public override int Count => 0;

	public XPathSingletonIterator(XPathNavigator nav)
	{
	}

	public XPathSingletonIterator(XPathNavigator nav, bool moved)
	{
	}

	public XPathSingletonIterator(XPathSingletonIterator it)
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

	public override void Reset()
	{
	}
}
