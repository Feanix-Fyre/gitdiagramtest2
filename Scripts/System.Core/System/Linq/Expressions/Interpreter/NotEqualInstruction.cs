namespace System.Linq.Expressions.Interpreter;

internal abstract class NotEqualInstruction : Instruction
{
	private sealed class NotEqualBoolean : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualSByte : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualInt16 : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualChar : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualInt32 : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualInt64 : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualByte : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualUInt16 : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualUInt32 : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualUInt64 : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualSingle : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualDouble : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualReference : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualSByteLiftedToNull : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualInt16LiftedToNull : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualCharLiftedToNull : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualInt32LiftedToNull : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualInt64LiftedToNull : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualByteLiftedToNull : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualUInt16LiftedToNull : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualUInt32LiftedToNull : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualUInt64LiftedToNull : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualSingleLiftedToNull : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class NotEqualDoubleLiftedToNull : NotEqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private static Instruction s_reference;

	private static Instruction s_Boolean;

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

	private static Instruction s_SByteLiftedToNull;

	private static Instruction s_Int16LiftedToNull;

	private static Instruction s_CharLiftedToNull;

	private static Instruction s_Int32LiftedToNull;

	private static Instruction s_Int64LiftedToNull;

	private static Instruction s_ByteLiftedToNull;

	private static Instruction s_UInt16LiftedToNull;

	private static Instruction s_UInt32LiftedToNull;

	private static Instruction s_UInt64LiftedToNull;

	private static Instruction s_SingleLiftedToNull;

	private static Instruction s_DoubleLiftedToNull;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	private NotEqualInstruction()
	{
	}

	public static Instruction Create(Type type, bool liftedToNull)
	{
		return null;
	}
}
