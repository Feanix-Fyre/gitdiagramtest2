namespace System.Linq.Expressions.Interpreter;

internal abstract class GreaterThanOrEqualInstruction : Instruction
{
	private sealed class GreaterThanOrEqualSByte : GreaterThanOrEqualInstruction
	{
		public GreaterThanOrEqualSByte(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanOrEqualInt16 : GreaterThanOrEqualInstruction
	{
		public GreaterThanOrEqualInt16(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanOrEqualChar : GreaterThanOrEqualInstruction
	{
		public GreaterThanOrEqualChar(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanOrEqualInt32 : GreaterThanOrEqualInstruction
	{
		public GreaterThanOrEqualInt32(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanOrEqualInt64 : GreaterThanOrEqualInstruction
	{
		public GreaterThanOrEqualInt64(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanOrEqualByte : GreaterThanOrEqualInstruction
	{
		public GreaterThanOrEqualByte(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanOrEqualUInt16 : GreaterThanOrEqualInstruction
	{
		public GreaterThanOrEqualUInt16(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanOrEqualUInt32 : GreaterThanOrEqualInstruction
	{
		public GreaterThanOrEqualUInt32(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanOrEqualUInt64 : GreaterThanOrEqualInstruction
	{
		public GreaterThanOrEqualUInt64(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanOrEqualSingle : GreaterThanOrEqualInstruction
	{
		public GreaterThanOrEqualSingle(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanOrEqualDouble : GreaterThanOrEqualInstruction
	{
		public GreaterThanOrEqualDouble(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private readonly object _nullValue;

	private static Instruction s_SByte;

	private static Instruction s_Int16;

	private static Instruction s_Char;

	private static Instruction s_Int32;

	private static Instruction s_Int64;

	private static Instruction s_Byte;

	private static Instruction s_UInt16;

	private static Instruction s_UInt32;

	private static Instruction s_UInt64;

	private static Instruction s_Single;

	private static Instruction s_Double;

	private static Instruction s_liftedToNullSByte;

	private static Instruction s_liftedToNullInt16;

	private static Instruction s_liftedToNullChar;

	private static Instruction s_liftedToNullInt32;

	private static Instruction s_liftedToNullInt64;

	private static Instruction s_liftedToNullByte;

	private static Instruction s_liftedToNullUInt16;

	private static Instruction s_liftedToNullUInt32;

	private static Instruction s_liftedToNullUInt64;

	private static Instruction s_liftedToNullSingle;

	private static Instruction s_liftedToNullDouble;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	private GreaterThanOrEqualInstruction(object nullValue)
	{
	}

	public static Instruction Create(Type type, bool liftedToNull = false)
	{
		return null;
	}
}
