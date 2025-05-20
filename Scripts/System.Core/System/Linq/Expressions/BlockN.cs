using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions;

internal class BlockN : BlockExpression
{
	private IReadOnlyList<Expression> _expressions;

	internal override int ExpressionCount => 0;

	internal BlockN(IReadOnlyList<Expression> expressions)
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
