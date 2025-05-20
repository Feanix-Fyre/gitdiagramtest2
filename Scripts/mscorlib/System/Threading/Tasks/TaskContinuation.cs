namespace System.Threading.Tasks;

internal abstract class TaskContinuation
{
	internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask);

	protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection)
	{
	}
}
