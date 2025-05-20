using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class GroupQuery : BaseAxisQuery
{
	public override XPathResultType StaticType => default(XPathResultType);

	public override QueryProps Properties => default(QueryProps);

	public GroupQuery(Query qy)
		: base((Query)null)
	{
	}

	private GroupQuery(GroupQuery other)
		: base((Query)null)
	{
	}

	public override XPathNavigator Advance()
	{
		return null;
	}

	public override object Evaluate(XPathNodeIterator nodeIterator)
	{
		return null;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
