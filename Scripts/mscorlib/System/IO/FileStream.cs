using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace System.IO;

/// <summary>Provides a <see cref="T:System.IO.Stream" /> for a file, supporting both synchronous and asynchronous read and write operations.</summary>
[ComVisible(true)]
public class FileStream : Stream
{
	private delegate int ReadDelegate(byte[] buffer, int offset, int count);

	private delegate void WriteDelegate(byte[] buffer, int offset, int count);

	private static byte[] buf_recycle;

	private static readonly object buf_recycle_lock;

	private byte[] buf;

	private string name;

	private SafeFileHandle safeHandle;

	private bool isExposed;

	private long append_startpos;

	private FileAccess access;

	private bool owner;

	private bool async;

	private bool canseek;

	private bool anonymous;

	private bool buf_dirty;

	private int buf_size;

	private int buf_length;

	private int buf_offset;

	private long buf_start;

	/// <summary>Gets a value that indicates whether the current stream supports reading.</summary>
	/// <returns>
	///   <see langword="true" /> if the stream supports reading; <see langword="false" /> if the stream is closed or was opened with write-only access.</returns>
	public override bool CanRead => false;

	/// <summary>Gets a value that indicates whether the current stream supports writing.</summary>
	/// <returns>
	///   <see langword="true" /> if the stream supports writing; <see langword="false" /> if the stream is closed or was opened with read-only access.</returns>
	public override bool CanWrite => false;

	/// <summary>Gets a value that indicates whether the current stream supports seeking.</summary>
	/// <returns>
	///   <see langword="true" /> if the stream supports seeking; <see langword="false" /> if the stream is closed or if the <see langword="FileStream" /> was constructed from an operating-system handle such as a pipe or output to the console.</returns>
	public override bool CanSeek => false;

	/// <summary>Gets the absolute path of the file opened in the <see langword="FileStream" />.</summary>
	/// <returns>A string that is the absolute path of the file.</returns>
	public virtual string Name => null;

	/// <summary>Gets the length in bytes of the stream.</summary>
	/// <returns>A long value representing the length of the stream in bytes.</returns>
	/// <exception cref="T:System.NotSupportedException">
	///   <see cref="P:System.IO.FileStream.CanSeek" /> for this stream is <see langword="false" />.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error, such as the file being closed, occurred.</exception>
	public override long Length => 0L;

	/// <summary>Gets or sets the current position of this stream.</summary>
	/// <returns>The current position of this stream.</returns>
	/// <exception cref="T:System.NotSupportedException">The stream does not support seeking.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.  
	/// -or-
	///  The position was set to a very large value beyond the end of the stream in Windows 98 or earlier.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Attempted to set the position to a negative value.</exception>
	/// <exception cref="T:System.IO.EndOfStreamException">Attempted seeking past the end of a stream that does not support this.</exception>
	public override long Position
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	/// <summary>Gets a <see cref="T:Microsoft.Win32.SafeHandles.SafeFileHandle" /> object that represents the operating system file handle for the file that the current <see cref="T:System.IO.FileStream" /> object encapsulates.</summary>
	/// <returns>An object that represents the operating system file handle for the file that the current <see cref="T:System.IO.FileStream" /> object encapsulates.</returns>
	public virtual SafeFileHandle SafeFileHandle => null;

