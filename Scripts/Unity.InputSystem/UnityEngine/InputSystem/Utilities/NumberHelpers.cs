using System.Runtime.CompilerServices;

namespace UnityEngine.InputSystem.Utilities;

internal static class NumberHelpers
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int AlignToMultipleOf(this int number, int alignment)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long AlignToMultipleOf(this long number, long alignment)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint AlignToMultipleOf(this uint number, uint alignment)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool Approximately(double a, double b)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float IntToNormalizedFloat(int value, int minValue, int maxValue)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float UIntToNormalizedFloat(uint value, uint minValue, uint maxValue)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint NormalizedFloatToUInt(float value, uint uintMinValue, uint uintMaxValue)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint RemapUIntBitsToNormalizeFloatToUIntBits(uint value, uint inBitSize, uint outBitSize)
	{
		return 0u;
	}
}
