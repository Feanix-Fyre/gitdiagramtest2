namespace System.Numerics;

internal static class BigIntegerCalculator
{
	private static int ReducerThreshold;

	private static int SquareThreshold;

	private static int AllocationThreshold;

	private static int MultiplyThreshold;

	public static uint[] Add(uint[] left, uint right)
	{
		return null;
	}

	public static uint[] Add(uint[] left, uint[] right)
	{
		return null;
	}

	private unsafe static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
	{
	}

	private unsafe static void AddSelf(uint* left, int leftLength, uint* right, int rightLength)
	{
	}

	public static uint[] Subtract(uint[] left, uint right)
	{
		return null;
	}

	public static uint[] Subtract(uint[] left, uint[] right)
	{
		return null;
	}

	private unsafe static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
	{
	}

	public static int Compare(uint[] left, uint[] right)
	{
		return 0;
	}

	public static uint[] Divide(uint[] left, uint right)
	{
		return null;
	}

	public static uint Remainder(uint[] left, uint right)
	{
		return 0u;
	}

	public static uint[] Divide(uint[] left, uint[] right)
	{
		return null;
	}

	public static uint[] Remainder(uint[] left, uint[] right)
	{
		return null;
	}

	private unsafe static void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
	{
	}

	private unsafe static uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength)
	{
		return 0u;
	}

	private unsafe static uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q)
	{
		return 0u;
	}

	private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo)
	{
		return false;
	}

	private static uint[] CreateCopy(uint[] value)
	{
		return null;
	}

	private static int LeadingZeros(uint value)
	{
		return 0;
	}

	public static uint[] Square(uint[] value)
	{
		return null;
	}

	private unsafe static void Square(uint* value, int valueLength, uint* bits, int bitsLength)
	{
	}

	public static uint[] Multiply(uint[] left, uint right)
	{
		return null;
	}

	public static uint[] Multiply(uint[] left, uint[] right)
	{
		return null;
	}

	private unsafe static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
	{
	}

	private unsafe static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength)
	{
	}
}
