using System.Collections.Generic;

namespace System.Linq.Expressions.Interpreter;

internal sealed class LocalVariables
{
	private sealed class VariableScope
	{
		public readonly int Start;

		public int Stop;

		public readonly LocalVariable Variable;

		public readonly VariableScope Parent;

		public List<VariableScope> ChildScopes;

		public VariableScope(LocalVariable variable, int start, VariableScope parent)
		{
		}
	}

	private readonly HybridReferenceDictionary<ParameterExpression, VariableScope> _variables;

	private Dictionary<ParameterExpression, LocalVariable> _closureVariables;

	private int _localCount;

	private int _maxLocalCount;

	public int LocalCount => 0;

	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables => null;

	public LocalDefinition DefineLocal(ParameterExpression variable, int start)
	{
		return default(LocalDefinition);
	}

	public void UndefineLocal(LocalDefinition definition, int end)
	{
	}

	internal void Box(ParameterExpression variable, InstructionList instructions)
	{
	}

	public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local)
	{
		local = null;
		return false;
	}

	internal LocalVariable AddClosureVariable(ParameterExpression variable)
	{
		return null;
	}
}
