namespace System.Linq.Expressions.Interpreter;

internal sealed class LoadLocalFromClosureInstruction : LocalAccessInstruction
{
	public override int ProducedStack => 0;

	public override string InstructionName => null;

	internal LoadLocalFromClosureInstruction(int index)
		: base(0)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
