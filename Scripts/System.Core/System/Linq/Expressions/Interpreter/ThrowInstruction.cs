namespace System.Linq.Expressions.Interpreter;

internal sealed class ThrowInstruction : Instruction
{
	internal static readonly ThrowInstruction Throw;

	internal static readonly ThrowInstruction VoidThrow;

	internal static readonly ThrowInstruction Rethrow;

	internal static readonly ThrowInstruction VoidRethrow;

	private readonly bool _hasResult;

	private readonly bool _rethrow;

	public override string InstructionName => null;

	public override int ProducedStack => 0;

	public override int ConsumedStack => 0;

	private ThrowInstruction(bool hasResult, bool isRethrow)
	{
	}

	public override int Run(InterpretedFrame frame)
	{
		return 0;
	}

	private static Exception WrapThrownObject(object thrown)
	{
		return null;
	}
}
