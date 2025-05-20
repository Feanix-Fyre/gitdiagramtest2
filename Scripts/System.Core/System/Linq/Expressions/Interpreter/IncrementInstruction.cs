namespace System.Linq.Expressions.Interpreter;

internal abstract class IncrementInstruction : Instruction
{
	private sealed class IncrementInt16 : IncrementInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class IncrementInt32 : IncrementInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class IncrementInt64 : IncrementInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class IncrementUInt16 : IncrementInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class IncrementUInt32 : IncrementInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class IncrementUInt64 : IncrementInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class IncrementSingle : IncrementInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class IncrementDouble : IncrementInstruction
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

	private static Instruction s_Single;

	private static Instruction s_Double;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	private IncrementInstruction()
	{
	}

	public static Instruction Create(Type type)
	{
		return null;
	}
}
