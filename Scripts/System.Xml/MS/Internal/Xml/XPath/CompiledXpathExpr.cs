using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

internal class CompiledXpathExpr : XPathExpression
{
	private class UndefinedXsltContext : XsltContext
	{
		private IXmlNamespaceResolver _nsResolver;

		public override string DefaultNamespace => null;

		public override bool Whitespace => false;

		public UndefinedXsltContext(IXmlNamespaceResolver nsResolver)
			: base(dummy: false)
		{
		}

		public override string LookupNamespace(string prefix)
		{
			return null;
		}

		public override IXsltContextVariable ResolveVariable(string prefix, string name)
		{
			return null;
		}

		public override IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes)
		{
			return null;
		}

		public override bool PreserveWhitespace(XPathNavigator node)
		{
			return false;
		}
	}

	private Query _query;

	private string _expr;

	private bool _needContext;

	internal Query QueryTree => null;

	internal CompiledXpathExpr(Query query, string expression, bool needContext)
	{
	}

	public override void SetContext(IXmlNamespaceResolver nsResolver)
	{
	}
}
