namespace System.Linq.Expressions.Interpreter;

internal abstract class LessThanOrEqualInstruction : Instruction
{
	private sealed class LessThanOrEqualSByte : LessThanOrEqualInstruction
	{
		public LessThanOrEqualSByte(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanOrEqualInt16 : LessThanOrEqualInstruction
	{
		public LessThanOrEqualInt16(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanOrEqualChar : LessThanOrEqualInstruction
	{
		public LessThanOrEqualChar(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanOrEqualInt32 : LessThanOrEqualInstruction
	{
		public LessThanOrEqualInt32(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanOrEqualInt64 : LessThanOrEqualInstruction
	{
		public LessThanOrEqualInt64(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanOrEqualByte : LessThanOrEqualInstruction
	{
		public LessThanOrEqualByte(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanOrEqualUInt16 : LessThanOrEqualInstruction
	{
		public LessThanOrEqualUInt16(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanOrEqualUInt32 : LessThanOrEqualInstruction
	{
		public LessThanOrEqualUInt32(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanOrEqualUInt64 : LessThanOrEqualInstruction
	{
		public LessThanOrEqualUInt64(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanOrEqualSingle : LessThanOrEqualInstruction
	{
		public LessThanOrEqualSingle(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanOrEqualDouble : LessThanOrEqualInstruction
	{
		public LessThanOrEqualDouble(object nullValue)
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

	private LessThanOrEqualInstruction(object nullValue)
	{
	}

	public static Instruction Create(Type type, bool liftedToNull = false)
	{
		return null;
	}
}
