using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

/// <summary>Represents a builder for asynchronous methods that return a task.</summary>
public struct AsyncTaskMethodBuilder
{
	private static readonly Task<VoidTaskResult> s_cachedCompleted;

	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder;

	/// <summary>Gets the task for this builder.</summary>
	/// <returns>The task for this builder.</returns>
	/// <exception cref="T:System.InvalidOperationException">The builder is not initialized.</exception>
	public Task Task => null;

	/// <summary>Creates an instance of the <see cref="T:System.Runtime.CompilerServices.AsyncTaskMethodBuilder" /> class.</summary>
	/// <returns>A new instance of the builder.</returns>
	public static AsyncTaskMethodBuilder Create()
	{
		return default(AsyncTaskMethodBuilder);
	}

	/// <summary>Begins running the builder with the associated state machine.</summary>
	/// <param name="stateMachine">The state machine instance, passed by reference.</param>
	/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stateMachine" /> is <see langword="null" />.</exception>
	[DebuggerStepThrough]
	public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
	{
	}

	/// <summary>Associates the builder with the specified state machine.</summary>
	/// <param name="stateMachine">The state machine instance to associate with the builder.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stateMachine" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The state machine was previously set.</exception>
	public void SetStateMachine(IAsyncStateMachine stateMachine)
	{
	}

	/// <summary>Schedules the state machine to proceed to the next action when the specified awaiter completes. This method can be called from partially trusted code.</summary>
	/// <param name="awaiter">The awaiter.</param>
	/// <param name="stateMachine">The state machine.</param>
	/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
	/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
	{
	}

	/// <summary>Marks the task as successfully completed.</summary>
	/// <exception cref="T:System.InvalidOperationException">The task has already completed.  
	///  -or-  
	///  The builder is not initialized.</exception>
	public void SetResult()
	{
	}

	/// <summary>Marks the task as failed and binds the specified exception to the task.</summary>
	/// <param name="exception">The exception to bind to the task.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="exception" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The task has already completed.  
	///  -or-  
	///  The builder is not initialized.</exception>
	public void SetException(Exception exception)
	{
	}
}
/// <summary>Represents a builder for asynchronous methods that returns a task and provides a parameter for the result.</summary>
/// <typeparam name="TResult">The result to use to complete the task.</typeparam>
public struct AsyncTaskMethodBuilder<TResult>
{
	internal static readonly Task<TResult> s_defaultResultTask;

	private AsyncMethodBuilderCore m_coreState;

	private Task<TResult> m_task;

	/// <summary>Gets the task for this builder.</summary>
	/// <returns>The task for this builder.</returns>
	public Task<TResult> Task => null;

	/// <summary>Creates an instance of the <see cref="T:System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1" /> class.</summary>
	/// <returns>A new instance of the builder.</returns>
	public static AsyncTaskMethodBuilder<TResult> Create()
	{
		return default(AsyncTaskMethodBuilder<TResult>);
	}

	/// <summary>Begins running the builder with the associated state machine.</summary>
	/// <param name="stateMachine">The state machine instance, passed by reference.</param>
	/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stateMachine" /> is <see langword="null" />.</exception>
	[DebuggerStepThrough]
	public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
	{
	}

	/// <summary>Associates the builder with the specified state machine.</summary>
	/// <param name="stateMachine">The state machine instance to associate with the builder.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stateMachine" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The state machine was previously set.</exception>
	public void SetStateMachine(IAsyncStateMachine stateMachine)
	{
	}

	/// <summary>Schedules the state machine to proceed to the next action when the specified awaiter completes. This method can be called from partially trusted code.</summary>
	/// <param name="awaiter">The awaiter.</param>
	/// <param name="stateMachine">The state machine.</param>
	/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
	/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
	{
	}

	/// <summary>Marks the task as successfully completed.</summary>
	/// <param name="result">The result to use to complete the task.</param>
	/// <exception cref="T:System.InvalidOperationException">The task has already completed.</exception>
	public void SetResult(TResult result)
	{
	}

	internal void SetResult(Task<TResult> completedTask)
	{
	}

	/// <summary>Marks the task as failed and binds the specified exception to the task.</summary>
	/// <param name="exception">The exception to bind to the task.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="exception" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The task has already completed.</exception>
	public void SetException(Exception exception)
	{
	}

	internal static Task<TResult> GetTaskForResult(TResult result)
	{
		return null;
	}
}
