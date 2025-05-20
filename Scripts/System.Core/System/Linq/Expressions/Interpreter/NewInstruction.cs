using System.Reflection;

namespace System.Linq.Expressions.Interpreter;

internal class NewInstruction : Instruction
{
	protected readonly ConstructorInfo _constructor;

	protected readonly int _argumentCount;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	public NewInstruction(ConstructorInfo constructor, int argumentCount)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}

	protected object[] GetArgs(InterpretedFrame frame, int first)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
