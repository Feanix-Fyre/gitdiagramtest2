using System.Reflection;

namespace System.Dynamic.Utils;

internal static class TypeExtensions
{
	private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache;

	public static MethodInfo GetAnyStaticMethodValidated(this Type type, string name, Type[] types)
	{
		return null;
	}

	private static bool MatchesArgumentTypes(this MethodInfo mi, Type[] argTypes)
	{
		return false;
	}

	public static Type GetReturnType(this MethodBase mi)
	{
		return null;
	}

	public static TypeCode GetTypeCode(this Type type)
	{
		return default(TypeCode);
	}

	internal static ParameterInfo[] GetParametersCached(this MethodBase method)
	{
		return null;
	}
}
