namespace System.Linq.Expressions.Interpreter;

internal sealed class PopInstruction : Instruction
{
	internal static readonly PopInstruction Instance;

	public override int ConsumedStack => 0;

	public override string InstructionName => null;

	private PopInstruction()
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
