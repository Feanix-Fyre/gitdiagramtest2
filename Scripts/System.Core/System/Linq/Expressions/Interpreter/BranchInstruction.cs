namespace System.Linq.Expressions.Interpreter;

internal class BranchInstruction : OffsetInstruction
{
	private static Instruction[][][] s_caches;

	internal readonly bool _hasResult;

	internal readonly bool _hasValue;

	public override Instruction[] Cache => null;

	public override string InstructionName => null;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	internal BranchInstruction()
	{
	}

	public BranchInstruction(bool hasResult, bool hasValue)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
