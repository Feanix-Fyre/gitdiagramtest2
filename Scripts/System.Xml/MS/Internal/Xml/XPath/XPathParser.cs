using System.Collections.Generic;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class XPathParser
{
	private class ParamInfo
	{
		private Function.FunctionType _ftype;

		private int _minargs;

		private int _maxargs;

		private XPathResultType[] _argTypes;

		public Function.FunctionType FType => default(Function.FunctionType);

		public int Minargs => 0;

		public int Maxargs => 0;

		public XPathResultType[] ArgTypes => null;

		internal ParamInfo(Function.FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes)
		{
		}
	}

	private XPathScanner _scanner;

	private int _parseDepth;

	private static readonly XPathResultType[] s_temparray1;

	private static readonly XPathResultType[] s_temparray2;

	private static readonly XPathResultType[] s_temparray3;

	private static readonly XPathResultType[] s_temparray4;

	private static readonly XPathResultType[] s_temparray5;

	private static readonly XPathResultType[] s_temparray6;

	private static readonly XPathResultType[] s_temparray7;

	private static readonly XPathResultType[] s_temparray8;

	private static readonly XPathResultType[] s_temparray9;

	private static Dictionary<string, ParamInfo> s_functionTable;

	private static Dictionary<string, Axis.AxisType> s_AxesTable;

	private XPathParser(XPathScanner scanner)
	{
	}

	public static AstNode ParseXPathExpression(string xpathExpression)
	{
		return null;
	}

	private AstNode ParseExpression(AstNode qyInput)
	{
		return null;
	}

	private AstNode ParseOrExpr(AstNode qyInput)
	{
		return null;
	}

	private AstNode ParseAndExpr(AstNode qyInput)
	{
		return null;
	}

	private AstNode ParseEqualityExpr(AstNode qyInput)
	{
		return null;
	}

	private AstNode ParseRelationalExpr(AstNode qyInput)
	{
		return null;
	}

	private AstNode ParseAdditiveExpr(AstNode qyInput)
	{
		return null;
	}

	private AstNode ParseMultiplicativeExpr(AstNode qyInput)
	{
		return null;
	}

	private AstNode ParseUnaryExpr(AstNode qyInput)
	{
		return null;
	}

	private AstNode ParseUnionExpr(AstNode qyInput)
	{
		return null;
	}

	private static bool IsNodeType(XPathScanner scaner)
	{
		return false;
	}

	private AstNode ParsePathExpr(AstNode qyInput)
	{
		return null;
	}

	private AstNode ParseFilterExpr(AstNode qyInput)
	{
		return null;
	}

	private AstNode ParsePredicate(AstNode qyInput)
	{
		return null;
	}

	private AstNode ParseLocationPath(AstNode qyInput)
	{
		return null;
	}

	private AstNode ParseRelativeLocationPath(AstNode qyInput)
	{
		return null;
	}

	private static bool IsStep(XPathScanner.LexKind lexKind)
	{
		return false;
	}

	private AstNode ParseStep(AstNode qyInput)
	{
		return null;
	}

	private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType)
	{
		return null;
	}

	private static bool IsPrimaryExpr(XPathScanner scanner)
	{
		return false;
	}

	private AstNode ParsePrimaryExpr(AstNode qyInput)
	{
		return null;
	}

	private AstNode ParseMethod(AstNode qyInput)
	{
		return null;
	}

	private void CheckToken(XPathScanner.LexKind t)
	{
	}

	private void PassToken(XPathScanner.LexKind t)
	{
	}

	private void NextLex()
	{
	}

	private bool TestOp(string op)
	{
		return false;
	}

	private void CheckNodeSet(XPathResultType t)
	{
	}

	private static Dictionary<string, ParamInfo> CreateFunctionTable()
	{
		return null;
	}

	private static Dictionary<string, Axis.AxisType> CreateAxesTable()
	{
		return null;
	}

	private Axis.AxisType GetAxis()
	{
		return default(Axis.AxisType);
	}
}
