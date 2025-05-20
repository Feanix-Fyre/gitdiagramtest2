using System.Threading;

namespace System.IO;

internal class FileStreamAsyncResult : IAsyncResult
{
	private object state;

	private bool completed;

	private ManualResetEvent wh;

	private AsyncCallback cb;

	private bool completedSynch;

	public int Count;

	public int OriginalCount;

	public int BytesRead;

	private AsyncCallback realcb;

	public object AsyncState => null;

	public bool CompletedSynchronously => false;

	public WaitHandle AsyncWaitHandle => null;

	public bool IsCompleted => false;

	public FileStreamAsyncResult(AsyncCallback cb, object state)
	{
	}

	private static void CBWrapper(IAsyncResult ares)
	{
	}
}
