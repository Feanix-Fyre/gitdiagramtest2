namespace System.Linq.Expressions.Interpreter;

internal sealed class LeaveFinallyInstruction : Instruction
{
	internal static readonly Instruction Instance;

	public override int ConsumedStack => 0;

	public override string InstructionName => null;

	private LeaveFinallyInstruction()
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
