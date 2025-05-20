using System.Runtime.CompilerServices;

namespace System.Threading;

/// <summary>Represents a lock that is used to manage access to a resource, allowing multiple threads for reading or exclusive access for writing.</summary>
public class ReaderWriterLockSlim : IDisposable
{
	private struct TimeoutTracker
	{
		private int m_total;

		private int m_start;

		public int RemainingMilliseconds => 0;

		public bool IsExpired => false;

		public TimeoutTracker(int millisecondsTimeout)
		{
			m_total = 0;
			m_start = 0;
		}
	}

	private bool fIsReentrant;

	private int myLock;

	private const int LockSpinCycles = 20;

	private const int LockSpinCount = 10;

	private const int LockSleep0Count = 5;

	private uint numWriteWaiters;

	private uint numReadWaiters;

	private uint numWriteUpgradeWaiters;

	private uint numUpgradeWaiters;

	private bool fNoWaiters;

	private int upgradeLockOwnerId;

	private int writeLockOwnerId;

	private EventWaitHandle writeEvent;

	private EventWaitHandle readEvent;

	private EventWaitHandle upgradeEvent;

	private EventWaitHandle waitUpgradeEvent;

	private static long s_nextLockID;

	private long lockID;

	[ThreadStatic]
	private static ReaderWriterCount t_rwc;

	private bool fUpgradeThreadHoldingRead;

	private const int MaxSpinCount = 20;

	private uint owners;

	private const uint WRITER_HELD = 2147483648u;

	private const uint WAITING_WRITERS = 1073741824u;

	private const uint WAITING_UPGRADER = 536870912u;

	private const uint MAX_READER = 268435454u;

	private const uint READER_MASK = 268435455u;

	private bool fDisposed;

	/// <summary>Gets a value that indicates whether the current thread has entered the lock in read mode.</summary>
	/// <returns>
	///     <see langword="true" /> if the current thread has entered read mode; otherwise, <see langword="false" />.</returns>
	public bool IsReadLockHeld => false;

	/// <summary>Gets a value that indicates whether the current thread has entered the lock in upgradeable mode. </summary>
	/// <returns>
	///     <see langword="true" /> if the current thread has entered upgradeable mode; otherwise, <see langword="false" />.</returns>
	public bool IsUpgradeableReadLockHeld => false;

	/// <summary>Gets a value that indicates whether the current thread has entered the lock in write mode.</summary>
	/// <returns>
	///     <see langword="true" /> if the current thread has entered write mode; otherwise, <see langword="false" />.</returns>
	public bool IsWriteLockHeld => false;

	/// <summary>Gets the number of times the current thread has entered the lock in read mode, as an indication of recursion.</summary>
	/// <returns>0 (zero) if the current thread has not entered read mode, 1 if the thread has entered read mode but has not entered it recursively, or n if the thread has entered the lock recursively n - 1 times.</returns>
	public int RecursiveReadCount => 0;

	/// <summary>Gets the number of times the current thread has entered the lock in upgradeable mode, as an indication of recursion.</summary>
	/// <returns>0 if the current thread has not entered upgradeable mode, 1 if the thread has entered upgradeable mode but has not entered it recursively, or n if the thread has entered upgradeable mode recursively n - 1 times.</returns>
	public int RecursiveUpgradeCount => 0;

	/// <summary>Gets the number of times the current thread has entered the lock in write mode, as an indication of recursion.</summary>
	/// <returns>0 if the current thread has not entered write mode, 1 if the thread has entered write mode but has not entered it recursively, or n if the thread has entered write mode recursively n - 1 times.</returns>
	public int RecursiveWriteCount => 0;

	/// <summary>Gets the total number of threads that are waiting to enter the lock in read mode.</summary>
	/// <returns>The total number of threads that are waiting to enter read mode.</returns>
	public int WaitingReadCount => 0;

	/// <summary>Gets the total number of threads that are waiting to enter the lock in upgradeable mode.</summary>
	/// <returns>The total number of threads that are waiting to enter upgradeable mode.</returns>
	public int WaitingUpgradeCount => 0;

