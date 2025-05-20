namespace System.Linq.Expressions;

/// <summary>Represents assignment operation for a field or property of an object.</summary>
public sealed class MemberAssignment : MemberBinding
{
	private readonly Expression _expression;

	/// <summary>Gets the expression to assign to the field or property.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> that represents the value to assign to the field or property.</returns>
	public Expression Expression => null;
}
