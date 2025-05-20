namespace System.Linq.Expressions;

internal sealed class Expression0<TDelegate> : Expression<TDelegate>
{
	internal override int ParameterCount => 0;

	public Expression0(Expression body)
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
