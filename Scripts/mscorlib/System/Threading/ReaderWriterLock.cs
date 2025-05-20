using System.Collections;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading;

/// <summary>Defines a lock that supports single writers and multiple readers.</summary>
[ComVisible(true)]
public sealed class ReaderWriterLock : CriticalFinalizerObject
{
	private int seq_num;

	private int state;

	private int readers;

	private int writer_lock_owner;

	private LockQueue writer_queue;

	private Hashtable reader_locks;

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ReaderWriterLock" /> class.</summary>
	public ReaderWriterLock()
	{
	}

	/// <summary>Ensures that resources are freed and other cleanup operations are performed when the garbage collector reclaims the <see cref="T:System.Threading.ReaderWriterLock" /> object.</summary>
	~ReaderWriterLock()
	{
	}

	/// <summary>Acquires the writer lock, using an <see cref="T:System.Int32" /> value for the time-out.</summary>
	/// <param name="millisecondsTimeout">The time-out in milliseconds.</param>
	/// <exception cref="T:System.ApplicationException">
	///   <paramref name="timeout" /> expires before the lock request is granted.</exception>
	public void AcquireWriterLock(int millisecondsTimeout)
	{
	}

	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount)
	{
	}

	/// <summary>Decrements the lock count on the writer lock.</summary>
	/// <exception cref="T:System.ApplicationException">The thread does not have the writer lock.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void ReleaseWriterLock()
	{
	}

	private void ReleaseWriterLock(int releaseCount)
	{
	}

	private bool HasWriterLock()
	{
		return false;
	}
}
