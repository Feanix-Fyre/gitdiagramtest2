namespace System.Threading.Tasks;

internal sealed class ContinuationTaskFromResultTask<TAntecedentResult> : Task
{
	private Task<TAntecedentResult> m_antecedent;

	public ContinuationTaskFromResultTask(Task<TAntecedentResult> antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
		: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
	{
	}

	internal override void InnerInvoke()
	{
	}
}