	/// <summary>Gets the total number of threads that are waiting to enter the lock in write mode.</summary>
	/// <returns>The total number of threads that are waiting to enter write mode.</returns>
	public int WaitingWriteCount => 0;

	private void InitializeThreadCounts()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ReaderWriterLockSlim" /> class with default property values.</summary>
	public ReaderWriterLockSlim()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ReaderWriterLockSlim" /> class, specifying the lock recursion policy.</summary>
	/// <param name="recursionPolicy">One of the enumeration values that specifies the lock recursion policy.</param>
	public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool IsRWEntryEmpty(ReaderWriterCount rwc)
	{
		return false;
	}

	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private ReaderWriterCount GetThreadRWCount(bool dontAllocate)
	{
		return null;
	}

	/// <summary>Tries to enter the lock in read mode.</summary>
	/// <exception cref="T:System.Threading.LockRecursionException">The current thread cannot acquire the write lock when it holds the read lock.-or-The <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" /> property is <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" />, and the current thread has attempted to acquire the read lock when it already holds the read lock. -or-The <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" /> property is <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" />, and the current thread has attempted to acquire the read lock when it already holds the write lock. -or-The recursion number would exceed the capacity of the counter. This limit is so large that applications should never encounter this exception. </exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ReaderWriterLockSlim" /> object has been disposed. </exception>
	public void EnterReadLock()
	{
	}

	/// <summary>Tries to enter the lock in read mode, with an optional integer time-out.</summary>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or -1 (<see cref="F:System.Threading.Timeout.Infinite" />) to wait indefinitely.</param>
	/// <returns>
	///     <see langword="true" /> if the calling thread entered read mode, otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.Threading.LockRecursionException">The <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" /> property is <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" /> and the current thread has already entered the lock. -or-The recursion number would exceed the capacity of the counter. The limit is so large that applications should never encounter it.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="millisecondsTimeout" /> is negative, but it is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> (-1), which is the only negative value allowed.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ReaderWriterLockSlim" /> object has been disposed. </exception>
	public bool TryEnterReadLock(int millisecondsTimeout)
	{
		return false;
	}

	private bool TryEnterReadLock(TimeoutTracker timeout)
	{
		return false;
	}

	private bool TryEnterReadLockCore(TimeoutTracker timeout)
	{
		return false;
	}

	/// <summary>Tries to enter the lock in write mode.</summary>
	/// <exception cref="T:System.Threading.LockRecursionException">The <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" /> property is <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" /> and the current thread has already entered the lock in any mode. -or-The current thread has entered read mode, so trying to enter the lock in write mode would create the possibility of a deadlock. -or-The recursion number would exceed the capacity of the counter. The limit is so large that applications should never encounter it.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ReaderWriterLockSlim" /> object has been disposed. </exception>
	public void EnterWriteLock()
	{
	}

	/// <summary>Tries to enter the lock in write mode, with an optional time-out.</summary>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or -1 (<see cref="F:System.Threading.Timeout.Infinite" />) to wait indefinitely.</param>
	/// <returns>
	///     <see langword="true" /> if the calling thread entered write mode, otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.Threading.LockRecursionException">The <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" /> property is <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" /> and the current thread has already entered the lock. -or-The current thread initially entered the lock in read mode, and therefore trying to enter write mode would create the possibility of a deadlock. -or-The recursion number would exceed the capacity of the counter. The limit is so large that applications should never encounter it.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="millisecondsTimeout" /> is negative, but it is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> (-1), which is the only negative value allowed. </exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ReaderWriterLockSlim" /> object has been disposed. </exception>
	public bool TryEnterWriteLock(int millisecondsTimeout)
	{
		return false;
	}

	private bool TryEnterWriteLock(TimeoutTracker timeout)
	{
		return false;
	}

	private bool TryEnterWriteLockCore(TimeoutTracker timeout)
	{
		return false;
	}

