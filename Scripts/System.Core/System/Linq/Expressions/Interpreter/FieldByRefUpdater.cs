using System.Reflection;

namespace System.Linq.Expressions.Interpreter;

internal sealed class FieldByRefUpdater : ByRefUpdater
{
	private readonly LocalDefinition? _object;

	private readonly FieldInfo _field;

	public FieldByRefUpdater(LocalDefinition? obj, FieldInfo field, int argumentIndex)
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
