using System.Collections.Generic;
using System.Reflection;

namespace System.Linq.Expressions;

internal sealed class InstanceMethodCallExpression2 : InstanceMethodCallExpression, IArgumentProvider
{
	private object _arg0;

	private readonly Expression _arg1;

	public override int ArgumentCount => 0;

	public InstanceMethodCallExpression2(MethodInfo method, Expression instance, Expression arg0, Expression arg1)
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
