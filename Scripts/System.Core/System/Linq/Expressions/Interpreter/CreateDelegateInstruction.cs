namespace System.Linq.Expressions.Interpreter;

internal sealed class CreateDelegateInstruction : Instruction
{
	private readonly LightDelegateCreator _creator;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	internal CreateDelegateInstruction(LightDelegateCreator delegateCreator)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
