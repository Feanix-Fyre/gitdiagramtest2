namespace System.Linq.Expressions.Interpreter;

internal sealed class DefaultValueInstruction : Instruction
{
	private readonly Type _type;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	internal DefaultValueInstruction(Type type)
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
