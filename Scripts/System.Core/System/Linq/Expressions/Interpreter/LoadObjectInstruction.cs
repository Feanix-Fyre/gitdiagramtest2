namespace System.Linq.Expressions.Interpreter;

internal sealed class LoadObjectInstruction : Instruction
{
	private readonly object _value;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	internal LoadObjectInstruction(object value)
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
