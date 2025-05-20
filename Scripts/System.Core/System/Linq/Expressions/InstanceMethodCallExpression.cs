using System.Reflection;

namespace System.Linq.Expressions;

internal class InstanceMethodCallExpression : MethodCallExpression, IArgumentProvider
{
	private readonly Expression _instance;

	public InstanceMethodCallExpression(MethodInfo method, Expression instance)
		: base(null)
	{
	}

	internal override Expression GetInstance()
	{
		return null;
	}
}
