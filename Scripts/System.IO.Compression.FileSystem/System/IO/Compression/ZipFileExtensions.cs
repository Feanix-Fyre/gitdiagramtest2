using System.ComponentModel;

namespace System.IO.Compression;

/// <summary>Provides extension methods for the <see cref="T:System.IO.Compression.ZipArchive" /> and <see cref="T:System.IO.Compression.ZipArchiveEntry" /> classes.</summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ZipFileExtensions
{
	public static void ExtractToDirectory(this ZipArchive source, string destinationDirectoryName, bool overwrite)
	{
	}

	internal static ZipArchiveEntry DoCreateEntryFromFile(ZipArchive destination, string sourceFileName, string entryName, CompressionLevel? compressionLevel)
	{
		return null;
	}

	/// <summary>Extracts an entry in the zip archive to a file, and optionally overwrites an existing file that has the same name.</summary>
	/// <param name="source">The zip archive entry to extract a file from.</param>
	/// <param name="destinationFileName">The path of the file to create from the contents of the entry. You can specify either a relative or an absolute path. A relative path is interpreted as relative to the current working directory.</param>
	/// <param name="overwrite">
	///   <see langword="true" /> to overwrite an existing file that has the same name as the destination file; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="destinationFileName" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />.  
	/// -or-  
	/// <paramref name="destinationFileName" /> specifies a directory.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="destinationFileName" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
	/// <exception cref="T:System.IO.IOException">
	///   <paramref name="destinationFileName" /> already exists and <paramref name="overwrite" /> is <see langword="false" />.  
	/// -or-  
	/// An I/O error occurred.  
	/// -or-  
	/// The entry is currently open for writing.  
	/// -or-  
	/// The entry has been deleted from the archive.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission to create the new file.</exception>
	/// <exception cref="T:System.IO.InvalidDataException">The entry is missing from the archive or is corrupt and cannot be read.  
	///  -or-  
	///  The entry has been compressed by using a compression method that is not supported.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The zip archive that this entry belongs to has been disposed.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="destinationFileName" /> is in an invalid format.  
	/// -or-  
	/// The zip archive for this entry was opened in <see cref="F:System.IO.Compression.ZipArchiveMode.Create" /> mode, which does not permit the retrieval of entries.</exception>
	public static void ExtractToFile(this ZipArchiveEntry source, string destinationFileName, bool overwrite)
	{
	}
}
