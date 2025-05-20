namespace System.Numerics;

internal static class NumericsHelpers
{
	public static void GetDoubleParts(double dbl, out int sign, out int exp, out ulong man, out bool fFinite)
	{
		sign = default(int);
		exp = default(int);
		man = default(ulong);
		fFinite = default(bool);
	}

	public static double GetDoubleFromParts(int sign, int exp, ulong man)
	{
		return 0.0;
	}

	public static void DangerousMakeTwosComplement(uint[] d)
	{
	}

	public static ulong MakeUlong(uint uHi, uint uLo)
	{
		return 0uL;
	}

	public static uint Abs(int a)
	{
		return 0u;
	}

	public static uint CombineHash(uint u1, uint u2)
	{
		return 0u;
	}

	public static int CombineHash(int n1, int n2)
	{
		return 0;
	}

	public static int CbitHighZero(uint u)
	{
		return 0;
	}

	public static int CbitHighZero(ulong uu)
	{
		return 0;
	}
}
