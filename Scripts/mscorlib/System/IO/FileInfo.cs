using System.Runtime.Serialization;

namespace System.IO;

/// <summary>Provides properties and instance methods for the creation, copying, deletion, moving, and opening of files, and aids in the creation of <see cref="T:System.IO.FileStream" /> objects. This class cannot be inherited.</summary>
[Serializable]
public sealed class FileInfo : FileSystemInfo
{
	/// <summary>Gets the size, in bytes, of the current file.</summary>
	/// <returns>The size of the current file in bytes.</returns>
	/// <exception cref="T:System.IO.IOException">
	///   <see cref="M:System.IO.FileSystemInfo.Refresh" /> cannot update the state of the file or directory.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">The file does not exist.  
	///  -or-  
	///  The <see langword="Length" /> property is called for a directory.</exception>
	public long Length => 0L;

	/// <summary>Gets the name of the file.</summary>
	/// <returns>The name of the file.</returns>
	public override string Name => null;

	private FileInfo()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileInfo" /> class, which acts as a wrapper for a file path.</summary>
	/// <param name="fileName">The fully qualified name of the new file, or the relative file name. Do not end the path with the directory separator character.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="fileName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.ArgumentException">The file name is empty, contains only white spaces, or contains invalid characters.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">Access to <paramref name="fileName" /> is denied.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="fileName" /> contains a colon (:) in the middle of the string.</exception>
	public FileInfo(string fileName)
	{
	}

	internal FileInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
	{
	}

	/// <summary>Creates a <see cref="T:System.IO.StreamWriter" /> that writes a new text file.</summary>
	/// <returns>A new <see langword="StreamWriter" />.</returns>
	/// <exception cref="T:System.UnauthorizedAccessException">The file name is a directory.</exception>
	/// <exception cref="T:System.IO.IOException">The disk is read-only.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public StreamWriter CreateText()
	{
		return null;
	}

	/// <summary>Creates a <see cref="T:System.IO.StreamWriter" /> that appends text to the file represented by this instance of the <see cref="T:System.IO.FileInfo" />.</summary>
	/// <returns>A new <see langword="StreamWriter" />.</returns>
	public StreamWriter AppendText()
	{
		return null;
	}

	/// <summary>Permanently deletes a file.</summary>
	/// <exception cref="T:System.IO.IOException">The target file is open or memory-mapped on a computer running Microsoft Windows NT.  
	///  -or-  
	///  There is an open handle on the file, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories and files. For more information, see How to: Enumerate Directories and Files.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The path is a directory.</exception>
	public override void Delete()
	{
	}

	private FileInfo(SerializationInfo info, StreamingContext context)
	{
	}
}
