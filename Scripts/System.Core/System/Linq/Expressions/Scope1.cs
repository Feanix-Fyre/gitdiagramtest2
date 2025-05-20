using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions;

internal sealed class Scope1 : ScopeExpression
{
	private object _body;

	internal override int ExpressionCount => 0;

	internal Scope1(IReadOnlyList<ParameterExpression> variables, Expression body)
		: base(null)
	{
	}

	private Scope1(IReadOnlyList<ParameterExpression> variables, object body)
		: base(null)
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
