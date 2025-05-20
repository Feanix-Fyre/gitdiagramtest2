namespace System.Linq.Expressions.Interpreter;

internal sealed class NewArrayInitInstruction : Instruction
{
	private readonly Type _elementType;

	private readonly int _elementCount;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	internal NewArrayInitInstruction(Type elementType, int elementCount)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
