using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks;

/// <summary>Represents an object that handles the low-level work of queuing tasks onto threads.</summary>
[DebuggerDisplay("Id={Id}")]
[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskSchedulerDebugView))]
public abstract class TaskScheduler
{
	internal sealed class SystemThreadingTasks_TaskSchedulerDebugView
	{
	}

	private static ConditionalWeakTable<TaskScheduler, object> s_activeTaskSchedulers;

	private static readonly TaskScheduler s_defaultTaskScheduler;

	internal static int s_taskSchedulerIdCounter;

	private int m_taskSchedulerId;

	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException;

	private static readonly Lock _unobservedTaskExceptionLockObject;

	/// <summary>Indicates the maximum concurrency level this <see cref="T:System.Threading.Tasks.TaskScheduler" /> is able to support.</summary>
	/// <returns>Returns an integer that represents the maximum concurrency level. The default scheduler returns <see cref="F:System.Int32.MaxValue" />.</returns>
	public virtual int MaximumConcurrencyLevel => 0;

	internal virtual bool RequiresAtomicStartTransition => false;

	/// <summary>Gets the default <see cref="T:System.Threading.Tasks.TaskScheduler" /> instance that is provided by the .NET Framework.</summary>
	/// <returns>Returns the default <see cref="T:System.Threading.Tasks.TaskScheduler" /> instance.</returns>
	public static TaskScheduler Default => null;

	/// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskScheduler" /> associated with the currently executing task.</summary>
	/// <returns>Returns the <see cref="T:System.Threading.Tasks.TaskScheduler" /> associated with the currently executing task.</returns>
	public static TaskScheduler Current => null;

	internal static TaskScheduler InternalCurrent => null;

	/// <summary>Gets the unique ID for this <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
	/// <returns>Returns the unique ID for this <see cref="T:System.Threading.Tasks.TaskScheduler" />.</returns>
	public int Id => 0;

	/// <summary>Queues a <see cref="T:System.Threading.Tasks.Task" /> to the scheduler.</summary>
	/// <param name="task">The <see cref="T:System.Threading.Tasks.Task" /> to be queued.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="task" /> argument is null.</exception>
	protected internal abstract void QueueTask(Task task);

	/// <summary>Determines whether the provided <see cref="T:System.Threading.Tasks.Task" /> can be executed synchronously in this call, and if it can, executes it.</summary>
	/// <param name="task">The <see cref="T:System.Threading.Tasks.Task" /> to be executed.</param>
	/// <param name="taskWasPreviouslyQueued">A Boolean denoting whether or not task has previously been queued. If this parameter is True, then the task may have been previously queued (scheduled); if False, then the task is known not to have been queued, and this call is being made in order to execute the task inline without queuing it.</param>
	/// <returns>A Boolean value indicating whether the task was executed inline.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="task" /> argument is null.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <paramref name="task" /> was already executed.</exception>
	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued)
	{
		return false;
	}

	/// <summary>Attempts to dequeue a <see cref="T:System.Threading.Tasks.Task" /> that was previously queued to this scheduler.</summary>
	/// <param name="task">The <see cref="T:System.Threading.Tasks.Task" /> to be dequeued.</param>
	/// <returns>A Boolean denoting whether the <paramref name="task" /> argument was successfully dequeued.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="task" /> argument is null.</exception>
	protected internal virtual bool TryDequeue(Task task)
	{
		return false;
	}

	internal virtual void NotifyWorkItemProgress()
	{
	}

	/// <summary>Initializes the <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
	protected TaskScheduler()
	{
	}

	/// <summary>Creates a <see cref="T:System.Threading.Tasks.TaskScheduler" /> associated with the current <see cref="T:System.Threading.SynchronizationContext" />.</summary>
	/// <returns>A <see cref="T:System.Threading.Tasks.TaskScheduler" /> associated with the current <see cref="T:System.Threading.SynchronizationContext" />, as determined by <see cref="P:System.Threading.SynchronizationContext.Current" />.</returns>
	/// <exception cref="T:System.InvalidOperationException">The current SynchronizationContext may not be used as a TaskScheduler.</exception>
	public static TaskScheduler FromCurrentSynchronizationContext()
	{
		return null;
	}

	/// <summary>Attempts to execute the provided <see cref="T:System.Threading.Tasks.Task" /> on this scheduler.</summary>
	/// <param name="task">A <see cref="T:System.Threading.Tasks.Task" /> object to be executed.</param>
	/// <returns>A Boolean that is true if <paramref name="task" /> was successfully executed, false if it was not. A common reason for execution failure is that the task had previously been executed or is in the process of being executed by another thread.</returns>
	/// <exception cref="T:System.InvalidOperationException">The <paramref name="task" /> is not associated with this scheduler.</exception>
	protected bool TryExecuteTask(Task task)
	{
		return false;
	}

	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea)
	{
	}
}
