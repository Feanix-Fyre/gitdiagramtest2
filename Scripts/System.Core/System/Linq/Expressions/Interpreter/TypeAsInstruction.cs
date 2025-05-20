namespace System.Linq.Expressions.Interpreter;

internal sealed class TypeAsInstruction : Instruction
{
	private readonly Type _type;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	internal TypeAsInstruction(Type type)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
