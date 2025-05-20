namespace System.Linq.Expressions.Interpreter;

internal abstract class AddOvfInstruction : Instruction
{
	private sealed class AddOvfInt16 : AddOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class AddOvfInt32 : AddOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class AddOvfInt64 : AddOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class AddOvfUInt16 : AddOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class AddOvfUInt32 : AddOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class AddOvfUInt64 : AddOvfInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private static Instruction s_Int16;

	private static Instruction s_Int32;

	private static Instruction s_Int64;

	private static Instruction s_UInt16;

	private static Instruction s_UInt32;

	private static Instruction s_UInt64;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	private AddOvfInstruction()
	{
	}

	public static Instruction Create(Type type)
	{
		return null;
	}
}
