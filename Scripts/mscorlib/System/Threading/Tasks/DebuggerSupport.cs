using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Internal.Runtime.Augments;

namespace System.Threading.Tasks;

internal static class DebuggerSupport
{
	private static readonly LowLevelDictionary<int, Task> s_activeTasks;

	private static readonly object s_activeTasksLock;

	public static bool LoggingOn => false;

	public static void TraceOperationCreation(CausalityTraceLevel traceLevel, Task task, string operationName, ulong relatedContext)
	{
	}

	public static void TraceOperationCompletion(CausalityTraceLevel traceLevel, Task task, AsyncStatus status)
	{
	}

	public static void TraceOperationRelation(CausalityTraceLevel traceLevel, Task task, CausalityRelation relation)
	{
	}

	public static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, Task task, CausalitySynchronousWork work)
	{
	}

	public static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void AddToActiveTasks(Task task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void AddToActiveTasksNonInlined(Task task)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void RemoveFromActiveTasks(Task task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void RemoveFromActiveTasksNonInlined(Task task)
	{
	}
}
