using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

internal static class AsyncTaskCache
{
	internal static readonly Task<bool> TrueTask;

	internal static readonly Task<bool> FalseTask;

	internal static readonly Task<int>[] Int32Tasks;

	private static Task<int>[] CreateInt32Tasks()
	{
		return null;
	}

	internal static Task<TResult> CreateCacheableTask<TResult>(TResult result)
	{
		return null;
	}
}
