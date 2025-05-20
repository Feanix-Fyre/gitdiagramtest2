namespace System.Linq.Expressions.Interpreter;

internal sealed class CoalescingBranchInstruction : OffsetInstruction
{
	private static Instruction[] s_cache;

	public override Instruction[] Cache => null;

	public override string InstructionName => null;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
