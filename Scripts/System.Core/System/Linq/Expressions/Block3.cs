using System.Collections.ObjectModel;

namespace System.Linq.Expressions;

internal sealed class Block3 : BlockExpression
{
	private object _arg0;

	private readonly Expression _arg1;

	private readonly Expression _arg2;

	internal override int ExpressionCount => 0;

	internal Block3(Expression arg0, Expression arg1, Expression arg2)
	{
	}

	internal override Expression GetExpression(int index)
	{
		return null;
	}

	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
	{
		return null;
	}

	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
	{
		return null;
	}
}
