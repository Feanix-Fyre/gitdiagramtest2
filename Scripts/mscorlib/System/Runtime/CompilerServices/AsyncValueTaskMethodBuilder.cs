using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

[StructLayout((LayoutKind)3)]
public struct AsyncValueTaskMethodBuilder
{
	private AsyncTaskMethodBuilder _methodBuilder;

	private bool _haveResult;

	private bool _useBuilder;
}
[StructLayout((LayoutKind)3)]
public struct AsyncValueTaskMethodBuilder<TResult>
{
	private AsyncTaskMethodBuilder<TResult> _methodBuilder;

	private TResult _result;

	private bool _haveResult;

	private bool _useBuilder;

	public ValueTask<TResult> Task => default(ValueTask<TResult>);

	public static AsyncValueTaskMethodBuilder<TResult> Create()
	{
		return default(AsyncValueTaskMethodBuilder<TResult>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
	{
	}

	public void SetStateMachine(IAsyncStateMachine stateMachine)
	{
	}

	public void SetResult(TResult result)
	{
	}

	public void SetException(Exception exception)
	{
	}

	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
	{
	}
}
