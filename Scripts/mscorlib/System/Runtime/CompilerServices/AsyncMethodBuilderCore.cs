using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

internal struct AsyncMethodBuilderCore
{
	internal sealed class MoveNextRunner
	{
		private readonly ExecutionContext m_context;

		internal IAsyncStateMachine m_stateMachine;

		private static ContextCallback s_invokeMoveNext;

		internal MoveNextRunner(ExecutionContext context, IAsyncStateMachine stateMachine)
		{
		}

		internal void Run()
		{
		}

		private static void InvokeMoveNext(object stateMachine)
		{
		}
	}

	private class ContinuationWrapper
	{
		internal readonly Action m_continuation;

		private readonly Action m_invokeAction;

		internal readonly Task m_innerTask;

		internal ContinuationWrapper(Action continuation, Action invokeAction, Task innerTask)
		{
		}

		internal void Invoke()
		{
		}
	}

	internal IAsyncStateMachine m_stateMachine;

	internal Action m_defaultContextAction;

	public void SetStateMachine(IAsyncStateMachine stateMachine)
	{
	}

	internal Action GetCompletionAction(Task taskForTracing, ref MoveNextRunner runnerToInitialize)
	{
		return null;
	}

	private Action OutputAsyncCausalityEvents(Task innerTask, Action continuation)
	{
		return null;
	}

	internal void PostBoxInitialization(IAsyncStateMachine stateMachine, MoveNextRunner runner, Task builtTask)
	{
	}

	internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext)
	{
	}

	internal static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask = null)
	{
		return null;
	}

	internal static Task TryGetContinuationTask(Action action)
	{
		return null;
	}
}
