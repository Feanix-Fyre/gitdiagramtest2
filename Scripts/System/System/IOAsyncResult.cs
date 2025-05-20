using System.Runtime.InteropServices;
using System.Threading;

namespace System;

[StructLayout((LayoutKind)0)]
internal abstract class IOAsyncResult : IAsyncResult
{
	private AsyncCallback async_callback;

	private object async_state;

	private ManualResetEvent wait_handle;

	private bool completed_synchronously;

	private bool completed;

	public AsyncCallback AsyncCallback => null;

	public object AsyncState => null;

	public WaitHandle AsyncWaitHandle => null;

	public bool CompletedSynchronously
	{
		get
		{
			return false;
		}
		protected set
		{
		}
	}

	public bool IsCompleted
	{
		get
		{
			return false;
		}
		protected set
		{
		}
	}

	protected IOAsyncResult()
	{
	}

	protected void Init(AsyncCallback async_callback, object async_state)
	{
	}

	protected IOAsyncResult(AsyncCallback async_callback, object async_state)
	{
	}

	internal abstract void CompleteDisposed();
}
