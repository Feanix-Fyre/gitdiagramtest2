namespace System.Linq.Expressions.Interpreter;

internal sealed class CastToEnumInstruction : CastInstruction
{
	private readonly Type _t;

	public CastToEnumInstruction(Type t)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
