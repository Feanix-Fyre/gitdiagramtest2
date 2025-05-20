using System;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
internal sealed class _AndroidJNIHelper
{
	public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy)
	{
		return (IntPtr)0;
	}

	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
	{
		return (IntPtr)0;
	}

	[RequiredByNativeCode]
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs)
	{
		return (IntPtr)0;
	}

	public static void CreateJNIArgArray(object[] args, Span<jvalue> ret)
	{
	}

	public static object UnboxArray(AndroidJavaObject obj)
	{
		return null;
	}

	public static object Unbox(AndroidJavaObject obj)
	{
		return null;
	}

	public static AndroidJavaObject Box(object obj)
	{
		return null;
	}

	public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs)
	{
	}

	public static IntPtr ConvertToJNIArray(Array array)
	{
		return (IntPtr)0;
	}

	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
	{
		return default(ArrayType);
	}

	public static IntPtr GetConstructorID(IntPtr jclass, object[] args)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetConstructorID(IntPtr jclass, string signature)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic)
	{
		return (IntPtr)0;
	}

	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic)
	{
		return (IntPtr)0;
	}

	public static string GetSignature(object obj)
	{
		return null;
	}

	public static string GetSignature(object[] args)
	{
		return null;
	}

	public static string GetSignature<ReturnType>(object[] args)
	{
		return null;
	}
}
