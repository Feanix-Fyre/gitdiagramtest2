namespace System.Threading;

internal sealed class ThreadPoolWorkQueueThreadLocals
{
	[ThreadStatic]
	public static ThreadPoolWorkQueueThreadLocals threadLocals;

	public readonly ThreadPoolWorkQueue workQueue;

	public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue;

	public readonly Random random;

	public ThreadPoolWorkQueueThreadLocals(ThreadPoolWorkQueue tpq)
	{
	}

	private void CleanUp()
	{
	}

	~ThreadPoolWorkQueueThreadLocals()
	{
	}
}
