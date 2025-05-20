namespace System.Linq.Expressions.Interpreter;

internal abstract class MulOvfInstruction : Instruction
{
	private sealed class MulOvfInt16 : MulOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class MulOvfInt32 : MulOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class MulOvfInt64 : MulOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class MulOvfUInt16 : MulOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class MulOvfUInt32 : MulOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class MulOvfUInt64 : MulOvfInstruction
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

	private MulOvfInstruction()
	{
	}

	public static Instruction Create(Type type)
	{
		return null;
	}
}
