using System.Diagnostics;
using System.Reflection;

namespace System.Linq.Expressions;

/// <summary>Represents an expression that has a unary operator.</summary>
[DebuggerTypeProxy(typeof(UnaryExpressionProxy))]
public sealed class UnaryExpression : Expression
{
	/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
	/// <returns>The <see cref="P:System.Linq.Expressions.UnaryExpression.Type" /> that represents the static type of the expression.</returns>
	public sealed override Type Type { get; }

	/// <summary>Returns the node type of this <see cref="T:System.Linq.Expressions.Expression" />.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> that represents this expression.</returns>
	public sealed override ExpressionType NodeType { get; }

	/// <summary>Gets the operand of the unary operation.</summary>
	/// <returns>An <see cref="T:System.Linq.Expressions.Expression" /> that represents the operand of the unary operation.</returns>
	public Expression Operand { get; }

	/// <summary>Gets the implementing method for the unary operation.</summary>
	/// <returns>The <see cref="T:System.Reflection.MethodInfo" /> that represents the implementing method.</returns>
	public MethodInfo Method { get; }

	/// <summary>Gets a value that indicates whether the expression tree node represents a lifted call to an operator.</summary>
	/// <returns>
	///     <see langword="true" /> if the node represents a lifted call; otherwise, <see langword="false" />.</returns>
	public bool IsLifted => false;

	/// <summary>Gets a value that indicates whether the expression tree node represents a lifted call to an operator whose return type is lifted to a nullable type.</summary>
	/// <returns>
	///     <see langword="true" /> if the operator's return type is lifted to a nullable type; otherwise, <see langword="false" />.</returns>
	public bool IsLiftedToNull => false;

	/// <summary>Gets a value that indicates whether the expression tree node can be reduced.</summary>
	/// <returns>True if a node can be reduced, otherwise false.</returns>
	public override bool CanReduce => false;

	private bool IsPrefix => false;

	internal UnaryExpression(ExpressionType nodeType, Expression expression, Type type, MethodInfo method)
	{
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return null;
	}

	/// <summary>Reduces the expression node to a simpler expression. </summary>
	/// <returns>The reduced expression.</returns>
	public override Expression Reduce()
	{
		return null;
	}

	private UnaryExpression FunctionalOp(Expression operand)
	{
		return null;
	}

	private Expression ReduceVariable()
	{
		return null;
	}

	private Expression ReduceMember()
	{
		return null;
	}

	private Expression ReduceIndex()
	{
		return null;
	}

	/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
	/// <param name="operand">The <see cref="P:System.Linq.Expressions.UnaryExpression.Operand" /> property of the result.</param>
	/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
	public UnaryExpression Update(Expression operand)
	{
		return null;
	}
}
