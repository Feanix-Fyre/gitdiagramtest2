using System.Reflection;

namespace System.Linq.Expressions;

internal sealed class PropertyExpression : MemberExpression
{
	private readonly PropertyInfo _property;

	public sealed override Type Type => null;

	public PropertyExpression(Expression expression, PropertyInfo member)
		: base(null)
	{
	}

	internal override MemberInfo GetMember()
	{
		return null;
	}
}
