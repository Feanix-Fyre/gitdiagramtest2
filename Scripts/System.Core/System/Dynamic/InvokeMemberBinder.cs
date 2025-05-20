namespace System.Dynamic;

/// <summary>Represents the invoke member dynamic operation at the call site, providing the binding semantic and the details about the operation.</summary>
public abstract class InvokeMemberBinder : DynamicMetaObjectBinder
{
	/// <summary>Gets the name of the member to invoke.</summary>
	/// <returns>The name of the member to invoke.</returns>
	public string Name { get; }

	/// <summary>Gets the value indicating if the string comparison should ignore the case of the member name.</summary>
	/// <returns>True if the case is ignored, otherwise false.</returns>
	public bool IgnoreCase { get; }

	/// <summary>Performs the binding of the dynamic invoke member operation.</summary>
	/// <param name="target">The target of the dynamic invoke member operation.</param>
	/// <param name="args">An array of arguments of the dynamic invoke member operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		return null;
	}

	/// <summary>Performs the binding of the dynamic invoke member operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic invoke member operation.</param>
	/// <param name="args">The arguments of the dynamic invoke member operation.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args)
	{
		return null;
	}

	/// <summary>When overridden in the derived class, performs the binding of the dynamic invoke member operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic invoke member operation.</param>
	/// <param name="args">The arguments of the dynamic invoke member operation.</param>
	/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public abstract DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	/// <summary>When overridden in the derived class, performs the binding of the dynamic invoke operation if the target dynamic object cannot bind.</summary>
	/// <param name="target">The target of the dynamic invoke operation.</param>
	/// <param name="args">The arguments of the dynamic invoke operation.</param>
	/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
	/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
}
