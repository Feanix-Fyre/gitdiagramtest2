namespace System.Linq.Expressions.Interpreter;

internal sealed class AssignLocalToClosureInstruction : LocalAccessInstruction
{
	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	internal AssignLocalToClosureInstruction(int index)
		: base(0)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
