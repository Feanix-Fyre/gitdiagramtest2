using System.Collections.Generic;

namespace System.IO.Enumeration;

internal static class FileSystemEnumerableFactory
{
	private static readonly char[] s_unixEscapeChars;

	internal static void NormalizeInputs(ref string directory, ref string expression, EnumerationOptions options)
	{
	}

	private static bool MatchesPattern(string expression, ReadOnlySpan<char> name, EnumerationOptions options)
	{
		return false;
	}

	internal static IEnumerable<string> UserFiles(string directory, string expression, EnumerationOptions options)
	{
		return null;
	}

	internal static IEnumerable<string> UserDirectories(string directory, string expression, EnumerationOptions options)
	{
		return null;
	}

	internal static IEnumerable<string> UserEntries(string directory, string expression, EnumerationOptions options)
	{
		return null;
	}

	internal static IEnumerable<FileInfo> FileInfos(string directory, string expression, EnumerationOptions options)
	{
		return null;
	}

	internal static IEnumerable<DirectoryInfo> DirectoryInfos(string directory, string expression, EnumerationOptions options)
	{
		return null;
	}

	internal static IEnumerable<FileSystemInfo> FileSystemInfos(string directory, string expression, EnumerationOptions options)
	{
		return null;
	}
}
