using System.Collections.Generic;

namespace System.IO;

/// <summary>Exposes static methods for creating, moving, and enumerating through directories and subdirectories. This class cannot be inherited.</summary>
public static class Directory
{
	/// <summary>Creates all directories and subdirectories in the specified path unless they already exist.</summary>
	/// <param name="path">The directory to create.</param>
	/// <returns>An object that represents the directory at the specified path. This object is returned regardless of whether a directory at the specified path already exists.</returns>
	/// <exception cref="T:System.IO.IOException">The directory specified by <paramref name="path" /> is a file.  
	///  -or-  
	///  The network name is not known.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.  
	/// -or-  
	/// <paramref name="path" /> is prefixed with, or contains, only a colon character (:).</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="path" /> contains a colon character (:) that is not part of a drive label ("C:\").</exception>
	public static DirectoryInfo CreateDirectory(string path)
	{
		return null;
	}

	/// <summary>Determines whether the given path refers to an existing directory on disk.</summary>
	/// <param name="path">The path to test.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="path" /> refers to an existing directory; <see langword="false" /> if the directory does not exist or an error occurs when trying to determine if the specified directory exists.</returns>
	public static bool Exists(string path)
	{
		return false;
	}

	/// <summary>Returns the names of files (including their paths) in the specified directory.</summary>
	/// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
	/// <returns>An array of the full names (including paths) for the files in the specified directory, or an empty array if no files are found.</returns>
	/// <exception cref="T:System.IO.IOException">
	///   <paramref name="path" /> is a file name.  
	/// -or-  
	/// A network error has occurred.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is not found or is invalid (for example, it is on an unmapped drive).</exception>
	public static string[] GetFiles(string path)
	{
		return null;
	}

