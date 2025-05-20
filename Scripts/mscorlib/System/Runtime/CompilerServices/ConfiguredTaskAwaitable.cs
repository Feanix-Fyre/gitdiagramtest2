using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

/// <summary>Provides an awaitable object that enables configured awaits on a task.</summary>
public readonly struct ConfiguredTaskAwaitable
{
	/// <summary>Provides an awaiter for an awaitable (<see cref="T:System.Runtime.CompilerServices.ConfiguredTaskAwaitable" />) object.</summary>
	public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		internal readonly Task m_task;

		internal readonly bool m_continueOnCapturedContext;

		/// <summary>Gets a value that specifies whether the task being awaited is completed.</summary>
		/// <returns>
		///   <see langword="true" /> if the task being awaited is completed; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.NullReferenceException">The awaiter was not properly initialized.</exception>
		public bool IsCompleted => false;

		internal ConfiguredTaskAwaiter(Task task, bool continueOnCapturedContext)
		{
			m_task = null;
			m_continueOnCapturedContext = false;
		}

		/// <summary>Schedules the continuation action for the task associated with this awaiter.</summary>
		/// <param name="continuation">The action to invoke when the await operation completes.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuation" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.NullReferenceException">The awaiter was not properly initialized.</exception>
		public void OnCompleted(Action continuation)
		{
		}

		/// <summary>Schedules the continuation action for the task associated with this awaiter.</summary>
		/// <param name="continuation">The action to invoke when the await operation completes.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuation" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.NullReferenceException">The awaiter was not properly initialized.</exception>
		public void UnsafeOnCompleted(Action continuation)
		{
		}

		/// <summary>Ends the await on the completed task.</summary>
		/// <exception cref="T:System.NullReferenceException">The awaiter was not properly initialized.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task was canceled.</exception>
		/// <exception cref="T:System.Exception">The task completed in a faulted state.</exception>
		[StackTraceHidden]
		public void GetResult()
		{
		}
	}

	private readonly ConfiguredTaskAwaiter m_configuredTaskAwaiter;

	internal ConfiguredTaskAwaitable(Task task, bool continueOnCapturedContext)
	{
		m_configuredTaskAwaiter = default(ConfiguredTaskAwaiter);
	}

	/// <summary>Returns an awaiter for this awaitable object.</summary>
	/// <returns>The awaiter.</returns>
	public ConfiguredTaskAwaiter GetAwaiter()
	{
		return default(ConfiguredTaskAwaiter);
	}
}
/// <summary>Provides an awaitable object that enables configured awaits on a task.</summary>
/// <typeparam name="TResult">The type of the result produced by this <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
public readonly struct ConfiguredTaskAwaitable<TResult>
{
	/// <summary>Provides an awaiter for an awaitable object(<see cref="T:System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1" />).</summary>
	/// <typeparam name="TResult" />
	public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly Task<TResult> m_task;

		private readonly bool m_continueOnCapturedContext;

		/// <summary>Gets a value that specifies whether the task being awaited has been completed.</summary>
		/// <returns>
		///   <see langword="true" /> if the task being awaited has been completed; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.NullReferenceException">The awaiter was not properly initialized.</exception>
		public bool IsCompleted => false;

		internal ConfiguredTaskAwaiter(Task<TResult> task, bool continueOnCapturedContext)
		{
			m_task = null;
			m_continueOnCapturedContext = false;
		}

		/// <summary>Schedules the continuation action for the task associated with this awaiter.</summary>
		/// <param name="continuation">The action to invoke when the await operation completes.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuation" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.NullReferenceException">The awaiter was not properly initialized.</exception>
		public void UnsafeOnCompleted(Action continuation)
		{
		}

		/// <summary>Ends the await on the completed task.</summary>
		/// <returns>The result of the completed task.</returns>
		/// <exception cref="T:System.NullReferenceException">The awaiter was not properly initialized.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task was canceled.</exception>
		/// <exception cref="T:System.Exception">The task completed in a faulted state.</exception>
		[StackTraceHidden]
		public TResult GetResult()
		{
			return default(TResult);
		}
	}

	private readonly ConfiguredTaskAwaiter m_configuredTaskAwaiter;

	internal ConfiguredTaskAwaitable(Task<TResult> task, bool continueOnCapturedContext)
	{
		m_configuredTaskAwaiter = default(ConfiguredTaskAwaiter);
	}

	/// <summary>Returns an awaiter for this awaitable object.</summary>
	/// <returns>The awaiter.</returns>
	public ConfiguredTaskAwaiter GetAwaiter()
	{
		return default(ConfiguredTaskAwaiter);
	}
}
