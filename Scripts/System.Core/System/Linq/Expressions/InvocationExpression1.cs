namespace System.Linq.Expressions;

internal sealed class InvocationExpression1 : InvocationExpression
{
	private object _arg0;

	public override int ArgumentCount => 0;

	public InvocationExpression1(Expression lambda, Type returnType, Expression arg0)
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
