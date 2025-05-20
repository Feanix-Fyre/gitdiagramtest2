using System.Reflection;

namespace System.Linq.Expressions.Interpreter;

internal abstract class FieldInstruction : Instruction
{
	protected readonly FieldInfo _field;

	public FieldInstruction(FieldInfo field)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
