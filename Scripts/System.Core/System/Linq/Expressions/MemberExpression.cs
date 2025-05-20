using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace System.Linq.Expressions;

/// <summary>Represents accessing a field or property.</summary>
[DebuggerTypeProxy(typeof(MemberExpressionProxy))]
public class MemberExpression : Expression
{
	/// <summary>Gets the field or property to be accessed.</summary>
	/// <returns>The <see cref="T:System.Reflection.MemberInfo" /> that represents the field or property to be accessed.</returns>
	public MemberInfo Member => null;

	/// <summary>Gets the containing object of the field or property.</summary>
	/// <returns>An <see cref="T:System.Linq.Expressions.Expression" /> that represents the containing object of the field or property.</returns>
	public Expression Expression { get; }

	/// <summary>Returns the node type of this <see cref="P:System.Linq.Expressions.MemberExpression.Expression" />.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> that represents this expression.</returns>
	public sealed override ExpressionType NodeType => default(ExpressionType);

	internal MemberExpression(Expression expression)
	{
	}

	internal static PropertyExpression Make(Expression expression, PropertyInfo property)
	{
		return null;
	}

	internal static FieldExpression Make(Expression expression, FieldInfo field)
	{
		return null;
	}

	[ExcludeFromCodeCoverage]
	internal virtual MemberInfo GetMember()
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

	/// <summary>Creates a new expression that is like this one, but using the supplied children. If all of the children are the same, it will return this expression.</summary>
	/// <param name="expression">The <see cref="P:System.Linq.Expressions.MemberExpression.Expression" /> property of the result.</param>
	/// <returns>This expression if no children are changed or an expression with the updated children.</returns>
	public MemberExpression Update(Expression expression)
	{
		return null;
	}
}
