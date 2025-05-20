using System.Collections.Generic;

namespace System.Linq.Expressions.Interpreter;

internal abstract class OffsetInstruction : Instruction
{
	protected int _offset;

	public abstract Instruction[] Cache { get; }

	public Instruction Fixup(int offset)
	{
		return null;
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
