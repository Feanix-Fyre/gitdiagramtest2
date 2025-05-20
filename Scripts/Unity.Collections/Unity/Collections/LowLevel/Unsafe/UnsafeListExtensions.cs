using System;

namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompatible]
public static class UnsafeListExtensions
{
	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static int IndexOf<T, U>(this UnsafeList<T> list, U value) where T : struct, IEquatable<U>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static bool Contains<T, U>(this UnsafeList<T> list, U value) where T : struct, IEquatable<U>
	{
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static int IndexOf<T, U>(this UnsafeList<T>.ParallelReader list, U value) where T : struct, IEquatable<U>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static bool Contains<T, U>(this UnsafeList<T>.ParallelReader list, U value) where T : struct, IEquatable<U>
	{
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public static bool ArraysEqual<T>(this UnsafeList<T> array, UnsafeList<T> other) where T : struct, IEquatable<T>
	{
		return false;
	}
}
