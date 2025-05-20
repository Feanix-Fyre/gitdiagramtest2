namespace System.Linq.Expressions.Interpreter;

internal sealed class ArrayByRefUpdater : ByRefUpdater
{
	private readonly LocalDefinition _array;

	private readonly LocalDefinition _index;

	public ArrayByRefUpdater(LocalDefinition array, LocalDefinition index, int argumentIndex)
		: base(0)
	{
	}

	public override void Update(InterpretedFrame frame, object value)
	{
	}

	public override void UndefineTemps(InstructionList instructions, LocalVariables locals)
	{
	}
}
