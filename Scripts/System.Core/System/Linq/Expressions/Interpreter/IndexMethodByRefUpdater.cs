using System.Reflection;

namespace System.Linq.Expressions.Interpreter;

internal sealed class IndexMethodByRefUpdater : ByRefUpdater
{
	private readonly MethodInfo _indexer;

	private readonly LocalDefinition? _obj;

	private readonly LocalDefinition[] _args;

	public IndexMethodByRefUpdater(LocalDefinition? obj, LocalDefinition[] args, MethodInfo indexer, int argumentIndex)
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
