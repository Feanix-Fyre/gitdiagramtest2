namespace System.Linq.Expressions.Interpreter;

internal abstract class EqualInstruction : Instruction
{
	private sealed class EqualBoolean : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualSByte : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualInt16 : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualChar : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualInt32 : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualInt64 : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualByte : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualUInt16 : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualUInt32 : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualUInt64 : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualSingle : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualDouble : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualReference : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualBooleanLiftedToNull : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualSByteLiftedToNull : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualInt16LiftedToNull : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualCharLiftedToNull : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualInt32LiftedToNull : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualInt64LiftedToNull : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualByteLiftedToNull : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualUInt16LiftedToNull : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualUInt32LiftedToNull : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualUInt64LiftedToNull : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualSingleLiftedToNull : EqualInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualDoubleLiftedToNull : EqualInstruction
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

	private static Instruction s_BooleanLiftedToNull;

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

	private EqualInstruction()
	{
	}

	public static Instruction Create(Type type, bool liftedToNull)
	{
		return null;
	}
}
