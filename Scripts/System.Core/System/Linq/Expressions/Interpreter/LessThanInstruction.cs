namespace System.Linq.Expressions.Interpreter;

internal abstract class LessThanInstruction : Instruction
{
	private sealed class LessThanSByte : LessThanInstruction
	{
		public LessThanSByte(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanInt16 : LessThanInstruction
	{
		public LessThanInt16(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanChar : LessThanInstruction
	{
		public LessThanChar(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanInt32 : LessThanInstruction
	{
		public LessThanInt32(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanInt64 : LessThanInstruction
	{
		public LessThanInt64(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanByte : LessThanInstruction
	{
		public LessThanByte(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanUInt16 : LessThanInstruction
	{
		public LessThanUInt16(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanUInt32 : LessThanInstruction
	{
		public LessThanUInt32(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanUInt64 : LessThanInstruction
	{
		public LessThanUInt64(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanSingle : LessThanInstruction
	{
		public LessThanSingle(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class LessThanDouble : LessThanInstruction
	{
		public LessThanDouble(object nullValue)
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

	private LessThanInstruction(object nullValue)
	{
	}

	public static Instruction Create(Type type, bool liftedToNull = false)
	{
		return null;
	}
}
