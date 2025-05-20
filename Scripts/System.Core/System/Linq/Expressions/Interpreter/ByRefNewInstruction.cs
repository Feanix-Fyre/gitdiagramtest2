using System.Reflection;

namespace System.Linq.Expressions.Interpreter;

internal class ByRefNewInstruction : NewInstruction
{
	private readonly ByRefUpdater[] _byrefArgs;

	public override string InstructionName => null;

	internal ByRefNewInstruction(ConstructorInfo target, int argumentCount, ByRefUpdater[] byrefArgs)
		: base(null, 0)
	{
	}

	public sealed override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
