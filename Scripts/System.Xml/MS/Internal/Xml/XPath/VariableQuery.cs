using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

internal sealed class VariableQuery : ExtensionQuery
{
	private IXsltContextVariable _variable;

	public override XPathResultType StaticType => default(XPathResultType);

	public VariableQuery(string name, string prefix)
		: base(null, null)
	{
	}

	private VariableQuery(VariableQuery other)
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
