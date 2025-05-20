namespace System.Linq.Expressions.Interpreter;

internal sealed class AssignLocalBoxedInstruction : LocalAccessInstruction
{
	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	internal AssignLocalBoxedInstruction(int index)
		: base(0)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
