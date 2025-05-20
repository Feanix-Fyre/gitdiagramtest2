namespace System.Linq.Expressions.Interpreter;

internal sealed class SetArrayItemInstruction : Instruction
{
	internal static readonly SetArrayItemInstruction Instance;

	public override int ConsumedStack => 0;

	public override string InstructionName => null;

	private SetArrayItemInstruction()
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
