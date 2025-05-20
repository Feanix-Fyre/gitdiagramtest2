namespace System.Linq.Expressions.Interpreter;

internal sealed class StoreLocalBoxedInstruction : LocalAccessInstruction
{
	public override int ConsumedStack => 0;

	public override string InstructionName => null;

	internal StoreLocalBoxedInstruction(int index)
		: base(0)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
