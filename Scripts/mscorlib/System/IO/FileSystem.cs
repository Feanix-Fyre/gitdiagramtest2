using Microsoft.Win32.SafeHandles;

namespace System.IO;

internal static class FileSystem
{
	private class UnitySafeFindHandle : SafeFindHandle
	{
		private readonly IntPtr m_Handle;

		public IntPtr Handle => (IntPtr)0;

		public override bool IsInvalid => false;

		public UnitySafeFindHandle(IntPtr handle)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}

	public static void CopyFile(string sourceFullPath, string destFullPath, bool overwrite)
	{
	}

	public static void CreateDirectory(string fullPath)
	{
	}

	public static void DeleteFile(string fullPath)
	{
	}

	public static bool DirectoryExists(string fullPath)
	{
		return false;
	}

	private static bool DirectoryExists(string path, out int lastError)
	{
		lastError = default(int);
		return false;
	}

	internal static int FillAttributeInfo(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data, bool returnErrorOnNotFound)
	{
		return 0;
	}

	public static bool FileExists(string fullPath)
	{
		return false;
	}

	public static DateTimeOffset GetCreationTime(string fullPath)
	{
		return default(DateTimeOffset);
	}

	public static DateTimeOffset GetLastAccessTime(string fullPath)
	{
		return default(DateTimeOffset);
	}

	public static DateTimeOffset GetLastWriteTime(string fullPath)
	{
		return default(DateTimeOffset);
	}

	public static void MoveDirectory(string sourceFullPath, string destFullPath)
	{
	}

	public static void MoveFile(string sourceFullPath, string destFullPath)
	{
	}

	private static SafeFileHandle OpenHandle(string fullPath, bool asDirectory)
	{
		return null;
	}

	public static void RemoveDirectory(string fullPath, bool recursive)
	{
	}

	private static void GetFindData(string fullPath, ref Interop.Kernel32.WIN32_FIND_DATA findData)
	{
	}

	private static bool IsNameSurrogateReparsePoint(ref Interop.Kernel32.WIN32_FIND_DATA data)
	{
		return false;
	}

	private static void RemoveDirectoryRecursive(string fullPath, ref Interop.Kernel32.WIN32_FIND_DATA findData, bool topLevel)
	{
	}

	private static void RemoveDirectoryInternal(string fullPath, bool topLevel, bool allowDirectoryNotEmpty = false)
	{
	}

	public static void SetAttributes(string fullPath, FileAttributes attributes)
	{
	}

	public static void SetLastWriteTime(string fullPath, DateTimeOffset time, bool asDirectory)
	{
	}

	public static string[] GetLogicalDrives()
	{
		return null;
	}

	private static bool UnityCreateDirectory(string name)
	{
		return false;
	}

	private static bool UnityRemoveDirectory(string fullPath)
	{
		return false;
	}

	private static bool UnityGetFileAttributesEx(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data)
	{
		return false;
	}

	private static bool UnitySetFileAttributes(string fullPath, FileAttributes attributes)
	{
		return false;
	}

	internal static IntPtr UnityCreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes)
	{
		return (IntPtr)0;
	}

	private static int UnityCopyFile(string sourceFullPath, string destFullPath, bool failIfExists)
	{
		return 0;
	}

	private static bool UnityDeleteFile(string path)
	{
		return false;
	}

	private static bool UnityMoveFile(string sourceFullPath, string destFullPath)
	{
		return false;
	}

	private static SafeFindHandle UnityFindFirstFile(string path, ref Interop.Kernel32.WIN32_FIND_DATA findData)
	{
		return null;
	}

	private static bool UnityFindNextFile(SafeFindHandle handle, ref Interop.Kernel32.WIN32_FIND_DATA findData)
	{
		return false;
	}

	private static bool BrokeredCreateDirectory(string path)
	{
		return false;
	}

	private static bool BrokeredRemoveDirectory(string path)
	{
		return false;
	}

	private static bool BrokeredGetFileAttributes(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data)
	{
		return false;
	}

	private static bool BrokeredSetAttributes(string path, FileAttributes attributes)
	{
		return false;
	}

	private static IntPtr BrokeredOpenFile(string lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, int dwFlagsAndAttributes)
	{
		return (IntPtr)0;
	}

	private static void BrokeredCopyFile(string sourcePath, string destPath, bool overwrite, ref int error)
	{
	}

	private static bool BrokeredMoveFile(string sourceFullPath, string destFullPath)
	{
		return false;
	}

	private static bool BrokeredDeleteFile(string path)
	{
		return false;
	}

	private static IntPtr BrokeredFindFirstFile(string searchPath, ref string resultFilePath, ref uint attributes)
	{
		return (IntPtr)0;
	}

	private static bool BrokeredFindNextFile(IntPtr handle, ref string resultFilePath, ref uint attributes)
	{
		return false;
	}

	private static int BrokeredSafeFindHandleDispose(IntPtr handle)
	{
		return 0;
	}

	private static string RemoveExtendedPathPrefix(string path)
	{
		return null;
	}
}
