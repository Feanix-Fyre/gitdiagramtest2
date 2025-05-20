namespace System.Dynamic;

/// <summary>Represents the unary dynamic operation at the call site, providing the binding semantic and the details about the operation.</summary>
public abstract class UnaryOperationBinder : DynamicMetaObjectBinder
{
	/// <summary>Performs the binding of the unary dynamic operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic unary operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target)
	{
		return null;
	}

	/// <summary>Performs the binding of the unary dynamic operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic unary operation.</param>
	/// <param name="errorSuggestion">The binding result in case the binding fails, or null.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	/// <summary>Performs the binding of the dynamic unary operation.</summary>
	/// <param name="target">The target of the dynamic operation.</param>
	/// <param name="args">An array of arguments of the dynamic operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		return null;
	}
}
