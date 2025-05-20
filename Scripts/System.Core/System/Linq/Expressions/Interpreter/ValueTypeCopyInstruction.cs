namespace System.Linq.Expressions.Interpreter;

internal sealed class ValueTypeCopyInstruction : Instruction
{
	public static readonly ValueTypeCopyInstruction Instruction;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