	/// <summary>Returns the names of files (including their paths) that match the specified search pattern in the specified directory.</summary>
	/// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
	/// <param name="searchPattern">The search string to match against the names of files in <paramref name="path" />.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.</param>
	/// <returns>An array of the full names (including paths) for the files in the specified directory that match the specified search pattern, or an empty array if no files are found.</returns>
	/// <exception cref="T:System.IO.IOException">
	///   <paramref name="path" /> is a file name.  
	/// -or-  
	/// A network error has occurred.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using <see cref="M:System.IO.Path.GetInvalidPathChars" />.  
	/// -or-  
	/// <paramref name="searchPattern" /> doesn't contain a valid pattern.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> or <paramref name="searchPattern" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is not found or is invalid (for example, it is on an unmapped drive).</exception>
	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}

	/// <summary>Returns the names of files (including their paths) that match the specified search pattern in the specified directory, using a value to determine whether to search subdirectories.</summary>
	/// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
	/// <param name="searchPattern">The search string to match against the names of files in <paramref name="path" />.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.</param>
	/// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include all subdirectories or only the current directory.</param>
	/// <returns>An array of the full names (including paths) for the files in the specified directory that match the specified search pattern and option, or an empty array if no files are found.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.  
	/// -or-  
	/// <paramref name="searchPattern" /> does not contain a valid pattern.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> or <paramref name="searchpattern" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is not found or is invalid (for example, it is on an unmapped drive).</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.IO.IOException">
	///   <paramref name="path" /> is a file name.  
	/// -or-  
	/// A network error has occurred.</exception>
	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
	{
		return null;
	}

	public static string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
	{
		return null;
	}

	/// <summary>Returns the names of subdirectories (including their paths) in the specified directory.</summary>
	/// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
	/// <returns>An array of the full names (including paths) of subdirectories in the specified path, or an empty array if no directories are found.</returns>
	/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.IO.IOException">
	///   <paramref name="path" /> is a file name.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
	public static string[] GetDirectories(string path)
	{
		return null;
	}

	/// <summary>Returns the names of the subdirectories (including their paths) that match the specified search pattern in the specified directory, and optionally searches subdirectories.</summary>
	/// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
	/// <param name="searchPattern">The search string to match against the names of subdirectories in <paramref name="path" />. This parameter can contain a combination of valid literal and wildcard characters, but it doesn't support regular expressions.</param>
	/// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include all subdirectories or only the current directory.</param>
	/// <returns>An array of the full names (including paths) of the subdirectories that match the specified criteria, or an empty array if no directories are found.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.  
	/// -or-  
	/// <paramref name="searchPattern" /> does not contain a valid pattern.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> or <paramref name="searchPattern" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.IO.IOException">
	///   <paramref name="path" /> is a file name.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
	public static string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
	{
		return null;
	}

	public static string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
	{
		return null;
	}

	internal static IEnumerable<string> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
	{
		return null;
	}

	/// <summary>Returns an enumerable collection of file names and directory names in a specified path.</summary>
	/// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
	/// <returns>An enumerable collection of file-system entries in the directory specified by <paramref name="path" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is a zero-length string, contains only white space, or contains invalid characters. You can query for invalid characters by using the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">
	///   <paramref name="path" /> is invalid, such as referring to an unmapped drive.</exception>
	/// <exception cref="T:System.IO.IOException">
	///   <paramref name="path" /> is a file name.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or combined exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	public static IEnumerable<string> EnumerateFileSystemEntries(string path)
	{
		return null;
	}

	public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions)
	{
		return null;
	}

	/// <summary>Returns the volume information, root information, or both for the specified path.</summary>
	/// <param name="path">The path of a file or directory.</param>
	/// <returns>A string that contains the volume information, root information, or both for the specified path.</returns>
	/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with <see cref="M:System.IO.Path.GetInvalidPathChars" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	public static string GetDirectoryRoot(string path)
	{
		return null;
	}

	internal static string InternalGetDirectoryRoot(string path)
	{
		return null;
	}

	/// <summary>Gets the current working directory of the application.</summary>
	/// <returns>A string that contains the absolute path of the current working directory, and does not end with a backslash (\).</returns>
	/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.NotSupportedException">The operating system is Windows CE, which does not have current directory functionality.  
	///  This method is available in the .NET Compact Framework, but is not currently supported.</exception>
	public static string GetCurrentDirectory()
	{
		return null;
	}

	/// <summary>Moves a file or a directory and its contents to a new location.</summary>
	/// <param name="sourceDirName">The path of the file or directory to move.</param>
	/// <param name="destDirName">The path to the new location for <paramref name="sourceDirName" />. If <paramref name="sourceDirName" /> is a file, then <paramref name="destDirName" /> must also be a file name.</param>
	/// <exception cref="T:System.IO.IOException">An attempt was made to move a directory to a different volume.  
	///  -or-  
	///  <paramref name="destDirName" /> already exists.  
	///  -or-  
	///  The <paramref name="sourceDirName" /> and <paramref name="destDirName" /> parameters refer to the same file or directory.  
	///  -or-  
	///  The directory or a file within it is being used by another process.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="sourceDirName" /> or <paramref name="destDirName" /> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters with the  <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="sourceDirName" /> or <paramref name="destDirName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified by <paramref name="sourceDirName" /> is invalid (for example, it is on an unmapped drive).</exception>
	public static void Move(string sourceDirName, string destDirName)
	{
	}

	/// <summary>Deletes the specified directory and, if indicated, any subdirectories and files in the directory.</summary>
	/// <param name="path">The name of the directory to remove.</param>
	/// <param name="recursive">
	///   <see langword="true" /> to remove directories, subdirectories, and files in <paramref name="path" />; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.IO.IOException">A file with the same name and location specified by <paramref name="path" /> exists.  
	///  -or-  
	///  The directory specified by <paramref name="path" /> is read-only, or <paramref name="recursive" /> is <see langword="false" /> and <paramref name="path" /> is not an empty directory.  
	///  -or-  
	///  The directory is the application's current working directory.  
	///  -or-  
	///  The directory contains a read-only file.  
	///  -or-  
	///  The directory is being used by another process.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters. You can query for invalid characters by using the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">
	///   <paramref name="path" /> does not exist or could not be found.  
	/// -or-  
	/// The specified path is invalid (for example, it is on an unmapped drive).</exception>
	public static void Delete(string path, bool recursive)
	{
	}

	/// <summary>Retrieves the names of the logical drives on this computer in the form "&lt;drive letter&gt;:\".</summary>
	/// <returns>The logical drives on this computer.</returns>
	/// <exception cref="T:System.IO.IOException">An I/O error occured (for example, a disk error).</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	public static string[] GetLogicalDrives()
	{
		return null;
	}

	internal static string InsecureGetCurrentDirectory()
	{
		return null;
	}
}
