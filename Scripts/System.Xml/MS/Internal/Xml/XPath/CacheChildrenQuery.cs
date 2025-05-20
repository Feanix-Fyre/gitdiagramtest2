using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class CacheChildrenQuery : ChildrenQuery
{
	private XPathNavigator _nextInput;

	private ClonableStack<XPathNavigator> _elementStk;

	private ClonableStack<int> _positionStk;

	private bool _needInput;

	public CacheChildrenQuery(Query qyInput, string name, string prefix, XPathNodeType type)
		: base(null, null, null, default(XPathNodeType))
	{
	}

	private CacheChildrenQuery(CacheChildrenQuery other)
		: base(null, null, null, default(XPathNodeType))
	{
	}

	public override void Reset()
	{
	}

	public override XPathNavigator Advance()
	{
		return null;
	}

	private bool DecideNextNode()
	{
		return false;
	}

	private XPathNavigator GetNextInput()
	{
		return null;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
