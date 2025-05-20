namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction
{
	private readonly bool _hasFinally;

	private TryCatchFinallyHandler _tryHandler;

	internal TryCatchFinallyHandler Handler => null;

	public override int ProducedContinuations => 0;

	public override string InstructionName => null;

	internal void SetTryHandler(TryCatchFinallyHandler tryHandler)
	{
	}

	private EnterTryCatchFinallyInstruction(int targetIndex, bool hasFinally)
		: base(0)
	{
	}

	internal static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex)
	{
		return null;
	}

	internal static EnterTryCatchFinallyInstruction CreateTryCatch()
	{
		return null;
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
