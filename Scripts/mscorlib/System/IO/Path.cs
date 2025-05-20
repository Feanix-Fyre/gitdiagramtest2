using System.Runtime.InteropServices;
using System.Text;

namespace System.IO;

/// <summary>Performs operations on <see cref="T:System.String" /> instances that contain file or directory path information. These operations are performed in a cross-platform manner.</summary>
[ComVisible(true)]
public static class Path
{
	/// <summary>Provides a platform-specific array of characters that cannot be specified in path string arguments passed to members of the <see cref="T:System.IO.Path" /> class.</summary>
	[Obsolete("see GetInvalidPathChars and GetInvalidFileNameChars methods.")]
	public static readonly char[] InvalidPathChars;

	/// <summary>Provides a platform-specific alternate character used to separate directory levels in a path string that reflects a hierarchical file system organization.</summary>
	public static readonly char AltDirectorySeparatorChar;

	/// <summary>Provides a platform-specific character used to separate directory levels in a path string that reflects a hierarchical file system organization.</summary>
	public static readonly char DirectorySeparatorChar;

	/// <summary>A platform-specific separator character used to separate path strings in environment variables.</summary>
	public static readonly char PathSeparator;

	internal static readonly string DirectorySeparatorStr;

	/// <summary>Provides a platform-specific volume separator character.</summary>
	public static readonly char VolumeSeparatorChar;

	internal static readonly char[] PathSeparatorChars;

	private static readonly bool dirEqualsVolume;

	internal static readonly char[] trimEndCharsWindows;

	internal static readonly char[] trimEndCharsUnix;

	/// <summary>Changes the extension of a path string.</summary>
	/// <param name="path">The path information to modify. The path cannot contain any of the characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</param>
	/// <param name="extension">The new extension (with or without a leading period). Specify <see langword="null" /> to remove an existing extension from <paramref name="path" />.</param>
	/// <returns>The modified path information.  
	///  On Windows-based desktop platforms, if <paramref name="path" /> is <see langword="null" /> or an empty string (""), the path information is returned unmodified. If <paramref name="extension" /> is <see langword="null" />, the returned string contains the specified path with its extension removed. If <paramref name="path" /> has no extension, and <paramref name="extension" /> is not <see langword="null" />, the returned path string contains <paramref name="extension" /> appended to the end of <paramref name="path" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
	public static string ChangeExtension(string path, string extension)
	{
		return null;
	}

	/// <summary>Combines two strings into a path.</summary>
	/// <param name="path1">The first path to combine.</param>
	/// <param name="path2">The second path to combine.</param>
	/// <returns>The combined paths. If one of the specified paths is a zero-length string, this method returns the other path. If <paramref name="path2" /> contains an absolute path, this method returns <paramref name="path2" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path1" /> or <paramref name="path2" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path1" /> or <paramref name="path2" /> is <see langword="null" />.</exception>
	public static string Combine(string path1, string path2)
	{
		return null;
	}

	internal static string CleanPath(string s)
	{
		return null;
	}

	/// <summary>Returns the directory information for the specified path string.</summary>
	/// <param name="path">The path of a file or directory.</param>
	/// <returns>Directory information for <paramref name="path" />, or <see langword="null" /> if <paramref name="path" /> denotes a root directory or is null. Returns <see cref="F:System.String.Empty" /> if <paramref name="path" /> does not contain directory information.</returns>
	/// <exception cref="T:System.ArgumentException">The <paramref name="path" /> parameter contains invalid characters, is empty, or contains only white spaces.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.  
	///
	///
	///
	///
	///  The <paramref name="path" /> parameter is longer than the system-defined maximum length.</exception>
	public static string GetDirectoryName(string path)
	{
		return null;
	}

