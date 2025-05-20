using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

/// <summary>Provides an object that waits for the completion of an asynchronous task.</summary>
public readonly struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	internal readonly Task m_task;

	/// <summary>Gets a value that indicates whether the asynchronous task has completed.</summary>
	/// <returns>
	///   <see langword="true" /> if the task has completed; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.NullReferenceException">The <see cref="T:System.Runtime.CompilerServices.TaskAwaiter" /> object was not properly initialized.</exception>
	public bool IsCompleted => false;

	internal TaskAwaiter(Task task)
	{
		m_task = null;
	}

	/// <summary>Schedules the continuation action for the asynchronous task that is associated with this awaiter.</summary>
	/// <param name="continuation">The action to invoke when the await operation completes.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="continuation" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The awaiter was not properly initialized.</exception>
	public void UnsafeOnCompleted(Action continuation)
	{
	}

	/// <summary>Ends the wait for the completion of the asynchronous task.</summary>
	/// <exception cref="T:System.NullReferenceException">The <see cref="T:System.Runtime.CompilerServices.TaskAwaiter" /> object was not properly initialized.</exception>
	/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task was canceled.</exception>
	/// <exception cref="T:System.Exception">The task completed in a <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> state.</exception>
	[StackTraceHidden]
	public void GetResult()
	{
	}

	[StackTraceHidden]
	internal static void ValidateEnd(Task task)
	{
	}

	[StackTraceHidden]
	private static void HandleNonSuccessAndDebuggerNotification(Task task)
	{
	}

	[StackTraceHidden]
	private static void ThrowForNonSuccess(Task task)
	{
	}

	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext)
	{
	}

	private static Action OutputWaitEtwEvents(Task task, Action continuation)
	{
		return null;
	}
}
/// <summary>Represents an object that waits for the completion of an asynchronous task and provides a parameter for the result.</summary>
/// <typeparam name="TResult">The result for the task.</typeparam>
public readonly struct TaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion
{
	private readonly Task<TResult> m_task;

	/// <summary>Gets a value that indicates whether the asynchronous task has completed.</summary>
	/// <returns>
	///   <see langword="true" /> if the task has completed; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.NullReferenceException">The <see cref="T:System.Runtime.CompilerServices.TaskAwaiter`1" /> object was not properly initialized.</exception>
	public bool IsCompleted => false;

	internal TaskAwaiter(Task<TResult> task)
	{
		m_task = null;
	}

	/// <summary>Schedules the continuation action for the asynchronous task associated with this awaiter.</summary>
	/// <param name="continuation">The action to invoke when the await operation completes.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="continuation" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The awaiter was not properly initialized.</exception>
	public void UnsafeOnCompleted(Action continuation)
	{
	}

	/// <summary>Ends the wait for the completion of the asynchronous task.</summary>
	/// <returns>The result of the completed task.</returns>
	/// <exception cref="T:System.NullReferenceException">The <see cref="T:System.Runtime.CompilerServices.TaskAwaiter`1" /> object was not properly initialized.</exception>
	/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task was canceled.</exception>
	/// <exception cref="T:System.Exception">The task completed in a <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> state.</exception>
	[StackTraceHidden]
	public TResult GetResult()
	{
		return default(TResult);
	}
}
