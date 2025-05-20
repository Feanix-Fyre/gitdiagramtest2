using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

internal abstract class ExtensionQuery : Query
{
	protected string prefix;

	protected string name;

	protected XsltContext xsltContext;

	private ResetableIterator _queryIterator;

	public override XPathNavigator Current => null;

	public override int CurrentPosition => 0;

	protected string QName => null;

	public override int Count => 0;

	public override XPathResultType StaticType => default(XPathResultType);

	public ExtensionQuery(string prefix, string name)
	{
	}

	protected ExtensionQuery(ExtensionQuery other)
	{
	}

	public override void Reset()
	{
	}

	public override XPathNavigator Advance()
	{
		return null;
	}

	protected object ProcessResult(object value)
	{
		return null;
	}
}
