using System;
using System.Reflection;

namespace UnityEngine.InputSystem.Utilities;

internal static class TypeHelpers
{
	public static TObject As<TObject>(this object obj)
	{
		return default(TObject);
	}

	public static bool IsInt(this TypeCode type)
	{
		return false;
	}

	public static Type GetValueType(MemberInfo member)
	{
		return null;
	}

	public static string GetNiceTypeName(this Type type)
	{
		return null;
	}

	public static Type GetGenericTypeArgumentFromHierarchy(Type type, Type genericTypeDefinition, int argumentIndex)
	{
		return null;
	}
}
