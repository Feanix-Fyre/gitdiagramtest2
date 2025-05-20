namespace System.Linq.Expressions;

internal sealed class InvocationExpression2 : InvocationExpression
{
	private object _arg0;

	private readonly Expression _arg1;

	public override int ArgumentCount => 0;

	public InvocationExpression2(Expression lambda, Type returnType, Expression arg0, Expression arg1)
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
