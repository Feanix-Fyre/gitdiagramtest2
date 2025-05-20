namespace System.Linq.Expressions.Interpreter;

internal abstract class NumericConvertInstruction : Instruction
{
	internal sealed class Unchecked : NumericConvertInstruction
	{
		public override string InstructionName => null;

		public Unchecked(TypeCode from, TypeCode to, bool isLiftedToNull)
			: base(default(TypeCode), default(TypeCode), isLiftedToNull: false)
		{
		}

		protected override object Convert(object obj)
		{
			return null;
		}

		private object ConvertInt32(int obj)
		{
			return null;
		}

		private object ConvertInt64(long obj)
		{
			return null;
		}

		private object ConvertUInt64(ulong obj)
		{
			return null;
		}

		private object ConvertDouble(double obj)
		{
			return null;
		}
	}

	internal sealed class Checked : NumericConvertInstruction
	{
		public override string InstructionName => null;

		public Checked(TypeCode from, TypeCode to, bool isLiftedToNull)
			: base(default(TypeCode), default(TypeCode), isLiftedToNull: false)
		{
		}

		protected override object Convert(object obj)
		{
			return null;
		}

		private object ConvertInt32(int obj)
		{
			return null;
		}

		private object ConvertInt64(long obj)
		{
			return null;
		}

		private object ConvertUInt64(ulong obj)
		{
			return null;
		}

		private object ConvertDouble(double obj)
		{
			return null;
		}
	}

	internal sealed class ToUnderlying : NumericConvertInstruction
	{
		public override string InstructionName => null;

		public ToUnderlying(TypeCode to, bool isLiftedToNull)
			: base(default(TypeCode), default(TypeCode), isLiftedToNull: false)
		{
		}

		protected override object Convert(object obj)
		{
			return null;
		}
	}

	internal readonly TypeCode _from;

	internal readonly TypeCode _to;

	private readonly bool _isLiftedToNull;

	public override string InstructionName => null;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	protected NumericConvertInstruction(TypeCode from, TypeCode to, bool isLiftedToNull)
	{
	}

	public sealed override int Run(InterpretedFrame frame)
	{
		return 0;
	}

	protected abstract object Convert(object obj);

	public override string ToString()
	{
		return null;
	}
}
