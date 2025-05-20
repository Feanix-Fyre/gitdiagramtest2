using System.Collections.ObjectModel;

namespace System.Linq.Expressions;

/// <summary>Represents initializing the elements of a collection member of a newly created object.</summary>
public sealed class MemberListBinding : MemberBinding
{
	/// <summary>Gets the element initializers for initializing a collection member of a newly created object.</summary>
	/// <returns>A <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see cref="T:System.Linq.Expressions.ElementInit" /> objects to initialize a collection member with.</returns>
	public ReadOnlyCollection<ElementInit> Initializers { get; }
}
