using System.Runtime.CompilerServices;

namespace System.Threading;

/// <summary>Provides a pool of threads that can be used to execute tasks, post work items, process asynchronous I/O, wait on behalf of other threads, and process timers.</summary>
public static class ThreadPool
{
	internal static bool IsThreadPoolThread => false;

	/// <summary>Retrieves the difference between the maximum number of thread pool threads returned by the <see cref="M:System.Threading.ThreadPool.GetMaxThreads(System.Int32@,System.Int32@)" /> method, and the number currently active.</summary>
	/// <param name="workerThreads">The number of available worker threads.</param>
	/// <param name="completionPortThreads">The number of available asynchronous I/O threads.</param>
	public static void GetAvailableThreads(out int workerThreads, out int completionPortThreads)
	{
		workerThreads = default(int);
		completionPortThreads = default(int);
	}

	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack)
	{
		return null;
	}

	/// <summary>Registers a delegate to wait for a <see cref="T:System.Threading.WaitHandle" />, specifying a <see cref="T:System.TimeSpan" /> value for the time-out.</summary>
	/// <param name="waitObject">The <see cref="T:System.Threading.WaitHandle" /> to register. Use a <see cref="T:System.Threading.WaitHandle" /> other than <see cref="T:System.Threading.Mutex" />.</param>
	/// <param name="callBack">The <see cref="T:System.Threading.WaitOrTimerCallback" /> delegate to call when the <paramref name="waitObject" /> parameter is signaled.</param>
	/// <param name="state">The object passed to the delegate.</param>
	/// <param name="timeout">The time-out represented by a <see cref="T:System.TimeSpan" />. If <paramref name="timeout" /> is 0 (zero), the function tests the object's state and returns immediately. If <paramref name="timeout" /> is -1, the function's time-out interval never elapses.</param>
	/// <param name="executeOnlyOnce">
	///   <see langword="true" /> to indicate that the thread will no longer wait on the <paramref name="waitObject" /> parameter after the delegate has been called; <see langword="false" /> to indicate that the timer is reset every time the wait operation completes until the wait is unregistered.</param>
	/// <returns>The <see cref="T:System.Threading.RegisteredWaitHandle" /> that encapsulates the native handle.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="timeout" /> parameter is less than -1.</exception>
	/// <exception cref="T:System.NotSupportedException">The <paramref name="timeout" /> parameter is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce)
	{
		return null;
	}

	/// <summary>Queues a method for execution, and specifies an object containing data to be used by the method. The method executes when a thread pool thread becomes available.</summary>
	/// <param name="callBack">A <see cref="T:System.Threading.WaitCallback" /> representing the method to execute.</param>
	/// <param name="state">An object containing data to be used by the method.</param>
	/// <returns>
	///   <see langword="true" /> if the method is successfully queued; <see cref="T:System.NotSupportedException" /> is thrown if the work item could not be queued.</returns>
	/// <exception cref="T:System.NotSupportedException">The common language runtime (CLR) is hosted, and the host does not support this action.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="callBack" /> is <see langword="null" />.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool QueueUserWorkItem(WaitCallback callBack, object state)
	{
		return false;
	}

	/// <summary>Queues a method for execution. The method executes when a thread pool thread becomes available.</summary>
	/// <param name="callBack">A <see cref="T:System.Threading.WaitCallback" /> that represents the method to be executed.</param>
	/// <returns>
	///   <see langword="true" /> if the method is successfully queued; <see cref="T:System.NotSupportedException" /> is thrown if the work item could not be queued.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="callBack" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The common language runtime (CLR) is hosted, and the host does not support this action.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool QueueUserWorkItem(WaitCallback callBack)
	{
		return false;
	}

	/// <summary>Queues the specified delegate to the thread pool, but does not propagate the calling stack to the worker thread.</summary>
	/// <param name="callBack">A <see cref="T:System.Threading.WaitCallback" /> that represents the delegate to invoke when a thread in the thread pool picks up the work item.</param>
	/// <param name="state">The object that is passed to the delegate when serviced from the thread pool.</param>
	/// <returns>
	///   <see langword="true" /> if the method succeeds; <see cref="T:System.OutOfMemoryException" /> is thrown if the work item could not be queued.</returns>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.ApplicationException">An out-of-memory condition was encountered.</exception>
	/// <exception cref="T:System.OutOfMemoryException">The work item could not be queued.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="callBack" /> is <see langword="null" />.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state)
	{
		return false;
	}

	public static bool QueueUserWorkItem<TState>(Action<TState> callBack, TState state, bool preferLocal)
	{
		return false;
	}

	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = true)
	{
		return false;
	}

	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal)
	{
	}

	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem)
	{
		return false;
	}

	internal static bool RequestWorkerThread()
	{
		return false;
	}

	private static void EnsureVMInitialized()
	{
	}

	private static void GetAvailableThreadsNative(out int workerThreads, out int completionPortThreads)
	{
		workerThreads = default(int);
		completionPortThreads = default(int);
	}

	internal static bool NotifyWorkItemComplete()
	{
		return false;
	}

	internal static void ReportThreadStatus(bool isWorking)
	{
	}

	internal static void NotifyWorkItemProgress()
	{
	}

	internal static void NotifyWorkItemProgressNative()
	{
	}

	internal static void NotifyWorkItemQueued()
	{
	}

	private static void InitializeVMTp(ref bool enableWorkerTracking)
	{
	}
}
