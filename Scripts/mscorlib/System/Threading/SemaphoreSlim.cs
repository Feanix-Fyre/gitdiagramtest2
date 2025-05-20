using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Threading;

/// <summary>Represents a lightweight alternative to <see cref="T:System.Threading.Semaphore" /> that limits the number of threads that can access a resource or pool of resources concurrently.</summary>
[ComVisible(false)]
[DebuggerDisplay("Current Count = {m_currentCount}")]
public class SemaphoreSlim : IDisposable
{
	private sealed class TaskNode : Task<bool>, IThreadPoolWorkItem
	{
		internal TaskNode Prev;

		internal TaskNode Next;

		internal TaskNode()
		{
		}

		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
		}

		void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CWaitUntilCountOrTimeoutAsync_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public CancellationToken cancellationToken;

		public TaskNode asyncWaiter;

		public int millisecondsTimeout;

		public SemaphoreSlim _003C_003E4__this;

		private CancellationTokenSource _003Ccts_003E5__2;

		private object _003C_003E7__wrap2;

		private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private int m_currentCount;

	private readonly int m_maxCount;

	private int m_waitCount;

	private object m_lockObj;

	private ManualResetEvent m_waitHandle;

	private TaskNode m_asyncHead;

	private TaskNode m_asyncTail;

	private static readonly Task<bool> s_trueTask;

	private static readonly Task<bool> s_falseTask;

	private const int NO_MAXIMUM = int.MaxValue;

	private static Action<object> s_cancellationTokenCanceledEventHandler;

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.SemaphoreSlim" /> class, specifying the initial and maximum number of requests that can be granted concurrently.</summary>
	/// <param name="initialCount">The initial number of requests for the semaphore that can be granted concurrently.</param>
	/// <param name="maxCount">The maximum number of requests for the semaphore that can be granted concurrently.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="initialCount" /> is less than 0, or <paramref name="initialCount" /> is greater than <paramref name="maxCount" />, or <paramref name="maxCount" /> is equal to or less than 0.</exception>
	public SemaphoreSlim(int initialCount, int maxCount)
	{
	}

	/// <summary>Blocks the current thread until it can enter the <see cref="T:System.Threading.SemaphoreSlim" />.</summary>
	/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception>
	public void Wait()
	{
	}

	/// <summary>Blocks the current thread until it can enter the <see cref="T:System.Threading.SemaphoreSlim" />, using a 32-bit signed integer that specifies the timeout, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, <see cref="F:System.Threading.Timeout.Infinite" />(-1) to wait indefinitely, or zero to test the state of the wait handle and return immediately.</param>
	/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe.</param>
	/// <returns>
	///   <see langword="true" /> if the current thread successfully entered the <see cref="T:System.Threading.SemaphoreSlim" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.OperationCanceledException">
	///   <paramref name="cancellationToken" /> was canceled.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite timeout -or- timeout is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.SemaphoreSlim" /> instance has been disposed, or the <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has been disposed.</exception>
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
	{
		return false;
	}

	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken)
	{
		return false;
	}

	/// <summary>Asynchronously waits to enter the <see cref="T:System.Threading.SemaphoreSlim" />.</summary>
	/// <returns>A task that will complete when the semaphore has been entered.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.SemaphoreSlim" /> has been disposed.</exception>
	public Task WaitAsync()
	{
		return null;
	}

	/// <summary>Asynchronously waits to enter the <see cref="T:System.Threading.SemaphoreSlim" />, using a 32-bit signed integer to measure the time interval, while observing a <see cref="T:System.Threading.CancellationToken" />.</summary>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely, or zero to test the state of the wait handle and return immediately.</param>
	/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to observe.</param>
	/// <returns>A task that will complete with a result of <see langword="true" /> if the current thread successfully entered the <see cref="T:System.Threading.SemaphoreSlim" />, otherwise with a result of <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="millisecondsTimeout" /> is a number other than -1, which represents an infinite timeout -or- timeout is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception>
	/// <exception cref="T:System.OperationCanceledException">
	///   <paramref name="cancellationToken" /> was canceled.</exception>
	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken)
	{
		return null;
	}

	private TaskNode CreateAndAddAsyncWaiter()
	{
		return null;
	}

	private bool RemoveAsyncWaiter(TaskNode task)
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CWaitUntilCountOrTimeoutAsync_003Ed__32))]
	private Task<bool> WaitUntilCountOrTimeoutAsync(TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Releases the <see cref="T:System.Threading.SemaphoreSlim" /> object once.</summary>
	/// <returns>The previous count of the <see cref="T:System.Threading.SemaphoreSlim" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception>
	/// <exception cref="T:System.Threading.SemaphoreFullException">The <see cref="T:System.Threading.SemaphoreSlim" /> has already reached its maximum size.</exception>
	public int Release()
	{
		return 0;
	}

	/// <summary>Releases the <see cref="T:System.Threading.SemaphoreSlim" /> object a specified number of times.</summary>
	/// <param name="releaseCount">The number of times to exit the semaphore.</param>
	/// <returns>The previous count of the <see cref="T:System.Threading.SemaphoreSlim" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="releaseCount" /> is less than 1.</exception>
	/// <exception cref="T:System.Threading.SemaphoreFullException">The <see cref="T:System.Threading.SemaphoreSlim" /> has already reached its maximum size.</exception>
	public int Release(int releaseCount)
	{
		return 0;
	}

	private static void QueueWaiterTask(TaskNode waiterTask)
	{
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.SemaphoreSlim" /> class.</summary>
	public void Dispose()
	{
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Threading.SemaphoreSlim" />, and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
	}

	private static void CancellationTokenCanceledEventHandler(object obj)
	{
	}

	private void CheckDispose()
	{
	}

	private static string GetResourceString(string str)
	{
		return null;
	}
}
