using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions;

internal class ScopeN : ScopeExpression
{
	private IReadOnlyList<Expression> _body;

	protected IReadOnlyList<Expression> Body => null;

	internal override int ExpressionCount => 0;

	internal ScopeN(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body)
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
