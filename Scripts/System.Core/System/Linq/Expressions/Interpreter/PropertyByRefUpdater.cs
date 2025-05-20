using System.Reflection;

namespace System.Linq.Expressions.Interpreter;

internal sealed class PropertyByRefUpdater : ByRefUpdater
{
	private readonly LocalDefinition? _object;

	private readonly PropertyInfo _property;

	public PropertyByRefUpdater(LocalDefinition? obj, PropertyInfo property, int argumentIndex)
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
