using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Unity.Burst;

namespace Unity.Collections;

[BurstCompatible]
public static class NativeArrayExtensions
{
	[StructLayout((LayoutKind)0, Size = 1)]
	public struct NativeArrayStaticId<T> where T : struct
	{
		internal static readonly SharedStatic<int> s_staticSafetyId;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static bool Contains<T, U>(this NativeArray<T> array, U value) where T : struct, IEquatable<U>
	{
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static int IndexOf<T, U>(this NativeArray<T> array, U value) where T : struct, IEquatable<U>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static bool Contains<T, U>(this NativeArray<T>.ReadOnly array, U value) where T : struct, IEquatable<U>
	{
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static int IndexOf<T, U>(this NativeArray<T>.ReadOnly array, U value) where T : struct, IEquatable<U>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static bool Contains<T, U>(this NativeList<T> list, U value) where T : struct, IEquatable<U>
	{
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static int IndexOf<T, U>(this NativeList<T> list, U value) where T : struct, IEquatable<U>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public unsafe static bool Contains<T, U>(void* ptr, int length, U value) where T : struct, IEquatable<U>
	{
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public unsafe static int IndexOf<T, U>(void* ptr, int length, U value) where T : struct, IEquatable<U>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static NativeArray<U> Reinterpret<T, U>(this NativeArray<T> array) where T : struct where U : struct
	{
		return default(NativeArray<U>);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static bool ArraysEqual<T>(this NativeArray<T> array, NativeArray<T> other) where T : struct, IEquatable<T>
	{
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static bool ArraysEqual<T>(this NativeList<T> array, NativeArray<T> other) where T : struct, IEquatable<T>
	{
		return false;
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckReinterpretSize<T, U>(ref NativeArray<T> array) where T : struct where U : struct
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	internal static void Initialize<T>(this ref NativeArray<T> array, int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory) where T : struct
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(AllocatorManager.AllocatorHandle)
	})]
	internal static void Initialize<T, U>(this ref NativeArray<T> array, int length, ref U allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct where U : struct, AllocatorManager.IAllocator
	{
	}
}
