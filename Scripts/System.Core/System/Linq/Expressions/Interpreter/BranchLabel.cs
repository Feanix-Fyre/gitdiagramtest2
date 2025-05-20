using System.Collections.Generic;

namespace System.Linq.Expressions.Interpreter;

internal sealed class BranchLabel
{
	private int _targetIndex;

	private int _stackDepth;

	private int _continuationStackDepth;

	private List<int> _forwardBranchFixups;

	internal int LabelIndex { get; set; }

	internal bool HasRuntimeLabel => false;

	internal int TargetIndex => 0;

	internal RuntimeLabel ToRuntimeLabel()
	{
		return default(RuntimeLabel);
	}

	internal void Mark(InstructionList instructions)
	{
	}

	internal void AddBranch(InstructionList instructions, int branchIndex)
	{
	}

	internal void FixupBranch(InstructionList instructions, int branchIndex)
	{
	}
}
