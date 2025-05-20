using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class Variable : AstNode
{
	private string _localname;

	private string _prefix;

	public override AstType Type => default(AstType);

	public override XPathResultType ReturnType => default(XPathResultType);

	public string Localname => null;

	public string Prefix => null;

	public Variable(string name, string prefix)
	{
	}
}
