namespace System.Linq.Expressions.Interpreter;

internal sealed class NewArrayInstruction : Instruction
{
	private readonly Type _elementType;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	internal NewArrayInstruction(Type elementType)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
