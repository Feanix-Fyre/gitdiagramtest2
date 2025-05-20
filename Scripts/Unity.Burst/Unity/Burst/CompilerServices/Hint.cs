namespace Unity.Burst.CompilerServices;

public static class Hint
{
	public static bool Likely(bool condition)
	{
		return false;
	}

	public static bool Unlikely(bool condition)
	{
		return false;
	}

	public static void Assume(bool condition)
	{
	}
}
