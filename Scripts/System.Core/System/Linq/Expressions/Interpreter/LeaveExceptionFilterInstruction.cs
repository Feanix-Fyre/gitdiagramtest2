using System.Diagnostics.CodeAnalysis;

namespace System.Linq.Expressions.Interpreter;

internal sealed class LeaveExceptionFilterInstruction : Instruction
{
	internal static readonly LeaveExceptionFilterInstruction Instance;

	public override string InstructionName => null;

	public override int ConsumedStack => 0;

	private LeaveExceptionFilterInstruction()
	{
	}

	[ExcludeFromCodeCoverage]
	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
