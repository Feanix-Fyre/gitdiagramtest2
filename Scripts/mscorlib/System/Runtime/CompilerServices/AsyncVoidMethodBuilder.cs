using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

/// <summary>Represents a builder for asynchronous methods that do not return a value.</summary>
public struct AsyncVoidMethodBuilder
{
	private SynchronizationContext m_synchronizationContext;

	private AsyncMethodBuilderCore m_coreState;

	private Task m_task;

	internal Task Task => null;

	/// <summary>Creates an instance of the <see cref="T:System.Runtime.CompilerServices.AsyncVoidMethodBuilder" /> class.</summary>
	/// <returns>A new instance of the builder.</returns>
	public static AsyncVoidMethodBuilder Create()
	{
		return default(AsyncVoidMethodBuilder);
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

	/// <summary>Marks the method builder as successfully completed.</summary>
	/// <exception cref="T:System.InvalidOperationException">The builder is not initialized.</exception>
	public void SetResult()
	{
	}

	/// <summary>Binds an exception to the method builder.</summary>
	/// <param name="exception">The exception to bind.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="exception" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The builder is not initialized.</exception>
	public void SetException(Exception exception)
	{
	}

	private void NotifySynchronizationContextOfCompletion()
	{
	}
}