	/// <summary>Tries to enter the lock in upgradeable mode.</summary>
	/// <exception cref="T:System.Threading.LockRecursionException">The <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" /> property is <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" /> and the current thread has already entered the lock in any mode. -or-The current thread has entered read mode, so trying to enter upgradeable mode would create the possibility of a deadlock. -or-The recursion number would exceed the capacity of the counter. The limit is so large that applications should never encounter it.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ReaderWriterLockSlim" /> object has been disposed. </exception>
	public void EnterUpgradeableReadLock()
	{
	}

	/// <summary>Tries to enter the lock in upgradeable mode, with an optional time-out.</summary>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or -1 (<see cref="F:System.Threading.Timeout.Infinite" />) to wait indefinitely.</param>
	/// <returns>
	///     <see langword="true" /> if the calling thread entered upgradeable mode, otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.Threading.LockRecursionException">The <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" /> property is <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" /> and the current thread has already entered the lock. -or-The current thread initially entered the lock in read mode, and therefore trying to enter upgradeable mode would create the possibility of a deadlock. -or-The recursion number would exceed the capacity of the counter. The limit is so large that applications should never encounter it.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="millisecondsTimeout" /> is negative, but it is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> (-1), which is the only negative value allowed. </exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ReaderWriterLockSlim" /> object has been disposed. </exception>
	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout)
	{
		return false;
	}

	private bool TryEnterUpgradeableReadLock(TimeoutTracker timeout)
	{
		return false;
	}

	private bool TryEnterUpgradeableReadLockCore(TimeoutTracker timeout)
	{
		return false;
	}

	/// <summary>Reduces the recursion count for read mode, and exits read mode if the resulting count is 0 (zero).</summary>
	/// <exception cref="T:System.Threading.SynchronizationLockException">The current thread has not entered the lock in read mode. </exception>
	public void ExitReadLock()
	{
	}

	/// <summary>Reduces the recursion count for write mode, and exits write mode if the resulting count is 0 (zero).</summary>
	/// <exception cref="T:System.Threading.SynchronizationLockException">The current thread has not entered the lock in write mode.</exception>
	public void ExitWriteLock()
	{
	}

	/// <summary>Reduces the recursion count for upgradeable mode, and exits upgradeable mode if the resulting count is 0 (zero).</summary>
	/// <exception cref="T:System.Threading.SynchronizationLockException">The current thread has not entered the lock in upgradeable mode.</exception>
	public void ExitUpgradeableReadLock()
	{
	}

	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent)
	{
	}

	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, TimeoutTracker timeout, bool isWriteWaiter)
	{
		return false;
	}

	private void ExitAndWakeUpAppropriateWaiters()
	{
	}

	private void ExitAndWakeUpAppropriateWaitersPreferringWriters()
	{
	}

	private void ExitAndWakeUpAppropriateReadWaiters()
	{
	}

	private bool IsWriterAcquired()
	{
		return false;
	}

	private void SetWriterAcquired()
	{
	}

	private void ClearWriterAcquired()
	{
	}

	private void SetWritersWaiting()
	{
	}

	private void ClearWritersWaiting()
	{
	}

	private void SetUpgraderWaiting()
	{
	}

	private void ClearUpgraderWaiting()
	{
	}

	private uint GetNumReaders()
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void EnterMyLock()
	{
	}

	private void EnterMyLockSpin()
	{
	}

	private void ExitMyLock()
	{
	}

	private static void SpinWait(int SpinCount)
	{
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.ReaderWriterLockSlim" /> class.</summary>
	/// <exception cref="T:System.Threading.SynchronizationLockException">
	///         <see cref="P:System.Threading.ReaderWriterLockSlim.WaitingReadCount" /> is greater than zero. -or-
	///         <see cref="P:System.Threading.ReaderWriterLockSlim.WaitingUpgradeCount" /> is greater than zero. -or-
	///         <see cref="P:System.Threading.ReaderWriterLockSlim.WaitingWriteCount" /> is greater than zero. </exception>
	public void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}
}
