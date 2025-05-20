namespace System.Linq.Expressions.Interpreter;

internal abstract class ByRefUpdater
{
	public readonly int ArgumentIndex;

	public ByRefUpdater(int argumentIndex)
	{
	}

	public abstract void Update(InterpretedFrame frame, object value);

	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals)
	{
	}
}
