using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class Group : AstNode
{
	private AstNode _groupNode;

	public override AstType Type => default(AstType);

	public override XPathResultType ReturnType => default(XPathResultType);

	public AstNode GroupNode => null;

	public Group(AstNode groupNode)
	{
	}
}
