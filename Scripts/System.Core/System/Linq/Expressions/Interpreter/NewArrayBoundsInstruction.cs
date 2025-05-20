namespace System.Linq.Expressions.Interpreter;

internal sealed class NewArrayBoundsInstruction : Instruction
{
	private readonly Type _elementType;

	private readonly int _rank;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	internal NewArrayBoundsInstruction(Type elementType, int rank)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
