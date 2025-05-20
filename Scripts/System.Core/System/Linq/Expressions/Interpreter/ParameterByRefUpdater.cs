namespace System.Linq.Expressions.Interpreter;

internal sealed class ParameterByRefUpdater : ByRefUpdater
{
	private readonly LocalVariable _parameter;

	public ParameterByRefUpdater(LocalVariable parameter, int argumentIndex)
		: base(0)
	{
	}

	public override void Update(InterpretedFrame frame, object value)
	{
	}
}
