namespace System.Threading;

internal class ThreadHelper
{
	private Delegate _start;

	private object _startArg;

	private ExecutionContext _executionContext;

	internal static ContextCallback _ccb;

	internal ThreadHelper(Delegate start)
	{
	}

	internal void SetExecutionContextHelper(ExecutionContext ec)
	{
	}

	private static void ThreadStart_Context(object state)
	{
	}

	internal void ThreadStart(object obj)
	{
	}

	internal void ThreadStart()
	{
	}
}
