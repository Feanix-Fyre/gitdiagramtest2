using System.Collections.Generic;

namespace System.Threading.Tasks;

/// <summary>Provides support for creating and scheduling <see cref="T:System.Threading.Tasks.Task`1" /> objects.</summary>
/// <typeparam name="TResult">The return value of the <see cref="T:System.Threading.Tasks.Task`1" /> objects that the methods of this class create.</typeparam>
public class TaskFactory<TResult>
{
	private sealed class FromAsyncTrimPromise<TInstance> : Task<TResult> where TInstance : class
	{
		internal static readonly AsyncCallback s_completeFromAsyncResult;

		private TInstance m_thisRef;

		private Func<TInstance, IAsyncResult, TResult> m_endMethod;

		internal FromAsyncTrimPromise(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod)
		{
		}

		internal static void CompleteFromAsyncResult(IAsyncResult asyncResult)
		{
		}

		internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization)
		{
		}
	}

	private CancellationToken m_defaultCancellationToken;

	private TaskScheduler m_defaultScheduler;

	private TaskCreationOptions m_defaultCreationOptions;

	private TaskContinuationOptions m_defaultContinuationOptions;

	/// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory`1" /> instance with the default configuration.</summary>
	public TaskFactory()
	{
	}

	/// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory`1" /> instance with the specified configuration.</summary>
	/// <param name="cancellationToken">The default cancellation token that will be assigned to tasks created by this <see cref="T:System.Threading.Tasks.TaskFactory" /> unless another cancellation token is explicitly specified when calling the factory methods.</param>
	/// <param name="creationOptions">The default options to use when creating tasks with this <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</param>
	/// <param name="continuationOptions">The default options to use when creating continuation tasks with this <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</param>
	/// <param name="scheduler">The default scheduler to use to schedule any tasks created with this <see cref="T:System.Threading.Tasks.TaskFactory`1" />. A null value indicates that <see cref="P:System.Threading.Tasks.TaskScheduler.Current" /> should be used.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="creationOptions" /> or <paramref name="continuationOptions" /> specifies an invalid value.</exception>
	public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
	}

	/// <summary>Creates and starts a task.</summary>
	/// <param name="function">A function delegate that returns the future result to be available through the task.</param>
	/// <param name="cancellationToken">The cancellation token that will be assigned to the new task.</param>
	/// <param name="creationOptions">One of the enumeration values that controls the behavior of the created task.</param>
	/// <param name="scheduler">The task scheduler that is used to schedule the created task.</param>
	/// <returns>The started task.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The cancellation token source that created <paramref name="cancellationToken" /> has already been disposed.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is <see langword="null" />.  
	///  -or-  
	///  The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> parameter specifies an invalid value.</exception>
	public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		return null;
	}

	/// <summary>Creates and starts a task.</summary>
	/// <param name="function">A function delegate that returns the future result to be available through the task.</param>
	/// <param name="state">An object that contains data to be used by the <paramref name="function" /> delegate.</param>
	/// <param name="cancellationToken">The cancellation token that will be assigned to the new task.</param>
	/// <param name="creationOptions">One of the enumeration values that controls the behavior of the created task.</param>
	/// <param name="scheduler">The task scheduler that is used to schedule the created task.</param>
	/// <returns>The started task.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The cancellation token source that created <paramref name="cancellationToken" /> has already been disposed.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is <see langword="null" />.  
	///  -or-  
	///  The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> parameter specifies an invalid value.</exception>
	public Task<TResult> StartNew(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		return null;
	}

	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization)
	{
	}

	/// <summary>Creates a task that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
	/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
	/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
	/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
	/// <returns>The created task that represents the asynchronous operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="beginMethod" /> argument is <see langword="null" />.  
	///  -or-  
	///  The <paramref name="endMethod" /> argument is <see langword="null" />.</exception>
	public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state)
	{
		return null;
	}

	internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions)
	{
		return null;
	}

	/// <summary>Creates a task that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
	/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
	/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
	/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
	/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
	/// <typeparam name="TArg1">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
	/// <returns>The created task that represents the asynchronous operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="beginMethod" /> argument is <see langword="null" />.  
	///  -or-  
	///  The <paramref name="endMethod" /> argument is <see langword="null" />.</exception>
	public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state)
	{
		return null;
	}

	internal static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions)
	{
		return null;
	}

	internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
	{
		return null;
	}

	internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) where TInstance : class
	{
		return null;
	}
}
/// <summary>Provides support for creating and scheduling <see cref="T:System.Threading.Tasks.Task" /> objects.</summary>
public class TaskFactory
{
	internal sealed class CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction
	{
		private IList<Task> _tasks;

