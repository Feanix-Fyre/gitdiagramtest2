using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System.IO.Enumeration;

public abstract class FileSystemEnumerator<TResult> : CriticalFinalizerObject, IEnumerator<TResult>, IDisposable, IEnumerator
{
	private readonly string _originalRootDirectory;

	private readonly string _rootDirectory;

	private readonly EnumerationOptions _options;

	private readonly object _lock;

	private unsafe Interop.NtDll.FILE_FULL_DIR_INFORMATION* _entry;

	private TResult _current;

	private IntPtr _buffer;

	private int _bufferLength;

	private IntPtr _directoryHandle;

	private string _currentPath;

	private bool _lastEntryFound;

	private Queue<(IntPtr Handle, string Path)> _pending;

	public TResult Current => default(TResult);

	object IEnumerator.Current => null;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool GetDataUWP()
	{
		return false;
	}

	private IntPtr CreateRelativeDirectoryHandleUWP(ReadOnlySpan<char> relativePath, string fullPath)
	{
		return (IntPtr)0;
	}

	public FileSystemEnumerator(string directory, EnumerationOptions options = null)
	{
	}

	private void CloseDirectoryHandle()
	{
	}

	private IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = false)
	{
		return (IntPtr)0;
	}

	private bool ContinueOnDirectoryError(int error, bool ignoreNotFound)
	{
		return false;
	}

	public bool MoveNext()
	{
		return false;
	}

	private void FindNextEntry()
	{
	}

	private bool DequeueNextDirectory()
	{
		return false;
	}

	private void InternalDispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool GetData()
	{
		return false;
	}

	private IntPtr CreateRelativeDirectoryHandle(ReadOnlySpan<char> relativePath, string fullPath)
	{
		return (IntPtr)0;
	}

	protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry)
	{
		return false;
	}

	protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry)
	{
		return false;
	}

	protected abstract TResult TransformEntry(ref FileSystemEntry entry);

	protected virtual void OnDirectoryFinished(ReadOnlySpan<char> directory)
	{
	}

	protected virtual bool ContinueOnError(int error)
	{
		return false;
	}

	private void DirectoryFinished()
	{
	}

	public void Reset()
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	~FileSystemEnumerator()
	{
	}
}
