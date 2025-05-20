using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Linq.Expressions;

/// <summary>Represents an expression that applies a delegate or lambda expression to a list of argument expressions.</summary>
[DebuggerTypeProxy(typeof(InvocationExpressionProxy))]
public class InvocationExpression : Expression, IArgumentProvider
{
	/// <summary>Gets the static type of the expression that this <see cref="P:System.Linq.Expressions.InvocationExpression.Expression" /> represents.</summary>
	/// <returns>The <see cref="P:System.Linq.Expressions.InvocationExpression.Type" /> that represents the static type of the expression.</returns>
	public sealed override Type Type { get; }

	/// <summary>Returns the node type of this expression. Extension nodes should return <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> when overriding this method.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> of the expression.</returns>
	public sealed override ExpressionType NodeType => default(ExpressionType);

	/// <summary>Gets the delegate or lambda expression to be applied.</summary>
	/// <returns>An <see cref="T:System.Linq.Expressions.Expression" /> that represents the delegate to be applied.</returns>
	public Expression Expression { get; }

	[ExcludeFromCodeCoverage]
	public virtual int ArgumentCount => 0;

	internal InvocationExpression(Expression expression, Type returnType)
	{
	}

	[ExcludeFromCodeCoverage]
	public virtual Expression GetArgument(int index)
	{
		return null;
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return null;
	}

	[ExcludeFromCodeCoverage]
	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
	{
		return null;
	}
}
