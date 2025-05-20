namespace System.Threading;

internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem
{
	private WaitCallback callback;

	private ExecutionContext context;

	private object state;

	internal static ContextCallback ccb;

	internal QueueUserWorkItemCallback(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark)
	{
	}

	void IThreadPoolWorkItem.ExecuteWorkItem()
	{
	}

	void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
	{
	}

	private static void WaitCallback_Context(object state)
	{
	}
}