	public static ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path)
	{
		return default(ReadOnlySpan<char>);
	}

	/// <summary>Returns the extension of the specified path string.</summary>
	/// <param name="path">The path string from which to get the extension.</param>
	/// <returns>The extension of the specified path (including the period "."), or <see langword="null" />, or <see cref="F:System.String.Empty" />. If <paramref name="path" /> is <see langword="null" />, <see cref="M:System.IO.Path.GetExtension(System.String)" /> returns <see langword="null" />. If <paramref name="path" /> does not have extension information, <see cref="M:System.IO.Path.GetExtension(System.String)" /> returns <see cref="F:System.String.Empty" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
	public static string GetExtension(string path)
	{
		return null;
	}

	/// <summary>Returns the file name and extension of the specified path string.</summary>
	/// <param name="path">The path string from which to obtain the file name and extension.</param>
	/// <returns>The characters after the last directory character in <paramref name="path" />. If the last character of <paramref name="path" /> is a directory or volume separator character, this method returns <see cref="F:System.String.Empty" />. If <paramref name="path" /> is <see langword="null" />, this method returns <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
	public static string GetFileName(string path)
	{
		return null;
	}

	/// <summary>Returns the file name of the specified path string without the extension.</summary>
	/// <param name="path">The path of the file.</param>
	/// <returns>The string returned by <see cref="M:System.IO.Path.GetFileName(System.String)" />, minus the last period (.) and all characters following it.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
	public static string GetFileNameWithoutExtension(string path)
	{
		return null;
	}

	/// <summary>Returns the absolute path for the specified path string.</summary>
	/// <param name="path">The file or directory for which to obtain absolute path information.</param>
	/// <returns>The fully qualified location of <paramref name="path" />, such as "C:\MyFile.txt".</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
	/// -or-  
	/// The system could not retrieve the absolute path.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permissions.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="path" /> contains a colon (":") that is not part of a volume identifier (for example, "c:\").</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	public static string GetFullPath(string path)
	{
		return null;
	}

	internal static string GetFullPathInternal(string path)
	{
		return null;
	}

	[PreserveSig]
	private static extern int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull);

	internal static string GetFullPathName(string path)
	{
		return null;
	}

	internal static string WindowsDriveAdjustment(string path)
	{
		return null;
	}

	internal static string InsecureGetFullPath(string path)
	{
		return null;
	}

	internal static bool IsDirectorySeparator(char c)
	{
		return false;
	}

	/// <summary>Gets the root directory information of the specified path.</summary>
	/// <param name="path">The path from which to obtain root directory information.</param>
	/// <returns>The root directory of <paramref name="path" />, or <see langword="null" /> if <paramref name="path" /> is <see langword="null" />, or an empty string if <paramref name="path" /> does not contain root directory information.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
	/// -or-  
	/// <see cref="F:System.String.Empty" /> was passed to <paramref name="path" />.</exception>
	public static string GetPathRoot(string path)
	{
		return null;
	}

	/// <summary>Returns the path of the current user's temporary folder.</summary>
	/// <returns>The path to the temporary folder, ending with a backslash.</returns>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permissions.</exception>
	public static string GetTempPath()
	{
		return null;
	}

	private static string get_temp_path()
	{
		return null;
	}

	public static bool IsPathRooted(ReadOnlySpan<char> path)
	{
		return false;
	}

	/// <summary>Gets a value indicating whether the specified path string contains a root.</summary>
	/// <param name="path">The path to test.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="path" /> contains a root; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
	public static bool IsPathRooted(string path)
	{
		return false;
	}

	/// <summary>Gets an array containing the characters that are not allowed in file names.</summary>
	/// <returns>An array containing the characters that are not allowed in file names.</returns>
	public static char[] GetInvalidFileNameChars()
	{
		return null;
	}

	/// <summary>Gets an array containing the characters that are not allowed in path names.</summary>
	/// <returns>An array containing the characters that are not allowed in path names.</returns>
	public static char[] GetInvalidPathChars()
	{
		return null;
	}

	private static int findExtension(string path)
	{
		return 0;
	}

	static Path()
	{
	}

	private static string GetServerAndShare(string path)
	{
		return null;
	}

	private static bool SameRoot(string root, string path)
	{
		return false;
	}

	private static string CanonicalizePath(string path)
	{
		return null;
	}

	/// <summary>Combines an array of strings into a path.</summary>
	/// <param name="paths">An array of parts of the path.</param>
	/// <returns>The combined paths.</returns>
	/// <exception cref="T:System.ArgumentException">One of the strings in the array contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">One of the strings in the array is <see langword="null" />.</exception>
	public static string Combine(params string[] paths)
	{
		return null;
	}

	/// <summary>Combines three strings into a path.</summary>
	/// <param name="path1">The first path to combine.</param>
	/// <param name="path2">The second path to combine.</param>
	/// <param name="path3">The third path to combine.</param>
	/// <returns>The combined paths.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path1" />, <paramref name="path2" />, or <paramref name="path3" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path1" />, <paramref name="path2" />, or <paramref name="path3" /> is <see langword="null" />.</exception>
	public static string Combine(string path1, string path2, string path3)
	{
		return null;
	}

	internal static void Validate(string path)
	{
	}

	internal static void Validate(string path, string parameterName)
	{
	}

	public static ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path)
	{
		return default(ReadOnlySpan<char>);
	}

	public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2)
	{
		return null;
	}

	public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3)
	{
		return null;
	}

	private static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second)
	{
		return null;
	}

	private static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second, ReadOnlySpan<char> third)
	{
		return null;
	}
}
