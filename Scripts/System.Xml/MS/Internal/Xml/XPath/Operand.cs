using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class Operand : AstNode
{
	private XPathResultType _type;

	private object _val;

	public override AstType Type => default(AstType);

	public override XPathResultType ReturnType => default(XPathResultType);

	public object OperandValue => null;

	public Operand(string val)
	{
	}

	public Operand(double val)
	{
	}
}
