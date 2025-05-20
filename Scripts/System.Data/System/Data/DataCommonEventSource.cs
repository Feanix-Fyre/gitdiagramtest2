using System.Diagnostics.Tracing;

namespace System.Data;

[EventSource(Name = "System.Data.DataCommonEventSource")]
internal class DataCommonEventSource : EventSource
{
	internal static readonly DataCommonEventSource Log;

	private static long s_nextScopeId;

	[Event(1, Level = EventLevel.Informational)]
	internal void Trace(string message)
	{
	}

	[NonEvent]
	internal void Trace<T0>(string format, T0 arg0)
	{
	}

	[NonEvent]
	internal void Trace<T0, T1>(string format, T0 arg0, T1 arg1)
	{
	}

	[NonEvent]
	internal void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2)
	{
	}

	[NonEvent]
	internal void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
	{
	}

	[NonEvent]
	internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
	{
	}

	[NonEvent]
	internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
	{
	}

	[Event(2, Level = EventLevel.Verbose)]
	internal long EnterScope(string message)
	{
		return 0L;
	}

	[NonEvent]
	internal long EnterScope<T1>(string format, T1 arg1)
	{
		return 0L;
	}

	[NonEvent]
	internal long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2)
	{
		return 0L;
	}

	[NonEvent]
	internal long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3)
	{
		return 0L;
	}

	[NonEvent]
	internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
	{
		return 0L;
	}

	[Event(3, Level = EventLevel.Verbose)]
	internal void ExitScope(long scopeId)
	{
	}
}
