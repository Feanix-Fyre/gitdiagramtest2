using System.IO;

namespace Unity.Services.Analytics.Internal;

internal class FileSystemCalls : IFileSystemCalls
{
	private readonly bool m_CanAccessFileSystem;

	internal FileSystemCalls()
	{
	}

	public bool CanAccessFileSystem()
	{
		return false;
	}

	public bool FileExists(string path)
	{
		return false;
	}

	public void DeleteFile(string path)
	{
	}

	public Stream OpenFileForWriting(string path)
	{
		return null;
	}

	public Stream OpenFileForReading(string path)
	{
		return null;
	}
}
