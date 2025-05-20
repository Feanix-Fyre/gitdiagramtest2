namespace System.Threading.Tasks;

internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction
{
	private byte _state;

	private readonly bool _lookForOce;

	public bool InvokeMayRunArbitraryCode => false;

	public UnwrapPromise(Task outerTask, bool lookForOce)
	{
	}

	public void Invoke(Task completingTask)
	{
	}

	private void InvokeCore(Task completingTask)
	{
	}

	private void InvokeCoreAsync(Task completingTask)
	{
	}

	private void ProcessCompletedOuterTask(Task task)
	{
	}

	private bool TrySetFromTask(Task task, bool lookForOce)
	{
		return false;
	}

	private void ProcessInnerTask(Task task)
	{
	}
}
