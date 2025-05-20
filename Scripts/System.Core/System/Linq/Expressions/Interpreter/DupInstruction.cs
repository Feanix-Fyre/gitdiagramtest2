namespace System.Linq.Expressions.Interpreter;

internal sealed class DupInstruction : Instruction
{
	internal static readonly DupInstruction Instance;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	private DupInstruction()
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
