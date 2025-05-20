namespace System.Linq.Expressions.Interpreter;

internal sealed class LoadLocalInstruction : LocalAccessInstruction, IBoxableInstruction
{
	public override int ProducedStack => 0;

	public override string InstructionName => null;

	internal LoadLocalInstruction(int index)
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
