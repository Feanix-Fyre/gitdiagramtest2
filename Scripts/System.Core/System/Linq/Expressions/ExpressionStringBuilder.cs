using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;

namespace System.Linq.Expressions;

internal sealed class ExpressionStringBuilder : ExpressionVisitor
{
	private readonly StringBuilder _out;

	private Dictionary<object, int> _ids;

	private ExpressionStringBuilder()
	{
	}

	public override string ToString()
	{
		return null;
	}

	private int GetLabelId(LabelTarget label)
	{
		return 0;
	}

	private int GetParamId(ParameterExpression p)
	{
		return 0;
	}

	private int GetId(object o)
	{
		return 0;
	}

	private void Out(string s)
	{
	}

	private void Out(char c)
	{
	}

	internal static string ExpressionToString(Expression node)
	{
		return null;
	}

	internal static string CatchBlockToString(CatchBlock node)
	{
		return null;
	}

	private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close) where T : Expression
	{
	}

	private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close, string seperator) where T : Expression
	{
	}

	protected internal override Expression VisitBinary(BinaryExpression node)
	{
		return null;
	}

	protected internal override Expression VisitParameter(ParameterExpression node)
	{
		return null;
	}

	protected internal override Expression VisitLambda<T>(Expression<T> node)
	{
		return null;
	}

	protected internal override Expression VisitConditional(ConditionalExpression node)
	{
		return null;
	}

	protected internal override Expression VisitConstant(ConstantExpression node)
	{
		return null;
	}

	private void OutMember(Expression instance, MemberInfo member)
	{
	}

	protected internal override Expression VisitMember(MemberExpression node)
	{
		return null;
	}

	protected internal override Expression VisitInvocation(InvocationExpression node)
	{
		return null;
	}

	protected internal override Expression VisitMethodCall(MethodCallExpression node)
	{
		return null;
	}

	protected internal override Expression VisitNewArray(NewArrayExpression node)
	{
		return null;
	}

	protected internal override Expression VisitTypeBinary(TypeBinaryExpression node)
	{
		return null;
	}

	protected internal override Expression VisitUnary(UnaryExpression node)
	{
		return null;
	}

	protected internal override Expression VisitBlock(BlockExpression node)
	{
		return null;
	}

	protected internal override Expression VisitDefault(DefaultExpression node)
	{
		return null;
	}

	protected internal override Expression VisitLabel(LabelExpression node)
	{
		return null;
	}

	protected internal override Expression VisitGoto(GotoExpression node)
	{
		return null;
	}

	protected internal override Expression VisitLoop(LoopExpression node)
	{
		return null;
	}

	protected override CatchBlock VisitCatchBlock(CatchBlock node)
	{
		return null;
	}

	protected internal override Expression VisitTry(TryExpression node)
	{
		return null;
	}

	protected internal override Expression VisitIndex(IndexExpression node)
	{
		return null;
	}

	protected internal override Expression VisitExtension(Expression node)
	{
		return null;
	}

	private void DumpLabel(LabelTarget target)
	{
	}

	private static bool IsBool(Expression node)
	{
		return false;
	}
}
