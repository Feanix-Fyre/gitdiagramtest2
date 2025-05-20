using System.Collections.Generic;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

internal sealed class FunctionQuery : ExtensionQuery
{
	private IList<Query> _args;

	private IXsltContextFunction _function;

	public override XPathResultType StaticType => default(XPathResultType);

	public FunctionQuery(string prefix, string name, List<Query> args)
		: base(null, null)
	{
	}

	private FunctionQuery(FunctionQuery other)
		: base(null, null)
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
