namespace System.IO;

internal static class PathInternal
{
	private static readonly bool s_isCaseSensitive;

	internal static StringComparison StringComparison => default(StringComparison);

	private static bool GetIsCaseSensitive()
	{
		return false;
	}
}
