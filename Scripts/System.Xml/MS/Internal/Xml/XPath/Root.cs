using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class Root : AstNode
{
	public override AstType Type => default(AstType);

	public override XPathResultType ReturnType => default(XPathResultType);
}
