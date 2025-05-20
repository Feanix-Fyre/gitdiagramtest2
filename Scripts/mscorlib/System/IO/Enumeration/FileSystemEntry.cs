namespace System.IO.Enumeration;

public ref struct FileSystemEntry
{
	internal unsafe Interop.NtDll.FILE_FULL_DIR_INFORMATION* _info;

	public ReadOnlySpan<char> Directory { get; private set; }

	public ReadOnlySpan<char> RootDirectory { get; private set; }

	public ReadOnlySpan<char> OriginalRootDirectory { get; private set; }

	public ReadOnlySpan<char> FileName => default(ReadOnlySpan<char>);

	public FileAttributes Attributes => default(FileAttributes);

	public bool IsDirectory => false;

	internal unsafe static void Initialize(ref FileSystemEntry entry, Interop.NtDll.FILE_FULL_DIR_INFORMATION* info, ReadOnlySpan<char> directory, ReadOnlySpan<char> rootDirectory, ReadOnlySpan<char> originalRootDirectory)
	{
	}

	public FileSystemInfo ToFileSystemInfo()
	{
		return null;
	}

	public string ToSpecifiedFullPath()
	{
		return null;
	}
}
