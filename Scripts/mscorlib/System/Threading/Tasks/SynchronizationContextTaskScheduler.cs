namespace System.Threading.Tasks;

internal sealed class SynchronizationContextTaskScheduler : TaskScheduler
{
	private SynchronizationContext m_synchronizationContext;

	private static readonly SendOrPostCallback s_postCallback;

	public override int MaximumConcurrencyLevel => 0;

	internal SynchronizationContextTaskScheduler()
	{
	}

	protected internal override void QueueTask(Task task)
	{
	}

	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
	{
		return false;
	}
}
