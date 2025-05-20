using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class Operator : AstNode
{
	public enum Op
	{
		INVALID = 0,
		OR = 1,
		AND = 2,
		EQ = 3,
		NE = 4,
		LT = 5,
		LE = 6,
		GT = 7,
		GE = 8,
		PLUS = 9,
		MINUS = 10,
		MUL = 11,
		DIV = 12,
		MOD = 13,
		UNION = 14
	}

	private static Op[] s_invertOp;

	private Op _opType;

	private AstNode _opnd1;

	private AstNode _opnd2;

	public override AstType Type => default(AstType);

	public override XPathResultType ReturnType => default(XPathResultType);

	public Op OperatorType => default(Op);

	public AstNode Operand1 => null;

	public AstNode Operand2 => null;

	public static Op InvertOperator(Op op)
	{
		return default(Op);
	}

	public Operator(Op op, AstNode opnd1, AstNode opnd2)
	{
	}
}
