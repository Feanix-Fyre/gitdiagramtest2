namespace System.Linq.Expressions.Interpreter;

internal abstract class InitializeLocalInstruction : LocalAccessInstruction
{
	internal sealed class Reference : InitializeLocalInstruction, IBoxableInstruction
	{
		public override string InstructionName => null;

		internal Reference(int index)
			: base(0)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}

		public Instruction BoxIfIndexMatches(int index)
		{
			return null;
		}
	}

	internal sealed class ImmutableValue : InitializeLocalInstruction, IBoxableInstruction
	{
		private readonly object _defaultValue;

		public override string InstructionName => null;

		internal ImmutableValue(int index, object defaultValue)
			: base(0)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}

		public Instruction BoxIfIndexMatches(int index)
		{
			return null;
		}
	}

	internal sealed class ImmutableBox : InitializeLocalInstruction
	{
		private readonly object _defaultValue;

		public override string InstructionName => null;

		internal ImmutableBox(int index, object defaultValue)
			: base(0)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	internal sealed class ImmutableRefBox : InitializeLocalInstruction
	{
		public override string InstructionName => null;

		internal ImmutableRefBox(int index)
			: base(0)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	internal sealed class ParameterBox : InitializeLocalInstruction
	{
		public override string InstructionName => null;

		public ParameterBox(int index)
			: base(0)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	internal sealed class Parameter : InitializeLocalInstruction, IBoxableInstruction
	{
		public override string InstructionName => null;

		internal Parameter(int index)
			: base(0)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}

		public Instruction BoxIfIndexMatches(int index)
		{
			return null;
		}
	}

	internal sealed class MutableValue : InitializeLocalInstruction, IBoxableInstruction
	{
		private readonly Type _type;

		public override string InstructionName => null;

		internal MutableValue(int index, Type type)
			: base(0)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}

		public Instruction BoxIfIndexMatches(int index)
		{
			return null;
		}
	}

	internal sealed class MutableBox : InitializeLocalInstruction
	{
		private readonly Type _type;

		public override string InstructionName => null;

		internal MutableBox(int index, Type type)
			: base(0)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	internal InitializeLocalInstruction(int index)
		: base(0)
	{
	}
}
