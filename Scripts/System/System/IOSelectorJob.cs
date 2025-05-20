using System.Runtime.InteropServices;
using System.Threading;

namespace System;

[StructLayout((LayoutKind)0)]
internal class IOSelectorJob : IThreadPoolWorkItem
{
	private IOOperation operation;

	private IOAsyncCallback callback;

	private IOAsyncResult state;

	public IOSelectorJob(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state)
	{
	}

	void IThreadPoolWorkItem.ExecuteWorkItem()
	{
	}

	void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
	{
	}

	public void MarkDisposed()
	{
	}
}
