using System.Runtime.CompilerServices;

namespace System.Threading.Tasks;

internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem
{
	private readonly ExecutionContext m_capturedContext;

	protected readonly Action m_action;

	private static ContextCallback s_invokeActionCallback;

	internal static bool IsValidLocationForInlining => false;

	internal AwaitTaskContinuation(Action action, bool flowExecutionContext)
	{
	}

	protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler)
	{
		return null;
	}

	internal override void Run(Task ignored, bool canInlineContinuationTask)
	{
	}

	void IThreadPoolWorkItem.ExecuteWorkItem()
	{
	}

	private static void InvokeAction(object state)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected static ContextCallback GetInvokeActionCallback()
	{
		return null;
	}

	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask)
	{
	}

	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask)
	{
	}

	internal static void UnsafeScheduleAction(Action action)
	{
	}

	protected static void ThrowAsyncIfNecessary(Exception exc)
	{
	}

	public void MarkAborted(ThreadAbortException e)
	{
	}
}
