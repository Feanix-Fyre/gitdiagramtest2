using System.Reflection;

namespace System.Linq.Expressions.Interpreter;

internal class MethodInfoCallInstruction : CallInstruction
{
	protected readonly MethodInfo _target;

	protected readonly int _argumentCount;

	public override int ArgumentCount => 0;

	public override int ProducedStack => 0;

	internal MethodInfoCallInstruction(MethodInfo target, int argumentCount)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}

	protected object[] GetArgs(InterpretedFrame frame, int first, int skip)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
