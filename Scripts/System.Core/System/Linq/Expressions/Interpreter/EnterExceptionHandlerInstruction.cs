using System.Diagnostics.CodeAnalysis;

namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterExceptionHandlerInstruction : Instruction
{
	internal static readonly EnterExceptionHandlerInstruction Void;

	internal static readonly EnterExceptionHandlerInstruction NonVoid;

	private readonly bool _hasValue;

	public override string InstructionName => null;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	private EnterExceptionHandlerInstruction(bool hasValue)
	{
	}

	[ExcludeFromCodeCoverage]
	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}
}
