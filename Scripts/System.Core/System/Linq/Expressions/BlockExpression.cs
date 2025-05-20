using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Linq.Expressions;

/// <summary>Represents a block that contains a sequence of expressions where variables can be defined.</summary>
[DebuggerTypeProxy(typeof(BlockExpressionProxy))]
public class BlockExpression : Expression
{
	/// <summary>Gets the expressions in this block.</summary>
	/// <returns>The read-only collection containing all the expressions in this block.</returns>
	public ReadOnlyCollection<Expression> Expressions => null;

	/// <summary>Gets the variables defined in this block.</summary>
	/// <returns>The read-only collection containing all the variables defined in this block.</returns>
	public ReadOnlyCollection<ParameterExpression> Variables => null;

	/// <summary>Returns the node type of this expression. Extension nodes should return <see cref="F:System.Linq.Expressions.ExpressionType.Extension" /> when overriding this method.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> of the expression.</returns>
	public sealed override ExpressionType NodeType => default(ExpressionType);

	/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
	/// <returns>The <see cref="P:System.Linq.Expressions.BlockExpression.Type" /> that represents the static type of the expression.</returns>
	public override Type Type => null;

	[ExcludeFromCodeCoverage]
	internal virtual int ExpressionCount => 0;

	internal BlockExpression()
	{
	}

	/// <summary>Dispatches to the specific visit method for this node type. For example, <see cref="T:System.Linq.Expressions.MethodCallExpression" /> calls the <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)" />.</summary>
	/// <param name="visitor">The visitor to visit this node with.</param>
	/// <returns>The result of visiting this node.</returns>
	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return null;
	}

	[ExcludeFromCodeCoverage]
	internal virtual Expression GetExpression(int index)
	{
		return null;
	}

	[ExcludeFromCodeCoverage]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions()
	{
		return null;
	}

	internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables()
	{
		return null;
	}

	[ExcludeFromCodeCoverage]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
	{
		return null;
	}

	internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection)
	{
		return null;
	}
}
