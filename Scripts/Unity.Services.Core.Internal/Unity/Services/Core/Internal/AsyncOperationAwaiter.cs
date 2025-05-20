using System;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core.Internal;

internal struct AsyncOperationAwaiter : IAsyncOperationAwaiter, ICriticalNotifyCompletion, INotifyCompletion
{
	private IAsyncOperation m_Operation;

	public bool IsCompleted => false;

	public AsyncOperationAwaiter(IAsyncOperation asyncOperation)
	{
		m_Operation = null;
	}

	public void OnCompleted(Action continuation)
	{
	}

	public void UnsafeOnCompleted(Action continuation)
	{
	}

	public void GetResult()
	{
	}
}
internal struct AsyncOperationAwaiter<T> : IAsyncOperationAwaiter<T>, ICriticalNotifyCompletion, INotifyCompletion
{
	private IAsyncOperation<T> m_Operation;

	public bool IsCompleted => false;

	public AsyncOperationAwaiter(IAsyncOperation<T> asyncOperation)
	{
		m_Operation = null;
	}

	public void OnCompleted(Action continuation)
	{
	}

	public void UnsafeOnCompleted(Action continuation)
	{
	}

	public T GetResult()
	{
		return default(T);
	}
}
