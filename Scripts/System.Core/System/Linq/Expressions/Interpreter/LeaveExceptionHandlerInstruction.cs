namespace System.Linq.Expressions.Interpreter;

internal sealed class LeaveExceptionHandlerInstruction : IndexedBranchInstruction
{
	private static readonly LeaveExceptionHandlerInstruction[] s_cache;

	private readonly bool _hasValue;

	public override string InstructionName => null;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	private LeaveExceptionHandlerInstruction(int labelIndex, bool hasValue)
		: base(0)
	{
	}

	internal static LeaveExceptionHandlerInstruction Create(int labelIndex, bool hasValue)
	{
		return null;
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
