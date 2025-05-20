using System.Collections.Generic;
using System.Reflection;

namespace System.Linq.Expressions;

internal sealed class MethodCallExpression0 : MethodCallExpression, IArgumentProvider
{
	public override int ArgumentCount => 0;

	public MethodCallExpression0(MethodInfo method)
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
