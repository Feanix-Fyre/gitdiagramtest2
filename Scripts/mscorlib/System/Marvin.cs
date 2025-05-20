using System.Runtime.CompilerServices;

namespace System;

internal static class Marvin
{
	public static ulong DefaultSeed { get; }

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int ComputeHash32(ReadOnlySpan<byte> data, ulong seed)
	{
		return 0;
	}

	public static int ComputeHash32(ref byte data, int count, ulong seed)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void Block(ref uint rp0, ref uint rp1)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static uint _rotl(uint value, int shift)
	{
		return 0u;
	}

	private static ulong GenerateSeed()
	{
		return 0uL;
	}
}
