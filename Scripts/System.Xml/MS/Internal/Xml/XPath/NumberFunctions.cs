using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

internal sealed class NumberFunctions : ValueQuery
{
	private Query _arg;

	private Function.FunctionType _ftype;

	public override XPathResultType StaticType => default(XPathResultType);

	public NumberFunctions(Function.FunctionType ftype, Query arg)
	{
	}

	private NumberFunctions(NumberFunctions other)
	{
	}

	public override void SetXsltContext(XsltContext context)
	{
	}

	internal static double Number(bool arg)
	{
		return 0.0;
	}

	internal static double Number(string arg)
	{
		return 0.0;
	}

	public override object Evaluate(XPathNodeIterator nodeIterator)
	{
		return null;
	}

	private double Number(XPathNodeIterator nodeIterator)
	{
		return 0.0;
	}

	private double Sum(XPathNodeIterator nodeIterator)
	{
		return 0.0;
	}

	private double Floor(XPathNodeIterator nodeIterator)
	{
		return 0.0;
	}

	private double Ceiling(XPathNodeIterator nodeIterator)
	{
		return 0.0;
	}

	private double Round(XPathNodeIterator nodeIterator)
	{
		return 0.0;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
