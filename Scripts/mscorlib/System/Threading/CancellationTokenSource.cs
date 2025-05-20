namespace System.Threading;

/// <summary>Signals to a <see cref="T:System.Threading.CancellationToken" /> that it should be canceled.</summary>
public class CancellationTokenSource : IDisposable
{
	private sealed class Linked1CancellationTokenSource : CancellationTokenSource
	{
		private readonly CancellationTokenRegistration _reg1;

		internal Linked1CancellationTokenSource(CancellationToken token1)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}

	private sealed class Linked2CancellationTokenSource : CancellationTokenSource
	{
		private readonly CancellationTokenRegistration _reg1;

		private readonly CancellationTokenRegistration _reg2;

		internal Linked2CancellationTokenSource(CancellationToken token1, CancellationToken token2)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}

	private sealed class LinkedNCancellationTokenSource : CancellationTokenSource
	{
		internal static readonly Action<object> s_linkedTokenCancelDelegate;
	}

	internal static readonly CancellationTokenSource s_canceledSource;

	internal static readonly CancellationTokenSource s_neverCanceledSource;

	private static readonly int s_nLists;

	private ManualResetEvent _kernelEvent;

	private SparselyPopulatedArray<CancellationCallbackInfo>[] _registeredCallbacksLists;

	private const int CannotBeCanceled = 0;

	private const int NotCanceledState = 1;

	private const int NotifyingState = 2;

	private const int NotifyingCompleteState = 3;

	private int _state;

	private int _threadIDExecutingCallbacks;

	private bool _disposed;

	private CancellationCallbackInfo _executingCallback;

	private Timer _timer;

	private static readonly TimerCallback s_timerCallback;

	/// <summary>Gets whether cancellation has been requested for this <see cref="T:System.Threading.CancellationTokenSource" />.</summary>
	/// <returns>
	///   <see langword="true" /> if cancellation has been requested for this <see cref="T:System.Threading.CancellationTokenSource" />; otherwise, <see langword="false" />.</returns>
	public bool IsCancellationRequested => false;

	internal bool IsCancellationCompleted => false;

	internal bool IsDisposed => false;

	internal int ThreadIDExecutingCallbacks
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets the <see cref="T:System.Threading.CancellationToken" /> associated with this <see cref="T:System.Threading.CancellationTokenSource" />.</summary>
	/// <returns>The <see cref="T:System.Threading.CancellationToken" /> associated with this <see cref="T:System.Threading.CancellationTokenSource" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The token source has been disposed.</exception>
	public CancellationToken Token => default(CancellationToken);

	internal CancellationCallbackInfo ExecutingCallback => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.CancellationTokenSource" /> class.</summary>
	public CancellationTokenSource()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.CancellationTokenSource" /> class that will be canceled after the specified time span.</summary>
	/// <param name="delay">The time interval to wait before canceling this <see cref="T:System.Threading.CancellationTokenSource" />.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="delay" />.<see cref="P:System.TimeSpan.TotalMilliseconds" /> is less than -1 or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	public CancellationTokenSource(TimeSpan delay)
	{
	}

	private void InitializeWithTimer(int millisecondsDelay)
	{
	}

	/// <summary>Communicates a request for cancellation.</summary>
	/// <exception cref="T:System.ObjectDisposedException">This <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
	/// <exception cref="T:System.AggregateException">An aggregate exception containing all the exceptions thrown by the registered callbacks on the associated <see cref="T:System.Threading.CancellationToken" />.</exception>
	public void Cancel()
	{
	}

	/// <summary>Communicates a request for cancellation, and specifies whether remaining callbacks and cancelable operations should be processed if an exception occurs.</summary>
	/// <param name="throwOnFirstException">
	///   <see langword="true" /> if exceptions should immediately propagate; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ObjectDisposedException">This <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
	/// <exception cref="T:System.AggregateException">An aggregate exception containing all the exceptions thrown by the registered callbacks on the associated <see cref="T:System.Threading.CancellationToken" />.</exception>
	public void Cancel(bool throwOnFirstException)
	{
	}

	/// <summary>Schedules a cancel operation on this <see cref="T:System.Threading.CancellationTokenSource" /> after the specified time span.</summary>
	/// <param name="delay">The time span to wait before canceling this <see cref="T:System.Threading.CancellationTokenSource" />.</param>
	/// <exception cref="T:System.ObjectDisposedException">The exception thrown when this <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when <paramref name="delay" /> is less than -1 or greater than Int32.MaxValue.</exception>
	public void CancelAfter(TimeSpan delay)
	{
	}

	/// <summary>Schedules a cancel operation on this <see cref="T:System.Threading.CancellationTokenSource" /> after the specified number of milliseconds.</summary>
	/// <param name="millisecondsDelay">The time span to wait before canceling this <see cref="T:System.Threading.CancellationTokenSource" />.</param>
	/// <exception cref="T:System.ObjectDisposedException">The exception thrown when this <see cref="T:System.Threading.CancellationTokenSource" /> has been disposed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The exception thrown when <paramref name="millisecondsDelay" /> is less than -1.</exception>
	public void CancelAfter(int millisecondsDelay)
	{
	}

	private static void TimerCallbackLogic(object obj)
	{
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.CancellationTokenSource" /> class.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Threading.CancellationTokenSource" /> class and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	internal void ThrowIfDisposed()
	{
	}

	private static void ThrowObjectDisposedException()
	{
	}

	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext)
	{
		return default(CancellationTokenRegistration);
	}

	private void NotifyCancellation(bool throwOnFirstException)
	{
	}

	private void ExecuteCallbackHandlers(bool throwOnFirstException)
	{
	}

	private void CancellationCallbackCoreWork_OnSyncContext(object obj)
	{
	}

	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args)
	{
	}

	/// <summary>Creates a <see cref="T:System.Threading.CancellationTokenSource" /> that will be in the canceled state when any of the source tokens are in the canceled state.</summary>
	/// <param name="token1">The first cancellation token to observe.</param>
	/// <param name="token2">The second cancellation token to observe.</param>
	/// <returns>A <see cref="T:System.Threading.CancellationTokenSource" /> that is linked to the source tokens.</returns>
	/// <exception cref="T:System.ObjectDisposedException">A <see cref="T:System.Threading.CancellationTokenSource" /> associated with one of the source tokens has been disposed.</exception>
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2)
	{
		return null;
	}

	internal static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token)
	{
		return null;
	}

	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo)
	{
	}
}
