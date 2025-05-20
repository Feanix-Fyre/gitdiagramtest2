namespace System.Threading.Tasks;

internal sealed class ThreadPoolTaskScheduler : TaskScheduler
{
	private static readonly ParameterizedThreadStart s_longRunningThreadWork;

	internal override bool RequiresAtomicStartTransition => false;

	internal ThreadPoolTaskScheduler()
	{
	}

	protected internal override void QueueTask(Task task)
	{
	}

	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
	{
		return false;
	}

	protected internal override bool TryDequeue(Task task)
	{
		return false;
	}

	internal override void NotifyWorkItemProgress()
	{
	}
}
