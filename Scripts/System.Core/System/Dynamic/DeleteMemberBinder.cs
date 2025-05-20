namespace System.Dynamic;

/// <summary>Represents the dynamic delete member operation at the call site, providing the binding semantic and the details about the operation.</summary>
public abstract class DeleteMemberBinder : DynamicMetaObjectBinder
{
	/// <summary>Gets the name of the member to delete.</summary>
	/// <returns>The name of the member to delete.</returns>
	public string Name { get; }

	/// <summary>Gets the value indicating if the string comparison should ignore the case of the member name.</summary>
	/// <returns>True if the string comparison should ignore the case, otherwise false.</returns>
	public bool IgnoreCase { get; }

	/// <summary>Performs the binding of the dynamic delete member operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic delete member operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target)
	{
		return null;
	}

	/// <summary>When overridden in the derived class, performs the binding of the dynamic delete member operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic delete member operation.</param>
	/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public abstract DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	/// <summary>Performs the binding of the dynamic delete member operation.</summary>
	/// <param name="target">The target of the dynamic delete member operation.</param>
	/// <param name="args">An array of arguments of the dynamic delete member operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		return null;
	}
}
