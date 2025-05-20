namespace System.Threading.Tasks;

internal sealed class ContinuationTaskFromTask : Task
{
	private Task m_antecedent;

	public ContinuationTaskFromTask(Task antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
		: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
	{
	}

	internal override void InnerInvoke()
	{
	}
}
