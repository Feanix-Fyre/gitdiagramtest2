using System.Runtime.CompilerServices;

namespace System.Threading.Tasks;

internal readonly struct ForceAsyncAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	private readonly Task _task;

	public bool IsCompleted => false;

	internal ForceAsyncAwaiter(Task task)
	{
		_task = null;
	}

	public ForceAsyncAwaiter GetAwaiter()
	{
		return default(ForceAsyncAwaiter);
	}

	public void GetResult()
	{
	}

	public void UnsafeOnCompleted(Action action)
	{
	}
}
