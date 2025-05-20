using System.Runtime.CompilerServices;

namespace System.Threading.Tasks;

internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
{
	private static readonly SendOrPostCallback s_postCallback;

	private static ContextCallback s_postActionCallback;

	private readonly SynchronizationContext m_syncContext;

	internal SynchronizationContextAwaitTaskContinuation(SynchronizationContext context, Action action, bool flowExecutionContext)
		: base(null, flowExecutionContext: false)
	{
	}

	internal sealed override void Run(Task ignored, bool canInlineContinuationTask)
	{
	}

	private static void PostAction(object state)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static ContextCallback GetPostActionCallback()
	{
		return null;
	}
}
