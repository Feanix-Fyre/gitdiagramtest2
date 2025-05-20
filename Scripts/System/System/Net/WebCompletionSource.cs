using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Net;

internal class WebCompletionSource<T>
{
	internal enum Status
	{
		Running = 0,
		Completed = 1,
		Canceled = 2,
		Faulted = 3
	}

	internal class Result
	{
		public Status Status { get; }

		public bool Success => false;

		public ExceptionDispatchInfo Error { get; }

		public T Argument { get; }

		public Result(T argument)
		{
		}

		public Result(Status state, ExceptionDispatchInfo error)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CWaitForCompletion_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public WebCompletionSource<T> _003C_003E4__this;

		private ConfiguredTaskAwaitable<Result>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private TaskCompletionSource<Result> completion;

	private Result currentResult;

	internal Result CurrentResult => null;

	internal Task Task => null;

	public WebCompletionSource(bool runAsync = true)
	{
	}

	public bool TrySetCompleted(T argument)
	{
		return false;
	}

	public bool TrySetCompleted()
	{
		return false;
	}

	public bool TrySetCanceled()
	{
		return false;
	}

	public bool TrySetCanceled(OperationCanceledException error)
	{
		return false;
	}

	public bool TrySetException(Exception error)
	{
		return false;
	}

	public void ThrowOnError()
	{
	}

	[AsyncStateMachine(typeof(WebCompletionSource<>._003CWaitForCompletion_003Ed__15))]
	public Task<T> WaitForCompletion()
	{
		return null;
	}
}
internal class WebCompletionSource : WebCompletionSource<object>
{
	public WebCompletionSource()
		: base(runAsync: false)
	{
	}
}