		public bool InvokeMayRunArbitraryCode => false;

		public CompleteOnInvokePromise(IList<Task> tasks)
		{
		}

		public void Invoke(Task completingTask)
		{
		}
	}

	private readonly CancellationToken m_defaultCancellationToken;

	private readonly TaskScheduler m_defaultScheduler;

	private readonly TaskCreationOptions m_defaultCreationOptions;

	private readonly TaskContinuationOptions m_defaultContinuationOptions;

	/// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory" /> instance with the default configuration.</summary>
	public TaskFactory()
	{
	}

	/// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory" /> instance with the specified configuration.</summary>
	/// <param name="cancellationToken">The default <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to tasks created by this <see cref="T:System.Threading.Tasks.TaskFactory" /> unless another CancellationToken is explicitly specified while calling the factory methods.</param>
	/// <param name="creationOptions">The default <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> to use when creating tasks with this TaskFactory.</param>
	/// <param name="continuationOptions">The default <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> to use when creating continuation tasks with this TaskFactory.</param>
	/// <param name="scheduler">The default <see cref="T:System.Threading.Tasks.TaskScheduler" /> to use to schedule any Tasks created with this TaskFactory. A null value indicates that TaskScheduler.Current should be used.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.  
	///  -or-  
	///  The <paramref name="continuationOptions" /> argument specifies an invalid value.</exception>
	public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
	}

	internal static void CheckCreationOptions(TaskCreationOptions creationOptions)
	{
	}

	/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task" />.</summary>
	/// <param name="action">The action delegate to execute asynchronously.</param>
	/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new <see cref="T:System.Threading.Tasks.Task" /></param>
	/// <param name="creationOptions">A TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" /></param>
	/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created <see cref="T:System.Threading.Tasks.Task" />.</param>
	/// <returns>The started <see cref="T:System.Threading.Tasks.Task" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
	/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="action" /> argument is null.  
	///  -or-  
	///  The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
	public Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		return null;
	}

	/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task" />.</summary>
	/// <param name="action">The action delegate to execute asynchronously.</param>
	/// <param name="state">An object containing data to be used by the <paramref name="action" /> delegate.</param>
	/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new task.</param>
	/// <param name="creationOptions">A TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" /></param>
	/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created <see cref="T:System.Threading.Tasks.Task" />.</param>
	/// <returns>The started <see cref="T:System.Threading.Tasks.Task" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
	/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="action" /> argument is null.  
	///  -or-  
	///  The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
	public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		return null;
	}

	/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
	/// <param name="function">A function delegate that returns the future result to be available through the <see cref="T:System.Threading.Tasks.Task`1" />.</param>
	/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new task.</param>
	/// <param name="creationOptions">A TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
	/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
	/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
	/// <returns>The started <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
	/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="function" /> argument is null.  
	///  -or-  
	///  The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
	public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		return null;
	}

	/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
	/// <param name="function">A function delegate that returns the future result to be available through the <see cref="T:System.Threading.Tasks.Task`1" />.</param>
	/// <param name="state">An object containing data to be used by the <paramref name="function" /> delegate.</param>
	/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new task.</param>
	/// <param name="creationOptions">A TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
	/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
	/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
	/// <returns>The started <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
	/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="function" /> argument is null.  
	///  -or-  
	///  The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
	public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		return null;
	}

	/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
	/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
	/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
	/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
	/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
	/// <typeparam name="TArg1">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
	/// <returns>The created <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.  
	///  -or-  
	///  The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state)
	{
		return null;
	}

	/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
	/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
	/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
	/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
	/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
	/// <param name="creationOptions">The TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" />.</param>
	/// <typeparam name="TArg1">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
	/// <returns>The created <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.  
	///  -or-  
	///  The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
	{
		return null;
	}

	/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
	/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
	/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
	/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
	/// <param name="arg2">The second argument passed to the <paramref name="beginMethod" /> delegate.</param>
	/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
	/// <typeparam name="TArg1">The type of the second argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
	/// <typeparam name="TArg2">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
	/// <returns>The created <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.  
	///  -or-  
	///  The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
	public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
	{
		return null;
	}

	/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
	/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
	/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
	/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
	/// <param name="arg2">The second argument passed to the <paramref name="beginMethod" /> delegate.</param>
	/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
	/// <param name="creationOptions">The TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" />.</param>
	/// <typeparam name="TArg1">The type of the second argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
	/// <typeparam name="TArg2">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
	/// <returns>The created <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
	/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.  
	///  -or-  
	///  The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
	public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
	{
		return null;
	}

	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod)
	{
	}

	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks)
	{
		return null;
	}

	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions)
	{
	}
}
