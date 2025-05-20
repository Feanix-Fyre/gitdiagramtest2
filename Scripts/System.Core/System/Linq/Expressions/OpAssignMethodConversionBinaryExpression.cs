using System.Reflection;

namespace System.Linq.Expressions;

internal sealed class OpAssignMethodConversionBinaryExpression : MethodBinaryExpression
{
	private readonly LambdaExpression _conversion;

	internal OpAssignMethodConversionBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method, LambdaExpression conversion)
		: base(default(ExpressionType), null, null, null, null)
	{
	}

	internal override LambdaExpression GetConversion()
	{
		return null;
	}
}
