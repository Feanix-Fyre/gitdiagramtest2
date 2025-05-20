using System.Collections.Generic;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal abstract class CacheAxisQuery : BaseAxisQuery
{
	protected List<XPathNavigator> outputBuffer;

	public override XPathNavigator Current => null;

	public override int CurrentPosition => 0;

	public override int Count => 0;

	public override QueryProps Properties => default(QueryProps);

	public CacheAxisQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest)
		: base((Query)null)
	{
	}

	protected CacheAxisQuery(CacheAxisQuery other)
		: base((Query)null)
	{
	}

	public override void Reset()
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
