using System.Reflection;

namespace System;

internal static class SecurityUtils
{
	private static void DemandReflectionAccess(Type type)
	{
	}

	private static void DemandGrantSet(Assembly assembly)
	{
	}

	private static bool HasReflectionPermission(Type type)
	{
		return false;
	}

	internal static object SecureCreateInstance(Type type)
	{
		return null;
	}

	internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic)
	{
		return null;
	}

	internal static object SecureCreateInstance(Type type, object[] args)
	{
		return null;
	}

	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic)
	{
		return null;
	}

	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags)
	{
		return null;
	}

	private static bool GenericArgumentsAreVisible(MethodInfo method)
	{
		return false;
	}

	internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args)
	{
		return null;
	}
}
