using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

[StructLayout((LayoutKind)3)]
public readonly struct ConfiguredValueTaskAwaitable
{
	[StructLayout((LayoutKind)3)]
	public readonly struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly ValueTask _value;

		public bool IsCompleted
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ConfiguredValueTaskAwaiter(ValueTask value)
		{
			_value = default(ValueTask);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[StackTraceHidden]
		public void GetResult()
		{
		}

		public void UnsafeOnCompleted(Action continuation)
		{
		}
	}

	private readonly ValueTask _value;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ConfiguredValueTaskAwaitable(ValueTask value)
	{
		_value = default(ValueTask);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ConfiguredValueTaskAwaiter GetAwaiter()
	{
		return default(ConfiguredValueTaskAwaiter);
	}
}
[StructLayout((LayoutKind)3)]
public readonly struct ConfiguredValueTaskAwaitable<TResult>
{
	[StructLayout((LayoutKind)3)]
	public readonly struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly ValueTask<TResult> _value;

		public bool IsCompleted
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ConfiguredValueTaskAwaiter(ValueTask<TResult> value)
		{
			_value = default(ValueTask<TResult>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[StackTraceHidden]
		public TResult GetResult()
		{
			return default(TResult);
		}

		public void UnsafeOnCompleted(Action continuation)
		{
		}
	}

	private readonly ValueTask<TResult> _value;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ConfiguredValueTaskAwaitable(ValueTask<TResult> value)
	{
		_value = default(ValueTask<TResult>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ConfiguredValueTaskAwaiter GetAwaiter()
	{
		return default(ConfiguredValueTaskAwaiter);
	}
}
