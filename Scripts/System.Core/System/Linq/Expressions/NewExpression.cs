using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace System.Linq.Expressions;

/// <summary>Represents a constructor call.</summary>
[DebuggerTypeProxy(typeof(NewExpressionProxy))]
public class NewExpression : Expression
{
	private IReadOnlyList<Expression> _arguments;

	/// <summary>Gets the called constructor.</summary>
	/// <returns>The <see cref="T:System.Reflection.ConstructorInfo" /> that represents the called constructor.</returns>
	public ConstructorInfo Constructor { get; }

	public Expression GetArgument(int index)
	{
		return null;
	}
}
