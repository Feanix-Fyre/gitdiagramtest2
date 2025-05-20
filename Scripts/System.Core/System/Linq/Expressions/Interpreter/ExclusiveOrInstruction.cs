namespace System.Linq.Expressions.Interpreter;

internal abstract class ExclusiveOrInstruction : Instruction
{
	private sealed class ExclusiveOrSByte : ExclusiveOrInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class ExclusiveOrInt16 : ExclusiveOrInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class ExclusiveOrInt32 : ExclusiveOrInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class ExclusiveOrInt64 : ExclusiveOrInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class ExclusiveOrByte : ExclusiveOrInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class ExclusiveOrUInt16 : ExclusiveOrInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class ExclusiveOrUInt32 : ExclusiveOrInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class ExclusiveOrUInt64 : ExclusiveOrInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class ExclusiveOrBoolean : ExclusiveOrInstruction
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

	private static Instruction s_Boolean;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	private ExclusiveOrInstruction()
	{
	}

	public static Instruction Create(Type type)
	{
		return null;
	}
}
