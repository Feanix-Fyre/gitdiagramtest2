using System.Diagnostics;

namespace System.Linq.Expressions;

/// <summary>Represents an operation between an expression and a type.</summary>
[DebuggerTypeProxy(typeof(TypeBinaryExpressionProxy))]
public sealed class TypeBinaryExpression : Expression
{
	/// <summary>Gets the static type of the expression that this <see cref="P:System.Linq.Expressions.TypeBinaryExpression.Expression" /> represents.</summary>
	/// <returns>The <see cref="P:System.Linq.Expressions.TypeBinaryExpression.Type" /> that represents the static type of the expression.</returns>
	public sealed override Type Type => null;

	/// <summary>Returns the node type of this Expression. Extension nodes should return <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> when overriding this method.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> of the expression.</returns>
	public sealed override ExpressionType NodeType { get; }

	/// <summary>Gets the expression operand of a type test operation.</summary>
	/// <returns>An <see cref="T:System.Linq.Expressions.Expression" /> that represents the expression operand of a type test operation.</returns>
	public Expression Expression { get; }

	/// <summary>Gets the type operand of a type test operation.</summary>
	/// <returns>A <see cref="T:System.Type" /> that represents the type operand of a type test operation.</returns>
	public Type TypeOperand { get; }

	internal TypeBinaryExpression(Expression expression, Type typeOperand, ExpressionType nodeType)
	{
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return null;
	}

	/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
	/// <param name="expression">The <see cref="P:System.Linq.Expressions.TypeBinaryExpression.Expression" /> property of the result.</param>
	/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
	public TypeBinaryExpression Update(Expression expression)
	{
		return null;
	}
}
