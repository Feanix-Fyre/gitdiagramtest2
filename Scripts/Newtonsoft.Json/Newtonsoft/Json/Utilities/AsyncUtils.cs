using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Utilities;

internal static class AsyncUtils
{
	public static readonly Task<bool> False;

	public static readonly Task<bool> True;

	internal static readonly Task CompletedTask;

	internal static Task<bool> ToAsync(this bool value)
	{
		return null;
	}

	public static Task? CancelIfRequestedAsync(this CancellationToken cancellationToken)
	{
		return null;
	}

	public static Task<T?>? CancelIfRequestedAsync<T>(this CancellationToken cancellationToken)
	{
		return null;
	}

	public static Task FromCanceled(this CancellationToken cancellationToken)
	{
		return null;
	}

	public static Task<T> FromCanceled<T>(this CancellationToken cancellationToken) where T : notnull
	{
		return null;
	}

	public static Task WriteAsync(this TextWriter writer, char value, CancellationToken cancellationToken)
	{
		return null;
	}

	public static Task WriteAsync(this TextWriter writer, string? value, CancellationToken cancellationToken)
	{
		return null;
	}

	public static Task WriteAsync(this TextWriter writer, char[] value, int start, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public static Task<int> ReadAsync(this TextReader reader, char[] buffer, int index, int count, CancellationToken cancellationToken)
	{
		return null;
	}

	public static bool IsCompletedSuccessfully(this Task task)
	{
		return false;
	}
}
