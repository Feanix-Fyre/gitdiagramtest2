namespace System.Threading.Tasks;

internal static class TaskToApm
{
	private sealed class TaskWrapperAsyncResult : IAsyncResult
	{
		internal readonly Task Task;

		private readonly object _state;

		private readonly bool _completedSynchronously;

		object IAsyncResult.AsyncState => null;

		bool IAsyncResult.CompletedSynchronously => false;

		bool IAsyncResult.IsCompleted => false;

		WaitHandle IAsyncResult.AsyncWaitHandle => null;

		internal TaskWrapperAsyncResult(Task task, object state, bool completedSynchronously)
		{
		}
	}

	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state)
	{
		return null;
	}

	public static void End(IAsyncResult asyncResult)
	{
	}

	public static TResult End<TResult>(IAsyncResult asyncResult)
	{
		return default(TResult);
	}

	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult)
	{
	}
}
