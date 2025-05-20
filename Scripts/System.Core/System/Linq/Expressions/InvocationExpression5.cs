namespace System.Linq.Expressions;

internal sealed class InvocationExpression5 : InvocationExpression
{
	private object _arg0;

	private readonly Expression _arg1;

	private readonly Expression _arg2;

	private readonly Expression _arg3;

	private readonly Expression _arg4;

	public override int ArgumentCount => 0;

	public InvocationExpression5(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
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
