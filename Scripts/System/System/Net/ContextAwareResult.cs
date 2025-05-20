using System.Threading;

namespace System.Net;

internal class ContextAwareResult : LazyAsyncResult
{
	[Flags]
	private enum StateFlags : byte
	{
		None = 0,
		CaptureIdentity = 1,
		CaptureContext = 2,
		ThreadSafeContextCopy = 4,
		PostBlockStarted = 8,
		PostBlockFinished = 0x10
	}

	private ExecutionContext _context;

	private object _lock;

	private StateFlags _flags;

	private void SafeCaptureIdentity()
	{
	}

	private void CleanupInternal()
	{
	}

	internal ContextAwareResult(object myObject, object myState, AsyncCallback myCallBack)
		: base(null, null, null)
	{
	}

	internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack)
		: base(null, null, null)
	{
	}

	internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack)
		: base(null, null, null)
	{
	}

	internal object StartPostingAsyncOp()
	{
		return null;
	}

	internal object StartPostingAsyncOp(bool lockCapture)
	{
		return null;
	}

	internal bool FinishPostingAsyncOp()
	{
		return false;
	}

	protected override void Cleanup()
	{
	}

	private bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext)
	{
		return false;
	}

	protected override void Complete(IntPtr userToken)
	{
	}

	private void CompleteCallback()
	{
	}
}
