namespace System.Linq.Expressions.Interpreter;

internal abstract class NegateCheckedInstruction : Instruction
{
	private sealed class NegateCheckedInt32 : NegateCheckedInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NegateCheckedInt16 : NegateCheckedInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NegateCheckedInt64 : NegateCheckedInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private static Instruction s_Int16;

	private static Instruction s_Int32;

	private static Instruction s_Int64;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	private NegateCheckedInstruction()
	{
	}

	public static Instruction Create(Type type)
	{
		return null;
	}
}
