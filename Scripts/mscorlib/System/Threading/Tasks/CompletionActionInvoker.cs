namespace System.Threading.Tasks;

internal sealed class CompletionActionInvoker : IThreadPoolWorkItem
{
	private readonly ITaskCompletionAction m_action;

	private readonly Task m_completingTask;

	internal CompletionActionInvoker(ITaskCompletionAction action, Task completingTask)
	{
	}

	void IThreadPoolWorkItem.ExecuteWorkItem()
	{
	}

	public void MarkAborted(ThreadAbortException e)
	{
	}
}
