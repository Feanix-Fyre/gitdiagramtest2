namespace System.Linq.Expressions.Interpreter;

internal abstract class AndInstruction : Instruction
{
	private sealed class AndSByte : AndInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class AndInt16 : AndInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class AndInt32 : AndInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class AndInt64 : AndInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class AndByte : AndInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class AndUInt16 : AndInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class AndUInt32 : AndInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class AndUInt64 : AndInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class AndBoolean : AndInstruction
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

	private AndInstruction()
	{
	}

	public static Instruction Create(Type type)
	{
		return null;
	}
}
