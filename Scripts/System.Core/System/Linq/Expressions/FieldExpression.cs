using System.Reflection;

namespace System.Linq.Expressions;

internal sealed class FieldExpression : MemberExpression
{
	private readonly FieldInfo _field;

	public sealed override Type Type => null;

	public FieldExpression(Expression expression, FieldInfo member)
		: base(null)
	{
	}

	internal override MemberInfo GetMember()
	{
		return null;
	}
}
