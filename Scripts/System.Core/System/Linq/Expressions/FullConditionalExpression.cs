namespace System.Linq.Expressions;

internal class FullConditionalExpression : ConditionalExpression
{
	private readonly Expression _false;

	internal FullConditionalExpression(Expression test, Expression ifTrue, Expression ifFalse)
		: base(null, null)
	{
	}

	internal override Expression GetFalse()
	{
		return null;
	}
}
