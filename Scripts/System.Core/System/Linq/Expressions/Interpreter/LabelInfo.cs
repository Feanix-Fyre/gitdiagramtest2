using System.Collections.Generic;

namespace System.Linq.Expressions.Interpreter;

internal sealed class LabelInfo
{
	private readonly LabelTarget _node;

	private BranchLabel _label;

	private object _definitions;

	private readonly List<LabelScopeInfo> _references;

	private bool _acrossBlockJump;

	private bool HasDefinitions => false;

	private bool HasMultipleDefinitions => false;

	internal LabelInfo(LabelTarget node)
	{
	}

	internal BranchLabel GetLabel(LightCompiler compiler)
	{
		return null;
	}

	internal void Reference(LabelScopeInfo block)
	{
	}

	internal void Define(LabelScopeInfo block)
	{
	}

	private void ValidateJump(LabelScopeInfo reference)
	{
	}

	internal void ValidateFinish()
	{
	}

	private void EnsureLabel(LightCompiler compiler)
	{
	}

	private bool DefinedIn(LabelScopeInfo scope)
	{
		return false;
	}

	private LabelScopeInfo FirstDefinition()
	{
		return null;
	}

	private void AddDefinition(LabelScopeInfo scope)
	{
	}

	internal static T CommonNode<T>(T first, T second, Func<T, T> parent) where T : class
	{
		return null;
	}
}
