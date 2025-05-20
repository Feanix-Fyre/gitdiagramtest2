namespace System.Linq.Expressions.Interpreter;

internal sealed class GotoInstruction : IndexedBranchInstruction
{
	private static readonly GotoInstruction[] s_cache;

	private readonly bool _hasResult;

	private readonly bool _hasValue;

	private readonly bool _labelTargetGetsValue;

	public override string InstructionName => null;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	private GotoInstruction(int targetIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue)
		: base(0)
	{
	}

	internal static GotoInstruction Create(int labelIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue)
	{
		return null;
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
