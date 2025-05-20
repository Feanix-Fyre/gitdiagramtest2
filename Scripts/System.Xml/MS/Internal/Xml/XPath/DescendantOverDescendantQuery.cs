using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class DescendantOverDescendantQuery : DescendantBaseQuery
{
	private int _level;

	public DescendantOverDescendantQuery(Query qyParent, bool matchSelf, string name, string prefix, XPathNodeType typeTest, bool abbrAxis)
		: base(null, null, null, default(XPathNodeType), matchSelf: false, abbrAxis: false)
	{
	}

	private DescendantOverDescendantQuery(DescendantOverDescendantQuery other)
		: base(null, null, null, default(XPathNodeType), matchSelf: false, abbrAxis: false)
	{
	}

	public override void Reset()
	{
	}

	public override XPathNavigator Advance()
	{
		return null;
	}

	private bool MoveToFirstChild()
	{
		return false;
	}

	private bool MoveUpUntilNext()
	{
		return false;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
