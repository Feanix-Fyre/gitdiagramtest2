using System.Threading;

namespace System.Net;

internal class LazyAsyncResult : IAsyncResult
{
	private class ThreadContext
	{
		internal int m_NestedIOCount;
	}

	[ThreadStatic]
	private static ThreadContext t_ThreadContext;

	private object m_AsyncObject;

	private object m_AsyncState;

	private AsyncCallback m_AsyncCallback;

	private object m_Result;

	private int m_IntCompleted;

	private bool m_EndCalled;

	private bool m_UserEvent;

	private object m_Event;

	private static ThreadContext CurrentThreadContext => null;

	internal object AsyncObject => null;

	public object AsyncState => null;

	protected AsyncCallback AsyncCallback => null;

	public WaitHandle AsyncWaitHandle => null;

	public bool CompletedSynchronously => false;

	public bool IsCompleted => false;

	internal bool InternalPeekCompleted => false;

	internal bool EndCalled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal LazyAsyncResult(object myObject, object myState, AsyncCallback myCallBack)
	{
	}

	private bool LazilyCreateEvent(out ManualResetEvent waitHandle)
	{
		waitHandle = null;
		return false;
	}

	protected void ProtectedInvokeCallback(object result, IntPtr userToken)
	{
	}

	internal void InvokeCallback(object result)
	{
	}

	internal void InvokeCallback()
	{
	}

	protected virtual void Complete(IntPtr userToken)
	{
	}

	private void WorkerThreadComplete(object state)
	{
	}

	protected virtual void Cleanup()
	{
	}

	internal object InternalWaitForCompletion()
	{
		return null;
	}

	private object WaitForCompletion(bool snap)
	{
		return null;
	}
}
