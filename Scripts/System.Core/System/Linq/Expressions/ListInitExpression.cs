using System.Collections.ObjectModel;
using System.Diagnostics;

namespace System.Linq.Expressions;

/// <summary>Represents a constructor call that has a collection initializer.</summary>
[DebuggerTypeProxy(typeof(ListInitExpressionProxy))]
public sealed class ListInitExpression : Expression
{
	/// <summary>Gets the expression that contains a call to the constructor of a collection type.</summary>
	/// <returns>A <see cref="T:System.Linq.Expressions.NewExpression" /> that represents the call to the constructor of a collection type.</returns>
	public NewExpression NewExpression { get; }

	/// <summary>Gets the element initializers that are used to initialize a collection.</summary>
	/// <returns>A <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see cref="T:System.Linq.Expressions.ElementInit" /> objects which represent the elements that are used to initialize the collection.</returns>
	public ReadOnlyCollection<ElementInit> Initializers { get; }
}
