using System.Globalization;
using System.Reflection;

namespace System;

[Serializable]
internal class DefaultBinder : Binder
{
	internal class BinderState
	{
		internal int[] m_argsMap;

		internal int m_originalSize;

		internal bool m_isParamArray;

		internal BinderState(int[] argsMap, int originalSize, bool isParamArray)
		{
		}
	}

	[Flags]
	private enum Primitives
	{
		Boolean = 8,
		Char = 0x10,
		SByte = 0x20,
		Byte = 0x40,
		Int16 = 0x80,
		UInt16 = 0x100,
		Int32 = 0x200,
		UInt32 = 0x400,
		Int64 = 0x800,
		UInt64 = 0x1000,
		Single = 0x2000,
		Double = 0x4000,
		Decimal = 0x8000,
		DateTime = 0x10000,
		String = 0x40000
	}

	private static Primitives[] _primitiveConversions;

	public override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, string[] names, out object state)
	{
		state = null;
		return null;
	}

	public override FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo)
	{
		return null;
	}

	public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers)
	{
		return null;
	}

	public override object ChangeType(object value, Type type, CultureInfo cultureInfo)
	{
		return null;
	}

	public override void ReorderArgumentArray(ref object[] args, object state)
	{
	}

	public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	private static int FindMostSpecific(ParameterInfo[] p1, int[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args)
	{
		return 0;
	}

	private static int FindMostSpecificType(Type c1, Type c2, Type t)
	{
		return 0;
	}

	private static int FindMostSpecificMethod(MethodBase m1, int[] paramOrder1, Type paramArrayType1, MethodBase m2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args)
	{
		return 0;
	}

	private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2)
	{
		return 0;
	}

	private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2)
	{
		return 0;
	}

	internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2)
	{
		return false;
	}

	internal static int GetHierarchyDepth(Type t)
	{
		return 0;
	}

	internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches)
	{
		return null;
	}

	private static void ReorderParams(int[] paramOrder, object[] vars)
	{
	}

	private static bool CreateParamOrder(int[] paramOrder, ParameterInfo[] pars, string[] names)
	{
		return false;
	}

	private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target)
	{
		return false;
	}

	private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type)
	{
		return false;
	}

	internal static bool CompareMethodSig(MethodBase m1, MethodBase m2)
	{
		return false;
	}

	public sealed override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	private static bool CanChangePrimitive(Type source, Type target)
	{
		return false;
	}

	private static bool CanPrimitiveWiden(Type source, Type target)
	{
		return false;
	}
}
