using System.Reflection;

namespace System.Linq.Expressions;

internal class MethodBinaryExpression : SimpleBinaryExpression
{
	private readonly MethodInfo _method;

	internal MethodBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method)
		: base(default(ExpressionType), null, null, null)
	{
	}

	internal override MethodInfo GetMethod()
	{
		return null;
	}
}
