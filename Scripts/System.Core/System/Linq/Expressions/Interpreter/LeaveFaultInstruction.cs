namespace System.Linq.Expressions.Interpreter;

internal sealed class LeaveFaultInstruction : Instruction
{
	internal static readonly Instruction Instance;

	public override int ConsumedStack => 0;

	public override int ConsumedContinuations => 0;

	public override string InstructionName => null;

	private LeaveFaultInstruction()
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
