using System.Reflection;

namespace System.Linq.Expressions.Interpreter;

internal class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction
{
	private readonly ByRefUpdater[] _byrefArgs;

	public override int ProducedStack => 0;

	internal ByRefMethodInfoCallInstruction(MethodInfo target, int argumentCount, ByRefUpdater[] byrefArgs)
		: base(null, 0)
	{
	}

	public sealed override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
