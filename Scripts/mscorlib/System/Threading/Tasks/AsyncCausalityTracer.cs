using System.Runtime.CompilerServices;

namespace System.Threading.Tasks;

[FriendAccessAllowed]
internal static class AsyncCausalityTracer
{
	[FriendAccessAllowed]
	internal static bool LoggingOn
	{
		[FriendAccessAllowed]
		get
		{
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[FriendAccessAllowed]
	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[FriendAccessAllowed]
	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
	{
	}
}
