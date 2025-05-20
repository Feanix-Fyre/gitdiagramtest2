using System;

namespace Unity.Collections;

[BurstCompatible]
public static class FixedString
{
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, int arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, int arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, int arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, int arg1, int arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, int arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, int arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, int arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, float arg1, int arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, int arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, int arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, int arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, string arg1, int arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, T1 arg1, int arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, T1 arg1, int arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, T1 arg1, int arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, T2 arg1, int arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, float arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, float arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, float arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, int arg1, float arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, float arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, float arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, float arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, float arg1, float arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, float arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, float arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, float arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, string arg1, float arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, T1 arg1, float arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, T1 arg1, float arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, T1 arg1, float arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, T2 arg1, float arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, string arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, string arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, string arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, int arg1, string arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, string arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, string arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, string arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, float arg1, string arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, string arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, string arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, string arg2, int arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, string arg1, string arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, T1 arg1, string arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, T1 arg1, string arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, T1 arg1, string arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, T2 arg1, string arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, int arg1, T1 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, int arg1, T1 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, int arg1, T1 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, int arg1, T2 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, float arg1, T1 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, float arg1, T1 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, float arg1, T1 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, float arg1, T2 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, string arg1, T1 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, string arg1, T1 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, string arg1, T1 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, string arg1, T2 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, int arg0, T1 arg1, T2 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, float arg0, T1 arg1, T2 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, string arg0, T1 arg1, T2 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2, T3>(FixedString512Bytes formatString, T1 arg0, T2 arg1, T3 arg2, int arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, int arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, int arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, int arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, int arg1, int arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, int arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, int arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, int arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, float arg1, int arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, int arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, int arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, int arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, string arg1, int arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, T1 arg1, int arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, T1 arg1, int arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, T1 arg1, int arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, T2 arg1, int arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, float arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, float arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, float arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, int arg1, float arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, float arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, float arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, float arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, float arg1, float arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, float arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, float arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, float arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, string arg1, float arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, T1 arg1, float arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, T1 arg1, float arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, T1 arg1, float arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, T2 arg1, float arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, string arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, string arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, string arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, int arg1, string arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, string arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, string arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, string arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, float arg1, string arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, string arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, string arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, string arg2, float arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, string arg1, string arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, T1 arg1, string arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, T1 arg1, string arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, T1 arg1, string arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, T2 arg1, string arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, int arg1, T1 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, int arg1, T1 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, int arg1, T1 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, int arg1, T2 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, float arg1, T1 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, float arg1, T1 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, float arg1, T1 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, float arg1, T2 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, string arg1, T1 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, string arg1, T1 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, string arg1, T1 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, string arg1, T2 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, int arg0, T1 arg1, T2 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, float arg0, T1 arg1, T2 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, string arg0, T1 arg1, T2 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2, T3>(FixedString512Bytes formatString, T1 arg0, T2 arg1, T3 arg2, float arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, int arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, int arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, int arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, int arg1, int arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, int arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, int arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, int arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, float arg1, int arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, int arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, int arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, int arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, string arg1, int arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, T1 arg1, int arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, T1 arg1, int arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, T1 arg1, int arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, T2 arg1, int arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, float arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, float arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, float arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, int arg1, float arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, float arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, float arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, float arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, float arg1, float arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, float arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, float arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, float arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, string arg1, float arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, T1 arg1, float arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, T1 arg1, float arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, T1 arg1, float arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, T2 arg1, float arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, string arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, string arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, string arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, int arg1, string arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, string arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, string arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, string arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, float arg1, string arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, string arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, string arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, string arg2, string arg3)
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, T1 arg0, string arg1, string arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, T1 arg1, string arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, T1 arg1, string arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, T1 arg1, string arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, T2 arg1, string arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, int arg1, T1 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, int arg1, T1 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, int arg1, T1 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, int arg1, T2 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, float arg1, T1 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, float arg1, T1 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, float arg1, T1 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, float arg1, T2 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, string arg1, T1 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, string arg1, T1 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, string arg1, T1 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, string arg1, T2 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, int arg0, T1 arg1, T2 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, float arg0, T1 arg1, T2 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, string arg0, T1 arg1, T2 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2, T3>(FixedString512Bytes formatString, T1 arg0, T2 arg1, T3 arg2, string arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, int arg1, int arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, int arg1, int arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, int arg1, int arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, int arg1, int arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, float arg1, int arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, float arg1, int arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, float arg1, int arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, float arg1, int arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, string arg1, int arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, string arg1, int arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, string arg1, int arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, string arg1, int arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, int arg0, T1 arg1, int arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, float arg0, T1 arg1, int arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, string arg0, T1 arg1, int arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2, T3>(FixedString512Bytes formatString, T1 arg0, T2 arg1, int arg2, T3 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, int arg1, float arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, int arg1, float arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, int arg1, float arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, int arg1, float arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, float arg1, float arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, float arg1, float arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, float arg1, float arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, float arg1, float arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, string arg1, float arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, string arg1, float arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, string arg1, float arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, string arg1, float arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, int arg0, T1 arg1, float arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, float arg0, T1 arg1, float arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, string arg0, T1 arg1, float arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2, T3>(FixedString512Bytes formatString, T1 arg0, T2 arg1, float arg2, T3 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, int arg1, string arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, int arg1, string arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, int arg1, string arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, int arg1, string arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, float arg1, string arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, float arg1, string arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, float arg1, string arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, float arg1, string arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, int arg0, string arg1, string arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, float arg0, string arg1, string arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1>(FixedString512Bytes formatString, string arg0, string arg1, string arg2, T1 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, T1 arg0, string arg1, string arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, int arg0, T1 arg1, string arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, float arg0, T1 arg1, string arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, string arg0, T1 arg1, string arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2, T3>(FixedString512Bytes formatString, T1 arg0, T2 arg1, string arg2, T3 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, int arg0, int arg1, T1 arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, float arg0, int arg1, T1 arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, string arg0, int arg1, T1 arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2, T3>(FixedString512Bytes formatString, T1 arg0, int arg1, T2 arg2, T3 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, int arg0, float arg1, T1 arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, float arg0, float arg1, T1 arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, string arg0, float arg1, T1 arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2, T3>(FixedString512Bytes formatString, T1 arg0, float arg1, T2 arg2, T3 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, int arg0, string arg1, T1 arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, float arg0, string arg1, T1 arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2>(FixedString512Bytes formatString, string arg0, string arg1, T1 arg2, T2 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2, T3>(FixedString512Bytes formatString, T1 arg0, string arg1, T2 arg2, T3 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2, T3>(FixedString512Bytes formatString, int arg0, T1 arg1, T2 arg2, T3 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2, T3>(FixedString512Bytes formatString, float arg0, T1 arg1, T2 arg2, T3 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[NotBurstCompatible]
	public static FixedString512Bytes Format<T1, T2, T3>(FixedString512Bytes formatString, string arg0, T1 arg1, T2 arg2, T3 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString512Bytes Format<T1, T2, T3, T4>(FixedString512Bytes formatString, T1 arg0, T2 arg1, T3 arg2, T4 arg3) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes where T4 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString512Bytes);
	}

	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, int arg1, int arg2)
	{
		return default(FixedString128Bytes);
	}

	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, int arg1, int arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, int arg1, int arg2)
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, T1 arg0, int arg1, int arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, float arg1, int arg2)
	{
		return default(FixedString128Bytes);
	}

	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, float arg1, int arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, float arg1, int arg2)
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, T1 arg0, float arg1, int arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, string arg1, int arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, string arg1, int arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, string arg1, int arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, T1 arg0, string arg1, int arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, int arg0, T1 arg1, int arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, float arg0, T1 arg1, int arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, string arg0, T1 arg1, int arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString128Bytes Format<T1, T2>(FixedString128Bytes formatString, T1 arg0, T2 arg1, int arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, int arg1, float arg2)
	{
		return default(FixedString128Bytes);
	}

	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, int arg1, float arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, int arg1, float arg2)
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, T1 arg0, int arg1, float arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, float arg1, float arg2)
	{
		return default(FixedString128Bytes);
	}

	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, float arg1, float arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, float arg1, float arg2)
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, T1 arg0, float arg1, float arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, string arg1, float arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, string arg1, float arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, string arg1, float arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, T1 arg0, string arg1, float arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, int arg0, T1 arg1, float arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, float arg0, T1 arg1, float arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, string arg0, T1 arg1, float arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString128Bytes Format<T1, T2>(FixedString128Bytes formatString, T1 arg0, T2 arg1, float arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, int arg1, string arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, int arg1, string arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, int arg1, string arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, T1 arg0, int arg1, string arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, float arg1, string arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, float arg1, string arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, float arg1, string arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, T1 arg0, float arg1, string arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, string arg1, string arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, string arg1, string arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, string arg1, string arg2)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, T1 arg0, string arg1, string arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, int arg0, T1 arg1, string arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, float arg0, T1 arg1, string arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, string arg0, T1 arg1, string arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1, T2>(FixedString128Bytes formatString, T1 arg0, T2 arg1, string arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, int arg0, int arg1, T1 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, float arg0, int arg1, T1 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, string arg0, int arg1, T1 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString128Bytes Format<T1, T2>(FixedString128Bytes formatString, T1 arg0, int arg1, T2 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, int arg0, float arg1, T1 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, float arg0, float arg1, T1 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, string arg0, float arg1, T1 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString128Bytes Format<T1, T2>(FixedString128Bytes formatString, T1 arg0, float arg1, T2 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, int arg0, string arg1, T1 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, float arg0, string arg1, T1 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, string arg0, string arg1, T1 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1, T2>(FixedString128Bytes formatString, T1 arg0, string arg1, T2 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString128Bytes Format<T1, T2>(FixedString128Bytes formatString, int arg0, T1 arg1, T2 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString128Bytes Format<T1, T2>(FixedString128Bytes formatString, float arg0, T1 arg1, T2 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1, T2>(FixedString128Bytes formatString, string arg0, T1 arg1, T2 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString128Bytes Format<T1, T2, T3>(FixedString128Bytes formatString, T1 arg0, T2 arg1, T3 arg2) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes where T3 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, int arg1)
	{
		return default(FixedString128Bytes);
	}

	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, int arg1)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, int arg1)
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, T1 arg0, int arg1) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, float arg1)
	{
		return default(FixedString128Bytes);
	}

	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, float arg1)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, float arg1)
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, T1 arg0, float arg1) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, string arg1)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, string arg1)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, string arg1)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, T1 arg0, string arg1) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, int arg0, T1 arg1) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, float arg0, T1 arg1) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, string arg0, T1 arg1) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[]
	{
		typeof(FixedString32Bytes),
		typeof(FixedString32Bytes)
	})]
	public static FixedString128Bytes Format<T1, T2>(FixedString128Bytes formatString, T1 arg0, T2 arg1) where T1 : struct, INativeList<byte>, IUTF8Bytes where T2 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}

	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0)
	{
		return default(FixedString128Bytes);
	}

	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0)
	{
		return default(FixedString128Bytes);
	}

	[NotBurstCompatible]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0)
	{
		return default(FixedString128Bytes);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(FixedString32Bytes) })]
	public static FixedString128Bytes Format<T1>(FixedString128Bytes formatString, T1 arg0) where T1 : struct, INativeList<byte>, IUTF8Bytes
	{
		return default(FixedString128Bytes);
	}
}
