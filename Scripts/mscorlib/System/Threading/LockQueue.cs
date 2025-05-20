namespace System.Threading;

internal class LockQueue
{
	private ReaderWriterLock rwlock;

	private int lockCount;

	public bool IsEmpty => false;

	public LockQueue(ReaderWriterLock rwlock)
	{
	}

	public bool Wait(int timeout)
	{
		return false;
	}

	public void Pulse()
	{
	}
}
