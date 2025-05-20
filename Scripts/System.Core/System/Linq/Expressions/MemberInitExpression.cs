using System.Collections.ObjectModel;
using System.Diagnostics;

namespace System.Linq.Expressions;

/// <summary>Represents calling a constructor and initializing one or more members of the new object.</summary>
[DebuggerTypeProxy(typeof(MemberInitExpressionProxy))]
public sealed class MemberInitExpression : Expression
{
	/// <summary>Gets the expression that represents the constructor call.</summary>
	/// <returns>A <see cref="T:System.Linq.Expressions.NewExpression" /> that represents the constructor call.</returns>
	public NewExpression NewExpression { get; }

	/// <summary>Gets the bindings that describe how to initialize the members of the newly created object.</summary>
	/// <returns>A <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see cref="T:System.Linq.Expressions.MemberBinding" /> objects which describe how to initialize the members.</returns>
	public ReadOnlyCollection<MemberBinding> Bindings { get; }
}
