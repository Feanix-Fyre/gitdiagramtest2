using System.Reflection;

namespace System.Linq.Expressions.Interpreter;

internal sealed class StoreStaticFieldInstruction : FieldInstruction
{
	public override string InstructionName => null;

	public override int ConsumedStack => 0;

	public StoreStaticFieldInstruction(FieldInfo field)
		: base(null)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
