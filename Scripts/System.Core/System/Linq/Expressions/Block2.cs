using System.Collections.ObjectModel;

namespace System.Linq.Expressions;

internal sealed class Block2 : BlockExpression
{
	private object _arg0;

	private readonly Expression _arg1;

	internal override int ExpressionCount => 0;

	internal Block2(Expression arg0, Expression arg1)
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
