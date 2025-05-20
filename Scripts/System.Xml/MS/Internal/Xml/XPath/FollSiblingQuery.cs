using System.Collections.Generic;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class FollSiblingQuery : BaseAxisQuery
{
	private ClonableStack<XPathNavigator> _elementStk;

	private List<XPathNavigator> _parentStk;

	private XPathNavigator _nextInput;

	public FollSiblingQuery(Query qyInput, string name, string prefix, XPathNodeType type)
		: base((Query)null)
	{
	}

	private FollSiblingQuery(FollSiblingQuery other)
		: base((Query)null)
	{
	}

	public override void Reset()
	{
	}

	private bool Visited(XPathNavigator nav)
	{
		return false;
	}

	private XPathNavigator FetchInput()
	{
		return null;
	}

	public override XPathNavigator Advance()
	{
		return null;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
