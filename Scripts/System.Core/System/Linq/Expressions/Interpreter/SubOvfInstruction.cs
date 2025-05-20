namespace System.Linq.Expressions.Interpreter;

internal abstract class SubOvfInstruction : Instruction
{
	private sealed class SubOvfInt16 : SubOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class SubOvfInt32 : SubOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class SubOvfInt64 : SubOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class SubOvfUInt16 : SubOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class SubOvfUInt32 : SubOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class SubOvfUInt64 : SubOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private static Instruction s_Int16;

	private static Instruction s_Int32;

	private static Instruction s_Int64;

	private static Instruction s_UInt16;

	private static Instruction s_UInt32;

	private static Instruction s_UInt64;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	private SubOvfInstruction()
	{
	}

	public static Instruction Create(Type type)
	{
		return null;
	}
}
