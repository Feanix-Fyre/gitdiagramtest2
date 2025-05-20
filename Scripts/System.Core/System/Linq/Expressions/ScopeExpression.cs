using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions;

internal class ScopeExpression : BlockExpression
{
	private IReadOnlyList<ParameterExpression> _variables;

	protected IReadOnlyList<ParameterExpression> VariablesList => null;

	internal ScopeExpression(IReadOnlyList<ParameterExpression> variables)
	{
	}

	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables()
	{
		return null;
	}

	internal IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables)
	{
		return null;
	}
}
