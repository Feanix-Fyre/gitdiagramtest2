namespace System.Linq.Expressions.Interpreter;

internal sealed class TypeEqualsInstruction : Instruction
{
	public static readonly TypeEqualsInstruction Instance;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	private TypeEqualsInstruction()
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
