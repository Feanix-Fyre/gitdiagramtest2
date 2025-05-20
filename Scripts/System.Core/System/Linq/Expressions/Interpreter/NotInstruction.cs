namespace System.Linq.Expressions.Interpreter;

internal abstract class NotInstruction : Instruction
{
	private sealed class NotBoolean : NotInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotInt64 : NotInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotInt32 : NotInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotInt16 : NotInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotUInt64 : NotInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotUInt32 : NotInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotUInt16 : NotInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotByte : NotInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotSByte : NotInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	public static Instruction s_Boolean;

	public static Instruction s_Int64;

	public static Instruction s_Int32;

	public static Instruction s_Int16;

	public static Instruction s_UInt64;

	public static Instruction s_UInt32;

	public static Instruction s_UInt16;

	public static Instruction s_Byte;

	public static Instruction s_SByte;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	private NotInstruction()
	{
	}

	public static Instruction Create(Type type)
	{
		return null;
	}
}
