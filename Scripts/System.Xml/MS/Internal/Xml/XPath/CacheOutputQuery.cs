using System.Collections.Generic;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

internal abstract class CacheOutputQuery : Query
{
	internal Query input;

	protected List<XPathNavigator> outputBuffer;

	public override XPathNavigator Current => null;

	public override XPathResultType StaticType => default(XPathResultType);

	public override int CurrentPosition => 0;

	public override int Count => 0;

	public override QueryProps Properties => default(QueryProps);

	public CacheOutputQuery(Query input)
	{
	}

	protected CacheOutputQuery(CacheOutputQuery other)
	{
	}

	public override void Reset()
	{
	}

	public override void SetXsltContext(XsltContext context)
	{
	}

	public override object Evaluate(XPathNodeIterator context)
	{
		return null;
	}

	public override XPathNavigator Advance()
	{
		return null;
	}
}
