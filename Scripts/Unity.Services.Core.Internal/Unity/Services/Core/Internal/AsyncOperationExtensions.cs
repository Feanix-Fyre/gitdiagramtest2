using System.Threading.Tasks;

namespace Unity.Services.Core.Internal;

internal static class AsyncOperationExtensions
{
	public static AsyncOperationAwaiter GetAwaiter(this IAsyncOperation self)
	{
		return default(AsyncOperationAwaiter);
	}

	public static Task AsTask(this IAsyncOperation self)
	{
		return null;
	}

	public static AsyncOperationAwaiter<T> GetAwaiter<T>(this IAsyncOperation<T> self)
	{
		return default(AsyncOperationAwaiter<T>);
	}

	public static Task<T> AsTask<T>(this IAsyncOperation<T> self)
	{
		return null;
	}
}
