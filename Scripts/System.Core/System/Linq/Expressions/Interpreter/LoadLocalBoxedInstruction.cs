namespace System.Linq.Expressions.Interpreter;

internal sealed class LoadLocalBoxedInstruction : LocalAccessInstruction
{
	public override int ProducedStack => 0;

	public override string InstructionName => null;

	internal LoadLocalBoxedInstruction(int index)
		: base(0)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
