using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

internal sealed class FilterQuery : BaseAxisQuery
{
	private Query _cond;

	private bool _noPosition;

	public Query Condition => null;

	public override QueryProps Properties => default(QueryProps);

	public FilterQuery(Query qyParent, Query cond, bool noPosition)
		: base((Query)null)
	{
	}

	private FilterQuery(FilterQuery other)
		: base((Query)null)
	{
	}

	public override void Reset()
	{
	}

	public override void SetXsltContext(XsltContext input)
	{
	}

	public override XPathNavigator Advance()
	{
		return null;
	}

	internal bool EvaluatePredicate()
	{
		return false;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
