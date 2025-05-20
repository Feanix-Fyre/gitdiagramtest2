using System.Collections.ObjectModel;
using System.Diagnostics;

namespace System.Linq.Expressions;

/// <summary>Represents one case of a <see cref="T:System.Linq.Expressions.SwitchExpression" />.</summary>
[DebuggerTypeProxy(typeof(Expression.SwitchCaseProxy))]
public sealed class SwitchCase
{
	/// <summary>Gets the values of this case. This case is selected for execution when the <see cref="P:System.Linq.Expressions.SwitchExpression.SwitchValue" /> matches any of these values.</summary>
	/// <returns>The read-only collection of the values for this case block.</returns>
	public ReadOnlyCollection<Expression> TestValues { get; }

	/// <summary>Gets the body of this case.</summary>
	/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> object that represents the body of the case block.</returns>
	public Expression Body { get; }
}
