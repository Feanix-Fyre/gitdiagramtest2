namespace System.Dynamic;

/// <summary>Represents the dynamic set index operation at the call site, providing the binding semantic and the details about the operation.</summary>
public abstract class SetIndexBinder : DynamicMetaObjectBinder
{
	/// <summary>Performs the binding of the dynamic set index operation.</summary>
	/// <param name="target">The target of the dynamic set index operation.</param>
	/// <param name="args">An array of arguments of the dynamic set index operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		return null;
	}

	/// <summary>Performs the binding of the dynamic set index operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic set index operation.</param>
	/// <param name="indexes">The arguments of the dynamic set index operation.</param>
	/// <param name="value">The value to set to the collection.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value)
	{
		return null;
	}

	/// <summary>When overridden in the derived class, performs the binding of the dynamic set index operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic set index operation.</param>
	/// <param name="indexes">The arguments of the dynamic set index operation.</param>
	/// <param name="value">The value to set to the collection.</param>
	/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public abstract DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
}
