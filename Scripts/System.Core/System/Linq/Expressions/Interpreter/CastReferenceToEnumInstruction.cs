namespace System.Linq.Expressions.Interpreter;

internal sealed class CastReferenceToEnumInstruction : CastInstruction
{
	private readonly Type _t;

	public CastReferenceToEnumInstruction(Type t)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
