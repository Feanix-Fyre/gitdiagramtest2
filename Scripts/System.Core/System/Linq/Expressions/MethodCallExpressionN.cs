using System.Collections.Generic;
using System.Reflection;

namespace System.Linq.Expressions;

internal sealed class MethodCallExpressionN : MethodCallExpression, IArgumentProvider
{
	private IReadOnlyList<Expression> _arguments;

	public override int ArgumentCount => 0;

	public MethodCallExpressionN(MethodInfo method, IReadOnlyList<Expression> args)
		: base(null)
	{
	}

	public override Expression GetArgument(int index)
	{
		return null;
	}

	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args)
	{
		return null;
	}
}
