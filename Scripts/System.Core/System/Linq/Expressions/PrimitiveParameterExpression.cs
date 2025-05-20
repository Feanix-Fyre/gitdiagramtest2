namespace System.Linq.Expressions;

internal sealed class PrimitiveParameterExpression<T> : ParameterExpression
{
	public sealed override Type Type => null;

	internal PrimitiveParameterExpression(string name)
		: base(null)
	{
	}
}
