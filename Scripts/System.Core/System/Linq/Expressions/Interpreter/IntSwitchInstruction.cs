using System.Collections.Generic;

namespace System.Linq.Expressions.Interpreter;

internal sealed class IntSwitchInstruction<T> : Instruction
{
	private readonly Dictionary<T, int> _cases;

	public override string InstructionName => null;

	public override int ConsumedStack => 0;

	internal IntSwitchInstruction(Dictionary<T, int> cases)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
