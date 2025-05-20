namespace System.Linq.Expressions;

internal sealed class InvocationExpression0 : InvocationExpression
{
	public override int ArgumentCount => 0;

	public InvocationExpression0(Expression lambda, Type returnType)
		: base(null, null)
	{
	}

	public override Expression GetArgument(int index)
	{
		return null;
	}

	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
	{
		return null;
	}
}
