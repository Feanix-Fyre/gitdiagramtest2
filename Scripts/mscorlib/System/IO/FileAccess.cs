namespace System.IO;

/// <summary>Defines constants for read, write, or read/write access to a file.</summary>
[Flags]
public enum FileAccess
{
	/// <summary>Read access to the file. Data can be read from the file. Combine with <see langword="Write" /> for read/write access.</summary>
	Read = 1,
	/// <summary>Write access to the file. Data can be written to the file. Combine with <see langword="Read" /> for read/write access.</summary>
	Write = 2,
	/// <summary>Read and write access to the file. Data can be written to and read from the file.</summary>
	ReadWrite = 3
}
