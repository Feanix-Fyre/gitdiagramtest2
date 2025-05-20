namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterFaultInstruction : IndexedBranchInstruction
{
	private static readonly EnterFaultInstruction[] s_cache;

	public override string InstructionName => null;

	public override int ProducedStack => 0;

	private EnterFaultInstruction(int labelIndex)
		: base(0)
	{
	}

	internal static EnterFaultInstruction Create(int labelIndex)
	{
		return null;
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
