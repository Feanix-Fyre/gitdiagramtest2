using System.Linq.Expressions;

namespace System.Dynamic.Utils;

internal static class ExpressionVisitorUtils
{
	public static Expression[] VisitBlockExpressions(ExpressionVisitor visitor, BlockExpression block)
	{
		return null;
	}

	public static ParameterExpression[] VisitParameters(ExpressionVisitor visitor, IParameterProvider nodes, string callerName)
	{
		return null;
	}

	public static Expression[] VisitArguments(ExpressionVisitor visitor, IArgumentProvider nodes)
	{
		return null;
	}
}
