using System.Linq.Expressions;

namespace System.Dynamic;

/// <summary>Represents the binary dynamic operation at the call site, providing the binding semantic and the details about the operation.</summary>
public abstract class BinaryOperationBinder : DynamicMetaObjectBinder
{
	/// <summary>The binary operation kind.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> object representing the kind of binary operation.</returns>
	public ExpressionType Operation { get; }

	/// <summary>Performs the binding of the binary dynamic operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic binary operation.</param>
	/// <param name="arg">The right hand side operand of the dynamic binary operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg)
	{
		return null;
	}

	/// <summary>When overridden in the derived class, performs the binding of the binary dynamic operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic binary operation.</param>
	/// <param name="arg">The right hand side operand of the dynamic binary operation.</param>
	/// <param name="errorSuggestion">The binding result if the binding fails, or null.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion);

	/// <summary>Performs the binding of the dynamic binary operation.</summary>
	/// <param name="target">The target of the dynamic operation.</param>
	/// <param name="args">An array of arguments of the dynamic operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		return null;
	}
}
