using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

internal sealed class LogicalExpr : ValueQuery
{
	private delegate bool cmpXslt(Operator.Op op, object val1, object val2);

	private struct NodeSet
	{
		private Query _opnd;

		private XPathNavigator _current;

		public string Value => null;

		public NodeSet(object opnd)
		{
			_opnd = null;
			_current = null;
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	private Operator.Op _op;

	private Query _opnd1;

	private Query _opnd2;

	private static readonly cmpXslt[][] s_CompXsltE;

	private static readonly cmpXslt[][] s_CompXsltO;

	public override XPathResultType StaticType => default(XPathResultType);

	public LogicalExpr(Operator.Op op, Query opnd1, Query opnd2)
	{
	}

	private LogicalExpr(LogicalExpr other)
	{
	}

	public override void SetXsltContext(XsltContext context)
	{
	}

	public override object Evaluate(XPathNodeIterator nodeIterator)
	{
		return null;
	}

	private static bool cmpQueryQueryE(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpQueryQueryO(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpQueryNumber(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpQueryStringE(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpQueryStringO(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpRtfQueryE(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpRtfQueryO(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpQueryBoolE(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpQueryBoolO(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpBoolBoolE(Operator.Op op, bool n1, bool n2)
	{
		return false;
	}

	private static bool cmpBoolBoolE(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpBoolBoolO(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpBoolNumberE(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpBoolNumberO(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpBoolStringE(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpRtfBoolE(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpBoolStringO(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpRtfBoolO(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpNumberNumber(Operator.Op op, double n1, double n2)
	{
		return false;
	}

	private static bool cmpNumberNumberO(Operator.Op op, double n1, double n2)
	{
		return false;
	}

	private static bool cmpNumberNumber(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpStringNumber(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpRtfNumber(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpStringStringE(Operator.Op op, string n1, string n2)
	{
		return false;
	}

	private static bool cmpStringStringE(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpRtfStringE(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpRtfRtfE(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpStringStringO(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpRtfStringO(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	private static bool cmpRtfRtfO(Operator.Op op, object val1, object val2)
	{
		return false;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}

	private static string Rtf(object o)
	{
		return null;
	}
}
