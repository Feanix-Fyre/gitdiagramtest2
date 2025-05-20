using System.Runtime.CompilerServices;

namespace System.Numerics;

internal class ConstantHelper
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static byte GetByteWithAllBitsSet()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static sbyte GetSByteWithAllBitsSet()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ushort GetUInt16WithAllBitsSet()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static short GetInt16WithAllBitsSet()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint GetUInt32WithAllBitsSet()
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int GetInt32WithAllBitsSet()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ulong GetUInt64WithAllBitsSet()
	{
		return 0uL;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long GetInt64WithAllBitsSet()
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float GetSingleWithAllBitsSet()
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double GetDoubleWithAllBitsSet()
	{
		return 0.0;
	}
}
