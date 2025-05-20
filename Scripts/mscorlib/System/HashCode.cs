using System.Runtime.CompilerServices;

namespace System;

public struct HashCode
{
	private static readonly uint s_seed;

	private uint _v1;

	private uint _v2;

	private uint _v3;

	private uint _v4;

	private uint _queue1;

	private uint _queue2;

	private uint _queue3;

	private uint _length;

	private static uint GenerateGlobalSeed()
	{
		return 0u;
	}

	public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4)
	{
		return 0;
	}

	public static int Combine<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static uint Rol(uint value, int count)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4)
	{
		v1 = default(uint);
		v2 = default(uint);
		v3 = default(uint);
		v4 = default(uint);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static uint Round(uint hash, uint input)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static uint QueueRound(uint hash, uint queuedValue)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static uint MixState(uint v1, uint v2, uint v3, uint v4)
	{
		return 0u;
	}

	private static uint MixEmptyState()
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static uint MixFinal(uint hash)
	{
		return 0u;
	}

	public void Add<T>(T value)
	{
	}

	private void Add(int value)
	{
	}

	public int ToHashCode()
	{
		return 0;
	}

	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes. Use ToHashCode to retrieve the computed hash code.", true)]
	public override int GetHashCode()
	{
		return 0;
	}

	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes.", true)]
	public override bool Equals(object obj)
	{
		return false;
	}
}
