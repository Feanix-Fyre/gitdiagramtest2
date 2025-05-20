namespace System.Linq.Expressions;

internal sealed class LogicalBinaryExpression : BinaryExpression
{
	public sealed override Type Type => null;

	public sealed override ExpressionType NodeType { get; }

	internal LogicalBinaryExpression(ExpressionType nodeType, Expression left, Expression right)
		: base(null, null)
	{
	}
}
