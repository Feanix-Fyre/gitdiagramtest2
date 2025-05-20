namespace System.Linq.Expressions;

internal sealed class CoalesceConversionBinaryExpression : BinaryExpression
{
	private readonly LambdaExpression _conversion;

	public sealed override ExpressionType NodeType => default(ExpressionType);

	public sealed override Type Type => null;

	internal CoalesceConversionBinaryExpression(Expression left, Expression right, LambdaExpression conversion)
		: base(null, null)
	{
	}

	internal override LambdaExpression GetConversion()
	{
		return null;
	}
}
