using System.Diagnostics;
using System.Reflection;

namespace System.Linq.Expressions;

/// <summary>Represents an expression that has a binary operator.</summary>
[DebuggerTypeProxy(typeof(BinaryExpressionProxy))]
public class BinaryExpression : Expression
{
	/// <summary>Gets a value that indicates whether the expression tree node can be reduced.</summary>
	/// <returns>True if the expression tree node can be reduced, otherwise false.</returns>
	public override bool CanReduce => false;

	/// <summary>Gets the right operand of the binary operation.</summary>
	/// <returns>An <see cref="T:System.Linq.Expressions.Expression" /> that represents the right operand of the binary operation.</returns>
	public Expression Right { get; }

	/// <summary>Gets the left operand of the binary operation.</summary>
	/// <returns>An <see cref="T:System.Linq.Expressions.Expression" /> that represents the left operand of the binary operation.</returns>
	public Expression Left { get; }

	/// <summary>Gets the implementing method for the binary operation.</summary>
	/// <returns>The <see cref="T:System.Reflection.MethodInfo" /> that represents the implementing method.</returns>
	public MethodInfo Method => null;

	/// <summary>Gets the type conversion function that is used by a coalescing or compound assignment operation.</summary>
	/// <returns>A <see cref="T:System.Linq.Expressions.LambdaExpression" /> that represents a type conversion function.</returns>
	public LambdaExpression Conversion => null;

	/// <summary>Gets a value that indicates whether the expression tree node represents a lifted call to an operator.</summary>
	/// <returns>
	///     <see langword="true" /> if the node represents a lifted call; otherwise, <see langword="false" />.</returns>
	public bool IsLifted => false;

	/// <summary>Gets a value that indicates whether the expression tree node represents a lifted call to an operator whose return type is lifted to a nullable type.</summary>
	/// <returns>
	///     <see langword="true" /> if the operator's return type is lifted to a nullable type; otherwise, <see langword="false" />.</returns>
	public bool IsLiftedToNull => false;

	internal bool IsLiftedLogical => false;

	internal bool IsReferenceComparison => false;

	internal BinaryExpression(Expression left, Expression right)
	{
	}

	private static bool IsOpAssignment(ExpressionType op)
	{
		return false;
	}

	internal virtual MethodInfo GetMethod()
	{
		return null;
	}

	/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
	/// <param name="left">The <see cref="P:System.Linq.Expressions.BinaryExpression.Left" /> property of the result. </param>
	/// <param name="conversion">The <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion" /> property of the result.</param>
	/// <param name="right">The <see cref="P:System.Linq.Expressions.BinaryExpression.Right" /> property of the result. </param>
	/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
	public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right)
	{
		return null;
	}

	/// <summary>Reduces the binary expression node to a simpler expression.</summary>
	/// <returns>The reduced expression.</returns>
	public override Expression Reduce()
	{
		return null;
	}

	private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op)
	{
		return default(ExpressionType);
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

	internal virtual LambdaExpression GetConversion()
	{
		return null;
	}

	/// <summary>Dispatches to the specific visit method for this node type. For example, <see cref="T:System.Linq.Expressions.MethodCallExpression" /> calls the <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)" />.</summary>
	/// <param name="visitor">The visitor to visit this node with.</param>
	/// <returns>The result of visiting this node.</returns>
	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return null;
	}

	internal Expression ReduceUserdefinedLifted()
	{
		return null;
	}
}
