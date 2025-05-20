namespace System.Linq.Expressions.Interpreter;

internal abstract class SubInstruction : Instruction
{
	private sealed class SubInt16 : SubInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class SubInt32 : SubInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class SubInt64 : SubInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class SubUInt16 : SubInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class SubUInt32 : SubInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class SubUInt64 : SubInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class SubSingle : SubInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class SubDouble : SubInstruction
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

	private SubInstruction()
	{
	}

	public static Instruction Create(Type type)
	{
		return null;
	}
}
