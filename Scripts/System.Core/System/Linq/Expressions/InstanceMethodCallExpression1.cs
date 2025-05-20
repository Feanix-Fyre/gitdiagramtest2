using System.Collections.Generic;
using System.Reflection;

namespace System.Linq.Expressions;

internal sealed class InstanceMethodCallExpression1 : InstanceMethodCallExpression, IArgumentProvider
{
	private object _arg0;

	public override int ArgumentCount => 0;

	public InstanceMethodCallExpression1(MethodInfo method, Expression instance, Expression arg0)
		: base(null, null)
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
