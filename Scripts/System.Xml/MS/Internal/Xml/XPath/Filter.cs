using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class Filter : AstNode
{
	private AstNode _input;

	private AstNode _condition;

	public override AstType Type => default(AstType);

	public override XPathResultType ReturnType => default(XPathResultType);

	public AstNode Input => null;

	public AstNode Condition => null;

	public Filter(AstNode input, AstNode condition)
	{
	}
}
