using System.Reflection;

namespace System.Linq.Expressions.Interpreter;

internal sealed class LoadStaticFieldInstruction : FieldInstruction
{
	public override string InstructionName => null;

	public override int ProducedStack => 0;

	public LoadStaticFieldInstruction(FieldInfo field)
		: base(null)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
