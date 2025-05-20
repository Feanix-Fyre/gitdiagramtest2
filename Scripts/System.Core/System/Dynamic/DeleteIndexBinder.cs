namespace System.Dynamic;

/// <summary>Represents the dynamic delete index operation at the call site, providing the binding semantic and the details about the operation.</summary>
public abstract class DeleteIndexBinder : DynamicMetaObjectBinder
{
	/// <summary>Performs the binding of the dynamic delete index operation.</summary>
	/// <param name="target">The target of the dynamic delete index operation.</param>
	/// <param name="args">An array of arguments of the dynamic delete index operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		return null;
	}

	/// <summary>Performs the binding of the dynamic delete index operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic delete index operation.</param>
	/// <param name="indexes">The arguments of the dynamic delete index operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes)
	{
		return null;
	}

	/// <summary>When overridden in the derived class, performs the binding of the dynamic delete index operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic delete index operation.</param>
	/// <param name="indexes">The arguments of the dynamic delete index operation.</param>
	/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public abstract DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
}
