using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace System.Threading.Tasks;

/// <summary>Represents an asynchronous operation that can return a value.</summary>
/// <typeparam name="TResult">The type of the result produced by this <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView<>))]
[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
public class Task<TResult> : Task
{
	internal TResult m_result;

	private static TaskFactory<TResult> s_defaultFactory;

	/// <summary>Gets the result value of this <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
	/// <returns>The result value of this <see cref="T:System.Threading.Tasks.Task`1" />, which is of the same type as the task's type parameter.</returns>
	/// <exception cref="T:System.AggregateException">The task was canceled. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains a <see cref="T:System.Threading.Tasks.TaskCanceledException" /> object.  
	///  -or-  
	///  An exception was thrown during the execution of the task. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains information about the exception or exceptions.</exception>
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public TResult Result => default(TResult);

	internal TResult ResultOnSuccess => default(TResult);

	/// <summary>Provides access to factory methods for creating and configuring <see cref="T:System.Threading.Tasks.Task`1" /> instances.</summary>
	/// <returns>A factory object that can create a variety of <see cref="T:System.Threading.Tasks.Task`1" /> objects.</returns>
	public new static TaskFactory<TResult> Factory => null;

	internal Task()
		: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
	{
	}

	internal Task(object state, TaskCreationOptions options)
		: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
	{
	}

	internal Task(TResult result)
		: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
	{
	}

	internal Task(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct)
		: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task`1" /> with the specified function.</summary>
	/// <param name="function">The delegate that represents the code to execute in the task. When the function has completed, the task's <see cref="P:System.Threading.Tasks.Task`1.Result" /> property will be set to return the result value of the function.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is null.</exception>
	public Task(Func<TResult> function)
		: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task`1" /> with the specified function.</summary>
	/// <param name="function">The delegate that represents the code to execute in the task. When the function has completed, the task's <see cref="P:System.Threading.Tasks.Task`1.Result" /> property will be set to return the result value of the function.</param>
	/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to be assigned to this task.</param>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is null.</exception>
	public Task(Func<TResult> function, CancellationToken cancellationToken)
		: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task`1" /> with the specified action, state, and options.</summary>
	/// <param name="function">The delegate that represents the code to execute in the task. When the function has completed, the task's <see cref="P:System.Threading.Tasks.Task`1.Result" /> property will be set to return the result value of the function.</param>
	/// <param name="state">An object representing data to be used by the function.</param>
	/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to be assigned to the new task.</param>
	/// <param name="creationOptions">The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to customize the task's behavior.</param>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is null.</exception>
	public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
		: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
	{
	}

	internal Task(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
	{
	}

	internal Task(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
	{
	}

	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
	{
		return null;
	}

	internal static Task<TResult> StartNew(Task parent, Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
	{
		return null;
	}

	internal bool TrySetResult(TResult result)
	{
		return false;
	}

	internal void DangerousSetResult(TResult result)
	{
	}

	internal TResult GetResultCore(bool waitCompletionNotification)
	{
		return default(TResult);
	}

	internal override void InnerInvoke()
	{
	}

	/// <summary>Gets an awaiter used to await this <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
	/// <returns>An awaiter instance.</returns>
	public new TaskAwaiter<TResult> GetAwaiter()
	{
		return default(TaskAwaiter<TResult>);
	}

	/// <summary>Configures an awaiter used to await this <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
	/// <param name="continueOnCapturedContext">true to attempt to marshal the continuation back to the original context captured; otherwise, false.</param>
	/// <returns>An object used to await this task.</returns>
	public new ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
	{
		return default(ConfiguredTaskAwaitable<TResult>);
	}

	/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
	/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
	/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
	/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.  
	///  -or-  
	///  The <paramref name="scheduler" /> argument is null.</exception>
	public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler)
	{
		return null;
	}

	internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
	{
		return null;
	}

	/// <summary>Creates a continuation that executes when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
	/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
	/// <param name="state">An object representing data to be used by the continuation action.</param>
	/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
	/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as  well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
	/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its  execution.</param>
	/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is null.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
	public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		return null;
	}

	internal Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
	{
		return null;
	}

	/// <summary>Creates a continuation that executes according the condition specified in <paramref name="continuationOptions" />.</summary>
	/// <param name="continuationFunction">A function to run according the condition specified in <paramref name="continuationOptions" />.  
	///  When run, the delegate will be passed the completed task as an argument.</param>
	/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
	/// <typeparam name="TNewResult">The type of the result produced by the continuation.</typeparam>
	/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
	public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions)
	{
		return null;
	}

	internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
	{
		return null;
	}
}
/// <summary>Represents an asynchronous operation.</summary>
[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable
{
	internal class ContingentProperties
	{
		internal ExecutionContext m_capturedContext;

		internal ManualResetEventSlim m_completionEvent;

		internal TaskExceptionHolder m_exceptionsHolder;

		internal CancellationToken m_cancellationToken;

		internal object m_cancellationRegistration;

		internal int m_internalCancellationRequested;

		internal int m_completionCountdown;

		internal LowLevelListWithIList<Task> m_exceptionalChildren;

		internal void SetCompleted()
		{
		}

		internal void UnregisterCancellationCallback()
		{
		}
	}

	private sealed class SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction
	{
		public bool InvokeMayRunArbitraryCode => false;

		internal SetOnInvokeMres()
			: base(initialState: false)
		{
		}

		public void Invoke(Task completingTask)
		{
		}
	}

	private sealed class DelayPromise : Task<VoidTaskResult>
	{
		internal readonly CancellationToken Token;

		internal CancellationTokenRegistration Registration;

		internal Timer Timer;

		internal DelayPromise(CancellationToken token)
		{
		}

		internal void Complete()
		{
		}
	}

	internal static int s_taskIdCounter;

	private int m_taskId;

	internal Delegate m_action;

	internal object m_stateObject;

	internal TaskScheduler m_taskScheduler;

	internal readonly Task m_parent;

	internal int m_stateFlags;

	private const int OptionsMask = 65535;

	internal const int TASK_STATE_STARTED = 65536;

	internal const int TASK_STATE_DELEGATE_INVOKED = 131072;

	internal const int TASK_STATE_DISPOSED = 262144;

	internal const int TASK_STATE_EXCEPTIONOBSERVEDBYPARENT = 524288;

	internal const int TASK_STATE_CANCELLATIONACKNOWLEDGED = 1048576;

	internal const int TASK_STATE_FAULTED = 2097152;

	internal const int TASK_STATE_CANCELED = 4194304;

	internal const int TASK_STATE_WAITING_ON_CHILDREN = 8388608;

	internal const int TASK_STATE_RAN_TO_COMPLETION = 16777216;

	internal const int TASK_STATE_WAITINGFORACTIVATION = 33554432;

	internal const int TASK_STATE_COMPLETION_RESERVED = 67108864;

	internal const int TASK_STATE_THREAD_WAS_ABORTED = 134217728;

	internal const int TASK_STATE_WAIT_COMPLETION_NOTIFICATION = 268435456;

	private const int TASK_STATE_COMPLETED_MASK = 23068672;

	private const int CANCELLATION_REQUESTED = 1;

	private object m_continuationObject;

	private static readonly object s_taskCompletionSentinel;

	internal static bool s_asyncDebuggingEnabled;

	internal ContingentProperties m_contingentProperties;

	private static readonly Action<object> s_taskCancelCallback;

	[ThreadStatic]
	internal static Task t_currentTask;

	[ThreadStatic]
	private static StackGuard t_stackGuard;

	private static readonly Func<ContingentProperties> s_createContingentProperties;

	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate;

	private static ContextCallback s_ecCallback;

	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate;

	private static readonly Dictionary<int, Task> s_currentActiveTasks;

	private static readonly object s_activeTasksLock;

	internal TaskCreationOptions Options => default(TaskCreationOptions);

	internal bool IsWaitNotificationEnabledOrNotRanToCompletion
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return false;
		}
	}

	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion => false;

	internal bool IsWaitNotificationEnabled => false;

	/// <summary>Gets an ID for this <see cref="T:System.Threading.Tasks.Task" /> instance.</summary>
	/// <returns>The identifier that is assigned by the system to this <see cref="T:System.Threading.Tasks.Task" /> instance.</returns>
	public int Id => 0;

	/// <summary>Returns the ID of the currently executing <see cref="T:System.Threading.Tasks.Task" />.</summary>
	/// <returns>An integer that was assigned by the system to the currently-executing task.</returns>
	public static int? CurrentId => null;

	internal static Task InternalCurrent => null;

	internal static StackGuard CurrentStackGuard => null;

	/// <summary>Gets the <see cref="T:System.AggregateException" /> that caused the <see cref="T:System.Threading.Tasks.Task" /> to end prematurely. If the <see cref="T:System.Threading.Tasks.Task" /> completed successfully or has not yet thrown any exceptions, this will return <see langword="null" />.</summary>
	/// <returns>The <see cref="T:System.AggregateException" /> that caused the <see cref="T:System.Threading.Tasks.Task" /> to end prematurely.</returns>
	public AggregateException Exception => null;

	/// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskStatus" /> of this task.</summary>
	/// <returns>The current <see cref="T:System.Threading.Tasks.TaskStatus" /> of this task instance.</returns>
	public TaskStatus Status => default(TaskStatus);

	/// <summary>Gets whether this <see cref="T:System.Threading.Tasks.Task" /> instance has completed execution due to being canceled.</summary>
	/// <returns>
	///   <see langword="true" /> if the task has completed due to being canceled; otherwise <see langword="false" />.</returns>
	public bool IsCanceled => false;

	internal bool IsCancellationRequested => false;

	internal CancellationToken CancellationToken => default(CancellationToken);

	internal bool IsCancellationAcknowledged => false;

	/// <summary>Gets whether this <see cref="T:System.Threading.Tasks.Task" /> has completed.</summary>
	/// <returns>
	///   <see langword="true" /> if the task has completed; otherwise <see langword="false" />.</returns>
	public bool IsCompleted => false;

	public bool IsCompletedSuccessfully => false;

	/// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to create this task.</summary>
	/// <returns>The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to create this task.</returns>
	public TaskCreationOptions CreationOptions => default(TaskCreationOptions);

	/// <summary>Gets a <see cref="T:System.Threading.WaitHandle" /> that can be used to wait for the task to complete.</summary>
	/// <returns>A <see cref="T:System.Threading.WaitHandle" /> that can be used to wait for the task to complete.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
	WaitHandle IAsyncResult.AsyncWaitHandle => null;

	/// <summary>Gets the state object supplied when the <see cref="T:System.Threading.Tasks.Task" /> was created, or null if none was supplied.</summary>
	/// <returns>An <see cref="T:System.Object" /> that represents the state data that was passed in to the task when it was created.</returns>
	public object AsyncState => null;

	/// <summary>Gets an indication of whether the operation completed synchronously.</summary>
	/// <returns>
	///   <see langword="true" /> if the operation completed synchronously; otherwise, <see langword="false" />.</returns>
	bool IAsyncResult.CompletedSynchronously => false;

	internal TaskScheduler ExecutingTaskScheduler => null;

	/// <summary>Provides access to factory methods for creating and configuring <see cref="T:System.Threading.Tasks.Task" /> and <see cref="T:System.Threading.Tasks.Task`1" /> instances.</summary>
	/// <returns>A factory object that can create a variety of <see cref="T:System.Threading.Tasks.Task" /> and <see cref="T:System.Threading.Tasks.Task`1" /> objects.</returns>
	public static TaskFactory Factory { get; }

	/// <summary>Gets a task that has already completed successfully.</summary>
	/// <returns>The successfully completed task.</returns>
	public static Task CompletedTask { get; }

	internal ManualResetEventSlim CompletedEvent => null;

	internal bool ExceptionRecorded => false;

	/// <summary>Gets whether the <see cref="T:System.Threading.Tasks.Task" /> completed due to an unhandled exception.</summary>
	/// <returns>
	///   <see langword="true" /> if the task has thrown an unhandled exception; otherwise <see langword="false" />.</returns>
	public bool IsFaulted => false;

	internal ExecutionContext CapturedContext
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool IsExceptionObservedByParent => false;

	internal bool IsDelegateInvoked => false;

	internal Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct)
	{
	}

	internal Task()
	{
	}

	internal Task(object state, TaskCreationOptions creationOptions, bool promiseStyle)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task" /> with the specified action.</summary>
	/// <param name="action">The delegate that represents the code to execute in the task.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> argument is <see langword="null" />.</exception>
	public Task(Action action)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task" /> with the specified action and <see cref="T:System.Threading.CancellationToken" />.</summary>
	/// <param name="action">The delegate that represents the code to execute in the task.</param>
	/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that the new  task will observe.</param>
	/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
	public Task(Action action, CancellationToken cancellationToken)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task" /> with the specified action and state.</summary>
	/// <param name="action">The delegate that represents the code to execute in the task.</param>
	/// <param name="state">An object representing data to be used by the action.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
	public Task(Action<object> action, object state)
	{
	}

	/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task" /> with the specified action, state, and options.</summary>
	/// <param name="action">The delegate that represents the code to execute in the task.</param>
	/// <param name="state">An object representing data to be used by the action.</param>
	/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that the new task will observe.</param>
	/// <param name="creationOptions">The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to customize the task's behavior.</param>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
	public Task(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
	{
	}

	internal Task(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
	{
	}

	internal void TaskConstructorCore(Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
	{
	}

	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation)
	{
	}

	private static void TaskCancelCallback(object o)
	{
	}

	internal bool TrySetCanceled(CancellationToken tokenToRecord)
	{
		return false;
	}

	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException)
	{
		return false;
	}

	internal bool TrySetException(object exceptionObject)
	{
		return false;
	}

	internal static TaskCreationOptions OptionsMethod(int flags)
	{
		return default(TaskCreationOptions);
	}

	internal bool AtomicStateUpdate(int newBits, int illegalBits)
	{
		return false;
	}

	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags)
	{
		return false;
	}

	internal void SetNotificationForWaitCompletion(bool enabled)
	{
	}

	internal bool NotifyDebuggerOfWaitCompletionIfNecessary()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void NotifyDebuggerOfWaitCompletion()
	{
	}

	internal bool MarkStarted()
	{
		return false;
	}

	internal void AddNewChild()
	{
	}

	internal void DisregardChild()
	{
	}

	/// <summary>Starts the <see cref="T:System.Threading.Tasks.Task" />, scheduling it for execution to the current <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> instance has been disposed.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Threading.Tasks.Task" /> is not in a valid state to be started. It may have already been started, executed, or canceled, or it may have been created in a manner that doesn't support direct scheduling.</exception>
	public void Start()
	{
	}

	/// <summary>Starts the <see cref="T:System.Threading.Tasks.Task" />, scheduling it for execution to the specified <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
	/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> with which to associate and execute this task.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Threading.Tasks.Task" /> is not in a valid state to be started. It may have already been started, executed, or canceled, or it may have been created in a manner that doesn't support direct scheduling.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> instance has been disposed.</exception>
	/// <exception cref="T:System.Threading.Tasks.TaskSchedulerException">The scheduler was unable to queue this task.</exception>
	public void Start(TaskScheduler scheduler)
	{
	}

	/// <summary>Runs the <see cref="T:System.Threading.Tasks.Task" /> synchronously on the <see cref="T:System.Threading.Tasks.TaskScheduler" /> provided.</summary>
	/// <param name="scheduler">The scheduler on which to attempt to run this task inline.</param>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> instance has been disposed.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Threading.Tasks.Task" /> is not in a valid state to be started. It may have already been started, executed, or canceled, or it may have been created in a manner that doesn't support direct scheduling.</exception>
	public void RunSynchronously(TaskScheduler scheduler)
	{
	}

	internal void InternalRunSynchronously(TaskScheduler scheduler, bool waitForCompletion)
	{
	}

	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions)
	{
		return null;
	}

	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions)
	{
		return null;
	}

	internal ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection)
	{
		return null;
	}

	private ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection)
	{
		return null;
	}

	private static bool IsCompletedMethod(int flags)
	{
		return false;
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.Tasks.Task" /> class.</summary>
	/// <exception cref="T:System.InvalidOperationException">The task is not in one of the final states: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" />, or <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
	public void Dispose()
	{
	}

	/// <summary>Disposes the <see cref="T:System.Threading.Tasks.Task" />, releasing all of its unmanaged resources.</summary>
	/// <param name="disposing">A Boolean value that indicates whether this method is being called due to a call to <see cref="M:System.Threading.Tasks.Task.Dispose" />.</param>
	/// <exception cref="T:System.InvalidOperationException">The task is not in one of the final states: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" />, or <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
	protected virtual void Dispose(bool disposing)
	{
	}

	internal void ScheduleAndStart(bool needsProtection)
	{
	}

	internal void AddException(object exceptionObject)
	{
	}

	internal void AddException(object exceptionObject, bool representsCancellation)
	{
	}

	private AggregateException GetExceptions(bool includeTaskCanceledExceptions)
	{
		return null;
	}

	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
	{
		return null;
	}

	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
	{
		return null;
	}

	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions)
	{
	}

	internal void UpdateExceptionObservedStatus()
	{
	}

	internal void Finish(bool bUserDelegateExecuted)
	{
	}

	internal void FinishStageTwo()
	{
	}

	internal void FinishStageThree()
	{
	}

	internal void ProcessChildCompletion(Task childTask)
	{
	}

	internal void AddExceptionsFromChildren()
	{
	}

	private void Execute()
	{
	}

	void IThreadPoolWorkItem.ExecuteWorkItem()
	{
	}

	internal bool ExecuteEntry(bool bPreventDoubleExecution)
	{
		return false;
	}

	private static void ExecutionContextCallback(object obj)
	{
	}

	internal virtual void InnerInvoke()
	{
	}

	private void HandleException(Exception unhandledException)
	{
	}

	/// <summary>Gets an awaiter used to await this <see cref="T:System.Threading.Tasks.Task" />.</summary>
	/// <returns>An awaiter instance.</returns>
	public TaskAwaiter GetAwaiter()
	{
		return default(TaskAwaiter);
	}

	/// <summary>Configures an awaiter used to await this <see cref="T:System.Threading.Tasks.Task" />.</summary>
	/// <param name="continueOnCapturedContext">
	///   <see langword="true" /> to attempt to marshal the continuation back to the original context captured; otherwise, <see langword="false" />.</param>
	/// <returns>An object used to await this task.</returns>
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
	{
		return default(ConfiguredTaskAwaitable);
	}

	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext)
	{
	}

	/// <summary>Waits for the <see cref="T:System.Threading.Tasks.Task" /> to complete execution.</summary>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
	/// <exception cref="T:System.AggregateException">The task was canceled. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains a <see cref="T:System.Threading.Tasks.TaskCanceledException" /> object.  
	///  -or-  
	///  An exception was thrown during the execution of the task. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains information about the exception or exceptions.</exception>
	public void Wait()
	{
	}

	/// <summary>Waits for the <see cref="T:System.Threading.Tasks.Task" /> to complete execution. The wait terminates if a timeout interval elapses or a cancellation token is canceled before the task completes.</summary>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Threading.Tasks.Task" /> completed execution within the allotted time; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
	/// <exception cref="T:System.AggregateException">The task was canceled. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains a <see cref="T:System.Threading.Tasks.TaskCanceledException" /> object.  
	///  -or-  
	///  An exception was thrown during the execution of the task. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains information about the exception or exceptions.</exception>
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
	{
		return false;
	}

	private bool WrappedTryRunInline()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken)
	{
		return false;
	}

	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken)
	{
		return false;
	}

	private bool SpinWait(int millisecondsTimeout)
	{
		return false;
	}

	internal bool InternalCancel(bool bCancelNonExecutingOnly)
	{
		return false;
	}

	internal void RecordInternalCancellationRequest()
	{
	}

	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord)
	{
	}

	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException)
	{
	}

	internal void CancellationCleanupLogic()
	{
	}

	private void SetCancellationAcknowledged()
	{
	}

	internal void FinishContinuations()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void LogFinishCompletionNotification()
	{
	}

	/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task" /> completes.</summary>
	/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
	/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is <see langword="null" />.</exception>
	public Task ContinueWith(Action<Task> continuationAction)
	{
		return null;
	}

	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
	{
		return null;
	}

	/// <summary>Creates a continuation that receives caller-supplied state information and a cancellation token and that executes when the target <see cref="T:System.Threading.Tasks.Task" /> completes. The continuation executes based on a set of specified conditions and uses a specified scheduler.</summary>
	/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
	/// <param name="state">An object representing data to be used by the continuation action.</param>
	/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
	/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
	/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its  execution.</param>
	/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		return null;
	}

	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
	{
		return null;
	}

	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions)
	{
		creationOptions = default(TaskCreationOptions);
		internalOptions = default(InternalTaskOptions);
	}

	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options)
	{
	}

	internal void AddCompletionAction(ITaskCompletionAction action)
	{
	}

	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers)
	{
	}

	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers)
	{
		return false;
	}

	private bool AddTaskContinuation(object tc, bool addBeforeOthers)
	{
		return false;
	}

	internal void RemoveContinuation(object continuationObject)
	{
	}

	/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that's completed successfully with the specified result.</summary>
	/// <param name="result">The result to store into the completed task.</param>
	/// <typeparam name="TResult">The type of the result returned by the task.</typeparam>
	/// <returns>The successfully completed task.</returns>
	public static Task<TResult> FromResult<TResult>(TResult result)
	{
		return null;
	}

	/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that has completed with a specified exception.</summary>
	/// <param name="exception">The exception with which to complete the task.</param>
	/// <returns>The faulted task.</returns>
	public static Task FromException(Exception exception)
	{
		return null;
	}

	/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that's completed with a specified exception.</summary>
	/// <param name="exception">The exception with which to complete the task.</param>
	/// <typeparam name="TResult">The type of the result returned by the task.</typeparam>
	/// <returns>The faulted task.</returns>
	public static Task<TResult> FromException<TResult>(Exception exception)
	{
		return null;
	}

	internal static Task FromCancellation(CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that's completed due to cancellation with a specified cancellation token.</summary>
	/// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
	/// <returns>The canceled task.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Cancellation has not been requested for <paramref name="cancellationToken" />; its <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> property is <see langword="false" />.</exception>
	public static Task FromCanceled(CancellationToken cancellationToken)
	{
		return null;
	}

	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that's completed due to cancellation with a specified cancellation token.</summary>
	/// <param name="cancellationToken">The cancellation token with which to complete the task.</param>
	/// <typeparam name="TResult">The type of the result returned by the task.</typeparam>
	/// <returns>The canceled task.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Cancellation has not been requested for <paramref name="cancellationToken" />; its <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> property is <see langword="false" />.</exception>
	public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken)
	{
		return null;
	}

	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception)
	{
		return null;
	}

	/// <summary>Queues the specified work to run on the thread pool and returns a <see cref="T:System.Threading.Tasks.Task" /> object that represents that work.</summary>
	/// <param name="action">The work to execute asynchronously</param>
	/// <returns>A task that represents the work queued to execute in the ThreadPool.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> parameter was <see langword="null" />.</exception>
	public static Task Run(Action action)
	{
		return null;
	}

	/// <summary>Queues the specified work to run on the thread pool and returns a <see cref="T:System.Threading.Tasks.Task`1" /> object that represents that work.</summary>
	/// <param name="function">The work to execute asynchronously.</param>
	/// <typeparam name="TResult">The return type of the task.</typeparam>
	/// <returns>A task object that represents the work queued to execute in the thread pool.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter is <see langword="null" />.</exception>
	public static Task<TResult> Run<TResult>(Func<TResult> function)
	{
		return null;
	}

	/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the  task returned by <paramref name="function" />.</summary>
	/// <param name="function">The work to execute asynchronously</param>
	/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was <see langword="null" />.</exception>
	public static Task Run(Func<Task> function)
	{
		return null;
	}

	/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the task returned by <paramref name="function" />.</summary>
	/// <param name="function">The work to execute asynchronously.</param>
	/// <param name="cancellationToken">A cancellation token that should be used to cancel the work.</param>
	/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was <see langword="null" />.</exception>
	/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
	public static Task Run(Func<Task> function, CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the <see langword="Task(TResult)" /> returned by <paramref name="function" />.</summary>
	/// <param name="function">The work to execute asynchronously</param>
	/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
	/// <returns>A <see langword="Task(TResult)" /> that represents a proxy for the <see langword="Task(TResult)" /> returned by <paramref name="function" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was <see langword="null" />.</exception>
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function)
	{
		return null;
	}

	/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the <see langword="Task(TResult)" /> returned by <paramref name="function" />.</summary>
	/// <param name="function">The work to execute asynchronously</param>
	/// <param name="cancellationToken">A cancellation token that should be used to cancel the work</param>
	/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
	/// <returns>A <see langword="Task(TResult)" /> that represents a proxy for the <see langword="Task(TResult)" /> returned by <paramref name="function" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was <see langword="null" />.</exception>
	/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Creates a cancellable task that completes after a specified time interval.</summary>
	/// <param name="delay">The time span to wait before completing the returned task, or <see langword="TimeSpan.FromMilliseconds(-1)" /> to wait indefinitely.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the time delay.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="delay" /> represents a negative time interval other than <see langword="TimeSpan.FromMillseconds(-1)" />.  
	/// -or-  
	/// The <paramref name="delay" /> argument's <see cref="P:System.TimeSpan.TotalMilliseconds" /> property is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The provided <paramref name="cancellationToken" /> has already been disposed.</exception>
	public static Task Delay(TimeSpan delay, CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Creates a task that completes after a specified number of milliseconds.</summary>
	/// <param name="millisecondsDelay">The number of milliseconds to wait before completing the returned task, or -1 to wait indefinitely.</param>
	/// <returns>A task that represents the time delay.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="millisecondsDelay" /> argument is less than -1.</exception>
	public static Task Delay(int millisecondsDelay)
	{
		return null;
	}

	/// <summary>Creates a cancellable task that completes after a specified number of milliseconds.</summary>
	/// <param name="millisecondsDelay">The number of milliseconds to wait before completing the returned task, or -1 to wait indefinitely.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the time delay.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="millisecondsDelay" /> argument is less than -1.</exception>
	/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled.</exception>
	/// <exception cref="T:System.ObjectDisposedException">The provided <paramref name="cancellationToken" /> has already been disposed.</exception>
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
	{
		return null;
	}

	/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
	/// <param name="tasks">The tasks to wait on for completion.</param>
	/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
	public static Task<Task> WhenAny(params Task[] tasks)
	{
		return null;
	}

	/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
	/// <param name="tasks">The tasks to wait on for completion.</param>
	/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
	public static Task<Task> WhenAny(IEnumerable<Task> tasks)
	{
		return null;
	}

	[FriendAccessAllowed]
	internal static bool AddToActiveTasks(Task task)
	{
		return false;
	}

	[FriendAccessAllowed]
	internal static void RemoveFromActiveTasks(int taskId)
	{
	}

	public void MarkAborted(ThreadAbortException e)
	{
	}

	private void ExecuteWithThreadLocal(ref Task currentTaskSlot)
	{
	}
}
