using System.Collections.Generic;

namespace System.Linq.Expressions;

internal sealed class InvocationExpressionN : InvocationExpression
{
	private IReadOnlyList<Expression> _arguments;

	public override int ArgumentCount => 0;

	public InvocationExpressionN(Expression lambda, IReadOnlyList<Expression> arguments, Type returnType)
		: base(null, null)
	{
	}

	public override Expression GetArgument(int index)
	{
		return null;
	}

	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
	{
		return null;
	}
}
