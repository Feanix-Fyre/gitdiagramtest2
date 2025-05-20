using System.Collections.Generic;
using System.Runtime.Serialization;

namespace System.IO;

/// <summary>Exposes instance methods for creating, moving, and enumerating through directories and subdirectories. This class cannot be inherited.</summary>
[Serializable]
public sealed class DirectoryInfo : FileSystemInfo
{
	/// <summary>Gets the parent directory of a specified subdirectory.</summary>
	/// <returns>The parent directory, or <see langword="null" /> if the path is null or if the file path denotes a root (such as "\", "C:", or * "\\server\share").</returns>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public DirectoryInfo Parent => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.DirectoryInfo" /> class on the specified path.</summary>
	/// <param name="path">A string specifying the path on which to create the <see langword="DirectoryInfo" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> contains invalid characters such as ", &lt;, &gt;, or |.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	public DirectoryInfo(string path)
	{
	}

	internal DirectoryInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
	{
	}

	private void Init(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
	{
	}

	/// <summary>Returns a file list from the current directory.</summary>
	/// <returns>An array of type <see cref="T:System.IO.FileInfo" />.</returns>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The path is invalid, such as being on an unmapped drive.</exception>
	public FileInfo[] GetFiles()
	{
		return null;
	}

	/// <summary>Returns a file list from the current directory matching the given search pattern.</summary>
	/// <param name="searchPattern">The search string to match against the names of files.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.</param>
	/// <returns>An array of type <see cref="T:System.IO.FileInfo" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="searchPattern" /> contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="searchPattern" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The path is invalid (for example, it is on an unmapped drive).</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public FileInfo[] GetFiles(string searchPattern)
	{
		return null;
	}

	public FileInfo[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions)
	{
		return null;
	}

	/// <summary>Returns the subdirectories of the current directory.</summary>
	/// <returns>An array of <see cref="T:System.IO.DirectoryInfo" /> objects.</returns>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid, such as being on an unmapped drive.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	public DirectoryInfo[] GetDirectories()
	{
		return null;
	}

	public DirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions)
	{
		return null;
	}

	/// <summary>Returns an enumerable collection of file system information that matches a specified search pattern and search subdirectory option.</summary>
	/// <param name="searchPattern">The search string to match against the names of directories.  This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.</param>
	/// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
	/// <returns>An enumerable collection of file system information objects that matches <paramref name="searchPattern" /> and <paramref name="searchOption" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="searchPattern" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid (for example, it is on an unmapped drive).</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
	{
		return null;
	}

	public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions)
	{
		return null;
	}

	internal static IEnumerable<FileSystemInfo> InternalEnumerateInfos(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
	{
		return null;
	}

	/// <summary>Deletes this <see cref="T:System.IO.DirectoryInfo" /> if it is empty.</summary>
	/// <exception cref="T:System.UnauthorizedAccessException">The directory contains a read-only file.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The directory described by this <see cref="T:System.IO.DirectoryInfo" /> object does not exist or could not be found.</exception>
	/// <exception cref="T:System.IO.IOException">The directory is not empty.  
	///  -or-  
	///  The directory is the application's current working directory.  
	///  -or-  
	///  There is an open handle on the directory, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories. For more information, see How to: Enumerate Directories and Files.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public override void Delete()
	{
	}

	/// <summary>Deletes this instance of a <see cref="T:System.IO.DirectoryInfo" />, specifying whether to delete subdirectories and files.</summary>
	/// <param name="recursive">
	///   <see langword="true" /> to delete this directory, its subdirectories, and all files; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.UnauthorizedAccessException">The directory contains a read-only file.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The directory described by this <see cref="T:System.IO.DirectoryInfo" /> object does not exist or could not be found.</exception>
	/// <exception cref="T:System.IO.IOException">The directory is read-only.  
	///  -or-  
	///  The directory contains one or more files or subdirectories and <paramref name="recursive" /> is <see langword="false" />.  
	///  -or-  
	///  The directory is the application's current working directory.  
	///  -or-  
	///  There is an open handle on the directory or on one of its files, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories and files. For more information, see How to: Enumerate Directories and Files.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public void Delete(bool recursive)
	{
	}

	private DirectoryInfo(SerializationInfo info, StreamingContext context)
	{
	}
}
