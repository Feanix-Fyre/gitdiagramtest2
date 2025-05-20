namespace System.Linq.Expressions.Interpreter;

internal abstract class LeftShiftInstruction : Instruction
{
	private sealed class LeftShiftSByte : LeftShiftInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LeftShiftInt16 : LeftShiftInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LeftShiftInt32 : LeftShiftInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LeftShiftInt64 : LeftShiftInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LeftShiftByte : LeftShiftInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LeftShiftUInt16 : LeftShiftInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LeftShiftUInt32 : LeftShiftInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LeftShiftUInt64 : LeftShiftInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private static Instruction s_SByte;

	private static Instruction s_Int16;

	private static Instruction s_Int32;

	private static Instruction s_Int64;

	private static Instruction s_Byte;

	private static Instruction s_UInt16;

	private static Instruction s_UInt32;

	private static Instruction s_UInt64;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	private LeftShiftInstruction()
	{
	}

	public static Instruction Create(Type type)
	{
		return null;
	}
}
