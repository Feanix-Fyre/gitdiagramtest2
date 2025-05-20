using System.Reflection;

namespace System.Linq.Expressions.Interpreter;

internal abstract class CallInstruction : Instruction
{
	public abstract int ArgumentCount { get; }

	public override string InstructionName => null;

	public override int ConsumedStack => 0;

	public static CallInstruction Create(MethodInfo info)
	{
		return null;
	}

	public static CallInstruction Create(MethodInfo info, ParameterInfo[] parameters)
	{
		return null;
	}

	private static CallInstruction GetArrayAccessor(MethodInfo info, int argumentCount)
	{
		return null;
	}

	public static void ArrayItemSetter1(Array array, int index0, object value)
	{
	}

	public static void ArrayItemSetter2(Array array, int index0, int index1, object value)
	{
	}

	public static void ArrayItemSetter3(Array array, int index0, int index1, int index2, object value)
	{
	}

	protected static bool TryGetLightLambdaTarget(object instance, out LightLambda lightLambda)
	{
		lightLambda = null;
		return false;
	}

	protected object InterpretLambdaInvoke(LightLambda targetLambda, object[] args)
	{
		return null;
	}
}
