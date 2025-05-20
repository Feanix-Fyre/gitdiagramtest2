namespace System.Linq.Expressions;

internal sealed class ByRefParameterExpression : TypedParameterExpression
{
	internal ByRefParameterExpression(Type type, string name)
		: base(null, null)
	{
	}

	internal override bool GetIsByRef()
	{
		return false;
	}
}
