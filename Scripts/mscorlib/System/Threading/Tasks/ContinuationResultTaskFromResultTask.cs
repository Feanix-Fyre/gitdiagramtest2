namespace System.Threading.Tasks;

internal sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult>
{
	private Task<TAntecedentResult> m_antecedent;

	public ContinuationResultTaskFromResultTask(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
	{
	}

	internal override void InnerInvoke()
	{
	}
}