	internal FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileStream" /> class with the specified path and creation mode.</summary>
	/// <param name="path">A relative or absolute path for the file that the current <see langword="FileStream" /> object will encapsulate.</param>
	/// <param name="mode">A constant that determines how to open or create the file.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is an empty string (""), contains only white space, or contains one or more invalid characters.  
	/// -or-  
	/// <paramref name="path" /> refers to a non-file device, such as "con:", "com1:", "lpt1:", etc. in an NTFS environment.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="path" /> refers to a non-file device, such as "con:", "com1:", "lpt1:", etc. in a non-NTFS environment.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found, such as when <paramref name="mode" /> is <see langword="FileMode.Truncate" /> or <see langword="FileMode.Open" />, and the file specified by <paramref name="path" /> does not exist. The file must already exist in these modes.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error, such as specifying <see langword="FileMode.CreateNew" /> when the file specified by <paramref name="path" /> already exists, occurred.  
	///  -or-  
	///  The stream has been closed.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="mode" /> contains an invalid value.</exception>
	public FileStream(string path, FileMode mode)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileStream" /> class with the specified path, creation mode, and read/write permission.</summary>
	/// <param name="path">A relative or absolute path for the file that the current <see langword="FileStream" /> object will encapsulate.</param>
	/// <param name="mode">A constant that determines how to open or create the file.</param>
	/// <param name="access">A constant that determines how the file can be accessed by the <see langword="FileStream" /> object. This also determines the values returned by the <see cref="P:System.IO.FileStream.CanRead" /> and <see cref="P:System.IO.FileStream.CanWrite" /> properties of the <see langword="FileStream" /> object. <see cref="P:System.IO.FileStream.CanSeek" /> is <see langword="true" /> if <paramref name="path" /> specifies a disk file.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is an empty string (""), contains only white space, or contains one or more invalid characters.  
	/// -or-  
	/// <paramref name="path" /> refers to a non-file device, such as "con:", "com1:", "lpt1:", etc. in an NTFS environment.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="path" /> refers to a non-file device, such as "con:", "com1:", "lpt1:", etc. in a non-NTFS environment.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found, such as when <paramref name="mode" /> is <see langword="FileMode.Truncate" /> or <see langword="FileMode.Open" />, and the file specified by <paramref name="path" /> does not exist. The file must already exist in these modes.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error, such as specifying <see langword="FileMode.CreateNew" /> when the file specified by <paramref name="path" /> already exists, occurred.  
	///  -or-  
	///  The stream has been closed.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The <paramref name="access" /> requested is not permitted by the operating system for the specified <paramref name="path" />, such as when <paramref name="access" /> is <see langword="Write" /> or <see langword="ReadWrite" /> and the file or directory is set for read-only access.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="mode" /> contains an invalid value.</exception>
	public FileStream(string path, FileMode mode, FileAccess access)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileStream" /> class with the specified path, creation mode, read/write permission, and sharing permission.</summary>
	/// <param name="path">A relative or absolute path for the file that the current <see langword="FileStream" /> object will encapsulate.</param>
	/// <param name="mode">A constant that determines how to open or create the file.</param>
	/// <param name="access">A constant that determines how the file can be accessed by the <see langword="FileStream" /> object. This also determines the values returned by the <see cref="P:System.IO.FileStream.CanRead" /> and <see cref="P:System.IO.FileStream.CanWrite" /> properties of the <see langword="FileStream" /> object. <see cref="P:System.IO.FileStream.CanSeek" /> is <see langword="true" /> if <paramref name="path" /> specifies a disk file.</param>
	/// <param name="share">A constant that determines how the file will be shared by processes.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is an empty string (""), contains only white space, or contains one or more invalid characters.  
	/// -or-  
	/// <paramref name="path" /> refers to a non-file device, such as "con:", "com1:", "lpt1:", etc. in an NTFS environment.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="path" /> refers to a non-file device, such as "con:", "com1:", "lpt1:", etc. in a non-NTFS environment.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found, such as when <paramref name="mode" /> is <see langword="FileMode.Truncate" /> or <see langword="FileMode.Open" />, and the file specified by <paramref name="path" /> does not exist. The file must already exist in these modes.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error, such as specifying <see langword="FileMode.CreateNew" /> when the file specified by <paramref name="path" /> already exists, occurred.  
	///  -or-  
	///  The system is running Windows 98 or Windows 98 Second Edition and <paramref name="share" /> is set to <see langword="FileShare.Delete" />.  
	///  -or-  
	///  The stream has been closed.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The <paramref name="access" /> requested is not permitted by the operating system for the specified <paramref name="path" />, such as when <paramref name="access" /> is <see langword="Write" /> or <see langword="ReadWrite" /> and the file or directory is set for read-only access.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="mode" /> contains an invalid value.</exception>
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileStream" /> class with the specified path, creation mode, read/write and sharing permission, and buffer size.</summary>
	/// <param name="path">A relative or absolute path for the file that the current <see langword="FileStream" /> object will encapsulate.</param>
	/// <param name="mode">A constant that determines how to open or create the file.</param>
	/// <param name="access">A constant that determines how the file can be accessed by the <see langword="FileStream" /> object. This also determines the values returned by the <see cref="P:System.IO.FileStream.CanRead" /> and <see cref="P:System.IO.FileStream.CanWrite" /> properties of the <see langword="FileStream" /> object. <see cref="P:System.IO.FileStream.CanSeek" /> is <see langword="true" /> if <paramref name="path" /> specifies a disk file.</param>
	/// <param name="share">A constant that determines how the file will be shared by processes.</param>
	/// <param name="bufferSize">A positive <see cref="T:System.Int32" /> value greater than 0 indicating the buffer size. The default buffer size is 4096.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is an empty string (""), contains only white space, or contains one or more invalid characters.  
	/// -or-  
	/// <paramref name="path" /> refers to a non-file device, such as "con:", "com1:", "lpt1:", etc. in an NTFS environment.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="path" /> refers to a non-file device, such as "con:", "com1:", "lpt1:", etc. in a non-NTFS environment.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="bufferSize" /> is negative or zero.  
	/// -or-  
	/// <paramref name="mode" />, <paramref name="access" />, or <paramref name="share" /> contain an invalid value.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found, such as when <paramref name="mode" /> is <see langword="FileMode.Truncate" /> or <see langword="FileMode.Open" />, and the file specified by <paramref name="path" /> does not exist. The file must already exist in these modes.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error, such as specifying <see langword="FileMode.CreateNew" /> when the file specified by <paramref name="path" /> already exists, occurred.  
	///  -or-  
	///  The system is running Windows 98 or Windows 98 Second Edition and <paramref name="share" /> is set to <see langword="FileShare.Delete" />.  
	///  -or-  
	///  The stream has been closed.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The <paramref name="access" /> requested is not permitted by the operating system for the specified <paramref name="path" />, such as when <paramref name="access" /> is <see langword="Write" /> or <see langword="ReadWrite" /> and the file or directory is set for read-only access.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileStream" /> class with the specified path, creation mode, read/write and sharing permission, buffer size, and synchronous or asynchronous state.</summary>
	/// <param name="path">A relative or absolute path for the file that the current <see langword="FileStream" /> object will encapsulate.</param>
	/// <param name="mode">A constant that determines how to open or create the file.</param>
	/// <param name="access">A constant that determines how the file can be accessed by the <see langword="FileStream" /> object. This also determines the values returned by the <see cref="P:System.IO.FileStream.CanRead" /> and <see cref="P:System.IO.FileStream.CanWrite" /> properties of the <see langword="FileStream" /> object. <see cref="P:System.IO.FileStream.CanSeek" /> is <see langword="true" /> if <paramref name="path" /> specifies a disk file.</param>
	/// <param name="share">A constant that determines how the file will be shared by processes.</param>
	/// <param name="bufferSize">A positive <see cref="T:System.Int32" /> value greater than 0 indicating the buffer size. The default buffer size is 4096.</param>
	/// <param name="useAsync">Specifies whether to use asynchronous I/O or synchronous I/O. However, note that the underlying operating system might not support asynchronous I/O, so when specifying <see langword="true" />, the handle might be opened synchronously depending on the platform. When opened asynchronously, the <see cref="M:System.IO.FileStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> and <see cref="M:System.IO.FileStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> methods perform better on large reads or writes, but they might be much slower for small reads or writes. If the application is designed to take advantage of asynchronous I/O, set the <paramref name="useAsync" /> parameter to <see langword="true" />. Using asynchronous I/O correctly can speed up applications by as much as a factor of 10, but using it without redesigning the application for asynchronous I/O can decrease performance by as much as a factor of 10.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is an empty string (""), contains only white space, or contains one or more invalid characters.  
	/// -or-  
	/// <paramref name="path" /> refers to a non-file device, such as "con:", "com1:", "lpt1:", etc. in an NTFS environment.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="path" /> refers to a non-file device, such as "con:", "com1:", "lpt1:", etc. in a non-NTFS environment.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="bufferSize" /> is negative or zero.  
	/// -or-  
	/// <paramref name="mode" />, <paramref name="access" />, or <paramref name="share" /> contain an invalid value.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found, such as when <paramref name="mode" /> is <see langword="FileMode.Truncate" /> or <see langword="FileMode.Open" />, and the file specified by <paramref name="path" /> does not exist. The file must already exist in these modes.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error, such as specifying <see langword="FileMode.CreateNew" /> when the file specified by <paramref name="path" /> already exists, occurred.  
	///  -or-  
	///  The system is running Windows 98 or Windows 98 Second Edition and <paramref name="share" /> is set to <see langword="FileShare.Delete" />.  
	///  -or-  
	///  The stream has been closed.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The <paramref name="access" /> requested is not permitted by the operating system for the specified <paramref name="path" />, such as when <paramref name="access" /> is <see langword="Write" /> or <see langword="ReadWrite" /> and the file or directory is set for read-only access.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileStream" /> class with the specified path, creation mode, read/write and sharing permission, the access other FileStreams can have to the same file, the buffer size, and additional file options.</summary>
	/// <param name="path">A relative or absolute path for the file that the current <see langword="FileStream" /> object will encapsulate.</param>
	/// <param name="mode">A constant that determines how to open or create the file.</param>
	/// <param name="access">A constant that determines how the file can be accessed by the <see langword="FileStream" /> object. This also determines the values returned by the <see cref="P:System.IO.FileStream.CanRead" /> and <see cref="P:System.IO.FileStream.CanWrite" /> properties of the <see langword="FileStream" /> object. <see cref="P:System.IO.FileStream.CanSeek" /> is <see langword="true" /> if <paramref name="path" /> specifies a disk file.</param>
	/// <param name="share">A constant that determines how the file will be shared by processes.</param>
	/// <param name="bufferSize">A positive <see cref="T:System.Int32" /> value greater than 0 indicating the buffer size. The default buffer size is 4096.</param>
	/// <param name="options">A value that specifies additional file options.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="path" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="path" /> is an empty string (""), contains only white space, or contains one or more invalid characters.  
	/// -or-  
	/// <paramref name="path" /> refers to a non-file device, such as "con:", "com1:", "lpt1:", etc. in an NTFS environment.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="path" /> refers to a non-file device, such as "con:", "com1:", "lpt1:", etc. in a non-NTFS environment.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="bufferSize" /> is negative or zero.  
	/// -or-  
	/// <paramref name="mode" />, <paramref name="access" />, or <paramref name="share" /> contain an invalid value.</exception>
	/// <exception cref="T:System.IO.FileNotFoundException">The file cannot be found, such as when <paramref name="mode" /> is <see langword="FileMode.Truncate" /> or <see langword="FileMode.Open" />, and the file specified by <paramref name="path" /> does not exist. The file must already exist in these modes.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error, such as specifying <see langword="FileMode.CreateNew" /> when the file specified by <paramref name="path" /> already exists, occurred.  
	///  -or-  
	///  The stream has been closed.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The <paramref name="access" /> requested is not permitted by the operating system for the specified <paramref name="path" />, such as when <paramref name="access" /> is <see langword="Write" /> or <see langword="ReadWrite" /> and the file or directory is set for read-only access.  
	///  -or-  
	///  <see cref="F:System.IO.FileOptions.Encrypted" /> is specified for <paramref name="options" />, but file encryption is not supported on the current platform.</exception>
	/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileStream" /> class for the specified file handle, with the specified read/write permission.</summary>
	/// <param name="handle">A file handle for the file that the current <see langword="FileStream" /> object will encapsulate.</param>
	/// <param name="access">A constant that sets the <see cref="P:System.IO.FileStream.CanRead" /> and <see cref="P:System.IO.FileStream.CanWrite" /> properties of the <see langword="FileStream" /> object.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="access" /> is not a field of <see cref="T:System.IO.FileAccess" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error, such as a disk error, occurred.  
	///  -or-  
	///  The stream has been closed.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The <paramref name="access" /> requested is not permitted by the operating system for the specified file handle, such as when <paramref name="access" /> is <see langword="Write" /> or <see langword="ReadWrite" /> and the file handle is set for read-only access.</exception>
	public FileStream(SafeFileHandle handle, FileAccess access)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileStream" /> class for the specified file handle, with the specified read/write permission, buffer size, and synchronous or asynchronous state.</summary>
	/// <param name="handle">A file handle for the file that this <see langword="FileStream" /> object will encapsulate.</param>
	/// <param name="access">A constant that sets the <see cref="P:System.IO.FileStream.CanRead" /> and <see cref="P:System.IO.FileStream.CanWrite" /> properties of the <see langword="FileStream" /> object.</param>
	/// <param name="bufferSize">A positive <see cref="T:System.Int32" /> value greater than 0 indicating the buffer size. The default buffer size is 4096.</param>
	/// <param name="isAsync">
	///   <see langword="true" /> if the handle was opened asynchronously (that is, in overlapped I/O mode); otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentException">The <paramref name="handle" /> parameter is an invalid handle.  
	///  -or-  
	///  The <paramref name="handle" /> parameter is a synchronous handle and it was used asynchronously.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="bufferSize" /> parameter is negative.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error, such as a disk error, occurred.  
	///  -or-  
	///  The stream has been closed.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The <paramref name="access" /> requested is not permitted by the operating system for the specified file handle, such as when <paramref name="access" /> is <see langword="Write" /> or <see langword="ReadWrite" /> and the file handle is set for read-only access.</exception>
	public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync)
	{
	}

	internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous)
	{
	}

	internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options)
	{
	}

	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper)
	{
	}

	private void ExposeHandle()
	{
	}

	/// <summary>Reads a byte from the file and advances the read position one byte.</summary>
	/// <returns>The byte, cast to an <see cref="T:System.Int32" />, or -1 if the end of the stream has been reached.</returns>
	/// <exception cref="T:System.NotSupportedException">The current stream does not support reading.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The current stream is closed.</exception>
	public override int ReadByte()
	{
		return 0;
	}

	/// <summary>Writes a byte to the current position in the file stream.</summary>
	/// <param name="value">A byte to write to the stream.</param>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support writing.</exception>
	public override void WriteByte(byte value)
	{
	}

	/// <summary>Reads a block of bytes from the stream and writes the data in a given buffer.</summary>
	/// <param name="array">When this method returns, contains the specified byte array with the values between <paramref name="offset" /> and (<paramref name="offset" /> + <paramref name="count" /> - 1) replaced by the bytes read from the current source.</param>
	/// <param name="offset">The byte offset in <paramref name="array" /> at which the read bytes will be placed.</param>
	/// <param name="count">The maximum number of bytes to read.</param>
	/// <returns>The total number of bytes read into the buffer. This might be less than the number of bytes requested if that number of bytes are not currently available, or zero if the end of the stream is reached.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support reading.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="offset" /> and <paramref name="count" /> describe an invalid range in <paramref name="array" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
	public override int Read([In][Out] byte[] array, int offset, int count)
	{
		return 0;
	}

	private int ReadInternal(byte[] dest, int offset, int count)
	{
		return 0;
	}

	/// <summary>Begins an asynchronous read operation. Consider using <see cref="M:System.IO.FileStream.ReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" /> instead.</summary>
	/// <param name="array">The buffer to read data into.</param>
	/// <param name="offset">The byte offset in <paramref name="array" /> at which to begin reading.</param>
	/// <param name="numBytes">The maximum number of bytes to read.</param>
	/// <param name="userCallback">The method to be called when the asynchronous read operation is completed.</param>
	/// <param name="stateObject">A user-provided object that distinguishes this particular asynchronous read request from other requests.</param>
	/// <returns>An object that references the asynchronous read.</returns>
	/// <exception cref="T:System.ArgumentException">The array length minus <paramref name="offset" /> is less than <paramref name="numBytes" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="numBytes" /> is negative.</exception>
	/// <exception cref="T:System.IO.IOException">An asynchronous read was attempted past the end of the file.</exception>
	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
	{
		return null;
	}

	/// <summary>Waits for the pending asynchronous read operation to complete. (Consider using <see cref="M:System.IO.FileStream.ReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" /> instead.)</summary>
	/// <param name="asyncResult">The reference to the pending asynchronous request to wait for.</param>
	/// <returns>The number of bytes read from the stream, between 0 and the number of bytes you requested. Streams only return 0 at the end of the stream, otherwise, they should block until at least 1 byte is available.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">This <see cref="T:System.IAsyncResult" /> object was not created by calling <see cref="M:System.IO.FileStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> on this class.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="M:System.IO.FileStream.EndRead(System.IAsyncResult)" /> is called multiple times.</exception>
	/// <exception cref="T:System.IO.IOException">The stream is closed or an internal error has occurred.</exception>
	public override int EndRead(IAsyncResult asyncResult)
	{
		return 0;
	}

	/// <summary>Writes a block of bytes to the file stream.</summary>
	/// <param name="array">The buffer containing data to write to the stream.</param>
	/// <param name="offset">The zero-based byte offset in <paramref name="array" /> from which to begin copying bytes to the stream.</param>
	/// <param name="count">The maximum number of bytes to write.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="offset" /> and <paramref name="count" /> describe an invalid range in <paramref name="array" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.  
	/// -or-
	///  Another thread may have caused an unexpected change in the position of the operating system's file handle.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.NotSupportedException">The current stream instance does not support writing.</exception>
	public override void Write(byte[] array, int offset, int count)
	{
	}

	private void WriteInternal(byte[] src, int offset, int count)
	{
	}

	/// <summary>Begins an asynchronous write operation. Consider using <see cref="M:System.IO.FileStream.WriteAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" /> instead.</summary>
	/// <param name="array">The buffer containing data to write to the current stream.</param>
	/// <param name="offset">The zero-based byte offset in <paramref name="array" /> at which to begin copying bytes to the current stream.</param>
	/// <param name="numBytes">The maximum number of bytes to write.</param>
	/// <param name="userCallback">The method to be called when the asynchronous write operation is completed.</param>
	/// <param name="stateObject">A user-provided object that distinguishes this particular asynchronous write request from other requests.</param>
	/// <returns>An object that references the asynchronous write.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> length minus <paramref name="offset" /> is less than <paramref name="numBytes" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="numBytes" /> is negative.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support writing.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
	{
		return null;
	}

	/// <summary>Ends an asynchronous write operation and blocks until the I/O operation is complete. (Consider using <see cref="M:System.IO.FileStream.WriteAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)" /> instead.)</summary>
	/// <param name="asyncResult">The pending asynchronous I/O request.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="asyncResult" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">This <see cref="T:System.IAsyncResult" /> object was not created by calling <see cref="M:System.IO.Stream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /> on this class.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="M:System.IO.FileStream.EndWrite(System.IAsyncResult)" /> is called multiple times.</exception>
	/// <exception cref="T:System.IO.IOException">The stream is closed or an internal error has occurred.</exception>
	public override void EndWrite(IAsyncResult asyncResult)
	{
	}

	/// <summary>Sets the current position of this stream to the given value.</summary>
	/// <param name="offset">The point relative to <paramref name="origin" /> from which to begin seeking.</param>
	/// <param name="origin">Specifies the beginning, the end, or the current position as a reference point for <paramref name="offset" />, using a value of type <see cref="T:System.IO.SeekOrigin" />.</param>
	/// <returns>The new position in the stream.</returns>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support seeking, such as if the <see langword="FileStream" /> is constructed from a pipe or console output.</exception>
	/// <exception cref="T:System.ArgumentException">Seeking is attempted before the beginning of the stream.</exception>
	/// <exception cref="T:System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	/// <summary>Sets the length of this stream to the given value.</summary>
	/// <param name="value">The new length of the stream.</param>
	/// <exception cref="T:System.IO.IOException">An I/O error has occurred.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support both writing and seeking.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Attempted to set the <paramref name="value" /> parameter to less than 0.</exception>
	public override void SetLength(long value)
	{
	}

	/// <summary>Clears buffers for this stream and causes any buffered data to be written to the file.</summary>
	/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream is closed.</exception>
	public override void Flush()
	{
	}

	/// <summary>Ensures that resources are freed and other cleanup operations are performed when the garbage collector reclaims the <see langword="FileStream" />.</summary>
	~FileStream()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.FileStream" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Asynchronously clears all buffers for this stream, causes any buffered data to be written to the underlying device, and monitors cancellation requests.</summary>
	/// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
	/// <returns>A task that represents the asynchronous flush operation.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Asynchronously reads a sequence of bytes from the current stream, advances the position within the stream by the number of bytes read, and monitors cancellation requests.</summary>
	/// <param name="buffer">The buffer to write the data into.</param>
	/// <param name="offset">The byte offset in <paramref name="buffer" /> at which to begin writing data from the stream.</param>
	/// <param name="count">The maximum number of bytes to read.</param>
	/// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
	/// <returns>A task that represents the asynchronous read operation. The value of the <paramref name="TResult" /> parameter contains the total number of bytes read into the buffer. The result value can be less than the number of bytes requested if the number of bytes currently available is less than the requested number, or it can be 0 (zero) if the end of the stream has been reached.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support reading.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous read operation.</exception>
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Asynchronously writes a sequence of bytes to the current stream, advances the current position within this stream by the number of bytes written, and monitors cancellation requests.</summary>
	/// <param name="buffer">The buffer to write data from.</param>
	/// <param name="offset">The zero-based byte offset in <paramref name="buffer" /> from which to begin copying bytes to the stream.</param>
	/// <param name="count">The maximum number of bytes to write.</param>
	/// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
	/// <returns>A task that represents the asynchronous write operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> or <paramref name="count" /> is negative.</exception>
	/// <exception cref="T:System.ArgumentException">The sum of <paramref name="offset" /> and <paramref name="count" /> is larger than the buffer length.</exception>
	/// <exception cref="T:System.NotSupportedException">The stream does not support writing.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The stream has been disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The stream is currently in use by a previous write operation.</exception>
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	private int ReadSegment(byte[] dest, int dest_offset, int count)
	{
		return 0;
	}

	private int WriteSegment(byte[] src, int src_offset, int count)
	{
		return 0;
	}

	private void FlushBuffer()
	{
	}

	private void FlushBufferIfDirty()
	{
	}

	private void RefillBuffer()
	{
	}

	private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count)
	{
		return 0;
	}

	private void InitBuffer(int size, bool isZeroSize)
	{
	}

	private string GetSecureFileName(string filename)
	{
		return null;
	}

	private string GetSecureFileName(string filename, bool full)
	{
		return null;
	}
}
