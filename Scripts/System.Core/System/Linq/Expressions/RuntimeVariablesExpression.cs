using System.Collections.ObjectModel;
using System.Diagnostics;

namespace System.Linq.Expressions;

/// <summary>An expression that provides runtime read/write permission for variables.</summary>
[DebuggerTypeProxy(typeof(RuntimeVariablesExpressionProxy))]
public sealed class RuntimeVariablesExpression : Expression
{
	/// <summary>The variables or parameters to which to provide runtime access.</summary>
	/// <returns>The read-only collection containing parameters that will be provided the runtime access.</returns>
	public ReadOnlyCollection<ParameterExpression> Variables { get; }
}
