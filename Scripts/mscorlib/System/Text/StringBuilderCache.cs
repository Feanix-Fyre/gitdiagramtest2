namespace System.Text;

internal static class StringBuilderCache
{
	[ThreadStatic]
	private static StringBuilder t_cachedInstance;

	public static StringBuilder Acquire(int capacity = 16)
	{
		return null;
	}

	public static void Release(StringBuilder sb)
	{
	}

	public static string GetStringAndRelease(StringBuilder sb)
	{
		return null;
	}
}
