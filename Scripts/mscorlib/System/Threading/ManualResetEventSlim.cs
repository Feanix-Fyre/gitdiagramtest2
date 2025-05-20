using System.Diagnostics;

namespace System.Threading;

/// <summary>Provides a slimmed down version of <see cref="T:System.Threading.ManualResetEvent" />.</summary>
[DebuggerDisplay("Set = {IsSet}")]
public class ManualResetEventSlim : IDisposable
{
	private const int DEFAULT_SPIN_SP = 1;

	private object m_lock;

	private ManualResetEvent m_eventObj;

	private int m_combinedState;

	private const int SignalledState_BitMask = int.MinValue;

	private const int SignalledState_ShiftCount = 31;

	private const int Dispose_BitMask = 1073741824;

	private const int SpinCountState_BitMask = 1073217536;

	private const int SpinCountState_ShiftCount = 19;

	private const int SpinCountState_MaxValue = 2047;

	private const int NumWaitersState_BitMask = 524287;

	private const int NumWaitersState_ShiftCount = 0;

	private const int NumWaitersState_MaxValue = 524287;

	private static Action<object> s_cancellationTokenCallback;

	/// <summary>Gets the underlying <see cref="T:System.Threading.WaitHandle" /> object for this <see cref="T:System.Threading.ManualResetEventSlim" />.</summary>
	/// <returns>The underlying <see cref="T:System.Threading.WaitHandle" /> event object fore this <see cref="T:System.Threading.ManualResetEventSlim" />.</returns>
	public WaitHandle WaitHandle => null;

	/// <summary>Gets whether the event is set.</summary>
	/// <returns>true if the event has is set; otherwise, false.</returns>
	public bool IsSet
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	/// <summary>Gets the number of spin waits that will occur before falling back to a kernel-based wait operation.</summary>
	/// <returns>Returns the number of spin waits that will occur before falling back to a kernel-based wait operation.</returns>
	public int SpinCount
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	private int Waiters
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ManualResetEventSlim" /> class with a Boolean value indicating whether to set the intial state to signaled.</summary>
	/// <param name="initialState">true to set the initial state signaled; false to set the initial state to nonsignaled.</param>
	public ManualResetEventSlim(bool initialState)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ManualResetEventSlim" /> class with a Boolean value indicating whether to set the intial state to signaled and a specified spin count.</summary>
	/// <param name="initialState">true to set the initial state to signaled; false to set the initial state to nonsignaled.</param>
	/// <param name="spinCount">The number of spin waits that will occur before falling back to a kernel-based wait operation.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="spinCount" /> is less than 0 or greater than the maximum allowed value.</exception>
	public ManualResetEventSlim(bool initialState, int spinCount)
	{
	}

	private void Initialize(bool initialState, int spinCount)
	{
	}

	private void EnsureLockObjectCreated()
	{
	}

	private bool LazyInitializeEvent()
	{
		return false;
	}

	/// <summary>Sets the state of the event to signaled, which allows one or more threads waiting on the event to proceed.</summary>
	public void Set()
	{
	}

	private void Set(bool duringCancellation)
	{
	}

	/// <summary>Sets the state of the event to nonsignaled, which causes threads to block.</summary>
	/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
	public void Reset()
	{
	}

	/// <summary>Blocks the current thread until the current <see cref="T:System.Threading.ManualResetEventSlim" /> is set.</summary>
	/// <exception cref="T:System.InvalidOperationException">The maximum number of waiters has been exceeded.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
	public void Wait()
	{
	}

	/// <summary>Blocks the current thread until the current <see cref="T:System.Threading.ManualResetEventSlim" /> is set, using a 32-bit signed integer to measure the time interval, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" />(-1) to wait indefinitely.</param>
	/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Threading.ManualResetEventSlim" /> was set; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.OperationCanceledException">
	///   <paramref name="cancellationToken" /> was canceled.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
	/// <exception cref="T:System.InvalidOperationException">The maximum number of waiters has been exceeded.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed or the <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has been disposed.</exception>
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
	{
		return false;
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.ManualResetEventSlim" /> class.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Threading.ManualResetEventSlim" />, and optionally releases the managed resources.</summary>
	/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	private void ThrowIfDisposed()
	{
	}

	private static void CancellationTokenCallback(object obj)
	{
	}

	private void UpdateStateAtomically(int newBits, int updateBitsMask)
	{
	}

	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount)
	{
		return 0;
	}

	private static int ExtractStatePortion(int state, int mask)
	{
		return 0;
	}
}
