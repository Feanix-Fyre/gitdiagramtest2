using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;

namespace System.Threading.Tasks;

[StructLayout((LayoutKind)3)]
[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder))]
public readonly struct ValueTask : IEquatable<ValueTask>
{
	private sealed class ValueTaskSourceAsTask : Task<VoidTaskResult>
	{
		private static readonly Action<object> s_completionAction;

		private IValueTaskSource _source;

		private readonly short _token;

		public ValueTaskSourceAsTask(IValueTaskSource source, short token)
		{
		}
	}

	private static readonly Task s_canceledTask;

	internal readonly object _obj;

	internal readonly short _token;

	internal readonly bool _continueOnCapturedContext;

	internal static Task CompletedTask => null;

	public bool IsCompleted
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ValueTask(Task task)
	{
		_obj = null;
		_token = 0;
		_continueOnCapturedContext = false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ValueTask(IValueTaskSource source, short token)
	{
		_obj = null;
		_token = 0;
		_continueOnCapturedContext = false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private ValueTask(object obj, short token, bool continueOnCapturedContext)
	{
		_obj = null;
		_token = 0;
		_continueOnCapturedContext = false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(ValueTask other)
	{
		return false;
	}

	public Task AsTask()
	{
		return null;
	}

	private Task GetTaskForValueTaskSource(IValueTaskSource t)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[StackTraceHidden]
	internal void ThrowIfCompletedUnsuccessfully()
	{
	}

	public ValueTaskAwaiter GetAwaiter()
	{
		return default(ValueTaskAwaiter);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
	{
		return default(ConfiguredValueTaskAwaitable);
	}
}
[StructLayout((LayoutKind)3)]
[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder<>))]
public readonly struct ValueTask<TResult> : IEquatable<ValueTask<TResult>>
{
	private sealed class ValueTaskSourceAsTask : Task<TResult>
	{
		private static readonly Action<object> s_completionAction;

		private IValueTaskSource<TResult> _source;

		private readonly short _token;

		public ValueTaskSourceAsTask(IValueTaskSource<TResult> source, short token)
		{
		}
	}

	private static Task<TResult> s_canceledTask;

	internal readonly object _obj;

	internal readonly TResult _result;

	internal readonly short _token;

	internal readonly bool _continueOnCapturedContext;

	public bool IsCompleted
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return false;
		}
	}

	public bool IsCompletedSuccessfully
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return false;
		}
	}

	public TResult Result
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(TResult);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ValueTask(TResult result)
	{
		_obj = null;
		_result = default(TResult);
		_token = 0;
		_continueOnCapturedContext = false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ValueTask(Task<TResult> task)
	{
		_obj = null;
		_result = default(TResult);
		_token = 0;
		_continueOnCapturedContext = false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ValueTask(IValueTaskSource<TResult> source, short token)
	{
		_obj = null;
		_result = default(TResult);
		_token = 0;
		_continueOnCapturedContext = false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private ValueTask(object obj, TResult result, short token, bool continueOnCapturedContext)
	{
		_obj = null;
		_result = default(TResult);
		_token = 0;
		_continueOnCapturedContext = false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(ValueTask<TResult> other)
	{
		return false;
	}

	public Task<TResult> AsTask()
	{
		return null;
	}

	private Task<TResult> GetTaskForValueTaskSource(IValueTaskSource<TResult> t)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ValueTaskAwaiter<TResult> GetAwaiter()
	{
		return default(ValueTaskAwaiter<TResult>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
	{
		return default(ConfiguredValueTaskAwaitable<TResult>);
	}

	public override string ToString()
	{
		return null;
	}
}
