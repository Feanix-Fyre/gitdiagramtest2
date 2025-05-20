using System.Collections.ObjectModel;

namespace System.Linq.Expressions;

/// <summary>Represents initializing members of a member of a newly created object.</summary>
public sealed class MemberMemberBinding : MemberBinding
{
	/// <summary>Gets the bindings that describe how to initialize the members of a member.</summary>
	/// <returns>A <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see cref="T:System.Linq.Expressions.MemberBinding" /> objects that describe how to initialize the members of the member.</returns>
	public ReadOnlyCollection<MemberBinding> Bindings { get; }
}
