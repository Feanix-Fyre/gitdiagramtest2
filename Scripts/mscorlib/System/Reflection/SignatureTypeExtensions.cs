namespace System.Reflection;

internal static class SignatureTypeExtensions
{
	public static bool MatchesParameterTypeExactly(this Type pattern, ParameterInfo parameter)
	{
		return false;
	}

	internal static bool MatchesExactly(this SignatureType pattern, Type actual)
	{
		return false;
	}

	internal static Type TryResolveAgainstGenericMethod(this SignatureType signatureType, MethodInfo genericMethod)
	{
		return null;
	}

	private static Type TryResolve(this SignatureType signatureType, Type[] genericMethodParameters)
	{
		return null;
	}

	private static Type TryMakeArrayType(this Type type)
	{
		return null;
	}

	private static Type TryMakeArrayType(this Type type, int rank)
	{
		return null;
	}

	private static Type TryMakeByRefType(this Type type)
	{
		return null;
	}

	private static Type TryMakePointerType(this Type type)
	{
		return null;
	}

	private static Type TryMakeGenericType(this Type type, Type[] instantiation)
	{
		return null;
	}
}
