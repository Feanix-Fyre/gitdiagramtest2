using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

internal sealed class NodeFunctions : ValueQuery
{
	private Query _arg;

	private Function.FunctionType _funcType;

	private XsltContext _xsltContext;

	public override XPathResultType StaticType => default(XPathResultType);

	public NodeFunctions(Function.FunctionType funcType, Query arg)
	{
	}

	public override void SetXsltContext(XsltContext context)
	{
	}

	private XPathNavigator EvaluateArg(XPathNodeIterator context)
	{
		return null;
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
