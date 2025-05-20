using System.Reflection;

namespace System.Linq.Expressions;

/// <summary>Provides the base class from which the classes that represent bindings that are used to initialize members of a newly created object derive.</summary>
public abstract class MemberBinding
{
	/// <summary>Gets the type of binding that is represented.</summary>
	/// <returns>One of the <see cref="T:System.Linq.Expressions.MemberBindingType" /> values.</returns>
	public MemberBindingType BindingType { get; }

	/// <summary>Gets the field or property to be initialized.</summary>
	/// <returns>The <see cref="T:System.Reflection.MemberInfo" /> that represents the field or property to be initialized.</returns>
	public MemberInfo Member { get; }
}
