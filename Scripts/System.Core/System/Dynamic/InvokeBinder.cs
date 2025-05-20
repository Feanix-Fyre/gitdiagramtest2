namespace System.Dynamic;

/// <summary>Represents the invoke dynamic operation at the call site, providing the binding semantic and the details about the operation.</summary>
public abstract class InvokeBinder : DynamicMetaObjectBinder
{
	/// <summary>Performs the binding of the dynamic invoke operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic invoke operation.</param>
	/// <param name="args">The arguments of the dynamic invoke operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		return null;
	}

	/// <summary>Performs the binding of the dynamic invoke operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic invoke operation.</param>
	/// <param name="args">The arguments of the dynamic invoke operation.</param>
	/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	/// <summary>Performs the binding of the dynamic invoke operation.</summary>
	/// <param name="target">The target of the dynamic invoke operation.</param>
	/// <param name="args">An array of arguments of the dynamic invoke operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		return null;
	}
}
