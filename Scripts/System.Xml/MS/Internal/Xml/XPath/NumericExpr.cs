using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

internal sealed class NumericExpr : ValueQuery
{
	private Operator.Op _op;

	private Query _opnd1;

	private Query _opnd2;

	public override XPathResultType StaticType => default(XPathResultType);

	public NumericExpr(Operator.Op op, Query opnd1, Query opnd2)
	{
	}

	private NumericExpr(NumericExpr other)
	{
	}

	public override void SetXsltContext(XsltContext context)
	{
	}

	public override object Evaluate(XPathNodeIterator nodeIterator)
	{
		return null;
	}

	private static double GetValue(Operator.Op op, double n1, double n2)
	{
		return 0.0;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
