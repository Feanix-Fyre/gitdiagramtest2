namespace System.Linq.Expressions.Interpreter;

internal abstract class GreaterThanInstruction : Instruction
{
	private sealed class GreaterThanSByte : GreaterThanInstruction
	{
		public GreaterThanSByte(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanInt16 : GreaterThanInstruction
	{
		public GreaterThanInt16(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanChar : GreaterThanInstruction
	{
		public GreaterThanChar(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanInt32 : GreaterThanInstruction
	{
		public GreaterThanInt32(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanInt64 : GreaterThanInstruction
	{
		public GreaterThanInt64(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanByte : GreaterThanInstruction
	{
		public GreaterThanByte(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanUInt16 : GreaterThanInstruction
	{
		public GreaterThanUInt16(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanUInt32 : GreaterThanInstruction
	{
		public GreaterThanUInt32(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanUInt64 : GreaterThanInstruction
	{
		public GreaterThanUInt64(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanSingle : GreaterThanInstruction
	{
		public GreaterThanSingle(object nullValue)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GreaterThanDouble : GreaterThanInstruction
	{
		public GreaterThanDouble(object nullValue)
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

	private GreaterThanInstruction(object nullValue)
	{
	}

	public static Instruction Create(Type type, bool liftedToNull = false)
	{
		return null;
	}
}
