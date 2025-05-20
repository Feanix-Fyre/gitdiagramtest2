namespace System.Dynamic;

/// <summary>Represents the convert dynamic operation at the call site, providing the binding semantic and the details about the operation.</summary>
public abstract class ConvertBinder : DynamicMetaObjectBinder
{
	/// <summary>The type to convert to.</summary>
	/// <returns>The <see cref="T:System.Type" /> object that represents the type to convert to.</returns>
	public Type Type { get; }

	/// <summary>Performs the binding of the dynamic convert operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic convert operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public DynamicMetaObject FallbackConvert(DynamicMetaObject target)
	{
		return null;
	}

	/// <summary>When overridden in the derived class, performs the binding of the dynamic convert operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic convert operation.</param>
	/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	/// <summary>Performs the binding of the dynamic convert operation.</summary>
	/// <param name="target">The target of the dynamic convert operation.</param>
	/// <param name="args">An array of arguments of the dynamic convert operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		return null;
	}
}
