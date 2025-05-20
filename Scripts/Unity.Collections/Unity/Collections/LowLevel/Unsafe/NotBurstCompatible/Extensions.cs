using System;

namespace Unity.Collections.LowLevel.Unsafe.NotBurstCompatible;

public static class Extensions
{
	public static T[] ToArray<T>(this UnsafeParallelHashSet<T> set) where T : struct, IEquatable<T>
	{
		return null;
	}

	[NotBurstCompatible]
	public static void AddNBC(this ref UnsafeAppendBuffer buffer, string value)
	{
	}

	[NotBurstCompatible]
	public static byte[] ToBytesNBC(this ref UnsafeAppendBuffer buffer)
	{
		return null;
	}

	[NotBurstCompatible]
	public static void ReadNextNBC(this ref UnsafeAppendBuffer.Reader reader, out string value)
	{
		value = null;
	}
}
