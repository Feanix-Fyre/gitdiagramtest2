using System.Collections.Generic;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class PreSiblingQuery : CacheAxisQuery
{
	public override QueryProps Properties => default(QueryProps);

	public PreSiblingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest)
		: base(null, null, null, default(XPathNodeType))
	{
	}

	protected PreSiblingQuery(PreSiblingQuery other)
		: base(null, null, null, default(XPathNodeType))
	{
	}

	private static bool NotVisited(XPathNavigator nav, List<XPathNavigator> parentStk)
	{
		return false;
	}

	public override object Evaluate(XPathNodeIterator context)
	{
		return null;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
