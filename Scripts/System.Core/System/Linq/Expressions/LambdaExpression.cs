using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Linq.Expressions;

/// <summary>Describes a lambda expression. This captures a block of code that is similar to a .NET method body.</summary>
[DebuggerTypeProxy(typeof(LambdaExpressionProxy))]
public abstract class LambdaExpression : Expression, IParameterProvider
{
	private readonly Expression _body;

	/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
	/// <returns>The <see cref="P:System.Linq.Expressions.LambdaExpression.Type" /> that represents the static type of the expression.</returns>
	public sealed override Type Type => null;

	internal abstract Type TypeCore { get; }

	internal abstract Type PublicType { get; }

	/// <summary>Returns the node type of this <see cref="T:System.Linq.Expressions.Expression" />.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> that represents this expression.</returns>
	public sealed override ExpressionType NodeType => default(ExpressionType);

	/// <summary>Gets the name of the lambda expression.</summary>
	/// <returns>The name of the lambda expression.</returns>
	public string Name => null;

	internal virtual string NameCore => null;

	/// <summary>Gets the body of the lambda expression.</summary>
	/// <returns>An <see cref="T:System.Linq.Expressions.Expression" /> that represents the body of the lambda expression.</returns>
	public Expression Body => null;

	/// <summary>Gets the return type of the lambda expression.</summary>
	/// <returns>The <see cref="T:System.Type" /> object representing the type of the lambda expression.</returns>
	public Type ReturnType => null;

	/// <summary>Gets the value that indicates if the lambda expression will be compiled with the tail call optimization.</summary>
	/// <returns>True if the lambda expression will be compiled with the tail call optimization, otherwise false.</returns>
	public bool TailCall => false;

	internal virtual bool TailCallCore => false;

	[ExcludeFromCodeCoverage]
	int IParameterProvider.ParameterCount => 0;

	[ExcludeFromCodeCoverage]
	internal virtual int ParameterCount => 0;

	internal LambdaExpression(Expression body)
	{
	}

	[ExcludeFromCodeCoverage]
	ParameterExpression IParameterProvider.GetParameter(int index)
	{
		return null;
	}

	[ExcludeFromCodeCoverage]
	internal virtual ParameterExpression GetParameter(int index)
	{
		return null;
	}
}
