namespace System.Linq.Expressions.Interpreter;

internal sealed class GetArrayItemInstruction : Instruction
{
	internal static readonly GetArrayItemInstruction Instance;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	private GetArrayItemInstruction()
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
