using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

internal sealed class UnionExpr : Query
{
	internal Query qy1;

	internal Query qy2;

	private bool _advance1;

	private bool _advance2;

	private XPathNavigator _currentNode;

	private XPathNavigator _nextNode;

	public override XPathResultType StaticType => default(XPathResultType);

	public override XPathNavigator Current => null;

	public override int CurrentPosition => 0;

	public UnionExpr(Query query1, Query query2)
	{
	}

	private UnionExpr(UnionExpr other)
	{
	}

	public override void Reset()
	{
	}

	public override void SetXsltContext(XsltContext xsltContext)
	{
	}

	public override object Evaluate(XPathNodeIterator context)
	{
		return null;
	}

	private XPathNavigator ProcessSamePosition(XPathNavigator result)
	{
		return null;
	}

	private XPathNavigator ProcessBeforePosition(XPathNavigator res1, XPathNavigator res2)
	{
		return null;
	}

	private XPathNavigator ProcessAfterPosition(XPathNavigator res1, XPathNavigator res2)
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
