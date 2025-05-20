using System.Threading;

namespace System.Windows.Forms;

internal class AsyncMethodResult : IAsyncResult
{
	private ManualResetEvent handle;

	private object state;

	private bool completed;

	private object return_value;

	private Exception exception;

	public virtual WaitHandle AsyncWaitHandle => null;

	public object AsyncState => null;

	public bool CompletedSynchronously => false;

	public bool IsCompleted => false;

	public object EndInvoke()
	{
		return null;
	}

	public void Complete(object result)
	{
	}

	public void CompleteWithException(Exception ex)
	{
	}
}
