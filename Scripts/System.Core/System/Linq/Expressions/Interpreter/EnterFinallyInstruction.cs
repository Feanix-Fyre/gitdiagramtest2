namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterFinallyInstruction : IndexedBranchInstruction
{
	private static readonly EnterFinallyInstruction[] s_cache;

	public override string InstructionName => null;

	public override int ProducedStack => 0;

	public override int ConsumedContinuations => 0;

	private EnterFinallyInstruction(int labelIndex)
		: base(0)
	{
	}

	internal static EnterFinallyInstruction Create(int labelIndex)
	{
		return null;
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
