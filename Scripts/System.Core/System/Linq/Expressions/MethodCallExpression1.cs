using System.Collections.Generic;
using System.Reflection;

namespace System.Linq.Expressions;

internal sealed class MethodCallExpression1 : MethodCallExpression, IArgumentProvider
{
	private object _arg0;

	public override int ArgumentCount => 0;

	public MethodCallExpression1(MethodInfo method, Expression arg0)
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
