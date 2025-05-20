namespace System.Threading.Tasks;

internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
{
	private readonly TaskScheduler m_scheduler;

	internal TaskSchedulerAwaitTaskContinuation(TaskScheduler scheduler, Action action, bool flowExecutionContext)
		: base(null, flowExecutionContext: false)
	{
	}

	internal sealed override void Run(Task ignored, bool canInlineContinuationTask)
	{
	}
}
