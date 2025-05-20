using System.Diagnostics;

namespace System.Linq.Expressions;

/// <summary>Represents a named parameter expression.</summary>
[DebuggerTypeProxy(typeof(ParameterExpressionProxy))]
public class ParameterExpression : Expression
{
	/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
	/// <returns>The <see cref="P:System.Linq.Expressions.ParameterExpression.Type" /> that represents the static type of the expression.</returns>
	public override Type Type => null;

	/// <summary>Returns the node type of this <see cref="T:System.Linq.Expressions.Expression" />.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> that represents this expression.</returns>
	public sealed override ExpressionType NodeType => default(ExpressionType);

	/// <summary>Gets the name of the parameter or variable.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains the name of the parameter.</returns>
	public string Name { get; }

	/// <summary>Indicates that this ParameterExpression is to be treated as a <see langword="ByRef" /> parameter.</summary>
	/// <returns>True if this ParameterExpression is a <see langword="ByRef" /> parameter, otherwise false.</returns>
	public bool IsByRef => false;

	internal ParameterExpression(string name)
	{
	}

	internal static ParameterExpression Make(Type type, string name, bool isByRef)
	{
		return null;
	}

	internal virtual bool GetIsByRef()
	{
		return false;
	}

	/// <summary>Dispatches to the specific visit method for this node type. For example, <see cref="T:System.Linq.Expressions.MethodCallExpression" /> calls the <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)" />.</summary>
	/// <param name="visitor">The visitor to visit this node with.</param>
	/// <returns>The result of visiting this node.</returns>
	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return null;
	}
}
