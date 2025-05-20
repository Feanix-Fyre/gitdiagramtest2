namespace System.Dynamic;

/// <summary>Represents the dynamic create operation at the call site, providing the binding semantic and the details about the operation.</summary>
public abstract class CreateInstanceBinder : DynamicMetaObjectBinder
{
	/// <summary>Performs the binding of the dynamic create operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic create operation.</param>
	/// <param name="args">The arguments of the dynamic create operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		return null;
	}

	/// <summary>When overridden in the derived class, performs the binding of the dynamic create operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic create operation.</param>
	/// <param name="args">The arguments of the dynamic create operation.</param>
	/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public abstract DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	/// <summary>Performs the binding of the dynamic create operation.</summary>
	/// <param name="target">The target of the dynamic create operation.</param>
	/// <param name="args">An array of arguments of the dynamic create operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		return null;
	}
}
