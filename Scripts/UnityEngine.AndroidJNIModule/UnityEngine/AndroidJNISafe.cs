using System;

namespace UnityEngine;

internal class AndroidJNISafe
{
	public static void CheckException()
	{
	}

	public static void QueueDeleteGlobalRef(IntPtr globalref)
	{
	}

	public static void DeleteWeakGlobalRef(IntPtr globalref)
	{
	}

	public static void DeleteLocalRef(IntPtr localref)
	{
	}

	public static IntPtr NewString(string chars)
	{
		return (IntPtr)0;
	}

	public static string GetStringChars(IntPtr str)
	{
		return null;
	}

	public static IntPtr GetObjectClass(IntPtr ptr)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetMethodID(IntPtr obj, string name, string sig)
	{
		return (IntPtr)0;
	}

	public static IntPtr FromReflectedMethod(IntPtr refMethod)
	{
		return (IntPtr)0;
	}

	public static IntPtr FindClass(string name)
	{
		return (IntPtr)0;
	}

	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return (IntPtr)0;
	}

	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
	}

	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
	}

	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return (IntPtr)0;
	}

	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return (IntPtr)0;
	}

	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return null;
	}

	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return '\0';
	}

	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0.0;
	}

	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0f;
	}

	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0L;
	}

	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return false;
	}

	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return (IntPtr)0;
	}

	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return null;
	}

	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return '\0';
	}

	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0.0;
	}

	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0f;
	}

	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0L;
	}

	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return false;
	}

	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	public static char[] FromCharArray(IntPtr array)
	{
		return null;
	}

	public static double[] FromDoubleArray(IntPtr array)
	{
		return null;
	}

	public static float[] FromFloatArray(IntPtr array)
	{
		return null;
	}

	public static long[] FromLongArray(IntPtr array)
	{
		return null;
	}

	public static short[] FromShortArray(IntPtr array)
	{
		return null;
	}

	public static byte[] FromByteArray(IntPtr array)
	{
		return null;
	}

	public static sbyte[] FromSByteArray(IntPtr array)
	{
		return null;
	}

	public static bool[] FromBooleanArray(IntPtr array)
	{
		return null;
	}

	public static int[] FromIntArray(IntPtr array)
	{
		return null;
	}

	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToCharArray(char[] array)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToDoubleArray(double[] array)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToFloatArray(float[] array)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToLongArray(long[] array)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToShortArray(short[] array)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToByteArray(byte[] array)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToSByteArray(sbyte[] array)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToBooleanArray(bool[] array)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToIntArray(int[] array)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetObjectArrayElement(IntPtr array, int index)
	{
		return (IntPtr)0;
	}

	public static int GetArrayLength(IntPtr array)
	{
		return 0;
	}
}
