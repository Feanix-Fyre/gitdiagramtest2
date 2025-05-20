namespace System.Linq.Expressions.Interpreter;

internal sealed class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction
{
	public override int ConsumedStack => 0;

	public override string InstructionName => null;

	internal StoreLocalInstruction(int index)
		: base(0)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}

	public Instruction BoxIfIndexMatches(int index)
	{
		return null;
	}
}
