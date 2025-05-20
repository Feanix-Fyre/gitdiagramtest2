namespace System.Linq.Expressions;

internal sealed class StackGuard
{
	private int _executionStackCount;

	public bool TryEnterOnCurrentStack()
	{
		return false;
	}

	public void RunOnEmptyStack<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
	{
	}

	private R RunOnEmptyStackCore<R>(Func<object, R> action, object state)
	{
		return default(R);
	}
}
