namespace System.Data;

internal sealed class Operators
{
	private static readonly int[] s_priority;

	private static readonly string[] s_looks;

	internal static bool IsArithmetical(int op)
	{
		return false;
	}

	internal static bool IsLogical(int op)
	{
		return false;
	}

	internal static bool IsRelational(int op)
	{
		return false;
	}

	internal static int Priority(int op)
	{
		return 0;
	}

	internal static string ToString(int op)
	{
		return null;
	}
}
