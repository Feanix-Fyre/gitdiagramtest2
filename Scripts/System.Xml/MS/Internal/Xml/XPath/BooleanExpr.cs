using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

internal sealed class BooleanExpr : ValueQuery
{
	private Query _opnd1;

	private Query _opnd2;

	private bool _isOr;

	public override XPathResultType StaticType => default(XPathResultType);

	public BooleanExpr(Operator.Op op, Query opnd1, Query opnd2)
	{
	}

	private BooleanExpr(BooleanExpr other)
	{
	}

	public override void SetXsltContext(XsltContext context)
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
