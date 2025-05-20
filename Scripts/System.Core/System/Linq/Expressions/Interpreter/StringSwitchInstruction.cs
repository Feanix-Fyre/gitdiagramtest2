using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions.Interpreter;

internal sealed class StringSwitchInstruction : Instruction
{
	private readonly Dictionary<string, int> _cases;

	private readonly StrongBox<int> _nullCase;

	public override string InstructionName => null;

	public override int ConsumedStack => 0;

	internal StringSwitchInstruction(Dictionary<string, int> cases, StrongBox<int> nullCase)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
