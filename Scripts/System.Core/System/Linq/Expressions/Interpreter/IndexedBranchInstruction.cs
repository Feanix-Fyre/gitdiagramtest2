using System.Collections.Generic;

namespace System.Linq.Expressions.Interpreter;

internal abstract class IndexedBranchInstruction : Instruction
{
	internal readonly int _labelIndex;

	public IndexedBranchInstruction(int labelIndex)
	{
	}

	public RuntimeLabel GetLabel(InterpretedFrame frame)
	{
		return default(RuntimeLabel);
	}

	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
