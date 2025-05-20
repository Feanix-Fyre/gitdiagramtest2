namespace System.Linq.Expressions.Interpreter;

internal abstract class CastInstruction : Instruction
{
	private sealed class CastInstructionT<T> : CastInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private abstract class CastInstructionNoT : CastInstruction
	{
		private sealed class Ref : CastInstructionNoT
		{
			public Ref(Type t)
				: base(null)
			{
			}

			protected override void ConvertNull(InterpretedFrame frame)
			{
			}
		}

		private sealed class Value : CastInstructionNoT
		{
			public Value(Type t)
				: base(null)
			{
			}

			protected override void ConvertNull(InterpretedFrame frame)
			{
			}
		}

		private readonly Type _t;

		protected CastInstructionNoT(Type t)
		{
		}

		public new static CastInstruction Create(Type t)
		{
			return null;
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}

		protected abstract void ConvertNull(InterpretedFrame frame);
	}

	private static CastInstruction s_Boolean;

	private static CastInstruction s_Byte;

	private static CastInstruction s_Char;

	private static CastInstruction s_DateTime;

	private static CastInstruction s_Decimal;

	private static CastInstruction s_Double;

	private static CastInstruction s_Int16;

	private static CastInstruction s_Int32;

	private static CastInstruction s_Int64;

	private static CastInstruction s_SByte;

	private static CastInstruction s_Single;

	private static CastInstruction s_String;

	private static CastInstruction s_UInt16;

	private static CastInstruction s_UInt32;

	private static CastInstruction s_UInt64;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	public static Instruction Create(Type t)
	{
		return null;
	}
}
