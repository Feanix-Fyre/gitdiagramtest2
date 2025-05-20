using System.Reflection;

namespace System.Linq.Expressions.Interpreter;

internal sealed class LoadFieldInstruction : FieldInstruction
{
	public override string InstructionName => null;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public LoadFieldInstruction(FieldInfo field)
		: base(null)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
