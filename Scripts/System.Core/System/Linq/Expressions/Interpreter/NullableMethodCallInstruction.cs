using System.Reflection;

namespace System.Linq.Expressions.Interpreter;

internal abstract class NullableMethodCallInstruction : Instruction
{
	private sealed class HasValue : NullableMethodCallInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GetValue : NullableMethodCallInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GetValueOrDefault : NullableMethodCallInstruction
	{
		private readonly Type _defaultValueType;

		public GetValueOrDefault(MethodInfo mi)
		{
		}

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GetValueOrDefault1 : NullableMethodCallInstruction
	{
		public override int ConsumedStack => 0;

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class EqualsClass : NullableMethodCallInstruction
	{
		public override int ConsumedStack => 0;

		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class ToStringClass : NullableMethodCallInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private sealed class GetHashCodeClass : NullableMethodCallInstruction
	{
		public override int Run(InterpretedFrame frame)
		{
			return 0;
		}
	}

	private static NullableMethodCallInstruction s_hasValue;

	private static NullableMethodCallInstruction s_value;

	private static NullableMethodCallInstruction s_equals;

	private static NullableMethodCallInstruction s_getHashCode;

	private static NullableMethodCallInstruction s_getValueOrDefault1;

	private static NullableMethodCallInstruction s_toString;

	public override int ConsumedStack => 0;

	public override int ProducedStack => 0;

	public override string InstructionName => null;

	private NullableMethodCallInstruction()
	{
	}

	public static Instruction Create(string method, int argCount, MethodInfo mi)
	{
		return null;
	}

	public static Instruction CreateGetValue()
	{
		return null;
	}
}
