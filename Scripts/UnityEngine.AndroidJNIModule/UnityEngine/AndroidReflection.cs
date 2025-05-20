using System;

namespace UnityEngine;

internal class AndroidReflection
{
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass;

	private static readonly IntPtr s_ReflectionHelperGetConstructorID;

	private static readonly IntPtr s_ReflectionHelperGetMethodID;

	private static readonly IntPtr s_ReflectionHelperGetFieldID;

	private static readonly IntPtr s_ReflectionHelperGetFieldSignature;

	private static readonly IntPtr s_ReflectionHelperNewProxyInstance;

	private static readonly IntPtr s_ReflectionHelperSetNativeExceptionOnProxy;

	private static readonly IntPtr s_FieldGetDeclaringClass;

	public static bool IsPrimitive(Type t)
	{
		return false;
	}

	public static bool IsAssignableFrom(Type t, Type from)
	{
		return false;
	}

	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature)
	{
		return (IntPtr)0;
	}

	private static IntPtr GetMethodID(string clazz, string methodName, string signature)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetConstructorMember(IntPtr jclass, string signature)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic)
	{
		return (IntPtr)0;
	}

	public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze)
	{
		return (IntPtr)0;
	}

	public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound)
	{
	}
}
