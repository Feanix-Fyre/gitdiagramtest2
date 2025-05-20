using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading;

/// <summary>Provides a mutual exclusion lock primitive where a thread trying to acquire the lock waits in a loop repeatedly checking until the lock becomes available.</summary>
[ComVisible(false)]
[DebuggerTypeProxy(typeof(SystemThreading_SpinLockDebugView))]
[DebuggerDisplay("IsHeld = {IsHeld}")]
public struct SpinLock
{
	internal class SystemThreading_SpinLockDebugView
	{
	}

	private int m_owner;

	private static int MAXIMUM_WAITERS;

	/// <summary>Gets whether the lock is held by the current thread.</summary>
	/// <returns>true if the lock is held by the current thread; otherwise false.</returns>
	/// <exception cref="T:System.InvalidOperationException">Thread ownership tracking is disabled.</exception>
	public bool IsHeldByCurrentThread
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return false;
		}
	}

	/// <summary>Gets whether thread ownership tracking is enabled for this instance.</summary>
	/// <returns>true if thread ownership tracking is enabled for this instance; otherwise false.</returns>
	public bool IsThreadOwnerTrackingEnabled
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return false;
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.SpinLock" /> structure with the option to track thread IDs to improve debugging.</summary>
	/// <param name="enableThreadOwnerTracking">Whether to capture and use thread IDs for debugging purposes.</param>
	public SpinLock(bool enableThreadOwnerTracking)
	{
		m_owner = 0;
	}

	/// <summary>Acquires the lock in a reliable manner, such that even if an exception occurs within the method call, <paramref name="lockTaken" /> can be examined reliably to determine whether the lock was acquired.</summary>
	/// <param name="lockTaken">True if the lock is acquired; otherwise, false. <paramref name="lockTaken" /> must be initialized to false prior to calling this method.</param>
	/// <exception cref="T:System.ArgumentException">The <paramref name="lockTaken" /> argument must be initialized to false prior to calling Enter.</exception>
	/// <exception cref="T:System.Threading.LockRecursionException">Thread ownership tracking is enabled, and the current thread has already acquired this lock.</exception>
	public void Enter(ref bool lockTaken)
	{
	}

	/// <summary>Attempts to acquire the lock in a reliable manner, such that even if an exception occurs within the method call, <paramref name="lockTaken" /> can be examined reliably to determine whether the lock was acquired.</summary>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
	/// <param name="lockTaken">True if the lock is acquired; otherwise, false. <paramref name="lockTaken" /> must be initialized to false prior to calling this method.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="lockTaken" /> argument must be initialized to false prior to calling TryEnter.</exception>
	/// <exception cref="T:System.Threading.LockRecursionException">Thread ownership tracking is enabled, and the current thread has already acquired this lock.</exception>
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken)
	{
	}

	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken)
	{
	}

	private void DecrementWaiters()
	{
	}

	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken)
	{
	}

	/// <summary>Releases the lock.</summary>
	/// <param name="useMemoryBarrier">A Boolean value that indicates whether a memory fence should be issued in order to immediately publish the exit operation to other threads.</param>
	/// <exception cref="T:System.Threading.SynchronizationLockException">Thread ownership tracking is enabled, and the current thread is not the owner of this lock.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void Exit(bool useMemoryBarrier)
	{
	}

	private void ExitSlowPath(bool useMemoryBarrier)
	{
	}
}
