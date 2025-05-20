using System.Runtime.CompilerServices;

namespace System.IO;

internal static class PathInternal
{
	private static readonly bool s_isCaseSensitive;

	internal static StringComparison StringComparison => default(StringComparison);

	internal static bool IsCaseSensitive => false;

	internal static bool IsValidDriveChar(char value)
	{
		return false;
	}

	internal static bool EndsWithPeriodOrSpace(string path)
	{
		return false;
	}

	internal static string EnsureExtendedPrefixIfNeeded(string path)
	{
		return null;
	}

	internal static string EnsureExtendedPrefix(string path)
	{
		return null;
	}

	internal static bool IsDevice(ReadOnlySpan<char> path)
	{
		return false;
	}

	internal static bool IsDeviceUNC(ReadOnlySpan<char> path)
	{
		return false;
	}

	internal static bool IsExtended(ReadOnlySpan<char> path)
	{
		return false;
	}

	internal static int GetRootLength(ReadOnlySpan<char> path)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool IsDirectorySeparator(char c)
	{
		return false;
	}

	internal static bool EndsInDirectorySeparator(ReadOnlySpan<char> path)
	{
		return false;
	}

	internal static bool StartsWithDirectorySeparator(ReadOnlySpan<char> path)
	{
		return false;
	}

	internal static string EnsureTrailingSeparator(string path)
	{
		return null;
	}

	internal static string TrimEndingDirectorySeparator(string path)
	{
		return null;
	}

	internal static ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path)
	{
		return default(ReadOnlySpan<char>);
	}

	internal static bool IsRoot(ReadOnlySpan<char> path)
	{
		return false;
	}

	private static bool GetIsCaseSensitive()
	{
		return false;
	}

	public static bool IsPartiallyQualified(string path)
	{
		return false;
	}
}
