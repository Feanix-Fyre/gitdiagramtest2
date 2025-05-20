namespace System.Linq.Expressions.Interpreter;

internal sealed class RuntimeVariablesInstruction : Instruction
{
	private readonly int _count;

	public override int ProducedStack => 0;

	public override int ConsumedStack => 0;

	public override string InstructionName => null;

	public RuntimeVariablesInstruction(int count)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
