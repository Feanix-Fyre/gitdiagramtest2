using System;
using UnityEngine.Bindings;

namespace UnityEngine;

[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType.DoubleColon)]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[NativeConditional("PLATFORM_ANDROID")]
public static class AndroidJNI
{
	[ThreadSafe]
	public static IntPtr FindClass(string name)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr FromReflectedMethod(IntPtr refMethod)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr ExceptionOccurred()
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static void ExceptionClear()
	{
	}

	[ThreadSafe]
	public static IntPtr NewGlobalRef(IntPtr obj)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	internal static void QueueDeleteGlobalRef(IntPtr obj)
	{
	}

	[ThreadSafe]
	public static IntPtr NewWeakGlobalRef(IntPtr obj)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static void DeleteWeakGlobalRef(IntPtr obj)
	{
	}

	[ThreadSafe]
	public static IntPtr NewLocalRef(IntPtr obj)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static void DeleteLocalRef(IntPtr obj)
	{
	}

	[ThreadSafe]
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2)
	{
		return false;
	}

	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr GetObjectClass(IntPtr obj)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
	{
		return (IntPtr)0;
	}

	public static IntPtr NewString(string chars)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	private static IntPtr NewStringFromStr(string chars)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static string GetStringChars(IntPtr str)
	{
		return null;
	}

	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
	{
		return null;
	}

	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return null;
	}

	[ThreadSafe]
	public unsafe static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return null;
	}

	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return (IntPtr)0;
	}

	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	[ThreadSafe]
	public unsafe static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return 0;
	}

	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return false;
	}

	[ThreadSafe]
	public unsafe static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return false;
	}

	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	[ThreadSafe]
	public unsafe static short CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return 0;
	}

	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	[ThreadSafe]
	public unsafe static sbyte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return 0;
	}

	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return '\0';
	}

	[ThreadSafe]
	public unsafe static char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return '\0';
	}

	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0f;
	}

	[ThreadSafe]
	public unsafe static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return 0f;
	}

	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0.0;
	}

	[ThreadSafe]
	public unsafe static double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return 0.0;
	}

	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
	{
		return 0L;
	}

	[ThreadSafe]
	public unsafe static long CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
	{
		return 0L;
	}

	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
	{
		return null;
	}

	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return null;
	}

	[ThreadSafe]
	public unsafe static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return null;
	}

	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return (IntPtr)0;
	}

	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	[ThreadSafe]
	public unsafe static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return 0;
	}

	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return false;
	}

	[ThreadSafe]
	public unsafe static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return false;
	}

	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	[ThreadSafe]
	public unsafe static short CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return 0;
	}

	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0;
	}

	[ThreadSafe]
	public unsafe static sbyte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return 0;
	}

	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return '\0';
	}

	[ThreadSafe]
	public unsafe static char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return '\0';
	}

	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0f;
	}

	[ThreadSafe]
	public unsafe static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return 0f;
	}

	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0.0;
	}

	[ThreadSafe]
	public unsafe static double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return 0.0;
	}

	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
		return 0L;
	}

	[ThreadSafe]
	public unsafe static long CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
		return 0L;
	}

	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
	{
	}

	[ThreadSafe]
	public unsafe static void CallStaticVoidMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
	{
	}

	[ThreadSafe]
	public static IntPtr ToBooleanArray(bool[] array)
	{
		return (IntPtr)0;
	}

	[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
	[ThreadSafe]
	public static IntPtr ToByteArray(byte[] array)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToSByteArray(sbyte[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToSByteArray(sbyte* array, int length)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToCharArray(char[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToCharArray(char* array, int length)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToShortArray(short[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToShortArray(short* array, int length)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToIntArray(int[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToIntArray(int* array, int length)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToLongArray(long[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToLongArray(long* array, int length)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToFloatArray(float[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToFloatArray(float* array, int length)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToDoubleArray(double[] array)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToDoubleArray(double* array, int length)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public unsafe static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass)
	{
		return (IntPtr)0;
	}

	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static bool[] FromBooleanArray(IntPtr array)
	{
		return null;
	}

	[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
	[ThreadSafe]
	public static byte[] FromByteArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static sbyte[] FromSByteArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static char[] FromCharArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static short[] FromShortArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static int[] FromIntArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static long[] FromLongArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static float[] FromFloatArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static double[] FromDoubleArray(IntPtr array)
	{
		return null;
	}

	[ThreadSafe]
	public static int GetArrayLength(IntPtr array)
	{
		return 0;
	}

	[ThreadSafe]
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static IntPtr GetObjectArrayElement(IntPtr array, int index)
	{
		return (IntPtr)0;
	}

	[ThreadSafe]
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj)
	{
	}
}
