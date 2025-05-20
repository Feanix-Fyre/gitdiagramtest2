using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

internal sealed class MergeFilterQuery : CacheOutputQuery
{
	private Query _child;

	public MergeFilterQuery(Query input, Query child)
		: base((Query)null)
	{
	}

	private MergeFilterQuery(MergeFilterQuery other)
		: base((Query)null)
	{
	}

	public override void SetXsltContext(XsltContext xsltContext)
	{
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
