namespace System.Linq.Expressions;

internal sealed class Expression3<TDelegate> : Expression<TDelegate>
{
	private object _par0;

	private readonly ParameterExpression _par1;

	private readonly ParameterExpression _par2;

	internal override int ParameterCount => 0;

	public Expression3(Expression body, ParameterExpression par0, ParameterExpression par1, ParameterExpression par2)
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
