namespace System.Linq.Expressions.Interpreter;

internal sealed class NullCheckInstruction : Instruction
{
	public static readonly Instruction Instance;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	private NullCheckInstruction()
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
