using System.Collections.Generic;

namespace System.Linq.Expressions.Interpreter;

internal abstract class LocalAccessInstruction : Instruction
{
	internal readonly int _index;

	protected LocalAccessInstruction(int index)
	{
	}

	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects)
	{
		return null;
	}
}
