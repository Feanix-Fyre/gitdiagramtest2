namespace Mono.Security;

internal sealed class BitConverterLE
{
	private unsafe static byte[] GetUIntBytes(byte* bytes)
	{
		return null;
	}

	private unsafe static byte[] GetULongBytes(byte* bytes)
	{
		return null;
	}

	internal static byte[] GetBytes(float value)
	{
		return null;
	}

	internal static byte[] GetBytes(double value)
	{
		return null;
	}

	private unsafe static void UIntFromBytes(byte* dst, byte[] src, int startIndex)
	{
	}

	private unsafe static void ULongFromBytes(byte* dst, byte[] src, int startIndex)
	{
	}

	internal static float ToSingle(byte[] value, int startIndex)
	{
		return 0f;
	}

	internal static double ToDouble(byte[] value, int startIndex)
	{
		return 0.0;
	}
}
