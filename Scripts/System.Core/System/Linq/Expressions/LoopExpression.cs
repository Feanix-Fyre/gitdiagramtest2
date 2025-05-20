using System.Diagnostics;

namespace System.Linq.Expressions;

/// <summary>Represents an infinite loop. It can be exited with "break".</summary>
[DebuggerTypeProxy(typeof(LoopExpressionProxy))]
public sealed class LoopExpression : Expression
{
	/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
	/// <returns>The <see cref="P:System.Linq.Expressions.LoopExpression.Type" /> that represents the static type of the expression.</returns>
	public sealed override Type Type => null;

	/// <summary>Returns the node type of this expression. Extension nodes should return <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> when overriding this method.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> of the expression.</returns>
	public sealed override ExpressionType NodeType => default(ExpressionType);

	/// <summary>Gets the <see cref="T:System.Linq.Expressions.Expression" /> that is the body of the loop.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> that is the body of the loop.</returns>
	public Expression Body { get; }

	/// <summary>Gets the <see cref="T:System.Linq.Expressions.LabelTarget" /> that is used by the loop body as a break statement target.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.LabelTarget" /> that is used by the loop body as a break statement target.</returns>
	public LabelTarget BreakLabel { get; }

	/// <summary>Gets the <see cref="T:System.Linq.Expressions.LabelTarget" /> that is used by the loop body as a continue statement target.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.LabelTarget" /> that is used by the loop body as a continue statement target.</returns>
	public LabelTarget ContinueLabel { get; }

	internal LoopExpression(Expression body, LabelTarget @break, LabelTarget @continue)
	{
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return null;
	}

	/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
	/// <param name="breakLabel">The <see cref="P:System.Linq.Expressions.LoopExpression.BreakLabel" /> property of the result.</param>
	/// <param name="continueLabel">The <see cref="P:System.Linq.Expressions.LoopExpression.ContinueLabel" /> property of the result.</param>
	/// <param name="body">The <see cref="P:System.Linq.Expressions.LoopExpression.Body" /> property of the result.</param>
	/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
	public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body)
	{
		return null;
	}
}
