namespace System.Linq.Expressions.Interpreter;

internal sealed class ArrayLengthInstruction : Instruction
{
	public static readonly ArrayLengthInstruction Instance;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	private ArrayLengthInstruction()
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
