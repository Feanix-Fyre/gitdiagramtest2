using System.Collections.Generic;
using System.Globalization;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

internal sealed class StringFunctions : ValueQuery
{
	private Function.FunctionType _funcType;

	private IList<Query> _argList;

	private static readonly CompareInfo s_compareInfo;

	public override XPathResultType StaticType => default(XPathResultType);

	public StringFunctions(Function.FunctionType funcType, IList<Query> argList)
	{
	}

	private StringFunctions(StringFunctions other)
	{
	}

	public override void SetXsltContext(XsltContext context)
	{
	}

	public override object Evaluate(XPathNodeIterator nodeIterator)
	{
		return null;
	}

	internal static string toString(double num)
	{
		return null;
	}

	internal static string toString(bool b)
	{
		return null;
	}

	private string toString(XPathNodeIterator nodeIterator)
	{
		return null;
	}

	private string Concat(XPathNodeIterator nodeIterator)
	{
		return null;
	}

	private bool StartsWith(XPathNodeIterator nodeIterator)
	{
		return false;
	}

	private bool Contains(XPathNodeIterator nodeIterator)
	{
		return false;
	}

	private string SubstringBefore(XPathNodeIterator nodeIterator)
	{
		return null;
	}

	private string SubstringAfter(XPathNodeIterator nodeIterator)
	{
		return null;
	}

	private string Substring(XPathNodeIterator nodeIterator)
	{
		return null;
	}

	private double StringLength(XPathNodeIterator nodeIterator)
	{
		return 0.0;
	}

	private string Normalize(XPathNodeIterator nodeIterator)
	{
		return null;
	}

	private string Translate(XPathNodeIterator nodeIterator)
	{
		return null;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
