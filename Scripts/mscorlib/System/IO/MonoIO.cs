using System.Runtime.InteropServices;

namespace System.IO;

internal static class MonoIO
{
	public static readonly IntPtr InvalidHandle;

	private static bool dump_handles;

	public static IntPtr ConsoleOutput => (IntPtr)0;

	public static IntPtr ConsoleInput => (IntPtr)0;

	public static IntPtr ConsoleError => (IntPtr)0;

	public static char VolumeSeparatorChar => '\0';

	public static char DirectorySeparatorChar => '\0';

	public static char AltDirectorySeparatorChar => '\0';

	public static char PathSeparator => '\0';

	public static Exception GetException(MonoIOError error)
	{
		return null;
	}

	public static Exception GetException(string path, MonoIOError error)
	{
		return null;
	}

	public static string GetCurrentDirectory(out MonoIOError error)
	{
		error = default(MonoIOError);
		return null;
	}

	private unsafe static bool SetFileAttributes(char* path, FileAttributes attrs, out MonoIOError error)
	{
		error = default(MonoIOError);
		return false;
	}

	public static bool SetFileAttributes(string path, FileAttributes attrs, out MonoIOError error)
	{
		error = default(MonoIOError);
		return false;
	}

	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error)
	{
		error = default(MonoIOError);
		return default(MonoFileType);
	}

	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error)
	{
		error = default(MonoIOError);
		return default(MonoFileType);
	}

	public static bool FindCloseFile(IntPtr hnd)
	{
		return false;
	}

	private unsafe static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error)
	{
		error = default(MonoIOError);
		return (IntPtr)0;
	}

	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error)
	{
		error = default(MonoIOError);
		return (IntPtr)0;
	}

	private static bool Cancel_internal(IntPtr handle, out MonoIOError error)
	{
		error = default(MonoIOError);
		return false;
	}

	internal static bool Cancel(SafeHandle safeHandle, out MonoIOError error)
	{
		error = default(MonoIOError);
		return false;
	}

	public static bool Close(IntPtr handle, out MonoIOError error)
	{
		error = default(MonoIOError);
		return false;
	}

	private static int Read(IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error)
	{
		error = default(MonoIOError);
		return 0;
	}

	public static int Read(SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error)
	{
		error = default(MonoIOError);
		return 0;
	}

	private static int Write(IntPtr handle, [In] byte[] src, int src_offset, int count, out MonoIOError error)
	{
		error = default(MonoIOError);
		return 0;
	}

	public static int Write(SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error)
	{
		error = default(MonoIOError);
		return 0;
	}

	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error)
	{
		error = default(MonoIOError);
		return 0L;
	}

	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error)
	{
		error = default(MonoIOError);
		return 0L;
	}

	private static long GetLength(IntPtr handle, out MonoIOError error)
	{
		error = default(MonoIOError);
		return 0L;
	}

	public static long GetLength(SafeHandle safeHandle, out MonoIOError error)
	{
		error = default(MonoIOError);
		return 0L;
	}

	private static bool SetLength(IntPtr handle, long length, out MonoIOError error)
	{
		error = default(MonoIOError);
		return false;
	}

	public static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error)
	{
		error = default(MonoIOError);
		return false;
	}

	public static bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options, out MonoIOError error)
	{
		target_handle = default(IntPtr);
		error = default(MonoIOError);
		return false;
	}

	private static void DumpHandles()
	{
	}

	public static bool RemapPath(string path, out string newPath)
	{
		newPath = null;
		return false;
	}
}
