namespace System.Linq.Expressions;

internal sealed class Expression1<TDelegate> : Expression<TDelegate>
{
	private object _par0;

	internal override int ParameterCount => 0;

	public Expression1(Expression body, ParameterExpression par0)
		: base((Expression)null)
	{
	}

	internal override ParameterExpression GetParameter(int index)
	{
		return null;
	}

	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
	{
		return null;
	}
}
