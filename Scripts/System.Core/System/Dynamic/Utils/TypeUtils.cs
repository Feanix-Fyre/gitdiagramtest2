using System.Reflection;

namespace System.Dynamic.Utils;

internal static class TypeUtils
{
	private static readonly Type[] s_arrayAssignableInterfaces;

	public static Type GetNonNullableType(this Type type)
	{
		return null;
	}

	public static Type GetNullableType(this Type type)
	{
		return null;
	}

	public static bool IsNullableType(this Type type)
	{
		return false;
	}

	public static bool IsNullableOrReferenceType(this Type type)
	{
		return false;
	}

	public static bool IsBool(this Type type)
	{
		return false;
	}

	public static bool IsNumeric(this Type type)
	{
		return false;
	}

	public static bool IsInteger(this Type type)
	{
		return false;
	}

	public static bool IsArithmetic(this Type type)
	{
		return false;
	}

	public static bool IsUnsignedInt(this Type type)
	{
		return false;
	}

	public static bool IsIntegerOrBool(this Type type)
	{
		return false;
	}

	public static bool IsNumericOrBool(this Type type)
	{
		return false;
	}

	public static bool IsValidInstanceType(MemberInfo member, Type instanceType)
	{
		return false;
	}

	public static bool HasIdentityPrimitiveOrNullableConversionTo(this Type source, Type dest)
	{
		return false;
	}

	public static bool HasReferenceConversionTo(this Type source, Type dest)
	{
		return false;
	}

	private static bool StrictHasReferenceConversionTo(this Type source, Type dest, bool skipNonArray)
	{
		return false;
	}

	private static bool HasArrayToInterfaceConversion(Type source, Type dest)
	{
		return false;
	}

	private static bool HasInterfaceToArrayConversion(Type source, Type dest)
	{
		return false;
	}

	private static bool IsCovariant(Type t)
	{
		return false;
	}

	private static bool IsContravariant(Type t)
	{
		return false;
	}

	private static bool IsInvariant(Type t)
	{
		return false;
	}

	private static bool IsDelegate(Type t)
	{
		return false;
	}

	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest)
	{
		return false;
	}

	public static bool IsConvertible(this Type type)
	{
		return false;
	}

	public static bool HasReferenceEquality(Type left, Type right)
	{
		return false;
	}

	public static bool HasBuiltInEqualityOperator(Type left, Type right)
	{
		return false;
	}

	public static bool IsImplicitlyConvertibleTo(this Type source, Type destination)
	{
		return false;
	}

	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType)
	{
		return null;
	}

	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo)
	{
		return null;
	}

	private static bool IsImplicitNumericConversion(Type source, Type destination)
	{
		return false;
	}

	private static bool IsImplicitReferenceConversion(Type source, Type destination)
	{
		return false;
	}

	private static bool IsImplicitBoxingConversion(Type source, Type destination)
	{
		return false;
	}

	private static bool IsImplicitNullableConversion(Type source, Type destination)
	{
		return false;
	}

	public static Type FindGenericType(Type definition, Type type)
	{
		return null;
	}

	public static MethodInfo GetBooleanOperator(Type type, string name)
	{
		return null;
	}

	public static Type GetNonRefType(this Type type)
	{
		return null;
	}

	public static bool AreEquivalent(Type t1, Type t2)
	{
		return false;
	}

	public static bool AreReferenceAssignable(Type dest, Type src)
	{
		return false;
	}

	public static bool IsSameOrSubclass(Type type, Type subType)
	{
		return false;
	}

	public static void ValidateType(Type type, string paramName)
	{
	}

	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer)
	{
	}

	public static bool ValidateType(Type type, string paramName, int index)
	{
		return false;
	}

	public static MethodInfo GetInvokeMethod(this Type delegateType)
	{
		return null;
	}
}
