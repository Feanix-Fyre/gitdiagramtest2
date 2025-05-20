using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace System.Linq.Expressions;

/// <summary>Represents indexing a property or array.</summary>
[DebuggerTypeProxy(typeof(IndexExpressionProxy))]
public sealed class IndexExpression : Expression, IArgumentProvider
{
	private IReadOnlyList<Expression> _arguments;

	/// <summary>Returns the node type of this <see cref="T:System.Linq.Expressions.Expression" />.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> that represents this expression.</returns>
	public sealed override ExpressionType NodeType => default(ExpressionType);

	/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
	/// <returns>The <see cref="P:System.Linq.Expressions.IndexExpression.Type" /> that represents the static type of the expression.</returns>
	public sealed override Type Type => null;

	/// <summary>An object to index.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> representing the object to index.</returns>
	public Expression Object { get; }

	/// <summary>Gets the <see cref="T:System.Reflection.PropertyInfo" /> for the property if the expression represents an indexed property, returns null otherwise.</summary>
	/// <returns>The <see cref="T:System.Reflection.PropertyInfo" /> for the property if the expression represents an indexed property, otherwise null.</returns>
	public PropertyInfo Indexer { get; }

	public int ArgumentCount => 0;

	internal IndexExpression(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments)
	{
	}

	public Expression GetArgument(int index)
	{
		return null;
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return null;
	}

	internal Expression Rewrite(Expression instance, Expression[] arguments)
	{
		return null;
	}
}
