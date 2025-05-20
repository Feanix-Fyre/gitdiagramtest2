using System.Collections.Generic;

namespace System.Linq.Expressions.Interpreter;

internal sealed class LoadCachedObjectInstruction : Instruction
{
	private readonly uint _index;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	internal LoadCachedObjectInstruction(uint index)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
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
