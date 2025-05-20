using System;

namespace Unity.Collections;

[BurstCompatible]
public static class FixedList128BytesExtensions
{
	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static int IndexOf<T, U>(this ref FixedList128Bytes<T> list, U value) where T : struct, IEquatable<U>
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static bool Contains<T, U>(this ref FixedList128Bytes<T> list, U value) where T : struct, IEquatable<U>
	{
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static bool Remove<T, U>(this ref FixedList128Bytes<T> list, U value) where T : struct, IEquatable<U>
	{
		return false;
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public static bool RemoveSwapBack<T, U>(this ref FixedList128Bytes<T> list, U value) where T : struct, IEquatable<U>
	{
		return false;
	}
}
