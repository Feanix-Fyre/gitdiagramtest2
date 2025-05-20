using System.Collections.ObjectModel;

namespace System.Linq.Expressions;

internal static class ExpressionCreator<TDelegate>
{
	public static LambdaExpression CreateExpressionFunc(Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters)
	{
		return null;
	}
}
