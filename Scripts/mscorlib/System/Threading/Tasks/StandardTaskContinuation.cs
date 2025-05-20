namespace System.Threading.Tasks;

internal class StandardTaskContinuation : TaskContinuation
{
	internal readonly Task m_task;

	internal readonly TaskContinuationOptions m_options;

	private readonly TaskScheduler m_taskScheduler;

	internal StandardTaskContinuation(Task task, TaskContinuationOptions options, TaskScheduler scheduler)
	{
	}

	internal override void Run(Task completedTask, bool bCanInlineContinuationTask)
	{
	}
}
