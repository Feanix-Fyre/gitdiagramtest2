using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.ExceptionServices;

namespace System.Threading.Tasks;

internal class TaskExceptionHolder
{
	private static readonly bool s_failFastOnUnobservedException;

	private readonly Task m_task;

	private LowLevelListWithIList<ExceptionDispatchInfo> m_faultExceptions;

	private ExceptionDispatchInfo m_cancellationException;

	private bool m_isHandled;

	internal bool ContainsFaultList => false;

	internal TaskExceptionHolder(Task task)
	{
	}

	private static bool ShouldFailFastOnUnobservedException()
	{
		return false;
	}

	~TaskExceptionHolder()
	{
	}

	internal void Add(object exceptionObject, bool representsCancellation)
	{
	}

	private void SetCancellationException(object exceptionObject)
	{
	}

	private void AddFaultException(object exceptionObject)
	{
	}

	private void MarkAsUnhandled()
	{
	}

	internal void MarkAsHandled(bool calledFromFinalizer)
	{
	}

	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException)
	{
		return null;
	}

	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
	{
		return null;
	}

	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
	{
		return null;
	}
}
