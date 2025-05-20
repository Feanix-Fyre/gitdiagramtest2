using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Dynamic.Utils;

internal static class ExpressionUtils
{
	public static ReadOnlyCollection<T> ReturnReadOnly<T>(ref IReadOnlyList<T> collection)
	{
		return null;
	}

	public static T ReturnObject<T>(object collectionOrT) where T : class
	{
		return null;
	}

	public static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName)
	{
	}

	public static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis)
	{
	}

	public static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arguments, ParameterInfo pi, string methodParamName, string argumentParamName, int index = -1)
	{
		return null;
	}

	public static void RequiresCanRead(Expression expression, string paramName)
	{
	}

	public static void RequiresCanRead(Expression expression, string paramName, int idx)
	{
	}

	public static bool TryQuote(Type parameterType, ref Expression argument)
	{
		return false;
	}

	internal static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind)
	{
		return null;
	}

	internal static bool SameElements<T>(ref IEnumerable<T> replacement, IReadOnlyList<T> current) where T : class
	{
		return false;
	}

	private static bool SameElementsInCollection<T>(ICollection<T> replacement, IReadOnlyList<T> current) where T : class
	{
		return false;
	}

	public static void ValidateArgumentCount(this LambdaExpression lambda)
	{
	}
}
